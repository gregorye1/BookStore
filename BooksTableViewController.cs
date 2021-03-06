using Foundation;
using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using UIKit;

namespace BookStore
{
    public partial class BooksTableViewController : UITableViewController
    {
        List<Book> bookList;
        public BooksTableViewController (IntPtr handle) : base (handle)
        {
            bookList = new List<Book>();

            bookList.Add(new Book()
            {
                Author = "J.K Rowling",
                Name = "Harry Potter and the Sorcerer's Stone",
                Publisher = "Bloomsbury",
                Year = 1997
                    
            });
			bookList.Add(new Book()
			{
				Author = "J.K Rowling",
				Name = "Harry Potter and the Chamber of Secrets",
				Publisher = "Bloomsbury",
				Year = 1998
                    
			});
			bookList.Add(new Book()
			{
				Author = "J.K Rowling",
				Name = "Harry Potter and the Prisoner of Azkaban",
				Publisher = "Bloomsbury",
				Year = 1999
                    
			});
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return bookList.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("Book") as BookTableViewCell;

            var data = bookList[indexPath.Row];

            cell.BookData = data;

            return cell;
        }
    }

    public class Book
    {
        public string Name;
        public string Author;
        public string Publisher;
        public int Year;
    }
}