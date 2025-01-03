using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojtuckiUMLeditor.JSON
{
    public class DiagramClass
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public List<DiagramAttributes> Attributes { get; set; }
        public List<DiagramMethods> Methods { get; set; }
    }
}
