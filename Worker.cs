using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stroiteli
{
    public class Worker: IWorker
    {
        public string Name { get; set; }
        public Worker(string value)
        {
            Name = value;
        }
    }
}
