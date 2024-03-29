﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreRelationships.Data
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Backpack Backpack { get; set; }
        public List<Weapon> Weapons { get; set; }

        public List<Faction> Factions { get; set; }
    }
}
