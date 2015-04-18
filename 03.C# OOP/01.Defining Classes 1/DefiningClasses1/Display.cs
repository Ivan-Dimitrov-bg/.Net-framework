using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneClass
{
    class Display
    {
        private int size;
        private int numberOfColors;

        public Display()
        {
            this.Size = 0;
            this.NumberOfColors = 0;
        }

        public Display(int size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public int NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }
    }

}