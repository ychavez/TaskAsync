namespace TaskAsync.Breakfast
{
    public static class Classic
    {
        public static void DoBreakfast() 
        {
            Coffee();
            HeatPan();
            FryEggs();
            FryBacon();
            ToastBread();
            Jam();
            Juice();
        }

        public static void Coffee()
        {
          Thread.Sleep(1000);
        }
        public static void HeatPan()
        {
            Thread.Sleep(1000);
        }
        public static void FryEggs()
        {
            Thread.Sleep(1000);
        }
        public static void FryBacon()
        {
            Thread.Sleep(1000);
        }
        public static void ToastBread()
        {
            Thread.Sleep(1000);
        }
        public static void Jam()
        {
            Thread.Sleep(1000);
        }
        public static void Juice()
        {
            Thread.Sleep(1000);
        }


    }
}
