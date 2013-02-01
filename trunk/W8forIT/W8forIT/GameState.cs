using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W8forIT
{
    class GameState
    {
        public string Status { get; set; }
        public string StatusMessage { get; set; }
        public int SecondsLeft { get; set; }
        public int Turn { get; set; }
        public int Money { get; set; }
        public List<Agent> AgentList{ get; set; }
        public List<Tasks> TaskList { get; set; }
        public Map Map { get; set; }
        public List<HeadQuarter> HeadQuarterList{get; set;}



    }
}
