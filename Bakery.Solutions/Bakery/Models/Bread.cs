namespace Bakery.Bread
{
    public class Loaves
    {
        public int BreadPrice { get; set; }

        public void BreadCost(int numberOfLoaves)
        {
            if(numberOfLoaves >= 3)
            {
                int numberOfDeals = (numberOfLoaves / 3);
                int numberOfSingleLoaves = (numberOfLoaves % 3);
                BreadPrice = (numberOfDeals * 10) + (numberOfSingleLoaves * 5);
            }
            else 
            {
                BreadPrice = (numberOfLoaves * 5);
            }
        }
    }
}