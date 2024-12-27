namespace WojtuckiUMLeditor
{
    public partial class Form1 : Form
    {

        private List<Rectangle> Classes = new List<Rectangle>();

        private int defaultX;
        private int defaultY;
        private int defaultWidth;
        private int defaultHeight;

        private Rectangle? selectedClass = null;
        private Point lastMousePosition;


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var rect in Classes)
            {

                g.FillRectangle(Brushes.LightBlue, rect);
                g.DrawRectangle(Pens.Black, rect);

                g.DrawString("ClassName", new Font("Arial", 12), Brushes.Black, rect.X + 5, rect.Y + 5);
            }
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            defaultX = 50;
            defaultY = 50;
            defaultWidth = 100;
            defaultHeight = 50;

            Classes.Add(new Rectangle(defaultX, defaultY, defaultWidth, defaultHeight));

            pictureBoxCanvas.Invalidate();
        }

        private void pictureBoxCanvas_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBoxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var rect in Classes)
            {
                if (rect.Contains(e.Location))
                {
                    selectedClass = rect;
                    lastMousePosition = e.Location;
                    break;
                }
            }
        }

        private void pictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedClass != null && e.Button == MouseButtons.Left) 
            {
                int dx = e.X - lastMousePosition.X;
                int dy = e.Y - lastMousePosition.Y; 

                
                var updatedRect = new Rectangle(
                    selectedClass.Value.X + dx,
                    selectedClass.Value.Y + dy,
                    selectedClass.Value.Width,
                    selectedClass.Value.Height
                );

                Classes.Remove(selectedClass.Value); 
                Classes.Add(updatedRect);           
                selectedClass = updatedRect;        

                lastMousePosition = e.Location;     
                pictureBoxCanvas.Invalidate();      
            }
        }

        private void pictureBoxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            selectedClass = null;
        }
    }
}
