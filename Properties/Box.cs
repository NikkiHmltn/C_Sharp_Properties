using System;
namespace Properties
{
    public class Box
    {
        //member variables
        // public technically makes it insecure code because everyone has access to it
        private int length = 3;
        private int height;
        //public int width;
        //public int volume;

        //type "prop" double tap tab, set type and name. shorthand.
        public int Width { get; set; }
        public int Volume { get; set; }

        //super short way to get and set without two separate methods
        public int Height
        {
            get{
                return height;
            }
            set
            {
                if (value < 0)
                {
                    //multiply with minus 1 to make it positive
                    height = -value;

                } else
                {
                    height = value;
                }
               
            }
        }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }

        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;

        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.length * this.Width * this.height;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, and the width is {2}, so the volume is {3}",
                length, height, Width, Volume=length*height*Width);
        }


        //NOTES -----------------------------------

        // MEMBER - PRIVATE FIELD
        //private string memberName;
        //private string jobTitle;
        //private int salary;

        //MEMBER - PUBLIC FIELD
        //public int age;

        //MEMBER - PROPERTY - EXPOSES JOBTITLE SAFETY - PROPS START WITH CAPITAL LETTER
        //public string JobTitle { get; set; }

        //PUBLIC MEMBER METHOD - CAN BE CALLED FOR OTHER CLASSES
        // public void Introduce(bool isFriend){
        //  Console.WriteLine("Hello, my name is {0}, and my job title is {1}", memberName, jobTitle)
        // }

        //PRIVATE MEMBER METHOD
        // private void SharingInfo(){
        //     Console.WriteLine("My salary is {0}", salary)
        // }

        // MEMBER CONSTRUCTOR
        // public Members() {
        //  age = 30;
        //  memberName = "Lucy";
        //  salary = 40000;
        //  jobTitle = "Developer";
        //  Console.WriteLine("Object Created")
        // }

        // MEMBER - FINALIZER - DESTRUCTOR
        // TILDE IS VERY IMPORTANT ~
        // ~Members(){
        // ITS HERE TO CLEAN UP STATEMENTS
        // 
        // }




    }
}
