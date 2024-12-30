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

namespace WojtuckiUMLeditor
{
    public partial class ClassEditorForm : Form
    {

        private UMLClass selectedClass;

        public ClassEditorForm(UMLClass umlClass)
        {
            InitializeComponent();
            selectedClass = umlClass;
        }

        private void buttonEditClassName_Click(object sender, EventArgs e)
        {
            using (var editNameForm = new EditClassNameForm(selectedClass.Name))
            {
                if (editNameForm.ShowDialog() == DialogResult.OK)
                {
                    selectedClass.Name = editNameForm.NewClassName;
                    (Owner as Form1)?.InvalidateCanvas(); 
                }
            }
        }

        private void buttonEditAttribute_Click(object sender, EventArgs e)
        {
            if (selectedClass.Attributes.Count > 0)
            {
                using (var editAttributeForm = new EditAttributeForm(selectedClass))
                {
                    if (editAttributeForm.ShowDialog() == DialogResult.OK)
                    {
                        (Owner as Form1)?.InvalidateCanvas();
                    }
                }
            }
            else
            {
                MessageBox.Show("Třída nemá žádné atributy.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }                

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
