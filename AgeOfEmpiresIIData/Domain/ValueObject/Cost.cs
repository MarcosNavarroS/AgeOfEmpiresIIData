namespace AgeOfEmpiresIIData.Domain.ValueObject
{
    public class Cost
    {
        private int? Wood { get; }
        private int? Food { get; }
        private int? Stone { get; }
        private int? Gold { get; }

        public Cost(int? wood, int? food, int? stone, int? gold)
        {
            Wood = wood;
            Food = food;
            Stone = stone;
            Gold = gold;
        }
    }
}