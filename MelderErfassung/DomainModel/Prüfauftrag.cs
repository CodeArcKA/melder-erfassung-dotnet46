using System;
using MelderErfassung.DomainModel.Events;

namespace MelderErfassung.DomainModel
{
    public class Prüfauftrag
    {
        private string _kundenId;
        private string _gebäudeId;
        private readonly EventHub _eventHub;
        public readonly string AuftragsId;

        internal void SetToInProgress(string name)
        {
            Apply(new PrüfauftragZugewiesenEvent(AuftragsId, name));
        }

        private void Apply(PrüfauftragZugewiesenEvent prüfauftragZugewiesenEvent)
        {
            if (_status != "Neu")
            {
                _eventHub.Publish(new PrüfauftragSchonInPrüfungEvent(AuftragsId));
                return;
            }

            _eventHub.Publish(prüfauftragZugewiesenEvent);
            _status = "In Prüfung";
        }

        private string _status;

        public Prüfauftrag(string kundenId, string gebäudeId, EventHub eventHub)
        {
            _status = "Neu";
            AuftragsId = Guid.NewGuid().ToString("N");
            _kundenId = kundenId;
            _gebäudeId = gebäudeId;
            _eventHub = eventHub;

            // Raise -> Publish
            _eventHub.Publish(new PrüfauftragAngelegtEvent(_kundenId, _gebäudeId, AuftragsId));
        }
    }
}