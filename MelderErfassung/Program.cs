using System;
using System.Linq;
using MelderErfassung.CommandHandler;
using MelderErfassung.Commands;
using MelderErfassung.DomainModel;
using MelderErfassung.EventHandler;
using MelderErfassung.ReadModels;

namespace MelderErfassung
{
    class Program
    {
        private static EventHub _eventHub;
        private static Repository _repository;

        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args)
        {
            _eventHub = new EventHub();
            _eventHub.RegisterEventHandler(new PrüfauftragAngelegtEventHandler());
            _eventHub.RegisterEventHandler(new PrüfauftragZugewiesenEventHandler());
            _eventHub.RegisterEventHandler(new PrüfauftragSchonInPrüfungEventHandler());

            _repository = new Repository(_eventHub);

            ErzeugeNeuenPrüfauftrag();
            AuftragsReadModel.Print();

            var auftrag = AuftragsReadModel.Aufträge.FirstOrDefault();
            WeisePrüfauftragZu(auftrag, "Frank");
            AuftragsReadModel.Print();

            WeisePrüfauftragZu(auftrag, "Frank");
            AuftragsReadModel.Print();

            Console.ReadKey();
        }

        private static void WeisePrüfauftragZu(Auftrag auftrag, string prüferName)
        {
            var h = new PrüfauftragZuweisenCommandHandler(_repository, _eventHub);
            h.Handle(new PrüfauftragZuweisenCommand(auftrag.AuftragsId, prüferName));
        }


        private static void ErzeugeNeuenPrüfauftrag()
        {
            var h = new PrüfauftragAnlegenCommandHandler(_repository, _eventHub);
            h.Handle(new PrüfauftragAnlegenCommand("Kunde1", "fluidmobile.Gebäude"));
        }
    }
}
