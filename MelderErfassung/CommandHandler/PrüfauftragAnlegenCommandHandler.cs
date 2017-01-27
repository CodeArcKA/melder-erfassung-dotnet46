using MelderErfassung.Commands;
using MelderErfassung.DomainModel;

namespace MelderErfassung.CommandHandler
{
    public class PrüfauftragAnlegenCommandHandler : ICommandHandler<PrüfauftragAnlegenCommand>
    {
        private readonly Repository _repo;
        private readonly EventHub _eventHub;

        public PrüfauftragAnlegenCommandHandler(Repository repo, EventHub eventHub)
        {
            _repo = repo;
            _eventHub = eventHub;
        }

        public void Handle(PrüfauftragAnlegenCommand prüfauftragAnlegenCommand)
        {
            _repo.AddPrüftrag(new Prüfauftrag(prüfauftragAnlegenCommand.KundenId, prüfauftragAnlegenCommand.GebäudeId, _eventHub));
        }
    }
}