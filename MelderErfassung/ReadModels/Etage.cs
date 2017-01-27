using System.Collections.Generic;

namespace MelderErfassung.ReadModels
{
    public class Etage
    {
        public string Id { get; set; }
        public IEnumerable<Melder> Melder { get; set; }
    }
}