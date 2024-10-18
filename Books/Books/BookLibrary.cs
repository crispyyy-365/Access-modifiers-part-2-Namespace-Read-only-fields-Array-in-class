using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class BookLibrary
    {
        Book[] _books = new Book[0];
        public void AddBook(Book book)
        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = book;
        }
        public void RemoveBook(Book book)
        {
            Book[] _newBooks = new Book[0];

            for(int i =  0; i < _books.Length; i++)
            {
                if (_books[i] != book)
                {
                    Array.Resize(ref _newBooks, _newBooks.Length + 1);
                    _newBooks[_newBooks.Length - 1] = _books[i];
                }
            }
        }
        public void ShowAll()
        {
            for (int i =  0; i < _books.Length; ++i)
            {
                Console.WriteLine(_books[i]);
            }
        }
        public bool BorrowBook(Book book)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].Name != book.Name)
                {
                    book.IsAveliable = false;
                    return book.IsAveliable;
                }
            }
            return book.IsAveliable;
        }
    }
}
