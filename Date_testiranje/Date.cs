using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProject
{
    public class Date
    {
        private int mDay;
        private int mMonth;
        private int mYear;

        public Date(int year, int month, int day)
        {
            _validate(year, month, day);
            mDay = day;
            mMonth = month;
            mYear = year;
        }

        // staticke metode, neovisne o instanci
        public static void _validate(int year, int month, int day)
        {
            // ne treba za null, jer je int
            if (year < 0 || year > 2999) throw new InvalidProgramException("Wrong year range");
            if (month < 1 || month > 12) throw new InvalidProgramException("Wrong month range");

            if (month == 2)
            {
                if (isLeapYear(year))
                {
                    if (day < 1 || day > 29) throw new InvalidProgramException("Wrong day range");
                }
                else
                {
                    if (day < 1 || day > 28) throw new InvalidProgramException("Wrong day range");
                }
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day < 1 || day > 31) throw new InvalidProgramException("Wrong day range");
            }
            else
            {
                if (day < 1 || day > 30) throw new InvalidProgramException("Wrong day range");
            }
        }

        public static Boolean isLeapYear(int year)
        {
            if (year % 4 != 0) return false;
            else if (year % 100 != 0) return true;
            else if (year % 400 != 0) return false;
            else return true;
        }

        // metode objekta
        public String getMonthName() 
        {
            return System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mMonth);
        }
        public int getNumberOfRemaingDaysInMonth()
        {
            if (mMonth == 2)
            {
                if (isLeapYear(mYear))
                {
                    return 29 - mDay;
                }
                else
                {
                    return 28 - mDay;
                }
            }
            else if (mMonth == 1 || mMonth == 3 || mMonth == 5 || mMonth == 7 || mMonth == 8 || mMonth == 10 || mMonth == 12)
            {
                return 31 - mDay;
            }
            else
            {
                return 30 - mDay;
            }
        }
    }
}
