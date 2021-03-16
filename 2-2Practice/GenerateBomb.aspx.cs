using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice
{
    public partial class GenerateBomb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ia_Bomb = new int[10] {0, 7, 13, 28, 44, 62, 74, 75, 87, 90};
            int i_Row = 0, i_Col = 0;
            int[,] ia_2DMap = new int[10, 10];
            for (int i =0; i < ia_Bomb.Length; i++)
            {
                mt_GetRowCol(ref i_Row, ref i_Col, ia_Bomb[i]);
                ia_2DMap[i_Row, i_Col] = -1;

            }

            for (int i=0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Response.Write(ia_2DMap[i, j]);
                }
                Response.Write("<br />");
            }
            
        }
    }
}