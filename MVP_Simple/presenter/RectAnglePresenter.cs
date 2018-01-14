using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP_Simple.model;
using MVP_Simple.view;

namespace MVP_Simple.presenter
{
    public class RectAnglePresenter
    {
        private IRectAngle rectView;

        public RectAnglePresenter(IRectAngle rectView)
        {
            this.rectView = rectView;
        }

        public void calcArea()
        {
            Rectangel rectangel = new Rectangel();
            rectangel.length = double.Parse(rectView.lengthText);
            rectangel.width = double.Parse(rectView.widthText);

            rectView.areaText = rectangel.calculateArea().ToString();
        }
    }
}
