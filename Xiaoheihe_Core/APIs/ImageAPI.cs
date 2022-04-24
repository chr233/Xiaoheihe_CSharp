using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using COSXML;
using COSXML.Auth;
using COSXML.Model.Object;
using COSXML.Model.Bucket;
using COSXML.CosException;

using Xiaoheihe_Core.Data;
using COSXML.Transfer;

namespace Xiaoheihe_Core.APIs
{
    public static class ImageAPI
    {
        internal static CosXmlConfig config { get; } = new CosXmlConfig.Builder()
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
        private static ImageUploadInfoResponse? GetUploadImageInfo(this XiaoheiheClient xhh, string imgPath)
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

            ImageUploadInfoResponse response = xhh.BasicRequest<ImageUploadInfoResponse>(HttpMethod.Post, subPath, content);

            return response;
        }

        /// <summary>
        /// 获取CosToken
        /// </summary>
        /// <param name="xhh"></param>
        /// <returns></returns>
        private static ImageUploadTokenResponse GetUploadCosToken(this XiaoheiheClient xhh)
        {
            string subPath = "/bbs/app/api/qcloud/cos/upload/token";

            ImageUploadTokenResponse response = xhh.BasicRequest<ImageUploadTokenResponse>(HttpMethod.Get, subPath);

            return response;
        }

        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="xhh"></param>
        /// <param name="imgPath"></param>
        /// <returns></returns>
        public static string? UploadImage(this XiaoheiheClient xhh, string imgPath)
        {
            if (!File.Exists(imgPath))
            {
                return null;
            }

            ImageUploadInfoResponse? uploadInfo = xhh.GetUploadImageInfo(imgPath);

            ImageUploadTokenResponse cosToken = xhh.GetUploadCosToken();

            if (uploadInfo == null || uploadInfo.Result == null || uploadInfo.Result.Keys.Count == 0 || cosToken.Result == null)
            {
                return null;
            }

            CredentialsData? credentials = cosToken.Result.Credentials;

            long timeStamp = new DateTimeOffset(cosToken.Result.ExpiredTime).ToUnixTimeSeconds();

            QCloudCredentialProvider cosCredentialProvider = new DefaultSessionQCloudCredentialProvider(credentials.TmpSecretId, credentials.TmpSecretKey, timeStamp, credentials.SessionToken);

            CosXml cosXml = new CosXmlServer(config, cosCredentialProvider);

            TransferManager transferManager = new(cosXml, new TransferConfig());

            string bucket = uploadInfo.Result.Bucket;
            string cosPath = uploadInfo.Result.Keys.First();
            string srcPath = imgPath;

            COSXMLUploadTask uploadTask = new(bucket, cosPath);

            uploadTask.SetSrcPath(srcPath);

            try
            {
                COSXMLUploadTask.UploadTaskResult result = transferManager.UploadAsync(uploadTask).Result;
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
