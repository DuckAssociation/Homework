using System;
using System.Collections.Generic;

namespace FirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Do your testing here.

            Console.ReadKey();
        }

    }

    public class PhoneBook
    {
        // TODO: Implement phone book without changing method signature. Replace comments with your code to succeed in this task. Good luck!

        Dictionary<string, int> _phoneBook = new Dictionary<string, int>();
        public PhoneBook(PhoneBookEntry[] initialValues)
        {
            // TODO: Remove and implement initial assignment from array (initialValues) to dictionary (_phoneBook).
            throw new NotImplementedException();
        }

        public void Add(PhoneBookEntry entry)
        {
            // TODO: Add passed value (entry) to dictionary
            throw new NotImplementedException();
        }

        public bool Remove(string name)
        {
            // TODO: Remove phone book entry from phone book.
            throw new NotImplementedException();
        }

        public bool Update(PhoneBookEntry entry)
        {
            // TODO: Update phone book entry information. If entry does not exist, return false, otherwise update and return true;
            throw new NotImplementedException();
        }

        public int Dial(string name)
        {
            // TODO: Return phone number for give person. If non existing return -1;
            throw new NotImplementedException();
        }

        public string[] Name(int number)
        {
            // TODO: Return name of people names who's phone number it is.
            throw new NotImplementedException();
        }

        public Dictionary<string, int> Addresses { get { return _phoneBook; } }
    }
}
