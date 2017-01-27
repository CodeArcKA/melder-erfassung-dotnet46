using System.Collections.Generic;

namespace MelderErfassung.ReadModels
{
    public class Gebäude    
    {
        public string Id { get; set; }
        public IEnumerable<Etage> Etagen { get; private set; }
    }
}