namespace LiteraryTourism.Forms
{
    partial class MuseumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuseumForm));
            this.web = new System.Windows.Forms.WebBrowser();
            this.back_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.icon_picture = new System.Windows.Forms.PictureBox();
            this.museum_name_lbl = new System.Windows.Forms.Label();
            this.site_lbl = new System.Windows.Forms.Label();
            this.rating_lbl = new System.Windows.Forms.Label();
            this.mark_lbl = new System.Windows.Forms.Label();
            this.mark_combo = new System.Windows.Forms.ComboBox();
            this.data_comments = new System.Windows.Forms.DataGridView();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picture_name_lbl = new System.Windows.Forms.Label();
            this.add_lbl = new System.Windows.Forms.Label();
            this.add_combo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_comments)).BeginInit();
            this.SuspendLayout();
            // 
            // web
            // 
            this.web.Dock = System.Windows.Forms.DockStyle.Left;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(500, 661);
            this.web.TabIndex = 0;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(707, 46);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 2;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Visible = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(707, 338);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(75, 23);
            this.next_btn.TabIndex = 3;
            this.next_btn.Text = "Вперед";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Visible = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(565, 89);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(359, 216);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // icon_picture
            // 
            this.icon_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon_picture.Enabled = false;
            this.icon_picture.Image = global::LiteraryTourism.Properties.Resources.icon;
            this.icon_picture.Location = new System.Drawing.Point(860, 12);
            this.icon_picture.Name = "icon_picture";
            this.icon_picture.Size = new System.Drawing.Size(112, 57);
            this.icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_picture.TabIndex = 16;
            this.icon_picture.TabStop = false;
            // 
            // museum_name_lbl
            // 
            this.museum_name_lbl.AutoSize = true;
            this.museum_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.museum_name_lbl.Location = new System.Drawing.Point(723, 375);
            this.museum_name_lbl.Name = "museum_name_lbl";
            this.museum_name_lbl.Size = new System.Drawing.Size(44, 13);
            this.museum_name_lbl.TabIndex = 17;
            this.museum_name_lbl.Text = "Музей";
            this.museum_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // site_lbl
            // 
            this.site_lbl.AutoSize = true;
            this.site_lbl.Location = new System.Drawing.Point(732, 397);
            this.site_lbl.Name = "site_lbl";
            this.site_lbl.Size = new System.Drawing.Size(23, 13);
            this.site_lbl.TabIndex = 18;
            this.site_lbl.Text = "site";
            this.site_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rating_lbl
            // 
            this.rating_lbl.AutoSize = true;
            this.rating_lbl.Location = new System.Drawing.Point(716, 418);
            this.rating_lbl.Name = "rating_lbl";
            this.rating_lbl.Size = new System.Drawing.Size(51, 13);
            this.rating_lbl.TabIndex = 19;
            this.rating_lbl.Text = "Рейтинг:";
            // 
            // mark_lbl
            // 
            this.mark_lbl.AutoSize = true;
            this.mark_lbl.Location = new System.Drawing.Point(685, 443);
            this.mark_lbl.Name = "mark_lbl";
            this.mark_lbl.Size = new System.Drawing.Size(53, 13);
            this.mark_lbl.TabIndex = 20;
            this.mark_lbl.Text = "Оценить:";
            this.mark_lbl.Visible = false;
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
            this.mark_combo.Location = new System.Drawing.Point(744, 440);
            this.mark_combo.Name = "mark_combo";
            this.mark_combo.Size = new System.Drawing.Size(58, 21);
            this.mark_combo.TabIndex = 21;
            this.mark_combo.Visible = false;
            this.mark_combo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.data_comments.Location = new System.Drawing.Point(520, 482);
            this.data_comments.MultiSelect = false;
            this.data_comments.Name = "data_comments";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_comments.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_comments.Size = new System.Drawing.Size(452, 167);
            this.data_comments.TabIndex = 22;
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
            // picture_name_lbl
            // 
            this.picture_name_lbl.AutoSize = true;
            this.picture_name_lbl.Location = new System.Drawing.Point(727, 315);
            this.picture_name_lbl.Name = "picture_name_lbl";
            this.picture_name_lbl.Size = new System.Drawing.Size(35, 13);
            this.picture_name_lbl.TabIndex = 23;
            this.picture_name_lbl.Text = "label1";
            this.picture_name_lbl.Visible = false;
            // 
            // add_lbl
            // 
            this.add_lbl.AutoSize = true;
            this.add_lbl.Location = new System.Drawing.Point(517, 12);
            this.add_lbl.Name = "add_lbl";
            this.add_lbl.Size = new System.Drawing.Size(66, 13);
            this.add_lbl.TabIndex = 24;
            this.add_lbl.Text = "Добавить в";
            this.add_lbl.Visible = false;
            // 
            // add_combo
            // 
            this.add_combo.FormattingEnabled = true;
            this.add_combo.Location = new System.Drawing.Point(598, 9);
            this.add_combo.Name = "add_combo";
            this.add_combo.Size = new System.Drawing.Size(184, 21);
            this.add_combo.TabIndex = 25;
            this.add_combo.Visible = false;
            this.add_combo.SelectedIndexChanged += new System.EventHandler(this.add_combo_SelectedIndexChanged);
            // 
            // MuseumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.add_combo);
            this.Controls.Add(this.add_lbl);
            this.Controls.Add(this.picture_name_lbl);
            this.Controls.Add(this.data_comments);
            this.Controls.Add(this.mark_combo);
            this.Controls.Add(this.mark_lbl);
            this.Controls.Add(this.rating_lbl);
            this.Controls.Add(this.site_lbl);
            this.Controls.Add(this.museum_name_lbl);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.web);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MuseumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_comments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.PictureBox icon_picture;
        private System.Windows.Forms.Label museum_name_lbl;
        private System.Windows.Forms.Label site_lbl;
        private System.Windows.Forms.Label rating_lbl;
        private System.Windows.Forms.Label mark_lbl;
        private System.Windows.Forms.ComboBox mark_combo;
        private System.Windows.Forms.DataGridView data_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Label picture_name_lbl;
        private System.Windows.Forms.Label add_lbl;
        private System.Windows.Forms.ComboBox add_combo;
    }
}