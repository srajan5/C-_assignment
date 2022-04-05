using System;

public enum BookType
{
    Magazine = 1,
    Novel = 2,
    ReferenceBook = 3,
    Miscellaneous = 4,
}

public struct Books
{
    int bookId;
    string title;
    int    Price;
    BookType BookType;

    public int BookId
    {
        get { return bookId; } 
        set { bookId = value; } 
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public int price
    {
        get { return price; }
        set { price = value; }  
    }

    public BookType bookType
    {
        get { return bookType; }
        set { bookType = value; }
    }

    public static void display_details(Books bk)
    {

        Console.WriteLine("The id of the book is {0}",bk.bookId);
        Console.WriteLine("The title of the book is {0}",bk.title);
        Console.WriteLine("The price of the book is {0}",bk.Price);
        string type = getbooktype(bk.BookType);
        Console.WriteLine("The title of the book is {0}",type);
    }

    public static string getbooktype(BookType bookType)
    {
        switch(bookType)
        {
            case BookType.Magazine:
                return "Magazine";
                case BookType.Novel:
                return "Novel";
            case BookType.ReferenceBook:
                return "ReferenceBook";
            case BookType.Miscellaneous:
                return "Miscellaneous";
                default:
                return "Invalid choice";
        }
    }

    public class Book
    {

        public static void Main()
        {
            Console.WriteLine("Please enter the book_id");
            int id =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the book_title");
            string title = Console.ReadLine();
            Console.WriteLine("Please enter the book_price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please select the book_type - 1 for Magazine,2 for Novel,3 for ReferenceBook, 4 for Miscellaneous");
            string type = Console.ReadLine();


            Books b = new Books();
            b.bookId = id;
            b.title = title;
            b.Price = price;
            b.BookType = (BookType)Enum.Parse(typeof(BookType), type);

            Books.display_details(b);


        }
       

    }
    



}
