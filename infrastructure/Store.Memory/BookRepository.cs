namespace Store.Memory {
    public class BookRepository : IBookRepository {

        private readonly Book[] books = new[] {
            new Book(1, "ISBN 0-1234-5678-7", "D. Knuth", "Art of Programming"),
            new Book(2, "ISBN 0-1234-5678-8", "M. Fowler", "Refactoring"),
            new Book(3, "ISBN 0-1234-5678-9", "B. Kernighan, D. Ritchie", "C Programming Language"),
        };

/*        public Book[] GetAllByTitle(string titlePart) {
            return books.Where(i => i.Title.Contains(titlePart)).ToArray();
        }*/

        public Book[] GetAllByIsbn(string isbn) {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query) {
            return books.Where(book => book.Title.Contains(query) 
                                    || book.Author.Contains(query))
                        .ToArray();
        }
    }
}