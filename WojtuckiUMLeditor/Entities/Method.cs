using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojtuckiUMLeditor.Entities
{
    public class Method
    {
        public string Name { get; set; }
        public string ReturnType { get; set; }

        public Method(string name, string returnType)
        {
            Name = name;
            ReturnType = returnType;
        }
    }

    
}
