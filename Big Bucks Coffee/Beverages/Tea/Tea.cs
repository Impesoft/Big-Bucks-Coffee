namespace Big_Bucks_Coffee
{
    internal abstract class Tea : Beverage
    {
        public int Theine { get; set; }

        public bool HasMilk { get; set; }

        public bool HasSugar { get; set; }

        public Tea()
        {
            Name = "Tea";
            Image = "/Images/mint.jpg";
        }
    }
}