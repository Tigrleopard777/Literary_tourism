namespace LiteraryTourism.Forms
{
    partial class RouteForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteForm));
            this.data_comments = new System.Windows.Forms.DataGridView();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark_combo = new System.Windows.Forms.ComboBox();
            this.mark_lbl = new System.Windows.Forms.Label();
            this.rating_lbl = new System.Windows.Forms.Label();
            this.writer_lbl = new System.Windows.Forms.Label();
            this.route_name_lbl = new System.Windows.Forms.Label();
            this.icon_picture = new System.Windows.Forms.PictureBox();
            this.web = new System.Windows.Forms.WebBrowser();
            this.data_movies = new System.Windows.Forms.DataGridView();
            this.data_museums = new System.Windows.Forms.DataGridView();
            this.movie_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_of_issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.museum_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.museum_site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.museum_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_places = new System.Windows.Forms.DataGridView();
            this.place_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_spectacles = new System.Windows.Forms.DataGridView();
            this.spectacle_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spectacle_link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theater_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.google_btn = new System.Windows.Forms.Button();
            this.yandex_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_comments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_movies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_museums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_places)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_spectacles)).BeginInit();
            this.SuspendLayout();
            // 
            // data_comments
            // 
            this.data_comments.AllowUserToAddRows = false;
            this.data_comments.AllowUserToDeleteRows = false;
            this.data_comments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_comments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_comments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comment,
            this.nick,
            this.date});
            this.data_comments.Location = new System.Drawing.Point(526, 482);
            this.data_comments.MultiSelect = false;
            this.data_comments.Name = "data_comments";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_comments.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_comments.Size = new System.Drawing.Size(452, 167);
            this.data_comments.TabIndex = 36;
            this.data_comments.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_comments_CellEndEdit);
            // 
            // comment
            // 
            this.comment.HeaderText = "Комментарий";
            this.comment.Name = "comment";
            this.comment.Width = 180;
            // 
            // nick
            // 
            this.nick.HeaderText = "Пользователь";
            this.nick.Name = "nick";
            this.nick.Width = 120;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            // 
            // mark_combo
            // 
            this.mark_combo.FormattingEnabled = true;
            this.mark_combo.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.mark_combo.Location = new System.Drawing.Point(750, 454);
            this.mark_combo.Name = "mark_combo";
            this.mark_combo.Size = new System.Drawing.Size(58, 21);
            this.mark_combo.TabIndex = 35;
            this.mark_combo.Visible = false;
            this.mark_combo.SelectedIndexChanged += new System.EventHandler(this.mark_combo_SelectedIndexChanged);
            // 
            // mark_lbl
            // 
            this.mark_lbl.AutoSize = true;
            this.mark_lbl.Location = new System.Drawing.Point(691, 457);
            this.mark_lbl.Name = "mark_lbl";
            this.mark_lbl.Size = new System.Drawing.Size(53, 13);
            this.mark_lbl.TabIndex = 34;
            this.mark_lbl.Text = "Оценить:";
            this.mark_lbl.Visible = false;
            // 
            // rating_lbl
            // 
            this.rating_lbl.AutoSize = true;
            this.rating_lbl.Location = new System.Drawing.Point(722, 432);
            this.rating_lbl.Name = "rating_lbl";
            this.rating_lbl.Size = new System.Drawing.Size(51, 13);
            this.rating_lbl.TabIndex = 33;
            this.rating_lbl.Text = "Рейтинг:";
            // 
            // writer_lbl
            // 
            this.writer_lbl.AutoSize = true;
            this.writer_lbl.Location = new System.Drawing.Point(723, 411);
            this.writer_lbl.Name = "writer_lbl";
            this.writer_lbl.Size = new System.Drawing.Size(56, 13);
            this.writer_lbl.TabIndex = 32;
            this.writer_lbl.Text = "Писатель";
            this.writer_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // route_name_lbl
            // 
            this.route_name_lbl.AutoSize = true;
            this.route_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.route_name_lbl.Location = new System.Drawing.Point(723, 389);
            this.route_name_lbl.Name = "route_name_lbl";
            this.route_name_lbl.Size = new System.Drawing.Size(59, 13);
            this.route_name_lbl.TabIndex = 31;
            this.route_name_lbl.Text = "Маршрут";
            this.route_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon_picture
            // 
            this.icon_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon_picture.Enabled = false;
            this.icon_picture.Image = global::LiteraryTourism.Properties.Resources.icon;
            this.icon_picture.Location = new System.Drawing.Point(866, 12);
            this.icon_picture.Name = "icon_picture";
            this.icon_picture.Size = new System.Drawing.Size(112, 57);
            this.icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_picture.TabIndex = 30;
            this.icon_picture.TabStop = false;
            // 
            // web
            // 
            this.web.Dock = System.Windows.Forms.DockStyle.Left;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(500, 661);
            this.web.TabIndex = 26;
            // 
            // data_movies
            // 
            this.data_movies.AllowUserToAddRows = false;
            this.data_movies.AllowUserToDeleteRows = false;
            this.data_movies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_movies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movie_title,
            this.year_of_issue});
            this.data_movies.Location = new System.Drawing.Point(506, 75);
            this.data_movies.Name = "data_movies";
            this.data_movies.ReadOnly = true;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_movies.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.data_movies.Size = new System.Drawing.Size(472, 58);
            this.data_movies.TabIndex = 37;
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
            this.museum_address});
            this.data_museums.Location = new System.Drawing.Point(506, 139);
            this.data_museums.Name = "data_museums";
            this.data_museums.ReadOnly = true;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_museums.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.data_museums.Size = new System.Drawing.Size(472, 86);
            this.data_museums.TabIndex = 38;
            // 
            // movie_title
            // 
            this.movie_title.HeaderText = "Фильм";
            this.movie_title.Name = "movie_title";
            this.movie_title.ReadOnly = true;
            this.movie_title.Width = 200;
            // 
            // year_of_issue
            // 
            this.year_of_issue.HeaderText = "Год выпуска";
            this.year_of_issue.Name = "year_of_issue";
            this.year_of_issue.ReadOnly = true;
            this.year_of_issue.Width = 150;
            // 
            // museum_name
            // 
            this.museum_name.HeaderText = "Музей";
            this.museum_name.Name = "museum_name";
            this.museum_name.ReadOnly = true;
            this.museum_name.Width = 140;
            // 
            // museum_site
            // 
            this.museum_site.HeaderText = "Сайт";
            this.museum_site.Name = "museum_site";
            this.museum_site.ReadOnly = true;
            this.museum_site.Width = 130;
            // 
            // museum_address
            // 
            this.museum_address.HeaderText = "Адрес";
            this.museum_address.Name = "museum_address";
            this.museum_address.ReadOnly = true;
            this.museum_address.Width = 150;
            // 
            // data_places
            // 
            this.data_places.AllowUserToAddRows = false;
            this.data_places.AllowUserToDeleteRows = false;
            this.data_places.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_places.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_places.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.place_name,
            this.place_address});
            this.data_places.Location = new System.Drawing.Point(506, 231);
            this.data_places.Name = "data_places";
            this.data_places.ReadOnly = true;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_places.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data_places.Size = new System.Drawing.Size(472, 81);
            this.data_places.TabIndex = 39;
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
            // data_spectacles
            // 
            this.data_spectacles.AllowUserToAddRows = false;
            this.data_spectacles.AllowUserToDeleteRows = false;
            this.data_spectacles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_spectacles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_spectacles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spectacle_title,
            this.spectacle_link,
            this.theater_name,
            this.address});
            this.data_spectacles.Location = new System.Drawing.Point(506, 317);
            this.data_spectacles.Name = "data_spectacles";
            this.data_spectacles.ReadOnly = true;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_spectacles.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.data_spectacles.Size = new System.Drawing.Size(472, 69);
            this.data_spectacles.TabIndex = 40;
            // 
            // spectacle_title
            // 
            this.spectacle_title.HeaderText = "Спектакль";
            this.spectacle_title.Name = "spectacle_title";
            this.spectacle_title.ReadOnly = true;
            this.spectacle_title.Width = 115;
            // 
            // spectacle_link
            // 
            this.spectacle_link.HeaderText = "Ссылка";
            this.spectacle_link.Name = "spectacle_link";
            this.spectacle_link.ReadOnly = true;
            // 
            // theater_name
            // 
            this.theater_name.HeaderText = "Театр";
            this.theater_name.Name = "theater_name";
            this.theater_name.ReadOnly = true;
            this.theater_name.Width = 110;
            // 
            // address
            // 
            this.address.HeaderText = "Адрес";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // google_btn
            // 
            this.google_btn.Location = new System.Drawing.Point(526, 24);
            this.google_btn.Name = "google_btn";
            this.google_btn.Size = new System.Drawing.Size(93, 23);
            this.google_btn.TabIndex = 41;
            this.google_btn.Text = "Google карты";
            this.google_btn.UseVisualStyleBackColor = true;
            this.google_btn.Click += new System.EventHandler(this.google_btn_Click);
            // 
            // yandex_btn
            // 
            this.yandex_btn.Location = new System.Drawing.Point(750, 24);
            this.yandex_btn.Name = "yandex_btn";
            this.yandex_btn.Size = new System.Drawing.Size(88, 23);
            this.yandex_btn.TabIndex = 42;
            this.yandex_btn.Text = "Яндекс карты";
            this.yandex_btn.UseVisualStyleBackColor = true;
            this.yandex_btn.Click += new System.EventHandler(this.yandex_btn_Click);
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.yandex_btn);
            this.Controls.Add(this.google_btn);
            this.Controls.Add(this.data_spectacles);
            this.Controls.Add(this.data_places);
            this.Controls.Add(this.data_museums);
            this.Controls.Add(this.data_movies);
            this.Controls.Add(this.data_comments);
            this.Controls.Add(this.mark_combo);
            this.Controls.Add(this.mark_lbl);
            this.Controls.Add(this.rating_lbl);
            this.Controls.Add(this.writer_lbl);
            this.Controls.Add(this.route_name_lbl);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.web);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RouteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.data_comments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_movies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_museums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_places)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_spectacles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.ComboBox mark_combo;
        private System.Windows.Forms.Label mark_lbl;
        private System.Windows.Forms.Label rating_lbl;
        private System.Windows.Forms.Label writer_lbl;
        private System.Windows.Forms.Label route_name_lbl;
        private System.Windows.Forms.PictureBox icon_picture;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.DataGridView data_movies;
        private System.Windows.Forms.DataGridViewTextBoxColumn movie_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_of_issue;
        private System.Windows.Forms.DataGridView data_museums;
        private System.Windows.Forms.DataGridViewTextBoxColumn museum_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn museum_site;
        private System.Windows.Forms.DataGridViewTextBoxColumn museum_address;
        private System.Windows.Forms.DataGridView data_places;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn place_address;
        private System.Windows.Forms.DataGridView data_spectacles;
        private System.Windows.Forms.DataGridViewTextBoxColumn spectacle_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn spectacle_link;
        private System.Windows.Forms.DataGridViewTextBoxColumn theater_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.Button google_btn;
        private System.Windows.Forms.Button yandex_btn;
    }
}