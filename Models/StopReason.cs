using System;
using System.Collections.Generic;

namespace Models
{
    public class StopReason
    {
        /// <summary>
        /// Arıza
        /// </summary>
        public List<WorkOrderTime> FaultTimes { get; set; }

        /// <summary>
        /// Mola
        /// </summary>
        public List<WorkOrderTime> BreakTimes { get; set; }

        /// <summary>
        /// Setup
        /// </summary>
        public List<WorkOrderTime> SetupTimes { get; set; }

        /// <summary>
        /// Setup
        /// </summary>
        public List<WorkOrderTime> ArgeTimes { get; set; }
    }
}
