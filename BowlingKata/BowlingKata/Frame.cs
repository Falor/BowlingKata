using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingKata
{
    class Frame
    {

        int firstAttempt;
        int secondAttempt;
        
        public int FirstAttempt
        {
            get => firstAttempt;
        }

        public int SecondAttempt
        {
            get => secondAttempt;
        }

        public Frame(int firstThrow, int secondThrow)
        {
            firstAttempt = firstThrow;
            secondAttempt = secondThrow;
        }

    }
}
