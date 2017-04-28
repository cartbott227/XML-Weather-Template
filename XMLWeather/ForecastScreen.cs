using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayforecast();
        }

        public void displayforecast()
        {
            //General info
            cityOutput.Text = Form1.dayDB[0].location + ",ON";
            labelTime.Text = Convert.ToString(DateTime.Now.Hour) + " : " + Convert.ToString(DateTime.Now.Minute);

            //Day 1
            maxTemp.Text = Convert.ToDouble(Form1.dayDB[0].tempHigh).ToString("0") + " C";
            minTemp.Text = Convert.ToDouble(Form1.dayDB[0].tempLow).ToString("0") + " C";
            date1.Text = Form1.dayDB[1].date;

            //Conditions
            if (Form1.dayDB[1].conditions.Contains("clouds"))
            {
                conditionsBox1.BackgroundImage = Properties.Resources.cloudimage;
            }
            else if (Form1.dayDB[1].conditions.Contains("clear"))
            {
                conditionsBox1.BackgroundImage = Properties.Resources.sunimage;
            }
            else if (Form1.dayDB[1].conditions.Contains("rain") || Form1.dayDB[1].conditions.Contains("drizzle"))
            {
                conditionsBox1.BackgroundImage = Properties.Resources.rainimage;
            }

            //Day 2
            maxTemp2.Text = Convert.ToDouble(Form1.dayDB[2].tempHigh).ToString("0") + " C";
            minTemp2.Text = Convert.ToDouble(Form1.dayDB[2].tempLow).ToString("0") + " C";
            date2.Text = Form1.dayDB[2].date;

            //Conditions
            if (Form1.dayDB[2].conditions.Contains("clouds"))
            {
                conditionsBox1.BackgroundImage = Properties.Resources.cloudimage;
            }
            else if (Form1.dayDB[2].conditions.Contains("clear"))
            {
                conditionsBox1.BackgroundImage = Properties.Resources.sunimage;
            }
            else if (Form1.dayDB[2].conditions.Contains("rain") || Form1.dayDB[1].conditions.Contains("drizzle"))
            {
                conditionsBox1.BackgroundImage = Properties.Resources.rainimage;
            }

            //Day 3
            maxTemp3.Text = Convert.ToDouble(Form1.dayDB[3].tempHigh).ToString("0") + " C";
            minTemp3.Text = Convert.ToDouble(Form1.dayDB[3].tempLow).ToString("0") + " C";
            date3.Text = Form1.dayDB[3].date;

            //Conditions
            if (Form1.dayDB[3].conditions.Contains("clouds"))
            {
                conditionsBox1.BackgroundImage = Properties.Resources.cloudimage;
            }
            else if (Form1.dayDB[3].conditions.Contains("clear"))
            {
                conditionsBox1.BackgroundImage = Properties.Resources.sunimage;
            }
            else if (Form1.dayDB[3].conditions.Contains("rain") || Form1.dayDB[1].conditions.Contains("drizzle"))
            {
                conditionsBox1.BackgroundImage = Properties.Resources.rainimage;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
