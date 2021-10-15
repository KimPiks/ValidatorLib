using System;
using BenchmarkDotNet.Attributes;
using Perfolizer.Mathematics.OutlierDetection;
using ValidatorLib;

namespace Benchmarks
{
    [Outliers(OutlierMode.DontRemove)]
    public class GuidMethodsBenchmark
    {
        [Benchmark]
        public void IsEmpty()
        {
            Validator.Validate(default(Guid)).IsEmpty();
        }

        [Benchmark]
        public void IsEmptyException()
        {
            try
            {
                Validator.Validate(new Guid()).IsEmpty();
            }
            catch (Exception)
            {
            }
        }

        [Benchmark]
        public void IsNotEmpty()
        {
            Validator.Validate(new Guid()).IsNotEmpty();
        }

        [Benchmark]
        public void IsNotEmptyException()
        {
            try
            {
                Validator.Validate(default(Guid)).IsNotEmpty();
            }
            catch (Exception)
            {
            }
        }
    }
}
