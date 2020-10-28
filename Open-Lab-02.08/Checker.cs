using System;

namespace Open_Lab_02._08
{
    public class Checker
    {
        public bool IsEmpty(string str)
        {
            Greeter greeter = new Greeter();
            greeter.Greet();
            Console.ReadKey();

            if (IsEmpty(str))
            {
                Console.WriteLine(greeter.Greet()+ str + ")");
                return true;
            }
            else
            {
                Console.WriteLine(greeter.Greet() + str + ")");
                return false;
            }
        }
    }
}
