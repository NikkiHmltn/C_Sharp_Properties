using System;
namespace Properties
{
    public class Box
    {
        //member variables
        // public technically makes it insecure code because everyone has access to it
        private int length = 3;
        public int height;
        public int width;
        public int volume;

        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, and the width is {2}, so the volume is {3}",
                length, height, width, volume=length*height*width);
        }
    }
}
