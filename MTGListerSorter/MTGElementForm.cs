using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Net.Http.Headers;

namespace MTGListerSorter
{
    public partial class MTGElementForm : UserControl
    {
        private enum EDropDownTextListPanel
        {
            Undefined,
            Colour,
            Edition,
            Types,
            Rarity,
            CardVariation,
            ReservedLocation,
            CurrentLocation,
            Language,
            StdEffects,
        }
        public enum EPopUpSourceCalled
        {
            Type,
            Edition,
            Location,
        }

        private const int LISTBOXITEMHEIGHT = 17;
        private const int LISTBOXITEMMAXELEMENTS = 7;
        private const string NEWELEMENTTOADD = "new...";


        public MTGElementForm()
        {
            InitializeComponent();

            SetFillableMode(false);
            ClearForm();

            #region Colour Panel/List
            foreach (dynamic col in Enum.GetValues(typeof(EColour)))
            {
                if (col != EColour.INVALID)
                {
                    colourListbox.Items.Add(col);
                }
            }
            colourPanel.Height = LISTBOXITEMHEIGHT * (colourListbox.Items.Count <= LISTBOXITEMMAXELEMENTS ? colourListbox.Items.Count : LISTBOXITEMMAXELEMENTS);
            colourListbox.EndUpdate();
            colourListbox.SelectionMode = SelectionMode.MultiSimple;
            #endregion

            #region Language Panel/List
            foreach (dynamic lan in Enum.GetValues(typeof(ELanguage)))
            {
                if (lan != ELanguage.Unknown)
                {
                    languageListbox.Items.Add(lan);
                }
            }
            languagePanel.Height = LISTBOXITEMHEIGHT * (languageListbox.Items.Count <= LISTBOXITEMMAXELEMENTS ? languageListbox.Items.Count : LISTBOXITEMMAXELEMENTS);
            languageListbox.EndUpdate();
            languageListbox.SelectionMode = SelectionMode.One;
            #endregion

            #region Rarity Panel/List
            rarityListbox.Items.AddRange(Enum.GetNames(typeof(ERarity)));
            rarityPanel.Height = LISTBOXITEMHEIGHT * (rarityListbox.Items.Count <= LISTBOXITEMMAXELEMENTS ? rarityListbox.Items.Count : LISTBOXITEMMAXELEMENTS);
            rarityListbox.EndUpdate();
            rarityListbox.SelectionMode = SelectionMode.One;
            #endregion

            #region Card Variation Panel/List
            cardVariationListbox.Items.AddRange(Enum.GetNames(typeof(EVariation)));
            cardVariationPanel.Height = LISTBOXITEMHEIGHT * (cardVariationListbox.Items.Count <= LISTBOXITEMMAXELEMENTS ? cardVariationListbox.Items.Count : LISTBOXITEMMAXELEMENTS);
            cardVariationListbox.EndUpdate();
            cardVariationListbox.SelectionMode = SelectionMode.MultiSimple;
            #endregion
        }

        private void SetFillableMode(bool enable)
        {
            m_fillMode = enable;
            EnableForm(enable);

            if (enable)
            {
                createAcceptButton.Text = "Accept Entry";
                editCancelButton.Text = "Cancel Entry";
            }
            else
            {
                createAcceptButton.Text = "Create New";
                editCancelButton.Text = "Edit Selected";
            }

            duplicateButton.Visible = !enable;
            sortButton.Visible = !enable;
        }
        private void ClearForm()
        {
            m_cardEntry.ClearCardEntry();
            UpdateForm();
            HidePanels();
        }
        public void setCardEntry(CardEntryStruct entry)
        {
            SetFillableMode(false);
            m_cardEntry.copy(entry);
            UpdateForm();
        }

