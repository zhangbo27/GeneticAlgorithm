﻿using System;

namespace GeneticAlgorithm
{
    public static class Constants
    {
        private const int RandomSeed = 297;

        public const int InitialPopulation = 10000;
        public const int MaxPopulation = 1000000;
        public const int MaxGeneration = 30;
        public const int OldGeneration = 4;

        public const int MaxNumOfParents = 1000;
        public const float MutationRate = 0.55F; 

        public static readonly Random MyRandom = new Random(RandomSeed);

        public static int ChromosomeLength { get; set; }
        public static int GeneMin { get; set; }
        public static int GeneMax { get; set; }
    }
}