using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footban.Database.Trading.Model.Base
{
    public class BaseItemState
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}
