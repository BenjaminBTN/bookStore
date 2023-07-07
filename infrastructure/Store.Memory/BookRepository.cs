namespace Store.Memory {
    public class BookRepository : IBookRepository {

        private readonly Book[] books = new[] {
            new Book(1, "ISBN 0-1234-5678-7", "D. Knuth", "Art of Programming", "Book #1", 7m),
            new Book(2, "ISBN 0-1234-5678-8", "M. Fowler", "Refactoring", "Book #2", 15m),
            new Book(3, "ISBN 0-1234-5678-9", "B. Kernighan, D. Ritchie", "C Programming Language", "Book #3", 17m),
        };

/*        public Book[] GetAllByTitle(string titlePart) {
            return books.Where(i => i.Title.Contains(titlePart)).ToArray();
        }*/

        public Book[] GetAllByIsbn(string isbn) {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query) {
            return books.Where(book => book.Title.Contains(query) || book.Author.Contains(query))
                        .ToArray();
        }

        public Book GetById(int id) {
            return books.Single(book => book.Id == id);
        }
    }
}