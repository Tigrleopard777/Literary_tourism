namespace LiteraryTourism.Forms
{
    partial class PlacesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlacesForm));
            this.icon_picture = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.place_lbl = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_writer_txt = new System.Windows.Forms.TextBox();
            this.search_place_txt = new System.Windows.Forms.TextBox();
            this.data_places = new System.Windows.Forms.DataGridView();
            this.place_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place_rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relation_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_places)).BeginInit();
            this.SuspendLayout();
            // 
            // icon_picture
            // 
            this.icon_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon_picture.Enabled = false;
            this.icon_picture.Image = global::LiteraryTourism.Properties.Resources.icon;
            this.icon_picture.Location = new System.Drawing.Point(657, 14);
            this.icon_picture.Name = "icon_picture";
            this.icon_picture.Size = new System.Drawing.Size(112, 57);
            this.icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_picture.TabIndex = 23;
            this.icon_picture.TabStop = false;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(18, 423);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 22;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // place_lbl
            // 
            this.place_lbl.AutoSize = true;
            this.place_lbl.Location = new System.Drawing.Point(15, 59);
            this.place_lbl.Name = "place_lbl";
            this.place_lbl.Size = new System.Drawing.Size(39, 13);
            this.place_lbl.TabIndex = 21;
            this.place_lbl.Text = "Место";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(694, 86);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 20);
            this.search_btn.TabIndex = 20;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_writer_txt
            // 
            this.search_writer_txt.Location = new System.Drawing.Point(368, 86);
            this.search_writer_txt.Name = "search_writer_txt";
            this.search_writer_txt.Size = new System.Drawing.Size(301, 20);
            this.search_writer_txt.TabIndex = 19;
            // 
            // search_place_txt
            // 
            this.search_place_txt.Location = new System.Drawing.Point(18, 86);
            this.search_place_txt.Name = "search_place_txt";
            this.search_place_txt.Size = new System.Drawing.Size(329, 20);
            this.search_place_txt.TabIndex = 18;
            // 
            // data_places
            // 
            this.data_places.AllowUserToAddRows = false;
            this.data_places.AllowUserToDeleteRows = false;
            this.data_places.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_places.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_places.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.place_name,
            this.place_address,
            this.place_rating,
            this.writer_name,
            this.relation_description});
            this.data_places.Location = new System.Drawing.Point(18, 127);
            this.data_places.Name = "data_places";
            this.data_places.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_places.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_places.Size = new System.Drawing.Size(751, 265);
            this.data_places.TabIndex = 17;
            this.data_places.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_places_CellContentDoubleClick);
            // 
            // place_name
            // 
            this.place_name.HeaderText = "Место";
            this.place_name.Name = "place_name";
            this.place_name.ReadOnly = true;
            this.place_name.Width = 150;
            // 
            // place_address
            // 
            this.place_address.HeaderText = "Адрес";
            this.place_address.Name = "place_address";
            this.place_address.ReadOnly = true;
            this.place_address.Width = 150;
            // 
            // place_rating
            // 
            this.place_rating.HeaderText = "Рейтинг";
            this.place_rating.Name = "place_rating";
            this.place_rating.ReadOnly = true;
            // 
            // writer_name
            // 
            this.writer_name.HeaderText = "Писатель";
            this.writer_name.Name = "writer_name";
            this.writer_name.ReadOnly = true;
            this.writer_name.Width = 150;
            // 
            // relation_description
            // 
            this.relation_description.HeaderText = "Связь";
            this.relation_description.Name = "relation_description";
            this.relation_description.ReadOnly = true;
            this.relation_description.Width = 150;
            // 
            // writer_lbl
            // 
            this.writer_lbl.AutoSize = true;
            this.writer_lbl.Location = new System.Drawing.Point(365, 59);
            this.writer_lbl.Name = "writer_lbl";
            this.writer_lbl.Size = new System.Drawing.Size(56, 13);
            this.writer_lbl.TabIndex = 16;
            this.writer_lbl.Text = "Писатель";
            // 
            // PlacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.place_lbl);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_writer_txt);
            this.Controls.Add(this.search_place_txt);
            this.Controls.Add(this.data_places);
            this.Controls.Add(this.writer_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlacesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_places)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icon_picture;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label place_lbl;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_writer_txt;
        private System.Windows.Forms.TextBox search_place_txt;
        private System.Windows.Forms.DataGridView data_places;
        private System.Windows.Forms.Label writer_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn writer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn relation_description;
    }
}