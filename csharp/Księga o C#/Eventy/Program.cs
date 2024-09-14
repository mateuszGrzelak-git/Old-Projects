using System;

namespace Eventy
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaManager amgr = new AgendaManager();
            SMSSender sms = new SMSSender();

            amgr.AddedAgenda += sms.OnAddedAgender;
            amgr.AddedAgendShorter += sms.OnAddedAgendShorter;

            amgr.AddAgenda(new Agenda()
            {
                AgendaDate = DateTime.Now.AddDays(2),
                AgendaName = "Kubuś Puchatek"
            });

            Console.ReadKey();
        }
    }
}
//1. AgendaMenager