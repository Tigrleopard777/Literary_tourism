namespace LiteraryTourism.Forms
{
    partial class TheaterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheaterForm));
            this.web = new System.Windows.Forms.WebBrowser();
            this.picture = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.icon_picture = new System.Windows.Forms.PictureBox();
            this.theater_name_lbl = new System.Windows.Forms.Label();
            this.site_lbl = new System.Windows.Forms.Label();
            this.address_lbl = new System.Windows.Forms.Label();
            this.picture_name_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // web
            // 
            this.web.Dock = System.Windows.Forms.DockStyle.Left;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(500, 661);
            this.web.TabIndex = 40;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(535, 89);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(420, 282);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 41;
            this.picture.TabStop = false;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(716, 32);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 42;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Visible = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(716, 425);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(75, 23);
            this.next_btn.TabIndex = 43;
            this.next_btn.Text = "Вперед";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Visible = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
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
            this.icon_picture.TabIndex = 44;
            this.icon_picture.TabStop = false;
            // 
            // theater_name_lbl
            // 
            this.theater_name_lbl.AutoSize = true;
            this.theater_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theater_name_lbl.Location = new System.Drawing.Point(733, 468);
            this.theater_name_lbl.Name = "theater_name_lbl";
            this.theater_name_lbl.Size = new System.Drawing.Size(42, 13);
            this.theater_name_lbl.TabIndex = 45;
            this.theater_name_lbl.Text = "Театр";
            this.theater_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // site_lbl
            // 
            this.site_lbl.AutoSize = true;
            this.site_lbl.Location = new System.Drawing.Point(744, 533);
            this.site_lbl.Name = "site_lbl";
            this.site_lbl.Size = new System.Drawing.Size(23, 13);
            this.site_lbl.TabIndex = 46;
            this.site_lbl.Text = "site";
            this.site_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.Location = new System.Drawing.Point(737, 608);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(41, 13);
            this.address_lbl.TabIndex = 47;
            this.address_lbl.Text = "Адрес:";
            // 
            // picture_name_lbl
            // 
            this.picture_name_lbl.AutoSize = true;
            this.picture_name_lbl.Location = new System.Drawing.Point(736, 393);
            this.picture_name_lbl.Name = "picture_name_lbl";
            this.picture_name_lbl.Size = new System.Drawing.Size(35, 13);
            this.picture_name_lbl.TabIndex = 51;
            this.picture_name_lbl.Text = "label1";
            this.picture_name_lbl.Visible = false;
            // 
            // TheaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.picture_name_lbl);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.site_lbl);
            this.Controls.Add(this.theater_name_lbl);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.web);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TheaterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.PictureBox icon_picture;
        private System.Windows.Forms.Label theater_name_lbl;
        private System.Windows.Forms.Label site_lbl;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.Label picture_name_lbl;
    }
}