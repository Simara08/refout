using System;
using System.Collections.Generic;

namespace CourseManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NewGrup> grup1 = new List<NewGrup>();
            NewGrup grupS;
            List<Student> students = new List<Student>();
            Student studen;
            Console.WriteLine("1-Yeni qrup yarat");
            Console.WriteLine("2-Qrupların siyahısını göstər");
            Console.WriteLine("3-Qrup üzərində düzəliş etmək");
            Console.WriteLine("4 Qrupdakı tələbələrin siyahısını göstərt");
            Console.WriteLine("5-Bütün tələbələrin siyahısını göstər");
            Console.WriteLine("6-Tələbə yarat");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Grup no daxil edin");
                    string no = Console.ReadLine();
                    Console.WriteLine("Kateqoriyani  daxil edin");
                    string category= Console.ReadLine();
                    
                    break;
                default:
                    break;
            }
        }
    }
}
