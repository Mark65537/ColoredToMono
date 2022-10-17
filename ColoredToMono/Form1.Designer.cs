namespace ColoredToMono
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
            this.cMS_fotPicBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_normal = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_stretchImage = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CenterImage = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_zoom = new System.Windows.Forms.ToolStripMenuItem();
            this.pB_mono = new System.Windows.Forms.PictureBox();
            this.b_export = new System.Windows.Forms.Button();
            this.l_fileName = new System.Windows.Forms.Label();
            this.b_openImages = new System.Windows.Forms.Button();
            this.oFD = new System.Windows.Forms.OpenFileDialog();
            this.sFD = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.l_time = new System.Windows.Forms.Label();
            this.b_next = new System.Windows.Forms.Button();
            this.b_prev = new System.Windows.Forms.Button();
            this.NUpD_lavel = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.b_exportAll = new System.Windows.Forms.Button();
            this.cMS_fotPicBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_mono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpD_lavel)).BeginInit();
            this.SuspendLayout();
            // 
            // cMS_fotPicBox
            // 
            this.cMS_fotPicBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_normal,
            this.TSMI_stretchImage,
            this.TSMI_CenterImage,
            this.TSMI_zoom});
            this.cMS_fotPicBox.Name = "cMS_fotPicBox";
            this.cMS_fotPicBox.Size = new System.Drawing.Size(145, 92);
            this.cMS_fotPicBox.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cMS_fotPicBox_ItemClicked);
            // 
            // TSMI_normal
            // 
            this.TSMI_normal.Name = "TSMI_normal";
            this.TSMI_normal.Size = new System.Drawing.Size(144, 22);
            this.TSMI_normal.Text = "Normal";
            // 
            // TSMI_stretchImage
            // 
            this.TSMI_stretchImage.Name = "TSMI_stretchImage";
            this.TSMI_stretchImage.Size = new System.Drawing.Size(144, 22);
            this.TSMI_stretchImage.Text = "StretchImage";
            // 
            // TSMI_CenterImage
            // 
            this.TSMI_CenterImage.Name = "TSMI_CenterImage";
            this.TSMI_CenterImage.Size = new System.Drawing.Size(144, 22);
            this.TSMI_CenterImage.Text = "CenterImage";
            // 
            // TSMI_zoom
            // 
            this.TSMI_zoom.Name = "TSMI_zoom";
            this.TSMI_zoom.Size = new System.Drawing.Size(144, 22);
            this.TSMI_zoom.Text = "Zoom";
            // 
            // pB_mono
            // 
            this.pB_mono.BackColor = System.Drawing.Color.DarkGray;
            this.pB_mono.ContextMenuStrip = this.cMS_fotPicBox;
            this.pB_mono.Location = new System.Drawing.Point(12, 40);
            this.pB_mono.Name = "pB_mono";
            this.pB_mono.Size = new System.Drawing.Size(400, 240);
            this.pB_mono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_mono.TabIndex = 0;
            this.pB_mono.TabStop = false;
            this.pB_mono.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pB_mono_MouseClick);
            // 
            // b_export
            // 
            this.b_export.Location = new System.Drawing.Point(257, 11);
            this.b_export.Name = "b_export";
            this.b_export.Size = new System.Drawing.Size(75, 23);
            this.b_export.TabIndex = 2;
            this.b_export.Text = "Export";
            this.b_export.UseVisualStyleBackColor = true;
            this.b_export.Click += new System.EventHandler(this.b_export_Click);
            // 
            // l_fileName
            // 
            this.l_fileName.AutoEllipsis = true;
            this.l_fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_fileName.Location = new System.Drawing.Point(76, 295);
            this.l_fileName.Name = "l_fileName";
            this.l_fileName.Size = new System.Drawing.Size(266, 20);
            this.l_fileName.TabIndex = 3;
            this.l_fileName.Text = "..";
            this.l_fileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_openImages
            // 
            this.b_openImages.Location = new System.Drawing.Point(170, 11);
            this.b_openImages.Name = "b_openImages";
            this.b_openImages.Size = new System.Drawing.Size(81, 23);
            this.b_openImages.TabIndex = 4;
            this.b_openImages.Text = "Open";
            this.b_openImages.UseVisualStyleBackColor = true;
            this.b_openImages.Click += new System.EventHandler(this.b_openImages_Click);
            // 
            // oFD
            // 
            this.oFD.FileName = "test";
            this.oFD.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            this.oFD.Multiselect = true;
            // 
            // sFD
            // 
            this.sFD.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image " +
    "Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            this.sFD.Title = "Сохранить картинку как...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(418, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time:";
            // 
            // l_time
            // 
            this.l_time.AutoSize = true;
            this.l_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_time.Location = new System.Drawing.Point(463, 41);
            this.l_time.Name = "l_time";
            this.l_time.Size = new System.Drawing.Size(21, 20);
            this.l_time.TabIndex = 6;
            this.l_time.Text = "...";
            // 
            // b_next
            // 
            this.b_next.Enabled = false;
            this.b_next.Location = new System.Drawing.Point(363, 292);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(49, 23);
            this.b_next.TabIndex = 7;
            this.b_next.Text = "→";
            this.b_next.UseVisualStyleBackColor = true;
            this.b_next.Click += new System.EventHandler(this.b_next_Click);
            // 
            // b_prev
            // 
            this.b_prev.Enabled = false;
            this.b_prev.Location = new System.Drawing.Point(12, 295);
            this.b_prev.Name = "b_prev";
            this.b_prev.Size = new System.Drawing.Size(49, 23);
            this.b_prev.TabIndex = 7;
            this.b_prev.Text = "←";
            this.b_prev.UseVisualStyleBackColor = true;
            this.b_prev.Click += new System.EventHandler(this.b_prev_Click);
            this.b_prev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.b_prev_MouseDown);
            // 
            // NUpD_lavel
            // 
            this.NUpD_lavel.Location = new System.Drawing.Point(44, 11);
            this.NUpD_lavel.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.NUpD_lavel.Name = "NUpD_lavel";
            this.NUpD_lavel.Size = new System.Drawing.Size(120, 20);
            this.NUpD_lavel.TabIndex = 9;
            this.NUpD_lavel.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.NUpD_lavel.ValueChanged += new System.EventHandler(this.NUpD_lavel_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "lavel";
            // 
            // b_exportAll
            // 
            this.b_exportAll.Location = new System.Drawing.Point(337, 11);
            this.b_exportAll.Name = "b_exportAll";
            this.b_exportAll.Size = new System.Drawing.Size(75, 23);
            this.b_exportAll.TabIndex = 2;
            this.b_exportAll.Text = "Export All";
            this.b_exportAll.UseVisualStyleBackColor = true;
            this.b_exportAll.Click += new System.EventHandler(this.b_export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 336);
            this.Controls.Add(this.NUpD_lavel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_prev);
            this.Controls.Add(this.b_next);
            this.Controls.Add(this.l_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_openImages);
            this.Controls.Add(this.l_fileName);
            this.Controls.Add(this.b_exportAll);
            this.Controls.Add(this.b_export);
            this.Controls.Add(this.pB_mono);
            this.Name = "Form1";
            this.Text = "ColoredToMono ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cMS_fotPicBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_mono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpD_lavel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pB_mono;
        private System.Windows.Forms.Button b_export;
        private System.Windows.Forms.Label l_fileName;
        private System.Windows.Forms.Button b_openImages;
        private System.Windows.Forms.OpenFileDialog oFD;
        private System.Windows.Forms.SaveFileDialog sFD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_time;
        private System.Windows.Forms.Button b_next;
        private System.Windows.Forms.Button b_prev;
        private System.Windows.Forms.ContextMenuStrip cMS_fotPicBox;
        private System.Windows.Forms.ToolStripMenuItem TSMI_normal;
        private System.Windows.Forms.ToolStripMenuItem TSMI_stretchImage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CenterImage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_zoom;
        private System.Windows.Forms.NumericUpDown NUpD_lavel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_exportAll;
    }
}

