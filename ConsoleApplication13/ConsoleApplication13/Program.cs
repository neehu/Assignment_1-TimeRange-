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
        public void IntersectPeriods(List<TimeRange> SetA, List<TimeRange> SetB)
        {

            DateTime pointerx, pointery, pointera, pointerb;

            foreach (TimeRange FirstSet in SetA)
            {
                pointerx = FirstSet.StartDate;
                pointery = FirstSet.EndDate;


                foreach (TimeRange SecondSet in SetB)
                {
                    pointera = SecondSet.StartDate;
                    pointerb = SecondSet.EndDate;


                    if (((pointerx < pointera) && (pointery < pointerb)) && ((pointery > pointera)))
                    {

                        TimeRange p1 = new TimeRange();
                        p1.StartDate = pointera;
                        p1.EndDate = pointery;
                        Console.WriteLine((p1.StartDate));
                        Console.WriteLine((p1.EndDate));

                    }

                    if ((pointerx > pointera) && (pointery > pointerb) && ((pointerb > pointerx)))
                    {
                        TimeRange p2 = new TimeRange();
                        p2.StartDate = pointerx;
                        p2.EndDate = pointerb;
                        Console.WriteLine(p2.StartDate);
                        Console.WriteLine(p2.EndDate);
                    }


                    if ((pointerx >= pointera) && (pointery < pointerb))
                    {
                        TimeRange p1 = new TimeRange();
                        p1.StartDate = pointerx;
                        p1.EndDate = pointery;
                        Console.WriteLine(p1.StartDate);
                        Console.WriteLine(p1.EndDate);
                    }


                    if ((pointerx <= pointera) && (pointery >= pointerb))
                    {
                        TimeRange p2 = new TimeRange();
                        p2.StartDate = pointera;
                        p2.EndDate = pointerb;
                        Console.WriteLine(p2.StartDate);
                        Console.WriteLine(p2.EndDate);
                    }


                }

            }


        }

        static void Main(string[] args)
        {

            List<TimeRange> Set1 = new List<TimeRange>();
            List<TimeRange> Set2 = new List<TimeRange>();
            List<DateTime> Set3 = new List<DateTime>();
            period getperiod = new period();
            Console.WriteLine("Enter the ranges in period 1");

            while (true)
            {
                TimeRange period1 = new TimeRange();
                period1.StartDate = Convert.ToDateTime(Console.ReadLine());
                period1.EndDate = Convert.ToDateTime(Console.ReadLine());
                Set1.Add(period1);



                Console.WriteLine("Do you want to continue");

                if (Console.ReadLine() == "no")

                    break;

            }

            Console.WriteLine("Enter the ranges in period 2");

            while (true)
            {
                TimeRange period1 = new TimeRange();
                period1.StartDate = Convert.ToDateTime(Console.ReadLine());
                period1.EndDate = Convert.ToDateTime(Console.ReadLine());
                Set2.Add(period1);

                Console.WriteLine("Do you want to continue");

                if (Console.ReadLine() == "no")

                    break;

            }

            getperiod.IntersectPeriods(Set1, Set2);

            Console.ReadKey();
        }


    }
}
