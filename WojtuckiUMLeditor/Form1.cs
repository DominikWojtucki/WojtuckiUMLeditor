namespace WojtuckiUMLeditor
{
    public partial class Form1 : Form
    {
        private List<UMLClass> Classes = new List<UMLClass>();
        private UMLClass? selectedClass = null;
        private Point lastMousePosition;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            foreach (var umlClass in Classes)
            {
                
                g.FillRectangle(Brushes.LightBlue, umlClass.Bounds);
                g.DrawRectangle(Pens.Black, umlClass.Bounds);

                
                g.DrawString(umlClass.Name, new Font("Arial", 12), Brushes.Black, umlClass.Bounds, stringFormat);
                
                int lineY = umlClass.Bounds.Y + 50;               
                                
                int attributePadding = 5;  
                int attributeHeight = umlClass.Attributes.Count * 15 + attributePadding * 2; 
                
                Rectangle attributeBounds = new Rectangle(
                    umlClass.Bounds.X,
                    lineY + attributePadding, 
                    umlClass.Bounds.Width,
                    attributeHeight
                );

                
                g.FillRectangle(Brushes.White, attributeBounds);
                g.DrawRectangle(Pens.Black, attributeBounds);

                
                int yOffset = lineY + attributePadding + 5; 
                foreach (var attribute in umlClass.Attributes)
                {
                    g.DrawString($"{attribute.Name}: {attribute.DataType}", new Font("Arial", 10), Brushes.Black, umlClass.Bounds.X + 5, yOffset);
                    yOffset += 15; 
                }
               
                if (selectedClass == umlClass)
                {
                    g.DrawRectangle(Pens.Red, umlClass.Bounds);
                    g.DrawRectangle(Pens.Red, attributeBounds);
                }

                
            }
        }


        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            using (var dialog = new AddClassForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string className = dialog.ClassName;
                    Rectangle bounds = new Rectangle(50, 50, 100, 50);
                    Classes.Add(new UMLClass(bounds, className));
                    pictureBoxCanvas.Invalidate();
                }
            }
        }


        private void pictureBoxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            selectedClass = null;

            foreach (var umlClass in Classes)
            {
                if (umlClass.Bounds.Contains(e.Location))
                {
                    selectedClass = umlClass;
                    lastMousePosition = e.Location;
                    break;
                }
            }

            pictureBoxCanvas.Invalidate();
        }


        private void pictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedClass != null && e.Button == MouseButtons.Left)
            {
                int dx = e.X - lastMousePosition.X;
                int dy = e.Y - lastMousePosition.Y;

                selectedClass.Bounds = new Rectangle(
                    selectedClass.Bounds.X + dx,
                    selectedClass.Bounds.Y + dy,
                    selectedClass.Bounds.Width,
                    selectedClass.Bounds.Height
                );

                lastMousePosition = e.Location;
                pictureBoxCanvas.Invalidate();
            }
        }


        private void buttonDeleteClass_Click(object sender, EventArgs e)
        {



            if (selectedClass != null)
            {
                var result = MessageBox.Show("Are you sure you want to delete this class?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);                
                
                if(result == DialogResult.Yes) 
                {
                    Classes.Remove(selectedClass);
                    selectedClass = null;
                    pictureBoxCanvas.Invalidate();
                }              
            
            }
            else
            {
                MessageBox.Show("Vyberte třídu kliknutím na ni.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddAttribute_Click(object sender, EventArgs e)
        {
            if (selectedClass != null)
            {
                using (var dialog = new AddAttributeForm())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string attributeName = dialog.AttributeName;
                        string attributeDataType = dialog.AttributeDataType;
                        selectedClass.AddAttribute(attributeName, attributeDataType);
                        pictureBoxCanvas.Invalidate();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vyberte třídu, do které chcete přidat atribut.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

