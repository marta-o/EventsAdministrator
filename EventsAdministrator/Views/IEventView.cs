using EventsAdministrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAdministrator.Views
{
    internal interface IEventView
    {
        string Title { get; set; }
        string Info { get; set; }
        DateTime Date { get; set; }
        string Type { get; set; }
        string Priority { get; set; }
        string Sort { get; }
        string Filter {  get; }

        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler SerializeEvent;
        event EventHandler DeserializeEvent;
        event EventHandler SortEvent;
        event EventHandler FilterEvent;

        bool SetErrorTitle();
        bool SetErrorInfo();
        bool SetErrorType();
        bool SetErrorPriority();

        bool SetErrorSort();
        bool SetErrorFilter();

        void DataGridUpdate(Event ev);
        void DataGridClear();
        List<int> DataGridDeleteRows();
        void Clear();
    }
}
