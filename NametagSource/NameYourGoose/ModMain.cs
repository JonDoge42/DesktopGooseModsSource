using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
// 1. Added the "GooseModdingAPI" project as a reference.
// 2. Compile this.
// 3. Create a folder with this DLL in the root, and *no GooseModdingAPI DLL*
using GooseShared;
using SamEngine;

//  PS, I coded this while sleep deprived so if you find anything wrong thats why.
//  --Shaggy

namespace NameYourGoose
{
    class Config
    {
        public string GooseName { get; set; }
        public string RGBHexcode { get; set; }
    }

    public class ModEntryPoint : IMod
    {
        Config config = new Config();

        private void CheckConfig()
        {
            string path = @"Assets\Mods\NameYourGooseConfig.txt";
            try
            {
                using (TextReader tr = new StreamReader(new FileStream(path, FileMode.Open)))
                {
                    string line;
                    while ((line = tr.ReadLine()) != null)
                    {
                        if (line.StartsWith("GooseName"))
                        {
                            int i = line.IndexOf("=") + 1;
                            string name = line.Substring(i, line.Length - i).Trim();
                            config.GooseName = name;
                        }


                        if (line.StartsWith("RGBHexcode"))
                        {
                            int i = line.IndexOf("=") + 1;
                            string hexcode = line.Substring(i, line.Length - i).Trim();
                            config.RGBHexcode = hexcode;
                        }
                    }
                }
            }
            catch
            {
                using (StreamWriter sw = (File.Exists(path)) ? File.AppendText(path) : File.CreateText(path))
                {
                    MessageBox.Show("The Name your Goose configuration file was not found.\nMaking the file now, please restart", "Mod Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    sw.WriteLine("GooseName=Hjonk Hjonk\nRGBHexcode=#21ffc0");
                }
            }
        }


        // Gets called automatically, passes in a class that contains pointers to
        // useful functions we need to interface with the goose.
        void IMod.Init()
        {
            CheckConfig();

            InjectionPoints.PostRenderEvent += PostRender;
        }


        public void PostRender(GooseEntity goose, Graphics g)
        {
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Font drawFont = new Font("Arial", 16, FontStyle.Bold);

            Color color = ColorTranslator.FromHtml(config.RGBHexcode);

            SolidBrush solidBrush = new SolidBrush(color);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            g.DrawString(config.GooseName, drawFont, solidBrush, new PointF(goose.rig.head1EndPoint.x, goose.rig.head1EndPoint.y - 50), stringFormat);
        }
    }
}
