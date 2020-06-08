namespace Application.Boundaries.GetUnit
{
    public sealed class GetUnitInput
    {
        public GetUnitInput(int unitId) => UnitId = unitId;

        public int UnitId { get; }
    }
}