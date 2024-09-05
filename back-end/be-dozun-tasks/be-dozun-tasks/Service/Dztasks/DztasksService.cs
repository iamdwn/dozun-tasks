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

        public bool DeleteTasks(Tasks task)
        {
            throw new NotImplementedException();
        }

        public List<Tasks> GetTasks()
        {
            return _dbContext.Tasks.OrderByDescending(x => x.Id).ToList();
        }

        public bool UpdateTasks(Tasks task)
        {
            throw new NotImplementedException();
        }
    }
}
