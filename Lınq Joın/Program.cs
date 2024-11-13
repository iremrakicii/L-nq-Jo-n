using Lınq_Joın;

class Program
{
    static void Main(string[] args)
    {
        List<Books> books = new List<Books>();
        books.Add(new Books { BookId = 1, Title = "Bir Genç Kızın Günlüğü", AuthorId = 9 });
        books.Add(new Books { BookId = 2, Title = "Şeker portakalı", AuthorId = 4 });
        books.Add(new Books { BookId = 3, Title = "Seyir", AuthorId = 21 });
        books.Add(new Books { BookId = 4, Title = "Kürk Mantolu Madonna", AuthorId = 13 });

        List<Authors> authors = new List<Authors>();
        authors.Add(new Authors { AuthorName = "İpek Ongun", AuthorId = 9 });
        authors.Add(new Authors { AuthorName = "Sabahattin Ali", AuthorId = 13 });
        authors.Add(new Authors { AuthorName = "Piraye", AuthorId = 21 });

        var booksAuthors = books.Join(authors,
                              book => book.AuthorId,
                              author => author.AuthorId,
                              (book, author) => new
                              {
                                  BookTitle = book.Title,
                                  AuthorsName = author.AuthorName

                              });

        foreach (var book in booksAuthors)
        {
            Console.WriteLine($"Kitabın başlığı:{book.BookTitle}, Yazarın adı: {book.AuthorsName}");
        }

    }
}
