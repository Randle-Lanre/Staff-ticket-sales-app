﻿namespace Assignment_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameofApp = new System.Windows.Forms.Label();
            this.CashierLabel = new System.Windows.Forms.Label();
            this.UserNameInputBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumChild = new System.Windows.Forms.TextBox();
            this.NumStud = new System.Windows.Forms.TextBox();
            this.NumAdults = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CashierSummary = new System.Windows.Forms.GroupBox();
            this.AvgPricePaidOutput = new System.Windows.Forms.Label();
            this.TotalReciptsOutput = new System.Windows.Forms.Label();
            this.TotalTicketSoldOutput = new System.Windows.Forms.Label();
            this.CashierNameOutput = new System.Windows.Forms.Label();
            this.AvgP = new System.Windows.Forms.Label();
            this.TotalRcpt = new System.Windows.Forms.Label();
            this.SoldTickets = new System.Windows.Forms.Label();
            this.cashier = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.CashierSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameofApp
            // 
            this.NameofApp.AutoSize = true;
            this.NameofApp.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameofApp.Location = new System.Drawing.Point(142, 47);
            this.NameofApp.Name = "NameofApp";
            this.NameofApp.Size = new System.Drawing.Size(306, 25);
            this.NameofApp.TabIndex = 0;
            this.NameofApp.Text = "Daily Ticket Summary";
            // 
            // CashierLabel
            // 
            this.CashierLabel.AutoSize = true;
            this.CashierLabel.Location = new System.Drawing.Point(63, 135);
            this.CashierLabel.Name = "CashierLabel";
            this.CashierLabel.Size = new System.Drawing.Size(73, 13);
            this.CashierLabel.TabIndex = 1;
            this.CashierLabel.Text = "Cashier Name";
            // 
            // UserNameInputBox
            // 
            this.UserNameInputBox.Location = new System.Drawing.Point(171, 128);
            this.UserNameInputBox.Name = "UserNameInputBox";
            this.UserNameInputBox.Size = new System.Drawing.Size(221, 20);
            this.UserNameInputBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumChild);
            this.groupBox1.Controls.Add(this.NumStud);
            this.groupBox1.Controls.Add(this.NumAdults);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(79, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // NumChild
            // 
            this.NumChild.Location = new System.Drawing.Point(122, 131);
            this.NumChild.Name = "NumChild";
            this.NumChild.Size = new System.Drawing.Size(148, 20);
            this.NumChild.TabIndex = 5;
            // 
            // NumStud
            // 
            this.NumStud.Location = new System.Drawing.Point(123, 86);
            this.NumStud.Name = "NumStud";
            this.NumStud.Size = new System.Drawing.Size(147, 20);
            this.NumStud.TabIndex = 4;
            // 
            // NumAdults
            // 
            this.NumAdults.Location = new System.Drawing.Point(122, 46);
            this.NumAdults.Name = "NumAdults";
            this.NumAdults.Size = new System.Drawing.Size(149, 20);
            this.NumAdults.TabIndex = 3;
//            this.NumAdults.TextChanged += new System.EventHandler(this.NumAdults_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Child";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adult ";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(37, 402);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(99, 44);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(158, 402);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(83, 44);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(275, 402);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(88, 44);
            this.SummaryButton.TabIndex = 6;
            this.SummaryButton.Text = "Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(397, 402);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(87, 44);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CashierSummary
            // 
            this.CashierSummary.Controls.Add(this.AvgPricePaidOutput);
            this.CashierSummary.Controls.Add(this.TotalReciptsOutput);
            this.CashierSummary.Controls.Add(this.TotalTicketSoldOutput);
            this.CashierSummary.Controls.Add(this.CashierNameOutput);
            this.CashierSummary.Controls.Add(this.AvgP);
            this.CashierSummary.Controls.Add(this.TotalRcpt);
            this.CashierSummary.Controls.Add(this.SoldTickets);
            this.CashierSummary.Controls.Add(this.cashier);
            this.CashierSummary.Location = new System.Drawing.Point(84, 493);
            this.CashierSummary.Name = "CashierSummary";
            this.CashierSummary.Size = new System.Drawing.Size(343, 223);
            this.CashierSummary.TabIndex = 8;
            this.CashierSummary.TabStop = false;
            this.CashierSummary.Text = "Cashier Summary Data";
            this.CashierSummary.Visible = false;
            // 
            // AvgPricePaidOutput
            // 
            this.AvgPricePaidOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvgPricePaidOutput.Location = new System.Drawing.Point(165, 187);
            this.AvgPricePaidOutput.Name = "AvgPricePaidOutput";
            this.AvgPricePaidOutput.Size = new System.Drawing.Size(100, 23);
            this.AvgPricePaidOutput.TabIndex = 7;
            // 
            // TotalReciptsOutput
            // 
            this.TotalReciptsOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalReciptsOutput.Location = new System.Drawing.Point(165, 132);
            this.TotalReciptsOutput.Name = "TotalReciptsOutput";
            this.TotalReciptsOutput.Size = new System.Drawing.Size(98, 24);
            this.TotalReciptsOutput.TabIndex = 6;
            // 
            // TotalTicketSoldOutput
            // 
            this.TotalTicketSoldOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalTicketSoldOutput.Location = new System.Drawing.Point(165, 93);
            this.TotalTicketSoldOutput.Name = "TotalTicketSoldOutput";
            this.TotalTicketSoldOutput.Size = new System.Drawing.Size(100, 23);
            this.TotalTicketSoldOutput.TabIndex = 5;
            // 
            // CashierNameOutput
            // 
            this.CashierNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CashierNameOutput.Location = new System.Drawing.Point(166, 45);
            this.CashierNameOutput.Name = "CashierNameOutput";
            this.CashierNameOutput.Size = new System.Drawing.Size(100, 23);
            this.CashierNameOutput.TabIndex = 4;
            // 
            // AvgP
            // 
            this.AvgP.AutoSize = true;
            this.AvgP.Location = new System.Drawing.Point(44, 188);
            this.AvgP.Name = "AvgP";
            this.AvgP.Size = new System.Drawing.Size(77, 13);
            this.AvgP.TabIndex = 3;
            this.AvgP.Text = "Avg Price Paid";
            // 
            // TotalRcpt
            // 
            this.TotalRcpt.AutoSize = true;
            this.TotalRcpt.Location = new System.Drawing.Point(46, 143);
            this.TotalRcpt.Name = "TotalRcpt";
            this.TotalRcpt.Size = new System.Drawing.Size(68, 13);
            this.TotalRcpt.TabIndex = 2;
            this.TotalRcpt.Text = "Total Recipt:";
            // 
            // SoldTickets
            // 
            this.SoldTickets.AutoSize = true;
            this.SoldTickets.Location = new System.Drawing.Point(38, 94);
            this.SoldTickets.Name = "SoldTickets";
            this.SoldTickets.Size = new System.Drawing.Size(96, 13);
            this.SoldTickets.TabIndex = 1;
            this.SoldTickets.Text = "Total Tickets Sold:";
            // 
            // cashier
            // 
            this.cashier.AutoSize = true;
            this.cashier.Location = new System.Drawing.Point(37, 45);
            this.cashier.Name = "cashier";
            this.cashier.Size = new System.Drawing.Size(76, 13);
            this.cashier.TabIndex = 0;
            this.cashier.Text = "Cashier Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 741);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UserNameInputBox);
            this.Controls.Add(this.CashierLabel);
            this.Controls.Add(this.NameofApp);
            this.Controls.Add(this.CashierSummary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CashierSummary.ResumeLayout(false);
            this.CashierSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameofApp;
        private System.Windows.Forms.Label CashierLabel;
        private System.Windows.Forms.TextBox UserNameInputBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumChild;
        private System.Windows.Forms.TextBox NumStud;
        private System.Windows.Forms.TextBox NumAdults;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox CashierSummary;
        private System.Windows.Forms.Label AvgPricePaidOutput;
        private System.Windows.Forms.Label TotalReciptsOutput;
        private System.Windows.Forms.Label TotalTicketSoldOutput;
        private System.Windows.Forms.Label CashierNameOutput;
        private System.Windows.Forms.Label AvgP;
        private System.Windows.Forms.Label TotalRcpt;
        private System.Windows.Forms.Label SoldTickets;
        private System.Windows.Forms.Label cashier;
    }
}

