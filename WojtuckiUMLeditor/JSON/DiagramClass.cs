using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojtuckiUMLeditor.JSON
{
    public class DiagramData
    {
        public List<DiagramClass> Classes { get; set; }
        public List<DiagramRelation> Relations { get; set; }
    }
}
