using System;
using System.Collections.Generic;
using System.Linq;

namespace TodoApi.Models
{
    public class TodoRepositoryDb : ITodoRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TodoRepositoryDb(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TodoItem item)
        {
            throw new NotImplementedException();
        }

        public TodoItem Find(string key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _dbContext.Items.AsEnumerable();
        }

        public TodoItem Remove(string key)
        {
            throw new NotImplementedException();
        }

        public void Update(TodoItem item)
        {
            throw new NotImplementedException();
        }
    }
}