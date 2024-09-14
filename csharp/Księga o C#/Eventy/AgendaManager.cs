using System;
using System.Threading;

namespace Eventy
{
    public class AgendaManager
    {
        public delegate void AddedAgendaEventHandler(object o, AgendaEventArgs e);
        public event AddedAgendaEventHandler AddedAgenda;
        
        //EventHandler
        //EventHandler<TEventArgs>

        public event EventHandler<AgendaEventArgs> AddedAgendShorter;

        // <summary>
        //     Zasady Eventów:
        // powinien być Event publisher
        // protected
        // virtual
        // void
        // </summary>


        protected virtual void OnAddedAgenda(Agenda newAgenda)
        {
            if (AddedAgenda!=null)
            {
                AddedAgenda(this, new AgendaEventArgs() { Agenda = newAgenda});
            }
        }

        protected virtual void OnAddedAgendShorter(Agenda newAgenda)
        {
          if (AddedAgendShorter!=null)
            {
                AddedAgendShorter(this, new AgendaEventArgs() { Agenda = newAgenda});
            }  
        }

        public void AddAgenda(Agenda newAgenda)
        {
            System.Console.WriteLine("AddAgenda: Zaczynam dodawać...");
            Thread.Sleep(3000);
            OnAddedAgenda(newAgenda);
            OnAddedAgendShorter(newAgenda);
            System.Console.WriteLine("AddAgenda: Skończyłem dodawać...");
        }
    }
}