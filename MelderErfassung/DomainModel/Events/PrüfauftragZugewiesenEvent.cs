namespace MelderErfassung.DomainModel.Events
{
    public class PrüfauftragZugewiesenEvent : IEvent
    {
        public string PrüfAuftragId { get; }
        public string PrüferName { get; }

        public PrüfauftragZugewiesenEvent(string prüfAuftragId, string prüferName)
        {
            PrüfAuftragId = prüfAuftragId;
            PrüferName = prüferName;
        }
    }
}