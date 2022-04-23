using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using Xiaoheihe_Core.Data;

namespace Xiaoheihe_Core.APIs
{
    public static class ImageAPI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:验证平台兼容性", Justification = "<挂起>")]
        private static ImageInfo? PrepareImageData(string imgPath)
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



        public static ImageUploadResponse? UploadImage(this XiaoheiheClient xhh, string imgPath)
        {
            string subPath = "/bbs/app/api/qcloud/cos/upload/info";

            ImageInfo? imageInfo = PrepareImageData(imgPath);

            if(imageInfo == null) { return null; }

            Dictionary<string, string> formData = new(2)
            {
                { "file_infos", imageInfo.Package() },
                { "scope", "bbs" },
            };

            FormUrlEncodedContent content = new(formData);

            ImageUploadResponse response = xhh.BasicRequest<ImageUploadResponse>(HttpMethod.Post, subPath, content);

            return response;
        }
    }
}
