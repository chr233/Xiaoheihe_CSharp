using System.Drawing;
using COSXML;
using COSXML.Auth;
using COSXML.Transfer;
using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class ImageAPI
    {
        internal static CosXmlConfig CosConfig { get; } = new CosXmlConfig.Builder()
            .IsHttps(true).SetRegion("ap-shanghai").SetDebugLog(false).Build();

        /// <summary>
        /// 生成图片信息
        /// </summary>
        /// <param name="imgPath"></param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:验证平台兼容性", Justification = "<挂起>")]
        private static ImageInfo? PrepareImageInfo(string imgPath)
        {
            if (!File.Exists(imgPath))
            {
                return null;
            }

            FileInfo fileinfo = new(imgPath);

            Image image = Image.FromFile(imgPath);

            ImageInfo imageInfo = new()
            {
                Height = image.Height,
                Width = image.Width,
                Size = fileinfo.Length,
                ImageType = fileinfo.Extension[1..]
            };
            return imageInfo;
        }

        /// <summary>
        /// 获取图片上传位置
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="imgPath"></param>
        /// <returns></returns>
        private static async Task<ImageUploadInfoResponse?> GetUploadImageInfo(this XiaoheiheClient xhh, string imgPath)
        {
            string subPath = "/bbs/app/api/qcloud/cos/upload/info";

            ImageInfo? imageInfo = PrepareImageInfo(imgPath);

            if (imageInfo == null)
            {
                return null;
            }

            Dictionary<string, string> formData = new(2)
            {
                { "file_infos", imageInfo.Package() },
                { "scope", "bbs" },
            };

            FormUrlEncodedContent content = new(formData);

            ImageUploadInfoResponse response =await xhh.BasicRequest<ImageUploadInfoResponse>(HttpMethod.Post, subPath, content).ConfigureAwait(false);

            return response;
        }

        /// <summary>
        /// 获取CosToken
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        private static async Task<ImageUploadTokenResponse> GetUploadCosToken(this XiaoheiheClient xhh)
        {
            string subPath = "/bbs/app/api/qcloud/cos/upload/token";

            ImageUploadTokenResponse response = await xhh.BasicRequest<ImageUploadTokenResponse>(HttpMethod.Get, subPath).ConfigureAwait(false);

            return response;
        }

        /// <summary>
        /// 上传图片, 成功返回图片Uri, 失败返回null
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="imgPath"></param>
        /// <returns></returns>
        public static async Task<string?> UploadImage(this XiaoheiheClient xhh, string imgPath)
        {
            if (!File.Exists(imgPath))
            {
                return null;
            }

            ImageUploadInfoResponse? uploadInfo = await xhh.GetUploadImageInfo(imgPath).ConfigureAwait(false);

            ImageUploadTokenResponse cosToken = await xhh.GetUploadCosToken().ConfigureAwait(false);

            if (uploadInfo == null || uploadInfo.Result == null || uploadInfo.Result.Keys.Count == 0 || cosToken.Result == null)
            {
                return null;
            }

            CredentialsData? credentials = cosToken.Result.Credentials;

            long timeStamp = new DateTimeOffset(cosToken.Result.ExpiredTime).ToUnixTimeSeconds();

            QCloudCredentialProvider cosCredentialProvider = new DefaultSessionQCloudCredentialProvider(credentials.TmpSecretId, credentials.TmpSecretKey, timeStamp, credentials.SessionToken);

            CosXml cosXml = new CosXmlServer(CosConfig, cosCredentialProvider);

            TransferManager transferManager = new(cosXml, new TransferConfig());

            string bucket = uploadInfo.Result.Bucket;
            string cosPath = uploadInfo.Result.Keys.First();
            string srcPath = imgPath;

            COSXMLUploadTask uploadTask = new(bucket, cosPath);

            uploadTask.SetSrcPath(srcPath);

            try
            {
                COSXMLUploadTask.UploadTaskResult result = await transferManager.UploadAsync(uploadTask).ConfigureAwait(false);
                if (result.httpCode == 200)
                {
                    string dstUri = uploadInfo.Result.Host + cosPath;
                    return dstUri;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
