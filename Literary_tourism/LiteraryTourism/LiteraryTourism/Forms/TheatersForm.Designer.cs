namespace LiteraryTourism.Forms
{
    partial class TheatersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheatersForm));
            this.icon_picture = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.theater_lbl = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_theater_txt = new System.Windows.Forms.TextBox();
            this.data_theaters = new System.Windows.Forms.DataGridView();
            this.theater_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theater_site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theater_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_spectacle_txt = new System.Windows.Forms.TextBox();
            this.spectacle_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_theaters)).BeginInit();
            this.SuspendLayout();
            // 
            // icon_picture
            // 
            this.icon_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon_picture.Enabled = false;
            this.icon_picture.Image = global::LiteraryTourism.Properties.Resources.icon;
            this.icon_picture.Location = new System.Drawing.Point(657, 12);
            this.icon_picture.Name = "icon_picture";
            this.icon_picture.Size = new System.Drawing.Size(112, 57);
            this.icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_picture.TabIndex = 23;
            this.icon_picture.TabStop = false;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(18, 421);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 22;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // theater_lbl
            // 
            this.theater_lbl.AutoSize = true;
            this.theater_lbl.Location = new System.Drawing.Point(15, 57);
            this.theater_lbl.Name = "theater_lbl";
            this.theater_lbl.Size = new System.Drawing.Size(37, 13);
            this.theater_lbl.TabIndex = 21;
            this.theater_lbl.Text = "Театр";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(694, 84);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 20);
            this.search_btn.TabIndex = 20;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_theater_txt
            // 
            this.search_theater_txt.Location = new System.Drawing.Point(18, 84);
            this.search_theater_txt.Name = "search_theater_txt";
            this.search_theater_txt.Size = new System.Drawing.Size(328, 20);
            this.search_theater_txt.TabIndex = 18;
            // 
            // data_theaters
            // 
            this.data_theaters.AllowUserToAddRows = false;
            this.data_theaters.AllowUserToDeleteRows = false;
            this.data_theaters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_theaters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_theaters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.theater_name,
            this.theater_site,
            this.theater_address});
            this.data_theaters.Location = new System.Drawing.Point(18, 125);
            this.data_theaters.Name = "data_theaters";
            this.data_theaters.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_theaters.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_theaters.Size = new System.Drawing.Size(751, 265);
            this.data_theaters.TabIndex = 17;
            this.data_theaters.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_theaters_CellContentDoubleClick);
            // 
            // theater_name
            // 
            this.theater_name.HeaderText = "Театр";
            this.theater_name.Name = "theater_name";
            this.theater_name.ReadOnly = true;
            this.theater_name.Width = 200;
            // 
            // theater_site
            // 
            this.theater_site.HeaderText = "Сайт";
            this.theater_site.Name = "theater_site";
            this.theater_site.ReadOnly = true;
            this.theater_site.Width = 200;
            // 
            // theater_address
            // 
            this.theater_address.HeaderText = "Адрес";
            this.theater_address.Name = "theater_address";
            this.theater_address.ReadOnly = true;
            this.theater_address.Width = 200;
            // 
            // search_spectacle_txt
            // 
            this.search_spectacle_txt.Location = new System.Drawing.Point(368, 84);
            this.search_spectacle_txt.Name = "search_spectacle_txt";
            this.search_spectacle_txt.Size = new System.Drawing.Size(291, 20);
            this.search_spectacle_txt.TabIndex = 24;
            // 
            // spectacle_lbl
            // 
            this.spectacle_lbl.AutoSize = true;
            this.spectacle_lbl.Location = new System.Drawing.Point(365, 57);
            this.spectacle_lbl.Name = "spectacle_lbl";
            this.spectacle_lbl.Size = new System.Drawing.Size(61, 13);
            this.spectacle_lbl.TabIndex = 25;
            this.spectacle_lbl.Text = "Спектакль";
            // 
            // TheatersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.spectacle_lbl);
            this.Controls.Add(this.search_spectacle_txt);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.theater_lbl);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_theater_txt);
            this.Controls.Add(this.data_theaters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TheatersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_theaters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icon_picture;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label theater_lbl;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_theater_txt;
        private System.Windows.Forms.DataGridView data_theaters;
        private System.Windows.Forms.DataGridViewTextBoxColumn theater_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn theater_site;
        private System.Windows.Forms.DataGridViewTextBoxColumn theater_address;
        private System.Windows.Forms.TextBox search_spectacle_txt;
        private System.Windows.Forms.Label spectacle_lbl;
    }
}