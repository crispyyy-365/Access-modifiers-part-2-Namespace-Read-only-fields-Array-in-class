using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class Book : BookLibrary
    {
        private string _name;
        private string _author;
        private bool _isAveliable = true;

        public Book(string name, string author)
        {
            _name = name;
            _author = author;
        }
        public Book(string name, string author, bool isAveliable)
        {
            _name = name;
            _author = author;
            _isAveliable = isAveliable;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public bool IsAveliable
        {
            get { return _isAveliable; }
            set { _isAveliable = value; }
        }
        public void GetInfo()
        {
                Console.WriteLine($"Name : {Name} , Author : {Author} , Aveliable : {IsAveliable}");
        }
    }
}
