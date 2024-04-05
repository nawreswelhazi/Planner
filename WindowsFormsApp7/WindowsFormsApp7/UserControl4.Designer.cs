namespace WindowsFormsApp7
{
    partial class family
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.F_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards6 = new Bunifu.Framework.UI.BunifuCards();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.taskType = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.taskTittle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TaskID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
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
            this.bunifuCards7.Controls.Add(this.label1);
            this.bunifuCards7.Controls.Add(this.dataGridView1);
            this.bunifuCards7.LeftSahddow = false;
            this.bunifuCards7.Location = new System.Drawing.Point(11, 38);
            this.bunifuCards7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards7.Name = "bunifuCards7";
            this.bunifuCards7.RightSahddow = true;
            this.bunifuCards7.ShadowDepth = 20;
            this.bunifuCards7.Size = new System.Drawing.Size(822, 758);
            this.bunifuCards7.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 71;
            this.label1.Text = "Family List :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F_name,
            this.Last_name,
            this.age,
            this.task_type,
            this.notes});
            this.dataGridView1.Location = new System.Drawing.Point(42, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 174);
            this.dataGridView1.TabIndex = 1;
            // 
            // F_name
            // 
            this.F_name.HeaderText = "First Name";
            this.F_name.MinimumWidth = 6;
            this.F_name.Name = "F_name";
            this.F_name.ReadOnly = true;
            this.F_name.Width = 125;
            // 
            // Last_name
            // 
            this.Last_name.HeaderText = "Last Name";
            this.Last_name.MinimumWidth = 6;
            this.Last_name.Name = "Last_name";
            this.Last_name.ReadOnly = true;
            this.Last_name.Width = 125;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 125;
            // 
            // task_type
            // 
            this.task_type.HeaderText = "Task type";
            this.task_type.MinimumWidth = 6;
            this.task_type.Name = "task_type";
            this.task_type.ReadOnly = true;
            this.task_type.Width = 125;
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
            this.bunifuCards6.LeftSahddow = false;
            this.bunifuCards6.Location = new System.Drawing.Point(905, 692);
            this.bunifuCards6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards6.Name = "bunifuCards6";
            this.bunifuCards6.RightSahddow = true;
            this.bunifuCards6.ShadowDepth = 20;
            this.bunifuCards6.Size = new System.Drawing.Size(497, 83);
            this.bunifuCards6.TabIndex = 69;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button4.Location = new System.Drawing.Point(313, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 38);
            this.button4.TabIndex = 70;
            this.button4.Text = "Clear all";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button3.Location = new System.Drawing.Point(198, 23);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 38);
            this.button3.TabIndex = 69;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(83, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 38);
            this.button2.TabIndex = 68;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuCards3.Controls.Add(this.textBox2);
            this.bunifuCards3.Controls.Add(this.taskType);
            this.bunifuCards3.Controls.Add(this.textBox1);
            this.bunifuCards3.Controls.Add(this.note);
            this.bunifuCards3.Controls.Add(this.label17);
            this.bunifuCards3.Controls.Add(this.label16);
            this.bunifuCards3.Controls.Add(this.taskTittle);
            this.bunifuCards3.Controls.Add(this.label7);
            this.bunifuCards3.Controls.Add(this.TaskID);
            this.bunifuCards3.Controls.Add(this.label15);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(905, 47);
            this.bunifuCards3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(497, 611);
            this.bunifuCards3.TabIndex = 68;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(239, 119);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 23);
            this.textBox2.TabIndex = 70;
            // 
            // taskType
            // 
            this.taskType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.taskType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskType.Location = new System.Drawing.Point(239, 172);
            this.taskType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskType.Name = "taskType";
            this.taskType.Size = new System.Drawing.Size(200, 23);
            this.taskType.TabIndex = 69;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(43, 285);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 280);
            this.textBox1.TabIndex = 66;
            this.textBox1.Text = "hey ..";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note.Location = new System.Drawing.Point(41, 241);
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
            this.label17.Location = new System.Drawing.Point(39, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 23);
            this.label17.TabIndex = 61;
            this.label17.Text = "Task Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(39, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 23);
            this.label16.TabIndex = 59;
            this.label16.Text = "Age :";
            // 
            // taskTittle
            // 
            this.taskTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.taskTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskTittle.Location = new System.Drawing.Point(239, 69);
            this.taskTittle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskTittle.Name = "taskTittle";
            this.taskTittle.Size = new System.Drawing.Size(200, 23);
            this.taskTittle.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(39, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Last Name :";
            // 
            // TaskID
            // 
            this.TaskID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.TaskID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TaskID.Location = new System.Drawing.Point(239, 20);
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
            this.label15.Size = new System.Drawing.Size(122, 23);
            this.label15.TabIndex = 54;
            this.label15.Text = "First Name :";
            // 
            // family
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards7);
            this.Controls.Add(this.bunifuCards6);
            this.Controls.Add(this.bunifuCards3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "family";
            this.Size = new System.Drawing.Size(1443, 812);
            this.Load += new System.EventHandler(this.family_Load);
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
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.TextBox taskTittle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TaskID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox taskType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.TextBox textBox2;
    }
}
