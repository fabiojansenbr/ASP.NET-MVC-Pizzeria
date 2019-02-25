﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Tomasos.IdentityModels;

namespace Tomasos.Models
{
    public partial class Bestallning
    {
        public Bestallning()
        {
            BestallningMatratt = new HashSet<BestallningMatratt>();
        }

        public int BestallningId { get; set; }
        public DateTime BestallningDatum { get; set; }
        public int Totalbelopp { get; set; }
        public bool Levererad { get; set; }
        public string KundId { get; set; }

        [ForeignKey("KundId")]
        public virtual ApplicationUser Kund { get; set; }
        public virtual ICollection<BestallningMatratt> BestallningMatratt { get; set; }
    }
}
