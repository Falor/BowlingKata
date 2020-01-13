using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKata
{
    class Program
    {
        static Line testLine;
        static void Main(string[] args)
        {
            List<Frame> tmpFrames = new List<Frame>();
            for (int i = 0; i < 12; i++)
            {
                tmpFrames.Add(new Frame(10, 0));
            }
            testLine = new Line(tmpFrames);


            Console.WriteLine(testLine);
            Console.WriteLine(" Total score: " + testLine.Evaluate());
        }
    }
}
