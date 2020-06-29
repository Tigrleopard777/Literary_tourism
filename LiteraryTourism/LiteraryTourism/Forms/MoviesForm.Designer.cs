namespace LiteraryTourism.Forms
{
    partial class MoviesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesForm));
            this.movie_lbl = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_writer_txt = new System.Windows.Forms.TextBox();
            this.search_movie_txt = new System.Windows.Forms.TextBox();
            this.data_movies = new System.Windows.Forms.DataGridView();
            this.movie_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_of_issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movie_rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer_lbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.icon_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_movies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // movie_lbl
            // 
            this.movie_lbl.AutoSize = true;
            this.movie_lbl.Location = new System.Drawing.Point(15, 56);
            this.movie_lbl.Name = "movie_lbl";
            this.movie_lbl.Size = new System.Drawing.Size(44, 13);
            this.movie_lbl.TabIndex = 12;
            this.movie_lbl.Text = "Фильм";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(694, 83);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 20);
            this.search_btn.TabIndex = 11;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_writer_txt
            // 
            this.search_writer_txt.Location = new System.Drawing.Point(368, 83);
            this.search_writer_txt.Name = "search_writer_txt";
            this.search_writer_txt.Size = new System.Drawing.Size(301, 20);
            this.search_writer_txt.TabIndex = 10;
            // 
            // search_movie_txt
            // 
            this.search_movie_txt.Location = new System.Drawing.Point(18, 83);
            this.search_movie_txt.Name = "search_movie_txt";
            this.search_movie_txt.Size = new System.Drawing.Size(329, 20);
            this.search_movie_txt.TabIndex = 9;
            // 
            // data_movies
            // 
            this.data_movies.AllowUserToAddRows = false;
            this.data_movies.AllowUserToDeleteRows = false;
            this.data_movies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_movies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movie_title,
            this.year_of_issue,
            this.movie_rating,
            this.writer_name});
            this.data_movies.Location = new System.Drawing.Point(18, 124);
            this.data_movies.Name = "data_movies";
            this.data_movies.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_movies.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_movies.Size = new System.Drawing.Size(751, 265);
            this.data_movies.TabIndex = 8;
            this.data_movies.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_movies_CellContentDoubleClick);
            // 
            // movie_title
            // 
            this.movie_title.HeaderText = "Фильм";
            this.movie_title.Name = "movie_title";
            this.movie_title.ReadOnly = true;
            this.movie_title.Width = 150;
            // 
            // year_of_issue
            // 
            this.year_of_issue.HeaderText = "Год выпуска";
            this.year_of_issue.Name = "year_of_issue";
            this.year_of_issue.ReadOnly = true;
            this.year_of_issue.Width = 150;
            // 
            // movie_rating
            // 
            this.movie_rating.HeaderText = "Рейтинг";
            this.movie_rating.Name = "movie_rating";
            this.movie_rating.ReadOnly = true;
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
            this.writer_lbl.Location = new System.Drawing.Point(365, 56);
            this.writer_lbl.Name = "writer_lbl";
            this.writer_lbl.Size = new System.Drawing.Size(56, 13);
            this.writer_lbl.TabIndex = 7;
            this.writer_lbl.Text = "Писатель";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(18, 416);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 13;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // icon_picture
            // 
            this.icon_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon_picture.Enabled = false;
            this.icon_picture.Image = global::LiteraryTourism.Properties.Resources.icon;
            this.icon_picture.Location = new System.Drawing.Point(657, 2);
            this.icon_picture.Name = "icon_picture";
            this.icon_picture.Size = new System.Drawing.Size(112, 57);
            this.icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_picture.TabIndex = 14;
            this.icon_picture.TabStop = false;
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.movie_lbl);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_writer_txt);
            this.Controls.Add(this.search_movie_txt);
            this.Controls.Add(this.data_movies);
            this.Controls.Add(this.writer_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.data_movies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label movie_lbl;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_writer_txt;
        private System.Windows.Forms.TextBox search_movie_txt;
        private System.Windows.Forms.DataGridView data_movies;
        private System.Windows.Forms.Label writer_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_of_issue;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn writer_name;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox icon_picture;
    }
}