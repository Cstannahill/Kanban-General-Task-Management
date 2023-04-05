using Models.Domain;
using Models.Domain.TaskBoard;
using Models.Domain.Tasks;
using Models.Requests.Tasks;
using Sabio.Models.Requests;
using Sabio.Models.Requests.Tasks;
using System.Collections.Generic;

namespace Sabio.Services.Interfaces
{
    public interface ITaskService
    {
        public List<KanbanTask> GetAll();

        public KanbanTask Get(int id);

        public int Add(TaskAddRequest model, int userId);

        public void Update(TaskUpdateRequest model, int userId);

        public void Delete(int id);

        public List<TaskCategory> GetAllCategories();

        public List<TaskCategoryWithTasks> GetTaskLists();

        public int CreateLabel(TaskLabelAddRequest model);

        public void AddTaskLabel(LabelTaskAddRequest model);

        public List<TaskBoardMinimum> GetUserList(int userId);

        public TaskBoard GetTaskBoardById(int boardId);
        public int CreateTaskBoard(TaskBoardAddRequest model, int userId);
        public int CreateCategory(TaskCategoryAddRequest model);
    }
}