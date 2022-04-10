
namespace MaciejDemuchaLab1PracDomowa
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.improveGoldButton = new System.Windows.Forms.Button();
            this.resourcesLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.improveSteelButton = new System.Windows.Forms.Button();
            this.improveWoodButton = new System.Windows.Forms.Button();
            this.improveCrystalButton = new System.Windows.Forms.Button();
            this.improveFoodButton = new System.Windows.Forms.Button();
            this.buyArmyButton = new System.Windows.Forms.Button();
            this.labelEnhance = new System.Windows.Forms.Label();
            this.labelGold = new System.Windows.Forms.Label();
            this.labelSteel = new System.Windows.Forms.Label();
            this.labelWood = new System.Windows.Forms.Label();
            this.labelCrystal = new System.Windows.Forms.Label();
            this.labelFood = new System.Windows.Forms.Label();
            this.labelArmy = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRules = new System.Windows.Forms.Button();
            this.buttonRetention = new System.Windows.Forms.Button();
            this.buttonPeace = new System.Windows.Forms.Button();
            this.retentionLabel = new System.Windows.Forms.Label();
            this.peaceLabel = new System.Windows.Forms.Label();
            this.peaceInfo = new System.Windows.Forms.Button();
            this.retentionInfo = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.pictureArmy = new System.Windows.Forms.PictureBox();
            this.pictureFood = new System.Windows.Forms.PictureBox();
            this.pictureCrystal = new System.Windows.Forms.PictureBox();
            this.pictureWood = new System.Windows.Forms.PictureBox();
            this.pictureSteel = new System.Windows.Forms.PictureBox();
            this.pictureGold = new System.Windows.Forms.PictureBox();
            this.goldBar = new System.Windows.Forms.ProgressBar();
            this.steelBar = new System.Windows.Forms.ProgressBar();
            this.woodBar = new System.Windows.Forms.ProgressBar();
            this.crystalBar = new System.Windows.Forms.ProgressBar();
            this.foodBar = new System.Windows.Forms.ProgressBar();
            this.levelLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArmy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCrystal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSteel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGold)).BeginInit();
            this.SuspendLayout();
            // 
            // improveGoldButton
            // 
            this.improveGoldButton.Location = new System.Drawing.Point(181, 512);
            this.improveGoldButton.Name = "improveGoldButton";
            this.improveGoldButton.Size = new System.Drawing.Size(115, 55);
            this.improveGoldButton.TabIndex = 0;
            this.improveGoldButton.Text = "Ulepsz kopalnię złota";
            this.improveGoldButton.UseVisualStyleBackColor = true;
            this.improveGoldButton.Click += new System.EventHandler(this.improveGoldSpeed);
            // 
            // resourcesLabel
            // 
            this.resourcesLabel.AutoSize = true;
            this.resourcesLabel.Location = new System.Drawing.Point(62, 48);
            this.resourcesLabel.Name = "resourcesLabel";
            this.resourcesLabel.Size = new System.Drawing.Size(66, 17);
            this.resourcesLabel.TabIndex = 4;
            this.resourcesLabel.Text = "Surowce:";
            // 
            // timer
            // 
            this.timer.Interval = 4000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // improveSteelButton
            // 
            this.improveSteelButton.Location = new System.Drawing.Point(337, 512);
            this.improveSteelButton.Name = "improveSteelButton";
            this.improveSteelButton.Size = new System.Drawing.Size(124, 55);
            this.improveSteelButton.TabIndex = 12;
            this.improveSteelButton.Text = "Ulepsz kopalnię żelaza";
            this.improveSteelButton.UseVisualStyleBackColor = true;
            this.improveSteelButton.Click += new System.EventHandler(this.improveSteelSpeed);
            // 
            // improveWoodButton
            // 
            this.improveWoodButton.Location = new System.Drawing.Point(501, 512);
            this.improveWoodButton.Name = "improveWoodButton";
            this.improveWoodButton.Size = new System.Drawing.Size(115, 55);
            this.improveWoodButton.TabIndex = 13;
            this.improveWoodButton.Text = "Ulepsz tartak";
            this.improveWoodButton.UseVisualStyleBackColor = true;
            this.improveWoodButton.Click += new System.EventHandler(this.improveWoodSpeed);
            // 
            // improveCrystalButton
            // 
            this.improveCrystalButton.Location = new System.Drawing.Point(661, 512);
            this.improveCrystalButton.Name = "improveCrystalButton";
            this.improveCrystalButton.Size = new System.Drawing.Size(118, 55);
            this.improveCrystalButton.TabIndex = 14;
            this.improveCrystalButton.Text = "Ulepsz kopalnię kryształów";
            this.improveCrystalButton.UseVisualStyleBackColor = true;
            this.improveCrystalButton.Click += new System.EventHandler(this.improveCrystalSpeed);
            // 
            // improveFoodButton
            // 
            this.improveFoodButton.Location = new System.Drawing.Point(821, 512);
            this.improveFoodButton.Name = "improveFoodButton";
            this.improveFoodButton.Size = new System.Drawing.Size(115, 55);
            this.improveFoodButton.TabIndex = 15;
            this.improveFoodButton.Text = "Ulepsz farmę";
            this.improveFoodButton.UseVisualStyleBackColor = true;
            this.improveFoodButton.Click += new System.EventHandler(this.improveFoodSpeed);
            // 
            // buyArmyButton
            // 
            this.buyArmyButton.Location = new System.Drawing.Point(981, 512);
            this.buyArmyButton.Name = "buyArmyButton";
            this.buyArmyButton.Size = new System.Drawing.Size(112, 55);
            this.buyArmyButton.TabIndex = 16;
            this.buyArmyButton.Text = "Rekrutuj żołnierzy";
            this.buyArmyButton.UseVisualStyleBackColor = true;
            this.buyArmyButton.Click += new System.EventHandler(this.buyArmy);
            // 
            // labelEnhance
            // 
            this.labelEnhance.AutoSize = true;
            this.labelEnhance.Location = new System.Drawing.Point(67, 527);
            this.labelEnhance.Name = "labelEnhance";
            this.labelEnhance.Size = new System.Drawing.Size(82, 17);
            this.labelEnhance.TabIndex = 17;
            this.labelEnhance.Text = "Ulepszenia:";
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.Location = new System.Drawing.Point(280, 78);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(32, 17);
            this.labelGold.TabIndex = 24;
            this.labelGold.Text = "100";
            // 
            // labelSteel
            // 
            this.labelSteel.AutoSize = true;
            this.labelSteel.Location = new System.Drawing.Point(410, 78);
            this.labelSteel.Name = "labelSteel";
            this.labelSteel.Size = new System.Drawing.Size(24, 17);
            this.labelSteel.TabIndex = 25;
            this.labelSteel.Text = "50";
            // 
            // labelWood
            // 
            this.labelWood.AutoSize = true;
            this.labelWood.Location = new System.Drawing.Point(541, 78);
            this.labelWood.Name = "labelWood";
            this.labelWood.Size = new System.Drawing.Size(32, 17);
            this.labelWood.TabIndex = 26;
            this.labelWood.Text = "100";
            // 
            // labelCrystal
            // 
            this.labelCrystal.AutoSize = true;
            this.labelCrystal.Location = new System.Drawing.Point(674, 78);
            this.labelCrystal.Name = "labelCrystal";
            this.labelCrystal.Size = new System.Drawing.Size(24, 17);
            this.labelCrystal.TabIndex = 27;
            this.labelCrystal.Text = "50";
            // 
            // labelFood
            // 
            this.labelFood.AutoSize = true;
            this.labelFood.Location = new System.Drawing.Point(795, 78);
            this.labelFood.Name = "labelFood";
            this.labelFood.Size = new System.Drawing.Size(32, 17);
            this.labelFood.TabIndex = 28;
            this.labelFood.Text = "200";
            // 
            // labelArmy
            // 
            this.labelArmy.AutoSize = true;
            this.labelArmy.Location = new System.Drawing.Point(926, 78);
            this.labelArmy.Name = "labelArmy";
            this.labelArmy.Size = new System.Drawing.Size(16, 17);
            this.labelArmy.TabIndex = 29;
            this.labelArmy.Text = "3";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1144, 120);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(72, 49);
            this.buttonStart.TabIndex = 30;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonRules
            // 
            this.buttonRules.Location = new System.Drawing.Point(1144, 240);
            this.buttonRules.Name = "buttonRules";
            this.buttonRules.Size = new System.Drawing.Size(72, 49);
            this.buttonRules.TabIndex = 31;
            this.buttonRules.Text = "Zasady";
            this.buttonRules.UseVisualStyleBackColor = true;
            this.buttonRules.Click += new System.EventHandler(this.buttonRules_Click);
            // 
            // buttonRetention
            // 
            this.buttonRetention.Location = new System.Drawing.Point(1140, 426);
            this.buttonRetention.Name = "buttonRetention";
            this.buttonRetention.Size = new System.Drawing.Size(85, 34);
            this.buttonRetention.TabIndex = 36;
            this.buttonRetention.Text = "Zapłać";
            this.buttonRetention.UseVisualStyleBackColor = true;
            this.buttonRetention.Click += new System.EventHandler(this.buttonRetention_Click);
            // 
            // buttonPeace
            // 
            this.buttonPeace.Location = new System.Drawing.Point(1140, 591);
            this.buttonPeace.Name = "buttonPeace";
            this.buttonPeace.Size = new System.Drawing.Size(85, 34);
            this.buttonPeace.TabIndex = 35;
            this.buttonPeace.Text = "Zapłać";
            this.buttonPeace.UseVisualStyleBackColor = true;
            this.buttonPeace.Click += new System.EventHandler(this.buttonPeace_Click);
            // 
            // retentionLabel
            // 
            this.retentionLabel.AutoSize = true;
            this.retentionLabel.Location = new System.Drawing.Point(1116, 329);
            this.retentionLabel.Name = "retentionLabel";
            this.retentionLabel.Size = new System.Drawing.Size(134, 17);
            this.retentionLabel.TabIndex = 34;
            this.retentionLabel.Text = "System fos i retencji";
            // 
            // peaceLabel
            // 
            this.peaceLabel.AutoSize = true;
            this.peaceLabel.Location = new System.Drawing.Point(1117, 499);
            this.peaceLabel.Name = "peaceLabel";
            this.peaceLabel.Size = new System.Drawing.Size(122, 17);
            this.peaceLabel.TabIndex = 33;
            this.peaceLabel.Text = "Zawieszenie broni";
            // 
            // peaceInfo
            // 
            this.peaceInfo.Location = new System.Drawing.Point(1140, 533);
            this.peaceInfo.Name = "peaceInfo";
            this.peaceInfo.Size = new System.Drawing.Size(85, 34);
            this.peaceInfo.TabIndex = 37;
            this.peaceInfo.Text = "Informacje";
            this.peaceInfo.UseVisualStyleBackColor = true;
            this.peaceInfo.Click += new System.EventHandler(this.peaceInfo_Click);
            // 
            // retentionInfo
            // 
            this.retentionInfo.Location = new System.Drawing.Point(1140, 368);
            this.retentionInfo.Name = "retentionInfo";
            this.retentionInfo.Size = new System.Drawing.Size(85, 34);
            this.retentionInfo.TabIndex = 38;
            this.retentionInfo.Text = "Informacje";
            this.retentionInfo.UseVisualStyleBackColor = true;
            this.retentionInfo.Click += new System.EventHandler(this.retentionInfo_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(1144, 180);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(72, 49);
            this.buttonStop.TabIndex = 39;
            this.buttonStop.Text = "Pauza";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "250 drewno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 585);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "200 złoto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(371, 568);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Koszt:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(536, 602);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "150 stal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(536, 585);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "100 złoto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(536, 568);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Koszt:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(697, 602);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "200 stal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(697, 585);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 47;
            this.label14.Text = "300 złoto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(697, 568);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 17);
            this.label15.TabIndex = 46;
            this.label15.Text = "Koszt:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(851, 602);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 17);
            this.label16.TabIndex = 51;
            this.label16.Text = "200 drewno";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(851, 585);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 17);
            this.label17.TabIndex = 50;
            this.label17.Text = "250 złoto";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(851, 568);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 17);
            this.label18.TabIndex = 49;
            this.label18.Text = "Koszt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Koszt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "200 stal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 602);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "100 drewno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 619);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "100 kryształów";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1018, 619);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 17);
            this.label19.TabIndex = 55;
            this.label19.Text = "20 żywność";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1018, 602);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 17);
            this.label20.TabIndex = 54;
            this.label20.Text = "20 stal";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1018, 585);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 17);
            this.label21.TabIndex = 53;
            this.label21.Text = "50 złoto";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(1018, 568);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 17);
            this.label22.TabIndex = 52;
            this.label22.Text = "Koszt:";
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = global::MaciejDemuchaLab1PracDomowa.Properties.Resources.castle;
            this.pictureBoxMenu.Location = new System.Drawing.Point(65, 104);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(1026, 399);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenu.TabIndex = 56;
            this.pictureBoxMenu.TabStop = false;
            // 
            // pictureArmy
            // 
            this.pictureArmy.BackColor = System.Drawing.Color.Transparent;
            this.pictureArmy.Image = global::MaciejDemuchaLab1PracDomowa.Properties.Resources.army;
            this.pictureArmy.ImageLocation = "";
            this.pictureArmy.InitialImage = null;
            this.pictureArmy.Location = new System.Drawing.Point(904, 24);
            this.pictureArmy.Name = "pictureArmy";
            this.pictureArmy.Size = new System.Drawing.Size(56, 51);
            this.pictureArmy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureArmy.TabIndex = 11;
            this.pictureArmy.TabStop = false;
            // 
            // pictureFood
            // 
            this.pictureFood.BackColor = System.Drawing.Color.Transparent;
            this.pictureFood.Image = global::MaciejDemuchaLab1PracDomowa.Properties.Resources.food;
            this.pictureFood.ImageLocation = "";
            this.pictureFood.InitialImage = null;
            this.pictureFood.Location = new System.Drawing.Point(782, 24);
            this.pictureFood.Name = "pictureFood";
            this.pictureFood.Size = new System.Drawing.Size(56, 51);
            this.pictureFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFood.TabIndex = 10;
            this.pictureFood.TabStop = false;
            // 
            // pictureCrystal
            // 
            this.pictureCrystal.BackColor = System.Drawing.Color.Transparent;
            this.pictureCrystal.Image = global::MaciejDemuchaLab1PracDomowa.Properties.Resources.crystal2;
            this.pictureCrystal.ImageLocation = "";
            this.pictureCrystal.InitialImage = null;
            this.pictureCrystal.Location = new System.Drawing.Point(653, 24);
            this.pictureCrystal.Name = "pictureCrystal";
            this.pictureCrystal.Size = new System.Drawing.Size(56, 51);
            this.pictureCrystal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCrystal.TabIndex = 9;
            this.pictureCrystal.TabStop = false;
            // 
            // pictureWood
            // 
            this.pictureWood.BackColor = System.Drawing.Color.Transparent;
            this.pictureWood.Image = global::MaciejDemuchaLab1PracDomowa.Properties.Resources.wood;
            this.pictureWood.ImageLocation = "";
            this.pictureWood.InitialImage = null;
            this.pictureWood.Location = new System.Drawing.Point(524, 24);
            this.pictureWood.Name = "pictureWood";
            this.pictureWood.Size = new System.Drawing.Size(56, 51);
            this.pictureWood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureWood.TabIndex = 8;
            this.pictureWood.TabStop = false;
            // 
            // pictureSteel
            // 
            this.pictureSteel.BackColor = System.Drawing.Color.Transparent;
            this.pictureSteel.Image = global::MaciejDemuchaLab1PracDomowa.Properties.Resources.steel2;
            this.pictureSteel.ImageLocation = "";
            this.pictureSteel.InitialImage = null;
            this.pictureSteel.Location = new System.Drawing.Point(394, 24);
            this.pictureSteel.Name = "pictureSteel";
            this.pictureSteel.Size = new System.Drawing.Size(56, 51);
            this.pictureSteel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSteel.TabIndex = 7;
            this.pictureSteel.TabStop = false;
            // 
            // pictureGold
            // 
            this.pictureGold.BackColor = System.Drawing.Color.Transparent;
            this.pictureGold.Image = global::MaciejDemuchaLab1PracDomowa.Properties.Resources.gold1;
            this.pictureGold.ImageLocation = "";
            this.pictureGold.InitialImage = null;
            this.pictureGold.Location = new System.Drawing.Point(269, 24);
            this.pictureGold.Name = "pictureGold";
            this.pictureGold.Size = new System.Drawing.Size(56, 51);
            this.pictureGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGold.TabIndex = 6;
            this.pictureGold.TabStop = false;
            // 
            // goldBar
            // 
            this.goldBar.Location = new System.Drawing.Point(195, 644);
            this.goldBar.Name = "goldBar";
            this.goldBar.Size = new System.Drawing.Size(86, 17);
            this.goldBar.TabIndex = 57;
            // 
            // steelBar
            // 
            this.steelBar.Location = new System.Drawing.Point(364, 644);
            this.steelBar.Name = "steelBar";
            this.steelBar.Size = new System.Drawing.Size(86, 17);
            this.steelBar.TabIndex = 58;
            // 
            // woodBar
            // 
            this.woodBar.Location = new System.Drawing.Point(516, 644);
            this.woodBar.Name = "woodBar";
            this.woodBar.Size = new System.Drawing.Size(86, 17);
            this.woodBar.TabIndex = 59;
            // 
            // crystalBar
            // 
            this.crystalBar.Location = new System.Drawing.Point(677, 644);
            this.crystalBar.Name = "crystalBar";
            this.crystalBar.Size = new System.Drawing.Size(86, 17);
            this.crystalBar.TabIndex = 60;
            // 
            // foodBar
            // 
            this.foodBar.Location = new System.Drawing.Point(831, 644);
            this.foodBar.Name = "foodBar";
            this.foodBar.Size = new System.Drawing.Size(86, 17);
            this.foodBar.TabIndex = 61;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(67, 644);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(58, 17);
            this.levelLabel.TabIndex = 62;
            this.levelLabel.Text = "Poziom:";
            // 
            // gameTimer
            // 
            this.gameTimer.BackColor = System.Drawing.Color.BurlyWood;
            this.gameTimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gameTimer.Location = new System.Drawing.Point(1129, 46);
            this.gameTimer.Name = "gameTimer";
            this.gameTimer.ReadOnly = true;
            this.gameTimer.Size = new System.Drawing.Size(96, 19);
            this.gameTimer.TabIndex = 63;
            this.gameTimer.Text = "00:00:00";
            this.gameTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.gameTimer);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.foodBar);
            this.Controls.Add(this.crystalBar);
            this.Controls.Add(this.woodBar);
            this.Controls.Add(this.steelBar);
            this.Controls.Add(this.goldBar);
            this.Controls.Add(this.pictureBoxMenu);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.retentionInfo);
            this.Controls.Add(this.peaceInfo);
            this.Controls.Add(this.buttonRetention);
            this.Controls.Add(this.buttonPeace);
            this.Controls.Add(this.retentionLabel);
            this.Controls.Add(this.peaceLabel);
            this.Controls.Add(this.buttonRules);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelArmy);
            this.Controls.Add(this.labelFood);
            this.Controls.Add(this.labelCrystal);
            this.Controls.Add(this.labelWood);
            this.Controls.Add(this.labelSteel);
            this.Controls.Add(this.labelGold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEnhance);
            this.Controls.Add(this.buyArmyButton);
            this.Controls.Add(this.improveFoodButton);
            this.Controls.Add(this.improveCrystalButton);
            this.Controls.Add(this.improveWoodButton);
            this.Controls.Add(this.improveSteelButton);
            this.Controls.Add(this.pictureArmy);
            this.Controls.Add(this.pictureFood);
            this.Controls.Add(this.pictureCrystal);
            this.Controls.Add(this.pictureWood);
            this.Controls.Add(this.pictureSteel);
            this.Controls.Add(this.pictureGold);
            this.Controls.Add(this.resourcesLabel);
            this.Controls.Add(this.improveGoldButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Zarządzaj królestwem!";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArmy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCrystal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSteel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button improveGoldButton;
        private System.Windows.Forms.Label resourcesLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button improveSteelButton;
        private System.Windows.Forms.Button improveWoodButton;
        private System.Windows.Forms.Button improveCrystalButton;
        private System.Windows.Forms.Button improveFoodButton;
        private System.Windows.Forms.Button buyArmyButton;
        private System.Windows.Forms.Label labelEnhance;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Label labelSteel;
        private System.Windows.Forms.Label labelWood;
        private System.Windows.Forms.Label labelCrystal;
        private System.Windows.Forms.Label labelFood;
        private System.Windows.Forms.Label labelArmy;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRules;
        private System.Windows.Forms.Button buttonRetention;
        private System.Windows.Forms.Button buttonPeace;
        private System.Windows.Forms.Label retentionLabel;
        private System.Windows.Forms.Label peaceLabel;
        private System.Windows.Forms.Button peaceInfo;
        private System.Windows.Forms.Button retentionInfo;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureGold;
        private System.Windows.Forms.PictureBox pictureSteel;
        private System.Windows.Forms.PictureBox pictureWood;
        private System.Windows.Forms.PictureBox pictureCrystal;
        private System.Windows.Forms.PictureBox pictureFood;
        private System.Windows.Forms.PictureBox pictureArmy;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.ProgressBar goldBar;
        private System.Windows.Forms.ProgressBar steelBar;
        private System.Windows.Forms.ProgressBar woodBar;
        private System.Windows.Forms.ProgressBar crystalBar;
        private System.Windows.Forms.ProgressBar foodBar;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.TextBox gameTimer;
    }
}

