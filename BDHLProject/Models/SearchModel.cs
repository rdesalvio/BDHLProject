using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDHLProject.Models
{
    public class SearchModel
    {
        public string DBYear { get; set; }

        public string StatisticsType { get; set; }

        public List<C201617TotalStats> PlayersSixteenSeventeen { get; set; }
        public List<C201617PPStats> PPPlayersSixteenSeventeen { get; set; }

    }
}