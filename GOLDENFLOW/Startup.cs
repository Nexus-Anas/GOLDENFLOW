using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOLDENFLOW
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
            timer1.Start();
        }

        private int _sec;
        private void timer1_Tick(object sender, EventArgs e)
        {
            _sec++;
            if (_sec == 4)
            {
                new Form1().Show();
                Hide();
            }
        }

        /////////////////////////////////////Settings/////////////////////////////////////////////
        private bool _mouseDown;
        private Point _startPoint = new Point(0, 0);
        private void Startup_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true; _startPoint = new Point(e.X, e.Y);
        }
        private void Startup_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                var point = PointToScreen(e.Location);
                Location = new Point(point.X - _startPoint.X, point.Y - _startPoint.Y);
            }
        }
        private void Startup_MouseUp(object sender, MouseEventArgs e) => _mouseDown = false;
        //////////////////////////////////////////////////////////////////////////////////////////
    }
}
