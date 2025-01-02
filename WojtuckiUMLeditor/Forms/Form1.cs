﻿using WojtuckiUMLeditor.Entities;
using WojtuckiUMLeditor.Entities.WojtuckiUMLeditor.Entities;
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
        private List<UMLRelation> Relations = new List<UMLRelation>();
        private UMLClass? selectedClass2 = null;



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


                if (selectedClass == umlClass || umlClass == selectedClass2)
                {
                    g.DrawRectangle(Pens.Red, umlClass.Bounds);
                    g.DrawRectangle(Pens.Red, attributeBounds);
                    g.DrawRectangle(Pens.Red, methodBounds);                    
                }                

                foreach (var relation in Relations)
                {
                    relation.DrawRelationship(g);
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
            if (!IsClickOnClass(e.Location))
            {
                selectedClass = null;
                selectedClass2 = null;
            }
            else
            {
                // Logika pro výběr tříd
                if (selectedClass == null)
                {
                    foreach (var umlClass in Classes)
                    {
                        if (umlClass.Bounds.Contains(e.Location))
                        {
                            selectedClass = umlClass;
                            lastMousePosition = e.Location;
                            break;
                        }
                    }
                }
                else if (selectedClass2 == null)
                {
                    foreach (var umlClass in Classes)
                    {
                        if (umlClass.Bounds.Contains(e.Location) && umlClass != selectedClass)
                        {
                            selectedClass2 = umlClass;
                            break;
                        }
                    }
                }
                pictureBoxCanvas.Invalidate();
            }
        }

        private bool IsClickOnClass(Point location)
        {
            foreach (var umlClass in Classes)
            {
                if (umlClass.Bounds.Contains(location))
                {
                    return true;
                }
            }
            return false;
        }

        private void pictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedClass != null)
            {
                // Přesouvání první třídy
                if (e.Button == MouseButtons.Left && !isResizing)
                {
                    int dx = e.X - lastMousePosition.X;
                    int dy = e.Y - lastMousePosition.Y;

                    selectedClass.Move(dx, dy);  // Metoda pro přesouvání třídy
                    lastMousePosition = e.Location;
                }
            }

            if (selectedClass2 != null)
            {
                // Přesouvání druhé třídy
                if (e.Button == MouseButtons.Left && !isResizing)
                {
                    int dx = e.X - lastMousePosition.X;
                    int dy = e.Y - lastMousePosition.Y;

                    selectedClass2.Move(dx, dy);  // Metoda pro přesouvání druhé třídy
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
                    var relationsToRemove = Relations.Where(r => r.FromClass == selectedClass || r.ToClass == selectedClass).ToList();

                    foreach (var relation in relationsToRemove)
                    {
                        Relations.Remove(relation);
                    }

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

        private void buttonCreateRelation_Click(object sender, EventArgs e)
        {
            if (selectedClass != null && selectedClass2 != null)
            {
                using (var relationDialog = new RelationForm())
                {
                    if (relationDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Získání vybrané multiplicity (1 nebo *)
                        string multiplicityEnd = relationDialog.MultiplicityEnd;   // například "*"

                        // Vytvoření nového vztahu s vybraným typem a multiplicitou
                        UMLRelation relation = new UMLRelation(selectedClass, selectedClass2, relationDialog.SelectedRelationType, multiplicityEnd);
                        Relations.Add(relation);

                        // Reset výběru tříd po přidání vztahu
                        selectedClass = null;
                        selectedClass2 = null;

                        pictureBoxCanvas.Invalidate();
                    }
                }
            }
            else
            {
                MessageBox.Show("Musíte vybrat dvě třídy pro vytvoření vztahu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

