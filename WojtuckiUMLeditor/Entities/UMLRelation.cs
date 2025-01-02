using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojtuckiUMLeditor.Entities
{
    using System;
    using System.Drawing;

    namespace WojtuckiUMLeditor.Entities
    {
        public class UMLRelation
        {
            public UMLClass FromClass { get; }
            public UMLClass ToClass { get; }            
            public string Multiplicity { get; set; }
            public RelationType Type { get; set; }

            public UMLRelation(UMLClass fromClass, UMLClass toClass, RelationType type, string multiplicity)
            {
                FromClass = fromClass;
                ToClass = toClass;
                Type = type;
                Multiplicity = multiplicity;
            }


            public void DrawRelation(Graphics g)
            {
                if (FromClass == null || ToClass == null) return;

                Pen pen = new Pen(Color.Black);
                
                Point startPoint = GetEdgePoint(FromClass, ToClass);
                Point endPoint = GetEdgePoint(ToClass, FromClass);

                switch (Type)
                {
                    case RelationType.Association:
                        g.DrawLine(pen, startPoint, endPoint);
                        break;
                    case RelationType.Aggregation:
                        g.DrawLine(pen, startPoint, endPoint);
                        g.DrawPolygon(pen, GetDiamondShape(endPoint));
                        break;
                    case RelationType.Composition:
                        g.DrawLine(pen, startPoint, endPoint);
                        g.FillPolygon(Brushes.Black, GetDiamondShape(endPoint));
                        break;
                    case RelationType.Generalization:
                        g.DrawLine(pen, startPoint, endPoint);
                        g.FillPolygon(Brushes.Black, GetTriangleShape(endPoint));
                        break;
                }
                
                g.DrawString(Multiplicity, new Font("Arial", 8), Brushes.Black, FromClass.Bounds.X, FromClass.Bounds.Y);
                g.DrawString(Multiplicity, new Font("Arial", 8), Brushes.Black, ToClass.Bounds.X, ToClass.Bounds.Y);
            }

            private Point GetEdgePoint(UMLClass fromClass, UMLClass toClass)
            {
                
                int dx = toClass.Center().X - fromClass.Center().X;
                int dy = toClass.Center().Y - fromClass.Center().Y;
                
                double length = Math.Sqrt(dx * dx + dy * dy);
                double unitX = dx / length;
                double unitY = dy / length;
                
                int edgeX = (int)(fromClass.Center().X + fromClass.Bounds.Width / 2 * unitX);
                int edgeY = (int)(fromClass.Center().Y + fromClass.Bounds.Height / 2 * unitY);

                return new Point(edgeX, edgeY);
            }


            private Point[] GetDiamondShape(Point center)
            {
                return new Point[]
                {
                new Point(center.X, center.Y - 10),
                new Point(center.X + 10, center.Y),
                new Point(center.X, center.Y + 10),
                new Point(center.X - 10, center.Y)
                };
            }

            private Point[] GetTriangleShape(Point center)
            {
                return new Point[]
                {
                new Point(center.X, center.Y - 10),
                new Point(center.X + 10, center.Y + 10),
                new Point(center.X - 10, center.Y + 10)
                };
            }

            public void DrawRelationship(Graphics g)
            {
                
                Point startPoint = new Point(FromClass.Bounds.Right, FromClass.Bounds.Top + FromClass.Bounds.Height / 2);
                Point endPoint = new Point(ToClass.Bounds.Left, ToClass.Bounds.Top + ToClass.Bounds.Height / 2);
                
                g.DrawLine(Pens.Black, startPoint, endPoint);                
                
                g.DrawString(Multiplicity, new Font("Arial", 10), Brushes.Black, endPoint.X - 20, endPoint.Y - 5);
                
                switch (Type)
                {
                    case RelationType.Association:
                        DrawAssociation(g, startPoint, endPoint);
                        break;
                    case RelationType.Aggregation:
                        DrawAggregation(g, endPoint);
                        break;
                    case RelationType.Composition:
                        DrawComposition(g, endPoint);
                        break;
                    case RelationType.Generalization:
                        DrawGeneralization(g, endPoint);
                        break;
                }
            }
            
            private void DrawAssociation(Graphics g, Point startPoint, Point endPoint)
            {
                g.DrawLine(Pens.Black, startPoint, endPoint); // Čára
            }

            private void DrawAggregation(Graphics g, Point endPoint)
            {
                g.DrawPolygon(Pens.Black, GetDiamondShape(endPoint)); // Kosočtverec
            }

            private void DrawComposition(Graphics g, Point endPoint)
            {
                g.FillPolygon(Brushes.Black, GetDiamondShape(endPoint)); // Vyplněný kosočtverec
            }

            private void DrawGeneralization(Graphics g, Point endPoint)
            {
                g.FillPolygon(Brushes.Black, GetTriangleShape(endPoint)); // Trojúhelník
            }
        }
    }

        
        public enum RelationType
        {
            Association,
            Aggregation,
            Composition,
            Generalization
        }
}



