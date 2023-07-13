
namespace ChallengeApp.Test

{
    public class EmployeeTests
    {
        [Test]
        public void StatisticsMax()
        {
            //arange - przygotowanie
            var employee = new Employee("Mariusz", "Szczepański");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(7);

            //act - uruchamianie
            var statistics = employee.GetStatistics();

            //assert - sprawdzanie
            Assert.AreEqual(7, statistics.Max);


        }

        [Test]
        public void StatisticsMin()
        {
            //arange - przygotowanie
            var employee = new Employee("Mariusz", "Szczepański");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(7);

            //act - uruchamianie
            var statistics = employee.GetStatistics();

            //assert - sprawdzanie
            Assert.AreEqual(2, statistics.Min);


        }

        [Test]
        public void StatisticsAverage()
        {
            //arange - przygotowanie
            var employee = new Employee("Mariusz", "Szczepański");
            employee.AddGrade(2);
            employee.AddGrade(4);
            employee.AddGrade(7);

            //act - uruchamianie
            var statistics = employee.GetStatistics();

            //assert - sprawdzanie
            Assert.AreEqual(Math.Round(4.33, 2), Math.Round(statistics.Average, 2));


        }


    }
}
