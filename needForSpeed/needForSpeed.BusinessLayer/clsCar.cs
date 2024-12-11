namespace needForSpeed.BusinessLayer
{
    public class clsCar
    {

        public clsCar(string brand, string model, int yearOfProduction, int horePower, int acceleration, int suspension, int durability)
        {
            this.brand = brand;
            this.model = model;
            this.yearOfProduction = yearOfProduction;
            this.horePower = horePower;
            this.acceleration = acceleration;
            this.suspension = suspension;
            this.durability = durability;
        }

        public string brand { get; set; }
        public string model { get; set; }
        public int yearOfProduction { get; set; }
        public int horePower { get; set; }
        public int acceleration { get; set; }
        public int suspension { get; set; }
        public int durability { get; set; }



    }

    public class clsPerformanceCar : clsCar
    {
        public clsPerformanceCar(string brand, string model, int yearOfProduction, int horePower, int acceleration, int suspension, int durability) : base(brand, model, yearOfProduction, horePower, acceleration, suspension, durability)
        {

        }

        protected List<string> addOnes = new List<string>();

        public void Increase()
        {
            horePower = (int)(horePower * 1.50);
        }
        public void Decrease()
        {
            suspension = (int)(suspension / 1.25);
        }

        public void AddOnes(string brand)
        {
            addOnes.Add(brand);
        }

        
    }

    public class clsShowCar : clsCar
    {

        public clsShowCar(string brand, string model, int yearOfProduction, int horePower, int acceleration, int suspension, int durability, int stars = 0) : base(brand, model, yearOfProduction, horePower, acceleration, suspension, durability)
        {
            this.stars = stars;
        }

        public int stars { get; set; }


    }

}
