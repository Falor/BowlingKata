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



        public Line(List<Frame> frames)
        {
            this.frames = frames;
        }



        public int Evaluate()
        {
            int sum = 0;
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
