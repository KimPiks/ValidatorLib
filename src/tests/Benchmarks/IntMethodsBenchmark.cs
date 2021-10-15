using System;
using BenchmarkDotNet.Attributes;
using Perfolizer.Mathematics.OutlierDetection;
using ValidatorLib;

namespace Benchmarks
{
    [Outliers(OutlierMode.DontRemove)]
    public class IntMethodsBenchmark
    {
        [Benchmark]
        public void IsPositive()
        {
            Validator.Validate(1).IsPositive();
        }

        [Benchmark]
        public void IsPositiveException()
        {
            try
            {
                Validator.Validate(-1).IsPositive();
            }
            catch (Exception)
            {
            }
        }

        [Benchmark]
        public void IsNegative()
        {
            Validator.Validate(-1).IsNegative();
        }

        [Benchmark]
        public void IsNegativeException()
        {
            try
            {
                Validator.Validate(1).IsNegative();
            }
            catch (Exception)
            {
            }
        }
    }
}
