namespace LetsQueue
{
    public class Coffee
    {
        public Coffee(string typeOfCoffee)
        {
            TypeOfCoffee = typeOfCoffee;
        }
        public string TypeOfCoffee { get; }

        public override int GetHashCode()
        {
            return TypeOfCoffee.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is Coffee)
                return ((Coffee)obj).TypeOfCoffee == TypeOfCoffee;

            return false;
        }
    }
}