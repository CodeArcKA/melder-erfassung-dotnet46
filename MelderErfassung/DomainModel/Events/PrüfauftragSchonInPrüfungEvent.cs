namespace MelderErfassung.DomainModel.Events
{
    public class PrüfauftragSchonInPrüfungEvent : IEvent
    {
        public string AuftragsId { get; }

        public PrüfauftragSchonInPrüfungEvent(string auftragsId)
        {
            AuftragsId = auftragsId;
        }
    }
}