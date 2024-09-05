using be_dozun_tasks.Data;
using be_dozun_tasks.Models;

namespace be_dozun_tasks.Service.Dztasks
{
    public class DztasksService : IDztasksService
    {
        private readonly DztasksDbContext _dbContext;

        public DztasksService(DztasksDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddTasks(Tasks task)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTasks(int id)
        {
            Tasks task = _dbContext.Tasks.Find(id);
            task.isComplete = true;
            _dbContext.SaveChanges();
            return true;
        }

        public List<Tasks> GetTasks()
        {
            return _dbContext.Tasks
                .OrderByDescending(x => x.Id)
                .Where(x => !x.isComplete)
                .ToList();
        }

        public bool UpdateTasks(Tasks task)
        {
            throw new NotImplementedException();
        }
    }
}
