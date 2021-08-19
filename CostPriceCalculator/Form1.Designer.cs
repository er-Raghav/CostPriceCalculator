namespace CostPriceCalculator
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
            this.txtShareSold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPerShare = new System.Windows.Forms.Label();
            this.txtPerShare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dtpSellDate = new System.Windows.Forms.DateTimePicker();
            this.pnlCalculation = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCPShareSold = new System.Windows.Forms.TextBox();
            this.txtGainLoss = new System.Windows.Forms.TextBox();
            this.txtRemainingShare = new System.Windows.Forms.TextBox();
            this.txtCPRemainShare = new System.Windows.Forms.TextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.pnlCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtShareSold
            // 
            this.txtShareSold.Location = new System.Drawing.Point(297, 50);
            this.txtShareSold.Name = "txtShareSold";
            this.txtShareSold.Size = new System.Drawing.Size(139, 20);
            this.txtShareSold.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shares Sold:";
            // 
            // lblPerShare
            // 
            this.lblPerShare.AutoSize = true;
            this.lblPerShare.Location = new System.Drawing.Point(201, 88);
            this.lblPerShare.Name = "lblPerShare";
            this.lblPerShare.Size = new System.Drawing.Size(84, 13);
            this.lblPerShare.TabIndex = 3;
            this.lblPerShare.Text = "Price Per Share:";
            // 
            // txtPerShare
            // 
            this.txtPerShare.Location = new System.Drawing.Point(297, 85);
            this.txtPerShare.Name = "txtPerShare";
            this.txtPerShare.Size = new System.Drawing.Size(139, 20);
            this.txtPerShare.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sell Date:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(361, 158);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dtpSellDate
            // 
            this.dtpSellDate.Location = new System.Drawing.Point(297, 117);
            this.dtpSellDate.Name = "dtpSellDate";
            this.dtpSellDate.Size = new System.Drawing.Size(139, 20);
            this.dtpSellDate.TabIndex = 7;
            // 
            // pnlCalculation
            // 
            this.pnlCalculation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCalculation.Controls.Add(this.txtCPRemainShare);
            this.pnlCalculation.Controls.Add(this.txtRemainingShare);
            this.pnlCalculation.Controls.Add(this.txtGainLoss);
            this.pnlCalculation.Controls.Add(this.txtCPShareSold);
            this.pnlCalculation.Controls.Add(this.label6);
            this.pnlCalculation.Controls.Add(this.label5);
            this.pnlCalculation.Controls.Add(this.label4);
            this.pnlCalculation.Controls.Add(this.label2);
            this.pnlCalculation.Location = new System.Drawing.Point(141, 211);
            this.pnlCalculation.Name = "pnlCalculation";
            this.pnlCalculation.Size = new System.Drawing.Size(320, 160);
            this.pnlCalculation.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cost Price of Share Sold:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gain Loss on Sale:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Number of Remaining Shares:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cost Price of Remaining Shares:";
            // 
            // txtCPShareSold
            // 
            this.txtCPShareSold.Enabled = false;
            this.txtCPShareSold.Location = new System.Drawing.Point(213, 30);
            this.txtCPShareSold.Name = "txtCPShareSold";
            this.txtCPShareSold.Size = new System.Drawing.Size(100, 20);
            this.txtCPShareSold.TabIndex = 4;
            // 
            // txtGainLoss
            // 
            this.txtGainLoss.Enabled = false;
            this.txtGainLoss.Location = new System.Drawing.Point(213, 59);
            this.txtGainLoss.Name = "txtGainLoss";
            this.txtGainLoss.Size = new System.Drawing.Size(100, 20);
            this.txtGainLoss.TabIndex = 5;
            // 
            // txtRemainingShare
            // 
            this.txtRemainingShare.Enabled = false;
            this.txtRemainingShare.Location = new System.Drawing.Point(213, 85);
            this.txtRemainingShare.Name = "txtRemainingShare";
            this.txtRemainingShare.Size = new System.Drawing.Size(100, 20);
            this.txtRemainingShare.TabIndex = 6;
            // 
            // txtCPRemainShare
            // 
            this.txtCPRemainShare.Enabled = false;
            this.txtCPRemainShare.Location = new System.Drawing.Point(213, 111);
            this.txtCPRemainShare.Name = "txtCPRemainShare";
            this.txtCPRemainShare.Size = new System.Drawing.Size(100, 20);
            this.txtCPRemainShare.TabIndex = 7;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(204, 192);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 9;
            this.lblErrorMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 427);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.pnlCalculation);
            this.Controls.Add(this.dtpSellDate);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPerShare);
            this.Controls.Add(this.txtPerShare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShareSold);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlCalculation.ResumeLayout(false);
            this.pnlCalculation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShareSold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPerShare;
        private System.Windows.Forms.TextBox txtPerShare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DateTimePicker dtpSellDate;
        private System.Windows.Forms.Panel pnlCalculation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCPRemainShare;
        private System.Windows.Forms.TextBox txtRemainingShare;
        private System.Windows.Forms.TextBox txtGainLoss;
        private System.Windows.Forms.TextBox txtCPShareSold;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}

