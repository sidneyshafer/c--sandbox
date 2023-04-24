using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesPartOne
{
    class Box
    {
        // Member Variables
        private int length = 3;
        private int height;
        // private int width;
        private int volume;

        // Properties
        // convention: user uppercase first letter
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
            }
        }

        // Faster way of setting property
        public int Width { get; set; }

        public int Volume
        { get { return this.length * this.height * this.Width; } }

        // Setter
        // can also make private
        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0.");
            }
            this.length = length;
        }

        // Constructor
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }

        // Getter
        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.length * this.height * this.Width;
        }

        // Read only proprty
        public int FrontSurface
        {
            get { return height * length; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1}, width is {2}, and volume is {3}. "
                , length, height, Width, volume = length*height*Width);
        }

    }
}
