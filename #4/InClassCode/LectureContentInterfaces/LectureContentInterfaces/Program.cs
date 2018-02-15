using System;

namespace LectureContentInterfaces
{
    interface IDataStore
    {
        string Read();
        bool Write(string value);
    }

    public class DBStore : IDataStore
    {
        public string Read()
        {
            return "What was read from DB";
        }

        public bool Write(string value)
        {
            Console.WriteLine($"Write to DB - {value}");
            return true;
        }
    }

    public class FileStore : IDataStore
    {
        public string Read()
        {
            return "What was read from File";
        }

        public bool Write(string value)
        {
            Console.WriteLine($"Write to file - {value}");
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dataManipulator = new DataManipulator(new DBStore());
            dataManipulator.Manipulate("(My value, deal with it)", "This is value passed in - {0}");
            Console.ReadKey();
        }
    }

    class DataManipulator
    {
        private readonly IDataStore _store;

        public DataManipulator(IDataStore store)
        {
            _store = store;
        }

        public void Manipulate(string originalValue, string template)
        {
            _store.Write($"| {String.Format(template, originalValue)} |");
        }
    }
}
