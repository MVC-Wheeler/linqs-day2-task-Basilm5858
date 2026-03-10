using System.Diagnostics;

namespace Linq_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Author> authors = new List<Author>()
            {
                new Author { Id = 1, Name = "Naguib Mahfouz" },
                new Author { Id = 2, Name = "Taha Hussein" },
                new Author { Id = 3, Name = "Ahmed Khaled Tawfik" },
                new Author { Id = 4, Name = "Youssef Ziedan" }
            };
            List<Book> books = new List<Book>()
            {
                new Book { Id = 1, Title = "Palace Walk", Pages = 420, AuthorId = 1 },
                new Book { Id = 2, Title = "Palace of Desire", Pages = 420, AuthorId = 1 },
                new Book { Id = 3, Title = "The Days", Pages = 300, AuthorId = 2 },
                new Book { Id = 4, Title = "Season of Migration", Pages = 250, AuthorId = 2 },
                new Book { Id = 5, Title = "Utopia", Pages = 210, AuthorId = 3 },
                new Book { Id = 6, Title = "The Legend of Dracula", Pages = 180, AuthorId = 3 },
                new Book { Id = 7, Title = "Azazeel", Pages = 350, AuthorId = 3 },
                new Book { Id = 8, Title = "Shadow of the Serpent", Pages = 270, AuthorId = 4 }
            };


            //var q1 = books.Where(x => x.Pages > 300).ToList();
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}




            //var q2 = books.Where(x => x.AuthorId == 1).ToList();
            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}


            //var q3 = books.Where(x => x.Pages > 200 && x.Pages < 350).ToList();
            //foreach (var item in q3)
            //{
            //    Console.WriteLine(item);
            //}

            //var q4 = books.Where(x => x.Title.StartsWith("P")).ToList();
            //foreach (var item in q4)
            //{
            //    Console.WriteLine(item);
            //}

            //var q5 = books.Select(x => x.Title).ToList();
            //foreach (var item in q5)
            //{
            //    Console.WriteLine(item);
            //}


            //var q7 = authors.Select(x => x.Name).ToList();
            //foreach (var item in q7)
            //{
            //    Console.WriteLine(item);
            //}

            //var q8 = books.Where(x => x.Pages > 300).FirstOrDefault();
            //Console.WriteLine(q8);

            //var q9 = books.Where(x => x.AuthorId == 2).FirstOrDefault();
            //Console.WriteLine(q9);

            //var q10 = authors.Where(x => x.Id == 3).Single();
            //Console.WriteLine(q10);

            //var q11 = books.Where(x => x.Title == "Utopia").Single();
            //Console.WriteLine(q11);

            //var q12 = books.OrderBy(x => x.Pages).ToList();
            //foreach(var item in q12)
            //{
            //    Console.WriteLine(item);
            //}

            //var q13 = books.OrderByDescending(x => x.Title).ToList();
            //foreach (var item in q13)
            //{
            //    Console.WriteLine(item);
            //}

            //var q14 = books.OrderBy(x => x.AuthorId).ThenBy(x => x.Pages).ToList();
            //foreach (var item in q14)
            //{
            //    Console.WriteLine(item);
            //}

            //var q15 = books.Count();
            //Console.WriteLine(q15);

            //var q16 = books.Average(x => x.Pages);
            //Console.WriteLine(q16);

            //var q17 = books.Max(x => x.Pages);
            //Console.WriteLine(q17);

            //var q18 = books.Any(x => x.Pages > 300);
            //Console.WriteLine(q18);

            //var q19 = books.All(x => x.Pages > 100);
            //Console.WriteLine(q19);

            //List<string> bookTitles = new List<string>()
            //{
            //    "Palace Walk",
            //    "Palace of Desire",
            //    "The Days",
            //    "Season of Migration",
            //    "Utopia",
            //    "The Legend of Dracula",
            //    "Azazeel",
            //    "Shadow of the Serpent"
            //};

            //var q20 = bookTitles.Where(x => x.Contains("Utopia")).ToList();
            //foreach (var item in q20)
            //{
            //    Console.WriteLine(item);
            //}

            //var q21 = from b in books
            //          join a in authors
            //          on b.AuthorId equals a.Id
            //          select new
            //          {
            //              b.Title,
            //              a.Name
            //          };
            //foreach( var item in q21)
            //{
            //    Console.WriteLine(item);
            //}

            //var q22 = from b in books
            //          join a in authors
            //          on b.AuthorId equals a.Id
            //          select new
            //          {
            //              b.Title,
            //              a.Name,
            //              b.Pages
            //          };
            //foreach (var item in q22)
            //{
            //    Console.WriteLine(item);
            //}

            //var q23 = books.GroupBy(x => x.AuthorId).ToList();
            //foreach(var item in q23)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach(var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //    Console.WriteLine("================================");
            //}

            //var q24 = authors.GroupJoin(books,
            //    a => a.Id,
            //    b => b.AuthorId,
            //    (a, b) => new
            //    {
            //        AuthorName = a.Name,
            //        Books = b
            //    }).ToList();

            //foreach (var book in q24)
            //{
            //    Console.WriteLine($"Author: {book.AuthorName}");
            //    foreach (var item in book.Books)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine("================================");
            //}

            //var q25 = books.Take(3).ToList();
            //foreach (var item in q25)
            //{
            //    Console.WriteLine(item);
            //}

            //var q26 = books.Skip(2).Take(8).ToList();
            //foreach (var item in q26)
            //{
            //    Console.WriteLine(item);
            //}

            //var q27 = books.Skip(3).Take(2).ToList();
            //foreach (var item in q27)
            //{
            //    Console.WriteLine(item);
            //}

            //var q28 = books.TakeWhile(x => x.Pages < 300).ToList();
            //foreach (var item in q28)
            //{
            //    Console.WriteLine(item);
            //}

            //var q29 = books.SkipWhile(x => x.Pages < 250).ToList();
            //foreach (var item in q29)
            //{
            //    Console.WriteLine(item);
            //}

            //var q30 = books.Chunk(2);
            //foreach (var item in q30)
            //{
            //    Console.WriteLine("Chunk:");
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //    Console.WriteLine("===============================");
            //}


            //var q31 = books.Select(x => x.AuthorId).Distinct();
            //foreach (var item in q31)
            //{
            //    Console.WriteLine(item);
            //}

            //List<string> titles = new List<string>()
            //{
            //    "Palace Walk",
            //    "Palace of Desire",
            //    "The Days",
            //    "Season of Migration",
            //    "Utopia",
            //    "The Legend of Dracula",
            //    "Azazeel",
            //    "Shadow of the Serpent"
            //};
            //List<string> titles2 = new List<string>()
            //{
            //    "Messi Palace Walk",
            //    "Basil Palace of Desire",
            //    "The Days Old",
            //    "Season of Migration",
            //    "Utopia",
            //    "The Legend of Dracula",
            //};

            //var q32 = (titles.ToList()).Union(titles2.ToList());
            //foreach (var title in q32)
            //{
            //    Console.WriteLine(title);
            //}

            //List<string> titles = new List<string>()
            //{
            //    "Palace Walk",
            //    "Palace of Desire",
            //    "The Days",
            //    "Season of Migration",
            //    "Utopia",
            //    "The Legend of Dracula",
            //    "Azazeel",
            //    "Shadow of the Serpent"
            //};
            //List<string> titles2 = new List<string>()
            //{
            //    "Messi Palace Walk",
            //    "Basil Palace of Desire",
            //    "The Days Old",
            //    "Season of Migration",
            //    "Utopia",
            //    "The Legend of Dracula",
            //};

            //var q33 = (titles.ToList()).Intersect(titles2.ToList());
            //foreach (var title in q33)
            //{
            //    Console.WriteLine(title);
            //}

            //List<string> titles = new List<string>()
            //{
            //    "Palace Walk",
            //    "Palace of Desire",
            //    "The Days",
            //    "Season of Migration",
            //    "Utopia",
            //    "The Legend of Dracula",
            //    "Azazeel",
            //    "Shadow of the Serpent"
            //};
            //List<string> titles2 = new List<string>()
            //{
            //    "Messi Palace Walk",
            //    "Basil Palace of Desire",
            //    "The Days Old",
            //    "Season of Migration",
            //    "Utopia",
            //    "The Legend of Dracula",
            //};

            //var q34 = (titles.ToList()).Except(titles2.ToList());
            //foreach (var title in q34)
            //{
            //    Console.WriteLine(title);
            //}
        }
    }
}
