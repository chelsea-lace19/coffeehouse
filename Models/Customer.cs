using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11._2.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNum { get; set; }

        public int GetDays(DateTime BirthDate)
        {
            DateTime today = DateTime.Today;
            DateTime bday = new DateTime(today.Year, BirthDate.Month, BirthDate.Day);

            if (bday < today)
            {
                bday = bday.AddYears(1);
            }
            int numDays = (bday-today).Days;
            return numDays;
        }

    }
}
