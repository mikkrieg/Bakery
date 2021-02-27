namespace Bakery.Pastry
{
    public class Pastries
    {
        public int PastryPrice { get; set; }
        public void PastryCost(int numberOfPastries)
        {
            if(numberOfPastries >= 3)
            {
                int numberOfBundles = (numberOfPastries / 3);
                int numberOfSingles = (numberOfPastries % 3);
                PastryPrice = (numberOfBundles * 5) + (numberOfSingles * 2);
            }
            else 
            {
                PastryPrice = (numberOfPastries * 2);
            }
        }
    }
}