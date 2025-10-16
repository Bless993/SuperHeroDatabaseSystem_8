using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SuperHeroDatabaseSystem_8.BusinessLogicLayer;

namespace SuperheroDatabaseSystem_8.DataAccessLayer
{
    public class SuperheroRepository
    {
        private readonly string filePath = "superheroes.txt";

        public List<Superhero> ReadAll()
        {
            var heroes = new List<Superhero>();

            if (!File.Exists(filePath))
                return heroes;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var data = line.Split(',');
                if (data.Length == 7)
                {
                    heroes.Add(new Superhero(
                        data[0], data[1], int.Parse(data[2]), data[3], int.Parse(data[4])
                    ));
                }
            }
            return heroes;
        }

        public void Add(Superhero hero)
        {
            File.AppendAllText(filePath, hero.ToString() + Environment.NewLine);
        }

        public void Update(Superhero updatedHero)
        {
            var heroes = ReadAll();
            var existing = heroes.FirstOrDefault(h => h.HeroID == updatedHero.HeroID);

            if (existing != null)
            {
                heroes.Remove(existing);
                heroes.Add(updatedHero);
                SaveAll(heroes);
            }
        }

        public void Delete(string heroId)
        {
            var heroes = ReadAll();
            heroes.RemoveAll(h => h.HeroID == heroId);
            SaveAll(heroes);
        }

        private void SaveAll(List<Superhero> heroes)
        {
            File.WriteAllLines(filePath, heroes.Select(h => h.ToString()));
        }
    }
}
