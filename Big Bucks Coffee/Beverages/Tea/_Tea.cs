namespace Big_Bucks_Coffee
{
    internal abstract class _Tea : Beverage
    {
        public int Theine { get; set; }

        public bool HasMilk { get; set; }

        public bool HasSugar { get; set; }

        public _Tea()
        {
            Name = "Tea";
            Image = "/Images/Tea.png";
            DefaultImage = "/Images/Tea.png";
        }
    }
}