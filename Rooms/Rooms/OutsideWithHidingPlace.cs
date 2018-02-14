using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms
{
    class OutsideWithHidingPlace : Outside
    {

        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName)
            :base(name, hot)
        {
            HidingPlaceName = hidingPlaceName;
        }

        public string HidingPlaceName { get; private set; }

        public override string Description
        {
            get
            {
                return base.Description + " Some could hide " + HidingPlaceName + ".";
            }
        }
    }
}
