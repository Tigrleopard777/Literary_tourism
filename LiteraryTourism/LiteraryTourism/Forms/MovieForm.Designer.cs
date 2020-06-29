namespace LiteraryTourism.Forms
{
    partial class MovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieForm));
            this.add_combo = new System.Windows.Forms.ComboBox();
            this.add_lbl = new System.Windows.Forms.Label();
            this.data_comments = new System.Windows.Forms.DataGridView();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark_combo = new System.Windows.Forms.ComboBox();
            this.mark_lbl = new System.Windows.Forms.Label();
            this.rating_lbl = new System.Windows.Forms.Label();
            this.year_of_issue = new System.Windows.Forms.Label();
            this.movie_title_lbl = new System.Windows.Forms.Label();
            this.icon_picture = new System.Windows.Forms.PictureBox();
            this.web = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.data_comments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // add_combo
            // 
            this.add_combo.FormattingEnabled = true;
            this.add_combo.Location = new System.Drawing.Point(604, 9);
            this.add_combo.Name = "add_combo";
            this.add_combo.Size = new System.Drawing.Size(184, 21);
            this.add_combo.TabIndex = 39;
            this.add_combo.Visible = false;
            this.add_combo.SelectedIndexChanged += new System.EventHandler(this.add_combo_SelectedIndexChanged);
            // 
            // add_lbl
            // 
            this.add_lbl.AutoSize = true;
            this.add_lbl.Location = new System.Drawing.Point(523, 12);
            this.add_lbl.Name = "add_lbl";
            this.add_lbl.Size = new System.Drawing.Size(66, 13);
            this.add_lbl.TabIndex = 38;
            this.add_lbl.Text = "Добавить в";
            this.add_lbl.Visible = false;
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
            this.data_comments.Location = new System.Drawing.Point(526, 470);
            this.data_comments.MultiSelect = false;
            this.data_comments.Name = "data_comments";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_comments.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_comments.Size = new System.Drawing.Size(452, 179);
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
            this.mark_combo.Location = new System.Drawing.Point(750, 346);
            this.mark_combo.Name = "mark_combo";
            this.mark_combo.Size = new System.Drawing.Size(58, 21);
            this.mark_combo.TabIndex = 35;
            this.mark_combo.Visible = false;
            this.mark_combo.SelectedIndexChanged += new System.EventHandler(this.mark_combo_SelectedIndexChanged);
            // 
            // mark_lbl
            // 
            this.mark_lbl.AutoSize = true;
            this.mark_lbl.Location = new System.Drawing.Point(691, 349);
            this.mark_lbl.Name = "mark_lbl";
            this.mark_lbl.Size = new System.Drawing.Size(53, 13);
            this.mark_lbl.TabIndex = 34;
            this.mark_lbl.Text = "Оценить:";
            this.mark_lbl.Visible = false;
            // 
            // rating_lbl
            // 
            this.rating_lbl.AutoSize = true;
            this.rating_lbl.Location = new System.Drawing.Point(725, 266);
            this.rating_lbl.Name = "rating_lbl";
            this.rating_lbl.Size = new System.Drawing.Size(51, 13);
            this.rating_lbl.TabIndex = 33;
            this.rating_lbl.Text = "Рейтинг:";
            // 
            // year_of_issue
            // 
            this.year_of_issue.AutoSize = true;
            this.year_of_issue.Location = new System.Drawing.Point(738, 180);
            this.year_of_issue.Name = "year_of_issue";
            this.year_of_issue.Size = new System.Drawing.Size(28, 13);
            this.year_of_issue.TabIndex = 32;
            this.year_of_issue.Text = "Год:";
            this.year_of_issue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movie_title_lbl
            // 
            this.movie_title_lbl.AutoSize = true;
            this.movie_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movie_title_lbl.Location = new System.Drawing.Point(720, 100);
            this.movie_title_lbl.Name = "movie_title_lbl";
            this.movie_title_lbl.Size = new System.Drawing.Size(68, 20);
            this.movie_title_lbl.TabIndex = 31;
            this.movie_title_lbl.Text = "Фильм";
            this.movie_title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.add_combo);
            this.Controls.Add(this.add_lbl);
            this.Controls.Add(this.data_comments);
            this.Controls.Add(this.mark_combo);
            this.Controls.Add(this.mark_lbl);
            this.Controls.Add(this.rating_lbl);
            this.Controls.Add(this.year_of_issue);
            this.Controls.Add(this.movie_title_lbl);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.web);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.data_comments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox add_combo;
        private System.Windows.Forms.Label add_lbl;
        private System.Windows.Forms.DataGridView data_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.ComboBox mark_combo;
        private System.Windows.Forms.Label mark_lbl;
        private System.Windows.Forms.Label rating_lbl;
        private System.Windows.Forms.Label year_of_issue;
        private System.Windows.Forms.Label movie_title_lbl;
        private System.Windows.Forms.PictureBox icon_picture;
        private System.Windows.Forms.WebBrowser web;
    }
}