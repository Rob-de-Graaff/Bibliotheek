using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek
{
    class Book
    {
        private string bookNumber;
        private string title;
        private string genre;
        private int lentDaysLimit;
        private int totalDays;
        private int amount;
        private double fine;
        private DateTime loanDate;
        private DateTime returnDate;

        public Book(string bookNumber, string title, string genre, int lentDaysLimit, int totalDays, int amount, double fine, DateTime loanDate,
            DateTime returnDate)
        {
            this.bookNumber = bookNumber;
            this.title = title;
            this.genre = genre;
            this.lentDaysLimit = lentDaysLimit;
            this.totalDays = totalDays;
            this.amount = amount;
            this.fine = fine;
            this.loanDate = loanDate;
            this.returnDate = returnDate;
        }

        public override string ToString()
        {
            return $"Booknumber:{bookNumber}, Title:{title}, Genre:{genre}, Amount:{amount}";
        }

        public string BookNumber
        {
            get { return bookNumber; }
            set { bookNumber = value; }
        }

        public string Title
        {
            get { return title; }
        }

        public string Genre
        {
            get { return genre; }
        }

        public int LentDaysLimit
        {
            get { return lentDaysLimit; }
            set { lentDaysLimit = value; }
        }

        public int TotalDays
        {
            get { return totalDays; }
            set { totalDays = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public double Fine
        {
            get { return fine; }
            set { fine = value; }
        }

        public DateTime LoanDate
        {
            get { return loanDate; }
            set { loanDate = value; }
        }

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
    }
}
