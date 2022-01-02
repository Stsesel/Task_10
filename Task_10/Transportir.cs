using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Transportir
    {
        int grad;
        int minute;
        int second;

        public int Grad
        {
            get
            {
                return grad;
            }

            set
            {
                grad = value % 360;
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }

            set
            {
                Grad += value / 60;
                minute= value % 60;
            }
        }

        public int Second
        {
            get
            {
                return second;
            }

            set
            {
                Minute += value / 60;
                second = value % 60;
            }
        }



        public Transportir(int grad, int minute, int second)
        {
            this.Grad = grad;
            this.Minute = minute;
            this.Second = second;

        }




        public int ToRadians()
        {
            return second + minute * 60 + grad * 60 * 60;
        }
    }
}
