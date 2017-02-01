using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace IntersectPeriods
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
        public List<TimeRange> IntersectPeriods(List<TimeRange> inputSetA, List<TimeRange> inputSetB)
        {
            List<TimeRange> intersectPeriods = new List<TimeRange>();
            DateTime startDateA, endDateA, StartdateB, EnddateB;

            foreach (TimeRange Element in inputSetA)
            {
                startDateA = Element.StartDate;
                endDateA = Element.EndDate;

                foreach (TimeRange element in inputSetB)
                {
                    StartdateB = element.StartDate;
                    EnddateB = element.EndDate;


                    if (((startDateA <= StartdateB) && (endDateA <= EnddateB)) && ((endDateA >= StartdateB)))
                    {

                        TimeRange overlappingPeriods = new TimeRange();
                        overlappingPeriods.StartDate = StartdateB;
                        overlappingPeriods.EndDate = endDateA;
                        intersectPeriods.Add(new TimeRange(overlappingPeriods.StartDate, overlappingPeriods.EndDate));


                    }

                    if ((startDateA >= StartdateB) && (endDateA >= EnddateB) && ((EnddateB >= startDateA)))
                    {
                        TimeRange overlappingPeriods = new TimeRange();
                        overlappingPeriods.StartDate = startDateA;
                        overlappingPeriods.EndDate = EnddateB;
                        intersectPeriods.Add(new TimeRange(overlappingPeriods.StartDate, overlappingPeriods.EndDate));
                    }


                    if ((startDateA >= StartdateB) && (endDateA <= EnddateB))
                    {
                        TimeRange overlappingPeriods = new TimeRange();
                        overlappingPeriods.StartDate = startDateA;
                        overlappingPeriods.EndDate = endDateA;
                        intersectPeriods.Add(new TimeRange(overlappingPeriods.StartDate, overlappingPeriods.EndDate));
                    }


                    if ((startDateA <= StartdateB) && (endDateA >= EnddateB))
                    {
                        TimeRange overlappingPeriods = new TimeRange();
                        overlappingPeriods.StartDate = StartdateB;
                        overlappingPeriods.EndDate = EnddateB;
                        intersectPeriods.Add(new TimeRange(overlappingPeriods.StartDate, overlappingPeriods.EndDate));
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
            intersectPeriod = getperiod.IntersectPeriods(InputSetA, inputSetB);

            foreach (TimeRange period in intersectPeriod)
            {
                Console.WriteLine(Convert.ToString(period.StartDate + "-" + Convert.ToString(period.EndDate)));

            }
            Console.ReadKey();
        }
    }
}
