using WojtuckiUMLeditor.Entities;
using WojtuckiUMLeditor.Forms;

namespace WojtuckiUMLeditor
{

    public partial class Form1 : Form
    {
        private List<UMLClass> Classes = new List<UMLClass>();
        private UMLClass? selectedClass = null;
        private Point lastMousePosition;
        private bool isResizing = false;
        private Point resizeStartPoint;



        public Form1()
        {
            InitializeComponent();
        }

        public void InvalidateCanvas()
        {
            pictureBoxCanvas.Invalidate();
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
                int lineY2 = umlClass.Bounds.Y + lineY + 20;

                int attributePadding = 5;
                int attributeHeight = umlClass.Attributes.Count * 15 + attributePadding * 2;

                int methodPadding = 5;
                int methodHeight = umlClass.Methods.Count * 15 + methodPadding * 2;

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

                int methodYOffset = umlClass.GetMethodsYOffset();
                Rectangle methodBounds = new Rectangle(umlClass.Bounds.X, methodYOffset, umlClass.Bounds.Width, umlClass.GetMethodsAreaHeight());
                g.FillRectangle(Brushes.White, methodBounds);
                g.DrawRectangle(Pens.Black, methodBounds);

                foreach (var method in umlClass.Methods)
                {
                    g.DrawString($"{method.ReturnType} {method.Name}()", new Font("Arial", 10), Brushes.Black, umlClass.Bounds.X + 5, methodYOffset);
                    methodYOffset += 15;
                }


                if (selectedClass == umlClass)
                {
                    g.DrawRectangle(Pens.Red, umlClass.Bounds);
                    g.DrawRectangle(Pens.Red, attributeBounds);
                    g.DrawRectangle(Pens.Red, methodBounds);
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
            isResizing = false;

            foreach (var umlClass in Classes)
            {
                if (umlClass.Bounds.Contains(e.Location))
                {
                    selectedClass = umlClass;
                    lastMousePosition = e.Location;

                    if (umlClass.IsMouseOverResizeHandle(e.Location))
                    {
                        isResizing = true;
                        resizeStartPoint = e.Location;
                    }
                    break;
                }
            }
        }

        private void pictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedClass != null)
            {
                if (isResizing)
                {
                    int dx = e.X - resizeStartPoint.X;
                    int dy = e.Y - resizeStartPoint.Y;

                    selectedClass.Resize(selectedClass.Bounds.Width + dx, selectedClass.Bounds.Height + dy);


                    int newHeight = selectedClass.GetAttributesAreaHeight();
                    if (newHeight > selectedClass.Bounds.Height)
                    {
                        selectedClass.Resize(selectedClass.Bounds.Width, newHeight);
                    }

                    resizeStartPoint = e.Location;
                }
                else if (e.Button == MouseButtons.Left)
                {
                    int dx = e.X - lastMousePosition.X;
                    int dy = e.Y - lastMousePosition.Y;
                    selectedClass.Move(dx, dy);
                    lastMousePosition = e.Location;
                }
            }

            pictureBoxCanvas.Invalidate();
        }

        private void pictureBoxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isResizing = false;
        }


        private void buttonDeleteClass_Click(object sender, EventArgs e)
        {
            if (selectedClass != null)
            {
                var result = MessageBox.Show($"Are you sure you want to delete this class {selectedClass.Name}?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
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

        private void buttonEditClass_Click(object sender, EventArgs e)
        {
            if (selectedClass != null)
            {
                var classEditorForm = new ClassEditorForm(selectedClass);
                classEditorForm.Owner = this;
                classEditorForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vyberte třídu pro úpravu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAddMethod_Click(object sender, EventArgs e)
        {
            if (selectedClass != null)
            {
                using (var dialog = new AddMethodForm())
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string methodName = dialog.Name;
                        string returnType = dialog.ReturnType;
                        selectedClass.Methods.Add(new Method(methodName, returnType));
                        pictureBoxCanvas.Invalidate();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vyberte třídu, do které chcete přidat metodu.", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonExportToPNG_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Save UML Diagram";
                saveFileDialog.FileName = "UMLDiagram.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrWhiteSpace(saveFileDialog.FileName))
                    {
                        SaveToPNG(saveFileDialog.FileName);
                    }
                }
            }            
        }

        private void SaveToPNG(string filePath)
        {
            Bitmap bitmap = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
            pictureBoxCanvas.DrawToBitmap(bitmap, new Rectangle(0, 0, pictureBoxCanvas.Width, pictureBoxCanvas.Height));
            bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("UML diagram byl úspěšně exportován do PNG!", "Export dokončen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

