using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Calender : UserControl
    {
        public Calender()
        {
            InitializeComponent();
            axCalendar1.DayColor = Color.DarkGray;
            axCalendar1.DayCaptionForeColor = Color.Black;
            axCalendar1.DayCaptionBackColor = Color.Gold;
            axCalendar1.MonthYearBackColor = Color.DarkGray;
            axCalendar1.MonthYearForeColor = Color.Gold;

            axCalendar1.CtlBackColor = Color.DeepSkyBlue;
        }

        private void taskType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btn_succ_Click(object sender, EventArgs e)
        {

            if (axCalendar1.Month < 12)
                axCalendar1.Month++;
            else
            {
                axCalendar1.Month = 1;
                axCalendar1.Year++;
            }
        }

        private void btn_pred_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            switch (dtp.Value.Month.ToString())
            {
                case "1":
                    axCalendar1.Month = 1;
                    break;
                case "2":
                    axCalendar1.Month = 2;
                    break;
                case "3":
                    axCalendar1.Month = 3;
                    break;
                case "4":
                    axCalendar1.Month = 4;
                    break;
                case "5":
                    axCalendar1.Month = 5;
                    break;
                case "6":
                    axCalendar1.Month = 6;
                    break;
                case "7":
                    axCalendar1.Month = 7;
                    break;
                case "8":
                    axCalendar1.Month = 8;
                    break;
                case "9":
                    axCalendar1.Month = 9;
                    break;
                case "10":
                    axCalendar1.Month = 10;
                    break;
                case "11":
                    axCalendar1.Month = 11;
                    break;
                case "12":
                    axCalendar1.Month = 12;
                    break;
            }
            int b = dtp.Value.Year;

            axCalendar1.Year = (short)b;
            axCalendar1.SetText(5, "1-Football  \n2-Basketball \n3-Cinema");
            //axCalendar51.SetText(3, "1-bonjour  \n ");
            axCalendar1.SetText(3, "\n match milan");
        }

        private void btn_pred_Click_1(object sender, EventArgs e)
        {
            if (axCalendar1.Month > 1)
                axCalendar1.Month--;
            else
            {
                axCalendar1.Month = 12;
                axCalendar1.Year--;
            }
        }

        private void Calender_Load(object sender, EventArgs e)
        {

        }

        private void taskImport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }



        /*  */


    }
}
