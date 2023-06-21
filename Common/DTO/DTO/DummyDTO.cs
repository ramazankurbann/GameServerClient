using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLib.DTO
{
    public class DummyDTO : AbstractDTO
    {
        public static int DTOID = 1;
        public DummyDTO()
        {
            ID = DTOID;
          
            Reset();
        }

        public override void Reset()
        {
           
        }
    }
}
