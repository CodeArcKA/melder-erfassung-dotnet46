using System;
using MelderErfassung.DomainModel;
using MelderErfassung.DomainModel.Events;

namespace MelderErfassung.EventHandler
{
    public class PrüfauftragSchonInPrüfungEventHandler : IEventHandler<PrüfauftragSchonInPrüfungEvent>
    {
        public void Handle(PrüfauftragSchonInPrüfungEvent eventToHandle)
        {
            Console.WriteLine($"Achtung Auftrag {eventToHandle.AuftragsId} schon in Prüfung");
        }
    }
}