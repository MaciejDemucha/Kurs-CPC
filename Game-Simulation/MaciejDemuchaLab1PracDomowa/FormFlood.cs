using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaciejDemuchaLab1PracDomowa
{
    public partial class FormFlood : Form
    {
        /// <summary>
        /// zmienne boolowskie przechowujące informacje o podjęctej decyzji
        /// </summary>
        bool pay = false;
        bool wait = false;
        public FormFlood(bool pay, bool wait)
        {
            InitializeComponent();
            this.pay = pay;
            this.wait = wait;
        }
        /// <summary>
        /// metody zmieniające wartości zmiennych w zależności od decyzji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPay_Click(object sender, EventArgs e)
        {
            this.pay = true;
        }

        private void buttonWait_Click(object sender, EventArgs e)
        {
            this.wait = true;
        }
        /// <summary>
        /// gettery zwracające wartości zmiennych boolean
        /// </summary>
        /// <returns></returns>
        public bool getPay()
        {
            return this.pay;
        }
        public bool getWait()
        {
            return this.wait;
        }
    }
}
