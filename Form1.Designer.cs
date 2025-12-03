namespace myBTC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bitcoinAmount = new TextBox();
            btcamountl = new Label();
            currencySelector = new ComboBox();
            tocurrencylabel = new Label();
            GetRates = new Button();
            BTCresult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // bitcoinAmount
            // 
            bitcoinAmount.Location = new Point(311, 125);
            bitcoinAmount.Name = "bitcoinAmount";
            bitcoinAmount.Size = new Size(117, 23);
            bitcoinAmount.TabIndex = 0;
            // 
            // btcamountl
            // 
            btcamountl.AutoSize = true;
            btcamountl.ForeColor = SystemColors.ActiveCaptionText;
            btcamountl.Location = new Point(310, 107);
            btcamountl.Name = "btcamountl";
            btcamountl.Size = new Size(62, 15);
            btcamountl.TabIndex = 1;
            btcamountl.Text = "BTC kogus";
            btcamountl.Click += btcamountl_Click;
            // 
            // currencySelector
            // 
            currencySelector.FormattingEnabled = true;
            currencySelector.Items.AddRange(new object[] { "EUR", "USD" });
            currencySelector.Location = new Point(310, 228);
            currencySelector.Name = "currencySelector";
            currencySelector.Size = new Size(121, 23);
            currencySelector.TabIndex = 2;
            // 
            // tocurrencylabel
            // 
            tocurrencylabel.AutoSize = true;
            tocurrencylabel.Location = new Point(311, 210);
            tocurrencylabel.Name = "tocurrencylabel";
            tocurrencylabel.Size = new Size(66, 15);
            tocurrencylabel.TabIndex = 3;
            tocurrencylabel.Text = "Sihtvaluuta";
            // 
            // GetRates
            // 
            GetRates.Location = new Point(503, 325);
            GetRates.Name = "GetRates";
            GetRates.Size = new Size(75, 23);
            GetRates.TabIndex = 4;
            GetRates.Text = "Arvuta";
            GetRates.UseVisualStyleBackColor = true;
            GetRates.Click += getcoin_Click;
            // 
            // BTCresult
            // 
            BTCresult.AutoSize = true;
            BTCresult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            BTCresult.Location = new Point(116, 549);
            BTCresult.Name = "BTCresult";
            BTCresult.Size = new Size(187, 32);
            BTCresult.TabIndex = 5;
            BTCresult.Text = "calculationresult";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 488);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 6;
            label1.Text = "Arvutuse tulemus";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(713, 682);
            Controls.Add(label1);
            Controls.Add(BTCresult);
            Controls.Add(GetRates);
            Controls.Add(tocurrencylabel);
            Controls.Add(currencySelector);
            Controls.Add(btcamountl);
            Controls.Add(bitcoinAmount);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bitcoinAmount;
        private Label btcamountl;
        private ComboBox currencySelector;
        private Label tocurrencylabel;
        private Button GetRates;
        private Label BTCresult;
        private Label label1;
    }
}
