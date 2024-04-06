namespace RpgSim
{
    public static class EnumExtensions
    {
        private static Random random = new Random();

        public static T GetRandom<T>()
        {
            Type enumType = typeof(T);

            if (!enumType.IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }

            Array values = Enum.GetValues(enumType);
            int randomIndex = random.Next(values.Length);

            return (T)values.GetValue(randomIndex);
        }
    }
}
