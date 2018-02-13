using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms
{
    abstract class Location
    {

        //constructor to set the name field which is read-only
        public Location(string name)
        {
            Name = name;
        }

        //array of loacation references that keeps track
        //of all the other places location connects to
        public Location[] Exits;

        public string Name { get; private set; }

        //property to retrun a string to descrip the room
        //will be overridden by sub classes
        public virtual string Description
        {
            get
            {
                string description = "You're standing in the " + Name + ". You see exits to the following places: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length - 1)
                    {
                        description += ",";
                    }
                }
                description += ".";
                return description;
            }
        }
    }
}
