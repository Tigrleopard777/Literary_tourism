namespace LiteraryTourism.Forms
{
    partial class WriterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriterForm));
            this.picture_name_lbl = new System.Windows.Forms.Label();
            this.place_of_birth_lbl = new System.Windows.Forms.Label();
            this.date_of_birth_lbl = new System.Windows.Forms.Label();
            this.writer_name_lbl = new System.Windows.Forms.Label();
            this.icon_picture = new System.Windows.Forms.PictureBox();
            this.next_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.web = new System.Windows.Forms.WebBrowser();
            this.date_of_death_lbl = new System.Windows.Forms.Label();
            this.place_of_death_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_name_lbl
            // 
            this.picture_name_lbl.AutoSize = true;
            this.picture_name_lbl.Location = new System.Drawing.Point(742, 393);
            this.picture_name_lbl.Name = "picture_name_lbl";
            this.picture_name_lbl.Size = new System.Drawing.Size(35, 13);
            this.picture_name_lbl.TabIndex = 60;
            this.picture_name_lbl.Text = "label1";
            this.picture_name_lbl.Visible = false;
            // 
            // place_of_birth_lbl
            // 
            this.place_of_birth_lbl.AutoSize = true;
            this.place_of_birth_lbl.Location = new System.Drawing.Point(713, 585);
            this.place_of_birth_lbl.Name = "place_of_birth_lbl";
            this.place_of_birth_lbl.Size = new System.Drawing.Size(95, 13);
            this.place_of_birth_lbl.TabIndex = 59;
            this.place_of_birth_lbl.Text = "Место рождения:";
            // 
            // date_of_birth_lbl
            // 
            this.date_of_birth_lbl.AutoSize = true;
            this.date_of_birth_lbl.Location = new System.Drawing.Point(719, 508);
            this.date_of_birth_lbl.Name = "date_of_birth_lbl";
            this.date_of_birth_lbl.Size = new System.Drawing.Size(89, 13);
            this.date_of_birth_lbl.TabIndex = 58;
            this.date_of_birth_lbl.Text = "Дата рождения:";
            this.date_of_birth_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // writer_name_lbl
            // 
            this.writer_name_lbl.AutoSize = true;
            this.writer_name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writer_name_lbl.Location = new System.Drawing.Point(728, 468);
            this.writer_name_lbl.Name = "writer_name_lbl";
            this.writer_name_lbl.Size = new System.Drawing.Size(64, 13);
            this.writer_name_lbl.TabIndex = 57;
            this.writer_name_lbl.Text = "Писатель";
            this.writer_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.icon_picture.TabIndex = 56;
            this.icon_picture.TabStop = false;
            // 
            // next_btn
            // 
            this.next_btn.Location = new System.Drawing.Point(722, 425);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(75, 23);
            this.next_btn.TabIndex = 55;
            this.next_btn.Text = "Вперед";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Visible = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(722, 32);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 54;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Visible = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(534, 87);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(420, 282);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 53;
            this.picture.TabStop = false;
            // 
            // web
            // 
            this.web.Dock = System.Windows.Forms.DockStyle.Left;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(500, 661);
            this.web.TabIndex = 52;
            // 
            // date_of_death_lbl
            // 
            this.date_of_death_lbl.AutoSize = true;
            this.date_of_death_lbl.Location = new System.Drawing.Point(721, 547);
            this.date_of_death_lbl.Name = "date_of_death_lbl";
            this.date_of_death_lbl.Size = new System.Drawing.Size(76, 13);
            this.date_of_death_lbl.TabIndex = 61;
            this.date_of_death_lbl.Text = "Дата смерти:";
            this.date_of_death_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // place_of_death_lbl
            // 
            this.place_of_death_lbl.AutoSize = true;
            this.place_of_death_lbl.Location = new System.Drawing.Point(719, 626);
            this.place_of_death_lbl.Name = "place_of_death_lbl";
            this.place_of_death_lbl.Size = new System.Drawing.Size(82, 13);
            this.place_of_death_lbl.TabIndex = 62;
            this.place_of_death_lbl.Text = "Место смерти:";
            // 
            // WriterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.place_of_death_lbl);
            this.Controls.Add(this.date_of_death_lbl);
            this.Controls.Add(this.picture_name_lbl);
            this.Controls.Add(this.place_of_birth_lbl);
            this.Controls.Add(this.date_of_birth_lbl);
            this.Controls.Add(this.writer_name_lbl);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.web);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WriterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label picture_name_lbl;
        private System.Windows.Forms.Label place_of_birth_lbl;
        private System.Windows.Forms.Label date_of_birth_lbl;
        private System.Windows.Forms.Label writer_name_lbl;
        private System.Windows.Forms.PictureBox icon_picture;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.Label date_of_death_lbl;
        private System.Windows.Forms.Label place_of_death_lbl;
    }
}