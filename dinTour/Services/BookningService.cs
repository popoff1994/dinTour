using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;

namespace dinTour.Services
{
    public class BookningService
    {
        public List<Bookning> ParkeringList { get; set; }

       public DBGService<Bookning> DbService { get; set; }

       public BookningService(DBGService<Bookning> dbService)
       {
          DbService = dbService;
          //ParkeringList = DbService.GetObjectsAsync().Result.ToList();
       }

       public async void AddBookning(Bookning booking)
       {
          ParkeringList.Add(booking);
          //await DbService.AddObjectAsync(booking);
       }
    }
}
