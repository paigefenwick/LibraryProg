using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    public class LibraryBook
    {
        
        //backing fields 
        private string _title;
        private string _author;
        private string _publisher;
        private int _copyright;
        private string _callnumber;
        private bool isCheckedOut = false;

        //constructor
        public LibraryBook(string T, string A, string P, int CR, string CP)
        {
            SetBook(T, A, P, CR, CP);
        }

        //Precondition: constructor
        //Postcondition: this method sets the constructors to their property
        public void SetBook(string T, string A, string P, int CR, string CP)
        {
            Title = T;
            Author = A;
            Publisher = P;
            CopyRight = CR;
            CallNumber = CP;

        }

        //Title property
        public string Title
        {
            get
            {
                return _title;
            }
            private set
            {
                _title = value;
            }
        }

        //Author property
        public string Author
        {
            get
            {
                return _author;
            }
            private set
            {
                _author =value;
            }
        }

        //Publisher property
        public string Publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
            }
        }

        //Copyright property
        public int CopyRight
        {
            get
            {
                return _copyright;
            }
            private set
            {
                _copyright = value;
            }
        }

        //Callnumber property
        public string CallNumber
        {
            get
            {
                return _callnumber;
            }
            set
            {
                _callnumber = value;
            }
        }

        //Precondition: checkedout=true
        //Postcondition: if the book is checked out, this will display true 
        public void CheckOut()
        {
            isCheckedOut = true;
        }

        //Precondition: checkedout=false
        //Postcondition: if the book is on the shelf, then false will be displayed
        public void ReturnToShelf()
        {
            isCheckedOut=false;
        }

        //Precondition: checkedout=false
        //Postcondition: returns false as the checkedout value
        public bool IsCheckedOut()
        {
            return isCheckedOut;
        }

        //Precondition: none
        //Postcondition: display the details of the added 
        //book to a message box using the below format
        public override string ToString()
        {
            string details;

            details = "Title:" + Title.ToString() + System.Environment.NewLine
                + "Author:" + Author.ToString() + System.Environment.NewLine
                + "Publisher:" + Publisher.ToString() + System.Environment.NewLine
                + "Copyright:" + CopyRight.ToString("D4") + System.Environment.NewLine
                + "Call Number:" + CallNumber.ToString() + System.Environment.NewLine
                + "Check out Status:" + this.IsCheckedOut() + System.Environment.NewLine;

            return details;
        }

    }
}
