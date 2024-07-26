using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLabelCustomization
{
    public class Model
    {
        public string Name { get; set; }

        public double Value { get; set; }

        public Model(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
