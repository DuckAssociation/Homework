using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace KISS
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class TextManipulator
    {
        public string Capitalize(string value, bool capitalizeEveryWord)
        {
            if (value.Length > 1000)
                throw new Exception("String is too long :(.");

            value.Split(new char[] { ' ' });

        }

        public static bool IsInt32TryParse(string input)
        {
            return Int32.TryParse(input, out var _);
        }

        public static bool IsInt32Linq(string input)
        {
            return input.All(x => Char.IsDigit(x));
        }

        public static bool IsInt32RegEx(string input)
        {
            return Regex.IsMatch(input, @"^\d+$");
        }

        public class Constants
        {
            public static readonly string Address = "Stockholm, Sweden";
            public static readonly string StandardFormat = "{0} is {1}, lives in {2}, age {3}";
        }

        private static void DoSomething() => WriteToConsole("Nils", "a good friend", 30);

        private static void DoSomethingAgain() => WriteToConsole("Christian", "a neighbour", 54);

        private static void DoSomethingMore() => WriteToConsole("Eva", "my daughter", 4);

        private static void DoSomethingExtraordinary() => WriteToConsole("Lilly", "my daughter's best friend", 4);

        private static void WriteToConsole(string name, string description, int age)
        {
            Console.WriteLine(Constants.StandardFormat, name, description, Constants.Address, age);
        }

        // FIRST EDITION
        //public class Account
        //{
        //    List<string> _customers = new List<string>();
        //    public void CreateCustomer(string name, bool isPrivate = true)
        //    {
        //        if (String.IsNullOrEmpty(name))
        //            throw new Exception("Bad name");

        //        foreach (var customer in _customers)
        //        {
        //            if (customer == name)
        //                return;
        //        }

        //        File.AppendAllText("C:/Log.txt", "Creating Customer.");

        //        try
        //        {
        //            var cnn = new SqlConnection("Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password");
        //            cnn.Open();
        //            var command = new SqlCommand($"INSERT INTO Customers (Customer) VALUES {name}", cnn);
        //            command.ExecuteNonQuery();
        //            File.AppendAllText("C:/Log.txt", "Customer Inserted into DB");
        //            cnn.Close();
        //            File.AppendAllText("C:/Log.txt", "Disconnected from DB");
        //        }
        //        catch (Exception ex)
        //        {
        //            File.AppendAllText("C:/Log.txt", "Ups something went wrong!");
        //        }
        //    }
        //}


        // SECOND EDITION
        //public class Account
        //{
        //    List<string> _customers = new List<string>();
        //    public void CreateCustomer(string name, bool isPrivate = true)
        //    {
        //        if (!IsNameValid(name)) throw new ArgumentException($"Argument provided cannot be null or empty. Argument - {nameof(name)}");

        //        if (CustomerExists(name, _customers)) throw new AlreadyExistsException($"Customer already exists. Customer - {name}");

        //        File.AppendAllText("C:/Log.txt", "Creating Customer.");

        //        try
        //        {
        //            var cnn = new SqlConnection("Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password");
        //            cnn.Open();
        //            var command = new SqlCommand($"INSERT INTO Customers (Customer) VALUES {name}", cnn);
        //            command.ExecuteNonQuery();
        //            File.AppendAllText("C:/Log.txt", "Customer Inserted into DB");
        //            cnn.Close();
        //            File.AppendAllText("C:/Log.txt", "Disconnected from DB");
        //        }
        //        catch (Exception ex)
        //        {
        //            File.AppendAllText("C:/Log.txt", "Ups something went wrong!");
        //        }
        //    }

        //    private bool IsNameValid(string name) => !String.IsNullOrEmpty(name);
        //    private bool CustomerExists(string name, List<string> customers) => customers.Contains(name);

        //}
        //public class AlreadyExistsException : Exception
        //{
        //    public AlreadyExistsException(string message) : base(message)
        //    {
        //    }
        //}

        // THIRD EDITION
        //public class Account
        //{
        //    List<string> _customers = new List<string>();
        //    private readonly Logger _logger;

        //    public Account()
        //    {
        //        _logger = new Logger();
        //    }
        //    public void CreateCustomer(string name, bool isPrivate = true)
        //    {
        //        if (!IsNameValid(name)) throw new ArgumentException($"Argument provided cannot be null or empty. Argument - {nameof(name)}");

        //        if (CustomerExists(name, _customers)) throw new AlreadyExistsException($"Customer already exists. Customer - {name}");

        //        try
        //        {
        //            var cnn = new SqlConnection("Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password");
        //            cnn.Open();
        //            var command = new SqlCommand($"INSERT INTO Customers (Customer) VALUES {name}", cnn);
        //            command.ExecuteNonQuery();
        //            _logger.Log("Customer Inserted into DB");
        //            cnn.Close();
        //            _logger.Log("Disconnected from DB");
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.Log($"Exception message - {ex.Message}.{Environment.NewLine} StackTrace - {ex.StackTrace}. {Environment.NewLine} Failure while creating a customer.");
        //        }
        //    }

        //    private bool IsNameValid(string name) => !String.IsNullOrEmpty(name);
        //    private bool CustomerExists(string name, List<string> customers) => customers.Contains(name);

        //}

        //public class AlreadyExistsException : Exception
        //{
        //    public AlreadyExistsException(string message) : base(message)
        //    {
        //    }
        //}

        //public class Logger
        //{
        //    public void Log(string text)
        //    {
        //        try
        //        {
        //            File.AppendAllText("C:/Log.txt", text);
        //        }
        //        catch (Exception ex)
        //        {
        //            // Complex recovery. Not required to illustrate the example.
        //        }
        //    }
        //}

        // FOURTH EDITION
        //public class Account
        //{
        //    List<string> _customers = new List<string>();
        //    private readonly Logger _logger;
        //    private readonly DataBaseWriter _dbWriter;

        //    public Account()
        //    {
        //        _logger = new Logger();
        //        _dbWriter = new DataBaseWriter();
        //    }

        //    public void CreateCustomer(string name, bool isPrivate = true)
        //    {
        //        if (!IsNameValid(name)) throw new ArgumentException($"Argument provided cannot be null or empty. Argument - {nameof(name)}");

        //        if (CustomerExists(name, _customers)) throw new AlreadyExistingEntryException($"Customer already exists. Customer - {name}");

        //        _customers.Add(name);

        //        if (_dbWriter.Write(name)) _logger.Log("Successfully created customer.");
        //    }

        //    private bool IsNameValid(string name) => !String.IsNullOrEmpty(name);
        //    private bool CustomerExists(string name, List<string> customers) => customers.Contains(name);

        //}

        //public class AlreadyExistingEntryException : Exception
        //{
        //    public AlreadyExistingEntryException(string message) : base(message)
        //    {
        //    }
        //}

        //public class Logger
        //{
        //    public void Log(string text)
        //    {
        //        try
        //        {
        //            File.AppendAllText("C:/Log.txt", text);
        //        }
        //        catch (Exception ex)
        //        {
        //            // Complex recovery. Not required to illustrate the example.
        //        }
        //    }
        //}
        //public class DataBaseWriter
        //{
        //    private readonly Logger _logger;
        //    private readonly string _connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
        //    private readonly string _command = "INSERT INTO Customers (Customer) VALUES {0}";
        //    public DataBaseWriter()
        //    {
        //        _logger = new Logger();
        //    }
        //    public bool Write(string name)
        //    {
        //        try
        //        {
        //            using (var cnn = new SqlConnection())
        //            {
        //                cnn.Open();
        //                using (var command = new SqlCommand(String.Format(_command, name), cnn))
        //                {
        //                    command.ExecuteNonQuery();
        //                    _logger.Log($"{name} inserted into DataBase");
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            _logger.Log($"Failed to insert {name} into DataBase");
        //            _logger.Log($"Exception message - {ex.Message}.{Environment.NewLine} StackTrace - {ex.StackTrace}. {Environment.NewLine}.");
        //            return false;
        //        }
        //        return true;
        //    }
        //}

        // FIFTH EDITION

        //public class Account
        //{
        //   // Customers has nothing to with Account.
        //}

        public class Employee
        {
            public int Employee_Id { get; set; }
            public bool InsertIntoEmployeeTable(Employee em)
            {
                return true;
            }
            
            public void GenerateReport(Employee em)
            {
            }
        }

        public class ReportGeneration
        {
            public void GenerateReport(Employee em)
            {
            }
        }
    }
}
