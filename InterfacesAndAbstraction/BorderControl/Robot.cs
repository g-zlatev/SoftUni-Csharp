using System.Globalization;

namespace BorderControl
{
    public class Robot : IIdentifiable
    {

        public Robot()
        {
            
        }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get; private set; }

        public string Id { get; private set; }

    }
}
