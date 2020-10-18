namespace LiteraryTourism.Forms
{
    partial class AddRouteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRouteForm));
            this.route_name_lbl = new System.Windows.Forms.Label();
            this.route_name_txt = new System.Windows.Forms.TextBox();
            this.writers_combo = new System.Windows.Forms.ComboBox();
            this.writer_lbl = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // route_name_lbl
            // 
            this.route_name_lbl.AutoSize = true;
            this.route_name_lbl.Location = new System.Drawing.Point(132, 93);
            this.route_name_lbl.Name = "route_name_lbl";
            this.route_name_lbl.Size = new System.Drawing.Size(110, 13);
            this.route_name_lbl.TabIndex = 0;
            this.route_name_lbl.Text = "Название маршрута";
            // 
            // route_name_txt
            // 
            this.route_name_txt.Location = new System.Drawing.Point(104, 125);
            this.route_name_txt.Name = "route_name_txt";
            this.route_name_txt.Size = new System.Drawing.Size(167, 20);
            this.route_name_txt.TabIndex = 1;
            // 
            // writers_combo
            // 
            this.writers_combo.FormattingEnabled = true;
            this.writers_combo.Location = new System.Drawing.Point(104, 247);
            this.writers_combo.Name = "writers_combo";
            this.writers_combo.Size = new System.Drawing.Size(167, 21);
            this.writers_combo.TabIndex = 2;
            // 
            // writer_lbl
            // 
            this.writer_lbl.AutoSize = true;
            this.writer_lbl.Location = new System.Drawing.Point(157, 217);
            this.writer_lbl.Name = "writer_lbl";
            this.writer_lbl.Size = new System.Drawing.Size(56, 13);
            this.writer_lbl.TabIndex = 3;
            this.writer_lbl.Text = "Писатель";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(147, 361);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // AddRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.writer_lbl);
            this.Controls.Add(this.writers_combo);
            this.Controls.Add(this.route_name_txt);
            this.Controls.Add(this.route_name_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRouteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛитераТУРа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label route_name_lbl;
        private System.Windows.Forms.TextBox route_name_txt;
        private System.Windows.Forms.ComboBox writers_combo;
        private System.Windows.Forms.Label writer_lbl;
        private System.Windows.Forms.Button add_btn;
    }
}