        #region Affect TextBoxes
        private void UpdateForm()
        {
            nameBox.Text = m_cardEntry.printName();
            colourBox.Text = m_cardEntry.printColourSet();
            manaCostBox.Text = m_cardEntry.printManaCost();

            typeBox.Text = m_cardEntry.printTypes(StoringSubTypeElement.getEntryList().ToList());
            editionBox.Text = m_cardEntry.printEditionName(StoringEditionElement.getEntryList().ToList());
            rarityBox.Text = m_cardEntry.printRarity();

            cardVariationBox.Text = m_cardEntry.printCardVariation();

            locationReservedBox.Text = m_cardEntry.printReservedLocation(StoringLocationElement.getEntryList().ToList());
            locationCurrentBox.Text = m_cardEntry.printCurrentLocation(StoringLocationElement.getEntryList().ToList());
            languageBox.Text = m_cardEntry.printLanguage();
            valueBox.Text = m_cardEntry.value.ToString();

            stdEffectsBox.Text = m_cardEntry.printStdEffects(StoringStandardEffectElement.getEntryList().ToList());

            numberBox.Text = m_cardEntry.numberOfCards.ToString();
        }

        public void EnableForm(bool enable)
        {
            nameBox.Enabled = enable;
            colourBox.Enabled = enable;
            manaCostBox.Enabled = enable;

            typeBox.Enabled = enable;
            editionBox.Enabled = enable;
            rarityBox.Enabled = enable;

            cardVariationBox.Enabled = enable;

            locationReservedBox.Enabled = enable;
            locationCurrentBox.Enabled = enable;
            languageBox.Enabled = enable;
            valueBox.Enabled = enable;

            stdEffectsBox.Enabled = enable;

            numberBox.Enabled = enable;
        }
        #endregion

        #region Affect Additional Panels
        private void HidePanels()
        {
            colourPanel.Hide();
            colourListbox.ClearSelected();

            languagePanel.Hide();
            languageListbox.ClearSelected();

            rarityPanel.Hide();
            rarityListbox.ClearSelected();

            cardVariationPanel.Hide();
            cardVariationListbox.ClearSelected();

            typesPanel.Hide();
            typesListbox.ClearSelected();

            editionPanel.Hide();
            editionListbox.ClearSelected();

            m_currentActivePanel = EDropDownTextListPanel.Undefined;
        }

        private void RevealedPanel(EDropDownTextListPanel option)
        {
            switch (option)
            {
                case EDropDownTextListPanel.Colour:
                    #region Case Colour
                    colourPanel.Show();
                    colourPanel.Focus();
                    foreach (dynamic col in m_cardEntry.colourSet)
                    {
                        dynamic indexColour = colourListbox.FindString(ENumConverters.printEColour(col));
                        colourListbox.SetSelected(indexColour, true);
                    }
                    #endregion
                    break;

                case EDropDownTextListPanel.Language:
                    #region Case Language
                    languagePanel.Show();
                    languagePanel.Focus();
                    if (m_cardEntry.language != ELanguage.Unknown)
                    {
                        dynamic indexLanguage = languageListbox.FindString(m_cardEntry.printLanguage());
                        languageListbox.SetSelected(indexLanguage, true);
                    }
                    #endregion
                    break;

                case EDropDownTextListPanel.Rarity:
                    #region Rarity
                    rarityPanel.Show();
                    rarityPanel.Focus();
                    dynamic indexRarity = rarityListbox.FindString(m_cardEntry.printRarity());
                    rarityListbox.SetSelected(indexRarity, true);
                    #endregion
                    break;

                case EDropDownTextListPanel.CardVariation:
                    #region Case Card Variation
                    cardVariationPanel.Show();
                    cardVariationPanel.Focus();
                    foreach (dynamic cardVar in m_cardEntry.variation)
                    {
                        dynamic indexCardVariation = cardVariationListbox.FindString(ENumConverters.printEVariation(cardVar));
                        if (indexCardVariation >= 0)
                        {
                            cardVariationListbox.SetSelected(indexCardVariation, true);
                        }
                    }
                    #endregion
                    break;

                case EDropDownTextListPanel.Types:
                    #region Case Types
                    #region Types Panel/List
                    typesListbox.Items.Clear();
                    typesListbox.Items.AddRange(Enum.GetNames(typeof(EType)));
                    typesPanel.Height = LISTBOXITEMHEIGHT * (typesListbox.Items.Count <= LISTBOXITEMMAXELEMENTS ? typesListbox.Items.Count : LISTBOXITEMMAXELEMENTS);
                    typesListbox.EndUpdate();
                    typesListbox.SelectionMode = SelectionMode.MultiSimple;
                    #endregion

                    foreach(dynamic cardType in m_cardEntry.types)
                    {
                        dynamic indexType = typesListbox.FindString(ENumConverters.printEType(cardType.type));
                        typesListbox.Items.RemoveAt(indexType);
                        typesListbox.Items.Insert(indexType, cardType.printFullType(StoringSubTypeElement.getEntryList().ToList<SubTypeStruct>()));
                        typesListbox.SetSelected(indexType, true);
                    }
                    typesPanel.Show();
                    typesPanel.Focus();
                    #endregion
                    break;

                case EDropDownTextListPanel.Edition:
                    #region Case Edition
                    if (StoringEditionElement.getEntryList().Length > 0)
                    {
                        string repEditStr = "";
                        #region Edition Panel/List
                        editionListbox.Items.Clear();
                        editionListbox.SelectionMode = SelectionMode.One;
                        foreach (dynamic edit in StoringEditionElement.getEntryList())
                        {
                            if (edit.id == m_cardEntry.editionID)
                            {
                                repEditStr = edit.representation;
                            }
                            editionListbox.Items.Add(edit.representation);
                        }
                        editionListbox.Items.Add(NEWELEMENTTOADD);
                        editionPanel.Height = LISTBOXITEMHEIGHT * (editionListbox.Items.Count <= LISTBOXITEMMAXELEMENTS ? editionListbox.Items.Count : LISTBOXITEMMAXELEMENTS);
                        editionListbox.EndUpdate();
                        #endregion

                        if (repEditStr != "")
                        {
                            dynamic indexEdit = editionListbox.FindString(repEditStr);
                            editionListbox.SetSelected(indexEdit, true);
                        }

                        editionPanel.Show();
                        editionPanel.Focus();
                    }
                    else
                    {
                        if (clickCallPopUpDelegate != null)
                        {
                            clickCallPopUpDelegate(EPopUpSourceCalled.Type);
                        }
                    }
                    #endregion
                    break;

            }
            m_currentActivePanel = option;
        }
        #endregion

