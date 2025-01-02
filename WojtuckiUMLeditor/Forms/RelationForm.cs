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
using WojtuckiUMLeditor.Entities.WojtuckiUMLeditor.Entities;

namespace WojtuckiUMLeditor.Forms
{
    public partial class RelationForm : Form
    {
        public RelationType SelectedRelationType { get; private set; }        
        public string MultiplicityEnd { get; set; }

        public RelationForm()
        {
            InitializeComponent();
            InitializeComboBoxForRelationType();
            InitializeComboBoxForMultiplicity();           
            MultiplicityEnd = "1";
        }

        private void InitializeComboBoxForRelationType()
        {            
            comboBoxRelationType.Items.AddRange(Enum.GetNames(typeof(RelationType)));
            comboBoxRelationType.SelectedIndex = 0; 
        }

        private void InitializeComboBoxForMultiplicity()
        {            
            comboBoxMultiplicity.Items.Add("1");
            comboBoxMultiplicity.Items.Add("*");
            comboBoxMultiplicity.SelectedIndex = 0; 
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MultiplicityEnd = comboBoxMultiplicity.SelectedItem.ToString();

            SelectedRelationType = (RelationType)Enum.Parse(typeof(RelationType), comboBoxRelationType.SelectedItem.ToString());
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
