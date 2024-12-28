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
    public partial class AddAttributeForm : Form
    {
        public string AttributeName { get; set; }
        public string AttributeDataType { get; set; }

        public AddAttributeForm()
        {
            InitializeComponent();
        }

        private void buttonAttributeCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonAttributeOK_Click(object sender, EventArgs e)
        {
            AttributeName = textBoxAttributeName.Text;
            AttributeDataType = textBoxDataType.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
