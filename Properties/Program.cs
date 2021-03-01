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
            box.Height = 4;
            box.width = 5;

            // getting the length is impossible too because its private
            // set up a public method to set the length to work around it
            box.SetLength(4);
            Console.WriteLine("Box length is " + box.GetLength());
            Console.WriteLine("Box volume is " + box.GetVolume());

            box.DisplayInfo();


        }
    }
}
