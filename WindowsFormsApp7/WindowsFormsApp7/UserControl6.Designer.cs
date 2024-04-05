namespace WindowsFormsApp7
{
    partial class facture
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
            this.bunifuCards7 = new Bunifu.Framework.UI.BunifuCards();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Task_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards6 = new Bunifu.Framework.UI.BunifuCards();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.duree = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.taskDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.TaskID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bunifuCards6.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards7
            // 
            this.bunifuCards7.BackColor = System.Drawing.Color.White;
            this.bunifuCards7.BorderRadius = 5;
            this.bunifuCards7.BottomSahddow = true;
            this.bunifuCards7.color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuCards7.Controls.Add(this.label2);
            this.bunifuCards7.Controls.Add(this.dataGridView1);
            this.bunifuCards7.LeftSahddow = false;
            this.bunifuCards7.Location = new System.Drawing.Point(47, 87);
            this.bunifuCards7.Name = "bunifuCards7";
            this.bunifuCards7.RightSahddow = true;
            this.bunifuCards7.ShadowDepth = 20;
            this.bunifuCards7.Size = new System.Drawing.Size(760, 694);
            this.bunifuCards7.TabIndex = 70;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task_ID,
            this.bill_Type,
            this.bill_date,
            this.pay_date,
            this.notes});
            this.dataGridView1.Location = new System.Drawing.Point(36, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(675, 174);
            this.dataGridView1.TabIndex = 1;
            // 
            // Task_ID
            // 
            this.Task_ID.HeaderText = "ID";
            this.Task_ID.MinimumWidth = 6;
            this.Task_ID.Name = "Task_ID";
            this.Task_ID.ReadOnly = true;
            this.Task_ID.Width = 125;
            // 
            // bill_Type
            // 
            this.bill_Type.HeaderText = "Bill Type";
            this.bill_Type.MinimumWidth = 6;
            this.bill_Type.Name = "bill_Type";
            this.bill_Type.ReadOnly = true;
            this.bill_Type.Width = 125;
            // 
            // bill_date
            // 
            this.bill_date.HeaderText = "Bill date";
            this.bill_date.MinimumWidth = 6;
            this.bill_date.Name = "bill_date";
            this.bill_date.ReadOnly = true;
            this.bill_date.Width = 125;
            // 
            // pay_date
            // 
            this.pay_date.HeaderText = "Payment date";
            this.pay_date.MinimumWidth = 6;
            this.pay_date.Name = "pay_date";
            this.pay_date.ReadOnly = true;
            this.pay_date.Width = 125;
            // 
            // notes
            // 
            this.notes.HeaderText = "Note";
            this.notes.MinimumWidth = 6;
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            this.notes.Width = 125;
            // 
            // bunifuCards6
            // 
            this.bunifuCards6.BackColor = System.Drawing.Color.White;
            this.bunifuCards6.BorderRadius = 5;
            this.bunifuCards6.BottomSahddow = true;
            this.bunifuCards6.color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuCards6.Controls.Add(this.button4);
            this.bunifuCards6.Controls.Add(this.button3);
            this.bunifuCards6.Controls.Add(this.button2);
            this.bunifuCards6.Controls.Add(this.button1);
            this.bunifuCards6.LeftSahddow = false;
            this.bunifuCards6.Location = new System.Drawing.Point(903, 689);
            this.bunifuCards6.Name = "bunifuCards6";
            this.bunifuCards6.RightSahddow = true;
            this.bunifuCards6.ShadowDepth = 20;
            this.bunifuCards6.Size = new System.Drawing.Size(505, 92);
            this.bunifuCards6.TabIndex = 69;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button4.Location = new System.Drawing.Point(369, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 38);
            this.button4.TabIndex = 70;
            this.button4.Text = "Clear all";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button3.Location = new System.Drawing.Point(253, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 38);
            this.button3.TabIndex = 69;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(137, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 38);
            this.button2.TabIndex = 68;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(21, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 67;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuCards3.Controls.Add(this.dateTimePicker1);
            this.bunifuCards3.Controls.Add(this.label1);
            this.bunifuCards3.Controls.Add(this.duree);
            this.bunifuCards3.Controls.Add(this.textBox1);
            this.bunifuCards3.Controls.Add(this.note);
            this.bunifuCards3.Controls.Add(this.label17);
            this.bunifuCards3.Controls.Add(this.taskDate);
            this.bunifuCards3.Controls.Add(this.label16);
            this.bunifuCards3.Controls.Add(this.TaskID);
            this.bunifuCards3.Controls.Add(this.label15);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(903, 87);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(505, 596);
            this.bunifuCards3.TabIndex = 68;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.dateTimePicker1.Location = new System.Drawing.Point(268, 174);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(39, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "Payment date :";
            // 
            // duree
            // 
            this.duree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.duree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.duree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.duree.Location = new System.Drawing.Point(268, 66);
            this.duree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(200, 23);
            this.duree.TabIndex = 67;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(43, 301);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 255);
            this.textBox1.TabIndex = 66;
            this.textBox1.Text = "Notes here...";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note.Location = new System.Drawing.Point(41, 249);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(77, 23);
            this.note.TabIndex = 65;
            this.note.Text = "Notes :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(42, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 23);
            this.label17.TabIndex = 61;
            this.label17.Text = "Bill type :";
            // 
            // taskDate
            // 
            this.taskDate.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame;
            this.taskDate.Location = new System.Drawing.Point(268, 122);
            this.taskDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskDate.Name = "taskDate";
            this.taskDate.Size = new System.Drawing.Size(200, 22);
            this.taskDate.TabIndex = 60;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(39, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 23);
            this.label16.TabIndex = 59;
            this.label16.Text = "Bill date :";
            // 
            // TaskID
            // 
            this.TaskID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.TaskID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TaskID.Location = new System.Drawing.Point(268, 19);
            this.TaskID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskID.Name = "TaskID";
            this.TaskID.Size = new System.Drawing.Size(200, 23);
            this.TaskID.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(41, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 23);
            this.label15.TabIndex = 54;
            this.label15.Text = "ID   bill:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(32, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 70;
            this.label2.Text = "Bills list";
            // 
            // facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards7);
            this.Controls.Add(this.bunifuCards6);
            this.Controls.Add(this.bunifuCards3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "facture";
            this.Size = new System.Drawing.Size(1455, 810);
            this.bunifuCards7.ResumeLayout(false);
            this.bunifuCards7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bunifuCards6.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.TextBox duree;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker taskDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TaskID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
