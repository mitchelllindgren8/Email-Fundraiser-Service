using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailFundProject
{
    internal class EventCreator
    {
        public string startD;
        public string endD;
        public string sport;
        public string level;
        public int goal;


        public EventCreator(string aStartD, string aEndD, string aSport, string aLevel, int aGoal)
        {
            startD = aStartD;
            endD = aEndD;
            sport = aSport;
            level = aLevel;
            goal = aGoal;
        }

        public string startDate
        {
            get; set;
        }

        public string endDate
        {
            get; set;
        }

        public string sportFunc
        {
            get; set;
        }

        public string levelFunc
        {
            get; set;
        }

        public int goalFunc
        {
            get; set;
        }
    }
}
