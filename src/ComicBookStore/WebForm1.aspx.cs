﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComicBookStore
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void timer1_Tick(object sender, EventArgs e)
        {

           
        }

        protected void button_clicked(object sender, EventArgs e)
        {
            string text = input_1.Text;

            timerLabel.Text = DateTime.Now.ToString() + " " + text;
        }
    }
}