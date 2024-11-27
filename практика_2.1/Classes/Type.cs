using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика_2._1.Classes
{
    public class Type
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public Type(int id, string typeName)
        {
            Id = id;
            TypeName = typeName;
        }

    }
}
