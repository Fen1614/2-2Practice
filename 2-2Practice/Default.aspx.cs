﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int year = 1000;
            if (year <= 10000)
            {
                if (year % 4 == 0)
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            Response.Write("bingo");
                        }
                        else
                        {
                            Response.Write("no");
                        }
                    }
                    else{
                    Response.Write("no");
                    }
            }else{
                Response.Write("Warning!");
            }
            
        }
    }
}