using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int year = 30;
            bool isleap = false;

            if (year % 4 == 0){
                isleap = true;

                if (year % 100 == 0){
                    if (year % 400 == 0){
                        isleap = true;
                    }
                    else
                    {
                        isleap = false;
                    }
                }
            }
            if (isleap == true)
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