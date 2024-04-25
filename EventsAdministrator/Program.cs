using EventsAdministrator.Models;
using EventsAdministrator.Presenters;
using EventsAdministrator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsAdministrator
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IEventView view = new EventView();
            IEventRepository model = new EventRepository();
            new EventPresenter(view, model);
            Application.Run((Form) view);
        }
    }
}
