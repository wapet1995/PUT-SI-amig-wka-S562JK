namespace CrewAllocationForms
{
    partial class Form1
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
            this.start_button = new System.Windows.Forms.Button();
            this.flightsAssingmentsTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.addFlightBtn = new System.Windows.Forms.Button();
            this.minStewardsTB = new System.Windows.Forms.TextBox();
            this.minStewardesessTB = new System.Windows.Forms.TextBox();
            this.minFrenchTB = new System.Windows.Forms.TextBox();
            this.minGermanTB = new System.Windows.Forms.TextBox();
            this.minSpanishTB = new System.Windows.Forms.TextBox();
            this.personelNumberTB = new System.Windows.Forms.TextBox();
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.zgc1 = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCrew = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.crewListView = new System.Windows.Forms.ListView();
            this.columnCrew = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flightsListView = new System.Windows.Forms.ListView();
            this.columnFlights = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.personSpanishCbx = new System.Windows.Forms.CheckBox();
            this.personGermanCbx = new System.Windows.Forms.CheckBox();
            this.personFrenchCbx = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.personJobCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.personAddBtn = new System.Windows.Forms.Button();
            this.personNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generateTestCrewBtn = new System.Windows.Forms.Button();
            this.generateTestFlightsBtn = new System.Windows.Forms.Button();
            this.revertFlightsBtn = new System.Windows.Forms.Button();
            this.revertCrewBtn = new System.Windows.Forms.Button();
            this.lotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lotBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrew)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(6, 19);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(123, 23);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // flightsAssingmentsTB
            // 
            this.flightsAssingmentsTB.Location = new System.Drawing.Point(6, 46);
            this.flightsAssingmentsTB.Name = "flightsAssingmentsTB";
            this.flightsAssingmentsTB.Size = new System.Drawing.Size(520, 85);
            this.flightsAssingmentsTB.TabIndex = 20;
            this.flightsAssingmentsTB.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Łamigłówka: Problem przydziału załóg lotniczych";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Nastepne Rozwiązanie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addFlightBtn
            // 
            this.addFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addFlightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addFlightBtn.Location = new System.Drawing.Point(310, 141);
            this.addFlightBtn.Name = "addFlightBtn";
            this.addFlightBtn.Size = new System.Drawing.Size(80, 30);
            this.addFlightBtn.TabIndex = 17;
            this.addFlightBtn.Text = "+";
            this.addFlightBtn.UseVisualStyleBackColor = true;
            this.addFlightBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // minStewardsTB
            // 
            this.minStewardsTB.Location = new System.Drawing.Point(99, 53);
            this.minStewardsTB.Name = "minStewardsTB";
            this.minStewardsTB.Size = new System.Drawing.Size(80, 20);
            this.minStewardsTB.TabIndex = 12;
            // 
            // minStewardesessTB
            // 
            this.minStewardesessTB.Location = new System.Drawing.Point(185, 53);
            this.minStewardesessTB.Name = "minStewardesessTB";
            this.minStewardesessTB.Size = new System.Drawing.Size(80, 20);
            this.minStewardesessTB.TabIndex = 13;
            // 
            // minFrenchTB
            // 
            this.minFrenchTB.Location = new System.Drawing.Point(271, 53);
            this.minFrenchTB.Name = "minFrenchTB";
            this.minFrenchTB.Size = new System.Drawing.Size(80, 20);
            this.minFrenchTB.TabIndex = 14;
            // 
            // minGermanTB
            // 
            this.minGermanTB.Location = new System.Drawing.Point(357, 53);
            this.minGermanTB.Name = "minGermanTB";
            this.minGermanTB.Size = new System.Drawing.Size(80, 20);
            this.minGermanTB.TabIndex = 15;
            // 
            // minSpanishTB
            // 
            this.minSpanishTB.Location = new System.Drawing.Point(443, 53);
            this.minSpanishTB.Name = "minSpanishTB";
            this.minSpanishTB.Size = new System.Drawing.Size(80, 20);
            this.minSpanishTB.TabIndex = 16;
            // 
            // personelNumberTB
            // 
            this.personelNumberTB.Location = new System.Drawing.Point(13, 53);
            this.personelNumberTB.Name = "personelNumberTB";
            this.personelNumberTB.Size = new System.Drawing.Size(80, 20);
            this.personelNumberTB.TabIndex = 11;
            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlights.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.lotBindingSource, "NumerLotu", true));
            this.dataGridViewFlights.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.Size = new System.Drawing.Size(514, 121);
            this.dataGridViewFlights.TabIndex = 21;
            this.dataGridViewFlights.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // zgc1
            // 
            this.zgc1.Location = new System.Drawing.Point(555, 12);
            this.zgc1.Name = "zgc1";
            this.zgc1.ScrollGrace = 0D;
            this.zgc1.ScrollMaxX = 0D;
            this.zgc1.ScrollMaxY = 0D;
            this.zgc1.ScrollMaxY2 = 0D;
            this.zgc1.ScrollMinX = 0D;
            this.zgc1.ScrollMinY = 0D;
            this.zgc1.ScrollMinY2 = 0D;
            this.zgc1.Size = new System.Drawing.Size(640, 501);
            this.zgc1.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.minStewardsTB);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.personelNumberTB);
            this.groupBox1.Controls.Add(this.addFlightBtn);
            this.groupBox1.Controls.Add(this.minStewardesessTB);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.minFrenchTB);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.minSpanishTB);
            this.groupBox1.Controls.Add(this.minGermanTB);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Location = new System.Drawing.Point(12, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 179);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie lotu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(118, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Zatwierdź dane i dodaj lot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Zdefiniuj wymagania lotu - określ liczbę pracowników, minimalne liczby stewardów," +
    " stewardes,\r\npracowników francusko-, niemiecko- i hiszpańskojęzycznych.";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CrewAllocationForms.Properties.Resources.crew;
            this.pictureBox7.Location = new System.Drawing.Point(13, 79);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(80, 58);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CrewAllocationForms.Properties.Resources.male_steward;
            this.pictureBox2.Location = new System.Drawing.Point(99, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CrewAllocationForms.Properties.Resources.female_steward;
            this.pictureBox3.Location = new System.Drawing.Point(185, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CrewAllocationForms.Properties.Resources.France_Flag;
            this.pictureBox4.Location = new System.Drawing.Point(271, 79);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CrewAllocationForms.Properties.Resources.deutschFlag1;
            this.pictureBox5.Location = new System.Drawing.Point(357, 79);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 58);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CrewAllocationForms.Properties.Resources.Spain_Espanya_Flag;
            this.pictureBox6.Location = new System.Drawing.Point(443, 79);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(80, 58);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CrewAllocationForms.Properties.Resources.bg_plane;
            this.pictureBox1.Location = new System.Drawing.Point(551, 581);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewCrew);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 141);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dostępny personel";
            // 
            // dataGridViewCrew
            // 
            this.dataGridViewCrew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCrew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrew.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewCrew.Name = "dataGridViewCrew";
            this.dataGridViewCrew.Size = new System.Drawing.Size(514, 113);
            this.dataGridViewCrew.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.start_button);
            this.groupBox3.Controls.Add(this.flightsAssingmentsTB);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(9, 598);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 137);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wyznaczone przydziały załóg";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.revertCrewBtn);
            this.groupBox4.Controls.Add(this.revertFlightsBtn);
            this.groupBox4.Controls.Add(this.filterBtn);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.crewListView);
            this.groupBox4.Controls.Add(this.flightsListView);
            this.groupBox4.Location = new System.Drawing.Point(857, 519);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 216);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtrowanie wyników na grafie";
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(229, 13);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(103, 23);
            this.filterBtn.TabIndex = 2;
            this.filterBtn.Text = "Filtruj";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Loty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pracownicy";
            // 
            // crewListView
            // 
            this.crewListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crewListView.CheckBoxes = true;
            this.crewListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCrew});
            this.crewListView.FullRowSelect = true;
            this.crewListView.Location = new System.Drawing.Point(158, 62);
            this.crewListView.MultiSelect = false;
            this.crewListView.Name = "crewListView";
            this.crewListView.Size = new System.Drawing.Size(174, 148);
            this.crewListView.TabIndex = 22;
            this.crewListView.UseCompatibleStateImageBehavior = false;
            this.crewListView.View = System.Windows.Forms.View.Details;
            // 
            // columnCrew
            // 
            this.columnCrew.Text = "Personel";
            this.columnCrew.Width = 166;
            // 
            // flightsListView
            // 
            this.flightsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.flightsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flightsListView.CheckBoxes = true;
            this.flightsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFlights});
            this.flightsListView.FullRowSelect = true;
            this.flightsListView.Location = new System.Drawing.Point(6, 62);
            this.flightsListView.MultiSelect = false;
            this.flightsListView.Name = "flightsListView";
            this.flightsListView.Size = new System.Drawing.Size(143, 148);
            this.flightsListView.TabIndex = 21;
            this.flightsListView.UseCompatibleStateImageBehavior = false;
            this.flightsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnFlights
            // 
            this.columnFlights.Text = "Loty";
            this.columnFlights.Width = 137;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridViewFlights);
            this.groupBox5.Location = new System.Drawing.Point(9, 434);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(533, 158);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Wymagania lotów";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.personSpanishCbx);
            this.groupBox6.Controls.Add(this.personGermanCbx);
            this.groupBox6.Controls.Add(this.personFrenchCbx);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.personJobCB);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.personAddBtn);
            this.groupBox6.Controls.Add(this.personNameTB);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(15, 34);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(530, 62);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Dodaj personel";
            // 
            // personSpanishCbx
            // 
            this.personSpanishCbx.AutoSize = true;
            this.personSpanishCbx.Location = new System.Drawing.Point(392, 38);
            this.personSpanishCbx.Name = "personSpanishCbx";
            this.personSpanishCbx.Size = new System.Drawing.Size(77, 17);
            this.personSpanishCbx.TabIndex = 5;
            this.personSpanishCbx.Text = "Hiszpański";
            this.personSpanishCbx.UseVisualStyleBackColor = true;
            // 
            // personGermanCbx
            // 
            this.personGermanCbx.AutoSize = true;
            this.personGermanCbx.Location = new System.Drawing.Point(314, 39);
            this.personGermanCbx.Name = "personGermanCbx";
            this.personGermanCbx.Size = new System.Drawing.Size(72, 17);
            this.personGermanCbx.TabIndex = 4;
            this.personGermanCbx.Text = "Niemiecki";
            this.personGermanCbx.UseVisualStyleBackColor = true;
            // 
            // personFrenchCbx
            // 
            this.personFrenchCbx.AutoSize = true;
            this.personFrenchCbx.Location = new System.Drawing.Point(230, 39);
            this.personFrenchCbx.Name = "personFrenchCbx";
            this.personFrenchCbx.Size = new System.Drawing.Size(72, 17);
            this.personFrenchCbx.TabIndex = 3;
            this.personFrenchCbx.Text = "Francuski";
            this.personFrenchCbx.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Języki, którymi się posługuje:";
            // 
            // personJobCB
            // 
            this.personJobCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personJobCB.FormattingEnabled = true;
            this.personJobCB.Items.AddRange(new object[] {
            "Steward",
            "Stewardesa"});
            this.personJobCB.Location = new System.Drawing.Point(118, 36);
            this.personJobCB.Name = "personJobCB";
            this.personJobCB.Size = new System.Drawing.Size(98, 21);
            this.personJobCB.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Zawód:";
            // 
            // personAddBtn
            // 
            this.personAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.personAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personAddBtn.Location = new System.Drawing.Point(475, 20);
            this.personAddBtn.Name = "personAddBtn";
            this.personAddBtn.Size = new System.Drawing.Size(45, 35);
            this.personAddBtn.TabIndex = 6;
            this.personAddBtn.Text = "+";
            this.personAddBtn.UseVisualStyleBackColor = true;
            this.personAddBtn.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // personNameTB
            // 
            this.personNameTB.Location = new System.Drawing.Point(10, 36);
            this.personNameTB.Name = "personNameTB";
            this.personNameTB.Size = new System.Drawing.Size(100, 20);
            this.personNameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Imię:";
            // 
            // generateTestCrewBtn
            // 
            this.generateTestCrewBtn.Location = new System.Drawing.Point(555, 532);
            this.generateTestCrewBtn.Name = "generateTestCrewBtn";
            this.generateTestCrewBtn.Size = new System.Drawing.Size(149, 40);
            this.generateTestCrewBtn.TabIndex = 29;
            this.generateTestCrewBtn.Text = "Generuj testowe dane personelu";
            this.generateTestCrewBtn.UseVisualStyleBackColor = true;
            this.generateTestCrewBtn.Click += new System.EventHandler(this.generateTestCrewBtn_Click);
            // 
            // generateTestFlightsBtn
            // 
            this.generateTestFlightsBtn.Location = new System.Drawing.Point(710, 532);
            this.generateTestFlightsBtn.Name = "generateTestFlightsBtn";
            this.generateTestFlightsBtn.Size = new System.Drawing.Size(141, 40);
            this.generateTestFlightsBtn.TabIndex = 29;
            this.generateTestFlightsBtn.Text = "Generuj testowe dane lotów";
            this.generateTestFlightsBtn.UseVisualStyleBackColor = true;
            this.generateTestFlightsBtn.Click += new System.EventHandler(this.generateTestFlightsBtn_Click);
            // 
            // revertFlightsBtn
            // 
            this.revertFlightsBtn.Location = new System.Drawing.Point(74, 35);
            this.revertFlightsBtn.Name = "revertFlightsBtn";
            this.revertFlightsBtn.Size = new System.Drawing.Size(75, 23);
            this.revertFlightsBtn.TabIndex = 24;
            this.revertFlightsBtn.Text = "Odwróc";
            this.revertFlightsBtn.UseVisualStyleBackColor = true;
            this.revertFlightsBtn.Click += new System.EventHandler(this.revertFlightsBtn_Click);
            // 
            // revertCrewBtn
            // 
            this.revertCrewBtn.Location = new System.Drawing.Point(257, 35);
            this.revertCrewBtn.Name = "revertCrewBtn";
            this.revertCrewBtn.Size = new System.Drawing.Size(75, 23);
            this.revertCrewBtn.TabIndex = 24;
            this.revertCrewBtn.Text = "Odwróc";
            this.revertCrewBtn.UseVisualStyleBackColor = true;
            this.revertCrewBtn.Click += new System.EventHandler(this.revertCrewBtn_Click);
            // 
            // lotBindingSource
            // 
            this.lotBindingSource.DataSource = typeof(CrewAllocationForms.FlightData);
            // 
            // lotBindingSource1
            // 
            this.lotBindingSource1.DataSource = typeof(CrewAllocationForms.FlightData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 747);
            this.Controls.Add(this.generateTestFlightsBtn);
            this.Controls.Add(this.generateTestCrewBtn);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zgc1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Problem przydzielania załóg lotniczych (SWI-Prolog)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrew)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.RichTextBox flightsAssingmentsTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addFlightBtn;
        private System.Windows.Forms.TextBox minStewardsTB;
        private System.Windows.Forms.TextBox minStewardesessTB;
        private System.Windows.Forms.TextBox minFrenchTB;
        private System.Windows.Forms.TextBox minGermanTB;
        private System.Windows.Forms.TextBox minSpanishTB;
        private System.Windows.Forms.BindingSource lotBindingSource;
        private System.Windows.Forms.TextBox personelNumberTB;
        private System.Windows.Forms.DataGridView dataGridViewFlights;
        private System.Windows.Forms.BindingSource lotBindingSource1;
        private ZedGraph.ZedGraphControl zgc1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewCrew;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView crewListView;
        private System.Windows.Forms.ListView flightsListView;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.ColumnHeader columnFlights;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnCrew;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox personJobCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox personNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox personSpanishCbx;
        private System.Windows.Forms.CheckBox personGermanCbx;
        private System.Windows.Forms.CheckBox personFrenchCbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button personAddBtn;
        private System.Windows.Forms.Button generateTestCrewBtn;
        private System.Windows.Forms.Button generateTestFlightsBtn;
        private System.Windows.Forms.Button revertCrewBtn;
        private System.Windows.Forms.Button revertFlightsBtn;
    }
}

