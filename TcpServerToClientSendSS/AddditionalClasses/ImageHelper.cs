using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpServerToClientSendSS.AddditionalClasses
{
    public class ImageHelper
    {

        public string GetImagePath(byte[] buffer, int counter)
        {
            ImageConverter ic = new ImageConverter();
            var data = ic.ConvertFrom(buffer);

            Image img = data as Image;
            if (img != null)
            {
                Bitmap bitmap1 = new Bitmap(img);
                bitmap1.Save($@"C:\Users\Documents\source\repos\TspClientToServerSnedSS\TcpServerToClientSendSS\bin\Debug\Images\image{counter}.png");
                var imagepath = $@"C:\Users\Documents\source\repos\TspClientToServerSnedSS\TcpServerToClientSendSS\bin\Debug\Images\image{counter}.png";
                return imagepath;
            }
            else
            {
                return String.Empty;
            }

        }
        public byte[] GetBytesOfImage(string path)
        {
            var image = new Bitmap(path);
            ImageConverter imageconverter = new ImageConverter();
            var imagebytes = ((byte[])imageconverter.ConvertTo(image, typeof(byte[])));
            return imagebytes;
        }
    }
}
