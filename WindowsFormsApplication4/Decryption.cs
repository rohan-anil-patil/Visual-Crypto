using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Decryption : Form
    {
        int TotalSlides;
        Bitmap ImgSlide;

        Bitmap ImgCover;

        Bitmap ImgStacked;

        int CC = 0;
        int Y = 0;
        int X = 0;

        public Decryption()
        {
            InitializeComponent();
            stack.Enabled = false;
        }

        private void open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Slides";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();
        }

        private void stack_Click(object sender, EventArgs e)
        {
            int SlideNo = 0;
            foreach (string Img in openFileDialog1.FileNames)
            {
                if (!Img.Contains("_")) continue;

                SlideNo++;
                txtSlide.Text = "" + SlideNo;
                lblFile.Text = Path.GetFileName(Img);

                ImgSlide = new Bitmap(Img);
                pb.Image = ImgSlide;

                Application.DoEvents();


                progress.Minimum = 0;
                progress.Maximum = ImgSlide.Width * ImgSlide.Height;
                progress.Value = 0;

                for (int x = 0; x < ImgSlide.Width; x++)
                {
                    for (int y = 0; y < ImgSlide.Height; y++)
                    {
                        Color CS = ImgSlide.GetPixel(x, y);
                        Color CV = ImgCover.GetPixel(x, y);

                        Color C = Color.FromArgb(CS.R ^ CV.R, CS.G ^ CV.G, CS.B ^ CV.B);
                        ImgSlide.SetPixel(x, y, Color.FromArgb(C.R, C.G, C.B));

                        Color CI = ImgStacked.GetPixel(x, y);
                        ImgStacked.SetPixel(x, y, Color.FromArgb(C.R | CI.R, C.G | CI.G, C.B | CI.B));


                        progress.Value++;

                    }
                }

                PictureBox pb1 = new PictureBox();
                pb1.Location = new Point(X, Y);
                pb1.Height = 300;
                pb1.Width = 300;
                pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                pb1.BackColor = Color.White;
                pb1.Image = ImgSlide;

                pnl.Controls.Add(pb1);


                CC++;
                if (CC == 1)
                {
                    X = 0; Y += pb1.Height + 10;
                    CC = 0;
                }
                else X += pb1.Width + 10;

                picstack.Image = ImgStacked;



            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            TotalSlides = openFileDialog1.FileNames.Length - 1;
            txtSlides.Text = "" + TotalSlides;


            foreach (string Img in openFileDialog1.FileNames)
            {
                if (!Img.Contains("_"))
                {
                    ImgCover = new Bitmap(Img);
                    break;
                }
            }

            ImgStacked = new Bitmap(ImgCover.Width, ImgCover.Height);
            stack.Enabled = true;

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ImgStacked.Save(saveFileDialog1.FileName, ImageFormat.Png);
        }
    }
}
