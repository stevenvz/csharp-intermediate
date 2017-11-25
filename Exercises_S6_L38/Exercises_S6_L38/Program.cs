using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_S6_L38
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            workflowEngine.RegisterActivity(new CallWebSerivce());
            workflowEngine.RegisterActivity(new UploadVideo());
            workflowEngine.RegisterActivity(new ChangeStatus());
            workflowEngine.RegisterActivity(new SendMessage());

            workflowEngine.Run(new Activity());
        }
    }
}
