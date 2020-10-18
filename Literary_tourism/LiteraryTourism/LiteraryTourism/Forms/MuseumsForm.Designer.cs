namespace LiteraryTourism.Forms
{
    partial class MuseumsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuseumsForm));
            this.writer_lbl = new System.Windows.Forms.Label();
            this.data_museums = new System.Windows.Forms.DataGridView();
            this.museum_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.museum_site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.museum_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.museum_rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_museum_txt = new System.Windows.Forms.TextBox();
            this.search_writer_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.museum_lbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.icon_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_museums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // writer_lbl
            // 
            this.writer_lbl.AutoSize = true;
            this.writer_lbl.Location = new System.Drawing.Point(363, 48);
            this.writer_lbl.Name = "writer_lbl";
            this.writer_lbl.Size = new System.Drawing.Size(56, 13);
            this.writer_lbl.TabIndex = 1;
            this.writer_lbl.Text = "Писатель";
            // 
            // data_museums
            // 
            this.data_museums.AllowUserToAddRows = false;
            this.data_museums.AllowUserToDeleteRows = false;
            this.data_museums.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_museums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_museums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.museum_name,
            this.museum_site,
            this.museum_address,
            this.museum_rating,
            this.writer_name});
            this.data_museums.Location = new System.Drawing.Point(16, 116);
            this.data_museums.Name = "data_museums";
            this.data_museums.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_museums.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_museums.Size = new System.Drawing.Size(751, 265);
            this.data_museums.TabIndex = 2;
            this.data_museums.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_museums_CellContentDoubleClick);
            // 
            // museum_name
            // 
            this.museum_name.HeaderText = "Музей";
            this.museum_name.Name = "museum_name";
            this.museum_name.ReadOnly = true;
            this.museum_name.Width = 150;
            // 
            // museum_site
            // 
            this.museum_site.HeaderText = "Сайт";
            this.museum_site.Name = "museum_site";
            this.museum_site.ReadOnly = true;
            this.museum_site.Width = 150;
            // 
            // museum_address
            // 
            this.museum_address.HeaderText = "Адрес";
            this.museum_address.Name = "museum_address";
            this.museum_address.ReadOnly = true;
            this.museum_address.Width = 150;
            // 
            // museum_rating
            // 
            this.museum_rating.HeaderText = "Рейтинг";
            this.museum_rating.Name = "museum_rating";
            this.museum_rating.ReadOnly = true;
            // 
            // writer_name
            // 
            this.writer_name.HeaderText = "Писатель";
            this.writer_name.Name = "writer_name";
            this.writer_name.ReadOnly = true;
            this.writer_name.Width = 150;
            // 
            // search_museum_txt
            // 
            this.search_museum_txt.Location = new System.Drawing.Point(16, 75);
            this.search_museum_txt.Name = "search_museum_txt";
            this.search_museum_txt.Size = new System.Drawing.Size(329, 20);
            this.search_museum_txt.TabIndex = 3;
            // 
            // search_writer_txt
            // 
            this.search_writer_txt.Location = new System.Drawing.Point(366, 75);
            this.search_writer_txt.Name = "search_writer_txt";
            this.search_writer_txt.Size = new System.Drawing.Size(301, 20);
            this.search_writer_txt.TabIndex = 4;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(692, 75);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 20);
            this.search_btn.TabIndex = 5;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // museum_lbl
            // 
            this.museum_lbl.AutoSize = true;
            this.museum_lbl.Location = new System.Drawing.Point(13, 48);
            this.museum_lbl.Name = "museum_lbl";
            this.museum_lbl.Size = new System.Drawing.Size(39, 13);
            this.museum_lbl.TabIndex = 6;
            this.museum_lbl.Text = "Музей";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(16, 412);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // icon_picture
            // 
            this.icon_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon_picture.Enabled = false;
            this.icon_picture.Image = global::LiteraryTourism.Properties.Resources.icon;
            this.icon_picture.Location = new System.Drawing.Point(655, 3);
            this.icon_picture.Name = "icon_picture";
            this.icon_picture.Size = new System.Drawing.Size(112, 57);
            this.icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_picture.TabIndex = 15;
            this.icon_picture.TabStop = false;
            // 
            // MuseumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.museum_lbl);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_writer_txt);
            this.Controls.Add(this.search_museum_txt);
            this.Controls.Add(this.data_museums);
            this.Controls.Add(this.writer_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MuseumsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.data_museums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label writer_lbl;
        private System.Windows.Forms.DataGridView data_museums;
        private System.Windows.Forms.DataGridViewTextBoxColumn museum_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn museum_site;
        private System.Windows.Forms.DataGridViewTextBoxColumn museum_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn museum_rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn writer_name;
        private System.Windows.Forms.TextBox search_museum_txt;
        private System.Windows.Forms.TextBox search_writer_txt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label museum_lbl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox icon_picture;
    }
}