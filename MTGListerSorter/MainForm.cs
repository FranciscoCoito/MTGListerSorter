using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTGListerSorter
{
    public partial class MainForm : Form
    {
        enum EOverPanelViewMode
        {
            Hidden,
            MultiDropDownOption,
            CreateNewElement,
            ChangeLocation,
        }

        private const int LISTBOXITEMHEIGHT = 17;
        private const int LISTBOXITEMMAXELEMENTS = 4;

        public MainForm()
        {
            InitializeComponent();

            m_currentRow = uint.MaxValue;

            //InitList();
            InitFormPanel();

            HideOverPanel();

            SubTypeStruct tryp = new SubTypeStruct();
            tryp.ClearSubType();
            tryp.id = StoringSubTypeElement.getEntryMaxID() + 1;
            tryp.name = "ME";
            tryp.typeBelongsTo.Add(EType.Creature);
            StoringSubTypeElement.addToList(tryp);

            tryp.id = StoringSubTypeElement.getEntryMaxID() + 1;
            tryp.name = "glue";
            tryp.typeBelongsTo.Add(EType.Artifact);
            tryp.typeBelongsTo.Add(EType.Enchantment);
            StoringSubTypeElement.addToList(tryp);

            tryp.id = StoringSubTypeElement.getEntryMaxID() + 1;
            tryp.name = "Head";
            tryp.typeBelongsTo.Add(EType.Artifact);
            StoringSubTypeElement.addToList(tryp);

            tryp.id = StoringSubTypeElement.getEntryMaxID() + 1;
            tryp.name = "monkey";
            tryp.typeBelongsTo.Add(EType.Creature);
            StoringSubTypeElement.addToList(tryp);

            tryp.id = StoringSubTypeElement.getEntryMaxID() + 1;
            tryp.name = "golem";
            tryp.typeBelongsTo.Add(EType.Creature);
            tryp.typeBelongsTo.Add(EType.Artifact);
            StoringSubTypeElement.addToList(tryp);


            EditionStruct ed = new EditionStruct();
            ed.id = 1;
            ed.month = 12;
            ed.year = 2012;
            ed.representation = "MEr";
            ed.name = "Merde";
            StoringEditionElement.addToList(ed);
        }

        public void InitList()
        {
            int y = 0;
            for(int i=0;i<30;i++)
            {
                MTGListElement mtgListElement = new MTGListElement();
                if (i % 2 == 0)
                {
                    mtgListElement.setBackColour(Color.Cyan);
                }
                mtgListElement.Location = new System.Drawing.Point(1, -1 + y);
                mtgListElement.Name = mtgListElement.Name + 1;
                mtgListElement.TabIndex = i;

                CardEntryStruct entry = new CardEntryStruct();
                entry.ClearCardEntry();
                entry.id = (uint)i + 1;
                entry.name = "Some " + i;
                mtgListElement.setEntryElement((uint)i, entry);
                mtgListElement.clickDelegate = new MTGListElement.ReturnEnrtyDelegate(onClickFromList);

                listPanel.Controls.Add(mtgListElement);

                y += mtgListElement.Height;
            }
        }

        private void AddEntryToListPanel(int index, CardEntryStruct entry)
        {
            MTGListElement mtgListElement = new MTGListElement();
            int y = index * mtgListElement.Height;

            mtgListElement.Location = new System.Drawing.Point(1, -1 + y);
            mtgListElement.Name = mtgListElement.Name + "1";
            mtgListElement.TabIndex = index;

            mtgListElement.setEntryElement((uint)index, entry);
            mtgListElement.clickDelegate = new MTGListElement.ReturnEnrtyDelegate(onClickFromList);

            listPanel.Controls.Add(mtgListElement);
        }

        private void ReplaceEntryOnListPanel(uint index, CardEntryStruct entry)
        {
            foreach (MTGListElement control in listPanel.Controls)
            {
                if (control.getRow() == index)
                {
                    control.setEntryElement(index, entry);
                }
            }
        }

        private void InitFormPanel()
        {
            m_mtgElementForm = new MTGElementForm();
            m_mtgElementForm.clickAcceptOrCancelDelegate = new MTGElementForm.CompleteEnrtyChangeDelegate(onClickCompleteEntryChange);
            m_mtgElementForm.clickChangeEntryDelegate = new MTGElementForm.InitiateEntryChangeDelegate(onClickInitiateEntryChange);
            fillFormPanel.Controls.Add(m_mtgElementForm);
        }

        private void EnableAll(bool enable)
        {
            foreach (Control control in listPanel.Controls)
            {
                dynamic rowElement = control as MTGListElement;
            }
        }

        private void ClearOverPanel()
        {
            textLabel.Text = "Nothing";

            textBox.Clear();
            textBox.ReadOnly = true;

            numberPlacingCheckbox.Checked = false;
            numberPlacingCheckbox.Visible = false;

            reorderCheckBox.Checked = false;
            reorderCheckBox.Visible = false;

            overOptionsListbox.Items.Clear();
            overOptionsPanel.Hide();
        }

        private void HideOverPanel()
        {
            overPanel.Hide();
            ClearOverPanel();
            m_currentOverPanelMode = EOverPanelViewMode.Hidden;
        }

        private void RevealSubtypesDropDownOverPanel(string message, ComplexTypeStruct typeStruct)
        {
            ClearOverPanel();

            m_currentOverPanelMode = EOverPanelViewMode.MultiDropDownOption;

            textLabel.Text = message;

            SubTypeStruct[] allSubTypes = StoringSubTypeElement.getEntryList();

            SubTypeStruct[] allCatSubTypes = Array.FindAll(allSubTypes, x => x.typeBelongsTo.Contains(typeStruct.type));

            foreach(dynamic catSub in allCatSubTypes)
            {
                overOptionsListbox.Items.Add(catSub.name);
            }
            overOptionsListbox.Height = LISTBOXITEMHEIGHT * (overOptionsListbox.Items.Count <= LISTBOXITEMMAXELEMENTS ? overOptionsListbox.Items.Count : LISTBOXITEMMAXELEMENTS);
            overOptionsListbox.EndUpdate();
            overOptionsListbox.SelectionMode = SelectionMode.MultiSimple;

            foreach (dynamic subTypeID in typeStruct.subTypes)
            {
                dynamic subtype = Array.Find(allCatSubTypes, x => x.id == subTypeID);
                dynamic indexSubType = overOptionsListbox.FindString(subtype.name);
                overOptionsListbox.SetSelected(indexSubType, true);
            }
            overPanel.Show();
        }

        void onClickFromList(uint row, CardEntryStruct entry)
        {
            if (entry.id <= 0 && row < uint.MaxValue) return;
            m_currentRow = ChangeBackgroundColourOnList(row);
            m_mtgElementForm.setCardEntry(entry);
        }

        private uint ChangeBackgroundColourOnList(uint row)
        {
            uint retRow = uint.MaxValue;
            foreach (dynamic control in listPanel.Controls)
            {
                dynamic rowElement = control as MTGListElement;

                Color backColour = Color.White;
                if (rowElement.getRow() == row)
                {
                    backColour = Color.Cyan;
                    retRow = row;
                }
                rowElement.setBackColour(backColour);
            }

            return retRow;
        }

        void onClickCompleteEntryChange(CardEntryStruct entry)
        {
            if (entry.id > 0)
            {
                int entryIndex = 0;
                if (entry.id == uint.MaxValue)  //  Added a new Element
                {
                    entry.id = StoringCardEntryElement.getEntryMaxID() + 1;
                    StoringCardEntryElement.addToList(entry);

                    entryIndex = listPanel.Controls.Count;
                    AddEntryToListPanel(entryIndex, entry);
                }
                else  //  Replace a Element
                {
                    entryIndex = (int)m_currentRow;
                    StoringCardEntryElement.replaceFromList(entry);
                    ReplaceEntryOnListPanel((uint)entryIndex, entry);
                }
                onClickFromList((uint)entryIndex, entry);
            }
        }

        void onClickInitiateEntryChange(bool selectedEntry)
        {
            if (!selectedEntry)
            {
                m_currentRow = uint.MaxValue;
                ChangeBackgroundColourOnList(m_currentRow);
            }
        }


        MTGElementForm          m_mtgElementForm;
        uint                    m_currentRow;
        EOverPanelViewMode      m_currentOverPanelMode;
    }
}
