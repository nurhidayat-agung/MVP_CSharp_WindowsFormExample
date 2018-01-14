using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP_Simple.presenter;
using MVP_Simple.view;

namespace MVP_Simple
{
    public partial class Form1 : Form,IRectAngle
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string areaText
        {
            get { return tbxArea.Text; }

            set { tbxArea.Text = value; }
        }

        public string lengthText
        {
            get { return tbxLength.Text; }

            set { tbxLength.Text = value; }
        }

        public string widthText
        {
            get { return tbxWidth.Text; }

            set { tbxArea.Text = value; }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            RectAnglePresenter presenter = new RectAnglePresenter(this);
            presenter.calcArea();
        }
    }
}
