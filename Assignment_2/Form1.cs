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

        List<string> CashierNames = new List<string>();
        List<double> ListAmount = new List<double>();
        List<double> Listreceipts = new List<double>();


        const double adult = 7.70; const double student = 7.0; const double children = 6.26;


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

            SummaryButton.Enabled = true; //enables summary button

            CashierNameOutput.Text = UserNameInputBox.Text;
            CashierNames.Add(CashierNameOutput.Text);
            try
            {
                int TotalAdults, TotalStud, TotalChild; double Totalsum;

                TotalAdults = int.Parse(NumAdults.Text);
                TotalStud = int.Parse(NumStud.Text);
                TotalChild = int.Parse(NumChild.Text);
                Totalsum = TotalAdults + TotalStud + TotalChild;
                ListAmount.Add(Totalsum);
                TotalTicketSoldOutput.Text = Totalsum.ToString();
                CashierSummary.Visible = true;

                double AmountAdults, AmountStud, Amountchild; double Rawdata;

                AmountAdults = TotalAdults * (double)adult;
                AmountStud = TotalStud * (double)student;
                Amountchild = TotalChild * (double)children;
                Rawdata = AmountAdults + AmountStud + Amountchild;
                Listreceipts.Add(Rawdata);
                TotalReciptsOutput.Text = Rawdata.ToString("C");


                double AvgPricePaid;
                AvgPricePaid = Rawdata/Totalsum;
                AvgPricePaidOutput.Text = AvgPricePaid.ToString("C");





                //TotalTicketSoldOutput.Text = Treceipt.ToString();
                //CashierSummary.Visible = true;} 

            }
            catch 
            {
                MessageBox.Show("Try inputing a number instead of a letter :) ");
            }

        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {


            cashier.Text = "Total Cashiers";
            CashierSummary.Visible = true;

            CalculateButton.Enabled = false;
           // CashierSummary.Text = "Cinema Summary Data";

            
            //CashierNames.Add(UserNameInputBox.Text);
            int NumOfCashiers = CashierNames.Count;
            CashierNameOutput.Text = NumOfCashiers.ToString();



            double Tamount = ListAmount.Sum();
            double Trpct = Listreceipts.Sum();
            double avg = Trpct / Tamount;

            TotalTicketSoldOutput.Text = Tamount.ToString();

            TotalReciptsOutput.Text = Trpct.ToString("C");

            AvgPricePaidOutput.Text = avg.ToString("C");


            TicketsSoldGroupBox.Visible = false;//disable inputs
            CashierLabel.Visible = false;
            UserNameInputBox.Visible = false;



        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CashierSummary.Visible = false;
            UserNameInputBox.Text = "";
            NumAdults.Text = "";
            NumStud.Text = "";
            NumChild.Text = "";
            CashierNameOutput.Text = "";
            TotalTicketSoldOutput.Text = "";
            TotalReciptsOutput.Text = "";
            AvgPricePaidOutput.Text = "";

            UserNameInputBox.Focus();
            TicketsSoldGroupBox.Visible = true; //re-enables userinputs 

            CashierLabel.Visible = true;
            UserNameInputBox.Visible = true;
            CalculateButton.Enabled = true; //re-enables the calculate button


            // CashierSummary.Text = "Cashier Summary Data";
            cashier.Text = "Cashier Name";

        }

       
    }       

}
