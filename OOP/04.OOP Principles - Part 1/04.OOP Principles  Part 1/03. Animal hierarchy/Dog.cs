﻿namespace task03
{
    public class Dog:Animal,ISound
    {
        public Dog(string name,int age, Gender sex):base(name,age,sex)
        {
        }

        public override void MakeSound()
        {
            string sound = "Bau Bau";
        }
    }
}
