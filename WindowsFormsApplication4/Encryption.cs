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
    public partial class Encryption : Form
    {
        int TotalSlides;

        Bitmap ImgOriginal;

        Bitmap[] Slides;

        int BlockSize;

        int Rows;
        int Cols;
        int Patches;
        int SlidesTotalPatches;

        int[,] PatchXY;

        int[] PatchesIDX;
        int[] PatchesRandomIDX;
        Bitmap ImgCover;
        public Encryption()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Browse Image";
            openFileDialog1.ShowDialog();
        }

        private void btnCover_Click(object sender, EventArgs e)
        {
            openFileDialog2.Title = "Open Cover";
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            ImgOriginal = new Bitmap(openFileDialog1.FileName);
            Encrypt_image.Image = ImgOriginal;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = Path.GetFileNameWithoutExtension(saveFileDialog1.FileName);
            string filePath = saveFileDialog1.FileName;
            string savePath = fileName;
            for (int i = 0; i < Slides.Length; i++)
            {
                savePath = filePath.Replace(fileName, fileName + "_" + i);
                Slides[i].Save(savePath, ImageFormat.Png);
                ImgCover.Save(saveFileDialog1.FileName);
            }

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            ImgCover = new Bitmap(openFileDialog2.FileName);
            picCover.Image = ImgCover;
        }

        private void btnSaveSlides_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void btnGenerateSlides_Click(object sender, EventArgs e)
        {
            Detail();
            Slice();
            UpdatePanel();

        }
        private void Detail()
        {

            BlockSize = int.Parse(txtPatchSize.Text);
            TotalSlides = int.Parse(txtShares.Text);


            Rows = ImgOriginal.Height / BlockSize;
            txtRows.Text = "" + Rows;


            Cols = ImgOriginal.Width / BlockSize;
            txtCols.Text = "" + Cols;


            Patches = Rows * Cols;
            txtPatches.Text = "" + Patches;



            SlidesTotalPatches = Patches / TotalSlides;
            txtSharePatches.Text = "" + SlidesTotalPatches;


            PatchesIDX = new int[Patches];
            for (int idx = 0; idx < Patches; idx++)
            {
                PatchesIDX[idx] = idx;
            }


            Slides = new Bitmap[TotalSlides];
            for (int idx = 0; idx < TotalSlides; idx++)
            {
                Slides[idx] = new Bitmap(Cols * BlockSize, Rows * BlockSize);
                Slides[idx] = (Bitmap)ImgCover.Clone();
            }



            PatchXY = new int[Patches, 2];
            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < Cols; c++)
                {
                    PatchXY[(r * Cols) + c, 0] = c * BlockSize;
                    PatchXY[(r * Cols) + c, 1] = r * BlockSize;
                }
            }
        }

        private void Slice()
        {
            pb.Minimum = 0;
            pb.Maximum = Patches - 1;

            Random rnd = new Random();
            PatchesRandomIDX = PatchesIDX.OrderBy(x => rnd.Next()).ToArray();


            int SlideNo = 0;
            for (int idx = 0; idx < Patches; idx++)
            {

                pb.Value = idx;
                for (int x = PatchXY[PatchesRandomIDX[idx], 0]; x < PatchXY[PatchesRandomIDX[idx], 0] + BlockSize; x++)
                {
                    for (int y = PatchXY[PatchesRandomIDX[idx], 1]; y < PatchXY[PatchesRandomIDX[idx], 1] + BlockSize; y++)
                    {
                        Color C = ImgOriginal.GetPixel(x, y);
                        Color CS = ImgCover.GetPixel(x, y);

                        Slides[SlideNo].SetPixel(x, y, Color.FromArgb(C.R ^ CS.R, C.G ^ CS.G, C.B ^ CS.B));

                    }
                }
                SlideNo++;
                if (SlideNo == TotalSlides) SlideNo = 0;
            }

        }

        void UpdatePanel()
        {
            int CC = 0;
            int Y = 0;
            int X = 0;

            pnl.Controls.Clear();

            for (int idx = 0; idx < TotalSlides; idx++)
            {
                PictureBox PI = new PictureBox();
                PI.Location = new Point(X, Y);
                PI.Height = 300;
                PI.Width = 300;
                PI.SizeMode = PictureBoxSizeMode.StretchImage;
                PI.BackColor = Color.White;
                PI.Image = Slides[idx];

                pnl.Controls.Add(PI);

                CC++;
                if (CC == 2)
                {
                    X = 0; Y += PI.Height + 10;
                    CC = 0;
                }
                else X += PI.Width + 10;
            }
        }


    }
}
