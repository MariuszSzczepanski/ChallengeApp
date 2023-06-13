using ChallengeApp;

Employee emp1 = new Employee("Jarosław", "Baryła", 33);
Employee emp2 = new Employee("Jan", "Kowalski", 35);
Employee emp3 = new Employee("Marlena", "Hula", 28);



emp1.AddScore(9);
emp1.AddScore(4);
emp1.AddScore(3);
emp1.AddScore(7);
emp1.AddScore(5);

emp2.AddScore(5);
emp2.AddScore(6);
emp2.AddScore(9);
emp2.AddScore(8);
emp2.AddScore(3);

emp3.AddScore(6);
emp3.AddScore(9);
emp3.AddScore(6);
emp3.AddScore(4);
emp3.AddScore(4);

List<Employee> emps = new List<Employee>()
{
    emp1, emp2, emp3
};

int maxResult = -1;
Employee empWithMaxResult = null;

foreach (var emp in emps)
{
    if(emp.Result > maxResult)
    {
        maxResult = emp.Result;
        empWithMaxResult = emp;
    }
}

Console.WriteLine("Pracownik z najwyższą liczbą ocen : " + empWithMaxResult.Name + " " + empWithMaxResult.Surname);
Console.WriteLine("Liczba punktów : " + empWithMaxResult.Result);


