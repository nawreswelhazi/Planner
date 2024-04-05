namespace WindowsFormsApp7
{
    partial class Task
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
            this.Task_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Task_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task_impo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dureetask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards6 = new Bunifu.Framework.UI.BunifuCards();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.label19 = new System.Windows.Forms.Label();
            this.duree = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.Label();
            this.taskImport = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.taskType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.taskDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.taskTittle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TaskID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.F_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bunifuCards6.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards7
            // 
            this.bunifuCards7.BackColor = System.Drawing.Color.White;
            this.bunifuCards7.BorderRadius = 5;
            this.bunifuCards7.BottomSahddow = true;
            this.bunifuCards7.color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.bunifuCards7.Controls.Add(this.dataGridView2);
            this.bunifuCards7.Controls.Add(this.label3);
            this.bunifuCards7.Controls.Add(this.label1);
            this.bunifuCards7.Controls.Add(this.dataGridView1);
            this.bunifuCards7.LeftSahddow = false;
            this.bunifuCards7.Location = new System.Drawing.Point(41, 27);
            this.bunifuCards7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards7.Name = "bunifuCards7";
            this.bunifuCards7.RightSahddow = true;
            this.bunifuCards7.ShadowDepth = 20;
            this.bunifuCards7.Size = new System.Drawing.Size(959, 714);
            this.bunifuCards7.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 69;
            this.label1.Text = "Task list :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task_ID,
            this.Task_title,
            this.Task_Type,
            this.task_date,
            this.task_impo,
            this.notes,
            this.Dureetask});
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(924, 174);
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
            // Task_title
            // 
            this.Task_title.HeaderText = "Task Title";
            this.Task_title.MinimumWidth = 6;
            this.Task_title.Name = "Task_title";
            this.Task_title.ReadOnly = true;
            this.Task_title.Width = 125;
            // 
            // Task_Type
            // 
            this.Task_Type.HeaderText = "Task Type";
            this.Task_Type.MinimumWidth = 6;
            this.Task_Type.Name = "Task_Type";
            this.Task_Type.ReadOnly = true;
            this.Task_Type.Width = 125;
            // 
            // task_date
            // 
            this.task_date.HeaderText = "Task date";
            this.task_date.MinimumWidth = 6;
            this.task_date.Name = "task_date";
            this.task_date.ReadOnly = true;
            this.task_date.Width = 125;
            // 
            // task_impo
            // 
            this.task_impo.HeaderText = "Importance";
            this.task_impo.MinimumWidth = 6;
            this.task_impo.Name = "task_impo";
            this.task_impo.ReadOnly = true;
            this.task_impo.Width = 125;
            // 
            // notes
            // 
            this.notes.HeaderText = "Note";
            this.notes.MinimumWidth = 6;
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            this.notes.Width = 125;
            // 
            // Dureetask
            // 
            this.Dureetask.HeaderText = "Duration";
            this.Dureetask.MinimumWidth = 6;
            this.Dureetask.Name = "Dureetask";
            this.Dureetask.ReadOnly = true;
            this.Dureetask.Width = 125;
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
            this.bunifuCards6.Location = new System.Drawing.Point(1031, 654);
            this.bunifuCards6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards6.Name = "bunifuCards6";
            this.bunifuCards6.RightSahddow = true;
            this.bunifuCards6.ShadowDepth = 20;
            this.bunifuCards6.Size = new System.Drawing.Size(498, 87);
            this.bunifuCards6.TabIndex = 69;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button4.Location = new System.Drawing.Point(370, 30);
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
            this.button3.Location = new System.Drawing.Point(255, 30);
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
            this.button2.Location = new System.Drawing.Point(140, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 38);
            this.button2.TabIndex = 68;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(25, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 38);
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
            this.bunifuCards3.Controls.Add(this.button5);
            this.bunifuCards3.Controls.Add(this.textBox2);
            this.bunifuCards3.Controls.Add(this.label2);
            this.bunifuCards3.Controls.Add(this.label19);
            this.bunifuCards3.Controls.Add(this.duree);
            this.bunifuCards3.Controls.Add(this.textBox1);
            this.bunifuCards3.Controls.Add(this.note);
            this.bunifuCards3.Controls.Add(this.taskImport);
            this.bunifuCards3.Controls.Add(this.label18);
            this.bunifuCards3.Controls.Add(this.taskType);
            this.bunifuCards3.Controls.Add(this.label17);
            this.bunifuCards3.Controls.Add(this.taskDate);
            this.bunifuCards3.Controls.Add(this.label16);
            this.bunifuCards3.Controls.Add(this.taskTittle);
            this.bunifuCards3.Controls.Add(this.label7);
            this.bunifuCards3.Controls.Add(this.TaskID);
            this.bunifuCards3.Controls.Add(this.label15);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(1030, 27);
            this.bunifuCards3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(540, 623);
            this.bunifuCards3.TabIndex = 68;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(39, 281);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 23);
            this.label19.TabIndex = 68;
            this.label19.Text = "Duration :";
            // 
            // duree
            // 
            this.duree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.duree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.duree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.duree.Location = new System.Drawing.Point(268, 281);
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
            this.textBox1.Location = new System.Drawing.Point(41, 431);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(423, 137);
            this.textBox1.TabIndex = 66;
            this.textBox1.Text = "Write here...";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note.Location = new System.Drawing.Point(39, 402);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(128, 23);
            this.note.TabIndex = 65;
            this.note.Text = "Description :";
            // 
            // taskImport
            // 
            this.taskImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.taskImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.taskImport.FormattingEnabled = true;
            this.taskImport.Items.AddRange(new object[] {
            "Crucial ",
            "Important",
            "Medium",
            "Low "});
            this.taskImport.Location = new System.Drawing.Point(268, 226);
            this.taskImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskImport.Name = "taskImport";
            this.taskImport.Size = new System.Drawing.Size(200, 33);
            this.taskImport.TabIndex = 64;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(39, 230);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 23);
            this.label18.TabIndex = 63;
            this.label18.Text = "Task importance :";
            // 
            // taskType
            // 
            this.taskType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.taskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.taskType.FormattingEnabled = true;
            this.taskType.Location = new System.Drawing.Point(268, 167);
            this.taskType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taskType.Name = "taskType";
            this.taskType.Size = new System.Drawing.Size(200, 33);
            this.taskType.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(39, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 23);
            this.label17.TabIndex = 61;
            this.label17.Text = "Task type :";
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
            this.label16.Size = new System.Drawing.Size(115, 23);
            this.label16.TabIndex = 59;
            this.label16.Text = "Task date :";
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
            this.label7.Size = new System.Drawing.Size(102, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Task title :";
            // 
            // TaskID
            // 
            this.TaskID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.TaskID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TaskID.Location = new System.Drawing.Point(268, 18);
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
            this.label15.Size = new System.Drawing.Size(87, 23);
            this.label15.TabIndex = 54;
            this.label15.Text = "Task ID :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(269, 326);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 23);
            this.textBox2.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(41, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "People involved :";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gold;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.button5.Location = new System.Drawing.Point(485, 320);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 32);
            this.button5.TabIndex = 71;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(21, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 71;
            this.label3.Text = "Familly list :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F_name,
            this.Last_name,
            this.age,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(25, 521);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(677, 174);
            this.dataGridView2.TabIndex = 72;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Task type";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Note";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCards7);
            this.Controls.Add(this.bunifuCards6);
            this.Controls.Add(this.bunifuCards3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Task";
            this.Size = new System.Drawing.Size(1609, 777);
            this.bunifuCards7.ResumeLayout(false);
            this.bunifuCards7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bunifuCards6.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn task_impo;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dureetask;
        private Bunifu.Framework.UI.BunifuCards bunifuCards6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox duree;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.ComboBox taskImport;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox taskType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker taskDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox taskTittle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TaskID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
