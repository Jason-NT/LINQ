using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQListColdWeather
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<Weather> daysForcasted = new List<Weather>();
            daysForcasted.Add(new Weather(DaysOfWeek.Mon, 44, 33));
            daysForcasted.Add(new Weather(DaysOfWeek.Tues, 38, 31));
            daysForcasted.Add(new Weather(DaysOfWeek.Wed, 41, 32));
            daysForcasted.Add(new Weather(DaysOfWeek.Thurs, 38, 25));
            daysForcasted.Add(new Weather(DaysOfWeek.Fri, 30, 21));

            var coldDays =
                from forecast in daysForcasted
                where forecast.HighTemp < 40
                select forecast;

            foreach (var coldDay in coldDays)
            {
                Console.WriteLine("Cold Weather on {0}", coldDay.Day);
            }
        }
        
    }
    enum DaysOfWeek
    {
        Sun, Mon, Tues, Wed, Thurs, Fri, Sat
    }


    class Weather 
    {
        public DaysOfWeek Day;
        public int HighTemp;
        public int LowTemp;

        public Weather(DaysOfWeek day, int high, int low)
        {
            Day = day;
            HighTemp = high;
            LowTemp = low;
        }
    }   
}


