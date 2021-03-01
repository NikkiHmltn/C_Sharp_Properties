using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            //setting box length cant because its private
            //box.length = 3;
            box.height = 4;
            box.width = 5;

            // getting the length is impossible too because its private
            // set up a public method to set the length to work around it
            box.SetLength(5);
            Console.WriteLine("Box length is " + box.GetLength());

            box.DisplayInfo();
        }
    }
}
