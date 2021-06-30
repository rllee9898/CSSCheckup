using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo__Application
{
    public class DevTeam
    {
        //Constructors 
        //Constructor Empty
        public DevTeam() { }
        //Constructor Full
        public DevTeam(string teamName, int teamId, List<Developer> developers)
        {
            TeamId = teamId;
            TeamName = teamName;
            Developers = developers;
        }

        //POCO *Plain Old C# Object

        //Properties
        public string TeamName { get; set; }
        public int TeamId { get; set; }
        public List<Developer> Developers { get; set; }
    }
}