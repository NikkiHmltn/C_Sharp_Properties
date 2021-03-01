using System;
namespace Properties
{
    public class Box
    {
        //member variables
        public int length;
        public int height;
        public int width;
        public int volume;

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, and the width is {2}, so the volume is {3}",
                length, height, width, volume=length*height*width);
        }
    }
}
