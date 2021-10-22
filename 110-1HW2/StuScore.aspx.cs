using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW2
{
    public partial class StuScore : System.Web.UI.Page
    {
        public string s_ID;
        public float f_ChiS;
        public float f_MathS;
        public float f_EngS;
    }
    protected void Page_Load(object sender, EventArgs e)
        {
            Scores o_scores = new Scores();
            o_scores.s_ID = "A123456789";
            o_scores.f_ChiS = 62f;
            o_scores.f_MathS = 73f;
            o_scores.f_EngS = 84f;

            Response.Write("s_ID=" + o_scores.s_ID + "," +
                "f_ChiS=" + o_scores.f_ChiS.ToString() + "," +
                "f_MathS=" + o_scores.f_MathS.ToString() + "," +
                "f_EngS=" + o_scores.f_EngS.ToString());
        }
    }
}