using System;

namespace Exercises_S6_L38
{
    public class CallWebSerivce : IActivity
    {
        public void Execute(Activity activity)
        {
            Console.WriteLine("Calling web service...");
        }
    }
}