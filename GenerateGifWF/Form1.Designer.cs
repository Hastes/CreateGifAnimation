namespace GenerateGifWF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MoviePlace = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.rightClickMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gropBox1 = new System.Windows.Forms.GroupBox();
            this.reportPlace = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picturesCount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddImage = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveGif = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gropBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviePlace
            // 
            this.MoviePlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MoviePlace.Location = new System.Drawing.Point(21, 128);
            this.MoviePlace.Name = "MoviePlace";
            this.MoviePlace.Size = new System.Drawing.Size(478, 358);
            this.MoviePlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePlace.TabIndex = 1;
            this.MoviePlace.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(673, 82);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(21, 492);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(673, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // rightClickMenuStrip1
            // 
            this.rightClickMenuStrip1.Name = "rightClickMenuStrip1";
            this.rightClickMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(568, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 82);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // gropBox1
            // 
            this.gropBox1.Controls.Add(this.reportPlace);
            this.gropBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gropBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gropBox1.Location = new System.Drawing.Point(505, 128);
            this.gropBox1.Name = "gropBox1";
            this.gropBox1.Size = new System.Drawing.Size(189, 358);
            this.gropBox1.TabIndex = 7;
            this.gropBox1.TabStop = false;
            this.gropBox1.Text = "Последние действия";
            // 
            // reportPlace
            // 
            this.reportPlace.AutoScroll = true;
            this.reportPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportPlace.Location = new System.Drawing.Point(6, 16);
            this.reportPlace.Name = "reportPlace";
            this.reportPlace.Size = new System.Drawing.Size(177, 336);
            this.reportPlace.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Изображений";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picturesCount);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(385, 451);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 29);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // picturesCount
            // 
            this.picturesCount.AutoSize = true;
            this.picturesCount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.picturesCount.Location = new System.Drawing.Point(86, 10);
            this.picturesCount.Name = "picturesCount";
            this.picturesCount.Size = new System.Drawing.Size(13, 13);
            this.picturesCount.TabIndex = 2;
            this.picturesCount.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddImage,
            this.SaveGif,
            this.About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddImage
            // 
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(148, 20);
            this.AddImage.Text = "Добавить изображение";
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // SaveGif
            // 
            this.SaveGif.Name = "SaveGif";
            this.SaveGif.Size = new System.Drawing.Size(106, 20);
            this.SaveGif.Text = "Сохранить в GIF";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(94, 20);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 534);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gropBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.MoviePlace);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gropBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox MoviePlace;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ContextMenuStrip rightClickMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gropBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label picturesCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddImage;
        private System.Windows.Forms.ToolStripMenuItem SaveGif;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.FlowLayoutPanel reportPlace;
    }
}

