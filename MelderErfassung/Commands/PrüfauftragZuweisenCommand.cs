namespace MelderErfassung.Commands
{
    public class PrüfauftragZuweisenCommand : ICommand
    {
        public string AuftragsId { get; }
        public string PrüferName { get; }

        public PrüfauftragZuweisenCommand(string auftragsId, string prüferName)
        {
            AuftragsId = auftragsId;
            PrüferName = prüferName;
        }
    }
}