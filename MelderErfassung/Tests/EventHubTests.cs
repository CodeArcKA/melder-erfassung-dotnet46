using FluentAssertions;
using MelderErfassung.DomainModel;
using NUnit.Framework;

namespace MelderErfassung.Tests
{
    [TestFixture]
    public class EventHubTests
    {
        [Test]
        public void TestEventHandler()
        {
            var eventHub = new EventHub();
            var handler = new TestEventHandler(false);
            eventHub.RegisterEventHandler(handler);
            eventHub.Publish(new TestEvent());
            handler.Run.Should().BeTrue();
        }        
    }
}