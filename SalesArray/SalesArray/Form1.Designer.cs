
namespace SalesArray
{
    partial class FrmStoreSales
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
            this.BtnSalesAnalysis = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalesAnalysis
            // 
            this.BtnSalesAnalysis.Location = new System.Drawing.Point(361, 57);
            this.BtnSalesAnalysis.Name = "BtnSalesAnalysis";
            this.BtnSalesAnalysis.Size = new System.Drawing.Size(75, 23);
            this.BtnSalesAnalysis.TabIndex = 0;
            this.BtnSalesAnalysis.Text = "Sales Analysis";
            this.BtnSalesAnalysis.UseVisualStyleBackColor = true;
            this.BtnSalesAnalysis.Click += new System.EventHandler(this.BtnSalesAnalysis_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(233, 130);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(335, 190);
            this.TxtDisplay.TabIndex = 2;
            this.TxtDisplay.TextChanged += new System.EventHandler(this.TxtDisplay_TextChanged);
            // 
            // FrmStoreSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnSalesAnalysis);
            this.Name = "FrmStoreSales";
            this.Text = "Store Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalesAnalysis;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

