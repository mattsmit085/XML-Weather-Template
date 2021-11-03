using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public static string location = "Stratford, ON, CA";
        public static bool refreshweather = false;

        public static List<Day> days = new List<Day>();


        public CurrentScreen()
        {
            InitializeComponent();
            ExtractForecast();
            ExtractCurrent();
            DisplayCurrent();
        }

        //CHECK TO SEE IF CITY IS VALID
        public static bool findCity(string _city)
        {
            try
            {
                XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=" + _city + "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");
            }
            catch
            {
                return false;
            }
            return true;
        }

        //EXTRACT FORECAST INFORMATION
        public static void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=" + location + "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            days.Clear();

            while (reader.Read())
            {
            
                //TODO: create a day object
                Day day = new Day();

                //TODO: fill day object with required data
                reader.ReadToFollowing("time");
                day.date = reader.GetAttribute("day");

                reader.ReadToFollowing("temperature");
                day.tempLow = reader.GetAttribute("min");
                day.tempHigh = reader.GetAttribute("max");

                CurrentScreen.days.Add(day);

                //TODO: if day object not null add to the days list
            }
        }

        //EXTRACT CURRENT DAY INFORMATION
        public static void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=" + location + "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            CurrentScreen.days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            CurrentScreen.days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("speed");
            CurrentScreen.days[0].windSpeed = reader.GetAttribute("value");
            CurrentScreen.days[0].windUnit = reader.GetAttribute("units");
            CurrentScreen.days[0].windName = reader.GetAttribute("name");

            reader.ReadToFollowing("weather");
            CurrentScreen.days[0].condition = reader.GetAttribute("number");
        }

        //DISPLAY CURRENT INFORMATION TO LABELS
        public void DisplayCurrent()
        {

            cityOutput.Text = CurrentScreen.days[0].location;
            tempLabel.Text = Math.Round(Convert.ToDouble(CurrentScreen.days[0].currentTemp)) + "°";
            minOutput.Text = "LOW: " + Math.Round(Convert.ToDouble(CurrentScreen.days[0].tempLow)) + "°";
            maxOutput.Text = "HIGH: " + Math.Round(Convert.ToDouble(CurrentScreen.days[0].tempHigh)) + "°";

            dateLabel.Text = Convert.ToDateTime(CurrentScreen.days[0].date).ToString("dddd, dd");

            if (Convert.ToInt32(CurrentScreen.days[0].condition) > 800)
            {
                iconlabel.Image = Properties.Resources.scattered_clouds;
                this.BackgroundImage = Properties.Resources.clou;
                weatherlabel.Text = "Cloudy";
            }
            else if (Convert.ToInt32(CurrentScreen.days[0].condition) == 800)
            {
                iconlabel.Image = Properties.Resources.clearsky;
                weatherlabel.Text = "Clear Sky";
                this.BackgroundImage = Properties.Resources.SUNNY;
            }
            else if (Convert.ToInt32(CurrentScreen.days[0].condition) >= 600)
            {
                iconlabel.Image = Properties.Resources.snow;
                weatherlabel.Text = "Snow";
                this.BackgroundImage = Properties.Resources.sno;
            }
            else if (Convert.ToInt32(CurrentScreen.days[0].condition) >= 500)
            {
                iconlabel.Image = Properties.Resources.rain;
                weatherlabel.Text = "Rain";
                this.BackgroundImage = Properties.Resources.rai;
            }
            else if (Convert.ToInt32(CurrentScreen.days[0].condition) >= 200)
            {
                iconlabel.Image = Properties.Resources.thunderstorm;
                weatherlabel.Text = "Thunderstorms";
                this.BackgroundImage = Properties.Resources.Thund;
            }

        }

        //SWITCH TO FORECAST SCREEN ON CLICK
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void minLabel_Click(object sender, EventArgs e)
        {

        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {

        }

        //CONSTANTLY GET TIME OF DAY
        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            int currentSec = DateTime.Now.Second;
            int currentMin = DateTime.Now.Minute;
            int currentHour = DateTime.Now.Hour;

            timelabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        //ON CLICK, SET NEEDED CITY TO CITY
        private void searchButtonLabel_Click(object sender, EventArgs e)
        {
            if (findCity(citySearchLabel.Text) == true)
            {
                location = citySearchLabel.Text;

                ExtractForecast();
                ExtractCurrent();

                refreshweather = true;
                DisplayCurrent();

            }
            //IF CITY DOESNT EXIST, SAY INVALID
            else
            {
                citySearchLabel.Text = "Invalid City!";
            }

        }
    }
}
