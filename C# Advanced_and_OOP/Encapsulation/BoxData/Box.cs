namespace BoxData
{
    public class Box
    {
        private const string InvalidSideMessage = "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                ValidateSide(value, nameof(this.Length));

                this.length = value;
            }
        }


        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                ValidateSide(value, nameof(this.Width));

                this.width = value;
            }
        }


        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                ValidateSide(value, nameof(this.Height));

                this.height = value;
            }
        }

        public double CalculateSurfaceArea()
        {
            double surfaceArea = 2 * (this.length * this.width) + 2 * (this.length * this.height) + 2 * (this.width * this.height);
            return surfaceArea;
        }

        public double CalculateLateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (this.length * this.height) + 2 * (this.width * this.height);
            return lateralSurfaceArea;
        }

        public double CalculateVolume()
        {
            double volume = this.length * this.width * this.height;
            return volume;

        }
        private void ValidateSide(double value, string sideName)
        {
            if (value <= 0)
            {
                //Console.WriteLine(string.Format(InvalidSideMessage, sideName));
                throw new System.ArgumentException(string.Format(InvalidSideMessage, sideName));
            }

        }
    }
}
