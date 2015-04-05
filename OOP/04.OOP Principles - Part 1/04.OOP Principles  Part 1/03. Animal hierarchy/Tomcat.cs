using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    public class Tomcat:Cat,ISound
    {
        public Tomcat(string name, int age, Gender sex=Gender.Female)
            : base(name, age, sex)
        {
 
        }
        public override void MakeSound()
        {
            string sound = "pispsps";
        }
    }
}
