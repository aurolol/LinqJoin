using LinqJoin;

var authorList = new List<Author>();

authorList.Add(new Author { AuthorID = 1, Name = "Orhan Pamuk" });
authorList.Add(new Author { AuthorID = 2, Name = "Elif Şafak" });
authorList.Add(new Author { AuthorID = 3, Name = "Ahmet Ümit" });

var bookList = new List<Book>();

bookList.Add(new Book { BookID = 1, Title = "Kar", AuthorID = 1 });
bookList.Add(new Book { BookID = 2, Title = "İstanbul", AuthorID = 1 });
bookList.Add(new Book { BookID = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorID = 2 });
bookList.Add(new Book { BookID = 4, Title = "Beyoğlu Rapsodisi", AuthorID = 3 });

var bookAndAuthor = from author in authorList
                    join book in bookList on author.AuthorID equals book.AuthorID
                    select new
                    {
                        BookTitle = book.Title,
                        AuthorName = author.Name,
                    };

foreach (var item in bookAndAuthor)
{
    Console.WriteLine($"Yazarın adı -> {item.AuthorName}" +
                      $"\nKitap Başlığı -> {item.BookTitle}");
}