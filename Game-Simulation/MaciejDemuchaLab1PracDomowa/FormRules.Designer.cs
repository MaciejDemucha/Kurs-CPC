
namespace MaciejDemuchaLab1PracDomowa
{
    partial class FormRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRules));
            this.rulesBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rulesBox
            // 
            this.rulesBox.Location = new System.Drawing.Point(58, 29);
            this.rulesBox.Name = "rulesBox";
            this.rulesBox.ReadOnly = true;
            this.rulesBox.Size = new System.Drawing.Size(457, 324);
            this.rulesBox.TabIndex = 33;
            this.rulesBox.Text = resources.GetString("rulesBox.Text");
            // 
            // FormRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 397);
            this.Controls.Add(this.rulesBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRules";
            this.Text = "Zasady";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rulesBox;
    }
}