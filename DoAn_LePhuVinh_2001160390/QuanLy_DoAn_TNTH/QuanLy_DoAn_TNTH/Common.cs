using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_DoAn_TNTH
{
    class Common
    {
        private static DAMH _Entities = new DAMH();
        public static DAMH Entities
        {
            get { return Common._Entities; }
            set { Common._Entities = value; }
        }
    }
}
