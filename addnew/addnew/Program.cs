using System;

namespace addnew
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 7;
            int[] num = { 7,45,23}; 
           int[]  array1 = { 2, 3, 4, 5 };
            array1 = AddNew(ref array1, ref num);
            //array1=AddNew(ref array1, ref num);
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }






        }
        // new style
        static int[] AddNew(ref int[] array, ref int[] a)
        {

            int i;
            int[] c = new int[array.Length + a.Length];

            for (i = 0; i < array.Length; i++)
            {
                c[i] = array[i];
            }

            for (i = 0; i < a.Length; i++)
            {
                c[array.Length  + i] = a[i];
            }
            return c;
        }

        //sizin verdiyiniz taskn helli

        //static int[] addnew(ref int[] array, ref int a)
        //{
        //    int[] temp = new int[array.length + 1];
        //    for (int i = 0; i < array.length; i++)
        //    {
        //        temp[i] = array[i];
        //    }
        //    temp[temp.length - 1] = a;
        //    return temp;
























        }
    
}
