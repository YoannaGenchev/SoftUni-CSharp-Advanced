﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
            this.books.Sort(new BookComparator());
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex = -1;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.books = new List<Book>(books);
            }

            public void Dispose() { }
            public bool MoveNext()
            {
                this.currentIndex++;
                return this.currentIndex < this.books.Count;
            }
            public void Reset()
            {
                this.currentIndex = -1;
            }
            public Book Current => this.books[this.currentIndex];
            object IEnumerator.Current => Current;
        }
    }
}
