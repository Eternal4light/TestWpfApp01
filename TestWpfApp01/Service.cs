using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWpfApp01
{
    public class Service : Interface01
    {

        public string GetGuid()
        {
            Guid x = Guid.NewGuid();
            return x.ToString();
        }

        public Service()
        {

        }
    }
        
}
