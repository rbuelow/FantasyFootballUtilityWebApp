using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FFwebApp.Models.PlayerPositions
{
    public class Individual
    {
        public string Name { get; set; }
        //Throwing stats
        public int PassTDs { get; set; }
        public int PassYds { get; set; }
        public int Ints { get; set; }
        public int TwoPtConvThrown { get; set; }
        //Rush stats
        public int RushYds { get; set; }
        public int RushTDs { get; set; }
        //Receiving stats
        public int ReceivingYds { get; set; }
        public int ReceivingTDs { get; set; }
        //Misc/special teams stats
        public int FumblesLost { get; set; }
        public int TwoPtConvScored { get; set; }
        public int KickoffReturnTDs { get; set; }
        public int PuntReturnTDs { get; set; }
        public int FumbleRecovReturnTDs { get; set; }
        //Kicking stats
        public int FiftyPlusFieldGoalMade { get; set; }
        public int FortyToFortyNineFieldGoalMade { get; set; }
        public int ZeroToThirtyNineFieldGoalMade { get; set; }
        public int ExtraPointMade { get; set; }
        public int FieldGoalMissed { get; set; }
    }
}