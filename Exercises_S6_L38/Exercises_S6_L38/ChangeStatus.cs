using System;

namespace Exercises_S6_L38
{
    public class ChangeStatus : IActivity
    {
        public void Execute(Activity activity)
        {
            Console.WriteLine("Changing DB status...");
        }
    }
}