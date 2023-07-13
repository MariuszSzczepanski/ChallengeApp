using ChallengeApp;

var employee = new Employee("Mariusz", "Szczepański");
employee.AddGrade(2);
employee.AddGrade(4);
employee.AddGrade(7);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max : {statistics.Max}");
Console.WriteLine($"Min : {statistics.Min}");


