namespace LiteraryTourism.Forms
{
    partial class PlacesWorksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlacesWorksForm));
            this.back_btn = new System.Windows.Forms.Button();
            this.place_lbl = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_writer_txt = new System.Windows.Forms.TextBox();
            this.search_place_txt = new System.Windows.Forms.TextBox();
            this.data_place_work = new System.Windows.Forms.DataGridView();
            this.place_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place_rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excerpt_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer_lbl = new System.Windows.Forms.Label();
            this.icon_picture = new System.Windows.Forms.PictureBox();
            this.search_work_txt = new System.Windows.Forms.TextBox();
            this.work_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_place_work)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(18, 423);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 30;
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
            this.place_lbl.TabIndex = 29;
            this.place_lbl.Text = "Место";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(694, 86);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 20);
            this.search_btn.TabIndex = 28;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_writer_txt
            // 
            this.search_writer_txt.Location = new System.Drawing.Point(245, 86);
            this.search_writer_txt.Name = "search_writer_txt";
            this.search_writer_txt.Size = new System.Drawing.Size(210, 20);
            this.search_writer_txt.TabIndex = 27;
            // 
            // search_place_txt
            // 
            this.search_place_txt.Location = new System.Drawing.Point(18, 86);
            this.search_place_txt.Name = "search_place_txt";
            this.search_place_txt.Size = new System.Drawing.Size(210, 20);
            this.search_place_txt.TabIndex = 26;
            // 
            // data_place_work
            // 
            this.data_place_work.AllowUserToAddRows = false;
            this.data_place_work.AllowUserToDeleteRows = false;
            this.data_place_work.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_place_work.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_place_work.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.place_name,
            this.place_address,
            this.place_rating,
            this.writer_name,
            this.work_name,
            this.excerpt_text});
            this.data_place_work.Location = new System.Drawing.Point(18, 127);
            this.data_place_work.Name = "data_place_work";
            this.data_place_work.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_place_work.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_place_work.Size = new System.Drawing.Size(751, 265);
            this.data_place_work.TabIndex = 25;
            this.data_place_work.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_place_work_CellContentDoubleClick);
            // 
            // place_name
            // 
            this.place_name.HeaderText = "Место";
            this.place_name.Name = "place_name";
            this.place_name.ReadOnly = true;
            this.place_name.Width = 120;
            // 
            // place_address
            // 
            this.place_address.HeaderText = "Адрес";
            this.place_address.Name = "place_address";
            this.place_address.ReadOnly = true;
            this.place_address.Width = 120;
            // 
            // place_rating
            // 
            this.place_rating.HeaderText = "Рейтинг";
            this.place_rating.Name = "place_rating";
            this.place_rating.ReadOnly = true;
            this.place_rating.Width = 60;
            // 
            // writer_name
            // 
            this.writer_name.HeaderText = "Писатель";
            this.writer_name.Name = "writer_name";
            this.writer_name.ReadOnly = true;
            // 
            // work_name
            // 
            this.work_name.HeaderText = "Произведение";
            this.work_name.Name = "work_name";
            this.work_name.ReadOnly = true;
            this.work_name.Width = 120;
            // 
            // excerpt_text
            // 
            this.excerpt_text.HeaderText = "Выдержка";
            this.excerpt_text.Name = "excerpt_text";
            this.excerpt_text.ReadOnly = true;
            this.excerpt_text.Width = 170;
            // 
            // writer_lbl
            // 
            this.writer_lbl.AutoSize = true;
            this.writer_lbl.Location = new System.Drawing.Point(242, 59);
            this.writer_lbl.Name = "writer_lbl";
            this.writer_lbl.Size = new System.Drawing.Size(56, 13);
            this.writer_lbl.TabIndex = 24;
            this.writer_lbl.Text = "Писатель";
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
            this.icon_picture.TabIndex = 31;
            this.icon_picture.TabStop = false;
            // 
            // search_work_txt
            // 
            this.search_work_txt.Location = new System.Drawing.Point(471, 86);
            this.search_work_txt.Name = "search_work_txt";
            this.search_work_txt.Size = new System.Drawing.Size(210, 20);
            this.search_work_txt.TabIndex = 32;
            // 
            // work_lbl
            // 
            this.work_lbl.AutoSize = true;
            this.work_lbl.Location = new System.Drawing.Point(471, 59);
            this.work_lbl.Name = "work_lbl";
            this.work_lbl.Size = new System.Drawing.Size(81, 13);
            this.work_lbl.TabIndex = 33;
            this.work_lbl.Text = "Произведение";
            // 
            // PlacesWorksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.work_lbl);
            this.Controls.Add(this.search_work_txt);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.place_lbl);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_writer_txt);
            this.Controls.Add(this.search_place_txt);
            this.Controls.Add(this.data_place_work);
            this.Controls.Add(this.writer_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlacesWorksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.data_place_work)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
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
        private System.Windows.Forms.DataGridView data_place_work;
        private System.Windows.Forms.Label writer_lbl;
        private System.Windows.Forms.TextBox search_work_txt;
        private System.Windows.Forms.Label work_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn writer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn excerpt_text;
    }
}