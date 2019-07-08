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
                bmp.Save(@"C:\Users\Jama_yw17\source\repos\TcpServerToClientSendSS\TcpServerToClientSendSS\bin\Debug\" + "screenshot" + count.ToString() + ".png");  // saves the image
            }
            var source = @"C:\Users\Jama_yw17\source\repos\TcpServerToClientSendSS\TcpServerToClientSendSS\bin\Debug\" + "screenshot" + count.ToString() + ".png";
            return source;
        }
        //static void Main(string[] args)
        //{
        //    DateTime dateTime = DateTime.Now;
        //    for (int i = 0; i < 20; i++)
        //    {
        //        takeScreenShot(i);
        //    }
        //    DateTime dateTime2 = DateTime.Now;
        //    Console.WriteLine(dateTime2.Millisecond - dateTime.Millisecond);
        //}
    }
}
