using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // структуры не могут имплементировать (реализовать) интерфейсы - отличие от классов

            List<Figure> list = new List<Figure>();
            list.Add(new Square());
            list.Add(new Square());
            list.Add(new Square());
            list.Add(new Circle());
            list.Add(new Circle());
            list.Add(new Circle());

            foreach(Figure f in list)
            {
                Console.WriteLine(f.Area());
            }

            //  использование интерфейса
            IDataWork fg = new FileWork();
            fg.getFigures();
        }
    }

    //  абстрактный класс с методом
    public abstract class Figure
    {
        public abstract int Area();
    }

    public class Square : Figure
    {
        //  реализация метода абстрактного класса
        //  "override" переопределяет абстрактный класс
        public override int Area()
        {
            return 0;
        }
    }

    public class Circle : Figure
    {
        public override int Area()
        {
            return 1;
        }
    }

    //  можно сделать static class для печати списка (Листа), сортировки
    //  можно не создавать объект в классе, а сразу вызывать
    public static class ListWork
    {
        public static void printList()
        {

        }
    }

    public interface IDataWork
    {
        List<Figure> getFigures();
    }

    public class FileWork : IDataWork
    {
        public List<Figure> getFigures()
        {
            Console.WriteLine("Took from file"); 
            return new List<Figure>();
        }
    }

    //  реализация интерфейса
    public class DBWork : IDataWork
    {
        public List<Figure> getFigures()
        {
            Console.WriteLine("Took from db");
            return new List<Figure>();
        }
    }
}
