using System;

namespace LectureContent
{
    class Program
    {
        static void Main(string[] args)
        {
            

            new TestRefOutAndOptional().RefAndOutKeywordTest();
            Console.ReadKey();
        }
    }

    public class TestRefenceType
    {
        public TestRefenceType(int number)
        {
            Number = number;
        }
        public int Number { get; set; }
    }

    public class TestRefOutAndOptional
    {
        public int Number { get; set; }
        public void RefAndOutKeywordTest()
        {
            //int manoSkaicius;
            //TryGetStringOut(out manoSkaicius);
            //Console.WriteLine(manoSkaicius);

            if (Int32.TryParse("54", out int result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result);
            }
        }
        private void TryGetStringOut(out int value)
        {
            value = 8;
        }

        private void TryGetStringRegular(int value)
        {
            value = 8;
        }

        private void Dance(string style = "Cha Cha")
        {
            Console.WriteLine($"I am now dancing {style}");
        }

    }
}
