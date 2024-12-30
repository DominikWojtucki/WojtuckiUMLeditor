using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WojtuckiUMLeditor.Entities;
using Attribute = WojtuckiUMLeditor.Entities.Attribute;

namespace WojtuckiUMLeditor
{
    public partial class EditAttributeForm : Form
    {
        private UMLClass selectedClass;
        private Attribute? selectedAttribute;

        public EditAttributeForm(UMLClass umlClass)
        {
            InitializeComponent();
            selectedClass = umlClass;

            listBoxAttributes.DataSource = null;
            listBoxAttributes.DataSource = selectedClass.Attributes;
            listBoxAttributes.DisplayMember = "Name";

            listBoxAttributes.SelectedIndexChanged += listBoxAttributes_SelectedIndexChanged;

            if (selectedClass.Attributes.Count > 0)
            {
                listBoxAttributes.SelectedIndex = 0;
                selectedAttribute = selectedClass.Attributes[0];
                UpdateTextBoxes();
            }
        }

        private void listBoxAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAttributes.SelectedItem is Attribute attribute)
            {
                selectedAttribute = attribute;
                UpdateTextBoxes();
            }
        }

        private void UpdateTextBoxes()
        {
            if (selectedAttribute != null)
            {
                textBoxAttributeName.Text = selectedAttribute.Name;
                textBoxAttributeDataType.Text = selectedAttribute.DataType;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (selectedAttribute != null)
            {
                selectedAttribute.Name = textBoxAttributeName.Text;
                selectedAttribute.DataType = textBoxAttributeDataType.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Musíte vybrat atribut k úpravě.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedAttribute != null)
            {
                var result = MessageBox.Show(
                    $"Opravdu chcete smazat atribut \"{selectedAttribute.Name}\"?",
                    "Potvrzení mazání",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    selectedClass.Attributes.Remove(selectedAttribute);

                    listBoxAttributes.DataSource = null;
                    listBoxAttributes.DataSource = selectedClass.Attributes;
                    listBoxAttributes.DisplayMember = "Name";

                    selectedAttribute = null;
                    textBoxAttributeName.Text = string.Empty;
                    textBoxAttributeDataType.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Musíte vybrat atribut k odstranění.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

