using BlingBackend.Logic.Interfaces;
using BlingBackend.Model;
using BlingBackeng.Data.Interface;

namespace BlingBackend.Logic
{
    public class TaskLogic : LogicBase<Task>, ITaskLogic
    {
        private readonly ITaskRepository _taskRepository;

        public TaskLogic(ITaskRepository taskRepository) 
            : base(taskRepository)
        {
            _taskRepository = taskRepository;
        }
    }
}