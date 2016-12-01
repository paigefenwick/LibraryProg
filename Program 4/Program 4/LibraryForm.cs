//Paige Fenwick
//CIS 199-75
//Program 4
//8 December 2014
//To create a form using two seperate classes. The first class establishes backing fields, constructor with 5 parameters
//which each have their own properties. Then there are three methods which return true or false whether or not the book is checked out or not.
//Finally there is a tostring method which displays the output according to instructor instructions. The second class is the form class, which
//is made up a list box, 5 textboxes and 4 buttons. To start, the list is created to hold the Books to be added. Then the first button
//event handler is created to add the book information to the list. The final three event handlers display the details of the book, change the 
//status of the book to checked out and change the status of the book to returned, respectfully. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    public partial class program4 : Form
    {
        //library book list to hold added books
        List<LibraryBook> Books = new List<LibraryBook>();

        public program4()
        {
            InitializeComponent();
        }

        //Precondition: title!="",author!="",publisher!="",copyright>0,callnumber!=""
        //Postcondition: if the above conditions are meet, a new library book object is created.
        //then it is added to the list box with the title added to display the title in the list.
        //if the criteria was not meet, an error message displayed. The textboxes were then cleared.
        private void addBttn_Click(object sender, EventArgs e)
        {
            int copyright;
            if (titleTxt.Text != "" && authorTxt.Text != "" && publisherTxt.Text != "" && int.TryParse(copyrightTxt.Text, out copyright) &&
                callnumTxt.Text != "")
            {
                LibraryBook book = new LibraryBook(titleTxt.Text, authorTxt.Text, publisherTxt.Text, copyright, callnumTxt.Text);
                Books.Add(book);
                BookList.Items.Add(titleTxt.Text);
            }
            else
            {
                MessageBox.Show("Invalid input");
            }

            titleTxt.Clear();
            authorTxt.Clear();
            publisherTxt.Clear();
            copyrightTxt.Clear();
            callnumTxt.Clear();
        }
        //Precondition: selectedindex!=-1
        //Postcondition: if no items were selected, an error message would be displayed.
        //however if an item was selected, the book object was passed to the ToString method 
        //then displayed according to the ToString.
        private void detailsBttn_Click(object sender, EventArgs e)
        {
            if (BookList.SelectedIndex == -1)
            {
                MessageBox.Show("No item selected");
            }
            else
            {
                MessageBox.Show(Books[BookList.SelectedIndex].ToString(),"Results");
            }
        }
        //Precondition: selectedindex!=-1
        //Postcondition: if there were no items selected, an error message would display.
        //if an item was selected then it would reference the checkout method and change the value to true.
        private void checkOutBttn_Click(object sender, EventArgs e)
        {
            if (BookList.SelectedIndex == -1)
            {
                MessageBox.Show("No item selected");
            }
            else
            {
                Books[BookList.SelectedIndex].CheckOut();
            }
        }
        //Precondition: selectedindex!=-1
        //Postcondition: if there was no item selected, then an error message would display.
        //if an item was selected, the object would reference the returntoshelf method, returning the false value.
        private void returnBttn_Click(object sender, EventArgs e)
        {
            if (BookList.SelectedIndex==-1)
            {
                MessageBox.Show("No item selected");
            }
            else 
            {
                Books[BookList.SelectedIndex].ReturnToShelf();
            }
        }
    
    }



        
   
}

