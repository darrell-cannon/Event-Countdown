using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWPFApp
{
    [Serializable]
    internal class CountdownDate
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public bool IsEvent { get; set; }

        public int DaysUntilDate { get; set; }

        public CountdownDate(string name, DateTime date, bool isEvent)
        {
            Name = name;
            Date = ConvertDateToLatestYear(date);
            DaysUntilDate = CalculateDaysToDate(Date);
            IsEvent = isEvent;

        }
        
        public static DateTime ConvertDateToLatestYear(DateTime date)
        {
            DateTime newDate = new DateTime(DateTime.Today.Year, date.Month, date.Day);

            if (newDate.Date < DateTime.Today)
            {
                newDate = new DateTime(DateTime.Today.Year + 1, date.Month, date.Day);
            }

            return newDate;
        }

        public static int CalculateDaysToDate(DateTime date)
        {
            TimeSpan days = date - DateTime.Today;

            return (int)days.Days;
        }

    }
}
