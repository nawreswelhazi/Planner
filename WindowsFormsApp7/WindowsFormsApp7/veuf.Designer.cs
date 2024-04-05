namespace WindowsFormsApp7
{
    partial class veuf
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
            this.txtnbr = new System.Windows.Forms.TextBox();
            this.rbo = new System.Windows.Forms.RadioButton();
            this.rbn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_val = new System.Windows.Forms.Button();
            this.btn_valid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnbr
            // 
            this.txtnbr.Location = new System.Drawing.Point(109, 83);
            this.txtnbr.Name = "txtnbr";
            this.txtnbr.Size = new System.Drawing.Size(79, 20);
            this.txtnbr.TabIndex = 140;
            // 
            // rbo
            // 
            this.rbo.AutoSize = true;
            this.rbo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.rbo.ForeColor = System.Drawing.SystemColors.Control;
            this.rbo.Location = new System.Drawing.Point(63, 80);
            this.rbo.Margin = new System.Windows.Forms.Padding(2);
            this.rbo.Name = "rbo";
            this.rbo.Size = new System.Drawing.Size(48, 23);
            this.rbo.TabIndex = 139;
            this.rbo.TabStop = true;
            this.rbo.Text = "Yes";
            this.rbo.UseVisualStyleBackColor = true;
            this.rbo.CheckedChanged += new System.EventHandler(this.rbo_CheckedChanged);
            // 
            // rbn
            // 
            this.rbn.AutoSize = true;
            this.rbn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.rbn.ForeColor = System.Drawing.SystemColors.Control;
            this.rbn.Location = new System.Drawing.Point(191, 80);
            this.rbn.Margin = new System.Windows.Forms.Padding(2);
            this.rbn.Name = "rbn";
            this.rbn.Size = new System.Drawing.Size(46, 23);
            this.rbn.TabIndex = 137;
            this.rbn.TabStop = true;
            this.rbn.Text = "No";
            this.rbn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(77, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 21);
            this.label6.TabIndex = 138;
            this.label6.Text = "You have kids ?";
            // 
            // btn_val
            // 
            this.btn_val.BackColor = System.Drawing.Color.Gold;
            this.btn_val.Location = new System.Drawing.Point(39, 512);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(72, 27);
            this.btn_val.TabIndex = 136;
            this.btn_val.Text = "Next";
            this.btn_val.UseVisualStyleBackColor = false;
            this.btn_val.Click += new System.EventHandler(this.btn_val_Click);
            // 
            // btn_valid
            // 
            this.btn_valid.BackColor = System.Drawing.Color.Gold;
            this.btn_valid.Location = new System.Drawing.Point(207, 512);
            this.btn_valid.Name = "btn_valid";
            this.btn_valid.Size = new System.Drawing.Size(72, 27);
            this.btn_valid.TabIndex = 141;
            this.btn_valid.Text = "Valider";
            this.btn_valid.UseVisualStyleBackColor = false;
            this.btn_valid.Click += new System.EventHandler(this.btn_valid_Click);
            // 
            // veuf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(360, 579);
            this.Controls.Add(this.btn_valid);
            this.Controls.Add(this.txtnbr);
            this.Controls.Add(this.rbo);
            this.Controls.Add(this.rbn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_val);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "veuf";
            this.Text = "veuf";
            this.Load += new System.EventHandler(this.veuf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnbr;
        private System.Windows.Forms.RadioButton rbo;
        private System.Windows.Forms.RadioButton rbn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_val;
        private System.Windows.Forms.Button btn_valid;
    }
}