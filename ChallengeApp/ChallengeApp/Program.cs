using ChallengeApp;

var employee = new Employee("Mariusz", "Szczepański");
employee.AddGrade("Mariusz");
employee.AddGrade("9");
employee.AddGrade(7);
employee.AddGrade(5);

var statistics = employee.GetStatistics();

Console.WriteLine("Metoda Foreach");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max : {statistics.Max}");
Console.WriteLine($"Min : {statistics.Min}");


