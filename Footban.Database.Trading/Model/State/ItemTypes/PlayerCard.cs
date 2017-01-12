using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footban.Database.Trading.Model.State.ItemTypes
{
    public class PlayerCard : BaseItemState
    {
        public int Attack { get; set; }
        public int Defence { get; set; }
    }
}
