using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostPriceCalculator
{
    public partial class Form1 : Form
    {
        static int TotalShares;
        static int RemainShares;
        Queue<clsSharesStock> qShareStocks;
        public Form1()
        {
            InitializeComponent();
            GetShareStockQueue();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                double _perShareCostPriceSold = 0;
                double _perShareCostPriceRemaining = 0;
                double _TotalShareCostPriceRemaining = 0;
                double _totalSoldSharedCost = 0;
                double _totalShareCost = 0;
                double pricePerShare = 0;
                double gain_loss = 0;

                int shareSold;

                resetControls();
                //Validations
                if (!int.TryParse(txtShareSold.Text,out shareSold))
                {
                    lblErrorMessage.Text = "Please Enter Valid Shares Sold!";
                    lblErrorMessage.Visible = true;
                    return;
                }
                    int totalSold = shareSold;

                if (!double.TryParse(txtPerShare.Text, out pricePerShare))
                {
                    lblErrorMessage.Text = "Please Enter Valid Price per share!";
                    lblErrorMessage.Visible = true;
                    return;
                }
                if (shareSold > RemainShares) {
                    lblErrorMessage.Text = "Not Enough shares to sell. Remaining Shares: "+ RemainShares.ToString() ;
                    lblErrorMessage.Visible = true;
                    return;
                }
                                
                //Remaining Shares
                RemainShares -= shareSold;
                txtRemainingShare.Text = RemainShares.ToString();
                _totalSoldSharedCost = funcCostTotalShare(totalSold, pricePerShare);


                while (shareSold > 0)   //shareSold = 120
                {
                    var objStock = qShareStocks.Peek();
                    if (shareSold <= objStock.Shares)
                    {
                        objStock.Shares -= shareSold;
                        
                        _totalShareCost += shareSold * objStock.Price;
                         if (objStock.Shares == 0) { qShareStocks.Dequeue(); }
                        shareSold = 0;
                    }
                    else
                    {
                        
                        int balance_share = objStock.Shares;
                        _totalShareCost += balance_share * objStock.Price;
                        shareSold -= balance_share;
                        qShareStocks.Dequeue();
                    }
                }
                //Total Cost of Share Sold
                _perShareCostPriceSold = funcPerShare(totalSold, _totalShareCost);
                txtCPShareSold.Text = _perShareCostPriceSold.ToString();
                gain_loss = _totalSoldSharedCost - _totalShareCost;
                //Gain Loss
                txtGainLoss.Text = gain_loss.ToString();

                foreach (var item in qShareStocks)
                {
                    _TotalShareCostPriceRemaining += item.Shares * item.Price;
                }

                //The cost price of the remaining shares
                _perShareCostPriceRemaining = funcPerShare(RemainShares, _TotalShareCostPriceRemaining);
                txtCPRemainShare.Text = _perShareCostPriceRemaining.ToString();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }


        }

        class clsSharesStock
        {
            public String PurchaseDate { get; set; }
            public int Shares { get; set; }
            public double Price { get; set; }
        }

        private double funcPerShare(int Tshare, double Tcost) { return Tcost / Tshare; }
        private double funcCostTotalShare(int Tshare, double Tcost) { return Tcost * Tshare; }
        private void GetShareStockQueue()
        {
            RemainShares = TotalShares = 190; // Total Number of Shares.

            qShareStocks = new Queue<clsSharesStock>();
            qShareStocks.Enqueue(new clsSharesStock()
            {
                PurchaseDate = "01/01/2015",
                Shares = 100,
                Price = 10
            });
            qShareStocks.Enqueue(new clsSharesStock()
            {
                PurchaseDate = "02/02/2015",
                Shares = 40,
                Price = 12
            });
            qShareStocks.Enqueue(new clsSharesStock()
            {
                PurchaseDate = "03/03/2015",
                Shares = 50,
                Price = 11
            });

        }

        private void resetControls() {
            lblErrorMessage.Visible = false;
            txtCPRemainShare.Text = string.Empty;
            txtCPShareSold.Text = string.Empty;
            txtGainLoss.Text = string.Empty;
            txtRemainingShare.Text = string.Empty;
        }
    }
}
