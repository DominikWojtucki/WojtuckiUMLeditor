using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojtuckiUMLeditor.Entities
{
    public class Attribute
    {
        public string Name { get; set; }
        public string DataType { get; set; }

        public Attribute(string name, string dataType)
        {
            Name = name;
            DataType = dataType;
        }

        public override string ToString()
        {
            return $"{Name}: {DataType}";
        }
    }
}
