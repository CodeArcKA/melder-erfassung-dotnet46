namespace MelderErfassung.Commands
{
    public class PrüfauftragAnlegenCommand : ICommand
    {
        public string KundenId { get; private set; }
        public string GebäudeId { get; private set; }

        public PrüfauftragAnlegenCommand(string kundenId, string gebäudeId)
        {
            KundenId = kundenId;
            GebäudeId = gebäudeId;
        }
    }
}