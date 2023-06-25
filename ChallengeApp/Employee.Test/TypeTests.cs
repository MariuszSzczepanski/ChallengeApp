
namespace ChallengeApp.Test

{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {

            //arange
            float emp1 = 33;
            float emp2 = 35;

            Assert.AreNotEqual(emp1, emp2);

        }
        [Test]
        public void TEST2()
        {

            //arange
            int number1 = 1;
            int number2 = 1;

            Assert.AreEqual(number1,number2);

        }
        [Test]
        public void TEST3()
        {

            //arange
            var emp1 = GetEmployee("Jarosław");
            var emp2 = GetEmployee("Jarosław");

            Assert.AreEqual(emp1.Name, emp2.Name);

        }
        [Test]
        public void TEST4()
        {

            //arange
            string name1 = "Jaroslaw";
            string name2 = "Jan";

            Assert.AreNotEqual(name1, name2);

        }



        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
