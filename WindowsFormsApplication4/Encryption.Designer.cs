namespace WindowsFormsApplication4
{
    partial class Encryption
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCover = new System.Windows.Forms.Button();
            this.Encrypt_image = new System.Windows.Forms.PictureBox();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPatchSize = new System.Windows.Forms.TextBox();
            this.txtSharePatches = new System.Windows.Forms.TextBox();
            this.txtPatches = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.txtShares = new System.Windows.Forms.TextBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnGenerateSlides = new System.Windows.Forms.Button();
            this.btnSaveSlides = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.Encrypt_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(122, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Browse Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCover
            // 
            this.btnCover.Location = new System.Drawing.Point(173, 12);
            this.btnCover.Name = "btnCover";
            this.btnCover.Size = new System.Drawing.Size(116, 23);
            this.btnCover.TabIndex = 1;
            this.btnCover.Text = "Browse Cover";
            this.btnCover.UseVisualStyleBackColor = true;
            this.btnCover.Click += new System.EventHandler(this.btnCover_Click);
            // 
            // Encrypt_image
            // 
            this.Encrypt_image.Location = new System.Drawing.Point(13, 64);
            this.Encrypt_image.Name = "Encrypt_image";
            this.Encrypt_image.Size = new System.Drawing.Size(100, 50);
            this.Encrypt_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Encrypt_image.TabIndex = 2;
            this.Encrypt_image.TabStop = false;
            // 
            // picCover
            // 
            this.picCover.Location = new System.Drawing.Point(189, 64);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(100, 50);
            this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCover.TabIndex = 3;
            this.picCover.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patch Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Slides";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Columns";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rows";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total Patches";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Patches/Slides:";
            // 
            // txtPatchSize
            // 
            this.txtPatchSize.Location = new System.Drawing.Point(105, 149);
            this.txtPatchSize.Name = "txtPatchSize";
            this.txtPatchSize.Size = new System.Drawing.Size(100, 20);
            this.txtPatchSize.TabIndex = 10;
            this.txtPatchSize.Text = "1";
            // 
            // txtSharePatches
            // 
            this.txtSharePatches.Location = new System.Drawing.Point(333, 252);
            this.txtSharePatches.Name = "txtSharePatches";
            this.txtSharePatches.Size = new System.Drawing.Size(100, 20);
            this.txtSharePatches.TabIndex = 11;
            // 
            // txtPatches
            // 
            this.txtPatches.Location = new System.Drawing.Point(105, 245);
            this.txtPatches.Name = "txtPatches";
            this.txtPatches.Size = new System.Drawing.Size(100, 20);
            this.txtPatches.TabIndex = 12;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(333, 205);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 20);
            this.txtRows.TabIndex = 13;
            // 
            // txtCols
            // 
            this.txtCols.Location = new System.Drawing.Point(105, 189);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(100, 20);
            this.txtCols.TabIndex = 14;
            // 
            // txtShares
            // 
            this.txtShares.Location = new System.Drawing.Point(333, 149);
            this.txtShares.Name = "txtShares";
            this.txtShares.Size = new System.Drawing.Size(100, 20);
            this.txtShares.TabIndex = 15;
            this.txtShares.Text = "10";
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(561, 13);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(321, 455);
            this.pnl.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // btnGenerateSlides
            // 
            this.btnGenerateSlides.Location = new System.Drawing.Point(40, 309);
            this.btnGenerateSlides.Name = "btnGenerateSlides";
            this.btnGenerateSlides.Size = new System.Drawing.Size(144, 23);
            this.btnGenerateSlides.TabIndex = 17;
            this.btnGenerateSlides.Text = "Generate Slides";
            this.btnGenerateSlides.UseVisualStyleBackColor = true;
            this.btnGenerateSlides.Click += new System.EventHandler(this.btnGenerateSlides_Click);
            // 
            // btnSaveSlides
            // 
            this.btnSaveSlides.Location = new System.Drawing.Point(38, 364);
            this.btnSaveSlides.Name = "btnSaveSlides";
            this.btnSaveSlides.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSlides.TabIndex = 18;
            this.btnSaveSlides.Text = "Save Slides";
            this.btnSaveSlides.UseVisualStyleBackColor = true;
            this.btnSaveSlides.Click += new System.EventHandler(this.btnSaveSlides_Click);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(40, 339);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(100, 23);
            this.pb.TabIndex = 19;
            // 
            // Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 534);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnSaveSlides);
            this.Controls.Add(this.btnGenerateSlides);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.txtShares);
            this.Controls.Add(this.txtCols);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.txtPatches);
            this.Controls.Add(this.txtSharePatches);
            this.Controls.Add(this.txtPatchSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCover);
            this.Controls.Add(this.Encrypt_image);
            this.Controls.Add(this.btnCover);
            this.Controls.Add(this.btnLoad);
            this.Name = "Encryption";
            this.Text = "Encryption";
            ((System.ComponentModel.ISupportInitialize)(this.Encrypt_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCover;
        private System.Windows.Forms.PictureBox Encrypt_image;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPatchSize;
        private System.Windows.Forms.TextBox txtSharePatches;
        private System.Windows.Forms.TextBox txtPatches;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.TextBox txtShares;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnGenerateSlides;
        private System.Windows.Forms.Button btnSaveSlides;
        private System.Windows.Forms.ProgressBar pb;
    }
}