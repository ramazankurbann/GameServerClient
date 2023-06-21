using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLib
{
    public abstract class AbstractDTO : IDTO
    {
        public int ID { get; set; } = 0;
        public abstract void Reset();
    }
}
