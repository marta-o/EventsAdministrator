using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EventsAdministrator.Models
{
    public class EventRepository : IEventRepository
    {
        private List<Event> _repositoryList;
        public EventRepository()
        {
            _repositoryList = new List<Event>();
        }
        public void Add(Event ev)
        {
            _repositoryList.Add(ev);
        }
        public void Delete(int id)
        {
            _repositoryList.RemoveAt(id);
        }
        public void Clear()
        {
            _repositoryList.Clear();
        }
        public void Serialize(string path)
        {
            if (File.Exists(path))
            {
                List<Event> existingEvents = new List<Event>();
                using (FileStream existingFileStream = new FileStream(path, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Event>));
                    existingEvents = (List<Event>)serializer.Deserialize(existingFileStream);
                }

                foreach (var newEvent in _repositoryList)
                {
                    if (!existingEvents.Any(ev => ev.Title == newEvent.Title && ev.Date == newEvent.Date))
                    {
                        existingEvents.Add(newEvent);
                    }
                }

                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Event>));
                    serializer.Serialize(fs, existingEvents);
                }
            }
        }

        public IEnumerable<Event> Deserialize(string path)
        {
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Event>));
                    return (List<Event>)serializer.Deserialize(fs);
                }
            }
            else return Enumerable.Empty<Event>();

        }

        public IEnumerable<Event> Sort(string key)
        {
            if (key == "Po dacie")
            {
                return _repositoryList.OrderBy(ev => ev.Date).ToList();
            }
            else if (key == "Po typie")
            {
                return _repositoryList.OrderBy(ev => ev.Type).ToList();
            }
            else if (key == "Po priorytecie")
            {
                return _repositoryList.OrderByDescending(ev => ev.Priority).ToList();
            }
            else
            {
                return _repositoryList.ToList();
            }
        }
        public IEnumerable<Event> Filter(string key)
        {
            //string pattern = @"[0-9]{2}\.[0-9]{2}\.[0-9]{4}";
            if (key == "Niski" || key == "Średni" || key == "Wysoki")
            {
                return _repositoryList.Where(ev => ev.Priority == key).ToList();
            }
            else if (key == "Praca" || key == "Rodzina" || key == "Przyjaciele" || key == "Rozrywka" || key == "Zdrowie" || key == "Sport" || key == "Inne")
            {
                return _repositoryList.Where(ev => ev.Type == key).ToList();
            }
            else if (Regex.IsMatch(key, @"[0-9]{2}\.[0-9]{2}\.[0-9]{4}"))
            {
                return _repositoryList.Where(ev => ev.Date.ToShortDateString() == key).ToList();
            }
            else
            {
                return _repositoryList.ToList();
            }
        }

    }
}
