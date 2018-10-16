using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelmulletCinema
{
    public partial class Form1 : Form
    {

        List<string> CashierNames = new List<string>();
        List<decimal> ListAmount = new List<decimal>();
        List<decimal> Listreceipts = new List<decimal>();


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

            SummaryButton.Enabled = true; //enables summary button

            CashierNameOutput.Text = UserNameInputBox.Text;
            CashierNames.Add(CashierNameOutput.Text);

            try
            {
                int TotalAdults, TotalStud, TotalChild; decimal Totalsum;

                TotalAdults = int.Parse(NumAdults.Text);
                TotalStud = int.Parse(NumStud.Text);
                TotalChild = int.Parse(NumChild.Text);
                Totalsum = TotalAdults + TotalStud + TotalChild;
                ListAmount.Add(Totalsum);
                TotalTicketSoldOutput.Text = Totalsum.ToString();
                CashierSummary.Visible = true;


                try
                {
                    decimal AmountAdults, AmountStud, Amountchild; decimal Rawdata;

                    AmountAdults = TotalAdults * (decimal)adult;
                    AmountStud = TotalStud * (decimal)student;
                    Amountchild = TotalChild * (decimal)children;
                    Rawdata = AmountAdults + AmountStud + Amountchild;
                    Listreceipts.Add(Rawdata);
                    TotalReciptsOutput.Text = Rawdata.ToString("C");

                    try
                    {

                        decimal AvgPricePaid;
                        AvgPricePaid = Rawdata / Totalsum;
                        AvgPricePaidOutput.Text = AvgPricePaid.ToString("C");



                    }
                    catch { }
                    //TotalTicketSoldOutput.Text = Treceipt.ToString();
                    //CashierSummary.Visible = true;} 
                }
                catch { }


            }
            catch { }


            CalculateButton.Enabled = false;


            ClearButton.Enabled = true;
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {


            cashier.Text = "Total Cashiers";
            CashierSummary.Text = "Cinema Summary Data";
            CashierSummary.Visible = true;

            CalculateButton.Enabled = false;
           // CashierSummary.Text = "Cinema Summary Data";

            
            //CashierNames.Add(UserNameInputBox.Text);
            int NumOfCashiers = CashierNames.Count;
            CashierNameOutput.Text = NumOfCashiers.ToString();



            decimal Tamount = ListAmount.Sum();
            decimal Trpct = Listreceipts.Sum();
            decimal avg = Trpct / Tamount;

            TotalTicketSoldOutput.Text = Tamount.ToString();

            TotalReciptsOutput.Text = Trpct.ToString("C");

            AvgPricePaidOutput.Text = avg.ToString("C");


            TicketsSoldGroupBox.Visible = false;//disable inputs
            CashierLabel.Visible = false;
            UserNameInputBox.Visible = false;
            ClearButton.Enabled = true; 


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
            CashierSummary.Text = "Cashier Summary Data";


            CalculateButton.Enabled = true;

            ClearButton.Enabled = false;

        }

       
    }       

}
