
namespace MaciejDemuchaLab1PracDomowa
{
    partial class FormDrought
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrought));
            this.droughtTextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonWait = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // droughtTextBox
            // 
            this.droughtTextBox.Location = new System.Drawing.Point(74, 80);
            this.droughtTextBox.Name = "droughtTextBox";
            this.droughtTextBox.ReadOnly = true;
            this.droughtTextBox.Size = new System.Drawing.Size(566, 155);
            this.droughtTextBox.TabIndex = 0;
            this.droughtTextBox.Text = resources.GetString("droughtTextBox.Text");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(171, 306);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(88, 35);
            this.buttonPay.TabIndex = 2;
            this.buttonPay.Text = "Zapłać";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonWait
            // 
            this.buttonWait.Location = new System.Drawing.Point(426, 306);
            this.buttonWait.Name = "buttonWait";
            this.buttonWait.Size = new System.Drawing.Size(88, 35);
            this.buttonWait.TabIndex = 3;
            this.buttonWait.Text = "Czekaj";
            this.buttonWait.UseVisualStyleBackColor = true;
            this.buttonWait.Click += new System.EventHandler(this.buttonWait_Click);
            // 
            // FormDrought
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 392);
            this.ControlBox = false;
            this.Controls.Add(this.buttonWait);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.droughtTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDrought";
            this.Text = "Event";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox droughtTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonWait;
        private System.Windows.Forms.Timer timer1;
    }
}