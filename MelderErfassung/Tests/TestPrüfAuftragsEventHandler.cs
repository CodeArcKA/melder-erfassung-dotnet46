using MelderErfassung.DomainModel;
using MelderErfassung.DomainModel.Events;

namespace MelderErfassung.Tests
{
    public class TestPrüfAuftragsEventHandler : IEventHandler<PrüfauftragAngelegtEvent>
    {
        public void Handle(PrüfauftragAngelegtEvent eventToHandle)
        {
            KundenId = eventToHandle.AuftragKundenId;
        }

        public string KundenId { get; set; }

        public bool Run { get; set; }
    }
}