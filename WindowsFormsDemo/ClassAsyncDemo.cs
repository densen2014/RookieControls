using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncBreakfast
{
    //static class Program
    //{
    //    /// <summary>
    //    ///使用 Async 和 Await 的异步编程 
    //    /// </summary>
    //    /// <returns></returns>
    //    public static async Task Main()
    //    {
 
    //        //倒一杯咖啡。
    //        Coffee cup = PourCoffee();
    //        Console.WriteLine("coffee is ready");

    //        //加热平底锅,然后煎两个鸡蛋。
    //        var eggsTask = FryEggsAsync(2);
            
    //        //煎三片培根。
    //        var baconTask = FryBaconAsync(3);

    //        //烤两片面包,在烤面包上加黄油和果酱。
    //        var toastTask = MakeToastWithButterAndJamAsync(2);

    //        var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
    //        while (breakfastTasks.Count > 0)
    //        {
    //            Task finishedTask = await Task.WhenAny(breakfastTasks);
    //            if (finishedTask == eggsTask)
    //            {
    //                Console.WriteLine("eggs are ready 煎蛋");
    //            }
    //            else if (finishedTask == baconTask)
    //            {
    //                Console.WriteLine("bacon is ready 培根");
    //            }
    //            else if (finishedTask == toastTask)
    //            {
    //                Console.WriteLine("toast is ready 面包");
    //            }
    //            breakfastTasks.Remove(finishedTask);
    //        }
    //        //倒一杯橙汁
    //        Juice oj = PourOJ();
    //        Console.WriteLine("oj is ready 橙汁");
    //        Console.WriteLine("Breakfast is ready!");
    //    }

         
       
    //    /// <summary>
    //    /// 在烤面包上加黄油和果酱,在提供早餐之前，你希望等待表示先烤面包再添加黄油和果酱的任务完成
    //    /// </summary>
    //    /// <param name="number"></param>
    //    /// <returns></returns>
    //    static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
    //    {
    //        var toast = await ToastBreadAsync(number);
    //        ApplyButter(toast);
    //        ApplyJam(toast);

    //        return toast;
    //    }

    //    private static async Task<Toast> ToastBreadAsync(int slices)
    //    {
    //        for (int slice = 0; slice < slices; slice++)
    //        {
    //            Console.WriteLine("Putting a slice of bread in the toaster 面包");
    //        }
    //        Console.WriteLine("Start toasting... 面包");
    //        await Task.Delay(3000);
    //        Console.WriteLine("Remove toast from toaster");

    //        return new Toast();
    //    }

    //    private static void ApplyJam(Toast toast) =>
    //        Console.WriteLine("Putting jam on the toast 加黄油");

    //    private static void ApplyButter(Toast toast) =>
    //        Console.WriteLine("Putting butter on the toast 加果酱");



    //    private static Juice PourOJ()
    //    {
    //        Console.WriteLine("Pouring orange juice 橙汁");
    //        return new Juice();
    //    }

    //    /// <summary>
    //    /// 煎三片培根
    //    /// </summary>
    //    /// <param name="slices"></param>
    //    /// <returns></returns>
    //    private static async Task<Bacon> FryBaconAsync(int slices)
    //    {
    //        Console.WriteLine($"putting {slices} slices of bacon in the pan 培根");
    //        Console.WriteLine("cooking first side of bacon... 培根");
    //        await Task.Delay(3000);
    //        for (int slice = 0; slice < slices; slice++)
    //        {
    //            Console.WriteLine("flipping a slice of bacon");
    //        }
    //        Console.WriteLine("cooking the second side of bacon...");
    //        await Task.Delay(3000);
    //        Console.WriteLine("Put bacon on plate");

    //        return new Bacon();
    //    }


    //    /// <summary>
    //    /// 加热平底锅,然后煎两个鸡蛋
    //    /// </summary>
    //    /// <param name="howMany"></param>
    //    /// <returns></returns>
    //    private static async Task<Egg> FryEggsAsync(int howMany)
    //    {
    //        Console.WriteLine("Warming the egg pan...加热平底锅");
    //        await Task.Delay(3000);
    //        Console.WriteLine($"cracking {howMany} eggs 鸡蛋");
    //        Console.WriteLine("cooking the eggs ...");
    //        await Task.Delay(3000);
    //        Console.WriteLine("Put eggs on plate");

    //        return new Egg();
    //    }

    //    /// <summary>
    //    /// 倒一杯咖啡
    //    /// </summary>
    //    /// <returns></returns>
    //    private static Coffee PourCoffee()
    //    {
    //        Console.WriteLine("Pouring coffee 咖啡");
    //        return new Coffee();
    //    }
    //}

    internal class Toast
    {
    }

    internal class Bacon
    {
        public Bacon()
        {
        }
    }

    internal class Juice
    {
    }

    internal class Egg
    {
        public Egg()
        {
        }
    }

    internal class Coffee
    {
    }
}