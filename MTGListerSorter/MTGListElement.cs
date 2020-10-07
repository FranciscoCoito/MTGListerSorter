using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace MTGListerSorter
{
    public partial class MTGListElement : UserControl
    {
        public MTGListElement()
        {
            InitializeComponent();

            m_cardEntry = new CardEntryStruct();

            setEnable(true);

            ClearElement();
            setOnClickEvent();
        }

        public void setEntryElement(uint row, CardEntryStruct entry)
        {
            m_cardEntry.copy(entry);
            m_row = row;
            UpdateElement();
        }

        public void ClearElement()
        {
            m_cardEntry.ClearCardEntry();
            UpdateElement();
        }

        public void UpdateElement()
        {
            nameBox.Text = m_cardEntry.printName();
            colourBox.Text = m_cardEntry.printColourSet();
            manaCostBox.Text = m_cardEntry.printManaCost();
            editionBox.Text = m_cardEntry.printEditionName(StoringEditionElement.getEntryList().ToList());
            rarityBox.Text = m_cardEntry.printRarity();
            typeBox.Text = m_cardEntry.printTypes(StoringSubTypeElement.getEntryList().ToList());
            variationBox.Text = m_cardEntry.printCardVariation();
            languageBox.Text = m_cardEntry.printLanguage();
            numberBox.Text = m_cardEntry.printNumberOfCards();
            locationReservedBox.Text = m_cardEntry.printReservedLocation(StoringLocationElement.getEntryList().ToList());
            locationCurrentBox.Text = m_cardEntry.printCurrentLocation(StoringLocationElement.getEntryList().ToList());
            valueBox.Text = m_cardEntry.printValue();
            stdEffectsBox.Text = m_cardEntry.printStdEffects(StoringStandardEffectElement.getEntryList().ToList());
        }

        public void setEnable(bool enable)
        {
            nameBox.ReadOnly= enable;
            colourBox.ReadOnly = enable;
            manaCostBox.ReadOnly = enable;
            editionBox.ReadOnly = enable;
            rarityBox.ReadOnly = enable;
            typeBox.ReadOnly = enable;
            variationBox.ReadOnly = enable;
            languageBox.ReadOnly = enable;
            numberBox.ReadOnly = enable;
            locationReservedBox.ReadOnly = enable;
            locationCurrentBox.ReadOnly = enable;
            valueBox.ReadOnly = enable;
            stdEffectsBox.ReadOnly = enable;
        }
        public void setOnClickEvent()
        {
            nameBox.Click += new EventHandler(onClick);
            colourBox.Click += new EventHandler(onClick);
            manaCostBox.Click += new EventHandler(onClick);
            editionBox.Click += new EventHandler(onClick);
            rarityBox.Click += new EventHandler(onClick);
            typeBox.Click += new EventHandler(onClick);
            variationBox.Click += new EventHandler(onClick);
            languageBox.Click += new EventHandler(onClick);
            numberBox.Click += new EventHandler(onClick);
            locationReservedBox.Click += new EventHandler(onClick);
            locationCurrentBox.Click += new EventHandler(onClick);
            valueBox.Click += new EventHandler(onClick);
            stdEffectsBox.Click += new EventHandler(onClick);
        }

        public void setBackColour(Color colour)
        {
            BackColor = colour;

            nameBox.BackColor = colour;
            colourBox.BackColor = colour;
            manaCostBox.BackColor = colour;
            editionBox.BackColor = colour;
            rarityBox.BackColor = colour;
            typeBox.BackColor = colour;
            variationBox.BackColor = colour;
            languageBox.BackColor = colour;
            numberBox.BackColor = colour;
            locationReservedBox.BackColor = colour;
            locationCurrentBox.BackColor = colour;
            valueBox.BackColor = colour;
            stdEffectsBox.BackColor = colour;
        }

        private void onClick(object sender, EventArgs e)
        {
            if (clickDelegate != null) { clickDelegate(m_row, m_cardEntry); }
        }

        public uint getRow() { return m_row; }

        public delegate void ReturnEnrtyDelegate(uint row, CardEntryStruct entry);

        public ReturnEnrtyDelegate clickDelegate;
        uint m_row;
        CardEntryStruct m_cardEntry;
    }
}
