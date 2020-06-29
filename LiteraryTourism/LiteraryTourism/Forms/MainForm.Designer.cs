namespace LiteraryTourism
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.routes_btn = new System.Windows.Forms.Button();
            this.writers_btn = new System.Windows.Forms.Button();
            this.movies__btn = new System.Windows.Forms.Button();
            this.works_btn = new System.Windows.Forms.Button();
            this.spectacles_btn = new System.Windows.Forms.Button();
            this.museums_btn = new System.Windows.Forms.Button();
            this.places_btn = new System.Windows.Forms.Button();
            this.theaters_btn = new System.Windows.Forms.Button();
            this.icon_picture = new System.Windows.Forms.PictureBox();
            this.places_works_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // routes_btn
            // 
            this.routes_btn.Location = new System.Drawing.Point(103, 114);
            this.routes_btn.Name = "routes_btn";
            this.routes_btn.Size = new System.Drawing.Size(100, 35);
            this.routes_btn.TabIndex = 0;
            this.routes_btn.Text = "Маршруты";
            this.routes_btn.UseVisualStyleBackColor = true;
            this.routes_btn.Click += new System.EventHandler(this.routes_btn_Click);
            // 
            // writers_btn
            // 
            this.writers_btn.Location = new System.Drawing.Point(337, 114);
            this.writers_btn.Name = "writers_btn";
            this.writers_btn.Size = new System.Drawing.Size(100, 35);
            this.writers_btn.TabIndex = 1;
            this.writers_btn.Text = "Писатели";
            this.writers_btn.UseVisualStyleBackColor = true;
            this.writers_btn.Click += new System.EventHandler(this.writers_btn_Click);
            // 
            // movies__btn
            // 
            this.movies__btn.Location = new System.Drawing.Point(584, 114);
            this.movies__btn.Name = "movies__btn";
            this.movies__btn.Size = new System.Drawing.Size(100, 35);
            this.movies__btn.TabIndex = 2;
            this.movies__btn.Text = "Фильмы";
            this.movies__btn.UseVisualStyleBackColor = true;
            this.movies__btn.Click += new System.EventHandler(this.movies__btn_Click);
            // 
            // works_btn
            // 
            this.works_btn.Location = new System.Drawing.Point(103, 188);
            this.works_btn.Name = "works_btn";
            this.works_btn.Size = new System.Drawing.Size(100, 35);
            this.works_btn.TabIndex = 3;
            this.works_btn.Text = "Произведения";
            this.works_btn.UseVisualStyleBackColor = true;
            this.works_btn.Click += new System.EventHandler(this.works_btn_Click);
            // 
            // spectacles_btn
            // 
            this.spectacles_btn.Location = new System.Drawing.Point(584, 188);
            this.spectacles_btn.Name = "spectacles_btn";
            this.spectacles_btn.Size = new System.Drawing.Size(100, 35);
            this.spectacles_btn.TabIndex = 4;
            this.spectacles_btn.Text = "Спектакли";
            this.spectacles_btn.UseVisualStyleBackColor = true;
            this.spectacles_btn.Click += new System.EventHandler(this.spectacles_btn_Click);
            // 
            // museums_btn
            // 
            this.museums_btn.Location = new System.Drawing.Point(103, 265);
            this.museums_btn.Name = "museums_btn";
            this.museums_btn.Size = new System.Drawing.Size(100, 35);
            this.museums_btn.TabIndex = 5;
            this.museums_btn.Text = "Музеи";
            this.museums_btn.UseVisualStyleBackColor = true;
            this.museums_btn.Click += new System.EventHandler(this.museums_btn_Click);
            // 
            // places_btn
            // 
            this.places_btn.Location = new System.Drawing.Point(337, 265);
            this.places_btn.Name = "places_btn";
            this.places_btn.Size = new System.Drawing.Size(100, 35);
            this.places_btn.TabIndex = 6;
            this.places_btn.Text = "Места";
            this.places_btn.UseVisualStyleBackColor = true;
            this.places_btn.Click += new System.EventHandler(this.places_btn_Click);
            // 
            // theaters_btn
            // 
            this.theaters_btn.Location = new System.Drawing.Point(584, 265);
            this.theaters_btn.Name = "theaters_btn";
            this.theaters_btn.Size = new System.Drawing.Size(100, 35);
            this.theaters_btn.TabIndex = 7;
            this.theaters_btn.Text = "Театры";
            this.theaters_btn.UseVisualStyleBackColor = true;
            this.theaters_btn.Click += new System.EventHandler(this.theaters_btn_Click);
            // 
            // icon_picture
            // 
            this.icon_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon_picture.Enabled = false;
            this.icon_picture.Image = global::LiteraryTourism.Properties.Resources.icon;
            this.icon_picture.Location = new System.Drawing.Point(660, 12);
            this.icon_picture.Name = "icon_picture";
            this.icon_picture.Size = new System.Drawing.Size(112, 57);
            this.icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_picture.TabIndex = 15;
            this.icon_picture.TabStop = false;
            // 
            // places_works_btn
            // 
            this.places_works_btn.Location = new System.Drawing.Point(337, 188);
            this.places_works_btn.Name = "places_works_btn";
            this.places_works_btn.Size = new System.Drawing.Size(100, 35);
            this.places_works_btn.TabIndex = 16;
            this.places_works_btn.Text = "Места из произведений";
            this.places_works_btn.UseVisualStyleBackColor = true;
            this.places_works_btn.Click += new System.EventHandler(this.places_works_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(33, 406);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 17;
            this.exit_btn.Text = "Выйти";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.places_works_btn);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.theaters_btn);
            this.Controls.Add(this.places_btn);
            this.Controls.Add(this.museums_btn);
            this.Controls.Add(this.spectacles_btn);
            this.Controls.Add(this.works_btn);
            this.Controls.Add(this.movies__btn);
            this.Controls.Add(this.writers_btn);
            this.Controls.Add(this.routes_btn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button routes_btn;
        private System.Windows.Forms.Button writers_btn;
        private System.Windows.Forms.Button movies__btn;
        private System.Windows.Forms.Button works_btn;
        private System.Windows.Forms.Button spectacles_btn;
        private System.Windows.Forms.Button museums_btn;
        private System.Windows.Forms.Button places_btn;
        private System.Windows.Forms.Button theaters_btn;
        private System.Windows.Forms.PictureBox icon_picture;
        private System.Windows.Forms.Button places_works_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

