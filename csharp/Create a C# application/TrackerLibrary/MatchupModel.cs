using System;
using System.Collections.Generic;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> MyProperty { get; set; }
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}