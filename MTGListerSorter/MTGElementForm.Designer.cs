namespace MTGListerSorter
{
    partial class MTGElementForm
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colourBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.manaCostBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.editionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rarityBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.locationReservedBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.locationCurrentBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.incrementButton = new System.Windows.Forms.Button();
            this.decrementButton = new System.Windows.Forms.Button();
            this.stdEffectsBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.editCancelButton = new System.Windows.Forms.Button();
            this.duplicateButton = new System.Windows.Forms.Button();
            this.createAcceptButton = new System.Windows.Forms.Button();
            this.cardVariationBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sortButton = new System.Windows.Forms.Button();
            this.colourPanel = new System.Windows.Forms.Panel();
            this.colourListbox = new System.Windows.Forms.ListBox();
            this.languageListbox = new System.Windows.Forms.ListBox();
            this.languagePanel = new System.Windows.Forms.Panel();
            this.rarityListbox = new System.Windows.Forms.ListBox();
            this.rarityPanel = new System.Windows.Forms.Panel();
            this.languageBox = new System.Windows.Forms.TextBox();
            this.cardVariationListbox = new System.Windows.Forms.ListBox();
            this.cardVariationPanel = new System.Windows.Forms.Panel();
            this.typesListbox = new System.Windows.Forms.ListBox();
            this.typesPanel = new System.Windows.Forms.Panel();
            this.editionListbox = new System.Windows.Forms.ListBox();
            this.editionPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.colourPanel.SuspendLayout();
            this.languagePanel.SuspendLayout();
            this.rarityPanel.SuspendLayout();
            this.cardVariationPanel.SuspendLayout();
            this.typesPanel.SuspendLayout();
            this.editionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(48, 0);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(250, 23);
            this.nameBox.TabIndex = 0;
            this.nameBox.Text = "010203040506070809101112131415161718";
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // colourBox
            // 
            this.colourBox.Location = new System.Drawing.Point(376, 0);
            this.colourBox.Name = "colourBox";
            this.colourBox.ReadOnly = true;
            this.colourBox.Size = new System.Drawing.Size(50, 23);
            this.colourBox.TabIndex = 0;
            this.colourBox.Text = "RGBUW";
            this.colourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colourBox.Click += new System.EventHandler(this.colourBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Colour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mana Cost (CMC):";
            // 
            // manaCostBox
            // 
            this.manaCostBox.Location = new System.Drawing.Point(563, 0);
            this.manaCostBox.Name = "manaCostBox";
            this.manaCostBox.Size = new System.Drawing.Size(25, 23);
            this.manaCostBox.TabIndex = 0;
            this.manaCostBox.Text = "20";
            this.manaCostBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Types:";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(48, 29);
            this.typeBox.Name = "typeBox";
            this.typeBox.ReadOnly = true;
            this.typeBox.Size = new System.Drawing.Size(250, 23);
            this.typeBox.TabIndex = 0;
            this.typeBox.Text = "010203040506070809101112131415161718";
            this.typeBox.Click += new System.EventHandler(this.typeBox_Click);
            // 
            // editionBox
            // 
            this.editionBox.Location = new System.Drawing.Point(376, 29);
            this.editionBox.Name = "editionBox";
            this.editionBox.ReadOnly = true;
            this.editionBox.Size = new System.Drawing.Size(35, 23);
            this.editionBox.TabIndex = 0;
            this.editionBox.Text = "WAR";
            this.editionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editionBox.Click += new System.EventHandler(this.editionBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Edition:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rarity:";
            // 
            // rarityBox
            // 
            this.rarityBox.Location = new System.Drawing.Point(498, 29);
            this.rarityBox.Name = "rarityBox";
            this.rarityBox.ReadOnly = true;
            this.rarityBox.Size = new System.Drawing.Size(75, 23);
            this.rarityBox.TabIndex = 0;
            this.rarityBox.Text = "Masterpiece";
            this.rarityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rarityBox.Click += new System.EventHandler(this.rarityBox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Reserved Location:";
            // 
            // locationReservedBox
            // 
            this.locationReservedBox.Location = new System.Drawing.Point(111, 87);
            this.locationReservedBox.Name = "locationReservedBox";
            this.locationReservedBox.ReadOnly = true;
            this.locationReservedBox.Size = new System.Drawing.Size(150, 23);
            this.locationReservedBox.TabIndex = 0;
            this.locationReservedBox.Text = "Vampire Deck";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Current Location:";
            // 
            // locationCurrentBox
            // 
            this.locationCurrentBox.Location = new System.Drawing.Point(111, 116);
            this.locationCurrentBox.Name = "locationCurrentBox";
            this.locationCurrentBox.ReadOnly = true;
            this.locationCurrentBox.Size = new System.Drawing.Size(207, 23);
            this.locationCurrentBox.TabIndex = 0;
            this.locationCurrentBox.Text = "Vampire Deck";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(324, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Language:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Value (€):";
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(392, 116);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(50, 23);
            this.valueBox.TabIndex = 0;
            this.valueBox.Text = "9999.99";
            this.valueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.numberBox);
            this.groupBox1.Controls.Add(this.incrementButton);
            this.groupBox1.Controls.Add(this.decrementButton);
            this.groupBox1.Location = new System.Drawing.Point(468, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Number:";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(66, 16);
            this.numberBox.Name = "numberBox";
            this.numberBox.ReadOnly = true;
            this.numberBox.Size = new System.Drawing.Size(25, 23);
            this.numberBox.TabIndex = 0;
            this.numberBox.Text = "20";
            this.numberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // incrementButton
            // 
            this.incrementButton.Location = new System.Drawing.Point(37, 52);
            this.incrementButton.Name = "incrementButton";
            this.incrementButton.Size = new System.Drawing.Size(23, 23);
            this.incrementButton.TabIndex = 2;
            this.incrementButton.Text = "+";
            this.incrementButton.UseVisualStyleBackColor = true;
            // 
            // decrementButton
            // 
            this.decrementButton.Location = new System.Drawing.Point(66, 52);
            this.decrementButton.Name = "decrementButton";
            this.decrementButton.Size = new System.Drawing.Size(23, 23);
            this.decrementButton.TabIndex = 2;
            this.decrementButton.Text = "-";
            this.decrementButton.UseVisualStyleBackColor = true;
            // 
            // stdEffectsBox
            // 
            this.stdEffectsBox.Location = new System.Drawing.Point(111, 145);
            this.stdEffectsBox.Name = "stdEffectsBox";
            this.stdEffectsBox.ReadOnly = true;
            this.stdEffectsBox.Size = new System.Drawing.Size(310, 23);
            this.stdEffectsBox.TabIndex = 0;
            this.stdEffectsBox.Text = "01020304050607080910111213141516171819202122232425";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-1, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Standard Effects:";
            // 
            // editCancelButton
            // 
            this.editCancelButton.Location = new System.Drawing.Point(127, 209);
            this.editCancelButton.Name = "editCancelButton";
            this.editCancelButton.Size = new System.Drawing.Size(84, 23);
            this.editCancelButton.TabIndex = 3;
            this.editCancelButton.Text = "Edit Selected";
            this.editCancelButton.UseVisualStyleBackColor = true;
            this.editCancelButton.Click += new System.EventHandler(this.editCancelButton_Click);
            // 
            // duplicateButton
            // 
            this.duplicateButton.Location = new System.Drawing.Point(217, 209);
            this.duplicateButton.Name = "duplicateButton";
            this.duplicateButton.Size = new System.Drawing.Size(84, 23);
            this.duplicateButton.TabIndex = 3;
            this.duplicateButton.Text = "Duplicate";
            this.duplicateButton.UseVisualStyleBackColor = true;
            this.duplicateButton.Click += new System.EventHandler(this.duplicateButton_Click);
            // 
            // createAcceptButton
            // 
            this.createAcceptButton.Location = new System.Drawing.Point(37, 209);
            this.createAcceptButton.Name = "createAcceptButton";
            this.createAcceptButton.Size = new System.Drawing.Size(84, 23);
            this.createAcceptButton.TabIndex = 3;
            this.createAcceptButton.Text = "Create New";
            this.createAcceptButton.UseVisualStyleBackColor = true;
            this.createAcceptButton.Click += new System.EventHandler(this.createAcceptButton_Click);
            // 
            // cardVariationBox
            // 
            this.cardVariationBox.Location = new System.Drawing.Point(90, 58);
            this.cardVariationBox.Name = "cardVariationBox";
            this.cardVariationBox.ReadOnly = true;
            this.cardVariationBox.Size = new System.Drawing.Size(350, 23);
            this.cardVariationBox.TabIndex = 0;
            this.cardVariationBox.Text = "Foiled, Alternative Artwork, Borderless, Full Artwork, Promotional";
            this.cardVariationBox.Click += new System.EventHandler(this.cardVariationBox_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-1, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Card Variation:";
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(408, 209);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(84, 23);
            this.sortButton.TabIndex = 3;
            this.sortButton.Text = "Sort/Save";
            this.sortButton.UseVisualStyleBackColor = true;
            // 
            // colourPanel
            // 
            this.colourPanel.Controls.Add(this.colourListbox);
            this.colourPanel.Location = new System.Drawing.Point(377, 23);
            this.colourPanel.Name = "colourPanel";
            this.colourPanel.Size = new System.Drawing.Size(49, 11);
            this.colourPanel.TabIndex = 4;
            this.colourPanel.Leave += new System.EventHandler(this.onLeavePanels);
            // 
            // colourListbox
            // 
            this.colourListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colourListbox.FormattingEnabled = true;
            this.colourListbox.ItemHeight = 15;
            this.colourListbox.Location = new System.Drawing.Point(0, 0);
            this.colourListbox.Name = "colourListbox";
            this.colourListbox.Size = new System.Drawing.Size(49, 11);
            this.colourListbox.TabIndex = 0;
            this.colourListbox.Click += new System.EventHandler(this.onListboxClick);
            this.colourListbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            // 
            // languageListbox
            // 
            this.languageListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.languageListbox.FormattingEnabled = true;
            this.languageListbox.ItemHeight = 15;
            this.languageListbox.Location = new System.Drawing.Point(0, 0);
            this.languageListbox.Name = "languageListbox";
            this.languageListbox.Size = new System.Drawing.Size(24, 14);
            this.languageListbox.TabIndex = 0;
            this.languageListbox.Click += new System.EventHandler(this.onListboxClick);
            this.languageListbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            // 
            // languagePanel
            // 
            this.languagePanel.Controls.Add(this.languageListbox);
            this.languagePanel.Location = new System.Drawing.Point(393, 107);
            this.languagePanel.Name = "languagePanel";
            this.languagePanel.Size = new System.Drawing.Size(24, 14);
            this.languagePanel.TabIndex = 4;
            this.languagePanel.Leave += new System.EventHandler(this.onLeavePanels);
            // 
            // rarityListbox
            // 
            this.rarityListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rarityListbox.FormattingEnabled = true;
            this.rarityListbox.ItemHeight = 15;
            this.rarityListbox.Location = new System.Drawing.Point(0, 0);
            this.rarityListbox.Name = "rarityListbox";
            this.rarityListbox.Size = new System.Drawing.Size(75, 19);
            this.rarityListbox.TabIndex = 0;
            this.rarityListbox.Click += new System.EventHandler(this.onListboxClick);
            this.rarityListbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            // 
            // rarityPanel
            // 
            this.rarityPanel.Controls.Add(this.rarityListbox);
            this.rarityPanel.Location = new System.Drawing.Point(498, 52);
            this.rarityPanel.Name = "rarityPanel";
            this.rarityPanel.Size = new System.Drawing.Size(75, 19);
            this.rarityPanel.TabIndex = 4;
            this.rarityPanel.Leave += new System.EventHandler(this.onLeavePanels);
            // 
            // languageBox
            // 
            this.languageBox.Location = new System.Drawing.Point(392, 87);
            this.languageBox.Name = "languageBox";
            this.languageBox.ReadOnly = true;
            this.languageBox.Size = new System.Drawing.Size(25, 23);
            this.languageBox.TabIndex = 0;
            this.languageBox.Text = "EN";
            this.languageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.languageBox.Click += new System.EventHandler(this.languageBox_Click);
            // 
            // cardVariationListbox
            // 
            this.cardVariationListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardVariationListbox.FormattingEnabled = true;
            this.cardVariationListbox.ItemHeight = 15;
            this.cardVariationListbox.Location = new System.Drawing.Point(0, 0);
            this.cardVariationListbox.Name = "cardVariationListbox";
            this.cardVariationListbox.Size = new System.Drawing.Size(350, 13);
            this.cardVariationListbox.TabIndex = 0;
            this.cardVariationListbox.Click += new System.EventHandler(this.onListboxClick);
            this.cardVariationListbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            // 
            // cardVariationPanel
            // 
            this.cardVariationPanel.Controls.Add(this.cardVariationListbox);
            this.cardVariationPanel.Location = new System.Drawing.Point(90, 81);
            this.cardVariationPanel.Name = "cardVariationPanel";
            this.cardVariationPanel.Size = new System.Drawing.Size(350, 13);
            this.cardVariationPanel.TabIndex = 4;
            this.cardVariationPanel.Leave += new System.EventHandler(this.onLeavePanels);
            // 
            // typesListbox
            // 
            this.typesListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typesListbox.FormattingEnabled = true;
            this.typesListbox.ItemHeight = 15;
            this.typesListbox.Location = new System.Drawing.Point(0, 0);
            this.typesListbox.Name = "typesListbox";
            this.typesListbox.Size = new System.Drawing.Size(250, 13);
            this.typesListbox.TabIndex = 0;
            this.typesListbox.Click += new System.EventHandler(this.onListboxClick);
            this.typesListbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            // 
            // typesPanel
            // 
            this.typesPanel.Controls.Add(this.typesListbox);
            this.typesPanel.Location = new System.Drawing.Point(48, 52);
            this.typesPanel.Name = "typesPanel";
            this.typesPanel.Size = new System.Drawing.Size(250, 13);
            this.typesPanel.TabIndex = 4;
            this.typesPanel.Leave += new System.EventHandler(this.onLeavePanels);
            // 
            // listBox1
            // 
            this.editionListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editionListbox.FormattingEnabled = true;
            this.editionListbox.ItemHeight = 15;
            this.editionListbox.Location = new System.Drawing.Point(0, 0);
            this.editionListbox.Name = "listBox1";
            this.editionListbox.Size = new System.Drawing.Size(35, 13);
            this.editionListbox.TabIndex = 0;
            this.editionListbox.Click += new System.EventHandler(this.onListboxClick);
            this.editionListbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            // 
            // panel1
            // 
            this.editionPanel.Controls.Add(this.editionListbox);
            this.editionPanel.Location = new System.Drawing.Point(376, 52);
            this.editionPanel.Name = "panel1";
            this.editionPanel.Size = new System.Drawing.Size(35, 13);
            this.editionPanel.TabIndex = 4;
            this.editionPanel.Leave += new System.EventHandler(this.onLeavePanels);
            // 
            // MTGElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editionPanel);
            this.Controls.Add(this.typesPanel);
            this.Controls.Add(this.cardVariationPanel);
            this.Controls.Add(this.rarityPanel);
            this.Controls.Add(this.languagePanel);
            this.Controls.Add(this.colourPanel);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cardVariationBox);
            this.Controls.Add(this.createAcceptButton);
            this.Controls.Add(this.duplicateButton);
            this.Controls.Add(this.editCancelButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.stdEffectsBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.languageBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.locationCurrentBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.locationReservedBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rarityBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editionBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.manaCostBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "MTGElementForm";
            this.Size = new System.Drawing.Size(600, 550);
            this.Click += new System.EventHandler(this.onLeavePanels);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.colourPanel.ResumeLayout(false);
            this.languagePanel.ResumeLayout(false);
            this.rarityPanel.ResumeLayout(false);
            this.cardVariationPanel.ResumeLayout(false);
            this.typesPanel.ResumeLayout(false);
            this.editionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox colourBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox manaCostBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox editionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rarityBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox locationReservedBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox locationCurrentBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Button incrementButton;
        private System.Windows.Forms.Button decrementButton;
        private System.Windows.Forms.TextBox stdEffectsBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button editCancelButton;
        private System.Windows.Forms.Button duplicateButton;
        private System.Windows.Forms.Button createAcceptButton;
        private System.Windows.Forms.TextBox cardVariationBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Panel colourPanel;
        private System.Windows.Forms.ListBox colourListbox;
        private System.Windows.Forms.ListBox languageListbox;
        private System.Windows.Forms.Panel languagePanel;
        private System.Windows.Forms.ListBox rarityListbox;
        private System.Windows.Forms.Panel rarityPanel;
        private System.Windows.Forms.TextBox languageBox;
        private System.Windows.Forms.ListBox cardVariationListbox;
        private System.Windows.Forms.Panel cardVariationPanel;
        private System.Windows.Forms.ListBox typesListbox;
        private System.Windows.Forms.Panel typesPanel;
        private System.Windows.Forms.ListBox editionListbox;
        private System.Windows.Forms.Panel editionPanel;
    }
}
