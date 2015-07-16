using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuardingBoard
{
    public partial class frmBoard : Form
    {
        
        public frmBoard()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       /* public int GetAmountOfDaysByYearAndMonth()
        {
            int dayCount = DateTime.DaysInMonth(Convert.ToInt16(txtYear.Text), Convert.ToInt16(txtMonth.Text));
            return dayCount;
        }*/

        private void btnGenerateBoard_Click(object sender, EventArgs e)
        {
            
        }

        public void InitializeColumns()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            
            for (short i = 1; i <= 6; i++)
            {
                DataColumn col = new DataColumn("מאבטח - " + i);
                
                //dt.Columns["מאבטח - " + i].
            }
            dt.Columns.Add("מפקד כיתת כוננות");
            // DataRow dr = dt.NewRow();

            // dr["מפקד כיתת כוננות"] = "1234";

            dtgBoard.DataSource = dt;
            /* int dayCount = GetAmountOfDaysByYearAndMonth();
             for (short i = 1; i <= dayCount; i++)
             {
                
             }*/
        }
    }
}
