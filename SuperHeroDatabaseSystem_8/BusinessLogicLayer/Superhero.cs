using System;

namespace SuperHeroDatabaseSystem_8.BusinessLogicLayer
{
    public class Superhero
    {
        public string HeroID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Superpower { get; set; }
        public int ExamScore { get; set; }
        public string Rank { get; set; }
        public string ThreatLevel { get; set; }

        // Constructor
        public Superhero(string id, string name, int age, string power, int score)
        {
            HeroID = id;
            Name = name;
            Age = age;
            Superpower = power;
            ExamScore = score;

            Rank = CalculateRank(score);
            ThreatLevel = GetThreatLevel(Rank);
        }

        // Calculate Rank based on Exam Score
        public static string CalculateRank(int score)
        {
            if (score >= 81) return "S-Rank";
            if (score >= 61) return "A-Rank";
            if (score >= 41) return "B-Rank";
            return "C-Rank";
        }

        // Determine Threat Level from Rank
        public static string GetThreatLevel(string rank)
        {
            switch (rank)
            {
                case "S-Rank": return "Finals Week";
                case "A-Rank": return "Midterm Madness";
                case "B-Rank": return "Group Project Gone Wrong";
                default: return "Pop Quiz";
            }
        }

        // Used for saving hero info to text file
        public override string ToString()
        {
            return $"{HeroID},{Name},{Age},{Superpower},{ExamScore},{Rank},{ThreatLevel}";
        }
    }
}
