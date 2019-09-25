using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSample
{
    public class ConstructorSample
    {
        private DateTime _createDate;
        public DateTime CreateDate { get { return _createDate; } }

        public ConstructorSample()
        {
            _createDate = DateTime.Now;
        }
    }
}
