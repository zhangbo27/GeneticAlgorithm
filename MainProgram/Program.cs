﻿using System;
using GeneticAlgoProblems;
using GeneticAlgorithm;

namespace MainProgram
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var problem = new Equation1();

            Constants.ChromosomeLength = problem.VariableCount;
            Constants.GeneMin = problem.VariableMin;
            Constants.GeneMax = problem.VariableMax;

            var algo = new Algorithm {FitnessFunction = problem.CalculateFitness};

            var bestSolution = algo.FindBestSolution();
            Console.WriteLine($"Chromosome: {bestSolution}, Fitness:{bestSolution.Fitness}");

            watch.Stop();
            Console.WriteLine($"Elapsed time in Milliseconds: {watch.ElapsedMilliseconds}");

            Console.ReadLine();
        }
    }
}
