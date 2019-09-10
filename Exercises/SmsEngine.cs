using System;

namespace Classes
{
    public class SmsEngine : IWorkflowObject
    {
        public void Execute()
        {
            Console.WriteLine("Sending text message to user.");
        }
    }
}