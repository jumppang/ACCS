using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string url = "https://google.com";

            WebClient client = new WebClient();

            //System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolTypeExtensions.Tls12;
            //System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolTypeExtensions.Tls11;

            //string html = client.DownloadString(url);

            //Debug.WriteLine(html);


        }
    }
}
