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

//WEATHER APP
//MATT SMITH ICSU
// MR T
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
