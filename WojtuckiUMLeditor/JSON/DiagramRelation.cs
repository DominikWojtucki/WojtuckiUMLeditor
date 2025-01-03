using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WojtuckiUMLeditor.Entities;

namespace WojtuckiUMLeditor.JSON
{
    public class DiagramRelation
    {
        public int FromClassIndex { get; set; }
        public int ToClassIndex { get; set; }
        public RelationType Type { get; set; }
        public string Multiplicity { get; set; }
    }
}
