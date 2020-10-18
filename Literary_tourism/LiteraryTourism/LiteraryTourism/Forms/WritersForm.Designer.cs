namespace LiteraryTourism.Forms
{
    partial class WritersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WritersForm));
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.data_writers = new System.Windows.Forms.DataGridView();
            this.dfull_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddate_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddate_of_death = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dplace_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dplace_of_death = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_btn = new System.Windows.Forms.Button();
            this.icon_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_writers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(25, 75);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(616, 20);
            this.search_txt.TabIndex = 2;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(662, 75);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 20);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "Поиск";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // data_writers
            // 
            this.data_writers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_writers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_writers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dfull_name,
            this.ddate_of_birth,
            this.ddate_of_death,
            this.dplace_of_birth,
            this.dplace_of_death});
            this.data_writers.Location = new System.Drawing.Point(25, 118);
            this.data_writers.Name = "data_writers";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_writers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_writers.Size = new System.Drawing.Size(712, 262);
            this.data_writers.TabIndex = 4;
            this.data_writers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_writers_CellContentDoubleClick);
            // 
            // dfull_name
            // 
            this.dfull_name.HeaderText = "Автор";
            this.dfull_name.Name = "dfull_name";
            this.dfull_name.ReadOnly = true;
            this.dfull_name.Width = 150;
            // 
            // ddate_of_birth
            // 
            this.ddate_of_birth.HeaderText = "Дата рождения";
            this.ddate_of_birth.Name = "ddate_of_birth";
            this.ddate_of_birth.ReadOnly = true;
            // 
            // ddate_of_death
            // 
            this.ddate_of_death.HeaderText = "Дата смерти";
            this.ddate_of_death.Name = "ddate_of_death";
            this.ddate_of_death.ReadOnly = true;
            // 
            // dplace_of_birth
            // 
            this.dplace_of_birth.HeaderText = "Место рождения";
            this.dplace_of_birth.Name = "dplace_of_birth";
            this.dplace_of_birth.ReadOnly = true;
            this.dplace_of_birth.Width = 150;
            // 
            // dplace_of_death
            // 
            this.dplace_of_death.HeaderText = "Место смерти";
            this.dplace_of_death.Name = "dplace_of_death";
            this.dplace_of_death.ReadOnly = true;
            this.dplace_of_death.Width = 150;
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(25, 407);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 8;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // icon_picture
            // 
            this.icon_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.icon_picture.Enabled = false;
            this.icon_picture.Image = global::LiteraryTourism.Properties.Resources.icon;
            this.icon_picture.Location = new System.Drawing.Point(625, 3);
            this.icon_picture.Name = "icon_picture";
            this.icon_picture.Size = new System.Drawing.Size(112, 57);
            this.icon_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_picture.TabIndex = 15;
            this.icon_picture.TabStop = false;
            // 
            // WritersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.icon_picture);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.data_writers);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WritersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            ((System.ComponentModel.ISupportInitialize)(this.data_writers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView data_writers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dfull_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddate_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddate_of_death;
        private System.Windows.Forms.DataGridViewTextBoxColumn dplace_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dplace_of_death;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox icon_picture;
    }
}