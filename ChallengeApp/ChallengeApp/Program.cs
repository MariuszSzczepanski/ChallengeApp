﻿var name = "Ewa";
bool isFemale = true;
int Age = 29;

if (Age > 30 & name == "Ewa")
{
    Console.WriteLine("Jestem Ewa i mam poniżej 30 lat");
}
else if (Age < 30 & name == "Marek" & isFemale == false) 
{
    Console.WriteLine("Jestem Paulina i mam poniżej 30lat");
}
else if (Age == 29 & name == "Ewa" & isFemale == true)
{
    Console.WriteLine("Jestem Ewa w wieku 29 lat");
}
