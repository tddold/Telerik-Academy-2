using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace timer
{
    public class TimerMainProgram
    {
        public static void Main()
        {
            Timer newTimer = new Timer(1000,Timer.DelegateMethod);  
                     
            while (true)
            {
                Thread.Sleep(newTimer.t);
                PrintMethod(newTimer.MyMethod);              
            }
        }       

        public static void PrintMethod(Action<string> action)
        {
            action("The delegate method is called");
        }
    }
}
