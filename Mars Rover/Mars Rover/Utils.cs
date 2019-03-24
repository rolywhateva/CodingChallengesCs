using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Mars_Rover
{
   public   static class Utils
    {
        static void JoinAllFiles(string Outname)
        {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.in");
            Console.WriteLine(files.Length);
            Console.WriteLine(Directory.GetCurrentDirectory());
            StreamWriter writer = new StreamWriter(Outname);
            foreach (string file in files)
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    // Console.WriteLine("*");
                    string[] words = file.Split(new char[] { '\\', ':', 'C', 'D' }, StringSplitOptions.RemoveEmptyEntries);
                    writer.WriteLine(words[words.Length - 1]);

                    writer.WriteLine(reader.ReadLine());
                }
            }
            writer.Close();
        }
      public  static  double  TurnRadius(float WheelBase,float SteeringAngle)
        {
            const  double  DegreeToRad = Math.PI / 180;
            return (double)WheelBase / Math.Sin(SteeringAngle * DegreeToRad);
        }
        public static  double Travel( ref double x, ref double y, double  steeringAngle)
        {

        }

    }
}
