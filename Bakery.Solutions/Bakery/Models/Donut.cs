namespace Bakery.Models
{
    public class Donut
    {
        public int DonutPrice { get; set; }
        public void DonutCost(int numberOfDonuts)
        {
            if(numberOfDonuts >= 12)
            {
                int numberOfDozens = (numberOfDonuts / 12);
                int numberOfSingles = (numberOfDonuts % 12);
                DonutPrice = (numberOfDozens * 10) + (numberOfSingles * 2); 
            }
            else
            {
                DonutPrice = (numberOfDonuts * 2);
            }
        }
    }
}