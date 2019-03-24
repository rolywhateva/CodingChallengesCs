using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingCataliyst_AddictiveGame
{
    static class Utils
    {
       public static void Position(int val, int rows, int column, out int x, out int y)
        {
            int counter = 0;
            for (int r = 1; r <= rows; r++)
                for (int c = 1; c <= column; c++)
                {
                    counter++;
                    if (counter == val)
                    {
                        x = r;
                        y = c;
                        return;

                    }
                }
            x = 0;
            y = 0;
        }
       public  static  int ManhatanDistance(int poz1, int poz2, int rows, int column)
        {
            int x1, y1, x2, y2;
            Position(poz1, rows, column, out  x1, out  y1);
            Position(poz2, rows, column, out x2, out y2);
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);

        }

internal static int ValidPath(int rows, int columns, int start, int pathColor, Dictionary<int, int> pointsDictionary,string[] steps, out bool succes)
        {
            //Position(start, rows, columns, out int xstart, out int ystart);
            List<int> previous = new List<int>();
            int initial = start;
            succes = false;
            for(int i=0;i<steps.Length;i++)
            {
                switch(steps[i])
                {
                    case "S":start += columns; break;
                    case "N":start -= columns; break;
                    case "W": {
                            if (start % columns == 1)
                                return i+1;
                            start--;
                        }
                        break;
                    case "E":
                        {
                            if (start % columns == 0)
                                return i+1;

                            start++;
                        }

                   break;
                }


                if (start < 0 || start > rows * columns || previous.Contains(start))
                    return i + 1;
                previous.Add(start);
                if (pointsDictionary.ContainsKey(start))
                {
                    if (i != steps.Length - 1)
                        return i + 1;
                    else
                    if (pointsDictionary[start] != pointsDictionary[initial])
                        return i + 1;




                }
                else
                     if (i == steps.Length - 1)
                    return i + 1;

               

             
            }
          if(start!=initial)
            succes = true;
            return steps.Length;
        }
    }
}
