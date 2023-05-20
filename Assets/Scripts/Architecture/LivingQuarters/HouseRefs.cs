using Architecture;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Architecture.References
{
    public class HouseRefs
    {
        public ICollection<Person> People { get; set; }
        public Dictionary<string, int> Materials { get; set; }
        public Dictionary<string, int> Food { get; set; }

        public void AddToDict<T>(T item, int count)
        {
            string key = item.GetType().Name;
            if (item is Material)
            {
                if (Materials.ContainsKey(key))
                {
                    Materials[key] += count;
                    if(Materials[key] == 0)
                    {
                        Materials.Remove(key);
                    }
                }
                else
                {
                    Materials.Add(key, count);
                }
            }
            else if(item is Food)
            {
                if (Materials.ContainsKey(key))
                {
                    Food[key] += count;
                    if (Food[key] == 0)
                    {
                        Food.Remove(key);
                    }
                }
                else
                {
                    Food.Add(key, count);
                }
            }
            else
            {
                throw new InvalidOperationException("Incorrect type");
            }
        }

        public void Add(Person person)
        {
            var collection = People.ToList();
            collection.Add(person);
            People = collection;
        }
    }
}

