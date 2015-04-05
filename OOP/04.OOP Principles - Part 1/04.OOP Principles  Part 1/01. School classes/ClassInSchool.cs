namespace school
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ClassInSchool : ITextBlock
    {
        private List<Student> listOfStudents;
        private List<Teacher> listOfTeachers;
        private string textIdentifier;

        private string textBlock;


        public ClassInSchool(string inputText)
        {
            this.listOfStudents = new List<Student>();
            this.listOfTeachers = new List<Teacher>();
            this.TextIdentifier = inputText;
        }

        public ClassInSchool(string inputText, string inputTextBlock)
            : this(inputText)
        {
            this.listOfStudents = new List<Student>();
            this.listOfTeachers = new List<Teacher>();
            this.TextBlock = inputTextBlock;
        }

        public List<Student> ListOfStudents
        {
            get
            {
                return new List<Student>(this.listOfStudents);
            }
        }

        public List<Teacher> ListOfTeachers
        {
            get
            {
                return new List<Teacher>(this.listOfTeachers);
            }
        }

        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Invalid text identifier");
                }
                this.textIdentifier = value;
            }
        }
        public string TextBlock
        {
            get
            {
                return this.textBlock;
            }
            set
            {
                this.textBlock = value;
            }
        }

        public void AddTeacher(Teacher newTeacher)
        {
            this.listOfTeachers.Add(newTeacher);
        }

        public void RemoveTeacher(int indexOfTeacher)
        {
            this.listOfTeachers.RemoveAt(indexOfTeacher);
        }

        public void AddStudent(Student newStudent)
        {
            this.listOfStudents.Add(newStudent);
        }

        public void RemoveStudent(int indexOfStudent)
        {
            this.listOfStudents.RemoveAt(indexOfStudent);
        }
        public override string ToString()
        {
            var resultStudents = new StringBuilder();
            var resultTeachers = new StringBuilder();
        
            foreach (var teacher in this.listOfTeachers)
            {
                resultTeachers.AppendLine(teacher.ToString());
            }
            foreach (var student in this.listOfStudents)
            {
                resultStudents.AppendLine(student.ToString());
            }
            return string.Format("Class text identifier:{0} \ntext block:{1} \nTeachers\n{2}\nStudents:\n{3}", 
                this.TextIdentifier, TextBlock,resultTeachers.ToString(),resultStudents.ToString());
        }


    }
}
