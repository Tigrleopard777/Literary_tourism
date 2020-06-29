namespace LiteraryTourism.Forms
{
    partial class SpectaclesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpectaclesForm));
            this.icon_picture = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.spectacle_lbl = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_writer_txt = new System.Windows.Forms.TextBox();
            this.search_spectacle_txt = new System.Windows.Forms.TextBox();
            this.data_spectacles = new System.Windows.Forms.DataGridView();
            this.spectacle_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spectacle_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spectacle_link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spectacle_rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theater_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer_lbl = new System.Windows.Forms.Label();
            this.theater_name_lbl = new System.Windows.Forms.Label();
            this.search_theater_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_spectacles)).BeginInit();
            this.SuspendLayout();
            // 
            // icon_picture
            // 
            this.icon_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon_picture.Enabled = false;
            this.icon_picture.Image = global::LiteraryTourism.Properties.Resources.icon;
            this.icon_picture.Location = new System.Drawing.Point(657, 13);
            this.icon_picture.Name = "icon_picture";
            this.icon_picture.Size = new System.Drawing.Size(112, 57);
            this.icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_picture.TabIndex = 31;
            this.icon_picture.TabStop = false;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(17, 419);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 30;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // spectacle_lbl
            // 
            this.spectacle_lbl.AutoSize = true;
            this.spectacle_lbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.spectacle_lbl.Location = new System.Drawing.Point(15, 58);
            this.spectacle_lbl.Name = "spectacle_lbl";
            this.spectacle_lbl.Size = new System.Drawing.Size(61, 13);
            this.spectacle_lbl.TabIndex = 29;
            this.spectacle_lbl.Text = "Спектакль";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(694, 85);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 20);
            this.search_btn.TabIndex = 28;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_writer_txt
            // 
            this.search_writer_txt.Location = new System.Drawing.Point(470, 85);
            this.search_writer_txt.Name = "search_writer_txt";
            this.search_writer_txt.Size = new System.Drawing.Size(210, 20);
            this.search_writer_txt.TabIndex = 27;
            // 
            // search_spectacle_txt
            // 
            this.search_spectacle_txt.Location = new System.Drawing.Point(18, 85);
            this.search_spectacle_txt.Name = "search_spectacle_txt";
            this.search_spectacle_txt.Size = new System.Drawing.Size(210, 20);
            this.search_spectacle_txt.TabIndex = 26;
            // 
            // data_spectacles
            // 
            this.data_spectacles.AllowUserToAddRows = false;
            this.data_spectacles.AllowUserToDeleteRows = false;
            this.data_spectacles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_spectacles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_spectacles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spectacle_title,
            this.director,
            this.spectacle_type,
            this.spectacle_link,
            this.spectacle_rating,
            this.theater_name});
            this.data_spectacles.Location = new System.Drawing.Point(18, 126);
            this.data_spectacles.Name = "data_spectacles";
            this.data_spectacles.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_spectacles.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_spectacles.Size = new System.Drawing.Size(751, 265);
            this.data_spectacles.TabIndex = 25;
            this.data_spectacles.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_spectacles_CellContentDoubleClick);
            // 
            // spectacle_title
            // 
            this.spectacle_title.HeaderText = "Спектакль";
            this.spectacle_title.Name = "spectacle_title";
            this.spectacle_title.ReadOnly = true;
            this.spectacle_title.Width = 140;
            // 
            // director
            // 
            this.director.HeaderText = "Режиссер";
            this.director.Name = "director";
            this.director.ReadOnly = true;
            // 
            // spectacle_type
            // 
            this.spectacle_type.HeaderText = "Тип";
            this.spectacle_type.Name = "spectacle_type";
            this.spectacle_type.ReadOnly = true;
            this.spectacle_type.Width = 120;
            // 
            // spectacle_link
            // 
            this.spectacle_link.HeaderText = "Ссылка";
            this.spectacle_link.Name = "spectacle_link";
            this.spectacle_link.ReadOnly = true;
            this.spectacle_link.Width = 150;
            // 
            // spectacle_rating
            // 
            this.spectacle_rating.HeaderText = "Рейтинг";
            this.spectacle_rating.Name = "spectacle_rating";
            this.spectacle_rating.ReadOnly = true;
            this.spectacle_rating.Width = 60;
            // 
            // theater_name
            // 
            this.theater_name.HeaderText = "Театр";
            this.theater_name.Name = "theater_name";
            this.theater_name.ReadOnly = true;
            this.theater_name.Width = 130;
            // 
            // writer_lbl
            // 
            this.writer_lbl.AutoSize = true;
            this.writer_lbl.Location = new System.Drawing.Point(467, 58);
            this.writer_lbl.Name = "writer_lbl";
            this.writer_lbl.Size = new System.Drawing.Size(56, 13);
            this.writer_lbl.TabIndex = 24;
            this.writer_lbl.Text = "Писатель";
            // 
            // theater_name_lbl
            // 
            this.theater_name_lbl.AutoSize = true;
            this.theater_name_lbl.Location = new System.Drawing.Point(242, 58);
            this.theater_name_lbl.Name = "theater_name_lbl";
            this.theater_name_lbl.Size = new System.Drawing.Size(37, 13);
            this.theater_name_lbl.TabIndex = 32;
            this.theater_name_lbl.Text = "Театр";
            // 
            // search_theater_txt
            // 
            this.search_theater_txt.Location = new System.Drawing.Point(245, 85);
            this.search_theater_txt.Name = "search_theater_txt";
            this.search_theater_txt.Size = new System.Drawing.Size(210, 20);
            this.search_theater_txt.TabIndex = 33;
            // 
            // SpectaclesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.search_theater_txt);
            this.Controls.Add(this.theater_name_lbl);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.spectacle_lbl);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_writer_txt);
            this.Controls.Add(this.search_spectacle_txt);
            this.Controls.Add(this.data_spectacles);
            this.Controls.Add(this.writer_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpectaclesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_spectacles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icon_picture;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label spectacle_lbl;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_writer_txt;
        private System.Windows.Forms.TextBox search_spectacle_txt;
        private System.Windows.Forms.DataGridView data_spectacles;
        private System.Windows.Forms.Label writer_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn spectacle_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn director;
        private System.Windows.Forms.DataGridViewTextBoxColumn spectacle_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn spectacle_link;
        private System.Windows.Forms.DataGridViewTextBoxColumn spectacle_rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn theater_name;
        private System.Windows.Forms.Label theater_name_lbl;
        private System.Windows.Forms.TextBox search_theater_txt;
    }
}