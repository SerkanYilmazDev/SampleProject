using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Models;

namespace WorkOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Data
            var stopReasons = new StopReason
            {
                BreakTimes = new List<WorkOrderTime>()
                {
                    new BreakTime
                    {
                        StarTime = new DateTime(2017,01,01,10,00,00),
                        EndTime = new DateTime(2017,01,01,10,10,00)
                    },
                    new BreakTime
                    {
                        StarTime = new DateTime(2017,01,01,12,00,00),
                        EndTime = new DateTime(2017,01,01,12,30,00)
                    },
                    new BreakTime
                    {
                        StarTime = new DateTime(2017,01,01,14,00,00),
                        EndTime = new DateTime(2017,01,01,14,10,00)
                    },
                    new BreakTime
                    {
                        StarTime = new DateTime(2017,01,01,18,00,00),
                        EndTime = new DateTime(2017,01,01,18,10,00)
                    },
                    new BreakTime
                    {
                        StarTime = new DateTime(2017,01,01,20,00,00),
                        EndTime = new DateTime(2017,01,01,20,30,00)
                    },
                    new BreakTime
                    {
                        StarTime = new DateTime(2017,01,01,22,00,00),
                        EndTime = new DateTime(2017,01,01,22,10,00)
                    },
                    new BreakTime
                    {
                        StarTime = new DateTime(2017,01,02,10,00,00),
                        EndTime = new DateTime(2017,01,02,10,10,00)
                    },
                    new BreakTime
                    {
                        StarTime = new DateTime(2017,01,02,12,00,00),
                        EndTime = new DateTime(2017,01,02,12,30,00)
                    },
                    new BreakTime
                    {
                        StarTime = new DateTime(2017,01,02,14,00,00),
                        EndTime = new DateTime(2017,01,02,14,10,00)
                    },
                    new BreakTime
                    {
                        StarTime = new DateTime(2017,01,02,18,00,00),
                        EndTime = new DateTime(2017,01,02,18,10,00)
                    },
                    new BreakTime
                    {
                        StarTime = new DateTime(2017,01,03,04,00,00),
                        EndTime = new DateTime(2017,01,03,04,30,00)
                    },
                    new BreakTime
                    {
                        StarTime = new DateTime(2017,01,03,10,00,00),
                        EndTime = new DateTime(2017,01,03,10,10,00)
                    }
                },
                FaultTimes = new List<WorkOrderTime>()
                {
                   new FaultTime
                   {
                       StarTime = new DateTime(2017,01,01,10,30,00),
                       EndTime = new DateTime(2017,01,01,11,00,00)
                   },
                   new FaultTime
                   {
                       StarTime = new DateTime(2017,01,01,10,30,00),
                       EndTime = new DateTime(2017,01,01,11,00,00)
                   }
                },
                SetupTimes = new List<WorkOrderTime>()
                {
                    new SetupTime
                    {
                        StarTime = new DateTime(2017,01,01,15,00,00),
                        EndTime =  new DateTime(2017,01,01,16,30,00)
                    },
                    new SetupTime
                    {
                        StarTime = new DateTime(2017,01,03,06,00,00),
                        EndTime = new DateTime(2017,01,03,09,30,00)
                    }
                },
                ArgeTimes = new List<WorkOrderTime>()
                {
                    new ArgeTime
                    {
                        StarTime = new DateTime(2017,01,01,23,00,00),
                        EndTime =  new DateTime(2017,01,01,23,00,00)
                    }
                }
            };
            #endregion

            var workOrder1001 = new Models.WorkOrder
            {
                Number = 1001,
                StarTime = new DateTime(2017, 01, 01, 08, 00, 00),
                EndTime = new DateTime(2016, 01, 01, 16, 00, 00),
            };

            workOrder1001.FaultTime = Calculater(stopReasons.FaultTimes, workOrder1001);
            workOrder1001.ArgeTime = Calculater(stopReasons.ArgeTimes, workOrder1001);
            workOrder1001.SetupTime = Calculater(stopReasons.SetupTimes, workOrder1001);
            workOrder1001.BreakTime = Calculater(stopReasons.BreakTimes, workOrder1001);
            workOrder1001.TotalTime = workOrder1001.EndTime - workOrder1001.StarTime - workOrder1001.FaultTime -
                                      workOrder1001.ArgeTime - workOrder1001.SetupTime - workOrder1001.BreakTime;




        }

        public static TimeSpan Calculater(List<WorkOrderTime> stopReason, Models.WorkOrder workOrder)
        {
            //TODO: bütün stop reasonlar içinde workorder tipine göre süreler hesaplanacak



            return DateTime.Now - DateTime.Now;
        }
    }
}
