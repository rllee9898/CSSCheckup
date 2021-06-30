using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo__Application
{
    public class Developer
    {
        //Constructors 
        //Constructor Empty
        public Developer() { }
        //Constructor Full
        public Developer(string devName, int devId, bool hasAcceseToPluralsight)
        {
            DevName = devName;
            DevId = devId;
            HasAcceseToPluralsight = hasAcceseToPluralsight;
        }

        //POCO *Plain Old C# Object

        //Properties
        public string DevName { get; set; }
        public int DevId { get; set; }
        public bool HasAcceseToPluralsight { get; set; }
    }
}