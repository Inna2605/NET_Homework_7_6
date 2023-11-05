//Створіть клас «Футбольна Команда». Клас має містити інформацію про гравців футбольної команди.
//Реалізуйте підтримку ітератора для класу «Футбольна Команда».
//Протестуйте можливість використання foreach для класу «Футбольна Команда».
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_7_6
{
    internal class Player:Football_team
    {
        public string? Full_name { get; set; }
        public int Number { get; set; }
    }
}
