
namespace MaciejDemuchaLab1PracDomowa
{
    partial class FormAttack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttack));
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonFight = new System.Windows.Forms.Button();
            this.droughtTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonSurrender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(295, 289);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(110, 35);
            this.buttonPay.TabIndex = 6;
            this.buttonPay.Text = "Zapłać daninę";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonFight
            // 
            this.buttonFight.Location = new System.Drawing.Point(114, 289);
            this.buttonFight.Name = "buttonFight";
            this.buttonFight.Size = new System.Drawing.Size(104, 35);
            this.buttonFight.TabIndex = 5;
            this.buttonFight.Text = "Wyślij wojsko";
            this.buttonFight.UseVisualStyleBackColor = true;
            this.buttonFight.Click += new System.EventHandler(this.buttonFight_Click);
            // 
            // droughtTextBox
            // 
            this.droughtTextBox.Location = new System.Drawing.Point(73, 76);
            this.droughtTextBox.Name = "droughtTextBox";
            this.droughtTextBox.ReadOnly = true;
            this.droughtTextBox.Size = new System.Drawing.Size(566, 155);
            this.droughtTextBox.TabIndex = 4;
            this.droughtTextBox.Text = resources.GetString("droughtTextBox.Text");
            // 
            // buttonSurrender
            // 
            this.buttonSurrender.Location = new System.Drawing.Point(492, 289);
            this.buttonSurrender.Name = "buttonSurrender";
            this.buttonSurrender.Size = new System.Drawing.Size(110, 35);
            this.buttonSurrender.TabIndex = 7;
            this.buttonSurrender.Text = "Poddaj się";
            this.buttonSurrender.UseVisualStyleBackColor = true;
            this.buttonSurrender.Click += new System.EventHandler(this.buttonSurrender_Click);
            // 
            // FormAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 392);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSurrender);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonFight);
            this.Controls.Add(this.droughtTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAttack";
            this.Text = "Event";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonFight;
        private System.Windows.Forms.RichTextBox droughtTextBox;
        private System.Windows.Forms.Button buttonSurrender;
    }
}