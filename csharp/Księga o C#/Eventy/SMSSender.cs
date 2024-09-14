using System;

namespace Eventy
{
    public class SMSSender
    {
        public void OnAddedAgender(object o, AgendaEventArgs e)
        {
            System.Console.WriteLine("SMS Sender: SMS was send !!! Data: " + e.Agenda.AgendaDate + " Tytuł: " + e.Agenda.AgendaName);
        }
        public void OnAddedAgendShorter(object o, AgendaEventArgs e)
        {
            System.Console.WriteLine("SMS Sender: SMS was send !!! Data: " + e.Agenda.AgendaDate + " Tytuł: " + e.Agenda.AgendaName);
        }
    }
}