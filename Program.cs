using System;

namespace RevInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num =Convert.ToInt32(Console.ReadLine());
            var obj1 = new RevInt();
            obj1.RevertInt(num);
        }
    }
    public class RevInt
    {
        int sum = 0;
        int temp;
        public void RevertInt(int number)
        {
            while (number > 0)
            {
                temp = number % 10;
                sum = sum * 10 + temp;
                number = number / 10;
            }
            Console.WriteLine(sum);
        }
        //return -1;
        
    }
    //return -1;
}
