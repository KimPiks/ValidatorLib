using System;
using BenchmarkDotNet.Attributes;
using Perfolizer.Mathematics.OutlierDetection;
using ValidatorLib;

namespace Benchmarks
{
    [Outliers(OutlierMode.DontRemove)]
    public class ObjectMethodsBenchmark
    {
        [Benchmark]
        public void IsNull()
        {
            Validator.Validate((object)null).IsNull();
        }

        [Benchmark]
        public void IsNullException()
        {
            try
            {
                Validator.Validate(new object()).IsNull();
            }
            catch (Exception)
            {
            }
        }

        [Benchmark]
        public void IsNotNull()
        {
            Validator.Validate(new object()).IsNotNull();
        }

        [Benchmark]
        public void IsNotNullException()
        {
            try
            {
                Validator.Validate((object)null).IsNotNull();
            }
            catch (Exception)
            {
            }
        }
    }
}
