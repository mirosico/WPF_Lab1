using System;

namespace Lab1_Mysko.Models
{
    public class PickDataModel
    {
        public PickDataModel()
        {
        }

        public string CalculateAge(DateTime date)
        {
            TimeSpan timeSpan = DateTime.Now - date;
            int substr = timeSpan.Days;
            if (substr <= 0)
                throw new ArgumentException();
            int years = substr / 365;
            int months = (12 - date.Month + DateTime.Now.Month) % 12;
            int days = Math.Abs(DateTime.Now.Day - date.Day);
            if (years > 135)
                throw new ArgumentException();

            return days + " days, " + months + " months, " + years + " years";
        }
        public string IsBirthday(DateTime date)
        {
            if (date.Month == DateTime.Today.Month && date.Day == DateTime.Today.Day)
                return "Happy Birthday!Let your all the dreams to be on fire and light your birthday candles with that. \nHave a gorgeous birthday";
            return "Days left until your birthday: " + DayToBirthday(date).ToString();
        }
        private int DayToBirthday(DateTime date)
        {
            int days = DateTime.Today.DayOfYear - date.DayOfYear;
            if (days > 0)
            {
                days = DateTime.MaxValue.DayOfYear - DateTime.Today.DayOfYear + date.DayOfYear;
            }
            return Math.Abs(days);
        }
        public string CalculateChineseSign(DateTime date)
        {
            int year = date.Year;
            int chinese = (year - 4) % 12;
            switch (chinese)
            {
                case 0:
                    return "Rat";
                case 1:
                    return "Ox";
                case 2:
                    return "Tiger";
                case 3:
                    return "Rabbit";
                case 4:
                    return "Dragon";
                case 5:
                    return "Snake";
                case 6:
                    return "Horse";
                case 7:
                    return "Goat";
                case 8:
                    return "Monkey";
                case 9:
                    return "Rooster";
                case 10:
                    return "Dog";
                case 11:
                    return "Pig";
                default:
                    throw new ArgumentException("Inappropriate format of year!");
            }
        }
        public string CalculateWesternSign(DateTime date)
        {
            int day = date.Day;
            switch (date.Month)
            {
                case 1:
                    return day < 21 ? "Capricorn" : "Aquarius";
                case 2:
                    return day < 20 ? "Aquarius" : "Pisces";
                case 3:
                    return day < 21 ? "Pisces" : "Aries";
                case 4:
                    return day < 21 ? "Aries" : "Taurus";
                case 5:
                    return day < 21 ? "Taurus" : "Gemini";
                case 6:
                    return day < 21 ? "Gemini" : "Cancer";
                case 7:
                    return day < 22 ? "Cancer" : "Leo";
                case 8:
                    return day < 22 ? "Leo" : "Virgo";
                case 9:
                    return day < 22 ? "Virgo" : "Libra";
                case 10:
                    return day < 22 ? "Libra" : "Scorpio";
                case 11:
                    return day < 22 ? "Scorpio" : "Sagittarius";
                case 12:
                    return day < 22 ? "Sagittarius" : "Capricorn";
                default:
                    throw new ArgumentException("Inappropriate format of month !");
            }
        }
    }
}