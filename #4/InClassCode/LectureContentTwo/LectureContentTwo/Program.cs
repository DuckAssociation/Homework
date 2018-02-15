using System;

namespace LectureContentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var testing = new Testing();
            //testing.CountdownCompleted += TemplateMethod;
            //testing.OurDelegate += TemplateMethod;
            //testing.CountdownCompleted = null;
            //testing.OurDelegate = null;

            Calc((a, b, c) => { Console.WriteLine(a + b + c); });
            var u = new Func<int, int, int>((a, b) => a * b);
            Console.ReadKey();

            ReportCreator.ReportData reportDataDK = ReportForDenmark;
            ReportCreator.ReportData reportDataLT = ReportForLithuania;

            new ReportCreator(100, 21).GenerateReport(reportDataDK);
            new ReportCreator(150, 11).GenerateReport(reportDataLT);
            Console.ReadKey();

            bool whatIsTheResult = new object().Equals(new object());

            Console.ReadKey();

        }

        private static void Calc(Action<int, int, int> action)
        {
            action.Invoke(7, 9, 7);
        }

        private static int TemplateMethod(int x, int y)
        {
            return x;
        }
        private static decimal ReportForDenmark(int reportValue, int taxes)
        {
            return reportValue + taxes;
        }
        private static decimal ReportForLithuania(int reportValue, int taxes)
        {
            return reportValue * taxes;
        }
        private static void TemplateMethod(object o, EventArgs args)
        {
        }
    }

    class Testing
    {
        public delegate int PerformCalculation(int x, int y);
        public event EventHandler CountdownCompleted;
        public PerformCalculation OurDelegate;
        public Testing()
        {
            CountdownCompleted = null;
            OurDelegate = Calculate;
            OurDelegate -= Calculate;
            OurDelegate += Calculate;
            OurDelegate += Calculate;
            OurDelegate += Calculate;
            OurDelegate += CalculateSum;
            OurDelegate = null;
            OurDelegate?.Invoke(4, 8);
            //CountdownCompleted.Invoke(this, new EventArgs());
            // CountdownCompleted = null;

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public int Calculate(int x, int y)
        {
            Console.WriteLine(x * y);
            return x * y;
        }
        public int CalculateSum(int x, int y)
        {
            Console.WriteLine(x + y);
            return x + y;
        }

        public void Hi(PerformCalculation calc)
        {
            calc.Invoke(1, 5);
        }
    }

    public class ReportCreator
    {
        private readonly int reportValue;
        private readonly int reportTaxes;

        public ReportCreator(int reportValue, int reportTaxes)
        {
            this.reportValue = reportValue;
            this.reportTaxes = reportTaxes;
        }
        public delegate decimal ReportData(int primaryReportValue, int taxes);
        public void GenerateReport(ReportData reportData)
        {
            Console.WriteLine("OUR REPORT");
            var howWeDid = reportValue > 100 ? "GOOD" : "BAD";
            Console.WriteLine($"TODAY WE DID {howWeDid}");
            Console.WriteLine("Total - " + reportData.Invoke(reportValue, reportTaxes));
        }
    }
}
