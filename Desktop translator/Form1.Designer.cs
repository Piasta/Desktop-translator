namespace Desktop_translator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.settings_bt = new System.Windows.Forms.Button();
            this.translate_bt = new System.Windows.Forms.Button();
            this.info_bt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_bt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.translateControlPanel1 = new Desktop_translator.translateControlPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.settings_bt);
            this.panel1.Controls.Add(this.translate_bt);
            this.panel1.Controls.Add(this.info_bt);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 542);
            this.panel1.TabIndex = 0;
            // 
            // settings_bt
            // 
            this.settings_bt.FlatAppearance.BorderSize = 0;
            this.settings_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.settings_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.settings_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_bt.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settings_bt.ForeColor = System.Drawing.Color.GhostWhite;
            this.settings_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_bt.Location = new System.Drawing.Point(0, 374);
            this.settings_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settings_bt.Name = "settings_bt";
            this.settings_bt.Size = new System.Drawing.Size(141, 62);
            this.settings_bt.TabIndex = 2;
            this.settings_bt.Text = "Options";
            this.settings_bt.UseVisualStyleBackColor = true;
            // 
            // translate_bt
            // 
            this.translate_bt.FlatAppearance.BorderSize = 0;
            this.translate_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.translate_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.translate_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.translate_bt.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.translate_bt.ForeColor = System.Drawing.Color.GhostWhite;
            this.translate_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.translate_bt.Location = new System.Drawing.Point(0, 155);
            this.translate_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.translate_bt.Name = "translate_bt";
            this.translate_bt.Size = new System.Drawing.Size(141, 62);
            this.translate_bt.TabIndex = 0;
            this.translate_bt.Text = "Translate";
            this.translate_bt.UseVisualStyleBackColor = true;
            this.translate_bt.Click += new System.EventHandler(this.translate_bt_Click);
            // 
            // info_bt
            // 
            this.info_bt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.info_bt.FlatAppearance.BorderSize = 0;
            this.info_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.info_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.info_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info_bt.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info_bt.ForeColor = System.Drawing.Color.GhostWhite;
            this.info_bt.Image = ((System.Drawing.Image)(resources.GetObject("info_bt.Image")));
            this.info_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.info_bt.Location = new System.Drawing.Point(0, 459);
            this.info_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.info_bt.Name = "info_bt";
            this.info_bt.Size = new System.Drawing.Size(141, 62);
            this.info_bt.TabIndex = 0;
            this.info_bt.Text = "Info";
            this.info_bt.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // exit_bt
            // 
            this.exit_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bt.BackgroundImage")));
            this.exit_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_bt.FlatAppearance.BorderSize = 0;
            this.exit_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.exit_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bt.ForeColor = System.Drawing.Color.Cornsilk;
            this.exit_bt.Location = new System.Drawing.Point(795, 0);
            this.exit_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(45, 34);
            this.exit_bt.TabIndex = 1;
            this.exit_bt.UseVisualStyleBackColor = true;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.exit_bt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(141, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 34);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.BackgroundImage = global::Desktop_translator.Properties.Resources.off;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(747, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 34);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // translateControlPanel1
            // 
            this.translateControlPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.translateControlPanel1.Location = new System.Drawing.Point(141, 34);
            this.translateControlPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.translateControlPanel1.Name = "translateControlPanel1";
            this.translateControlPanel1.Size = new System.Drawing.Size(840, 507);
            this.translateControlPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(981, 542);
            this.Controls.Add(this.translateControlPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "ss";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button info_bt;
        internal System.Windows.Forms.Button exit_bt;
        private System.Windows.Forms.Button settings_bt;
        private System.Windows.Forms.Button translate_bt;
        public System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Panel panel1;
        private translateControlPanel translateControlPanel1;
        private System.Windows.Forms.Button button1;
    }
}

