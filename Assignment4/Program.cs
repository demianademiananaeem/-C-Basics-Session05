namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Q1

            Book book = new Book();
            //book.printPassword();
            //// مش هينقدر نعمل print 
            //// لان هو متعرف علي مستوي ال class بس 
            //// انا عملت method من جوه ال
            #endregion

            #region Q2

            //Console.WriteLine(book.copiesInStock);
            ////عادي ال compler شايفها 
            ////لانها متعرفه علي مستوي ال project
            #endregion

            #region Q3

            //book.Title = "Clean Code";
            //Console.WriteLine($"Book Title: {book.Title}");

            // هو متعرف علي مستوي العام اي مكان نقدر تستخدمه
            #endregion

            #region Q4

            //Genre genre = Genre.Science;
            // Console.WriteLine(genre);
            #endregion


            #region Q5

            Console.WriteLine($"fiction: {(int)Genre.Fiction}");

            Console.WriteLine($"NonFiction: {(int)Genre.NonFiction}");

            Console.WriteLine($"fiction: {(int)Genre.Science}");
            #endregion
        }
    }
}
