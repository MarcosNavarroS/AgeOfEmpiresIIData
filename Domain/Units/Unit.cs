using System.Collections.Generic;
using Domain.ValueObjects;

namespace Domain.Units
{
    public class Unit : IUnit
    {
        public int Id { get; }
        public string Name { get; } = null!;
        public string Expansion { get; } = null!;
        public string Age { get; } = null!;
        public string CreatedIn { get; } = null!;
        public Cost Cost { get; } = null!;
        public int BuildTime { get; }
        public decimal ReloadTime { get; }
        public decimal MovementRate { get; }
        public int LineOfSight { get; }
        public int HitPoints { get; }
        public int Attack { get; }
        public string Armor { get; }
        public string? Description { get; }
        public decimal? AttackDelay { get; }
        public string? Range { get; }
        public List<string>? AttackBonus { get; }
        public List<string>? ArmorBonus { get; }
        public int? SearchRadius { get; }
        public string? Accuracy { get; }
        public decimal? BlastRadius { get; }

        /*public Unit(
            int id,
            string name,
            string expansion,
            string age,
            string createdIn,
            Cost cost,
            int buildTime,
            decimal reloadTime,
            decimal movementRate,
            int lineOfSight,
            int hitPoints,
            int attack,
            string armor,
            string? description,
            decimal? attackDelay,
            string? range,
            List<string>? attackBonus,
            List<string>? armorBonus,
            int? searchRadius,
            string? accuracy,
            decimal? blastRadius
        )
        {
            Id = id;
            Name = name;
            Expansion = expansion;
            Age = age;
            CreatedIn = createdIn;
            Cost = cost;
            BuildTime = buildTime;
            ReloadTime = reloadTime;
            MovementRate = movementRate;
            LineOfSight = lineOfSight;
            HitPoints = hitPoints;
            Attack = attack;
            Armor = armor;
            Description = description;
            AttackDelay = attackDelay;
            Range = range;
            AttackBonus = attackBonus;
            ArmorBonus = armorBonus;
            SearchRadius = searchRadius;
            Accuracy = accuracy;
            BlastRadius = blastRadius;
        }*/
    }
}