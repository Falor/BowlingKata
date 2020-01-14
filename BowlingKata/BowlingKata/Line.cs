using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingKata
{
    class Line
    {

        List<Frame> frames;

        public List<Frame> Frames
        {
            get => frames;
        }

        public Line()
        {
            frames = new List<Frame>();
        }

        public Line(List<Frame> frames)
        {
            this.frames = frames;
        }


        /// <summary>
        /// Adds a new Frame to the Line.
        /// </summary>
        /// <param name="firstAttempt"></param>
        /// <param name="secondAttempt"></param>
        public void Add(int firstAttempt, int secondAttempt = 0)
        {
            if(frames.Count < 13)
                frames.Add(new Frame(firstAttempt, secondAttempt));
        }
   
        /// <summary>
        /// Evaluates the total amount of points in the line.
        /// </summary>
        /// <returns></returns>
        public int Evaluate()
        {
            // total sum
            int sum = 0;
            // sum of current frame
            int tmp = 0;

            for (int i = 0; i < 10; i++)
            {
                
                tmp = Frames[i].FirstAttempt  + Frames[i].SecondAttempt;

                if (tmp == 10)
                {
                    tmp += Frames[i + 1].FirstAttempt;
                    if(Frames[i].FirstAttempt == 10)
                    {
                        if(Frames[i + 1].SecondAttempt != 0)
                            tmp += Frames[i + 1].SecondAttempt;
                        else
                            tmp += Frames[i + 2].FirstAttempt;
                    }
                }
                    
                sum += tmp; 

                
            }

            return sum;
        }

        /// <summary>
        /// Returns the Line in a presentable manner
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string tmp = "";

            for(int i = 0; i < Frames.Count; i++)
            {
                if(frames[i].FirstAttempt == 10)
                {
                    tmp += "X ";
                }
                else
                {
                    tmp += frames[i].FirstAttempt;
                    tmp += "¬";

                    if (frames[i].FirstAttempt + frames[i].SecondAttempt != 10)
                    {
                        tmp += frames[i].SecondAttempt;
                    }
                    else
                    {
                        tmp += "/";
                    }
                }
            }
            return tmp;
        }
    }
}
