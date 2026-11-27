using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    internal class Book
    {
        private string password = "secret";

        public void printPassword()
        {
            Console.WriteLine($"Password: {password}");
        }
    }
}
