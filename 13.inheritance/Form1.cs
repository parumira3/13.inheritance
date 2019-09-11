using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.inheritance
{
    public partial class Form1 : Form
    {
        COneCycle _cOC;

        public Form1()
        {
            InitializeComponent();
            //this.Load += Form1_Load1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("외발자전거");
        }

        private void btnOneCycle_Click(object sender, EventArgs e)
        {

            OnecycleDraw();

        }

        private void OnecycleDraw()
        {

            lbName.Text = _cOC.strName;
            Graphics g = pMain.CreateGraphics(); //pMain 이라는 판넬에 그림을 그리겟다
            Pen p = _cOC.fPeninfo();

            g.DrawRectangle(p, _cOC._rtSquare1);
            g.DrawEllipse(p, _cOC._rtCircle1);
        }
    }
}
