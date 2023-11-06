namespace VSKalkulacka
{
    partial class Polynomy
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
            this.tb_polynom = new System.Windows.Forms.TextBox();
            this.bt_vypocist = new System.Windows.Forms.Button();
            this.lb_reseni = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tb_polynom
            // 
            this.tb_polynom.Location = new System.Drawing.Point(12, 12);
            this.tb_polynom.Name = "tb_polynom";
            this.tb_polynom.Size = new System.Drawing.Size(536, 20);
            this.tb_polynom.TabIndex = 0;
            // 
            // bt_vypocist
            // 
            this.bt_vypocist.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_vypocist.Location = new System.Drawing.Point(578, 12);
            this.bt_vypocist.Name = "bt_vypocist";
            this.bt_vypocist.Size = new System.Drawing.Size(122, 44);
            this.bt_vypocist.TabIndex = 1;
            this.bt_vypocist.Text = "Submit";
            this.bt_vypocist.UseVisualStyleBackColor = true;
            this.bt_vypocist.Click += new System.EventHandler(this.bt_vypocist_Click);
            // 
            // lb_reseni
            // 
            this.lb_reseni.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_reseni.FormattingEnabled = true;
            this.lb_reseni.ItemHeight = 27;
            this.lb_reseni.Items.AddRange(new object[] {
            "Rešení: "});
            this.lb_reseni.Location = new System.Drawing.Point(12, 55);
            this.lb_reseni.Name = "lb_reseni";
            this.lb_reseni.Size = new System.Drawing.Size(191, 139);
            this.lb_reseni.TabIndex = 2;
            // 
            // Polynomy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_reseni);
            this.Controls.Add(this.bt_vypocist);
            this.Controls.Add(this.tb_polynom);
            this.Name = "Polynomy";
            this.Text = "Polynomy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Polynomy_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_polynom;
        private System.Windows.Forms.Button bt_vypocist;
        private System.Windows.Forms.ListBox lb_reseni;
    }
}