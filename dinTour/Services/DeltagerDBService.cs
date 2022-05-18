using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;
using Microsoft.EntityFrameworkCore;

namespace dinTour.Services
{
    public class DeltagerDBService : DBGService<Deltager>
    {
        public async Task<Deltager> GetParkeringByUserIdAsync(int id)
        {
            Deltager user;

            using (var context = new dinTourDbContext())
            {
                user = context.Deltagere
                    .Include(u => u.Bookning)
                    .ThenInclude(i => i.Parkering)
                    .AsNoTracking()
                    .FirstOrDefault(u => u.DeltagerId == id);
            }
            return user;
        }
    }
}
