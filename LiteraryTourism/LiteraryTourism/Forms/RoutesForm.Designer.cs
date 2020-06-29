namespace LiteraryTourism.Forms
{
    partial class RoutesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutesForm));
            this.back_btn = new System.Windows.Forms.Button();
            this.route_lbl = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_writer_txt = new System.Windows.Forms.TextBox();
            this.search_route_txt = new System.Windows.Forms.TextBox();
            this.data_routes = new System.Windows.Forms.DataGridView();
            this.writer_lbl = new System.Windows.Forms.Label();
            this.user_lbl = new System.Windows.Forms.Label();
            this.search_user_txt = new System.Windows.Forms.TextBox();
            this.route_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.route_rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_route_btn = new System.Windows.Forms.Button();
            this.icon_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_routes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(18, 426);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 21;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // route_lbl
            // 
            this.route_lbl.AutoSize = true;
            this.route_lbl.Location = new System.Drawing.Point(15, 66);
            this.route_lbl.Name = "route_lbl";
            this.route_lbl.Size = new System.Drawing.Size(52, 13);
            this.route_lbl.TabIndex = 20;
            this.route_lbl.Text = "Маршрут";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(694, 93);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 20);
            this.search_btn.TabIndex = 19;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_writer_txt
            // 
            this.search_writer_txt.Location = new System.Drawing.Point(241, 93);
            this.search_writer_txt.Name = "search_writer_txt";
            this.search_writer_txt.Size = new System.Drawing.Size(210, 20);
            this.search_writer_txt.TabIndex = 18;
            // 
            // search_route_txt
            // 
            this.search_route_txt.Location = new System.Drawing.Point(18, 93);
            this.search_route_txt.Name = "search_route_txt";
            this.search_route_txt.Size = new System.Drawing.Size(210, 20);
            this.search_route_txt.TabIndex = 17;
            // 
            // data_routes
            // 
            this.data_routes.AllowUserToAddRows = false;
            this.data_routes.AllowUserToDeleteRows = false;
            this.data_routes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_routes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_routes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.route_name,
            this.writer_name,
            this.date,
            this.user_nick,
            this.route_rating});
            this.data_routes.Location = new System.Drawing.Point(18, 134);
            this.data_routes.Name = "data_routes";
            this.data_routes.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_routes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_routes.Size = new System.Drawing.Size(751, 265);
            this.data_routes.TabIndex = 16;
            this.data_routes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_routes_CellContentDoubleClick);
            // 
            // writer_lbl
            // 
            this.writer_lbl.AutoSize = true;
            this.writer_lbl.Location = new System.Drawing.Point(238, 66);
            this.writer_lbl.Name = "writer_lbl";
            this.writer_lbl.Size = new System.Drawing.Size(56, 13);
            this.writer_lbl.TabIndex = 15;
            this.writer_lbl.Text = "Писатель";
            // 
            // user_lbl
            // 
            this.user_lbl.AutoSize = true;
            this.user_lbl.Location = new System.Drawing.Point(461, 66);
            this.user_lbl.Name = "user_lbl";
            this.user_lbl.Size = new System.Drawing.Size(72, 13);
            this.user_lbl.TabIndex = 15;
            this.user_lbl.Text = "Разработчик";
            // 
            // search_user_txt
            // 
            this.search_user_txt.Location = new System.Drawing.Point(464, 93);
            this.search_user_txt.Name = "search_user_txt";
            this.search_user_txt.Size = new System.Drawing.Size(210, 20);
            this.search_user_txt.TabIndex = 18;
            // 
            // route_name
            // 
            this.route_name.HeaderText = "Маршрут";
            this.route_name.Name = "route_name";
            this.route_name.ReadOnly = true;
            this.route_name.Width = 150;
            // 
            // writer_name
            // 
            this.writer_name.HeaderText = "Писатель";
            this.writer_name.Name = "writer_name";
            this.writer_name.ReadOnly = true;
            this.writer_name.Width = 150;
            // 
            // date
            // 
            this.date.HeaderText = "Дата создания";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // user_nick
            // 
            this.user_nick.HeaderText = "Разработчик";
            this.user_nick.Name = "user_nick";
            this.user_nick.ReadOnly = true;
            this.user_nick.Width = 150;
            // 
            // route_rating
            // 
            this.route_rating.HeaderText = "Рейтинг";
            this.route_rating.Name = "route_rating";
            this.route_rating.ReadOnly = true;
            // 
            // add_route_btn
            // 
            this.add_route_btn.Location = new System.Drawing.Point(694, 426);
            this.add_route_btn.Name = "add_route_btn";
            this.add_route_btn.Size = new System.Drawing.Size(75, 23);
            this.add_route_btn.TabIndex = 23;
            this.add_route_btn.Text = "Добавить";
            this.add_route_btn.UseVisualStyleBackColor = true;
            this.add_route_btn.Visible = false;
            this.add_route_btn.Click += new System.EventHandler(this.add_route_btn_Click);
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
            this.icon_picture.TabIndex = 22;
            this.icon_picture.TabStop = false;
            // 
            // RoutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.add_route_btn);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.route_lbl);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_user_txt);
            this.Controls.Add(this.search_writer_txt);
            this.Controls.Add(this.search_route_txt);
            this.Controls.Add(this.user_lbl);
            this.Controls.Add(this.data_routes);
            this.Controls.Add(this.writer_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoutesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.data_routes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icon_picture;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label route_lbl;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_writer_txt;
        private System.Windows.Forms.TextBox search_route_txt;
        private System.Windows.Forms.DataGridView data_routes;
        private System.Windows.Forms.Label writer_lbl;
        private System.Windows.Forms.Label user_lbl;
        private System.Windows.Forms.TextBox search_user_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn route_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn writer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn route_rating;
        private System.Windows.Forms.Button add_route_btn;
    }
}