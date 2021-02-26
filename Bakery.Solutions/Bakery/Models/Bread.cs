namespace Bakery.Bread
{
    public class Loaves
    {
        public int BreadPrice {get; set;}

        public int BreadCost(int numberOfLoaves)
        {
            int numberOfDeals = (numberOfLoaves / 3);
            int numberOfSingleLoaves = (numberOfLoaves % 3);
            BreadPrice = (numberOfDeals * 10) + (numberOfSingleLoaves * 5);
            return BreadPrice;
        }
    }
}