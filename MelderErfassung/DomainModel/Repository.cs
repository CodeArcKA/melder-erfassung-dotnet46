using System.Collections.Generic;
using System.Linq;

namespace MelderErfassung.DomainModel
{
    public class Repository
    {
        private IList<Prüfauftrag> _auftragsListe = new List<Prüfauftrag>();
        private IList<Prüfer> _prüferListe = new List<Prüfer>()
        {
            new Prüfer()
            {
                Name = "Christoph"
            },
            new Prüfer()
            {
                Name = "Frank"
            }
        };
        private EventHub _eventHub;

        public Repository(EventHub eventHub)
        {
            _eventHub = eventHub;
        }

        public void AddPrüftrag(Prüfauftrag auftrag)
        {
            // TODO: validate auftrag
            _auftragsListe.Add(auftrag);
        }

        public Prüfauftrag GetPrüfauftragById(string auftragsId)
        {
            return _auftragsListe.FirstOrDefault(p => p.AuftragsId == auftragsId);
        }

        public Prüfer GetPrüferByName(string prüferName)
        {
            return _prüferListe.FirstOrDefault(p => p.Name == prüferName);
        }
    }
}