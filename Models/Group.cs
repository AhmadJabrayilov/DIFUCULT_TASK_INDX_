using System;
using System.Collections.Generic;
using System.Text;

namespace Intf_Indx_Excp.Models
{
    internal class Group
    {
        public string GroupNo { get; set; }
        private int _studentLimit;
        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (value > 4 && value < 19)
                {
                    _studentLimit = value;
                }
            }
        }


        private Student[] students = new Student[0];

        public Group(string groupNo, int studentlimit)
        {

        }


        public bool CheckGroupNo(string groupNo)
        {
            bool hasNumber = false;

            bool hasUpper = false;

            foreach (char item in groupNo)
            {
                if (char.IsNumber(item))
                {
                    hasNumber = true;
                }
                if (char.IsUpper(item))
                {
                    hasUpper = true;
                }
            }

            return true;
        }

        public void AddStudent(Student student)
        {
            if (students.Length == StudentLimit)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = student;
            }
        }

        public void GetStudent(int? id)
        {
            foreach (var item in students)
            {
                if(id == item.Id)
                {
                    item.StudentInfo();
                }
            }

        }

       public Student[] GetAllStudents()
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
            return students;
        }
        

        

        //public Group(string groupno, int studentlimit)
        //{
        //    GroupNo = groupno;
        //    StudentLimit = studentlimit;
        //}

    }
}
