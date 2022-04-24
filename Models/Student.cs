using System;
using System.Collections.Generic;
using System.Text;

namespace Intf_Indx_Excp.Models
{
    internal class Student
    {
        private int _id;
        public int Id { get; }
        public string Fullname { get; set; }
        private int _point;
      

        public Student(string fullname, int point)
        {
            _id++;
            Id = _id;
            Fullname = fullname;
            Point = point;

        }

        public void StudentInfo()
        {
            Console.WriteLine($"ID: {Id} / Fullname: {Fullname} / Point: {Point}");
        }


        public int Point
        {
            get
            {
                return _point;
            }

            set
            {
                if (value > 0 && value <= 100)
                {
                    _point = value;
                }
            }
        }

    }
}
