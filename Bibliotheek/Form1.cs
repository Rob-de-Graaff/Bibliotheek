using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheek
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Book> books;
        private List<string> lentBooksList;
        private List<string> returnedBooksList;
        private double _fineTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set dates, listboxes

            books = new Dictionary<int, Book>();
            lentBooksList = new List<string>();
            returnedBooksList = new List<string>();

            books.Add(1, new Book("", "Pride and Prejudice", "roman", 0, 0, 0, 0, Convert.ToDateTime("1/1/1"), Convert.ToDateTime("1/1/1")));
            books.Add(2, new Book("", "Programmeren in c#", "studieboek", 0, 0, 0, 0, Convert.ToDateTime("1/1/1"), Convert.ToDateTime("1/1/1")));

            // Sets booknumber, lentdayslimit
            foreach(KeyValuePair<int, Book> entry in books)
            {
                //sets book number "genre +serial number", lentdayslimit, fine
                switch (entry.Value.Genre)
                {
                    case "roman":
                        entry.Value.BookNumber = 9.ToString("00");
                        entry.Value.LentDaysLimit = 21;
                        entry.Value.Fine = 0.25;
                        break;
                    case "studieboek":
                        Random random = new Random();
                        do
                        {
                            entry.Value.BookNumber = random.Next(0, 100).ToString("00");
                        } while (entry.Value.BookNumber == "09");
                        entry.Value.LentDaysLimit = 30;
                        entry.Value.Fine = 1;
                        break;
                }
                entry.Value.BookNumber += entry.Key.ToString("00");
            }

            // Displays name property
            listBoxBooks.DataSource = books.Values.ToList();
            listBoxBooks.DisplayMember = "Value.ToString()";

            // Fills numericupdowns
            foreach (NumericUpDown control in panelYear.Controls)
            {
                control.Maximum = DateTime.Today.Year + 1;
                control.Minimum = DateTime.Today.Year;
                control.Value = DateTime.Today.Year;
            }

            foreach (NumericUpDown control in panelMonth.Controls)
            {
                control.Maximum = DateTime.Today.Month + 1;
                control.Minimum = DateTime.Today.Month;
                control.Value = DateTime.Today.Month;
            }

            foreach (NumericUpDown control in panelDay.Controls)
            {
                control.Maximum = DateTime.Today.Day + 7;
                //control.Minimum = DateTime.Today.Day;
                control.Value = DateTime.Today.Day;
            }

            // Displays calculation, total
            labelTicketsTotal.Text = $@"type*amount*fine+type*amount*fine";
            labelPriceTotal.Text = $@"Totaal: € {Math.Round(_fineTotal, 2):0.00},-";
        }

        private void ButtonAddBook_Click(object sender, EventArgs e)
        {
            //adds book to listbox, sets date today
            Book tempBook = (Book)listBoxBooks.SelectedItem;

            if (!lentBooksList.Contains(tempBook.ToString()))
            {
                tempBook.Amount = (int)numericUpDownAmount.Value;
                lentBooksList.Add(tempBook.ToString());
                tempBook.LoanDate = DateTime.Today;
            }

            // Displays properties
            listBoxLentBooks.DataSource = null;
            listBoxLentBooks.DataSource = lentBooksList;
            listBoxLentBooks.DisplayMember = "Value";
        }

        private void ButtonRemoveBook_Click(object sender, EventArgs e)
        {
            // removes book from listbox
            string tempBook = listBoxLentBooks.SelectedItem.ToString();

            lentBooksList.Remove(tempBook.ToString());

            // Displays properties
            listBoxLentBooks.DataSource = null;
            listBoxLentBooks.DataSource = lentBooksList;
            listBoxLentBooks.DisplayMember = "Value";
        }

        private void ButtonAddReturnedBook_Click(object sender, EventArgs e)
        {
           // Checks if listbox is empty and if the correct date is entered
            if (listBoxLentBooks.Items.Count > 0)
            {
                if (ValidateDate())
                {
                    string key = listBoxLentBooks.SelectedItem.ToString();
                    int indexStart = key.IndexOf("Title")-4;
                    int indexEnd = key.IndexOf("Title")-2;
                    int lenght = indexEnd - indexStart;
                    key = key.Substring(indexStart, lenght);

                    Book tempBook = books[Convert.ToInt32(key)];
                   
                    if (!returnedBooksList.Contains(tempBook.ToString()))
                    {
                        //tempBook.ReturnDate = new DateTime((int)numericUpDownYear1.Value,(int)numericUpDownMonth1.Value,(int)numericUpDownDay1.Value);
                        tempBook.ReturnDate =Convert.ToDateTime($"{(int)numericUpDownDay1.Value}/{(int)numericUpDownMonth1.Value}/{(int)numericUpDownYear1.Value}");
                        tempBook.TotalDays = (int)(tempBook.ReturnDate - tempBook.LoanDate).TotalDays;

                        returnedBooksList.Add(tempBook.ToString());
                    }

                    // Displays properties
                    listBoxReturnedBooks.DataSource = null;
                    listBoxReturnedBooks.DataSource = returnedBooksList;
                    listBoxReturnedBooks.DisplayMember = "Value";
                }
                else
                {
                    MessageBox.Show($@"Please select the correct day of the month");
                }
            }
            else
            {
                MessageBox.Show("There are no books lent");
            }
        }

        private void ButtonRemoveReturnedBook_Click(object sender, EventArgs e)
        {
            // removes book from listbox
            string tempBook = listBoxReturnedBooks.SelectedItem.ToString();

            returnedBooksList.Remove(tempBook);

            // Displays properties
            listBoxReturnedBooks.DataSource = null;
            listBoxReturnedBooks.DataSource = returnedBooksList;
            listBoxReturnedBooks.DisplayMember = "Value";
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            string genre1 = "none";
            string genre2 = "none";
            int amount1 = 0;
            int amount2 = 0;
            int days1 = 0;
            int days2 = 0;
            double fine1 = 0;
            double fine2 = 0;

            foreach (string book in returnedBooksList)
            {
                string key = book;
                int indexStart = key.IndexOf("Title")-4;
                int indexEnd = key.IndexOf("Title")-2;
                int lenght = indexEnd - indexStart;
                key = key.Substring(indexStart, lenght);
                string genre = book;
                indexStart = genre.IndexOf("Title")-6;
                indexEnd = genre.IndexOf("Title")-4;
                lenght = indexEnd - indexStart;
                genre = genre.Substring(indexStart, lenght);
                Book tempBook = books[Convert.ToInt32(key)];

                switch (Convert.ToInt32(genre))
                {
                    case 9:
                        genre1 = "romance";
                        amount1 = tempBook.Amount;
                        days1 = tempBook.TotalDays;
                        fine1 = tempBook.Fine;
                        if (tempBook.TotalDays > 21)
                        {
                            days1 = tempBook.TotalDays - 21;
                            //fine1 = days1*tempBook.Fine;
                        }
                        break;
                    case int k when (k != 9):
                        genre2 = "study book";
                        amount2 = tempBook.Amount;
                        days2 = tempBook.TotalDays;
                        fine2 = tempBook.Fine;
                        if (tempBook.TotalDays > 30)
                        {
                            days2 = (tempBook.TotalDays - 30) / 7;
                            //fine2 = Math.Ceiling((double)days2)*fine2;
                        }
                        break;
                }
            }

            _fineTotal = amount1 * (days1 * fine1) + amount2 * (Math.Ceiling((double)days2)*fine2);

            // Displays calculation, total
            labelTicketsTotal.Text = $@"type: {genre1}, amount {amount1}* (days {days1}* fine € {fine1})+ type: {genre2}, amount {amount2}* (days {days2}* fine € {fine2})";
            labelPriceTotal.Text = $@"Totaal: € {Math.Round(_fineTotal, 2):0.00},-";
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            numericUpDownAmount.Value = 1;
            listBoxLentBooks.DataSource = null;
            listBoxReturnedBooks.DataSource = null;
            lentBooksList.Clear();
            returnedBooksList.Clear();
            _fineTotal = 0;

            // Fills numericupdowns
            foreach (NumericUpDown control in panelYear.Controls)
            {
                control.Maximum = DateTime.Today.Year + 1;
                control.Minimum = DateTime.Today.Year;
                control.Value = DateTime.Today.Year;
            }

            foreach (NumericUpDown control in panelMonth.Controls)
            {
                control.Maximum = DateTime.Today.Month + 1;
                control.Minimum = DateTime.Today.Month;
                control.Value = DateTime.Today.Month;
            }

            foreach (NumericUpDown control in panelDay.Controls)
            {
                control.Maximum = DateTime.Today.Day + 7;
                //control.Minimum = DateTime.Today.Day;
                control.Value = DateTime.Today.Day;
            }

            labelTicketsTotal.Text = $@"type: none, amount {0}* fine € {0}+ type: none, amount {0}* fine € {0}";
        }

        private bool ValidateDate()
        {
            int checkDay = DateTime.DaysInMonth((int)numericUpDownYear1.Value, (int)numericUpDownMonth1.Value);

            if ((int)numericUpDownDay1.Value <= checkDay)
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
