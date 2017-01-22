using Footban.Database.Trading.Model.Base;

namespace Footban.Database.Trading.Model.State.ItemTypes
{
    public class PlayerCard : BaseItemState
    {
        public int Attack { get; set; }
        public int Defence { get; set; }
    }
}
