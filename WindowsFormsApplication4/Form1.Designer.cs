namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.slicer = new System.Windows.Forms.Button();
            this.stacker = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SuspendLayout();
            // 
            // slicer
            // 
            this.slicer.Location = new System.Drawing.Point(21, 52);
            this.slicer.Name = "slicer";
            this.slicer.Size = new System.Drawing.Size(137, 44);
            this.slicer.TabIndex = 0;
            this.slicer.Text = "Slicer";
            this.slicer.UseVisualStyleBackColor = true;
            this.slicer.Click += new System.EventHandler(this.slicer_Click);
            // 
            // stacker
            // 
            this.stacker.Location = new System.Drawing.Point(229, 52);
            this.stacker.Name = "stacker";
            this.stacker.Size = new System.Drawing.Size(136, 45);
            this.stacker.TabIndex = 1;
            this.stacker.Text = "Stacker";
            this.stacker.UseVisualStyleBackColor = true;
            this.stacker.Click += new System.EventHandler(this.stacker_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1080, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 478);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stacker);
            this.Controls.Add(this.slicer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Visual cryptography";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button slicer;
        private System.Windows.Forms.Button stacker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

