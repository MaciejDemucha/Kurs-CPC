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
    public partial class FormMain : Form
    {
        /// <summary>
        /// zmienne odpowiedzialne za zliczanie taktów timera
        /// </summary>
        int counter = 0;
        /// <summary>
        /// zmienne potrzebne do mierzenia czasu gry
        /// </summary>
        int h, m, s;
        System.Timers.Timer gameTime;

        /// <summary>
        /// zmienne odpowiadające za zliczanie surowców
        /// </summary>
        int gold = 100;
        int steel = 50;
        int wood = 100;
        int crystal = 50;
        int food = 200;
        static int army = 3;

        /// <summary>
        /// zmienne odpowiadające za prędkość przyrostu surowców
        /// </summary>
        int goldSpeed = 5;
        int steelSpeed = 5;
        int woodSpeed = 5;
        int crystalSpeed = 5;
        int foodSpeed = 5 - army;

        /// <summary>
        /// zmienne odpowiadające za przechowywanie poziomu ulepszeń wydobycia
        /// </summary>
        int goldLevel = 1;
        int steelLevel = 1;
        int woodLevel = 1;
        int crystalLevel = 1;
        int foodLevel = 1;

        /// <summary>
        /// zmienne boolowskie przechowujące informacje o zakupie zabezpieczeń przed zdarzeniami
        /// </summary>
        bool peace = false;
        bool retention = false;

        /// <summary>
        /// zmienna losowa używana przy wydarzeniach losowych
        /// </summary>
       Random rnd = new Random();
        /// <summary>
        /// zmienna przechowująca losowy numer decydujący o zdarzeniach losowych
        /// </summary>
        int eventNumber;
        /// <summary>
        /// zmienne przechowujące referencje do instancji poszczególnych Forms
        /// </summary>
        private FormRules formRules;
        private FormAttack formAttack;
        private FormDrought formDrought;
        private FormFlood formFlood;
        
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metody odpowiadające za ulepszanie prędkości uzyskiwania surowców i wyświetlanie poziomu na właściwym pasku postępu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void improveGoldSpeed(object sender, EventArgs e)
        {
            if(goldLevel == 3)
            {
                MessageBox.Show("Osiągnięto maksymalny poziom ulepszeń");
            }
            else
            {
                if (steel >= 200 && wood >= 100 && crystal >= 100)
                {
                    goldSpeed += 5;
                    goldLevel++;

                    steel -= 200;
                    wood -= 100;
                    crystal -= 100;

                    labelGold.Text = gold.ToString();
                    labelCrystal.Text = crystal.ToString();
                    labelWood.Text = wood.ToString();

                    goldBar.Increment(50);
                }
                else
                {
                    NoMoney();
                }
            }
        }

        private void improveSteelSpeed(object sender, EventArgs e)
        {
            if (steelLevel == 3)
            {
                MessageBox.Show("Osiągnięto maksymalny poziom ulepszeń");
            }
            else
            {
                if (wood >= 250 && gold >= 200)
                {
                    steelSpeed += 5;
                    steelLevel++;

                    wood -= 250;
                    gold -= 200;

                    labelGold.Text = gold.ToString();
                    labelWood.Text = wood.ToString();

                    steelBar.Increment(50);
                }
                else
                {
                    NoMoney();
                }
            }
        }

        private void improveWoodSpeed(object sender, EventArgs e)
        {
            if (woodLevel == 3)
            {
                MessageBox.Show("Osiągnięto maksymalny poziom ulepszeń");
            }
            else
            {
                if (gold >= 100 && steel >= 150)
                {
                    woodSpeed += 5;
                    woodLevel++;

                    gold -= 100;
                    steel -= 150;

                    labelGold.Text = gold.ToString();
                    labelSteel.Text = steel.ToString();

                    woodBar.Increment(50);
                }
                else
                {
                    NoMoney();
                }
            }
        }

        private void improveCrystalSpeed(object sender, EventArgs e)
        {
            if (crystalLevel == 3)
            {
                MessageBox.Show("Osiągnięto maksymalny poziom ulepszeń");
            }
            else
            {
                if (steel >= 200 && gold >= 300)
                {
                    crystalSpeed += 5;
                    crystalLevel++;

                    steel -= 200;
                    gold -= 300;

                    labelGold.Text = gold.ToString();
                    labelSteel.Text = steel.ToString();

                    crystalBar.Increment(50);
                }
                else
                {
                    NoMoney();
                }
            }
        }

        private void improveFoodSpeed(object sender, EventArgs e)
        {
            if (foodLevel == 3)
            {
                MessageBox.Show("Osiągnięto maksymalny poziom ulepszeń");
            }
            else
            {
                if(gold>=250 && wood>=200)
                {
                    foodSpeed += 5;
                    foodLevel++;

                    gold -= 250;
                    wood -= 200;

                    labelGold.Text = gold.ToString();
                    labelWood.Text = wood.ToString();

                    foodBar.Increment(50);
                }
                else
                {
                    NoMoney();
                }
            }
        }
        /// <summary>
        /// metoda obsługująca kupowanie jednostek i zapisująca zaktualizowaną ilość na ekranie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buyArmy(object sender, EventArgs e)
        {
            if(gold>=50 && steel>=20 && food>=20)
            {
                //pomocnicze zmienne lokalne przechowująca poprzednie tempo przyrostu zasobów
                int previousFoodSpeed = foodSpeed;
                int previousGoldSpeed = goldSpeed;
                army++;
                foodSpeed = previousFoodSpeed - 1;
                goldSpeed = previousGoldSpeed - 1;
                labelArmy.Text = army.ToString();

                gold -= 50;
                steel -= 20;
                food -= 20;

                labelGold.Text = gold.ToString();
                labelSteel.Text = steel.ToString();
                labelFood.Text = food.ToString();
            }
            else
            {
                NoMoney();
            }
        }
        /// <summary>
        /// metoda zliczająca cykle timera, dodające zebrane surowce i losująca zdarzenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;

            gold += goldSpeed;
            steel += steelSpeed;
            wood += woodSpeed;
            crystal += crystalSpeed;
            food += foodSpeed;

            labelGold.Text = gold.ToString();
            labelSteel.Text = steel.ToString();
            labelWood.Text = wood.ToString();
            labelCrystal.Text = crystal.ToString();
            labelFood.Text = food.ToString();
            
            //zdarzenia losowe, zaczynają sie po 15 cyklach (1 minuta), numer jest losowany co 10 cykli(40 s)
            
           if (counter >= 15)              
            {
                if (counter % 10 == 0)
                {
                    eventNumber = rnd.Next(100);

                    if (eventNumber == 1)
                    {
                        timer.Stop();
                        Drought();
                        timer.Start();
                    }

                    if (eventNumber == 50)
                    {
                        timer.Stop();
                        Flood();
                        timer.Start();
                    }

                    if (eventNumber == 90)
                    {
                        timer.Stop();
                        Attack();
                        timer.Start();
                    }
                }
            }

            if (army > 0 && gold <= 0)
            {
                timer.Stop();
                Desertion();
                timer.Start();
            }

                //koniec gry
                if (food<=0)
            {
                GameOver();
            }
        }
        /// <summary>
        /// metody wyświetlające okno zasad gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRules_Click(object sender, EventArgs e)
        {
            formRules = new FormRules();
            formRules.Show();

        }
        /// <summary>
        /// metody obsługujące zakup zabezpieczenia "zawieszenie broni"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPeace_Click(object sender, EventArgs e)
        {
            if(gold >= 1000 && crystal>= 300)
            {
                peace = true;
                gold -= 1000;
                crystal -= 300;

                labelGold.Text = gold.ToString();
                labelCrystal.Text = crystal.ToString();
            }
            else
            {
                NoMoney();
            }
        }
        /// <summary>
        /// metoda obsługująca kupowanie zabezpieczenia "system fos i retencji"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRetention_Click(object sender, EventArgs e)
        {
            if(gold >= 500 && wood >= 400 && steel >=300)
            {
                gold -= 500;
                wood -= 400;
                steel -= 300;
                retention = true;

                labelGold.Text = gold.ToString();
                labelSteel.Text = steel.ToString();
                labelWood.Text = wood.ToString();
            }
            else
            {
                NoMoney();
            }   
        }
        /// <summary>
        /// metody wyśiwetlające informacje o zabezpieczeniach
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void peaceInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gwarancja braku ataków wrogiego wojska " +
                "\n\n Koszt: \n\n 1000 złota \n\n 300 kryształów");
        }

        private void retentionInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zabezpieczenie przed katastrofami uderzającymi w produkcję żywności " +
                "\n\n Koszt: \n\n 500 złota \n\n 300 stali \n\n 400 drewna");
        }
        /// <summary>
        /// metoda powiadamiająca o braku potrzebnych zasobów
        /// </summary>
        private void NoMoney()
        {
            MessageBox.Show("Nie masz wystarczającej ilości zasobów!");
        }
        /// <summary>
        /// metody obsługująca wydarzenie "susza"
        /// </summary>
        private void Drought()
        {
            if (retention == false)
            {
                formDrought = new FormDrought(false, false);
                formDrought.Show();
                if (formDrought.getPay())
                {
                    if (gold >= 400 && crystal >= 200)
                    {
                        gold -= 400;
                        crystal -= 200;
                        labelGold.Text = gold.ToString();
                        labelCrystal.Text = crystal.ToString();
                        formDrought.Close();
                    }
                    else
                    {
                        NoMoney();
                    }
                }
                else if (formDrought.getWait())
                {
                    food -= 500;
                    labelFood.Text = food.ToString();
                    formDrought.Close();
                }
            }
        }
        /// <summary>
        /// metoda obsługująca wydarzenie "powódź"
        /// </summary>
        private void Flood()
        {
            if (retention == false)
            {
                formFlood = new FormFlood(false, false);
                formFlood.Show();
                if (formFlood.getPay())
                {
                    if (gold >= 400 && crystal >= 200)
                    {
                        gold -= 400;
                        crystal -= 200;
                        labelGold.Text = gold.ToString();
                        labelCrystal.Text = crystal.ToString();
                        formFlood.Close();
                    }
                    else
                    {
                        NoMoney();
                    }
                }
                else if (formFlood.getWait())
                {
                    food -= 300;
                    if(army>=5)
                    {
                        army -= 5;
                    }
                    else
                    {
                        army = 0;
                    }
                    labelFood.Text = food.ToString();
                    labelArmy.Text = army.ToString();
                    formFlood.Close();
                }
            }
        }
        /// <summary>
        /// metoda obsługująca wydarzenie "atak wrogich wojsk"
        /// </summary>
        private void Attack()
        {
            if(peace == false)
            {
                formAttack = new FormAttack(false, false, false);
                formAttack.Show();

                if(formAttack.getFight())
                {
                    if (army < 10)
                    {
                        MessageBox.Show("Za mało żołnierzy, aby odeprzeć atak \n Twoje królestwo zostało podbite");
                        formAttack.Close();
                        GameOver();
                    }
                    else
                    {
                        //losowa ilość poległych żołnierzy
                        int dead = rnd.Next(11);
                        army -= dead;
                        labelArmy.Text = army.ToString();
                        formAttack.Close();
                        MessageBox.Show("W walkach poległo " + dead + " żołnierzy");
                    }
                }
                else if(formAttack.getPay())
                {
                    if(gold>=500 && crystal >= 300)
                    {
                        gold -= 500;
                        crystal -= 300;
                        labelGold.Text = gold.ToString();
                        labelCrystal.Text = crystal.ToString();
                        formAttack.Close();
                    }
                    else
                    {
                        NoMoney();
                    }
                }
                else if(formAttack.getSurrender())
                {
                    formAttack.Close();
                    GameOver();
                }
            }   
        }
        /// <summary>
        /// metoda zamykająca grę po przegranej
        /// </summary>
        private void GameOver()
        {
            timer.Stop();
            DialogResult gameOver = MessageBox.Show("Twoje królestwo nie przetrwało", "Przegrałeś", MessageBoxButtons.OK);
            if (gameOver == DialogResult.OK)
                Application.Exit();
             
        }
        /// <summary>
        /// metoda działająca w momencie dezercji wojska
        /// </summary>
        private void Desertion()
        {
            MessageBox.Show("Nie masz środków na wypłatę żołdu, twoja armia zdezerterowała");
            //zmienne lokalne pomocnicze przechowujące informacje o tempie przyrostu zasobów
            int previousFoodSpeed = foodSpeed;
            int previousGoldSpeed = goldSpeed;
            int previousArmy = army;
            army = 0;
            foodSpeed = previousFoodSpeed + previousArmy;
            goldSpeed = previousGoldSpeed + previousArmy;
        }
       /// <summary>
       /// metody przycisków start i pauza
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            gameTime.Stop();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            gameTime.Start();
        }
        /// <summary>
        /// metody odpowiadające za funkcjonowanie pomiaru czasu gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            gameTime = new System.Timers.Timer();
            gameTime.Interval = 1000;
            gameTime.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s++;
                if (s == 60)
                {
                    s = 0;
                    m++;
                }
                if (m == 60)
                {
                    m = 0;
                    h++;
                }
                gameTimer.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
    }
}
