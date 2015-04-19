using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LoopsAndIfStataments;
namespace LoopsAndIfStataments
{
    class RefactorIfStatements
    {
        public static void Main()
        {
            //task 2 beneath
            int x = 0;
            int y = 0;
            int minX = 0;
            int maxX = 0;
            int maxY = 0;
            int minY = 0;
            bool shoudVisitCell = true;
            bool isYBetweemMinMax = minY <= y && y <= maxY;
            bool isXBetweenMinMax = minX <= x && x <= maxX;
            if (isXBetweenMinMax && (isYBetweemMinMax && shoudVisitCell))
            {
                VisitCell();
            }

            //task 1 beneath
            Potato potato = new Potato();
            bool isPeeled = potato.IsItPeeled;
            bool isRotten = potato.IsRotten;
            if (potato != null)
            {
                if (isPeeled && !isRotten)
                {
                    Cook(potato);
                }
            }
        }

        private static void VisitCell()
        {
            Console.WriteLine("i am visiting the cell");
        }

        private static void Cook(Potato potato)
        {
            Console.WriteLine("Cooking");
        }



    }
}
