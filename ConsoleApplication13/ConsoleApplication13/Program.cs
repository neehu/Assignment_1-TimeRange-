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
        public void IntersectPeriods(List<TimeRange> inputSet, List<TimeRange> Inputset)
        {

            DateTime startDate, endDate, Startdate, Enddate;

            foreach (TimeRange Element in inputSet)
            {
                startDate = Element.StartDate;
                endDate = Element.EndDate;

                foreach (TimeRange element in Inputset)
                {
                    Startdate = element.StartDate;
                    Enddate = element.EndDate;


                    if (((startDate < Startdate) && (endDate < Enddate)) && ((endDate > Startdate)))
                    {

                        TimeRange period = new TimeRange();
                        period.StartDate = Startdate;
                        period.EndDate = endDate;
                        Console.WriteLine((period.StartDate));
                        Console.WriteLine((period.EndDate));

                    }

                    if ((startDate > Startdate) && (endDate > Enddate) && ((Enddate > startDate)))
                    {
                        TimeRange Period = new TimeRange();
                        Period.StartDate = startDate;
                        Period.EndDate = Enddate;
                        Console.WriteLine(Period.StartDate);
                        Console.WriteLine(Period.EndDate);
                    }


                    if ((startDate >= Startdate) && (endDate < Enddate))
                    {
                        TimeRange period = new TimeRange();
                        period.StartDate = startDate;
                        period.EndDate = endDate;
                        Console.WriteLine(period.StartDate);
                        Console.WriteLine(period.EndDate);
                    }


                    if ((startDate <= Startdate) && (endDate >= Enddate))
                    {
                        TimeRange Period = new TimeRange();
                        Period.StartDate = Startdate;
                        Period.EndDate = Enddate;
                        Console.WriteLine(Period.StartDate);
                        Console.WriteLine(Period.EndDate);
                    }
                }

            }
        }

        static void Main(string[] args)
        {

            List<TimeRange> InputSet = new List<TimeRange>();
            List<TimeRange> inputSet = new List<TimeRange>();
            List<DateTime> intersectPeriod = new List<DateTime>();
            period getperiod = new period();
            Console.WriteLine("Enter the ranges in period 1");

            while (true)
            {
                TimeRange timerange = new TimeRange();
                timerange.StartDate = Convert.ToDateTime(Console.ReadLine());
                timerange.EndDate = Convert.ToDateTime(Console.ReadLine());
                InputSet.Add(timerange);



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
                inputSet.Add(timeRange);
                Console.WriteLine("Do you want to continue?");
                if (Console.ReadLine() == "no")
                    break;
            }
            getperiod.IntersectPeriods(InputSet, inputSet);
            Console.ReadKey();
        }
    }
}
