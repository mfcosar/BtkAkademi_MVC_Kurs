﻿namespace BtkAkademi.Models
{
    public class Repository
    {
        private static List<Candidate> applications = new List<Candidate>();
        public static IEnumerable<Candidate> Applications =>    applications;

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);

        }
    }
}
