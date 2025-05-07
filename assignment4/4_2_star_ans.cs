using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            int size = 2 * (radius + 1);

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    bool draw = false;


                    if (
                        (y == 1 && x >= 2 && x <= size / 2 + 1) ||
                        (y == size - 2 && x >= 2 && x <= size / 2 + 1) ||
                        (x == 2 && y >= 1 && y <= size - 2)
                    )
                        draw = true;


                    int left = size - 4;
                    int right = size - 1;
                    int top = size / 3;
                    int bottom = top + 4;


                    if ((x == left || x == right - 1) &&
                        ((y >= top - 2 && y <= top + 1) || (y >= bottom - 2 && y <= bottom + 1)))
                        draw = true;


                    if ((y == top || y == bottom) &&
                        x >= left - 1 && x <= right + 2)
                        draw = true;

                    Console.Write(draw ? '*' : ' ');
                }
                Console.WriteLine();
            }
        }

        // calculate the distance between (x1, y1) and (x2, y2)
        static double SqrDistance2D(double x1, double y1, double x2, double y2)
        {
            return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
        }

        // Checks if two values a and b are within a given distance.
        // |a - b| < distance
        static bool IsClose(double a, double b, double distance)
        {
            return Math.Abs(a - b) < distance;
        }
    }
}


/* example output
Enter the radius: 
>> 5
                *   *   
  *********     *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
  *********     *   *   

*/

/* example output (CHALLANGE)
Enter the radius: 
>> 5
                *   *  
      *         *   *  
   *     *      *   *  
  *                    
           ************
               *   *   
 *             *   *   
               *   *   
           ************
  *                    
   *     *    *   *    
      *       *   *    

*/