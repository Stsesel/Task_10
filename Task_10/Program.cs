using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные для транспортира");
            int grad_ = Convert.ToInt32(Console.ReadLine());
            int minute_ = Convert.ToInt32(Console.ReadLine());
            int second_ = Convert.ToInt32(Console.ReadLine());

            Transportir transportir = new Transportir(grad_, minute_, second_);

            //Transportir transportir = new Transportir() {grad=grad_, minute=minute_, second=second_};

            //transportir.grad = Convert.ToInt32(Console.ReadLine());
            //transportir.minute = Convert.ToInt32(Console.ReadLine());
            //transportir.second = Convert.ToInt32(Console.ReadLine());

            double totalRadians = transportir.ToRadians();
            Console.WriteLine("Значение в градусах " + totalRadians);
            Console.WriteLine("Перевод градусов в радианы " + (totalRadians / 3600 / 180 * Math.PI));
            Console.ReadKey();
        }
        
        

    

    }
}
