﻿namespace Disruptor.Test
{
    using Disruptor.Impl;
    using Xunit;
    using static Support.WaitStrategyTestUtil;

    public class Busy_Spin_Wait_Strategy_Test
    {
        [Fact(DisplayName = "应该等待")]
        public void Should_Wait_For_Value()
        {
            AssertWaitForWithDelayOf(50, new BusySpinWaitStrategy());
        }
    }
}
