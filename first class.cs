using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic
{
    internal class first_class
    {
        string a;
        int b;
        
        List<int> list = new List<int>();
        public void Pole(string s)
        {
            a = s;
        }
        public void Dop2El(int x, int y)
        {
            list.Add(x);
            list.Add(y);    
        }
        public string ConvertInString()
        {                        
            return a + String.Join(", ", list);
        }
        public string yourName()
        {
            return a;
        }
        public int yourNamelist()
        {
            return b;
        }
    }
    

    
}
