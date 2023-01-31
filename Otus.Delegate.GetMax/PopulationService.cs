namespace OTUS.Delegate.GetMax
{
    public class PopulationService
    {
        public static float GetPopulationDensity(Country country)
        {
            return country.Square / country.Population;
        }
    }
}
