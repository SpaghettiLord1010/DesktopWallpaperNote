
namespace DesktopWallpaperNote
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cg1 = new System.Windows.Forms.ColorDialog();
            this.cg2 = new System.Windows.Forms.ColorDialog();
            this.txtc = new System.Windows.Forms.ColorDialog();
            this.run = new System.Windows.Forms.Button();
            this.gc1_butt = new System.Windows.Forms.Button();
            this.gc2_butt = new System.Windows.Forms.Button();
            this.txtc_butt = new System.Windows.Forms.Button();
            this.img_textbox = new System.Windows.Forms.TextBox();
            this.filepath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.numupdownsize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownsize)).BeginInit();
            this.SuspendLayout();
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(12, 154);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(338, 45);
            this.run.TabIndex = 0;
            this.run.Text = "Save";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // gc1_butt
            // 
            this.gc1_butt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gc1_butt.Location = new System.Drawing.Point(12, 12);
            this.gc1_butt.Name = "gc1_butt";
            this.gc1_butt.Size = new System.Drawing.Size(338, 23);
            this.gc1_butt.TabIndex = 1;
            this.gc1_butt.Text = "Gradient Color 1";
            this.gc1_butt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gc1_butt.UseVisualStyleBackColor = true;
            this.gc1_butt.Click += new System.EventHandler(this.gc1_butt_Click);
            // 
            // gc2_butt
            // 
            this.gc2_butt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gc2_butt.Location = new System.Drawing.Point(12, 41);
            this.gc2_butt.Name = "gc2_butt";
            this.gc2_butt.Size = new System.Drawing.Size(338, 23);
            this.gc2_butt.TabIndex = 2;
            this.gc2_butt.Text = "Gradient Color 2";
            this.gc2_butt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gc2_butt.UseVisualStyleBackColor = true;
            this.gc2_butt.Click += new System.EventHandler(this.gc2_butt_Click);
            // 
            // txtc_butt
            // 
            this.txtc_butt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtc_butt.Location = new System.Drawing.Point(12, 70);
            this.txtc_butt.Name = "txtc_butt";
            this.txtc_butt.Size = new System.Drawing.Size(338, 23);
            this.txtc_butt.TabIndex = 3;
            this.txtc_butt.Text = "Text Color";
            this.txtc_butt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtc_butt.UseVisualStyleBackColor = true;
            this.txtc_butt.Click += new System.EventHandler(this.txtc_butt_Click);
            // 
            // img_textbox
            // 
            this.img_textbox.Location = new System.Drawing.Point(12, 99);
            this.img_textbox.Name = "img_textbox";
            this.img_textbox.Size = new System.Drawing.Size(240, 20);
            this.img_textbox.TabIndex = 4;
            // 
            // filepath
            // 
            this.filepath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.filepath.Location = new System.Drawing.Point(12, 125);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(338, 23);
            this.filepath.TabIndex = 5;
            this.filepath.Text = "Choose Filepath";
            this.filepath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filepath.UseVisualStyleBackColor = true;
            this.filepath.Click += new System.EventHandler(this.filepath_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyPictures;
            // 
            // numupdownsize
            // 
            this.numupdownsize.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numupdownsize.Location = new System.Drawing.Point(258, 99);
            this.numupdownsize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numupdownsize.Name = "numupdownsize";
            this.numupdownsize.Size = new System.Drawing.Size(92, 20);
            this.numupdownsize.TabIndex = 6;
            this.numupdownsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 206);
            this.Controls.Add(this.numupdownsize);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.img_textbox);
            this.Controls.Add(this.txtc_butt);
            this.Controls.Add(this.gc2_butt);
            this.Controls.Add(this.gc1_butt);
            this.Controls.Add(this.run);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numupdownsize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog cg1;
        private System.Windows.Forms.ColorDialog cg2;
        private System.Windows.Forms.ColorDialog txtc;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button gc1_butt;
        private System.Windows.Forms.Button gc2_butt;
        private System.Windows.Forms.Button txtc_butt;
        private System.Windows.Forms.TextBox img_textbox;
        private System.Windows.Forms.Button filepath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NumericUpDown numupdownsize;
    }
}

