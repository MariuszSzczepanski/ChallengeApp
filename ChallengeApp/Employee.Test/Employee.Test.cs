
namespace ChallengeApp.Test

{
    public class EmployeeTests
    {
        [Test]
        public void TheAverageOfNumberSShouldShowAverageValue()
        {
            //arange - przygotowanie
            var employee = new Employee("Mariusz", "Szczepański");
            employee.AddGrade(5);
            employee.AddGrade(9);
            employee.AddGrade(7);

            //act - uruchamianie
            var statistics = employee.GetStatistics();

            //assert - sprawdzanie
            Assert.AreEqual(7, statistics.Average);


        }

        [Test]
        public void WhenTheNumbursFitInCorrectLetterThenShouldBeA()
        {
            //arange - przygotowanie
            var employee = new Employee("Mariusz", "Szczepański");
            employee.AddGrade(80);
            employee.AddGrade(88);
            employee.AddGrade(90);

            //act - uruchamianie
            var statistics = employee.GetStatistics();

            //assert - sprawdzanie
            Assert.AreEqual('A', statistics.AverageLetter);


        }

        [Test]
        public void WhenTheNumbursFitInCorrectLetterThenShouldBeD ()
        {
            //arange - przygotowanie
            var employee = new Employee("Mariusz", "Szczepański");
            employee.AddGrade(20);
            employee.AddGrade(35);
            employee.AddGrade(30);

            //act - uruchamianie
            var statistics = employee.GetStatistics();

            //assert - sprawdzanie
            Assert.AreEqual('D', statistics.AverageLetter);

        }
    }
}
