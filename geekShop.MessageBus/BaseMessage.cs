using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekShop.MessageBus
{
    public class BaseMessage
    {
        public long Guid { get; set; }
        public DateTime MessageCreated { get; set; }
    }
}
