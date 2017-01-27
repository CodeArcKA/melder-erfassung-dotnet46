using MelderErfassung.DomainModel;

namespace MelderErfassung.Tests
{
    public class TestEventHandler : IEventHandler<TestEvent>
    {
        public bool Run { get; private set; }

        public TestEventHandler(bool run)
        {
            Run = run;
        }
        public void Handle(TestEvent eventToHandle)
        {
            Run = true;
        }
    }
}