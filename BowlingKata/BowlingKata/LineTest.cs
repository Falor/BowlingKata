using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace BowlingKata
{
    [TestFixture]
    public class LineTest
    {

        Line firstLine;
        Line secondLine;
        Line thirdLine;
        Line fourthLine;

        [SetUp]
        public void SetUp()
        {
            List<Frame> tmpFrames = new List<Frame>();
            for (int i = 0; i < 10; i++)
            {
                tmpFrames.Add(new Frame(0, 0));
            }
            firstLine = new Line(tmpFrames);

            tmpFrames = new List<Frame>();
            for (int i = 0; i < 10; i++)
            {
                tmpFrames.Add(new Frame(1, 0));
            }
            secondLine = new Line(tmpFrames);

            tmpFrames = new List<Frame>();
            for (int i = 0; i < 11; i++)
            {
                tmpFrames.Add(new Frame(5, 5));
            }
            thirdLine = new Line(tmpFrames);

            tmpFrames = new List<Frame>();
            for (int i = 0; i < 12; i++)
            {
                tmpFrames.Add(new Frame(10, 0));
            }
            fourthLine = new Line(tmpFrames);

        }

        [Test]
        public void Evaluation()
        {
            Assert.AreEqual(0, firstLine.Evaluate());
            Assert.AreEqual(10, secondLine.Evaluate());
            Assert.AreEqual(150, thirdLine.Evaluate());
            Assert.AreEqual(300, fourthLine.Evaluate());
        }

    }
}
