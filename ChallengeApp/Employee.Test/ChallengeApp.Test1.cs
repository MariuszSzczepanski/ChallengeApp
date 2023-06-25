
namespace ChallengeApp.Test
{
    public class EmployeeTest
    {


        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldCorrectResult()
        {

            //arange

            var emp = new Employee("Jaros³aw", "Bary³a", 33);
            emp.AddScore(5);
            emp.AddScore(10);

            //act
            var result = emp.Result;

            //assert
            Assert.AreEqual(15, result);

         
        }
    }
}