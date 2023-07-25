using ChallengeApp;

var employee = new Employee("Mariusz", "Szczepański");
employee.AddGrade("Mariusz");
employee.AddGrade(4000);
employee.AddGrade(7);
employee.AddGrade(5);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max : {statistics.Max}");
Console.WriteLine($"Min : {statistics.Min}");


