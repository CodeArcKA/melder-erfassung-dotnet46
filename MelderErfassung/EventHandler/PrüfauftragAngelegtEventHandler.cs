using MelderErfassung.DomainModel;
using MelderErfassung.DomainModel.Events;
using MelderErfassung.ReadModels;

namespace MelderErfassung.EventHandler
{
    public class PrüfauftragAngelegtEventHandler : IEventHandler<PrüfauftragAngelegtEvent>
    {
        public void Handle(PrüfauftragAngelegtEvent eventToHandle)
        {
            AuftragsReadModel.Aufträge.Add(new Auftrag()
            {
                AuftragsId = eventToHandle.AuftragsId,
                KundenId = eventToHandle.AuftragKundenId,
                GebäudeId = eventToHandle.AuftragGebäudeId
            });
        }
    }
}
