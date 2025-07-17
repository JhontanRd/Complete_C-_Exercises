using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SisGen_Eventos
{
    public class Authenticator
    {
        public DateTime GenerateDate(string date, string hour)
        {
            string fullDateTime = $"{date} {hour}";
            string toGenerate = fullDateTime.Replace('/', ' ').Replace(':', ' ');
            string[] toDate = toGenerate.Split(' ');
            DateTime dateT = new DateTime(Convert.ToInt32(toDate[2]), Convert.ToInt32(toDate[1]), Convert.ToInt32(toDate[0]), Convert.ToInt32(toDate[3]), Convert.ToInt32(toDate[4]), 00);
            return dateT;
        }

        public DateTime GenerateDate(string date)
        {
            string[] toDate = date.Split(' ');
            DateTime dateT = new DateTime(Convert.ToInt32(toDate[2]), Convert.ToInt32(toDate[1]), Convert.ToInt32(toDate[0]), Convert.ToInt32(toDate[3]), Convert.ToInt32(toDate[4]), 00);
            return dateT;
        }


        public bool FormatfForDateTime(string date, string hour) 
        {
            string dateTimeTest = $"{date} {hour}";
            Regex isVallidDate = new Regex(@"^\d{2}\/\d{2}\/\d{4}\s\d{2}\:\d{2}$");
            return (isVallidDate.Match(dateTimeTest).Success) ? true : false;
        }

        public bool IsVallidsValues(string date, string hour)
        {
            string newDateTime = this.Replacement(date, hour);
            string[] valuesOfDate = newDateTime.Split(' ');
            DateTime year = DateTime.UtcNow;
            bool nextStep = false;
            if (!string.IsNullOrWhiteSpace(date) || !string.IsNullOrEmpty(date) || !string.IsNullOrWhiteSpace(hour) || !String.IsNullOrEmpty(hour))
            {
                if (Convert.ToInt32(valuesOfDate[0]) >= 1 && Convert.ToInt32(valuesOfDate[0]) <= 31 &&
                Convert.ToInt32(valuesOfDate[1]) >= 1 && Convert.ToInt32(valuesOfDate[1]) <= 12 &&
                Convert.ToInt32(valuesOfDate[2]) >= year.Year && Convert.ToInt32(valuesOfDate[2]) <= 3000 &&
                Convert.ToInt32(valuesOfDate[3]) >= 0 && Convert.ToInt32(valuesOfDate[3]) <= 24 &&
                Convert.ToInt32(valuesOfDate[4]) >= 0 && Convert.ToInt32(valuesOfDate[4]) <= 60)
                {
                    nextStep = true;
                }
            }
            return nextStep;
        }

        public string Replacement(string date, string hour)
        {
            string dateTimeTest = $"{date} {hour}";
            string newDateTime = null;
            for(int i = 0; i < dateTimeTest.Length; i++)
            {
                if ((char.IsDigit(dateTimeTest[i])))
                {
                    newDateTime += dateTimeTest[i];
                }
                else
                {
                    newDateTime += " ";
                }
            }
            return newDateTime;
        }

        public bool IsItPossible(DateTime startDate, DateTime? endDate)
        {
            return (endDate <= startDate);
        }
        
    }
}
