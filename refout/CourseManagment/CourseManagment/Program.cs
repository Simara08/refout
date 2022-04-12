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
            for(int i = 1; i != 0; i++) 
            {
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Grup no daxil edin");
                        string no = Console.ReadLine();
                        Console.WriteLine("Kateqoriyani  daxil edin");
                        string category = Console.ReadLine();
                        Console.WriteLine("online-- 1.True  2.False");
                        int chek = Convert.ToInt32(Console.ReadLine());
                        bool isonline = false;
                        if (chek == 1)
                        {
                            isonline = true;
                        }
                        else
                        {
                            isonline = false;
                        }
                        grupS = new NewGrup(no, category, isonline);
                        grup1.Add(grupS);

                        break;
                    case 2:
                        foreach (var item in grup1)
                        {
                            Console.WriteLine(item.No);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter qrup No");
                        string grupno = Console.ReadLine();
                        foreach (var item in grup1)
                        {
                            if (item.No == grupno)
                            {
                                Console.WriteLine("Enter new grup no");
                                string newgrupno = Console.ReadLine();
                                foreach (var itemno in grup1)
                                {
                                    if (newgrupno == grupno)
                                    {
                                        Console.WriteLine("Eyni qrup nomresi daxil etmeyin");
                                    }
                                    else
                                    {
                                        item.No = newgrupno;
                                    }
                                }
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter grup no");
                        string No = Console.ReadLine();
                        bool Isex=false;
                        foreach (var item in grup1)
                        {
                            if (item.No==No)
                            {
                                Isex = true;
                            }
                        }
                        if (Isex == true)
                        {
                            foreach (var stuitem in students)
                            {
                                if (No==stuitem.GrupNo)
                                {
                                    Console.WriteLine($"{stuitem.FullNmae} {stuitem.GrupNo}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bele grup yoxdur");
                        }
                        break;
                    case 5:
                        foreach (var item in students)
                        {
                            Console.WriteLine($"{item.FullNmae} {item.GrupNo}");
                        }
                        break;
                    case 6:
                        bool StudentType;
                        int chekstu;
                            Console.WriteLine("Enter name");
                        string name = Console.ReadLine();
                        Console.WriteLine("1.Zemanetli-Yes or 2.zemanetsiz-No");
                        chekstu = Convert.ToInt32(Console.ReadLine());
                        if (chekstu==1)
                        {
                            StudentType = true;
                        }
                        else
                        {
                            StudentType = false;
                        }
                        Console.WriteLine("enter grup no");
                        string stuGr = Console.ReadLine();
                        foreach (var item in grup1)
                        {
                            if (item.No== stuGr)
                            {
                                studen = new Student( name,  stuGr,  StudentType);
                                students.Add(studen);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
           
        }
    }
}