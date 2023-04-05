using System.Collections.Generic;

namespace Models.Domain.Tasks
{
    public class TaskCategoryWithTasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<KanbanTask> Tasks { get; set; }
    }
}