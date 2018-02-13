using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {

        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }
}
