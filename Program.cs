//Створіть клас «Футбольна Команда». Клас має містити інформацію про гравців футбольної команди.
//Реалізуйте підтримку ітератора для класу «Футбольна Команда».
//Протестуйте можливість використання foreach для класу «Футбольна Команда».

using NET_Homework_7_6;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.OutputEncoding = Encoding.UTF8;Football_team football_Team = new Football_team();
football_Team.Add(new Player() { Full_name = "Радчук Павло Семенович", Number = 3 });football_Team.Add(new Player() { Full_name = "Голуб Юрій Володимирович", Number = 7 });football_Team.Add(new Player() { Full_name = "Левчик Дмитро Васильович", Number = 12 });football_Team.Add(new Player() { Full_name = "Юрченко Сергій Олександрович", Number = 9 });football_Team.Add(new Player() { Full_name = "Коваль Максим Володимирович", Number = 1 });football_Team.TeamName = "Дінамо";football_Team.Rating = 1;Console.WriteLine($"Футбольна команда \"{football_Team.TeamName}\"\tРейтинг {football_Team.Rating}\nГравці:");foreach (var team in football_Team)
{
    Console.WriteLine($"Гравець {team.Full_name} Номер {team.Number}");
}
