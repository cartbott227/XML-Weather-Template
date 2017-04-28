using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> dayDB = new List<Day>();
        Day d = new Day();

        public Form1()
        {
            InitializeComponent();
            GetData();
            ExtractCurrent();
            ExtractForecast();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            // one day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData.xml");
            // mulit day forecast
            client.DownloadFile("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0", "WeatherData7Day.xml");
       
        }

        private void ExtractCurrent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            XmlNode parent;

            parent = doc.DocumentElement;

            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "city")
                {
                    d.location = child.Attributes["name"].Value;
                }

                if (child.Name == "temperature")
                {
                    d.tempHigh = child.Attributes["max"].Value;
                    d.tempLow = child.Attributes["min"].Value;
                    d.currentTemp = child.Attributes["value"].Value;
                }
            }

            dayDB.Add(d);
        }
              
        private void ExtractForecast()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            d = new Day();

            XmlNode parent;

            parent = doc.DocumentElement;

            foreach (XmlNode child in parent.ChildNodes)
            {
                if (child.Name == "forecast")
                {
                    foreach (XmlNode grandchild in child.ChildNodes)
                    {
                        d.date = grandchild.Attributes["day"].Value;
                        foreach (XmlNode greatgrandchild  in grandchild.ChildNodes)
                        {
                            if (greatgrandchild.Name == "temperature")
                            {
                                d.tempHigh = greatgrandchild.Attributes["max"].Value;
                                d.tempLow = greatgrandchild.Attributes["min"].Value;
                            }
                            
                            if(greatgrandchild.Name == "clouds")
                            {
                                d.conditions = greatgrandchild.Attributes["value"].Value;
                                dayDB.Add(d);
                                d = new Day();


                            }
                        }
                    }

                    
                }
                
            }
            dayDB.RemoveAt(1);
        }
    }
}
