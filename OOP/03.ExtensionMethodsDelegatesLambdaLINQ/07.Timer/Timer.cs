using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timer
{
    
    public class Timer
    {
        public int t  {get;private set;}
        public Action<string> MyMethod { get; private set; }

        public Timer(int t, Action<string> DelegateMethod)
        {
            this.t = t;
            this.MyMethod = DelegateMethod;
        }      

        public static void DelegateMethod(string input)
        {
            Console.WriteLine(input);
        }

    }
}
