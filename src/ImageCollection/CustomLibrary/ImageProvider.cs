using System;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Net;
using PuzzleTag.SoundMaster;

namespace PuzzleTag.ImageCollection.CustomLibrary
{
    class ImageProvider
    {
        private int weidth = 190;
        private int height = 200;
        private UrlBuilder urlBuilder;

        public ImageProvider(string sourceServiceApiUrl)
        {
            this.urlBuilder = new UrlBuilder(sourceServiceApiUrl);
        }

        public ImageProvider SetDefaultSize(int weidth, int height)
        {
            this.weidth = weidth;
            this.height = height;

            this.urlBuilder.AddSection(this.weidth.ToString() + "x" + this.height.ToString());

            return this;
        }

        public Image RandomImage()
        {
            return GetImageByCategory("random");
        }

        public Image GetImageByCategory(string category)
        {
            return GetImageByCategories(new string[] { category });
        }

        public Image GetImageByCategories(string[] categories)
        {
            var url = GetUrl(categories);

            var request = Api.GetRequest(url);
            var response = Api.GetResponse(request);

            byte[] image = GetImage(response);
            var stream = new MemoryStream(image);

            try
            {
                Image imageFromStream = Image.FromStream(stream);
                
                SoundPlayer.PlayNewImageAddedSound();

                return imageFromStream;
            }
            catch (Exception e)
            {
                SoundPlayer.PlayFailedImageSound();
                return null;
            }
            finally
            {
                //stream.Close();
            }
        }

        private string GetUrl(string[] args = null)
        {
            var builtUrl = urlBuilder.AddParams(args).Build().Url;
            return builtUrl;
        }

        private byte[] GetImage(HttpWebResponse response)
        {
            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                    return null;
                using (var sr = new BinaryReader(dataStream))
                {
                    byte[] bytes = sr.ReadBytes(100000);

                    return bytes;
                }
            }

            return null;
        }
    }
}
