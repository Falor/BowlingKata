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
            string answer = "";
            do
            {
                Console.WriteLine("Show test run? (Y/N)");
                answer = Console.ReadLine();
            } while (answer.ToLower() != "y" && answer.ToLower() != "n");
            

            if(answer.ToLower() == "y")
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
            else
            {
                //enters manual input
                testLine = new Line();

                int frameCounter = 0;
                int frameMax = 12;
                while (frameCounter < frameMax)
                {
                    frameCounter++;
                    Console.WriteLine(frameCounter +". Try #1, Enter Value: ");

                    int first = 0;
                    Int32.TryParse(Console.ReadLine(),out first);
                    int second = 0;
                    if (first != 10)
                    {
                        Console.WriteLine(frameCounter + ". Try #2, Enter Value: ");
                        Int32.TryParse(Console.ReadLine(), out second);
                        
                    }
                    testLine.Add(first, second);


                }
                //output
                Console.WriteLine(testLine);
                Console.WriteLine(" Total score: " + testLine.Evaluate());


            }



        }
    }
}
