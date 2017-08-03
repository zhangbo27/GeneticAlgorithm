﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MathEquations
{
    public static class Equation1
    {
        // e.g. a + 2b + 3c + 4d = 30

        public const int VariableCount = 4;

        public static int CalculateFitness(IEnumerable<int> variables)
        {
            var eqVar = variables.ToArray();
            var fitness = Math.Abs(eqVar[0] + 2 * eqVar[1] + 3 * eqVar[2] + 4 * eqVar[3] - 30);
            return fitness;
        }
    }
}