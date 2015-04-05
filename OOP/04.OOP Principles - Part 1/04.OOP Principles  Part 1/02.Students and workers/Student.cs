
namespace task02
{
    public class Student:Human
    {
        public int Grade {get;private set;}
        public Student(string firstName, string lastName,int grade):base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return string.Format("Student {0} {1} - {2}", this.FirstName, this.LastName, this.Grade);
        }
       
    }
}
