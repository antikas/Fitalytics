using System;
using Fitalytics.Core.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fitalytics.Tests
{
    [TestClass]
    public class IntervalBlockTest
    {
        [TestMethod]
        public void ShouldReturnDurationTimespan()
        {
            int duration = 5*60*1000; // 5 minutes
            IntervalBlock interval = new IntervalBlock(RunOrWalk.WALK, duration, "Warmup");
            var expected = TimeSpan.FromMilliseconds(duration);
            Assert.AreEqual(expected, interval.Duration);
        }
    }
}
