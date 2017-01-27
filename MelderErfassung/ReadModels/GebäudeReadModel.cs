using System.Collections.Generic;

namespace MelderErfassung.ReadModels
{
    public class GebäudeReadModel
    {
        public IEnumerable<Gebäude> Gebäude { get; private set; }
    }
}