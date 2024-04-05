namespace WindowsFormsApp7
{
    partial class Message
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
            this.mess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.object_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.Label();
            this.taskTittle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TaskID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bunifuCards7 = new Bunifu.Framework.UI.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuCards6 = new Bunifu.Framework.UI.BunifuCards();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCards7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bunifuCards6.SuspendLayout();
            this.SuspendLayout();
            // 
            // mess
            // 
            this.mess.HeaderText = "Messgae";
            this.mess.MinimumWidth = 6;
            this.mess.Name = "mess";
            this.mess.ReadOnly = true;
            this.mess.Width = 125;
            // 
            // to_name
            // 
            this.to_name.HeaderText = "To";
            this.to_name.MinimumWidth = 6;
            this.to_name.Name = "to_name";
            this.to_name.ReadOnly = true;
            this.to_name.Width = 125;
            // 
            // Task_ID
            // 
            this.Task_ID.HeaderText = "ID";
            this.Task_ID.MinimumWidth = 6;
            this.Task_ID.Name = "Task_ID";
            this.Task_ID.ReadOnly = true;
            this.Task_ID.Width = 125;
            // 
            // object_type
            // 
            this.object_type.HeaderText = "Object";
            this.object_type.MinimumWidth = 6;
            this.object_type.Name = "object_type";
            this.object_type.ReadOnly = true;
            this.object_type.Width = 125;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuCards3.Controls.Add(this.textBox1);
            this.bunifuCards3.Controls.Add(this.note);
            this.bunifuCards3.Controls.Add(this.taskTittle);
            this.bunifuCards3.Controls.Add(this.label7);
            this.bunifuCards3.Controls.Add(this.TaskID);
            this.bunifuCards3.Controls.Add(this.label15);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(712, 58);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(694, 578);
            this.bunifuCards3.TabIndex = 71;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(43, 162);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(622, 372);
            this.textBox1.TabIndex = 66;
            this.textBox1.Text = "Say Hello...";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note.Location = new System.Drawing.Point(39, 121);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(107, 23);
            this.note.TabIndex = 65;
            this.note.Text = "Message :";
            // 
            // taskTittle
            // 
            this.taskTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.taskTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTittle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taskTittle.Location = new System.Drawing.Point(268, 68);
            this.taskTittle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskTittle.Name = "taskTittle";
            this.taskTittle.Size = new System.Drawing.Size(249, 23);
            this.taskTittle.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(39, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Object:";
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
            this.TaskID.Size = new System.Drawing.Size(249, 23);
            this.TaskID.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(41, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 23);
            this.label15.TabIndex = 54;
            this.label15.Text = "To:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(14, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 67;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button4.Location = new System.Drawing.Point(362, 28);
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
            this.button3.Location = new System.Drawing.Point(246, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 38);
            this.button3.TabIndex = 69;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
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
            this.bunifuCards7.Location = new System.Drawing.Point(34, 58);
            this.bunifuCards7.Name = "bunifuCards7";
            this.bunifuCards7.RightSahddow = true;
            this.bunifuCards7.ShadowDepth = 20;
            this.bunifuCards7.Size = new System.Drawing.Size(608, 727);
            this.bunifuCards7.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "Message List:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task_ID,
            this.to_name,
            this.object_type,
            this.mess});
            this.dataGridView1.Location = new System.Drawing.Point(24, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 656);
            this.dataGridView1.TabIndex = 1;
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
            this.bunifuCards6.Location = new System.Drawing.Point(712, 697);
            this.bunifuCards6.Name = "bunifuCards6";
            this.bunifuCards6.RightSahddow = true;
            this.bunifuCards6.ShadowDepth = 20;
            this.bunifuCards6.Size = new System.Drawing.Size(487, 88);
            this.bunifuCards6.TabIndex = 72;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(130, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 38);
            this.button2.TabIndex = 68;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards7);
            this.Controls.Add(this.bunifuCards6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Message";
            this.Size = new System.Drawing.Size(1443, 812);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.bunifuCards7.ResumeLayout(false);
            this.bunifuCards7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bunifuCards6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn mess;
        private System.Windows.Forms.DataGridViewTextBoxColumn to_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn object_type;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.TextBox taskTittle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TaskID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuCards bunifuCards7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}
