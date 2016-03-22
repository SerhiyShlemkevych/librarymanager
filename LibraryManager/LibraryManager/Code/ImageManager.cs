using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace LibraryManager
{
    public static class ImageManager
    {
        public static byte[] ImageToByteArray(Image image)
        {
            if (image == null)
            {
                throw new Exception("There is no image");
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {                
                image.Save(memoryStream, image.RawFormat);
                byte[] imageByte = memoryStream.GetBuffer();
                return imageByte;
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(byteArrayIn);

            return img;
        }
    }
}
