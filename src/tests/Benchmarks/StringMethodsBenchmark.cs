using BenchmarkDotNet.Attributes;
using Perfolizer.Mathematics.OutlierDetection;
using System;
using ValidatorLib;
using ValidatorLib.Validators;

namespace Benchmarks
{
    [Outliers(OutlierMode.DontRemove)]
    public class StringMethodsBenchmark
    {
        [Benchmark]
        public void IsEmailAddress()
        {
            Validator.Validate("asd@asd.com").IsEmailAddress();
        }

        [Benchmark]
        public void IsEmailAddressException()
        {
            try
            {
                Validator.Validate("asdasd.com").IsEmailAddress();
            }
            catch (Exception)
            {
            }
        }

        [Benchmark]
        public void IsPhoneNumber()
        {
            Validator.Validate("123456789").IsPhoneNumber();
        }

        [Benchmark]
        public void IsPhoneNumberException()
        {
            try
            {
                Validator.Validate("a").IsPhoneNumber();
            }
            catch (Exception)
            {
            }
        }

        [Benchmark]
        public void MinLength()
        {
            Validator.Validate("asd").MinLength(1);
        }

        [Benchmark]
        public void MinLengthException()
        {
            try
            {
                Validator.Validate("asd").MinLength(4);
            }
            catch (Exception)
            {
            }
        }

        [Benchmark]
        public void MaxLength()
        {
            Validator.Validate("asd").MaxLength(5);
        }

        [Benchmark]
        public void MaxLengthException()
        {
            try
            {
                Validator.Validate("asd").MaxLength(2);
            }
            catch (Exception)
            {
            }
        }

        [Benchmark]
        public void IsEmpty()
        {
            Validator.Validate("").IsEmpty();
        }

        [Benchmark]
        public void IsEmptyException()
        {
            try
            {
                Validator.Validate("1").IsEmpty();
            }
            catch (Exception)
            {
            }
        }

        [Benchmark]
        public void IsNotEmpty()
        {
            Validator.Validate("1").IsNotEmpty();
        }

        [Benchmark]
        public void IsNotEmptyException()
        {
            try
            {
                Validator.Validate("").IsNotEmpty();
            }
            catch (Exception)
            {
            }
        }

        [Benchmark]
        public void Only()
        {
            Validator.Validate("asd").Only(StringValidator.CharType.SmallLetters);
        }

        [Benchmark]
        public void OnlyException()
        {
            try
            {
                Validator.Validate("Asd").Only(StringValidator.CharType.SmallLetters);
            }
            catch (Exception)
            {
            }
        }

        [Benchmark]
        public void Contains()
        {
            Validator.Validate("aSD").Contains(StringValidator.CharType.SmallLetters);
        }

        [Benchmark]
        public void ContainsException()
        {
            try
            {
                Validator.Validate("ASD").Contains(StringValidator.CharType.SmallLetters);
            }
            catch (Exception)
            {
            }
        }
    }
}
