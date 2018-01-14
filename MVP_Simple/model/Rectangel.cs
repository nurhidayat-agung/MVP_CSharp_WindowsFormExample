using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Simple.model
{
    public class Rectangel
    {
        public double length { get; set; }
        public double width { get; set; }

        public double calculateArea()
        {
            return length * width;
        }
    }
}
