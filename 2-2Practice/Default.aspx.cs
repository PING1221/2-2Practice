using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int year = 1000;
            bool b_IsLeap = false;
            if (year % 4 == 0)
            {
                b_IsLeap = true;

                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        b_IsLeap = true;
                    }
                    else
                    {
                        b_IsLeap = false;
                    }
                }

                if (b_IsLeap == true)
                {
                    Response.Write("Y");
                }
                else
                {
                    Response.Write("N");
                }
            }
        }
    }
}
