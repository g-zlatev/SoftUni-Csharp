namespace OnlineShop.Models.Products.Components
{
    class CentralProcessingUnit : Component
    {
        public CentralProcessingUnit(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) : base(id, manufacturer, model, price, overallPerformance, generation)
        {
          
        }

        //TODO: Check overallPerformance override
        public override double OverallPerformance => base.OverallPerformance * 1.25;

    }
}
