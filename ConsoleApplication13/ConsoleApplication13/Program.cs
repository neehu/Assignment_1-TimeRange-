using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication13
{
    class TimeRange
    {
        public DateTime StartDate, EndDate;
        public TimeRange()
        {
        }
        public TimeRange(DateTime StartDate, DateTime EndDate)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }

    }

    class period
    {
        public List<TimeRange> IntersectPeriods(List<TimeRange> inputSetA, List<TimeRange> InputsetB)
        {
            List<TimeRange> intersectPeriods = new List<TimeRange>();
            DateTime startDateA, endDateA, StartdateB, EnddateB;

            foreach (TimeRange Element in inputSetA)
            {
                startDateA = Element.StartDate;
                endDateA = Element.EndDate;

                foreach (TimeRange element in InputsetB)
                {
                    StartdateB = element.StartDate;
                    EnddateB = element.EndDate;


                    if (((startDateA < StartdateB) && (endDateA < EnddateB)) && ((endDateA > StartdateB)))
                    {

                        TimeRange period = new TimeRange();
                        period.StartDate = StartdateB;
                        period.EndDate = endDateA;
                        intersectPeriods.Add(new TimeRange(period.StartDate, period.EndDate));
                        

                    }

                    if ((startDateA > StartdateB) && (endDateA > EnddateB) && ((EnddateB > startDateA)))
                    {
                        TimeRange Period = new TimeRange();
                        Period.StartDate = startDateA;
                        Period.EndDate = EnddateB;
                        intersectPeriods.Add(new TimeRange(Period.StartDate, Period.EndDate));
                    }


                    if ((startDateA >= StartdateB) && (endDateA < EnddateB))
                    {
                        TimeRange period = new TimeRange();
                        period.StartDate = startDateA;
                        period.EndDate = endDateA;
                        intersectPeriods.Add(new TimeRange(period.StartDate, period.EndDate));
                    }


                    if ((startDateA <= StartdateB) && (endDateA >= EnddateB))
                    {
                        TimeRange Period = new TimeRange();
                        Period.StartDate = StartdateB;
                        Period.EndDate = EnddateB;
                        intersectPeriods.Add(new TimeRange(Period.StartDate, Period.EndDate));
                    }
                }
             }
            return intersectPeriods;

        }

        static void Main(string[] args)
        {

            List<TimeRange> InputSetA = new List<TimeRange>();
            List<TimeRange> inputSetB = new List<TimeRange>();
            List<TimeRange> intersectPeriod = new List<TimeRange>();
            period getperiod = new period();
            Console.WriteLine("Enter the ranges in period 1");

            while (true)
            {
                TimeRange timerange = new TimeRange();
                timerange.StartDate = Convert.ToDateTime(Console.ReadLine());
                timerange.EndDate = Convert.ToDateTime(Console.ReadLine());
                InputSetA.Add(timerange);



                Console.WriteLine("Do you want to continue?");

                if (Console.ReadLine() == "no")

                    break;

            }

            Console.WriteLine("Enter the ranges in period 2");

            while (true)
            {
                TimeRange timeRange = new TimeRange();
                timeRange.StartDate = Convert.ToDateTime(Console.ReadLine());
                timeRange.EndDate = Convert.ToDateTime(Console.ReadLine());
                inputSetB.Add(timeRange);
                Console.WriteLine("Do you want to continue?");
                if (Console.ReadLine() == "no")
                    break;
            }
            intersectPeriod=getperiod.IntersectPeriods(InputSetA, inputSetB);
            Console.ReadKey();
        }
    }
}
