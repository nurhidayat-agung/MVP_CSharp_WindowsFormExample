using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Simple.view
{
    public interface IRectAngle
    {
        string lengthText { get; set; }
        string widthText { get; set; }
        string areaText { get; set; }
    }
}
