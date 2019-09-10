using System;

namespace Classes
{
    public class VideoEngine : IWorkflowObject
    {
        public void Execute()
        {
            Console.WriteLine("Sending video through pipeline.");
        }
    }
}