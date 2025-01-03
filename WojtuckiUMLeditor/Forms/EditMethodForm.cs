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

namespace WojtuckiUMLeditor.Forms
{
    public partial class EditMethodForm : Form
    {
        private UMLClass selectedClass;
        private Method? selectedMethod;

        public EditMethodForm(UMLClass umlClass)
        {
            InitializeComponent();
            selectedClass = umlClass;

            listBoxMethods.DataSource = null;
            listBoxMethods.DataSource = selectedClass.Methods;
            listBoxMethods.DisplayMember = "Name";

            listBoxMethods.SelectedIndexChanged += listBoxMethods_SelectedIndexChanged;

            if (selectedClass.Methods.Count > 0)
            {
                listBoxMethods.SelectedIndex = 0;
                selectedMethod = selectedClass.Methods[0];
                UpdateTextBoxes();
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (selectedMethod != null)
            {
                selectedMethod.Name = textBoxName.Text;
                selectedMethod.ReturnType = textBoxReturnType.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Musíte vybrat metodu k úpravě.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBoxMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMethods.SelectedItem is Method method)
            {
                selectedMethod = method;
                UpdateTextBoxes();
            }
        }


        private void UpdateTextBoxes()
        {
            if (selectedMethod != null)
            {
                textBoxName.Text = selectedMethod.Name;
                textBoxReturnType.Text = selectedMethod.ReturnType;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedMethod != null)
            {
                var result = MessageBox.Show(
                    $"Opravdu chcete smazat metodu \"{selectedMethod.Name}\"?",
                    "Potvrzení mazání",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    selectedClass.Methods.Remove(selectedMethod);
                    
                    listBoxMethods.DataSource = null;
                    listBoxMethods.DataSource = selectedClass.Methods;
                    listBoxMethods.DisplayMember = "Name";
                    
                    selectedMethod = null;
                    textBoxName.Text = string.Empty;
                    textBoxReturnType.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Musíte vybrat metodu k odstranění.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

