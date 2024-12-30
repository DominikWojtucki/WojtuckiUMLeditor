using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WojtuckiUMLeditor.Forms
{
    public partial class AddMethodForm : Form
    {
        public string Name { get; set; }
        public string ReturnType { get; set; }


        public AddMethodForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Name = textBoxName.Text;
            ReturnType = textBoxReturnType.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
