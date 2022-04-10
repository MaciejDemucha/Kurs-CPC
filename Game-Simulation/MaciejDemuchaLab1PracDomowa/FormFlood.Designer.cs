
namespace MaciejDemuchaLab1PracDomowa
{
    partial class FormFlood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFlood));
            this.buttonWait = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.droughtTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonWait
            // 
            this.buttonWait.Location = new System.Drawing.Point(437, 293);
            this.buttonWait.Name = "buttonWait";
            this.buttonWait.Size = new System.Drawing.Size(88, 35);
            this.buttonWait.TabIndex = 6;
            this.buttonWait.Text = "Czekaj";
            this.buttonWait.UseVisualStyleBackColor = true;
            this.buttonWait.Click += new System.EventHandler(this.buttonWait_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(173, 293);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(88, 35);
            this.buttonPay.TabIndex = 5;
            this.buttonPay.Text = "Zapłać";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // droughtTextBox
            // 
            this.droughtTextBox.Location = new System.Drawing.Point(74, 74);
            this.droughtTextBox.Name = "droughtTextBox";
            this.droughtTextBox.ReadOnly = true;
            this.droughtTextBox.Size = new System.Drawing.Size(566, 155);
            this.droughtTextBox.TabIndex = 4;
            this.droughtTextBox.Text = "Twojemu grodowi grozi powódź!\n\nMasz do wyboru dwie opcje:\n\n-\tNie reagować (-300 ż" +
    "ywności, -5 żołnierzy)\n-\tZapłacić magom, aby zatrzymali powódź (-400 złota, -200" +
    " kryształów)\n\nCo wybierasz?\n";
            // 
            // FormFlood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 392);
            this.ControlBox = false;
            this.Controls.Add(this.buttonWait);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.droughtTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFlood";
            this.Text = "Event";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWait;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.RichTextBox droughtTextBox;
    }
}