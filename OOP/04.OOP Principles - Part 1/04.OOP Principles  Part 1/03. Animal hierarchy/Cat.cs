﻿namespace task03
{
    public abstract class Cat:Animal,ISound
    {
        public Cat(string name, int age, Gender sex)
            : base(name, age, sex)
        { 
        }
       // public abstract void MakeSound();
      
    }
}
