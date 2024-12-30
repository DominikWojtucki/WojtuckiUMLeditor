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
    public partial class AddClassForm : Form
    {

        public string ClassName { get; private set; }

        public AddClassForm()
        {
            InitializeComponent();
        }

        private void buttonCancelClassName_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonOkClassName_Click(object sender, EventArgs e)
        {
            ClassName = textBoxClassName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
