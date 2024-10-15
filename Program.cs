using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practic;

namespace практика_класс
{
    internal class Program
    {
        static void Main()
        {

            int mmm = 1000;
            List<first_class> list = new List<first_class>();
            for (int i =0; i < mmm; i++)
            {
                first_class Obj = new first_class();
                Obj.Pole("gzsdjkgzdshyghdfzs ");
                Obj.Dop2El(1, i);                
                list.Add(Obj);

            }
            //string выв = Obj.ConvertInString();
            Console.WriteLine(list[0].ConvertInString());
            Console.WriteLine(list[100].ConvertInString());
            Console.WriteLine(list[999].ConvertInString());

            first_class Nobj = new first_class();
            for (int i = 0; i < mmm; i++)
            {                
                first_class X = list[i];                
                string y = X.yourName();

            }























            Console.ReadKey();
        }
    }
}
