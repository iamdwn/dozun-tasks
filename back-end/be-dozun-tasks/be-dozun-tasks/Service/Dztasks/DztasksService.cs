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
            _dbContext.Tasks.Add(task);
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteTasks(int id)
        {
            Tasks task = _dbContext.Tasks.Find(id);
            _dbContext.Tasks.Remove(task);
            _dbContext.SaveChanges();
            return true;
        }

        public List<Tasks> GetTasks()
        {
            return _dbContext.Tasks.OrderByDescending(x => x.Id).ToList();
        }

        public bool UpdateTasks(Tasks task)
        {
            _dbContext.Tasks.Update(task);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
