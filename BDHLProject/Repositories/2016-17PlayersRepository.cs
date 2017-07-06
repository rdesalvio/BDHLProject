using BDHLProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BDHLProject.Repositories
{
    public class _2016_17PlayersRepository
    {
        public static List<C201617TotalStats> Get201617Players()
        {
            NHLPlayers Players = new NHLPlayers();
            return Players.C201617TotalStats.ToList();
        }

        public static List<C201617PPStats> Get201617PPPlayers()
        {
            NHLPlayers Players = new NHLPlayers();
            return Players.C201617PPStats.ToList();
        }

    }
}