        #region Click Buttons Events
        private void createAcceptButton_Click(object sender, EventArgs e)
        {
            if(m_fillMode) // Accept Button
            {
                if (CheckIfAllowedToAccept())
                {
                    ConcludeEdition(m_cardEntry);
                }
            }
            else // Create Button
            {
                ClearForm();
                SetNewEntryForInput();
            }
        }

        private void editCancelButton_Click(object sender, EventArgs e)
        {
            if (m_fillMode) // Cancel Button
            {
                dynamic emptyEntry = new CardEntryStruct();
                emptyEntry.ClearCardEntry();

                ConcludeEdition(emptyEntry);
            }
            else // Edit Button
            {
                SetFillableMode(true);
                if (clickChangeEntryDelegate != null) { clickChangeEntryDelegate(true); }
            }
        }

        private void duplicateButton_Click(object sender, EventArgs e)
        {
            SetNewEntryForInput();
        }
        #endregion

        #region Auxiliary Function for Click Events
        private void SetNewEntryForInput()
        {
            SetFillableMode(true);
            m_cardEntry.id = uint.MaxValue;
            if (clickChangeEntryDelegate != null) { clickChangeEntryDelegate(false); }
        }

        private void ConcludeEdition(CardEntryStruct entry)
        {
            CardEntryStruct retEntry = new CardEntryStruct();
            retEntry.ClearCardEntry();
            retEntry.copy(entry);
            SetFillableMode(false);
            ClearForm();
            if (retEntry.numberOfCards == 0) ++retEntry.numberOfCards;
            if (clickAcceptOrCancelDelegate != null) { clickAcceptOrCancelDelegate(retEntry); }
        }

        private bool CheckIfAllowedToAccept()
        {
            return !(m_cardEntry.id == 0 || m_cardEntry.name == "" || m_cardEntry.language == ELanguage.Unknown /*|| m_cardEntry.types.Count == 0 || m_cardEntry.editionID == 0 || 
                     m_cardEntry.reservedLocationID == 0 || m_cardEntry.currentLocationIDs.Count == 0*/);
        }
        #endregion


        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            m_cardEntry.name = nameBox.Text;
        }

