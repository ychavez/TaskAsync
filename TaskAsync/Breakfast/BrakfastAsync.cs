using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAsync.Breakfast
{
    public static class BrakfastAsync
    {
        public static async Task MilCoffee()
        {
            List<Task> tareas = new();

            for (int i = 0; i < 1_000_000; i++)
            {
                tareas.Add(Coffee());
            }

            await Task.WhenAll(tareas);

            Console.WriteLine("Se ejecutaron todos los cafes");
        }


        public static async Task DoBreakfast()
        {
            var coffeTask = Coffee();

            var heatPanTask = HeatPan();

            await heatPanTask;

            var eggsTask = FryEggs();
            var baconTask = FryBacon();

            var breadTask = ToastBread();
            await breadTask;
            var jamTask = Jam();

            var juiceTask = Juice();

            await coffeTask;
            await eggsTask;
            await baconTask;
            await jamTask;
            await juiceTask;
        }

        public static async Task Coffee()
        {
            await Task.Delay(1000);
           // Console.WriteLine("Cofee");
        }
        public static async Task HeatPan()
        {
            await Task.Delay(1000);
            Console.WriteLine("Pan");
        }
        public static async Task FryEggs()
        {
            await Task.Delay(1000);
            Console.WriteLine("Eggs");
        }
        public static async Task FryBacon()
        {
            await Task.Delay(1000);
            Console.WriteLine("Bacon");
        }
        public static async Task ToastBread()
        {
            await Task.Delay(1000);
            Console.WriteLine("Bread");
        }
        public static async Task Jam()
        {
            await Task.Delay(1000);
            Console.WriteLine("Jam");
        }
        public static async Task Juice()
        {
            await Task.Delay(1000);
            Console.WriteLine("Juice");
        }

    }
}
