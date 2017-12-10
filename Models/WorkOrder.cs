using System;

namespace Models
{
    public class WorkOrder
    {
        public int Number { get; set; }

        public DateTime StarTime { get; set; }

        public DateTime EndTime { get; set; }

        public TimeSpan BreakTime { get; set; }

        public TimeSpan FaultTime { get; set; }

        public TimeSpan SetupTime { get; set; }

        public TimeSpan ArgeTime { get; set; }

        public TimeSpan TotalTime { get; set; }
    }
}
