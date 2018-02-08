using System;
using System.Collections.Generic;
using System.Linq;

namespace LetsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class CoffeeShop
    {
        // TODO: Implement phone book without changing method signature. Replace comments with your code to succeed in this task. Good luck!

        Dictionary<Coffee, int> _coffees = new Dictionary<Coffee, int>();
        Queue<int> _customers = new Queue<int>();
        int _ticket = 1;
        int _coffeesServed = 0;

        public CoffeeShop(Coffee[] coffeesPrepared)
        {
            foreach (var item in coffeesPrepared)
            {
                if (_coffees.ContainsKey(item))

                    _coffees[item]++;
                else
                    _coffees.Add(item, 1);
            }
            // TODO: Remove throw new NotImplementedException. Add coffees to coffee dictionary.
            //throw new NotImplementedException();
        }
        public CoffeeShop(Coffee[] coffeesPrepared, int customersInQueue) : this(coffeesPrepared)
        {
            _customers = new Queue<int>(Enumerable.Range(1, customersInQueue));
            _ticket = customersInQueue;
            // TODO: Remove throw new NotImplementedException. Add customers to queue with their ticket number. 
            //throw new NotImplementedException();
        }

        public void AddCustomer()
        {
            _customers.Enqueue(++_ticket);
            // TODO: Add customer to queue.
            //throw new NotImplementedException();
        }

        public bool ServeCustomer(Coffee coffee)
        {
            if (_coffees.ContainsKey(coffee))
            {
                if (_coffees[coffee] > 0)
                {
                    _customers.Dequeue();
                    _coffees[coffee]--;
                    _coffeesServed++;
                    return true;
                }
            }
            return false;

            // TODO: remove customer from queue and give him coffee. If coffee not yet made do nothing and return false.
            throw new NotImplementedException();
        }

        public bool AddCoffee(Coffee coffee)
        {
            if (_coffees.ContainsKey(coffee))
            {
                _coffees[coffee]++;
            }
            else
            {
                _coffees.Add(coffee, 1);
            }
            return true;
            // TODO: Add prepared coffee.
            throw new NotImplementedException();
        }

        public bool RemoveCoffee(Coffee coffee)
        {
            if (_coffees.ContainsKey(coffee) && _coffees[coffee] > 0)
            {
                _coffees[coffee]--;
                return true;
            }
            else
            {
                return false;
            }

            // TODO: Subtract given coffee
            throw new NotImplementedException();
        }

        public int[] Customers
        {
            get
            {
                return _customers.ToArray();

                // TODO: Return ticket numbers of people in queue.
                throw new NotImplementedException();
            }

        }

        public int NextTicket
        {
            get
            {
                return _ticket + 1;
                // TODO: return next ticket.
                throw new NotImplementedException();
            }
        }

        public int CoffeesServed
        {
            get
            {
                return _coffeesServed;
                // TODO: Track all coffees served & their count.
                throw new NotImplementedException();
            }
        }

        public int CustomersServed
        {
            get
            {
                return _ticket - _customers.Count;
                // TODO: Track all customers served.
                throw new NotImplementedException();
            }
        }

        public Dictionary<Coffee, int> CoffeesReadyToServe
        {
            get
            {
                return _coffees;
                // TODO: Track all currently availbale coffees.
                throw new NotImplementedException();
            }
        }

        public Queue<int> CustomersInQueue
        {
            get { return _customers; }
        }

    }
}
