using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojtuckiUMLeditor
{
    public class UMLClass
    {
        public Rectangle Bounds { get; set; } 
        public string Name { get; set; } 
        public List<Attribute> Attributes { get; set; }

        public UMLClass(Rectangle bounds, string name)
        {
            Bounds = bounds;
            Name = name;
            Attributes = new List<Attribute>();
        }

        public void AddAttribute(string name, string dataType) => Attributes.Add(new Attribute(name, dataType));
    }
}
