//Створіть клас «Футбольна Команда». Клас має містити інформацію про гравців футбольної команди.
//Реалізуйте підтримку ітератора для класу «Футбольна Команда».
//Протестуйте можливість використання foreach для класу «Футбольна Команда».
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NET_Homework_7_6
{
    internal class Football_team:IEnumerable<Player>
    {
        public string? TeamName {  get; set; }
        public int Rating { get; set; }

      List<Player> players = new List<Player>();

        public IEnumerator<Player> GetEnumerator()
        {
            return players.GetEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Add(Player pl)
        {
            players.Add(pl);
        }

        public void PrintPlayer()
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Гравець {player.Full_name} номер {player.Number}");
            }
        }
    }
}
