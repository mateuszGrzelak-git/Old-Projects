using System;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        ///<summary>
        ///Represents one team in the matchup
        ///</summary>
        public TeamModel MyProperty { get; set; }
        ///<summary>
        ///Represents the score for this particular team.
        ///</summary>
        public double Score { get; set; }
        ///<summary>
        ///Represents the matchup for that this team came
        ///from as the winner
        ///</summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}