﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WojtuckiUMLeditor.Entities;

namespace WojtuckiUMLeditor.JSON
{
    public class DiagramRelation
    {
        public string FromClass { get; set; }
        public string ToClass { get; set; }
        public string Type { get; set; }
        public string Multiplicity { get; set; }
    }
}
