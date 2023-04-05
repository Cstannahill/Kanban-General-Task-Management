using System.Collections.Generic;

namespace Models.Domain.Tasks
{
    public class KanbanTasksWithCat
    {
        public List<KanbanTask> Tasks { get; set; }
        public List<TaskCategory> TaskCategories { get; set; }
    }
}