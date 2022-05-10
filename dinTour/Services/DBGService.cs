using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;
using Microsoft.EntityFrameworkCore;

namespace dinTour.Services
{
    public class DBGService<T> : IService<T> where T : class
    {
        public async Task<IEnumerable<T>> GetObjectsAsync()
        {
            using (var context = new dinTourDbContext())
            {
                return await context.Set<T>().AsNoTracking().ToListAsync();
            }
        }
        public async Task UpdateObjectAsync(T obj)
        {
            using (var context = new dinTourDbContext())
            {
                context.Set<T>().Update(obj);
                await context.SaveChangesAsync();
            }
        }
        public async Task<T> GetObjectByIdAsync(int id)
        {
            using (var context = new dinTourDbContext())
            {
                return await context.Set<T>().FindAsync(id);
            }
        }

        public Task AddObjectAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public Task DeleteObjectAsync(T obj)
        {
            throw new NotImplementedException();
        }
    }
}

