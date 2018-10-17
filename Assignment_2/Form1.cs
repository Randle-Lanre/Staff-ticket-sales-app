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
        //----------------------------------------------------------------------------
        /* List declared to hold information for cashier names, each calculated
         * results entered
         */
         
        List<string> CashierNames = new List<string>();
        List<decimal> ListAmount = new List<decimal>();
        List<decimal> Listreceipts = new List<decimal>();

        //declared constant to be used in the calculation process
        const decimal ADULT = 7.70m;
        const decimal STUDENT = 7.0m;
        const decimal CHILDREN = 6.26m;

        //----------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        
        //Calcuates the each user transaction
        private void CalculateButton_Click(object sender, EventArgs e)
        {   //variables to be used in calculating each user inputs 
            int TotalAdults, TotalStud, TotalChild; decimal Totalsum;


            //Try and catch have been declared for each numerical inputs
            try
            {
                TotalAdults = int.Parse(NumAdults.Text); //Checks that adult tickets
                                                         //are numerical

                try
                {
                    TotalStud = int.Parse(NumStud.Text); //checks tickets entered 
                                                         //for students are 
                                                         //numerical
                                                         

                    try
                    {
                        TotalChild = int.Parse(NumChild.Text); //checks that the
                                                               //child ticket
                                                               //inputs are also numerical


                        /* if the inputs for adults, student and 
                         * children are numerical, it proceeds to perform
                         * the calculations
                         */

                        //Calculates the sum of the tickets
                        Totalsum = TotalAdults + TotalStud + TotalChild;
                        ListAmount.Add(Totalsum);//
                        TotalTicketSoldOutput.Text = Totalsum.ToString();
                        CashierSummary.Visible = true;
                        



                        decimal AmountAdults, AmountStud, Amountchild;
                        decimal Rawdata;
                        
                        //this multiplies the data 
                        AmountAdults = TotalAdults * (decimal)ADULT;
                        AmountStud = TotalStud * (decimal)STUDENT;
                        Amountchild = TotalChild * (decimal)CHILDREN;
                        Rawdata = AmountAdults + AmountStud + Amountchild;
                        Listreceipts.Add(Rawdata);
                        TotalReciptsOutput.Text = Rawdata.ToString("C");
                        
                        //this calculates the average 
                        decimal AvgPricePaid;
                        AvgPricePaid = Rawdata / Totalsum;
                        AvgPricePaidOutput.Text = AvgPricePaid.ToString("C");


                    }
                    catch {NumChild.ForeColor = System.Drawing.Color.Red;
                        MessageBox.Show("CHILD TICKETS\n\n" +
                            "Only Numerical Input accepted\n Please change the " +
                            "input in RED to a number"); }
                }
                catch { NumStud.ForeColor= System.Drawing.Color.Red;
                    MessageBox.Show("STUDENT TICKETS\n\n" +
                        "Only Numerical Input accepted\n Please change the " +
                        "input in RED to a number"); }
            }
            catch { NumAdults.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("ADULT TICKETS\n\n" +
                    "Only Numerical Input accepted\n Please change the " +
                    "input in RED to a number");}
                   



            
                SummaryButton.Enabled = true; //enables summary button

                CashierNameOutput.Text = UserNameInputBox.Text;// receive user inputs 
                CashierNames.Add(CashierNameOutput.Text);//appends the cashier names
                                                         //to the list 

                CalculateButton.Enabled = false;
                ClearButton.Enabled = true;
        }
                


    
        //-----------------------------------------------------------
        private void SummaryButton_Click(object sender, EventArgs e)
        {


            Cashier.Text = "Total Cashiers";
            CashierSummary.Text = "Cinema Summary Data";
            CashierSummary.Visible = true;

            CalculateButton.Enabled = false;
           // CashierSummary.Text = "Cinema Summary Data";

            
            //counts the number of cashiers
            int NumOfCashiers = CashierNames.Count;
            CashierNameOutput.Text = NumOfCashiers.ToString();


            //Calculates the average
            decimal Tamount = ListAmount.Sum();
            decimal Trpct = Listreceipts.Sum();
            decimal Avg = Trpct / Tamount;

            TotalTicketSoldOutput.Text = Tamount.ToString();

            TotalReciptsOutput.Text = Trpct.ToString("C");

            AvgPricePaidOutput.Text = Avg.ToString("C");


            TicketsSoldGroupBox.Visible = false;//disable inputs
            CashierLabel.Visible = false;
            UserNameInputBox.Visible = false;
            ClearButton.Enabled = true; 


        }
        //--------------------------------------------------------

        
           //this is the clear button 
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
            Cashier.Text = "Cashier Name";
            CashierSummary.Text = "Cashier Summary Data";


            CalculateButton.Enabled = true;//enables the clear button 

            ClearButton.Enabled = false; //enables the clear button

        }

        //--------------------------------------------------------


        //closes the program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }       

}
