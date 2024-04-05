using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetActivePanel(dashbord1);
        }





        private void hideSubMenu()
        {
            panelmenufamille.Visible = false;
         
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Control"></param>
            public void SetActivePanel(UserControl Control)
        {   
            dashbord1.Visible = false;
            task1.Visible = false;
            family1.Visible = false;
            facture1.Visible = false;
            message1.Visible = false;
            calender1.Visible = false;
            settinges1.Visible = false;
            child_Bord1.Visible = false;
            parents1.Visible = false;


            Control.Visible = true;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.Panelmenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_invoice = new System.Windows.Forms.Button();
            this.panelmenufamille = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.btn_famille = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnAnnouncement = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.useradress = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.dashbord1 = new WindowsFormsApp7.dashbord();
            this.calender1 = new WindowsFormsApp7.Calender();
            this.task1 = new WindowsFormsApp7.Task();
            this.message1 = new WindowsFormsApp7.Message();
            this.family1 = new WindowsFormsApp7.family();
            this.child_Bord1 = new WindowsFormsApp7.Child_Bord();
            this.parents1 = new WindowsFormsApp7.Parents();
            this.facture1 = new WindowsFormsApp7.facture();
            this.settinges1 = new WindowsFormsApp7.settinges();
            this.button3 = new System.Windows.Forms.Button();
            this.Panel2.SuspendLayout();
            this.Panelmenu.SuspendLayout();
            this.panelmenufamille.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.Panel2.Controls.Add(this.button3);
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(267, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1235, 56);
            this.Panel2.TabIndex = 19;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label3.Location = new System.Drawing.Point(33, 16);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(108, 25);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Dashboard";
            // 
            // Panelmenu
            // 
            this.Panelmenu.AutoScroll = true;
            this.Panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Panelmenu.Controls.Add(this.button2);
            this.Panelmenu.Controls.Add(this.btn_invoice);
            this.Panelmenu.Controls.Add(this.panelmenufamille);
            this.Panelmenu.Controls.Add(this.btnLogout);
            this.Panelmenu.Controls.Add(this.pnlStats);
            this.Panelmenu.Controls.Add(this.btn_famille);
            this.Panelmenu.Controls.Add(this.btnMessages);
            this.Panelmenu.Controls.Add(this.btnAnnouncement);
            this.Panelmenu.Controls.Add(this.btnCalendar);
            this.Panelmenu.Controls.Add(this.btnDashboard);
            this.Panelmenu.Controls.Add(this.panellogo);
            this.Panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panelmenu.Location = new System.Drawing.Point(0, 0);
            this.Panelmenu.Margin = new System.Windows.Forms.Padding(4);
            this.Panelmenu.Name = "Panelmenu";
            this.Panelmenu.Size = new System.Drawing.Size(267, 753);
            this.Panelmenu.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.button2.Location = new System.Drawing.Point(13, 720);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 25);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_invoice
            // 
            this.btn_invoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_invoice.FlatAppearance.BorderSize = 0;
            this.btn_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_invoice.Image = ((System.Drawing.Image)(resources.GetObject("btn_invoice.Image")));
            this.btn_invoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_invoice.Location = new System.Drawing.Point(0, 515);
            this.btn_invoice.Margin = new System.Windows.Forms.Padding(4);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(267, 45);
            this.btn_invoice.TabIndex = 24;
            this.btn_invoice.Text = "Manage invoice";
            this.btn_invoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_invoice.UseVisualStyleBackColor = true;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // panelmenufamille
            // 
            this.panelmenufamille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(159)))), ((int)(((byte)(244)))));
            this.panelmenufamille.Controls.Add(this.button4);
            this.panelmenufamille.Controls.Add(this.button5);
            this.panelmenufamille.Controls.Add(this.button1);
            this.panelmenufamille.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelmenufamille.Location = new System.Drawing.Point(0, 391);
            this.panelmenufamille.Name = "panelmenufamille";
            this.panelmenufamille.Size = new System.Drawing.Size(267, 124);
            this.panelmenufamille.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(159)))), ((int)(((byte)(244)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 43);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(267, 45);
            this.button4.TabIndex = 12;
            this.button4.Text = "Parents Bord";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(159)))), ((int)(((byte)(244)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 4);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(267, 45);
            this.button5.TabIndex = 11;
            this.button5.Text = "Family Bord";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(159)))), ((int)(((byte)(244)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 81);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Childrens Bord";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnLogout.Location = new System.Drawing.Point(227, 720);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(27, 25);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.pnlStats.Location = new System.Drawing.Point(-1, 165);
            this.pnlStats.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(7, 42);
            this.pnlStats.TabIndex = 19;
            // 
            // btn_famille
            // 
            this.btn_famille.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btn_famille.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_famille.FlatAppearance.BorderSize = 0;
            this.btn_famille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_famille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_famille.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_famille.Image = ((System.Drawing.Image)(resources.GetObject("btn_famille.Image")));
            this.btn_famille.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_famille.Location = new System.Drawing.Point(0, 346);
            this.btn_famille.Margin = new System.Windows.Forms.Padding(4);
            this.btn_famille.Name = "btn_famille";
            this.btn_famille.Size = new System.Drawing.Size(267, 45);
            this.btn_famille.TabIndex = 20;
            this.btn_famille.Text = "Familly space";
            this.btn_famille.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_famille.UseVisualStyleBackColor = true;
            this.btn_famille.Click += new System.EventHandler(this.btn_famille_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMessages.FlatAppearance.BorderSize = 0;
            this.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessages.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMessages.Image = ((System.Drawing.Image)(resources.GetObject("btnMessages.Image")));
            this.btnMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessages.Location = new System.Drawing.Point(0, 301);
            this.btnMessages.Margin = new System.Windows.Forms.Padding(4);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(267, 45);
            this.btnMessages.TabIndex = 18;
            this.btnMessages.Text = "    Messages";
            this.btnMessages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // btnAnnouncement
            // 
            this.btnAnnouncement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAnnouncement.FlatAppearance.BorderSize = 0;
            this.btnAnnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnnouncement.Image = ((System.Drawing.Image)(resources.GetObject("btnAnnouncement.Image")));
            this.btnAnnouncement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnouncement.Location = new System.Drawing.Point(0, 256);
            this.btnAnnouncement.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.Size = new System.Drawing.Size(267, 45);
            this.btnAnnouncement.TabIndex = 17;
            this.btnAnnouncement.Text = "Task Managment";
            this.btnAnnouncement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnnouncement.UseVisualStyleBackColor = true;
            this.btnAnnouncement.Click += new System.EventHandler(this.btnAnnouncement_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(0, 211);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(267, 45);
            this.btnCalendar.TabIndex = 16;
            this.btnCalendar.Text = "     Calendar";
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 166);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(267, 45);
            this.btnDashboard.TabIndex = 15;
            this.btnDashboard.Text = "    Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.useradress);
            this.panellogo.Controls.Add(this.username);
            this.panellogo.Controls.Add(this.image1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(267, 166);
            this.panellogo.TabIndex = 0;
            // 
            // useradress
            // 
            this.useradress.AutoSize = true;
            this.useradress.ForeColor = System.Drawing.Color.White;
            this.useradress.Location = new System.Drawing.Point(42, 128);
            this.useradress.Name = "useradress";
            this.useradress.Size = new System.Drawing.Size(210, 17);
            this.useradress.TabIndex = 7;
            this.useradress.Text = "2080,14 rue liberté bouchoucha";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(110, 105);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(46, 17);
            this.username.TabIndex = 136;
            this.username.Text = "User1";
            // 
            // image1
            // 
            this.image1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.image1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.image1.Image = ((System.Drawing.Image)(resources.GetObject("image1.Image")));
            this.image1.Location = new System.Drawing.Point(79, 15);
            this.image1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(119, 72);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image1.TabIndex = 135;
            this.image1.TabStop = false;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.dashbord1);
            this.pnlDashboard.Controls.Add(this.calender1);
            this.pnlDashboard.Controls.Add(this.task1);
            this.pnlDashboard.Controls.Add(this.message1);
            this.pnlDashboard.Controls.Add(this.family1);
            this.pnlDashboard.Controls.Add(this.child_Bord1);
            this.pnlDashboard.Controls.Add(this.parents1);
            this.pnlDashboard.Controls.Add(this.facture1);
            this.pnlDashboard.Controls.Add(this.settinges1);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(267, 56);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1235, 697);
            this.pnlDashboard.TabIndex = 20;
            // 
            // dashbord1
            // 
            this.dashbord1.Location = new System.Drawing.Point(0, 0);
            this.dashbord1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashbord1.Name = "dashbord1";
            this.dashbord1.Size = new System.Drawing.Size(1585, 823);
            this.dashbord1.TabIndex = 8;
            // 
            // calender1
            // 
            this.calender1.BackColor = System.Drawing.SystemColors.Control;
            this.calender1.Location = new System.Drawing.Point(0, 0);
            this.calender1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calender1.Name = "calender1";
            this.calender1.Size = new System.Drawing.Size(1561, 790);
            this.calender1.TabIndex = 7;
            // 
            // task1
            // 
            this.task1.Location = new System.Drawing.Point(0, 0);
            this.task1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(1609, 777);
            this.task1.TabIndex = 6;
            // 
            // message1
            // 
            this.message1.Location = new System.Drawing.Point(0, 0);
            this.message1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.message1.Name = "message1";
            this.message1.Size = new System.Drawing.Size(1443, 812);
            this.message1.TabIndex = 5;
            // 
            // family1
            // 
            this.family1.Location = new System.Drawing.Point(0, 0);
            this.family1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.family1.Name = "family1";
            this.family1.Size = new System.Drawing.Size(1443, 812);
            this.family1.TabIndex = 4;
            // 
            // child_Bord1
            // 
            this.child_Bord1.Location = new System.Drawing.Point(0, 0);
            this.child_Bord1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.child_Bord1.Name = "child_Bord1";
            this.child_Bord1.Size = new System.Drawing.Size(1622, 810);
            this.child_Bord1.TabIndex = 3;
            // 
            // parents1
            // 
            this.parents1.Location = new System.Drawing.Point(0, 0);
            this.parents1.Name = "parents1";
            this.parents1.Size = new System.Drawing.Size(1443, 812);
            this.parents1.TabIndex = 2;
            // 
            // facture1
            // 
            this.facture1.Location = new System.Drawing.Point(0, 0);
            this.facture1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.facture1.Name = "facture1";
            this.facture1.Size = new System.Drawing.Size(1455, 810);
            this.facture1.TabIndex = 1;
            // 
            // settinges1
            // 
            this.settinges1.BackColor = System.Drawing.SystemColors.Control;
            this.settinges1.Location = new System.Drawing.Point(0, 0);
            this.settinges1.Name = "settinges1";
            this.settinges1.Size = new System.Drawing.Size(1232, 697);
            this.settinges1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.button3.Location = new System.Drawing.Point(1156, 8);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 41);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1502, 753);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panelmenu);
            this.MaximumSize = new System.Drawing.Size(1520, 800);
            this.Name = "Form1";
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panelmenu.ResumeLayout(false);
            this.panelmenufamille.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.pnlDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }



       


       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        

        private void btnsettings_Click(object sender, EventArgs e)
        {
            String f = "Settignes";
           
            Label3.Text = f;
            SetActivePanel(settinges1);
            hideSubMenu();
        }

   

        private void button5_Click(object sender, EventArgs e)
        {
            pnlStats.Top = btn_famille.Top;
            pnlStats.Height = btn_famille.Height;
           
            Label3.Text += "/ " + button5.Text;
            SetActivePanel(family1);
            hideSubMenu();
        }

        private void btn_famille_Click(object sender, EventArgs e)
        {
            pnlStats.Top = btn_famille.Top;
            pnlStats.Height = btn_famille.Height;
            Label3.Text = btn_famille.Text;
            showSubMenu(panelmenufamille);
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
           
            pnlStats.Top = btn_invoice.Top;
            Label3.Text = btn_invoice.Text;
            pnlStats.Height = btn_invoice.Height;
            SetActivePanel(facture1);
            hideSubMenu();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            pnlStats.Top = btnMessages.Top;
            pnlStats.Height = btnMessages.Height;
            Label3.Text = btnMessages.Text;
            SetActivePanel(message1);
            hideSubMenu();

        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            pnlStats.Top = btnAnnouncement.Top;
            pnlStats.Height = btnAnnouncement.Height;
            Label3.Text = btnAnnouncement.Text;
            hideSubMenu();

            SetActivePanel(task1);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            pnlStats.Top = btnCalendar.Top;
            pnlStats.Height = btnCalendar.Height;
            Label3.Text = btnCalendar.Text;
            hideSubMenu();
            SetActivePanel(calender1);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlStats.Top = btnDashboard.Top;
            pnlStats.Height = btnDashboard.Height;
            Label3.Text = btnDashboard.Text;
            hideSubMenu();
            SetActivePanel(dashbord1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlStats.Top = button4.Top;
            pnlStats.Height = button4.Height;
            Label3.Text += "/ " + button4.Text;
            hideSubMenu();
            SetActivePanel(parents1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlStats.Top = button1.Top;
            pnlStats.Height = button1.Height;
            Label3.Text += "/ "+button1.Text;
            hideSubMenu();
            SetActivePanel(child_Bord1);
        }
    }
}
