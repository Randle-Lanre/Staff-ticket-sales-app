using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        const decimal adult = 7.70m; const decimal student = 7.0m; const decimal children = 6.26m;
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int TotalAdults, TotalStud, TotalChild;

            TotalAdults = int.Parse(NumAdults.Text);
            TotalStud = int.Parse(NumStud.Text);
            TotalChild = int.Parse(NumChild.Text);
            TotalTicketSoldOutput.Text = (TotalAdults + TotalStud + TotalChild).ToString();
            CashierSummary.Visible = true;



            

            //TotalTicketSoldOutput.Text = Treceipt.ToString();
            //CashierSummary.Visible = true;
        }
    }
}
