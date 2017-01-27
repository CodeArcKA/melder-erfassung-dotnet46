using MelderErfassung.Commands;
using MelderErfassung.DomainModel;

namespace MelderErfassung.CommandHandler
{
    public class PrüfauftragZuweisenCommandHandler : ICommandHandler<PrüfauftragZuweisenCommand>
    {
        private readonly Repository _repo;
        private readonly EventHub _eventHub;

        public PrüfauftragZuweisenCommandHandler(Repository repo, EventHub eventHub)
        {
            _repo = repo;
            _eventHub = eventHub;
        }

        public void Handle(PrüfauftragZuweisenCommand prüfauftragAnlegenCommand)
        {
            var prüfauftrag = _repo.GetPrüfauftragById(prüfauftragAnlegenCommand.AuftragsId);
            var prüfer = _repo.GetPrüferByName(prüfauftragAnlegenCommand.PrüferName);
            prüfer.FührePrüfauftragDurch(prüfauftrag, _eventHub);
        }
    }
}