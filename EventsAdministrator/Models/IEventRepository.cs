using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAdministrator.Models
{
    public interface IEventRepository
    {
        void Add(Event ev);
        void Delete(int index);
        void Clear();
        void Serialize(string path);
        IEnumerable<Event> Deserialize(string path);
        IEnumerable<Event> Sort(string key);
        IEnumerable<Event> Filter(string key);
    }
}
