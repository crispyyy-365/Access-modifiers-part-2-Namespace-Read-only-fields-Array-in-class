namespace Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("The Sign of Four","Conan Doyle");
            Book book2 = new Book("1984", "George Orwell");
            Book book3 = new Book("Mein Kampf", "Adolf Hitler");

            book.GetInfo();
            book2.GetInfo();
            book3.GetInfo();

            BookLibrary.AddBook(book);
            BookLibrary.AddBook(book2);
            BookLibrary.AddBook(book3);

            BookLibrary.RemoveBook(book);
            BookLibrary.RemoveBook(book2);
            BookLibrary.RemoveBook(book3);

            BookLibrary.BorrowBook(book);
            BookLibrary.BorrowBook(book2);
            BookLibrary.BorrowBook(book3);

        }
    }
}
