namespace MelderErfassung.DomainModel
{
    public class Prüfer
    {
        public string Name { get; set; }

        public void FührePrüfauftragDurch(Prüfauftrag auftrag, EventHub eventHub)
        {
            auftrag.SetToInProgress(Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}