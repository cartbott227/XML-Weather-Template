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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            maxTemp.Text = Form1.dayDB[0].tempHigh + " C|";
            minTemp.Text = Form1.dayDB[0].tempLow + " C";
            tempLabel.Text = Convert.ToDouble(Form1.dayDB[0].currentTemp).ToString("0") + " C";
            cityOutput.Text = Form1.dayDB[0].location + ",ON";
            labelTime.Text = Convert.ToString(DateTime.Now.Hour) + " : " + Convert.ToString(DateTime.Now.Minute);

            if (Form1.dayDB[0].conditions.Contains("clouds"))
            {
                conditionsBox.BackgroundImage = Properties.Resources.cloudimage;
            }
            else if (Form1.dayDB[0].conditions.Contains("clear"))
            {
                conditionsBox.BackgroundImage = Properties.Resources.sunimage;
            }
            else if (Form1.dayDB[0].conditions.Contains("rain") || Form1.dayDB[1].conditions.Contains("drizzle"))
            {
                conditionsBox.BackgroundImage = Properties.Resources.rainimage;
            }

            //if (Form1.dayDB[0].conditions == "scattered clouds")
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
