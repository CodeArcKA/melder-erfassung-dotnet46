namespace MelderErfassung.DomainModel.Events
{
    public class PrüfauftragAngelegtEvent : IEvent
    {
        public readonly string AuftragsId;
        public readonly string AuftragGebäudeId;
        public readonly string AuftragKundenId;

        public PrüfauftragAngelegtEvent(string auftragKundenId, string auftragGebäudeId, string auftragsId)
        {
            AuftragsId = auftragsId;
            AuftragGebäudeId = auftragGebäudeId;
            AuftragKundenId = auftragKundenId;
        }
    }
}