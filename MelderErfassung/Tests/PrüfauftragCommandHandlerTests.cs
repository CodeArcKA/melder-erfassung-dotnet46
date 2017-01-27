using System.Runtime.InteropServices;
using FluentAssertions;
using MelderErfassung.CommandHandler;
using MelderErfassung.Commands;
using MelderErfassung.DomainModel;
using NUnit.Framework;

namespace MelderErfassung.Tests
{
    [TestFixture]
    public class PrüfauftragCommandHandlerTests
    {
        [Test]
        public void CommandHandlerRuns()
        {
            var eventHub = new EventHub();
            var testHandler = new TestPrüfAuftragsEventHandler();
            eventHub.RegisterEventHandler(testHandler);
            var sut = new PrüfauftragAnlegenCommandHandler(new Repository(eventHub), eventHub);

            sut.Handle(new PrüfauftragAnlegenCommand("1", "2"));
            testHandler.KundenId.Should().Be("1");
        }
    }
}