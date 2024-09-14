using System;
using System.Collections.Generic;

namespace TrackerLibrary
{
    class TournamentModel
    {
        public string TournamentName { get; set; }
        public string EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        public List<PrizeModel> Prizes {get; set;} = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}