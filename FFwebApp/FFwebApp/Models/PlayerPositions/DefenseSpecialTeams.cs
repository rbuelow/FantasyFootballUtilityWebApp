using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFwebApp.Models.PlayerPositions
{
    public class DefenseSpecialTeams
    {
        public int KickoffReturnTDs { get; set; }
        public int PuntReturnTDs { get; set; }
        public int IntReturnTDs { get; set; }
        public int FumbleRecovReturnTDs { get; set; }
        public int Interceptions { get; set; }
        public int FumbleRecoveries { get; set; }
        public int BlockedKick { get; set; }
        public int Safeties { get; set; }
        public int Sacks { get; set; }
        public bool ZeroPtsAllowed { get; set; }
        public bool OneToSixPtsAllowed { get; set; }
        public bool SevenToThirteenPtsAllowed { get; set; }
        public bool FourteenToSeventeenPtsAllowed { get; set; }
        public bool EighteenToTwentySevenPtsAllowed { get; set; }
        public bool TwentyEightToThirtyFourPtsAllowed { get; set; }
        public bool ThirtyFiveToFortyFivePtsAllowed { get; set; }      
        public bool FortySixPlusPtsAllowed { get; set; }

    }
}