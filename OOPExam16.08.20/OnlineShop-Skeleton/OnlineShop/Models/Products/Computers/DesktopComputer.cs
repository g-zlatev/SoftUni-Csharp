namespace OnlineShop.Models.Products.Computers
{
    public class DesktopComputer : Computer
    {
        public DesktopComputer(int id, string manufacturer, string model, decimal price, double overallPerformance) : base(id, manufacturer, model, price, overallPerformance)
        {
            
        }


        public double OverallPerformance => 15;
    }
}
