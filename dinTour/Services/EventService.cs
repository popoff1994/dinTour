using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dinTour.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace dinTour.Services
{
    public class EventService
    {
        public List<Event> Events { get; set; }
        public DBGService<Event> DbService { get; set; }
        


        public EventService(DBGService<Event> dbService)
        {
            
            DbService = dbService;
            //Events = MockData.MockEvent.GetAllBegivenheder().ToList();
            Events = DbService.GetObjectsAsync().Result.ToList();
            //foreach (var eventet in Events)
            //{
            //    dbService.AddObjectAsync(eventet);
            //}

        }


        public List<Event> GetEvents()
        {
            return Events;
        }

        public Event GetEvent(int id)
        {
            foreach (Event item in Events)
            {
                if (item.EventId == id) return item;
            }
            return null;
        }


        public void TilmeldEvent(Event eventet)
        {
            foreach (Event i in Events)
                {
                    if (i.EventId == eventet.EventId)
                    {

                        i.AntalTilmeldte = i.AntalTilmeldte + eventet.AntalTilmeldte;
                        break;

                    }
                    DbService.UpdateObjectAsync(eventet);
                }

            }
        
    }
}
