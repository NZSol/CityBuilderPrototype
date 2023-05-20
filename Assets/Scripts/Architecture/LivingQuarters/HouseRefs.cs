using Architecture;
using System.Collections;
using System.Collections.Generic;

#nullable enable

namespace Architecture.References
{
    public class HouseRefs
    {
        public ICollection<Person> People { get; set; }
        public ICollection<Material> Materials { get; set; }
        public ICollection<Food> Food { get; set; }
    }
}
