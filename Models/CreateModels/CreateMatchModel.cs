﻿
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace crickinfo_mvc_ef_core.Models.CreateModels
{
    public class CreateMatchModel
    {

        //// Foreign key for TeamA
        //public int TeamAId { get; set; }
        //public Team TeamA { get; set; } = new Team(); // Initialize TeamA to a new instance

        //// Foreign key for TeamB
        //public int TeamBId { get; set; }
        //public Team TeamB { get; set; } = new Team(); // Initialize TeamB to a new instance

        public string Result { get; set; } = string.Empty; // Initialize with a default value

        public DateTime MatchDate { get; set; }

        //[NotMapped]
        public List<Team>? teamslist { get; set; }
        //public int TournamentId { get; set; }
        //public Tournament Tournament { get; set; } = new Tournament(); // Initialize Tournament to a new instance

    }
}
