using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Exercises_S6_L38
{
    public class WorkflowEngine
    {
        private readonly IList<IActivity> _activities;

        public WorkflowEngine()
        {
            _activities = new List<IActivity>();
        }

        public void Run(Activity activity)
        {
            foreach (var a in _activities)
                a.Execute(new Activity());
        }

        public void RegisterActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
    }
}