namespace WindowsFormsApplication4
{
    partial class Decryption
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
            this.open = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.stack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtSlides = new System.Windows.Forms.TextBox();
            this.txtSlide = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.picstack = new System.Windows.Forms.PictureBox();
            this.pnl = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picstack)).BeginInit();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(27, 12);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(75, 23);
            this.open.TabIndex = 0;
            this.open.Text = "Open Slides";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(27, 68);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(100, 50);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 1;
            this.pb.TabStop = false;
            // 
            // stack
            // 
            this.stack.Location = new System.Drawing.Point(27, 155);
            this.stack.Name = "stack";
            this.stack.Size = new System.Drawing.Size(75, 23);
            this.stack.TabIndex = 2;
            this.stack.Text = "Stack Slides";
            this.stack.UseVisualStyleBackColor = true;
            this.stack.Click += new System.EventHandler(this.stack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Stacked Slides:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Slide:";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(33, 271);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(56, 13);
            this.lblFile.TabIndex = 10;
            this.lblFile.Text = "XXXXXXX";
            // 
            // txtSlides
            // 
            this.txtSlides.Location = new System.Drawing.Point(142, 194);
            this.txtSlides.Name = "txtSlides";
            this.txtSlides.Size = new System.Drawing.Size(100, 20);
            this.txtSlides.TabIndex = 6;
            // 
            // txtSlide
            // 
            this.txtSlide.Location = new System.Drawing.Point(142, 232);
            this.txtSlide.Name = "txtSlide";
            this.txtSlide.Size = new System.Drawing.Size(100, 20);
            this.txtSlide.TabIndex = 7;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(36, 299);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 11;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(36, 344);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(100, 23);
            this.progress.TabIndex = 12;
            // 
            // picstack
            // 
            this.picstack.Location = new System.Drawing.Point(268, 32);
            this.picstack.Name = "picstack";
            this.picstack.Size = new System.Drawing.Size(175, 296);
            this.picstack.TabIndex = 13;
            this.picstack.TabStop = false;
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(520, 32);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(200, 296);
            this.pnl.TabIndex = 14;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Decryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 389);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.picstack);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.save);
            this.Controls.Add(this.txtSlide);
            this.Controls.Add(this.txtSlides);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stack);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.open);
            this.Name = "Decryption";
            this.Text = "Decryption";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picstack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button stack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtSlides;
        private System.Windows.Forms.TextBox txtSlide;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.PictureBox picstack;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}