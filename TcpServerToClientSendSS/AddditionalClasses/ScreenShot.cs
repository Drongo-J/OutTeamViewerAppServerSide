using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace TcpServerToClientSendSS.AddditionalClasses
{
   public class ScreenShot
    {
        public string TakeScreenShot(int count)
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                bmp.Save(@"C:\Users\Documents\source\repos\TspClientToServerSnedSS\TcpServerToClientSendSS\bin\Debug\" + "screenshot" + count.ToString() + ".png");  // saves the image
            }
            var source = @"C:\Users\Documents\source\repos\TspClientToServerSnedSS\TcpServerToClientSendSS\bin\Debug\" + "screenshot" + count.ToString() + ".png";
            return source;
        }

    }
}
