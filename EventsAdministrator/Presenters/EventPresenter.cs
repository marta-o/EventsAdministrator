using EventsAdministrator.Views;
using EventsAdministrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EventsAdministrator.Presenters
{
    internal class EventPresenter
    {
        private Models.IEventRepository _repository;
        private Views.IEventView _view;
        private IEnumerable<Event> _events;
        
        public EventPresenter(Views.IEventView view, Models.IEventRepository model)
        {
            _view = view;
            _repository = model;

            _view.AddNewEvent += AddEventToGrid;
            _view.DeleteEvent += DeleteEventFromGrid;
            _view.SerializeEvent += SerializeEvents;
            _view.DeserializeEvent += DeserializeEvents;
            _view.SortEvent += SortEvents;
            _view.FilterEvent += FilterEvents;
            _events = new List<Event>();
        }

        private void AddEventToGrid(object sender, EventArgs e) 
        {
            if (_view.SetErrorTitle() && _view.SetErrorInfo() && _view.SetErrorType() && _view.SetErrorPriority())
            {
                var ev = new Models.Event(_view.Title, _view.Info, _view.Date, _view.Type, _view.Priority);
                _repository.Add(ev);
                _view.DataGridUpdate(ev);
                _view.Clear();
            }
        }
        private void DeleteEventFromGrid(object sender, EventArgs e)
        {
            var id = _view.DataGridDeleteRows();
            if (id.Count > 0)
            {
                foreach (int i in id)
                {
                    _repository.Delete(i);
                }
            }
        }
        private void SerializeEvents(object sender, EventArgs e)
        {
            _repository.Serialize("eventsList.xml");
        }
        private void DeserializeEvents(object sender, EventArgs e)
        {
            _view.DataGridClear();
            _events = _repository.Deserialize("eventsList.xml");
            _repository.Clear();
            foreach(var ev in _events)
            {
                _repository.Add(ev);
                _view.DataGridUpdate(ev);
            }
        }
        private void SortEvents(object sender, EventArgs e)
        {
            DeserializeEvents(sender, e);
            _view.DataGridClear();
            _events = _repository.Sort(_view.Sort);
            _repository.Clear();
            
            foreach(var ev in _events)
            {
                _repository.Add(ev);
                _view.DataGridUpdate(ev);
            }
        }

        private void FilterEvents(object sender, EventArgs e)
        {
            DeserializeEvents(sender, e);
            _view.DataGridClear();
            _events = _repository.Filter(_view.Filter);
            _repository.Clear();

            foreach(var ev in _events)
            {
                _repository.Add(ev);
                _view.DataGridUpdate(ev);
            }
        }
    }
}
