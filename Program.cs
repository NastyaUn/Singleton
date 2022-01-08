using System;

namespace Паттерн_3_Singletone
{
    public class Autor
    {
        static Autor autor;
        protected Autor()
        {
            Console.WriteLine("Welcome, autor!");
        }
        public static Autor Instance()
        {
            if (autor == null)
            {
                autor = new Autor();
            }
            else 
            { Console.WriteLine("Autor already exists"); }
            return autor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Autor p = Autor.Instance();
            Autor p1 = Autor.Instance();
        }
    }
}
