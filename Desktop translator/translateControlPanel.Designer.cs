namespace Desktop_translator
{
    partial class translateControlPanel
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_rtbx = new System.Windows.Forms.RichTextBox();
            this.translatetxt_bt = new System.Windows.Forms.Button();
            this.output_rtbx = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // input_rtbx
            // 
            this.input_rtbx.BackColor = System.Drawing.Color.White;
            this.input_rtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_rtbx.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.input_rtbx.Location = new System.Drawing.Point(124, 94);
            this.input_rtbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.input_rtbx.Name = "input_rtbx";
            this.input_rtbx.Size = new System.Drawing.Size(591, 73);
            this.input_rtbx.TabIndex = 0;
            this.input_rtbx.Text = "";
            this.input_rtbx.TextChanged += new System.EventHandler(this.input_rtbx_TextChanged);
            // 
            // translatetxt_bt
            // 
            this.translatetxt_bt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.translatetxt_bt.FlatAppearance.BorderSize = 0;
            this.translatetxt_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.translatetxt_bt.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.translatetxt_bt.ForeColor = System.Drawing.SystemColors.Window;
            this.translatetxt_bt.Location = new System.Drawing.Point(263, 327);
            this.translatetxt_bt.Margin = new System.Windows.Forms.Padding(0);
            this.translatetxt_bt.Name = "translatetxt_bt";
            this.translatetxt_bt.Size = new System.Drawing.Size(316, 42);
            this.translatetxt_bt.TabIndex = 1;
            this.translatetxt_bt.Text = "Translate";
            this.translatetxt_bt.UseVisualStyleBackColor = false;
            this.translatetxt_bt.Click += new System.EventHandler(this.translatetxt_bt_Click);
            // 
            // output_rtbx
            // 
            this.output_rtbx.BackColor = System.Drawing.Color.White;
            this.output_rtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output_rtbx.Enabled = false;
            this.output_rtbx.Font = new System.Drawing.Font("Century", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.output_rtbx.Location = new System.Drawing.Point(124, 204);
            this.output_rtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.output_rtbx.Name = "output_rtbx";
            this.output_rtbx.Size = new System.Drawing.Size(591, 73);
            this.output_rtbx.TabIndex = 2;
            this.output_rtbx.Text = "";
            // 
            // translateControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.output_rtbx);
            this.Controls.Add(this.translatetxt_bt);
            this.Controls.Add(this.input_rtbx);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "translateControlPanel";
            this.Size = new System.Drawing.Size(840, 507);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button translatetxt_bt;
        public System.Windows.Forms.RichTextBox output_rtbx;
        public System.Windows.Forms.RichTextBox input_rtbx;
    }
}
