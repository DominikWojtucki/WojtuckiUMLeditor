using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojtuckiUMLeditor
{
    public partial class EditClassNameForm : Form
    {
        public string NewClassName { get; private set; }

        public EditClassNameForm(string currentClassName)
        {
            InitializeComponent();
            textBoxClassName.Text = currentClassName;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            NewClassName = textBoxClassName.Text;
            if (string.IsNullOrEmpty(NewClassName))
            {
                MessageBox.Show("Název třídy nemůže být prázdný.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK; 
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
