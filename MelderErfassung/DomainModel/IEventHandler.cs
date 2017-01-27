namespace MelderErfassung.DomainModel
{
    public interface IEventHandler<TEvent>
    {
        void Handle(TEvent eventToHandle);
    }
}