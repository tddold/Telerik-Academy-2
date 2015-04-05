﻿//Problem 4. Person class
//Create a class Person with two fields – name and age. Age can be left unspecified 
//(may contain null value. Override ToString() to display the information of a person 
//and if age is not specified – to say so.
//Write a program to test this functionality.

namespace Person
{
    using System;
    public class Person
    {
        private string  name;
        private int? age;
        public Person(string inputName, int? inputAge = null)
        {
            this.Name = inputName;
            this.Age = inputAge;
        }

        public int? Age
        {
            get 
            {
                return this.age; 
            }
            set 
            {
                this.age = value; 
            }
        }
        

        public string  Name
        {
            get 
            {
                return this.name;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Name can't be null.");
                }
                this.name = value; 
            }
        }

        public override string ToString()
        {
            string result = string.Format("Name:{0} Age:{1}", this.Name,this.Age==null?"No data":this.Age.ToString());
            return result;
        }
        
    }
}
