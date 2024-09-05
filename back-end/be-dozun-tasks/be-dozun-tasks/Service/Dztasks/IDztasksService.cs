using be_dozun_tasks.Models;

namespace be_dozun_tasks.Service.Dztasks
{
    public interface IDztasksService
    {
        List<Tasks> GetTasks();
        Boolean AddTasks(Tasks task);
        Boolean UpdateTasks(Tasks task);
        Boolean DeleteTasks(int id);
    }
}
