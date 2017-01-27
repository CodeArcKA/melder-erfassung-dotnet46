namespace MelderErfassung.ReadModels
{
    public class Auftrag
    {
        public Auftrag()
        {
            Status = "Neu";
        }

        public string AuftragsId { get; set; }
        public string KundenId { get; set; }
        public string Geb�udeId { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"AuftragsId: {AuftragsId}\tKundenId: {KundenId}\tGeb�udeId: {Geb�udeId}\tStatus: {Status}";
        }
    }
}