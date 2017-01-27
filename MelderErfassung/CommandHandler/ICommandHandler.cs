using MelderErfassung.Commands;

namespace MelderErfassung.CommandHandler
{
    public interface ICommandHandler<in TCommand> where TCommand: ICommand
    {
        void Handle(TCommand prüfauftragAnlegenCommand);
    }
}