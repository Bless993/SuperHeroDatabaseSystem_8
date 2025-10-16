namespace SuperHeroDatabaseSystem_8.BusinessLogicLayer
{
    public class SummaryReport
    {
        public int TotalHeroes { get; set; }
        public double AverageAge { get; set; }
        public double AverageExamScore { get; set; }

        public int CountS { get; set; }
        public int CountA { get; set; }
        public int CountB { get; set; }
        public int CountC { get; set; }

        // Optional: Constructor to initialize values
        public SummaryReport()
        {
            TotalHeroes = 0;
            AverageAge = 0;
            AverageExamScore = 0;
            CountS = 0;
            CountA = 0;
            CountB = 0;
            CountC = 0;
        }
    }
}
