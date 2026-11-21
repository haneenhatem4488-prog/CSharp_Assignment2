using System;
using System.Text;
namespace Assignment2__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion
            #region Q02
            //string variable1 = "Clean Code";
            //string variable2 = "Clean Code";
            //if (object.ReferenceEquals(variable1, variable2))
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("not Equal");
            #endregion
            #region Q03
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb);
            #endregion
            #region Q04
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb);
            #endregion
            #region Q05
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine("Book:" + title + "," + "Pages:" + pages);
            #endregion
            #region Q06
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine($"Book:{title},Pages:{pages}");
            #endregion
            #region Q07
            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine(string.Format("Book: {0},Pages: {1}", title, pages));
            #endregion
            #region Q08
            //int pages = 464;
            //if (pages > 300)
            //    Console.WriteLine("Long Book");
            //else
            //    Console.WriteLine("Short Book");
            #endregion
            #region Q09
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable == true)
            //    Console.WriteLine("you can borrow this book");
            #endregion
            #region Q10
            //string title = "Refactoring";
            //switch (title)
            //{
            //    case ("Clean Code"):
            //        Console.WriteLine("Great choice!"); break;
            //    case ("Refactoring"):
            //        Console.WriteLine("Nice pick!"); break;
            //    default:
            //        Console.WriteLine("Never heard of it"); break;

            //}
            #endregion
            #region Q11
            //int pages = 464;
            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);
            #endregion
            #region Q12
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + "." + books[i]);
            //}
            #endregion 
            #region Q13
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //while (i < books.Length)
            //{
            //    Console.WriteLine((i + 1) + "." + books[i]);
            //    i++;
            //}
            #endregion
            #region Q14
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //}
            //while (i < 3);
            #endregion
            #region Q15
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 1;
            //foreach (string book in books)
            //{
            //    Console.WriteLine(i + "." + book);
            //    i++;
            //}
            #endregion
            #region Q16
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + "." + books[i]);
            //    if (books[i] == "Refactoring") break;
            //}
            #endregion
            #region Q17
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;
            //foreach (string book in books)
            //{
            //    i++;
            //    if (book == "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i + "." + book);
            //}
            #endregion
            #region Q18
            //static string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //static void PrintFirstBook()
            //{
            //    if (books.Length == 0)
            //    {
            //        return;
            //    }

            //    Console.WriteLine(books[0]);
            //}
            #endregion
        }
    }
}