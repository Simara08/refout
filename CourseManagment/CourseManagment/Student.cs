using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment
{
    class Student
    {
        //Fullname Group No Type
        public string FullNmae { get; set; }
        public int GrupNo { get; set; }
        public bool Type { get; set; }
        public Student(string fullname,int grupno,bool type)
        {
            FullNmae = fullname;
            GrupNo = grupno;
            Type = type;
        }
        public override string ToString()
        {
            var result = Type ? "zemanetli" : "Zemanetsiz";
            return $"Fullname:{FullNmae} Grupno{GrupNo} Type{Type}";
        }
    }
}
