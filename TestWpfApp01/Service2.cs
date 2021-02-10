using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWpfApp01
{
    class Service2 : IGetOne
    {
        public string GetOne()
        {
            string x = "1";
            return x;
        }
    }
}
