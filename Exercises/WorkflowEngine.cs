using System;
using System.Collections.Generic;

namespace Classes
{
    public class WorkflowEngine
    {
        private readonly List<IWorkflowObject> _workflowObjects;

        public WorkflowEngine()
        {
            _workflowObjects = new List<IWorkflowObject>();
        }

        public void Run()
        {
            foreach (var workflow in _workflowObjects)
            {
                workflow.Execute();
            }
        }

        public void AddWorkflowObject(IWorkflowObject workflowObject)
        {
            _workflowObjects.Add(workflowObject);
        }
    }
}