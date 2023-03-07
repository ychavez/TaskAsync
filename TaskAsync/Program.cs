
using System.Diagnostics;
using TaskAsync.Breakfast;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var timmer = new Stopwatch();

        timmer.Start();
        // Classic.DoBreakfast();

      await BrakfastAsync.DoBreakfast();
        timmer.Stop();

        Console.WriteLine($"Pasaron {timmer.Elapsed}");

    }
}