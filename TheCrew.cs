using System.Collections.Generic;
using System;

namespace heist
{

    class TheCrew
    {
        public List<TeamMember> teamMembers { get; set; }

        public TheCrew()
        {
            teamMembers = new List<TeamMember>();
        }

        internal void Add()
        {
            throw new NotImplementedException();
        }
    }
}