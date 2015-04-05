//Problem 1. School classes
//We are given a school. In the school there are classes of students. Each class has a set of teachers.
//Each teacher teaches a set of disciplines. Students have name and unique class number. 
//Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and
//number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines 
//could have optional comments (free text block).
//Your task is to identify the classes (in terms of OOP) and their attributes
//and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.


namespace school
{
    public class MainProgram
    {
        static void Main()
        {
            Student student1=new Student("Aaaa Bbb",1);
            Student student2=new Student("Cccc Ddd",2);
            Student student3=new Student("Eeee Fff",3,"ZZZZZZZZZZZZZ");

            Teacher teacher1=new Teacher("Zzzz yyyy");
            Teacher teacher2=new Teacher("Xxxx wwww");

            Discipline oop=new Discipline("oop",12,10,"AAAAAAAA");
            Discipline Csharp=new Discipline("Csharp",20,14);
            Discipline Java=new Discipline("Java",15,16);

            teacher1.AddDisicipline(oop);
            teacher1.AddDisicipline(Csharp);
            teacher2.AddDisicipline(oop);
            teacher1.ListOfDisciplines.Add(Java);
            School MySchool = new School();
            ClassInSchool MyClass = new ClassInSchool("MyClassName");
            MyClass.AddStudent(student1);
            MyClass.AddStudent(student2);
            MyClass.AddStudent(student3);
            MyClass.AddTeacher(teacher1);
            MyClass.AddTeacher(teacher2);
            MySchool.AddClass(MyClass);
            System.Console.WriteLine(MyClass);
        }
    }
}
