using System.Linq;
using MelderErfassung.DomainModel;
using MelderErfassung.DomainModel.Events;
using MelderErfassung.ReadModels;

namespace MelderErfassung.EventHandler
{
    public class PrüfauftragZugewiesenEventHandler : IEventHandler<PrüfauftragZugewiesenEvent>
    {
        public void Handle(PrüfauftragZugewiesenEvent eventToHandle)
        {
            var auftrag = AuftragsReadModel.Aufträge.First(p => p.AuftragsId == eventToHandle.PrüfAuftragId);
            auftrag.Status = "In Prüfung";
        }
    }
}
