namespace WindowsFormsApp7
{
    partial class Calender
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calender));
            this.axCalendar1 = new AxCALENDARLib.AxCalendar();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btn_go = new System.Windows.Forms.Button();
            this.btn_pred = new System.Windows.Forms.Button();
            this.btn_succ = new System.Windows.Forms.Button();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.taskImport = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.taskTittle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar1)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            this.SuspendLayout();
            // 
            // axCalendar1
            // 
            this.axCalendar1.Enabled = true;
            this.axCalendar1.Location = new System.Drawing.Point(28, 78);
            this.axCalendar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.axCalendar1.Name = "axCalendar1";
            this.axCalendar1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCalendar1.OcxState")));
            this.axCalendar1.Size = new System.Drawing.Size(815, 544);
            this.axCalendar1.TabIndex = 0;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(256, 55);
            this.dtp.Margin = new System.Windows.Forms.Padding(4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(221, 22);
            this.dtp.TabIndex = 11;
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(487, 54);
            this.btn_go.Margin = new System.Windows.Forms.Padding(4);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(48, 28);
            this.btn_go.TabIndex = 10;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // btn_pred
            // 
            this.btn_pred.Location = new System.Drawing.Point(790, 54);
            this.btn_pred.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pred.Name = "btn_pred";
            this.btn_pred.Size = new System.Drawing.Size(48, 28);
            this.btn_pred.TabIndex = 9;
            this.btn_pred.Text = "<";
            this.btn_pred.UseVisualStyleBackColor = true;
            this.btn_pred.Click += new System.EventHandler(this.btn_pred_Click_1);
            // 
            // btn_succ
            // 
            this.btn_succ.Location = new System.Drawing.Point(846, 54);
            this.btn_succ.Margin = new System.Windows.Forms.Padding(4);
            this.btn_succ.Name = "btn_succ";
            this.btn_succ.Size = new System.Drawing.Size(48, 28);
            this.btn_succ.TabIndex = 8;
            this.btn_succ.Text = ">";
            this.btn_succ.UseVisualStyleBackColor = true;
            this.btn_succ.Click += new System.EventHandler(this.btn_succ_Click);
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuCards3.Controls.Add(this.taskImport);
            this.bunifuCards3.Controls.Add(this.btn_search);
            this.bunifuCards3.Controls.Add(this.label18);
            this.bunifuCards3.Controls.Add(this.taskTittle);
            this.bunifuCards3.Controls.Add(this.label7);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(1167, 113);
            this.bunifuCards3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(367, 238);
            this.bunifuCards3.TabIndex = 69;
            // 
            // taskImport
            // 
            this.taskImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.taskImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.taskImport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskImport.FormattingEnabled = true;
            this.taskImport.Items.AddRange(new object[] {
            "Crucial ",
            "Important",
            "Medium",
            "Low "});
            this.taskImport.Location = new System.Drawing.Point(198, 127);
            this.taskImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskImport.Name = "taskImport";
            this.taskImport.Size = new System.Drawing.Size(146, 33);
            this.taskImport.TabIndex = 70;
            this.taskImport.SelectedIndexChanged += new System.EventHandler(this.taskImport_SelectedIndexChanged);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Gold;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_search.Location = new System.Drawing.Point(256, 178);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 43);
            this.btn_search.TabIndex = 69;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(20, 131);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 23);
            this.label18.TabIndex = 63;
            this.label18.Text = "Task importance :";
            // 
            // taskTittle
            // 
            this.taskTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.taskTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskTittle.Location = new System.Drawing.Point(198, 37);
            this.taskTittle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskTittle.Name = "taskTittle";
            this.taskTittle.Size = new System.Drawing.Size(146, 23);
            this.taskTittle.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(20, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Task title :";
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.btn_pred);
            this.Controls.Add(this.btn_succ);
            this.Controls.Add(this.axCalendar1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calender";
            this.Size = new System.Drawing.Size(1561, 790);
            this.Load += new System.EventHandler(this.Calender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar1)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxCALENDARLib.AxCalendar axCalendar1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Button btn_pred;
        private System.Windows.Forms.Button btn_succ;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox taskTittle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox taskImport;
    }
}
