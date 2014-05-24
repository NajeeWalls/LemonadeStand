using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LemonadeStand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declaration of constants
        const decimal PAPERCUP_PRICE = 0.04m;
        const decimal LEMON_PRICE = 0.05m;
        const decimal CUP_OF_SUGAR_PRICE = 0.08m;
        const decimal ICECUBE_PRICE = 0.01m;
        decimal totalExpenseDecimal;
       
        //Integers (decimals) to be used later
        int paperCupInteger;
        int lemonsInteger;
        decimal cupsOfSugarDecimal;
        int iceCubeInteger;

        private void revenueButton_Click(object sender, EventArgs e)
        {
            try
            {
                //declarations of 
                decimal paperCupCost;
                decimal lemonsCost;
                decimal sugarCost;
                decimal iceCubeCost;

                paperCupInteger = int.Parse(cupsTextBox.Text);
                lemonsInteger = int.Parse(lemonTextBox.Text);
                cupsOfSugarDecimal = decimal.Parse(sugarTextBox.Text);
                iceCubeInteger = int.Parse(cubesTextBox.Text);

                paperCupCost = paperCupInteger * PAPERCUP_PRICE;
                lemonsCost = lemonsInteger * LEMON_PRICE;
                sugarCost = cupsOfSugarDecimal * CUP_OF_SUGAR_PRICE;
                iceCubeCost = iceCubeInteger * ICECUBE_PRICE;

                totalExpenseDecimal = paperCupCost + lemonsCost + sugarCost + iceCubeCost;
                expenseTextBox.Text = totalExpenseDecimal.ToString("C");
            }
            catch
            { }


        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevenueForm myRevenueForm = new RevenueForm();
            myRevenueForm.pitcherlemonsDecimal = lemonsInteger;
            myRevenueForm.pitchercupsOfSugarDecimal = cupsOfSugarDecimal;
            myRevenueForm.pitchericeCubeInteger = iceCubeInteger;
            myRevenueForm.profitPaperCupInteger = paperCupInteger;
            myRevenueForm.profitExpenseDecimal = totalExpenseDecimal;
            myRevenueForm.ShowDialog();
        }



    }
}
