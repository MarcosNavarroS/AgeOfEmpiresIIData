using System.Collections.Generic;
using Domain.ValueObjects;

namespace Domain.Units
{
    public interface IUnit
    {
        int Id { get; }
        string Name { get; }
        string Expansion { get; }
        string Age { get; }
        string CreatedIn { get; }
        Cost Cost { get; }
        int BuildTime { get; }
        decimal ReloadTime { get; }
        decimal MovementRate { get; }
        int LineOfSight { get; }
        int HitPoints { get; }
        int Attack { get; }
        string Armor { get; }
        string? Description { get; }
        decimal? AttackDelay { get; }
        string? Range { get; }
        List<string>? AttackBonus { get; }
        List<string>? ArmorBonus { get; }
        int? SearchRadius { get; }
        string? Accuracy { get; }
        decimal? BlastRadius { get; }
    }
}