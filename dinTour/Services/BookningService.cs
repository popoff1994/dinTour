using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;

namespace dinTour.Services
{
    public class BookningService
    {
        public List<Bookning> BookningList { get; set; }

        public DBGService<Bookning> DbService { get; set; }

       public BookningService(DBGService<Bookning> dbService)
       {
          DbService = dbService;
          BookningList = DbService.GetObjectsAsync().Result.ToList();
       }

       public async void AddBookning(Bookning booking)
       {
          BookningList.Add(booking);
          await DbService.AddObjectAsync(booking);
       }
    }
}
