using ChallengeApp;

var employee = new Employee("Mariusz", "Szczepański");
employee.AddGrade("Mariusz");
employee.AddGrade("9");
employee.AddGrade(7);
employee.AddGrade(5);

var statistics = employee.GetStatistics();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();


Console.WriteLine("Metoda Foreach");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max : {statistics.Max}");
Console.WriteLine($"Min : {statistics.Min}");

Console.WriteLine("Metoda For");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max : {statistics.Max}");
Console.WriteLine($"Min : {statistics.Min}");

Console.WriteLine("Metoda Do While");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max : {statistics.Max}");
Console.WriteLine($"Min : {statistics.Min}");

Console.WriteLine("Metoda While");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max : {statistics.Max}");
Console.WriteLine($"Min : {statistics.Min}");


