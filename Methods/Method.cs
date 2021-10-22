using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Methods
{
    class Method
    {
        public double[] x, y;
        public int N;
        protected double c, x0, y0, X, h;

        public Method(int N, double x0, double y0, double X)
        {
            this.N = N + 1;
            this.X = X;
            this.x0 = x0;
            this.y0 = y0;
            if (x0 == 0 || x0 == 1.0 / y0)
            {
                MessageBox.Show("IVP has no solution");
                Application.Exit();
            }
            c = Math.Exp(y0 / -x0)-x0;
            h = (X - x0) / N;
        }
        public void Calculate()
        {
            int range = (int)((X - x0) / 0.01);
            x = new double[range + 1];
            y = new double[range + 1];
            int count = 0;
            for (double i = x0; i <= X; i += 0.01)
            {
                x[count] = i;
                y[count] = Exact(i);
                count++;
            }
        }
        protected double Exact(double x)
        {
            if (x == 0.0)
            {
                MessageBox.Show("Interval [x0, X] has a point of discontinuity");
                Application.Exit();
            }

            return -x*Math.Log(c + x);
        }
        protected double F(double x, double y)
        {
            if (x == 0.0)
            {
                MessageBox.Show("Interval [x0, X] has a point of discontinuity");
                Application.Exit();
            }
            return y / x - x * Math.Exp(y / x);
        }
    }
}
