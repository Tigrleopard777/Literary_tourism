namespace LiteraryTourism.Forms
{
    partial class WorksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorksForm));
            this.back_btn = new System.Windows.Forms.Button();
            this.work_lbl = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_writer_txt = new System.Windows.Forms.TextBox();
            this.search_work_txt = new System.Windows.Forms.TextBox();
            this.data_works = new System.Windows.Forms.DataGridView();
            this.work_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer_lbl = new System.Windows.Forms.Label();
            this.icon_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_works)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(16, 415);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 22;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // work_lbl
            // 
            this.work_lbl.AutoSize = true;
            this.work_lbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.work_lbl.Location = new System.Drawing.Point(13, 54);
            this.work_lbl.Name = "work_lbl";
            this.work_lbl.Size = new System.Drawing.Size(81, 13);
            this.work_lbl.TabIndex = 21;
            this.work_lbl.Text = "Произведение";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(692, 81);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 20);
            this.search_btn.TabIndex = 20;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_writer_txt
            // 
            this.search_writer_txt.Location = new System.Drawing.Point(366, 81);
            this.search_writer_txt.Name = "search_writer_txt";
            this.search_writer_txt.Size = new System.Drawing.Size(301, 20);
            this.search_writer_txt.TabIndex = 19;
            // 
            // search_work_txt
            // 
            this.search_work_txt.Location = new System.Drawing.Point(16, 81);
            this.search_work_txt.Name = "search_work_txt";
            this.search_work_txt.Size = new System.Drawing.Size(329, 20);
            this.search_work_txt.TabIndex = 18;
            // 
            // data_works
            // 
            this.data_works.AllowUserToAddRows = false;
            this.data_works.AllowUserToDeleteRows = false;
            this.data_works.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_works.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_works.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.work_name,
            this.work_link,
            this.work_genre,
            this.work_rating,
            this.writer_name});
            this.data_works.Location = new System.Drawing.Point(16, 122);
            this.data_works.Name = "data_works";
            this.data_works.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_works.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_works.Size = new System.Drawing.Size(751, 265);
            this.data_works.TabIndex = 17;
            this.data_works.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_works_CellContentDoubleClick);
            // 
            // work_name
            // 
            this.work_name.HeaderText = "Произведение";
            this.work_name.Name = "work_name";
            this.work_name.ReadOnly = true;
            this.work_name.Width = 150;
            // 
            // work_link
            // 
            this.work_link.HeaderText = "Ссылка";
            this.work_link.Name = "work_link";
            this.work_link.ReadOnly = true;
            this.work_link.Width = 150;
            // 
            // work_genre
            // 
            this.work_genre.HeaderText = "Жанр";
            this.work_genre.Name = "work_genre";
            this.work_genre.ReadOnly = true;
            this.work_genre.Width = 150;
            // 
            // work_rating
            // 
            this.work_rating.HeaderText = "Рейтинг";
            this.work_rating.Name = "work_rating";
            this.work_rating.ReadOnly = true;
            // 
            // writer_name
            // 
            this.writer_name.HeaderText = "Писатель";
            this.writer_name.Name = "writer_name";
            this.writer_name.ReadOnly = true;
            this.writer_name.Width = 150;
            // 
            // writer_lbl
            // 
            this.writer_lbl.AutoSize = true;
            this.writer_lbl.Location = new System.Drawing.Point(363, 54);
            this.writer_lbl.Name = "writer_lbl";
            this.writer_lbl.Size = new System.Drawing.Size(56, 13);
            this.writer_lbl.TabIndex = 16;
            this.writer_lbl.Text = "Писатель";
            // 
            // icon_picture
            // 
            this.icon_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon_picture.Enabled = false;
            this.icon_picture.Image = global::LiteraryTourism.Properties.Resources.icon;
            this.icon_picture.Location = new System.Drawing.Point(655, 9);
            this.icon_picture.Name = "icon_picture";
            this.icon_picture.Size = new System.Drawing.Size(112, 57);
            this.icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_picture.TabIndex = 23;
            this.icon_picture.TabStop = false;
            // 
            // WorksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.work_lbl);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_writer_txt);
            this.Controls.Add(this.search_work_txt);
            this.Controls.Add(this.data_works);
            this.Controls.Add(this.writer_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.data_works)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icon_picture;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label work_lbl;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_writer_txt;
        private System.Windows.Forms.TextBox search_work_txt;
        private System.Windows.Forms.DataGridView data_works;
        private System.Windows.Forms.Label writer_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_link;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn writer_name;
    }
}