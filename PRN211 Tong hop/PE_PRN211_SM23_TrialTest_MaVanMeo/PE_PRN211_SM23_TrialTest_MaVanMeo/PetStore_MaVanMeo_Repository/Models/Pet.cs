﻿using System;
using System.Collections.Generic;

namespace PetStore_MaVanMeo_Repository.Models
{
    public partial class Pet
    {
        public int PetId { get; set; }
        public string PetName { get; set; } = null!;
        public DateTime? ImportDate { get; set; }
        public string? PetDescription { get; set; }
        public int? Quantity { get; set; }
        public double? PetPrice { get; set; }
        public string? PetGroupId { get; set; }

        public virtual PetGroup? PetGroup { get; set; }
    }
}
