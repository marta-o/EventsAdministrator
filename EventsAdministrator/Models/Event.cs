using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAdministrator.Models
{
    public class Event
    {
        public string Title { get; set; }
        public string Info { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }

        public override string ToString()
        {
            return $"Wydarzenie: {Title}, data: {Date}, typ: {Type}, priorytet: {Priority}, opis: {Info}";
        }

        public Event(string title, string info, DateTime date, string type, string priority)
        {
            Title = title;
            Info = info;
            Date = date;
            Type = type;
            Priority = priority;
        }

        public Event() { }
       
    }
}
