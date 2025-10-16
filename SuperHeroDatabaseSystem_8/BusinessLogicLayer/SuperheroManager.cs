using SuperheroDatabaseSystem_8.DataAccessLayer;
using SuperHeroDatabaseSystem_8.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperHeroDatabaseSystem_8.BusinessLogicLayer
{
    public class SuperheroManager
    {
        private readonly SuperheroRepository repository = new SuperheroRepository();

        // Get all superheroes
        public List<Superhero> GetAllHeroes()
        {
            return repository.ReadAll();
        }

        // Add new superhero
        public void AddHero(Superhero hero)
        {
            ValidateHero(hero);
            repository.Add(hero);
        }

        //  Update existing superhero
        public void UpdateHero(Superhero hero)
        {
            ValidateHero(hero);
            repository.Update(hero);
        }

        //  Delete superhero by ID
        public void DeleteHero(string heroId)
        {
            if (string.IsNullOrWhiteSpace(heroId))
                throw new Exception("Hero ID cannot be empty.");

            repository.Delete(heroId);
        }

        //  Generate summary report
        public SummaryReport GenerateSummary()
        {
            var heroes = repository.ReadAll();

            if (heroes.Count == 0)
                return new SummaryReport(); // return empty report if file is empty

            return new SummaryReport
            {
                TotalHeroes = heroes.Count,
                AverageAge = heroes.Average(h => h.Age),
                AverageExamScore = heroes.Average(h => h.ExamScore),
                CountS = heroes.Count(h => h.Rank == "S-Rank"),
                CountA = heroes.Count(h => h.Rank == "A-Rank"),
                CountB = heroes.Count(h => h.Rank == "B-Rank"),
                CountC = heroes.Count(h => h.Rank == "C-Rank")
            };
        }
        public void SaveSummaryToFile(SummaryReport summary)
        {
            string summaryPath = "summary.txt";

            using (var writer = new System.IO.StreamWriter(summaryPath, false)) // false = overwrite, true = append
            {
                writer.WriteLine($"Total Heroes: {summary.TotalHeroes}");
                writer.WriteLine($"Average Age: {summary.AverageAge:0.00}");
                writer.WriteLine($"Average Exam Score: {summary.AverageExamScore:0.00}");
                writer.WriteLine($"S-Rank: {summary.CountS}");
                writer.WriteLine($"A-Rank: {summary.CountA}");
                writer.WriteLine($"B-Rank: {summary.CountB}");
                writer.WriteLine($"C-Rank: {summary.CountC}");
                writer.WriteLine("=======================================");
                writer.WriteLine($"Summary generated on: {DateTime.Now}");
                writer.WriteLine("---------------------------------------");

            }
        }


        //  Input validation
        private void ValidateHero(Superhero hero)
        {
            if (string.IsNullOrWhiteSpace(hero.HeroID))
                throw new Exception("Hero ID is required.");
            if (string.IsNullOrWhiteSpace(hero.Name))
                throw new Exception("Hero name is required.");
            if (hero.Age <= 0)
                throw new Exception("Age must be greater than 0.");
            if (hero.ExamScore < 0 || hero.ExamScore > 100)
                throw new Exception("Exam score must be between 0 and 100.");
        }
    }
}
