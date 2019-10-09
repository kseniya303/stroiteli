using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stroiteli
{
    public class Team
    {
        TeamLeader TeamLeader { get; set; }
        List<Worker> Workers { get; set; }
        public Team()
        {
            TeamLeader = new TeamLeader("Mikhail");
            Workers = new List<Worker>() {
                new Worker("Worker #1"),
                new Worker("Worker #2"),
                new Worker("Worker #3"),
            };
        }
    }
}