        #region Textbox Click - RevealPanels
        private void colourBox_Click(object sender, EventArgs e)
        {
            RevealedPanel(EDropDownTextListPanel.Colour);
        }

        private void languageBox_Click(object sender, EventArgs e)
        {
            RevealedPanel(EDropDownTextListPanel.Language);
        }

        private void rarityBox_Click(object sender, EventArgs e)
        {
            RevealedPanel(EDropDownTextListPanel.Rarity);
        }

        private void cardVariationBox_Click(object sender, EventArgs e)
        {
            RevealedPanel(EDropDownTextListPanel.CardVariation);
        }

        private void typeBox_Click(object sender, EventArgs e)
        {
            RevealedPanel(EDropDownTextListPanel.Types);
        }

        private void editionBox_Click(object sender, EventArgs e)
        {
            RevealedPanel(EDropDownTextListPanel.Edition);
        }
        #endregion

        #region on Panel events
        private void onLeavePanels(object sender, EventArgs e)
        {
            if (m_currentActivePanel != EDropDownTextListPanel.Undefined)
            {
                HidePanels();
            }
        }
        
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if(m_currentActivePanel!=EDropDownTextListPanel.Undefined)
            {
                HidePanels();
            }
        }

        private void onListboxClick(object sender, EventArgs e)
        {
            switch(m_currentActivePanel)
            {
                case EDropDownTextListPanel.Colour:
                    m_cardEntry.colourSet.Clear();
                    foreach (dynamic colour in colourListbox.SelectedItems)
                    {
                        m_cardEntry.colourSet.Add(colour);
                    }
                    colourBox.Text = m_cardEntry.printColourSet();
                    break;

                case EDropDownTextListPanel.Language:
                    m_cardEntry.language = (ELanguage)languageListbox.SelectedItem;
                    languageBox.Text = m_cardEntry.printLanguage();
                    HidePanels();
                    break;

                case EDropDownTextListPanel.Rarity:
                    m_cardEntry.rarity = ENumConverters.getERarityStr(rarityListbox.SelectedItem.ToString());
                    rarityBox.Text = m_cardEntry.printRarity();
                    HidePanels();
                    break;

                case EDropDownTextListPanel.CardVariation:
                    m_cardEntry.variation.Clear();
                    foreach (dynamic variation in cardVariationListbox.SelectedItems)
                    {
                        m_cardEntry.variation.Add(ENumConverters.getEVariationStr(variation));
                    }
                    cardVariationBox.Text = m_cardEntry.printCardVariation();
                    break;

                case EDropDownTextListPanel.Types:
                    m_cardEntry.types.Clear();
                    if (clickCallPopUpDelegate!= null)
                    {
                        clickCallPopUpDelegate(EPopUpSourceCalled.Type);
                    }
                    else
                    {
                        foreach (dynamic type in typesListbox.SelectedItems)
                        {
                            dynamic typeStruct = new ComplexTypeStruct();
                            typeStruct.ClearComplexType(ENumConverters.getETypeStr(type));
                            m_cardEntry.types.Add(typeStruct);
                        }
                    }
                    typeBox.Text = m_cardEntry.printTypes(StoringSubTypeElement.getEntryList().ToList());

                    break;

                case EDropDownTextListPanel.Edition:
                    getlist
                    m_cardEntry.editionID
                    break;
            }
        }
        #endregion

        public delegate void CompleteEnrtyChangeDelegate(CardEntryStruct entry);
        public delegate void InitiateEntryChangeDelegate(bool selectedEntry);
        public delegate void CallPopUpDelegate(EPopUpSourceCalled popUpOption);

        public CompleteEnrtyChangeDelegate clickAcceptOrCancelDelegate;
        public InitiateEntryChangeDelegate clickChangeEntryDelegate;
        public CallPopUpDelegate clickCallPopUpDelegate;
        bool m_fillMode;
        CardEntryStruct m_cardEntry;
        EDropDownTextListPanel m_currentActivePanel;
    }
}
