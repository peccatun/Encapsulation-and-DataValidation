using PersonsInfo;
using System.Collections.Generic;

namespace Encapsulation
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reverseTeam;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reverseTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get
            {
                return this.firstTeam.AsReadOnly();
            }

        }

        public IReadOnlyCollection<Person> ReverseTeam
        {
            get
            {
                return this.reverseTeam;
            }
        }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                this.firstTeam.Add(player);
            }
            else
            {
                reverseTeam.Add(player);
            }
        }
    }
}
