using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCounter
{
    class Model
    {
        int days;
        public Model() { }
        public void Load (string birthdayDate)
        {
            string currentYear = DateTime.Now.Date.Year.ToString();
            DateTime date1 = DateTime.Parse(birthdayDate+"."+currentYear);
            DateTime date2 = DateTime.Now.Date;
            if (date2 > date1)
            {
                currentYear = (int.Parse(currentYear) + 1).ToString();
                date1 = DateTime.Parse(birthdayDate + "." + currentYear);
            }
            days = (date1 -date2).Days;
        }
        public string Message { get { return $"Ваш день рождения через {days} дней."; } }
    }
}
