using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojtuckiUMLeditor.Entities
{
    public class UMLClass
    {
        public Rectangle Bounds { get; set; }
        public string Name { get; set; }
        public List<Attribute> Attributes { get; set; }
        public List<Method> Methods { get; set; }

        private const int MinWidth = 50; 
        private const int MinHeight = 50; 
        private const int MaxWidth = 500; 
        private const int MaxHeight = 500;
        private const int AttributeHeight = 20;
        private const int MethodHeight = 20;

        public UMLClass(Rectangle bounds, string name)
        {
            Bounds = bounds;
            Name = name;
            Attributes = new List<Attribute>();
            Methods = new List<Method>();
        }

        public void AddAttribute(string name, string dataType) => Attributes.Add(new Attribute(name, dataType));

        public void Resize(int width, int height)
        {
            
            if (width < MinWidth)
                width = MinWidth;

            if (height < MinHeight)
                height = MinHeight;

            if (width > MaxWidth)
                width = MaxWidth;

            if (height > MaxHeight)
                height = MaxHeight;

            Bounds = new Rectangle(Bounds.X, Bounds.Y, width, height);
        }

        
        public void Move(int dx, int dy)
        {
            Bounds = new Rectangle(Bounds.X + dx, Bounds.Y + dy, Bounds.Width, Bounds.Height);
        }

        public int GetAttributesAreaHeight()
        {
            return Attributes.Count * AttributeHeight;
        }

        public int GetMethodsAreaHeight()
        {
            return Methods.Count * MethodHeight;
        }

        public int GetTotalHeight()
        {
            return GetAttributesAreaHeight() + GetMethodsAreaHeight();
        }
        
        public int GetMethodsYOffset()
        {
            return Bounds.Y + 65 + GetAttributesAreaHeight(); 
        }

        public bool IsMouseOverResizeHandle(Point mouseLocation)
        {
        int resizeAreaSize = 10; 
        
            return (mouseLocation.X >= Bounds.Right - resizeAreaSize && mouseLocation.X <= Bounds.Right &&
                    mouseLocation.Y >= Bounds.Bottom - resizeAreaSize && mouseLocation.Y <= Bounds.Bottom) ||
                    (mouseLocation.X <= Bounds.Left + resizeAreaSize && mouseLocation.X >= Bounds.Left &&
                    mouseLocation.Y <= Bounds.Bottom && mouseLocation.Y >= Bounds.Top + resizeAreaSize) ||
                    (mouseLocation.X >= Bounds.Left && mouseLocation.X <= Bounds.Left + resizeAreaSize &&
                    mouseLocation.Y >= Bounds.Top && mouseLocation.Y <= Bounds.Top + resizeAreaSize) ||
                    (mouseLocation.X >= Bounds.Right - resizeAreaSize && mouseLocation.X <= Bounds.Right &&
                    mouseLocation.Y <= Bounds.Top + resizeAreaSize && mouseLocation.Y >= Bounds.Top);
        }

        public Point Center()
        {
            return new Point(Bounds.X + Bounds.Width / 2, Bounds.Y + Bounds.Height / 2);
        }
    }
}
