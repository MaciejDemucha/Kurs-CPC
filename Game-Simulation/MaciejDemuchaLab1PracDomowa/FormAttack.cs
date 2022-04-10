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
    public partial class FormAttack : Form
    {
        /// <summary>
        /// zmienne boolowskie przechowujące informacje o podjęctej decyzji
        /// </summary>
        bool fight;
        bool pay;
        bool surrender;
        public FormAttack(bool fight, bool pay, bool surrender)
        {
            InitializeComponent();
            this.fight = fight;
            this.pay = pay;
            this.surrender = surrender;
        }
        /// <summary>
        /// metody zmieniające wartości zmiennych w zależności od decyzji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFight_Click(object sender, EventArgs e)
        {
            this.fight = true;
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            this.pay = true;
        }

        private void buttonSurrender_Click(object sender, EventArgs e)
        {
            this.surrender = true;
        }
        /// <summary>
        /// gettery zwracające wartości zmiennych boolean
        /// </summary>
        /// <returns></returns>
        public bool getFight()
        {
            return this.fight;
        }
        public bool getPay()
        {
            return this.pay;
        }
        public bool getSurrender()
        {
            return this.surrender;
        }
    }
}
