namespace math.net.xladdin
{
    using System;
    using System.Collections.Generic;
    using ExcelDna.Integration;

    internal static class ExcelMathNet
    {
        [ExcelFunction(Name = "MN.Euclid.Modulus", Description=@"Canonical Modulus. The result has the sign of the divisor.")]
        public static object Euclid_Modulus([ExcelArgument(Name = "dividend")] System.Double dividend, [ExcelArgument(Name = "divisor")] System.Double divisor)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Euclid_Modulus_Internal(dividend, divisor);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Euclid.Remainder", Description=@"Remainder (% operator). The result has the sign of the dividend.")]
        public static object Euclid_Remainder([ExcelArgument(Name = "dividend")] System.Double dividend, [ExcelArgument(Name = "divisor")] System.Double divisor)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Euclid_Remainder_Internal(dividend, divisor);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Euclid.IsEven", Description=@"Find out whether the provided 32 bit integer is an even number.")]
        public static object Euclid_IsEven([ExcelArgument(Name = "number")] System.Int32 number)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Euclid_IsEven_Internal(number);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Euclid.IsOdd", Description=@"Find out whether the provided 32 bit integer is an odd number.")]
        public static object Euclid_IsOdd([ExcelArgument(Name = "number")] System.Int32 number)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Euclid_IsOdd_Internal(number);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Euclid.IsPowerOfTwo", Description=@"Find out whether the provided 32 bit integer is a perfect power of two.")]
        public static object Euclid_IsPowerOfTwo([ExcelArgument(Name = "number")] System.Int32 number)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Euclid_IsPowerOfTwo_Internal(number);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Euclid.IsPerfectSquare", Description=@"Find out whether the provided 32 bit integer is a perfect square, i.e. a square of an integer.")]
        public static object Euclid_IsPerfectSquare([ExcelArgument(Name = "number")] System.Int32 number)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Euclid_IsPerfectSquare_Internal(number);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Euclid.PowerOfTwo", Description=@"Raises 2 to the provided integer exponent (0 <= exponent < 31).")]
        public static object Euclid_PowerOfTwo([ExcelArgument(Name = "exponent")] System.Int32 exponent)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Euclid_PowerOfTwo_Internal(exponent);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Euclid.Log2", Description=@"Evaluate the binary logarithm of an integer number.")]
        public static object Euclid_Log2([ExcelArgument(Name = "number")] System.Int32 number)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Euclid_Log2_Internal(number);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Euclid.CeilingToPowerOfTwo", Description=@"Find the closest perfect power of two that is larger or equal to the provided
        32 bit integer.")]
        public static object Euclid_CeilingToPowerOfTwo([ExcelArgument(Name = "number")] System.Int32 number)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Euclid_CeilingToPowerOfTwo_Internal(number);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Euclid.GreatestCommonDivisor_2", Description=@"Returns the greatest common divisor (gcd) of two integers using Euclid's algorithm.")]
        public static object Euclid_GreatestCommonDivisor_2([ExcelArgument(Name = "a")] System.Int64 a, [ExcelArgument(Name = "b")] System.Int64 b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Euclid_GreatestCommonDivisor_2_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Euclid.GreatestCommonDivisor_1", Description=@"Returns the greatest common divisor (gcd) of a set of integers using Euclid's algorithm.")]
        public static object Euclid_GreatestCommonDivisor_1([ExcelArgument(Name = "integers")] System.Int64[] integers)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Euclid_GreatestCommonDivisor_1_Internal(integers);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Euclid.LeastCommonMultiple_2", Description=@"Returns the least common multiple (lcm) of two integers using Euclid's algorithm.")]
        public static object Euclid_LeastCommonMultiple_2([ExcelArgument(Name = "a")] System.Int64 a, [ExcelArgument(Name = "b")] System.Int64 b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Euclid_LeastCommonMultiple_2_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Euclid.LeastCommonMultiple_1", Description=@"Returns the least common multiple (lcm) of a set of integers using Euclid's algorithm.")]
        public static object Euclid_LeastCommonMultiple_1([ExcelArgument(Name = "integers")] System.Int64[] integers)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Euclid_LeastCommonMultiple_1_Internal(integers);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.LinearSpaced", Description=@"Generate a linearly spaced sample vector of the given length between the specified values (inclusive).
        Equivalent to MATLAB linspace but with the length as first instead of last argument.")]
        public static object Generate_LinearSpaced([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "start")] System.Double start, [ExcelArgument(Name = "stop")] System.Double stop)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_LinearSpaced_Internal(length, start, stop);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.LogSpaced", Description=@"Generate a base 10 logarithmically spaced sample vector of the given length between the specified decade exponents (inclusive).
        Equivalent to MATLAB logspace but with the length as first instead of last argument.")]
        public static object Generate_LogSpaced([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "startExponent")] System.Double startExponent, [ExcelArgument(Name = "stopExponent")] System.Double stopExponent)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_LogSpaced_Internal(length, startExponent, stopExponent);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.LinearRange_2", Description=@"Generate a linearly spaced sample vector within the inclusive interval (start, stop) and step 1.
        Equivalent to MATLAB colon operator (:).")]
        public static object Generate_LinearRange_2([ExcelArgument(Name = "start")] System.Int32 start, [ExcelArgument(Name = "stop")] System.Int32 stop)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_LinearRange_2_Internal(start, stop);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.LinearRange_3", Description=@"Generate a linearly spaced sample vector within the inclusive interval (start, stop) and the provided step.
        The start value is aways included as first value, but stop is only included if it stop-start is a multiple of step.
        Equivalent to MATLAB double colon operator (::).")]
        public static object Generate_LinearRange_3([ExcelArgument(Name = "start")] System.Int32 start, [ExcelArgument(Name = "step")] System.Int32 step, [ExcelArgument(Name = "stop")] System.Int32 stop)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_LinearRange_3_Internal(start, step, stop);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.LinearRangeInt32_2", Description=@"Generate a linearly spaced sample vector within the inclusive interval (start, stop) and step 1.
        Equivalent to MATLAB colon operator (:).")]
        public static object Generate_LinearRangeInt32_2([ExcelArgument(Name = "start")] System.Int32 start, [ExcelArgument(Name = "stop")] System.Int32 stop)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_LinearRangeInt32_2_Internal(start, stop);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.LinearRangeInt32_3", Description=@"Generate a linearly spaced sample vector within the inclusive interval (start, stop) and the provided step.
        The start value is aways included as first value, but stop is only included if it stop-start is a multiple of step.
        Equivalent to MATLAB double colon operator (::).")]
        public static object Generate_LinearRangeInt32_3([ExcelArgument(Name = "start")] System.Int32 start, [ExcelArgument(Name = "step")] System.Int32 step, [ExcelArgument(Name = "stop")] System.Int32 stop)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_LinearRangeInt32_3_Internal(start, step, stop);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.Periodic", Description=@"Create a periodic wave.")]
        public static object Generate_Periodic([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "samplingRate")] System.Double samplingRate, [ExcelArgument(Name = "frequency")] System.Double frequency, [ExcelArgument(Name = "amplitude")] System.Double amplitude, [ExcelArgument(Name = "phase")] System.Double phase, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_Periodic_Internal(length, samplingRate, frequency, amplitude, phase, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.PeriodicSequence", Description=@"Create an infinite periodic wave sequence.")]
        public static object Generate_PeriodicSequence([ExcelArgument(Name = "samplingRate")] System.Double samplingRate, [ExcelArgument(Name = "frequency")] System.Double frequency, [ExcelArgument(Name = "amplitude")] System.Double amplitude, [ExcelArgument(Name = "phase")] System.Double phase, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_PeriodicSequence_Internal(samplingRate, frequency, amplitude, phase, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.Sinusoidal", Description=@"Create a Sine wave.")]
        public static object Generate_Sinusoidal([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "samplingRate")] System.Double samplingRate, [ExcelArgument(Name = "frequency")] System.Double frequency, [ExcelArgument(Name = "amplitude")] System.Double amplitude, [ExcelArgument(Name = "mean")] System.Double mean, [ExcelArgument(Name = "phase")] System.Double phase, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_Sinusoidal_Internal(length, samplingRate, frequency, amplitude, mean, phase, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.SinusoidalSequence", Description=@"Create an infinite Sine wave sequence.")]
        public static object Generate_SinusoidalSequence([ExcelArgument(Name = "samplingRate")] System.Double samplingRate, [ExcelArgument(Name = "frequency")] System.Double frequency, [ExcelArgument(Name = "amplitude")] System.Double amplitude, [ExcelArgument(Name = "mean")] System.Double mean, [ExcelArgument(Name = "phase")] System.Double phase, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_SinusoidalSequence_Internal(samplingRate, frequency, amplitude, mean, phase, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.Square", Description=@"Create a periodic square wave, starting with the high phase.")]
        public static object Generate_Square([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "highDuration")] System.Int32 highDuration, [ExcelArgument(Name = "lowDuration")] System.Int32 lowDuration, [ExcelArgument(Name = "lowValue")] System.Double lowValue, [ExcelArgument(Name = "highValue")] System.Double highValue, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_Square_Internal(length, highDuration, lowDuration, lowValue, highValue, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.SquareSequence", Description=@"Create an infinite periodic square wave sequence, starting with the high phase.")]
        public static object Generate_SquareSequence([ExcelArgument(Name = "highDuration")] System.Int32 highDuration, [ExcelArgument(Name = "lowDuration")] System.Int32 lowDuration, [ExcelArgument(Name = "lowValue")] System.Double lowValue, [ExcelArgument(Name = "highValue")] System.Double highValue, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_SquareSequence_Internal(highDuration, lowDuration, lowValue, highValue, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.Triangle", Description=@"Create a periodic triangle wave, starting with the raise phase from the lowest sample.")]
        public static object Generate_Triangle([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "raiseDuration")] System.Int32 raiseDuration, [ExcelArgument(Name = "fallDuration")] System.Int32 fallDuration, [ExcelArgument(Name = "lowValue")] System.Double lowValue, [ExcelArgument(Name = "highValue")] System.Double highValue, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_Triangle_Internal(length, raiseDuration, fallDuration, lowValue, highValue, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.TriangleSequence", Description=@"Create an infinite periodic triangle wave sequence, starting with the raise phase from the lowest sample.")]
        public static object Generate_TriangleSequence([ExcelArgument(Name = "raiseDuration")] System.Int32 raiseDuration, [ExcelArgument(Name = "fallDuration")] System.Int32 fallDuration, [ExcelArgument(Name = "lowValue")] System.Double lowValue, [ExcelArgument(Name = "highValue")] System.Double highValue, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_TriangleSequence_Internal(raiseDuration, fallDuration, lowValue, highValue, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.Sawtooth", Description=@"Create a periodic sawtooth wave, starting with the lowest sample.")]
        public static object Generate_Sawtooth([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "period")] System.Int32 period, [ExcelArgument(Name = "lowValue")] System.Double lowValue, [ExcelArgument(Name = "highValue")] System.Double highValue, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_Sawtooth_Internal(length, period, lowValue, highValue, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.SawtoothSequence", Description=@"Create an infinite periodic sawtooth wave sequence, starting with the lowest sample.")]
        public static object Generate_SawtoothSequence([ExcelArgument(Name = "period")] System.Int32 period, [ExcelArgument(Name = "lowValue")] System.Double lowValue, [ExcelArgument(Name = "highValue")] System.Double highValue, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_SawtoothSequence_Internal(period, lowValue, highValue, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.Step", Description=@"Create a Heaviside Step sample vector.")]
        public static object Generate_Step([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "amplitude")] System.Double amplitude, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_Step_Internal(length, amplitude, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.StepSequence", Description=@"Create an infinite Heaviside Step sample sequence.")]
        public static object Generate_StepSequence([ExcelArgument(Name = "amplitude")] System.Double amplitude, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_StepSequence_Internal(amplitude, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.Impulse", Description=@"Create a Kronecker Delta impulse sample vector.")]
        public static object Generate_Impulse([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "amplitude")] System.Double amplitude, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_Impulse_Internal(length, amplitude, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.ImpulseSequence", Description=@"Create a Kronecker Delta impulse sample vector.")]
        public static object Generate_ImpulseSequence([ExcelArgument(Name = "amplitude")] System.Double amplitude, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_ImpulseSequence_Internal(amplitude, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.PeriodicImpulse", Description=@"Create a periodic Kronecker Delta impulse sample vector.")]
        public static object Generate_PeriodicImpulse([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "period")] System.Int32 period, [ExcelArgument(Name = "amplitude")] System.Double amplitude, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_PeriodicImpulse_Internal(length, period, amplitude, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.PeriodicImpulseSequence", Description=@"Create a Kronecker Delta impulse sample vector.")]
        public static object Generate_PeriodicImpulseSequence([ExcelArgument(Name = "period")] System.Int32 period, [ExcelArgument(Name = "amplitude")] System.Double amplitude, [ExcelArgument(Name = "delay")] System.Int32 delay)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_PeriodicImpulseSequence_Internal(period, amplitude, delay);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.Uniform", Description=@"Create random samples, uniform between 0 and 1.
        Faster than other methods but with reduced guarantees on randomness.")]
        public static object Generate_Uniform([ExcelArgument(Name = "length")] System.Int32 length)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_Uniform_Internal(length);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.UniformSequence")]
        public static object Generate_UniformSequence()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_UniformSequence_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.Standard", Description=@"Create samples with independent amplitudes of standard distribution.")]
        public static object Generate_Standard([ExcelArgument(Name = "length")] System.Int32 length)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_Standard_Internal(length);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.StandardSequence")]
        public static object Generate_StandardSequence()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_StandardSequence_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.Normal", Description=@"Create samples with independent amplitudes of normal distribution and a flat spectral density.")]
        public static object Generate_Normal([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "mean")] System.Double mean, [ExcelArgument(Name = "standardDeviation")] System.Double standardDeviation)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_Normal_Internal(length, mean, standardDeviation);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Generate.NormalSequence", Description=@"Create an infinite sample sequence with independent amplitudes of normal distribution and a flat spectral density.")]
        public static object Generate_NormalSequence([ExcelArgument(Name = "mean")] System.Double mean, [ExcelArgument(Name = "standardDeviation")] System.Double standardDeviation)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Generate_NormalSequence_Internal(mean, standardDeviation);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.GoodnessOfFit.RSquared")]
        public static object GoodnessOfFit_RSquared([ExcelArgument(Name = "modelledValues")] System.Collections.Generic.IEnumerable<System.Double> modelledValues, [ExcelArgument(Name = "observedValues")] System.Collections.Generic.IEnumerable<System.Double> observedValues)
        {
            try
            {
                return math.net.xladdin.generated.Internal.GoodnessOfFit_RSquared_Internal(modelledValues, observedValues);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.GoodnessOfFit.R")]
        public static object GoodnessOfFit_R([ExcelArgument(Name = "modelledValues")] System.Collections.Generic.IEnumerable<System.Double> modelledValues, [ExcelArgument(Name = "observedValues")] System.Collections.Generic.IEnumerable<System.Double> observedValues)
        {
            try
            {
                return math.net.xladdin.generated.Internal.GoodnessOfFit_R_Internal(modelledValues, observedValues);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.GoodnessOfFit.PopulationStandardError")]
        public static object GoodnessOfFit_PopulationStandardError([ExcelArgument(Name = "modelledValues")] System.Collections.Generic.IEnumerable<System.Double> modelledValues, [ExcelArgument(Name = "observedValues")] System.Collections.Generic.IEnumerable<System.Double> observedValues)
        {
            try
            {
                return math.net.xladdin.generated.Internal.GoodnessOfFit_PopulationStandardError_Internal(modelledValues, observedValues);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.GoodnessOfFit.StandardError")]
        public static object GoodnessOfFit_StandardError([ExcelArgument(Name = "modelledValues")] System.Collections.Generic.IEnumerable<System.Double> modelledValues, [ExcelArgument(Name = "observedValues")] System.Collections.Generic.IEnumerable<System.Double> observedValues, [ExcelArgument(Name = "degreesOfFreedom")] System.Int32 degreesOfFreedom)
        {
            try
            {
                return math.net.xladdin.generated.Internal.GoodnessOfFit_StandardError_Internal(modelledValues, observedValues, degreesOfFreedom);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.Magnitude", Description=@"Returns the magnitude of the number.")]
        public static object Precision_Magnitude([ExcelArgument(Name = "value")] System.Double value)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_Magnitude_Internal(value);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.ScaleUnitMagnitude", Description=@"Returns the number divided by it's magnitude, effectively returning a number between -10 and 10.")]
        public static object Precision_ScaleUnitMagnitude([ExcelArgument(Name = "value")] System.Double value)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_ScaleUnitMagnitude_Internal(value);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.Increment", Description=@"Increments a floating point number to the next bigger number representable by the data type.")]
        public static object Precision_Increment([ExcelArgument(Name = "value")] System.Double value, [ExcelArgument(Name = "count")] System.Int32 count)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_Increment_Internal(value, count);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.Decrement", Description=@"Decrements a floating point number to the next smaller number representable by the data type.")]
        public static object Precision_Decrement([ExcelArgument(Name = "value")] System.Double value, [ExcelArgument(Name = "count")] System.Int32 count)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_Decrement_Internal(value, count);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.CoerceZero_2", Description=@"Forces small numbers near zero to zero, according to the specified absolute accuracy.")]
        public static object Precision_CoerceZero_2([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "maxNumbersBetween")] System.Int32 maxNumbersBetween)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_CoerceZero_2_Internal(a, maxNumbersBetween);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.CoerceZero_1", Description=@"Forces small numbers near zero to zero.")]
        public static object Precision_CoerceZero_1([ExcelArgument(Name = "a")] System.Double a)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_CoerceZero_1_Internal(a);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.MaximumMatchingFloatingPointNumber", Description=@"Returns the floating point number that will match the value with the tolerance on the maximum size (i.e. the result is
        always bigger than the value)")]
        public static object Precision_MaximumMatchingFloatingPointNumber([ExcelArgument(Name = "value")] System.Double value, [ExcelArgument(Name = "maxNumbersBetween")] System.Int64 maxNumbersBetween)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_MaximumMatchingFloatingPointNumber_Internal(value, maxNumbersBetween);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.MinimumMatchingFloatingPointNumber", Description=@"Returns the floating point number that will match the value with the tolerance on the minimum size (i.e. the result is
        always smaller than the value)")]
        public static object Precision_MinimumMatchingFloatingPointNumber([ExcelArgument(Name = "value")] System.Double value, [ExcelArgument(Name = "maxNumbersBetween")] System.Int64 maxNumbersBetween)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_MinimumMatchingFloatingPointNumber_Internal(value, maxNumbersBetween);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.EpsilonOf", Description=@"Evaluates the minimum distance to the next distinguishable number near the argument value.")]
        public static object Precision_EpsilonOf([ExcelArgument(Name = "value")] System.Double value)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_EpsilonOf_Internal(value);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.PositiveEpsilonOf", Description=@"Evaluates the minimum distance to the next distinguishable number near the argument value.")]
        public static object Precision_PositiveEpsilonOf([ExcelArgument(Name = "value")] System.Double value)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_PositiveEpsilonOf_Internal(value);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.CompareTo", Description=@"Compares two doubles and determines which double is bigger.
        a < b -> -1; a ~= b (almost equal according to parameter) -> 0; a > b -> +1.")]
        public static object Precision_CompareTo([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "maximumAbsoluteError")] System.Double maximumAbsoluteError)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_CompareTo_Internal(a, b, maximumAbsoluteError);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.CompareToRelative", Description=@"Compares two doubles and determines which double is bigger.
        a < b -> -1; a ~= b (almost equal according to parameter) -> 0; a > b -> +1.")]
        public static object Precision_CompareToRelative([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "maximumError")] System.Double maximumError)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_CompareToRelative_Internal(a, b, maximumError);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.CompareToNumbersBetween", Description=@"Compares two doubles and determines which double is bigger.
        a < b -> -1; a ~= b (almost equal according to parameter) -> 0; a > b -> +1.")]
        public static object Precision_CompareToNumbersBetween([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "maxNumbersBetween")] System.Int64 maxNumbersBetween)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_CompareToNumbersBetween_Internal(a, b, maxNumbersBetween);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.IsLarger", Description=@"Compares two doubles and determines if the first value is larger than the second
        value to within the specified number of decimal places or not.")]
        public static object Precision_IsLarger([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "decimalPlaces")] System.Int32 decimalPlaces)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_IsLarger_Internal(a, b, decimalPlaces);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.IsLargerRelative", Description=@"Compares two doubles and determines if the first value is larger than the second
        value to within the specified number of decimal places or not.")]
        public static object Precision_IsLargerRelative([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "decimalPlaces")] System.Int32 decimalPlaces)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_IsLargerRelative_Internal(a, b, decimalPlaces);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.IsLargerNumbersBetween", Description=@"Compares two doubles and determines if the first value is larger than the second
        value to within the tolerance or not. Equality comparison is based on the binary representation.")]
        public static object Precision_IsLargerNumbersBetween([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "maxNumbersBetween")] System.Int64 maxNumbersBetween)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_IsLargerNumbersBetween_Internal(a, b, maxNumbersBetween);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.IsSmaller", Description=@"Compares two doubles and determines if the first value is smaller than the second
        value to within the specified number of decimal places or not.")]
        public static object Precision_IsSmaller([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "decimalPlaces")] System.Int32 decimalPlaces)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_IsSmaller_Internal(a, b, decimalPlaces);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.IsSmallerRelative", Description=@"Compares two doubles and determines if the first value is smaller than the second
        value to within the specified number of decimal places or not.")]
        public static object Precision_IsSmallerRelative([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "decimalPlaces")] System.Int32 decimalPlaces)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_IsSmallerRelative_Internal(a, b, decimalPlaces);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.IsSmallerNumbersBetween", Description=@"Compares two doubles and determines if the first value is smaller than the second
        value to within the tolerance or not. Equality comparison is based on the binary representation.")]
        public static object Precision_IsSmallerNumbersBetween([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "maxNumbersBetween")] System.Int64 maxNumbersBetween)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_IsSmallerNumbersBetween_Internal(a, b, maxNumbersBetween);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.AlmostEqualNorm", Description=@"Compares two doubles and determines if they are equal
        within the specified maximum absolute error.")]
        public static object Precision_AlmostEqualNorm([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "diff")] System.Double diff, [ExcelArgument(Name = "maximumAbsoluteError")] System.Double maximumAbsoluteError)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_AlmostEqualNorm_Internal(a, b, diff, maximumAbsoluteError);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.AlmostEqualNormRelative", Description=@"Compares two doubles and determines if they are equal
        within the specified maximum error.")]
        public static object Precision_AlmostEqualNormRelative([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "diff")] System.Double diff, [ExcelArgument(Name = "maximumError")] System.Double maximumError)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_AlmostEqualNormRelative_Internal(a, b, diff, maximumError);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.AlmostEqual_3", Description=@"Compares two doubles and determines if they are equal within
        the specified maximum error.")]
        public static object Precision_AlmostEqual_3([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "maximumAbsoluteError")] System.Double maximumAbsoluteError)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_AlmostEqual_3_Internal(a, b, maximumAbsoluteError);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.AlmostEqual_2", Description=@"Checks whether two real numbers are almost equal.")]
        public static object Precision_AlmostEqual_2([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_AlmostEqual_2_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.AlmostEqualRelative_3", Description=@"Compares two doubles and determines if they are equal within
        the specified maximum error.")]
        public static object Precision_AlmostEqualRelative_3([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "maximumError")] System.Double maximumError)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_AlmostEqualRelative_3_Internal(a, b, maximumError);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.AlmostEqualRelative_2", Description=@"Checks whether two real numbers are almost equal.")]
        public static object Precision_AlmostEqualRelative_2([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_AlmostEqualRelative_2_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Precision.AlmostEqualNumbersBetween", Description=@"Compares two doubles and determines if they are equal to within the tolerance or not. Equality comparison is based on the binary representation.")]
        public static object Precision_AlmostEqualNumbersBetween([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "maxNumbersBetween")] System.Int64 maxNumbersBetween)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Precision_AlmostEqualNumbersBetween_Internal(a, b, maxNumbersBetween);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Combinatorics.Variations", Description=@"Count the number of possible variations without repetition.
        The order matters and each object can be chosen only once.")]
        public static object Combinatorics_Variations([ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Combinatorics_Variations_Internal(n, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Combinatorics.VariationsWithRepetition", Description=@"Count the number of possible variations with repetition.
        The order matters and each object can be chosen more than once.")]
        public static object Combinatorics_VariationsWithRepetition([ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Combinatorics_VariationsWithRepetition_Internal(n, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Combinatorics.Combinations", Description=@"Count the number of possible combinations without repetition.
        The order does not matter and each object can be chosen only once.")]
        public static object Combinatorics_Combinations([ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Combinatorics_Combinations_Internal(n, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Combinatorics.CombinationsWithRepetition", Description=@"Count the number of possible combinations with repetition.
        The order does not matter and an object can be chosen more than once.")]
        public static object Combinatorics_CombinationsWithRepetition([ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Combinatorics_CombinationsWithRepetition_Internal(n, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Combinatorics.Permutations", Description=@"Count the number of possible permutations (without repetition).")]
        public static object Combinatorics_Permutations([ExcelArgument(Name = "n")] System.Int32 n)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Combinatorics_Permutations_Internal(n);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.MagnitudeSquared")]
        public static object ComplexExtensions_MagnitudeSquared([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_MagnitudeSquared_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.Sign")]
        public static object ComplexExtensions_Sign([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_Sign_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.Conjugate")]
        public static object ComplexExtensions_Conjugate([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_Conjugate_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.Reciprocal")]
        public static object ComplexExtensions_Reciprocal([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_Reciprocal_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.Exp")]
        public static object ComplexExtensions_Exp([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_Exp_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.Ln")]
        public static object ComplexExtensions_Ln([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_Ln_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.Log10")]
        public static object ComplexExtensions_Log10([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_Log10_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.Log")]
        public static object ComplexExtensions_Log([ExcelArgument(Name = "complex")] System.Numerics.Complex complex, [ExcelArgument(Name = "baseValue")] System.Double baseValue)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_Log_Internal(complex, baseValue);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.Power")]
        public static object ComplexExtensions_Power([ExcelArgument(Name = "complex")] System.Numerics.Complex complex, [ExcelArgument(Name = "exponent")] System.Numerics.Complex exponent)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_Power_Internal(complex, exponent);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.Root")]
        public static object ComplexExtensions_Root([ExcelArgument(Name = "complex")] System.Numerics.Complex complex, [ExcelArgument(Name = "rootExponent")] System.Numerics.Complex rootExponent)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_Root_Internal(complex, rootExponent);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.Square")]
        public static object ComplexExtensions_Square([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_Square_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.SquareRoot")]
        public static object ComplexExtensions_SquareRoot([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_SquareRoot_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.IsZero")]
        public static object ComplexExtensions_IsZero([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_IsZero_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.IsOne")]
        public static object ComplexExtensions_IsOne([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_IsOne_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.IsImaginaryOne")]
        public static object ComplexExtensions_IsImaginaryOne([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_IsImaginaryOne_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.IsNaN")]
        public static object ComplexExtensions_IsNaN([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_IsNaN_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.IsInfinity")]
        public static object ComplexExtensions_IsInfinity([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_IsInfinity_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.IsReal")]
        public static object ComplexExtensions_IsReal([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_IsReal_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.IsRealNonNegative")]
        public static object ComplexExtensions_IsRealNonNegative([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_IsRealNonNegative_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.Norm")]
        public static object ComplexExtensions_Norm([ExcelArgument(Name = "complex")] System.Numerics.Complex complex)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_Norm_Internal(complex);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ComplexExtensions.NormOfDifference")]
        public static object ComplexExtensions_NormOfDifference([ExcelArgument(Name = "complex")] System.Numerics.Complex complex, [ExcelArgument(Name = "otherValue")] System.Numerics.Complex otherValue)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ComplexExtensions_NormOfDifference_Internal(complex, otherValue);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Control.TryUseNativeMKL")]
        public static object Control_TryUseNativeMKL()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Control_TryUseNativeMKL_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Control.TryUseNativeCUDA")]
        public static object Control_TryUseNativeCUDA()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Control_TryUseNativeCUDA_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Control.TryUseNativeOpenBLAS")]
        public static object Control_TryUseNativeOpenBLAS()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Control_TryUseNativeOpenBLAS_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Control.TryUseNative")]
        public static object Control_TryUseNative()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Control_TryUseNative_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Control.CheckDistributionParameters")]
        public static object Control_CheckDistributionParameters()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Control_CheckDistributionParameters_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Control.ThreadSafeRandomNumberGenerators")]
        public static object Control_ThreadSafeRandomNumberGenerators()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Control_ThreadSafeRandomNumberGenerators_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Control.MaxDegreeOfParallelism")]
        public static object Control_MaxDegreeOfParallelism()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Control_MaxDegreeOfParallelism_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Control.BlockSize")]
        public static object Control_BlockSize()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Control_BlockSize_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distance.SAD", Description=@"Sum of Absolute Difference (SAD), i.e. the L1-norm (Manhattan) of the difference.")]
        public static object Distance_SAD([ExcelArgument(Name = "a")] System.Double[] a, [ExcelArgument(Name = "b")] System.Double[] b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distance_SAD_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distance.MAE", Description=@"Mean-Absolute Error (MAE), i.e. the normalized L1-norm (Manhattan) of the difference.")]
        public static object Distance_MAE([ExcelArgument(Name = "a")] System.Double[] a, [ExcelArgument(Name = "b")] System.Double[] b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distance_MAE_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distance.SSD", Description=@"Sum of Squared Difference (SSD), i.e. the squared L2-norm (Euclidean) of the difference.")]
        public static object Distance_SSD([ExcelArgument(Name = "a")] System.Double[] a, [ExcelArgument(Name = "b")] System.Double[] b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distance_SSD_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distance.MSE", Description=@"Mean-Squared Error (MSE), i.e. the normalized squared L2-norm (Euclidean) of the difference.")]
        public static object Distance_MSE([ExcelArgument(Name = "a")] System.Double[] a, [ExcelArgument(Name = "b")] System.Double[] b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distance_MSE_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distance.Euclidean", Description=@"Euclidean Distance, i.e. the L2-norm of the difference.")]
        public static object Distance_Euclidean([ExcelArgument(Name = "a")] System.Double[] a, [ExcelArgument(Name = "b")] System.Double[] b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distance_Euclidean_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distance.Manhattan", Description=@"Manhattan Distance, i.e. the L1-norm of the difference.")]
        public static object Distance_Manhattan([ExcelArgument(Name = "a")] System.Double[] a, [ExcelArgument(Name = "b")] System.Double[] b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distance_Manhattan_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distance.Chebyshev", Description=@"Chebyshev Distance, i.e. the Infinity-norm of the difference.")]
        public static object Distance_Chebyshev([ExcelArgument(Name = "a")] System.Double[] a, [ExcelArgument(Name = "b")] System.Double[] b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distance_Chebyshev_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distance.Minkowski", Description=@"Minkowski Distance, i.e. the generalized p-norm of the difference.")]
        public static object Distance_Minkowski([ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "a")] System.Double[] a, [ExcelArgument(Name = "b")] System.Double[] b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distance_Minkowski_Internal(p, a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distance.Canberra", Description=@"Canberra Distance, a weighted version of the L1-norm of the difference.")]
        public static object Distance_Canberra([ExcelArgument(Name = "a")] System.Double[] a, [ExcelArgument(Name = "b")] System.Double[] b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distance_Canberra_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distance.Cosine", Description=@"Cosine Distance, representing the angular distance while ignoring the scale.")]
        public static object Distance_Cosine([ExcelArgument(Name = "a")] System.Double[] a, [ExcelArgument(Name = "b")] System.Double[] b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distance_Cosine_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distance.Hamming", Description=@"Hamming Distance, i.e. the number of positions that have different values in the vectors.")]
        public static object Distance_Hamming([ExcelArgument(Name = "a")] System.Double[] a, [ExcelArgument(Name = "b")] System.Double[] b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distance_Hamming_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distance.Pearson")]
        public static object Distance_Pearson([ExcelArgument(Name = "a")] System.Collections.Generic.IEnumerable<System.Double> a, [ExcelArgument(Name = "b")] System.Collections.Generic.IEnumerable<System.Double> b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distance_Pearson_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distance.Jaccard", Description=@"Jaccard distance, i.e. 1 - the Jaccard index.")]
        public static object Distance_Jaccard([ExcelArgument(Name = "a")] System.Double[] a, [ExcelArgument(Name = "b")] System.Double[] b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distance_Jaccard_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Fit.MultiDimWeighted", Description=@"Weighted Least-Squares fitting the points (X,y) = ((x0,x1,..,xk),y) and weights w to a linear surface y : X -> p0*x0 + p1*x1 + ... + pk*xk,
        returning its best fitting parameters as [p0, p1, p2, ..., pk] array.")]
        public static object Fit_MultiDimWeighted([ExcelArgument(Name = "x")] System.Double[][] x, [ExcelArgument(Name = "y")] System.Double[] y, [ExcelArgument(Name = "w")] System.Double[] w)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Fit_MultiDimWeighted_Internal(x, y, w);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Fit.PolynomialWeighted", Description=@"Weighted Least-Squares fitting the points (x,y) and weights w to a k-order polynomial y : x -> p0 + p1*x + p2*x^2 + ... + pk*x^k,
        returning its best fitting parameters as [p0, p1, p2, ..., pk] array, compatible with Evaluate.Polynomial.
        A polynomial with order/degree k has (k+1) coefficients and thus requires at least (k+1) samples.")]
        public static object Fit_PolynomialWeighted([ExcelArgument(Name = "x")] System.Double[] x, [ExcelArgument(Name = "y")] System.Double[] y, [ExcelArgument(Name = "w")] System.Double[] w, [ExcelArgument(Name = "order")] System.Int32 order)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Fit_PolynomialWeighted_Internal(x, y, w, order);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.FindRoots.ChebychevPolynomialFirstKind", Description=@"Find all roots of the Chebychev polynomial of the first kind.")]
        public static object FindRoots_ChebychevPolynomialFirstKind([ExcelArgument(Name = "degree")] System.Int32 degree, [ExcelArgument(Name = "intervalBegin")] System.Double intervalBegin, [ExcelArgument(Name = "intervalEnd")] System.Double intervalEnd)
        {
            try
            {
                return math.net.xladdin.generated.Internal.FindRoots_ChebychevPolynomialFirstKind_Internal(degree, intervalBegin, intervalEnd);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.FindRoots.ChebychevPolynomialSecondKind", Description=@"Find all roots of the Chebychev polynomial of the second kind.")]
        public static object FindRoots_ChebychevPolynomialSecondKind([ExcelArgument(Name = "degree")] System.Int32 degree, [ExcelArgument(Name = "intervalBegin")] System.Double intervalBegin, [ExcelArgument(Name = "intervalEnd")] System.Double intervalEnd)
        {
            try
            {
                return math.net.xladdin.generated.Internal.FindRoots_ChebychevPolynomialSecondKind_Internal(degree, intervalBegin, intervalEnd);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Evaluate.Polynomial", Description=@"Evaluate a polynomial at point x.
        Coefficients are ordered by power with power k at index k.
        Example: coefficients [3,-1,2] represent y=2x^2-x+3.")]
        public static object Evaluate_Polynomial([ExcelArgument(Name = "z")] System.Double z, [ExcelArgument(Name = "coefficients")] System.Double[] coefficients)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Evaluate_Polynomial_Internal(z, coefficients);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.NormSDist")]
        public static object ExcelFunctions_NormSDist([ExcelArgument(Name = "z")] System.Double z)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_NormSDist_Internal(z);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.NormSInv")]
        public static object ExcelFunctions_NormSInv([ExcelArgument(Name = "probability")] System.Double probability)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_NormSInv_Internal(probability);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.NormDist")]
        public static object ExcelFunctions_NormDist([ExcelArgument(Name = "x")] System.Double x, [ExcelArgument(Name = "mean")] System.Double mean, [ExcelArgument(Name = "standardDev")] System.Double standardDev, [ExcelArgument(Name = "cumulative")] System.Boolean cumulative)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_NormDist_Internal(x, mean, standardDev, cumulative);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.NormInv")]
        public static object ExcelFunctions_NormInv([ExcelArgument(Name = "probability")] System.Double probability, [ExcelArgument(Name = "mean")] System.Double mean, [ExcelArgument(Name = "standardDev")] System.Double standardDev)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_NormInv_Internal(probability, mean, standardDev);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.TDist")]
        public static object ExcelFunctions_TDist([ExcelArgument(Name = "x")] System.Double x, [ExcelArgument(Name = "degreesFreedom")] System.Int32 degreesFreedom, [ExcelArgument(Name = "tails")] System.Int32 tails)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_TDist_Internal(x, degreesFreedom, tails);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.TInv")]
        public static object ExcelFunctions_TInv([ExcelArgument(Name = "probability")] System.Double probability, [ExcelArgument(Name = "degreesFreedom")] System.Int32 degreesFreedom)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_TInv_Internal(probability, degreesFreedom);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.FDist")]
        public static object ExcelFunctions_FDist([ExcelArgument(Name = "x")] System.Double x, [ExcelArgument(Name = "degreesFreedom1")] System.Int32 degreesFreedom1, [ExcelArgument(Name = "degreesFreedom2")] System.Int32 degreesFreedom2)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_FDist_Internal(x, degreesFreedom1, degreesFreedom2);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.FInv")]
        public static object ExcelFunctions_FInv([ExcelArgument(Name = "probability")] System.Double probability, [ExcelArgument(Name = "degreesFreedom1")] System.Int32 degreesFreedom1, [ExcelArgument(Name = "degreesFreedom2")] System.Int32 degreesFreedom2)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_FInv_Internal(probability, degreesFreedom1, degreesFreedom2);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.BetaDist")]
        public static object ExcelFunctions_BetaDist([ExcelArgument(Name = "x")] System.Double x, [ExcelArgument(Name = "alpha")] System.Double alpha, [ExcelArgument(Name = "beta")] System.Double beta)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_BetaDist_Internal(x, alpha, beta);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.BetaInv")]
        public static object ExcelFunctions_BetaInv([ExcelArgument(Name = "probability")] System.Double probability, [ExcelArgument(Name = "alpha")] System.Double alpha, [ExcelArgument(Name = "beta")] System.Double beta)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_BetaInv_Internal(probability, alpha, beta);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.GammaDist")]
        public static object ExcelFunctions_GammaDist([ExcelArgument(Name = "x")] System.Double x, [ExcelArgument(Name = "alpha")] System.Double alpha, [ExcelArgument(Name = "beta")] System.Double beta, [ExcelArgument(Name = "cumulative")] System.Boolean cumulative)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_GammaDist_Internal(x, alpha, beta, cumulative);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.GammaInv")]
        public static object ExcelFunctions_GammaInv([ExcelArgument(Name = "probability")] System.Double probability, [ExcelArgument(Name = "alpha")] System.Double alpha, [ExcelArgument(Name = "beta")] System.Double beta)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_GammaInv_Internal(probability, alpha, beta);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.Quartile")]
        public static object ExcelFunctions_Quartile([ExcelArgument(Name = "array")] System.Double[] array, [ExcelArgument(Name = "quant")] System.Int32 quant)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_Quartile_Internal(array, quant);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.Percentile")]
        public static object ExcelFunctions_Percentile([ExcelArgument(Name = "array")] System.Double[] array, [ExcelArgument(Name = "k")] System.Double k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_Percentile_Internal(array, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.ExcelFunctions.PercentRank")]
        public static object ExcelFunctions_PercentRank([ExcelArgument(Name = "array")] System.Double[] array, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.ExcelFunctions_PercentRank_Internal(array, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.ExponentialIntegral", Description=@"Computes the generalized Exponential Integral function (En).")]
        public static object SpecialFunctions_ExponentialIntegral([ExcelArgument(Name = "x")] System.Double x, [ExcelArgument(Name = "n")] System.Int32 n)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_ExponentialIntegral_Internal(x, n);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.StruveL0", Description=@"Returns the modified Struve function of order 0.")]
        public static object SpecialFunctions_StruveL0([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_StruveL0_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.StruveL1", Description=@"Returns the modified Struve function of order 1.")]
        public static object SpecialFunctions_StruveL1([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_StruveL1_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.BesselI0MStruveL0", Description=@"Returns the difference between the Bessel I0 and Struve L0 functions.")]
        public static object SpecialFunctions_BesselI0MStruveL0([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_BesselI0MStruveL0_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.BesselI1MStruveL1", Description=@"Returns the difference between the Bessel I1 and Struve L1 functions.")]
        public static object SpecialFunctions_BesselI1MStruveL1([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_BesselI1MStruveL1_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.BesselI0", Description=@"Returns the modified Bessel function of first kind, order 0 of the argument.
        
        The function is defined as i0(x) = j0( ix ).
        
        The range is partitioned into the two intervals [0, 8] and
        (8, infinity). Chebyshev polynomial expansions are employed
        in each interval.")]
        public static object SpecialFunctions_BesselI0([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_BesselI0_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.BesselI1", Description=@"Returns the modified Bessel function of first kind,
        order 1 of the argument.
        
        The function is defined as i1(x) = -i j1( ix ).
        
        The range is partitioned into the two intervals [0, 8] and
        (8, infinity). Chebyshev polynomial expansions are employed
        in each interval.")]
        public static object SpecialFunctions_BesselI1([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_BesselI1_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.BesselK0", Description=@"Returns the modified Bessel function of the second kind
        of order 0 of the argument.
        
        The range is partitioned into the two intervals [0, 8] and
        (8, infinity). Chebyshev polynomial expansions are employed
        in each interval.")]
        public static object SpecialFunctions_BesselK0([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_BesselK0_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.BesselK0e", Description=@"Returns the exponentially scaled modified Bessel function
        of the second kind of order 0 of the argument.")]
        public static object SpecialFunctions_BesselK0e([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_BesselK0e_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.BesselK1", Description=@"Returns the modified Bessel function of the second kind
        of order 1 of the argument.
        
        The range is partitioned into the two intervals [0, 2] and
        (2, infinity). Chebyshev polynomial expansions are employed
        in each interval.")]
        public static object SpecialFunctions_BesselK1([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_BesselK1_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.BesselK1e", Description=@"Returns the exponentially scaled modified Bessel function
        of the second kind of order 1 of the argument.
        k1e(x) = exp(x) * k1(x).")]
        public static object SpecialFunctions_BesselK1e([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_BesselK1e_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.Logistic", Description=@"Computes the logistic function. see: http://en.wikipedia.org/wiki/Logistic")]
        public static object SpecialFunctions_Logistic([ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_Logistic_Internal(p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.Logit", Description=@"Computes the logit function, the inverse of the sigmoid logistic function. see: http://en.wikipedia.org/wiki/Logit")]
        public static object SpecialFunctions_Logit([ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_Logit_Internal(p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.Harmonic", Description=@"Computes the 'th Harmonic number.")]
        public static object SpecialFunctions_Harmonic([ExcelArgument(Name = "t")] System.Int32 t)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_Harmonic_Internal(t);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.GeneralHarmonic", Description=@"Compute the generalized harmonic number of order n of m. (1 + 1/2^m + 1/3^m + ... + 1/n^m)")]
        public static object SpecialFunctions_GeneralHarmonic([ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "m")] System.Double m)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_GeneralHarmonic_Internal(n, m);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.BetaLn", Description=@"Computes the logarithm of the Euler Beta function.")]
        public static object SpecialFunctions_BetaLn([ExcelArgument(Name = "z")] System.Double z, [ExcelArgument(Name = "w")] System.Double w)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_BetaLn_Internal(z, w);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.Beta", Description=@"Computes the Euler Beta function.")]
        public static object SpecialFunctions_Beta([ExcelArgument(Name = "z")] System.Double z, [ExcelArgument(Name = "w")] System.Double w)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_Beta_Internal(z, w);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.BetaIncomplete", Description=@"Returns the lower incomplete (unregularized) beta function
        B(a,b,x) = int(t^(a-1)*(1-t)^(b-1),t=0..x) for real a > 0, b > 0, 1 >= x >= 0.")]
        public static object SpecialFunctions_BetaIncomplete([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_BetaIncomplete_Internal(a, b, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.BetaRegularized", Description=@"Returns the regularized lower incomplete beta function
        I_x(a,b) = 1/Beta(a,b) * int(t^(a-1)*(1-t)^(b-1),t=0..x) for real a > 0, b > 0, 1 >= x >= 0.")]
        public static object SpecialFunctions_BetaRegularized([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_BetaRegularized_Internal(a, b, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.Erf", Description=@"Calculates the error function.")]
        public static object SpecialFunctions_Erf([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_Erf_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.Erfc", Description=@"Calculates the complementary error function.")]
        public static object SpecialFunctions_Erfc([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_Erfc_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.ErfInv", Description=@"Calculates the inverse error function evaluated at z.")]
        public static object SpecialFunctions_ErfInv([ExcelArgument(Name = "z")] System.Double z)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_ErfInv_Internal(z);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.ErfcInv", Description=@"Calculates the complementary inverse error function evaluated at z.")]
        public static object SpecialFunctions_ErfcInv([ExcelArgument(Name = "z")] System.Double z)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_ErfcInv_Internal(z);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.Factorial", Description=@"Computes the factorial function x -> x! of an integer number > 0. The function can represent all number up
        to 22! exactly, all numbers up to 170! using a double representation. All larger values will overflow.")]
        public static object SpecialFunctions_Factorial([ExcelArgument(Name = "x")] System.Int32 x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_Factorial_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.FactorialLn", Description=@"Computes the logarithmic factorial function x -> ln(x!) of an integer number > 0.")]
        public static object SpecialFunctions_FactorialLn([ExcelArgument(Name = "x")] System.Int32 x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_FactorialLn_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.Binomial", Description=@"Computes the binomial coefficient: n choose k.")]
        public static object SpecialFunctions_Binomial([ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_Binomial_Internal(n, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.BinomialLn", Description=@"Computes the natural logarithm of the binomial coefficient: ln(n choose k).")]
        public static object SpecialFunctions_BinomialLn([ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_BinomialLn_Internal(n, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.Multinomial", Description=@"Computes the multinomial coefficient: n choose n1, n2, n3, ...")]
        public static object SpecialFunctions_Multinomial([ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "ni")] System.Int32[] ni)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_Multinomial_Internal(n, ni);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.GammaLn", Description=@"Computes the logarithm of the Gamma function.")]
        public static object SpecialFunctions_GammaLn([ExcelArgument(Name = "z")] System.Double z)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_GammaLn_Internal(z);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.Gamma", Description=@"Computes the Gamma function.")]
        public static object SpecialFunctions_Gamma([ExcelArgument(Name = "z")] System.Double z)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_Gamma_Internal(z);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.GammaUpperRegularized", Description=@"Returns the upper incomplete regularized gamma function
        Q(a,x) = 1/Gamma(a) * int(exp(-t)t^(a-1),t=0..x) for real a > 0, x > 0.")]
        public static object SpecialFunctions_GammaUpperRegularized([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_GammaUpperRegularized_Internal(a, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.GammaUpperIncomplete", Description=@"Returns the upper incomplete gamma function
        Gamma(a,x) = int(exp(-t)t^(a-1),t=0..x) for real a > 0, x > 0.")]
        public static object SpecialFunctions_GammaUpperIncomplete([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_GammaUpperIncomplete_Internal(a, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.GammaLowerIncomplete", Description=@"Returns the lower incomplete gamma function
        gamma(a,x) = int(exp(-t)t^(a-1),t=0..x) for real a > 0, x > 0.")]
        public static object SpecialFunctions_GammaLowerIncomplete([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_GammaLowerIncomplete_Internal(a, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.GammaLowerRegularized", Description=@"Returns the lower incomplete regularized gamma function
        P(a,x) = 1/Gamma(a) * int(exp(-t)t^(a-1),t=0..x) for real a > 0, x > 0.")]
        public static object SpecialFunctions_GammaLowerRegularized([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_GammaLowerRegularized_Internal(a, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.GammaLowerRegularizedInv", Description=@"Returns the inverse P^(-1) of the regularized lower incomplete gamma function
        P(a,x) = 1/Gamma(a) * int(exp(-t)t^(a-1),t=0..x) for real a > 0, x > 0,
        such that P^(-1)(a,P(a,x)) == x.")]
        public static object SpecialFunctions_GammaLowerRegularizedInv([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "y0")] System.Double y0)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_GammaLowerRegularizedInv_Internal(a, y0);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.DiGamma", Description=@"Computes the Digamma function which is mathematically defined as the derivative of the logarithm of the gamma function.
        This implementation is based on
        Jose Bernardo
        Algorithm AS 103:
        Psi ( Digamma ) Function,
        Applied Statistics,
        Volume 25, Number 3, 1976, pages 315-317.
        Using the modifications as in Tom Minka's lightspeed toolbox.")]
        public static object SpecialFunctions_DiGamma([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_DiGamma_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.DiGammaInv", Description=@"Computes the inverse Digamma function: this is the inverse of the logarithm of the gamma function. This function will
          only return solutions that are positive.
        This implementation is based on the bisection method.")]
        public static object SpecialFunctions_DiGammaInv([ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_DiGammaInv_Internal(p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.ExponentialMinusOne", Description=@"Numerically stable exponential minus one, i.e. x -> exp(x)-1")]
        public static object SpecialFunctions_ExponentialMinusOne([ExcelArgument(Name = "power")] System.Double power)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_ExponentialMinusOne_Internal(power);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.SpecialFunctions.Hypotenuse")]
        public static object SpecialFunctions_Hypotenuse([ExcelArgument(Name = "a")] System.Numerics.Complex a, [ExcelArgument(Name = "b")] System.Numerics.Complex b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.SpecialFunctions_Hypotenuse_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.TestFunctions.Rosenbrock_2", Description=@"Valley-shaped Rosenbrock function for 2 dimensions: (x,y) -> (1-x)^2 + 100*(y-x^2)^2.
        This function has a global minimum at (1,1) with f(1,1) = 0.
        Common range: [-5,10] or [-2.048,2.048].")]
        public static object TestFunctions_Rosenbrock_2([ExcelArgument(Name = "x")] System.Double x, [ExcelArgument(Name = "y")] System.Double y)
        {
            try
            {
                return math.net.xladdin.generated.Internal.TestFunctions_Rosenbrock_2_Internal(x, y);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.TestFunctions.Rosenbrock_1", Description=@"Valley-shaped Rosenbrock function for 2 or more dimensions.
        This function have a global minimum of all ones and, for 8 > N > 3, a local minimum at (-1,1,...,1).")]
        public static object TestFunctions_Rosenbrock_1([ExcelArgument(Name = "x")] System.Double[] x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.TestFunctions_Rosenbrock_1_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.TestFunctions.Himmelblau", Description=@"Himmelblau, a multi-modal function: (x,y) -> (x^2+y-11)^2 + (x+y^2-7)^2
        This function has 4 global minima with f(x,y) = 0.
        Common range: [-6,6].
        Named after David Mautner Himmelblau")]
        public static object TestFunctions_Himmelblau([ExcelArgument(Name = "x")] System.Double x, [ExcelArgument(Name = "y")] System.Double y)
        {
            try
            {
                return math.net.xladdin.generated.Internal.TestFunctions_Himmelblau_Internal(x, y);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.TestFunctions.Rastrigin", Description=@"Rastrigin, a highly multi-modal function with many local minima.
        Global minimum of all zeros with f(0) = 0.
        Common range: [-5.12,5.12].")]
        public static object TestFunctions_Rastrigin([ExcelArgument(Name = "x")] System.Double[] x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.TestFunctions_Rastrigin_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.TestFunctions.DropWave", Description=@"Drop-Wave, a multi-modal and highly complex function with many local minima.
        Global minimum of all zeros with f(0) = -1.
        Common range: [-5.12,5.12].")]
        public static object TestFunctions_DropWave([ExcelArgument(Name = "x")] System.Double x, [ExcelArgument(Name = "y")] System.Double y)
        {
            try
            {
                return math.net.xladdin.generated.Internal.TestFunctions_DropWave_Internal(x, y);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.TestFunctions.Ackley", Description=@"Ackley, a function with many local minima. It is nearly flat in outer regions but has a large hole at the center.
        Global minimum of all zeros with f(0) = 0.
        Common range: [-32.768, 32.768].")]
        public static object TestFunctions_Ackley([ExcelArgument(Name = "x")] System.Double[] x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.TestFunctions_Ackley_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.TestFunctions.Bohachevsky1", Description=@"Bowl-shaped first Bohachevsky function.
        Global minimum of all zeros with f(0,0) = 0.
        Common range: [-100, 100]")]
        public static object TestFunctions_Bohachevsky1([ExcelArgument(Name = "x")] System.Double x, [ExcelArgument(Name = "y")] System.Double y)
        {
            try
            {
                return math.net.xladdin.generated.Internal.TestFunctions_Bohachevsky1_Internal(x, y);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.TestFunctions.Matyas", Description=@"Plate-shaped Matyas function.
        Global minimum of all zeros with f(0,0) = 0.
        Common range: [-10, 10].")]
        public static object TestFunctions_Matyas([ExcelArgument(Name = "x")] System.Double x, [ExcelArgument(Name = "y")] System.Double y)
        {
            try
            {
                return math.net.xladdin.generated.Internal.TestFunctions_Matyas_Internal(x, y);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.TestFunctions.SixHumpCamel", Description=@"Valley-shaped six-hump camel back function.
        Two global minima and four local minima. Global minima with f(x) ) -1.0316 at (0.0898,-0.7126) and (-0.0898,0.7126).
        Common range: x in [-3,3], y in [-2,2].")]
        public static object TestFunctions_SixHumpCamel([ExcelArgument(Name = "x")] System.Double x, [ExcelArgument(Name = "y")] System.Double y)
        {
            try
            {
                return math.net.xladdin.generated.Internal.TestFunctions_SixHumpCamel_Internal(x, y);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.DegreeToGrad", Description=@"Converts a degree (360-periodic) angle to a grad (400-periodic) angle.")]
        public static object Trig_DegreeToGrad([ExcelArgument(Name = "degree")] System.Double degree)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_DegreeToGrad_Internal(degree);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.DegreeToRadian", Description=@"Converts a degree (360-periodic) angle to a radian (2*Pi-periodic) angle.")]
        public static object Trig_DegreeToRadian([ExcelArgument(Name = "degree")] System.Double degree)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_DegreeToRadian_Internal(degree);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.GradToDegree", Description=@"Converts a grad (400-periodic) angle to a degree (360-periodic) angle.")]
        public static object Trig_GradToDegree([ExcelArgument(Name = "grad")] System.Double grad)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_GradToDegree_Internal(grad);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.GradToRadian", Description=@"Converts a grad (400-periodic) angle to a radian (2*Pi-periodic) angle.")]
        public static object Trig_GradToRadian([ExcelArgument(Name = "grad")] System.Double grad)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_GradToRadian_Internal(grad);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.RadianToDegree", Description=@"Converts a radian (2*Pi-periodic) angle to a degree (360-periodic) angle.")]
        public static object Trig_RadianToDegree([ExcelArgument(Name = "radian")] System.Double radian)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_RadianToDegree_Internal(radian);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.RadianToGrad", Description=@"Converts a radian (2*Pi-periodic) angle to a grad (400-periodic) angle.")]
        public static object Trig_RadianToGrad([ExcelArgument(Name = "radian")] System.Double radian)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_RadianToGrad_Internal(radian);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Sinc", Description=@"Normalized Sinc function. sinc(x) = sin(pi*x)/(pi*x).")]
        public static object Trig_Sinc([ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Sinc_Internal(x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Sin", Description=@"Trigonometric Sine of an angle in radian, or opposite / hypotenuse.")]
        public static object Trig_Sin([ExcelArgument(Name = "radian")] System.Double radian)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Sin_Internal(radian);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Cos", Description=@"Trigonometric Cosine of an angle in radian, or adjacent / hypotenuse.")]
        public static object Trig_Cos([ExcelArgument(Name = "radian")] System.Double radian)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Cos_Internal(radian);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Tan", Description=@"Trigonometric Tangent of an angle in radian, or opposite / adjacent.")]
        public static object Trig_Tan([ExcelArgument(Name = "radian")] System.Double radian)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Tan_Internal(radian);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Cot", Description=@"Trigonometric Cotangent of an angle in radian, or adjacent / opposite. Reciprocal of the tangent.")]
        public static object Trig_Cot([ExcelArgument(Name = "radian")] System.Double radian)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Cot_Internal(radian);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Sec", Description=@"Trigonometric Secant of an angle in radian, or hypotenuse / adjacent. Reciprocal of the cosine.")]
        public static object Trig_Sec([ExcelArgument(Name = "radian")] System.Double radian)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Sec_Internal(radian);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Csc", Description=@"Trigonometric Cosecant of an angle in radian, or hypotenuse / opposite. Reciprocal of the sine.")]
        public static object Trig_Csc([ExcelArgument(Name = "radian")] System.Double radian)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Csc_Internal(radian);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Asin", Description=@"Trigonometric principal Arc Sine in radian")]
        public static object Trig_Asin([ExcelArgument(Name = "opposite")] System.Double opposite)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Asin_Internal(opposite);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Acos", Description=@"Trigonometric principal Arc Cosine in radian")]
        public static object Trig_Acos([ExcelArgument(Name = "adjacent")] System.Double adjacent)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Acos_Internal(adjacent);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Atan", Description=@"Trigonometric principal Arc Tangent  in radian")]
        public static object Trig_Atan([ExcelArgument(Name = "opposite")] System.Double opposite)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Atan_Internal(opposite);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Acot", Description=@"Trigonometric principal Arc Cotangent in radian")]
        public static object Trig_Acot([ExcelArgument(Name = "adjacent")] System.Double adjacent)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Acot_Internal(adjacent);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Asec", Description=@"Trigonometric principal Arc Secant in radian")]
        public static object Trig_Asec([ExcelArgument(Name = "hypotenuse")] System.Double hypotenuse)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Asec_Internal(hypotenuse);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Acsc", Description=@"Trigonometric principal Arc Cosecant in radian")]
        public static object Trig_Acsc([ExcelArgument(Name = "hypotenuse")] System.Double hypotenuse)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Acsc_Internal(hypotenuse);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Sinh", Description=@"Hyperbolic Sine")]
        public static object Trig_Sinh([ExcelArgument(Name = "angle")] System.Double angle)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Sinh_Internal(angle);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Cosh", Description=@"Hyperbolic Cosine")]
        public static object Trig_Cosh([ExcelArgument(Name = "angle")] System.Double angle)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Cosh_Internal(angle);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Tanh", Description=@"Hyperbolic Tangent in radian")]
        public static object Trig_Tanh([ExcelArgument(Name = "angle")] System.Double angle)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Tanh_Internal(angle);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Coth", Description=@"Hyperbolic Cotangent")]
        public static object Trig_Coth([ExcelArgument(Name = "angle")] System.Double angle)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Coth_Internal(angle);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Sech", Description=@"Hyperbolic Secant")]
        public static object Trig_Sech([ExcelArgument(Name = "angle")] System.Double angle)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Sech_Internal(angle);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Csch", Description=@"Hyperbolic Cosecant")]
        public static object Trig_Csch([ExcelArgument(Name = "angle")] System.Double angle)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Csch_Internal(angle);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Asinh", Description=@"Hyperbolic Area Sine")]
        public static object Trig_Asinh([ExcelArgument(Name = "value")] System.Double value)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Asinh_Internal(value);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Acosh", Description=@"Hyperbolic Area Cosine")]
        public static object Trig_Acosh([ExcelArgument(Name = "value")] System.Double value)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Acosh_Internal(value);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Atanh", Description=@"Hyperbolic Area Tangent")]
        public static object Trig_Atanh([ExcelArgument(Name = "value")] System.Double value)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Atanh_Internal(value);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Acoth", Description=@"Hyperbolic Area Cotangent")]
        public static object Trig_Acoth([ExcelArgument(Name = "value")] System.Double value)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Acoth_Internal(value);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Asech", Description=@"Hyperbolic Area Secant")]
        public static object Trig_Asech([ExcelArgument(Name = "value")] System.Double value)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Asech_Internal(value);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Trig.Acsch", Description=@"Hyperbolic Area Cosecant")]
        public static object Trig_Acsch([ExcelArgument(Name = "value")] System.Double value)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Trig_Acsch_Internal(value);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.Hamming", Description=@"Hamming window. Named after Richard Hamming.
        Symmetric version, useful e.g. for filter design purposes.")]
        public static object Window_Hamming([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_Hamming_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.HammingPeriodic", Description=@"Hamming window. Named after Richard Hamming.
        Periodic version, useful e.g. for FFT purposes.")]
        public static object Window_HammingPeriodic([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_HammingPeriodic_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.Hann", Description=@"Hann window. Named after Julius von Hann.
        Symmetric version, useful e.g. for filter design purposes.")]
        public static object Window_Hann([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_Hann_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.HannPeriodic", Description=@"Hann window. Named after Julius von Hann.
        Periodic version, useful e.g. for FFT purposes.")]
        public static object Window_HannPeriodic([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_HannPeriodic_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.Cosine", Description=@"Cosine window.
        Symmetric version, useful e.g. for filter design purposes.")]
        public static object Window_Cosine([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_Cosine_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.CosinePeriodic", Description=@"Cosine window.
        Periodic version, useful e.g. for FFT purposes.")]
        public static object Window_CosinePeriodic([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_CosinePeriodic_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.Lanczos", Description=@"Lanczos window.
        Symmetric version, useful e.g. for filter design purposes.")]
        public static object Window_Lanczos([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_Lanczos_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.LanczosPeriodic", Description=@"Lanczos window.
        Periodic version, useful e.g. for FFT purposes.")]
        public static object Window_LanczosPeriodic([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_LanczosPeriodic_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.Gauss", Description=@"Gauss window.")]
        public static object Window_Gauss([ExcelArgument(Name = "width")] System.Int32 width, [ExcelArgument(Name = "sigma")] System.Double sigma)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_Gauss_Internal(width, sigma);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.Blackman", Description=@"Blackman window.")]
        public static object Window_Blackman([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_Blackman_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.BlackmanHarris", Description=@"Blackman-Harris window.")]
        public static object Window_BlackmanHarris([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_BlackmanHarris_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.BlackmanNuttall", Description=@"Blackman-Nuttall window.")]
        public static object Window_BlackmanNuttall([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_BlackmanNuttall_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.Bartlett", Description=@"Bartlett window.")]
        public static object Window_Bartlett([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_Bartlett_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.BartlettHann", Description=@"Bartlett-Hann window.")]
        public static object Window_BartlettHann([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_BartlettHann_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.Nuttall", Description=@"Nuttall window.")]
        public static object Window_Nuttall([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_Nuttall_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.FlatTop", Description=@"Flat top window.")]
        public static object Window_FlatTop([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_FlatTop_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.Dirichlet", Description=@"Uniform rectangular (dirichlet) window.")]
        public static object Window_Dirichlet([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_Dirichlet_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Window.Triangular", Description=@"Triangular window.")]
        public static object Window_Triangular([ExcelArgument(Name = "width")] System.Int32 width)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Window_Triangular_Internal(width);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.Minimum", Description=@"Returns the smallest value from the unsorted data array.
        Returns NaN if data is empty or any entry is NaN.")]
        public static object Statistics_ArrayStatistics_Minimum([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_Minimum_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.Maximum", Description=@"Returns the largest value from the unsorted data array.
        Returns NaN if data is empty or any entry is NaN.")]
        public static object Statistics_ArrayStatistics_Maximum([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_Maximum_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.MinimumAbsolute", Description=@"Returns the smallest absolute value from the unsorted data array.
        Returns NaN if data is empty or any entry is NaN.")]
        public static object Statistics_ArrayStatistics_MinimumAbsolute([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_MinimumAbsolute_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.MaximumAbsolute", Description=@"Returns the largest absolute value from the unsorted data array.
        Returns NaN if data is empty or any entry is NaN.")]
        public static object Statistics_ArrayStatistics_MaximumAbsolute([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_MaximumAbsolute_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.Mean", Description=@"Estimates the arithmetic sample mean from the unsorted data array.
        Returns NaN if data is empty or any entry is NaN.")]
        public static object Statistics_ArrayStatistics_Mean([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_Mean_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.GeometricMean", Description=@"Evaluates the geometric mean of the unsorted data array.
        Returns NaN if data is empty or any entry is NaN.")]
        public static object Statistics_ArrayStatistics_GeometricMean([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_GeometricMean_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.HarmonicMean", Description=@"Evaluates the harmonic mean of the unsorted data array.
        Returns NaN if data is empty or any entry is NaN.")]
        public static object Statistics_ArrayStatistics_HarmonicMean([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_HarmonicMean_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.Variance", Description=@"Estimates the unbiased population variance from the provided samples as unsorted array.
        On a dataset of size N will use an N-1 normalizer (Bessel's correction).
        Returns NaN if data has less than two entries or if any entry is NaN.")]
        public static object Statistics_ArrayStatistics_Variance([ExcelArgument(Name = "samples")] System.Double[] samples)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_Variance_Internal(samples);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.PopulationVariance", Description=@"Evaluates the population variance from the full population provided as unsorted array.
        On a dataset of size N will use an N normalizer and would thus be biased if applied to a subset.
        Returns NaN if data is empty or if any entry is NaN.")]
        public static object Statistics_ArrayStatistics_PopulationVariance([ExcelArgument(Name = "population")] System.Double[] population)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_PopulationVariance_Internal(population);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.StandardDeviation", Description=@"Estimates the unbiased population standard deviation from the provided samples as unsorted array.
        On a dataset of size N will use an N-1 normalizer (Bessel's correction).
        Returns NaN if data has less than two entries or if any entry is NaN.")]
        public static object Statistics_ArrayStatistics_StandardDeviation([ExcelArgument(Name = "samples")] System.Double[] samples)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_StandardDeviation_Internal(samples);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.PopulationStandardDeviation", Description=@"Evaluates the population standard deviation from the full population provided as unsorted array.
        On a dataset of size N will use an N normalizer and would thus be biased if applied to a subset.
        Returns NaN if data is empty or if any entry is NaN.")]
        public static object Statistics_ArrayStatistics_PopulationStandardDeviation([ExcelArgument(Name = "population")] System.Double[] population)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_PopulationStandardDeviation_Internal(population);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.Covariance", Description=@"Estimates the unbiased population covariance from the provided two sample arrays.
        On a dataset of size N will use an N-1 normalizer (Bessel's correction).
        Returns NaN if data has less than two entries or if any entry is NaN.")]
        public static object Statistics_ArrayStatistics_Covariance([ExcelArgument(Name = "samples1")] System.Double[] samples1, [ExcelArgument(Name = "samples2")] System.Double[] samples2)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_Covariance_Internal(samples1, samples2);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.PopulationCovariance", Description=@"Evaluates the population covariance from the full population provided as two arrays.
        On a dataset of size N will use an N normalizer and would thus be biased if applied to a subset.
        Returns NaN if data is empty or if any entry is NaN.")]
        public static object Statistics_ArrayStatistics_PopulationCovariance([ExcelArgument(Name = "population1")] System.Double[] population1, [ExcelArgument(Name = "population2")] System.Double[] population2)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_PopulationCovariance_Internal(population1, population2);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.RootMeanSquare", Description=@"Estimates the root mean square (RMS) also known as quadratic mean from the unsorted data array.
        Returns NaN if data is empty or any entry is NaN.")]
        public static object Statistics_ArrayStatistics_RootMeanSquare([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_RootMeanSquare_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.OrderStatisticInplace", Description=@"Returns the order statistic (order 1..N) from the unsorted data array.
        WARNING: Works inplace and can thus causes the data array to be reordered.")]
        public static object Statistics_ArrayStatistics_OrderStatisticInplace([ExcelArgument(Name = "data")] System.Double[] data, [ExcelArgument(Name = "order")] System.Int32 order)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_OrderStatisticInplace_Internal(data, order);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.MedianInplace", Description=@"Estimates the median value from the unsorted data array.
        WARNING: Works inplace and can thus causes the data array to be reordered.")]
        public static object Statistics_ArrayStatistics_MedianInplace([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_MedianInplace_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.PercentileInplace", Description=@"Estimates the p-Percentile value from the unsorted data array.
        If a non-integer Percentile is needed, use Quantile instead.
        Approximately median-unbiased regardless of the sample distribution (R8).
        WARNING: Works inplace and can thus causes the data array to be reordered.")]
        public static object Statistics_ArrayStatistics_PercentileInplace([ExcelArgument(Name = "data")] System.Double[] data, [ExcelArgument(Name = "p")] System.Int32 p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_PercentileInplace_Internal(data, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.LowerQuartileInplace", Description=@"Estimates the first quartile value from the unsorted data array.
        Approximately median-unbiased regardless of the sample distribution (R8).
        WARNING: Works inplace and can thus causes the data array to be reordered.")]
        public static object Statistics_ArrayStatistics_LowerQuartileInplace([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_LowerQuartileInplace_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.UpperQuartileInplace", Description=@"Estimates the third quartile value from the unsorted data array.
        Approximately median-unbiased regardless of the sample distribution (R8).
        WARNING: Works inplace and can thus causes the data array to be reordered.")]
        public static object Statistics_ArrayStatistics_UpperQuartileInplace([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_UpperQuartileInplace_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.InterquartileRangeInplace", Description=@"Estimates the inter-quartile range from the unsorted data array.
        Approximately median-unbiased regardless of the sample distribution (R8).
        WARNING: Works inplace and can thus causes the data array to be reordered.")]
        public static object Statistics_ArrayStatistics_InterquartileRangeInplace([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_InterquartileRangeInplace_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.FiveNumberSummaryInplace", Description=@"Estimates {min, lower-quantile, median, upper-quantile, max} from the unsorted data array.
        Approximately median-unbiased regardless of the sample distribution (R8).
        WARNING: Works inplace and can thus causes the data array to be reordered.")]
        public static object Statistics_ArrayStatistics_FiveNumberSummaryInplace([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_FiveNumberSummaryInplace_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.QuantileInplace", Description=@"Estimates the tau-th quantile from the unsorted data array.
        The tau-th quantile is the data value where the cumulative distribution
        function crosses tau.
        Approximately median-unbiased regardless of the sample distribution (R8).
        WARNING: Works inplace and can thus causes the data array to be reordered.")]
        public static object Statistics_ArrayStatistics_QuantileInplace([ExcelArgument(Name = "data")] System.Double[] data, [ExcelArgument(Name = "tau")] System.Double tau)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_QuantileInplace_Internal(data, tau);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.QuantileCustomInplace", Description=@"Estimates the tau-th quantile from the unsorted data array.
        The tau-th quantile is the data value where the cumulative distribution
        function crosses tau. The quantile defintion can be specified
        by 4 parameters a, b, c and d, consistent with Mathematica.
        WARNING: Works inplace and can thus causes the data array to be reordered.")]
        public static object Statistics_ArrayStatistics_QuantileCustomInplace([ExcelArgument(Name = "data")] System.Double[] data, [ExcelArgument(Name = "tau")] System.Double tau, [ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "c")] System.Double c, [ExcelArgument(Name = "d")] System.Double d)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_QuantileCustomInplace_Internal(data, tau, a, b, c, d);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.MinimumMagnitudePhase")]
        public static object Statistics_ArrayStatistics_MinimumMagnitudePhase([ExcelArgument(Name = "data")] System.Numerics.Complex[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_MinimumMagnitudePhase_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.ArrayStatistics.MaximumMagnitudePhase")]
        public static object Statistics_ArrayStatistics_MaximumMagnitudePhase([ExcelArgument(Name = "data")] System.Numerics.Complex[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_ArrayStatistics_MaximumMagnitudePhase_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.SortedArrayStatistics.Minimum", Description=@"Returns the smallest value from the sorted data array (ascending).")]
        public static object Statistics_SortedArrayStatistics_Minimum([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_SortedArrayStatistics_Minimum_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.SortedArrayStatistics.Maximum", Description=@"Returns the largest value from the sorted data array (ascending).")]
        public static object Statistics_SortedArrayStatistics_Maximum([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_SortedArrayStatistics_Maximum_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.SortedArrayStatistics.OrderStatistic", Description=@"Returns the order statistic (order 1..N) from the sorted data array (ascending).")]
        public static object Statistics_SortedArrayStatistics_OrderStatistic([ExcelArgument(Name = "data")] System.Double[] data, [ExcelArgument(Name = "order")] System.Int32 order)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_SortedArrayStatistics_OrderStatistic_Internal(data, order);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.SortedArrayStatistics.Median", Description=@"Estimates the median value from the sorted data array (ascending).
        Approximately median-unbiased regardless of the sample distribution (R8).")]
        public static object Statistics_SortedArrayStatistics_Median([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_SortedArrayStatistics_Median_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.SortedArrayStatistics.Percentile", Description=@"Estimates the p-Percentile value from the sorted data array (ascending).
        If a non-integer Percentile is needed, use Quantile instead.
        Approximately median-unbiased regardless of the sample distribution (R8).")]
        public static object Statistics_SortedArrayStatistics_Percentile([ExcelArgument(Name = "data")] System.Double[] data, [ExcelArgument(Name = "p")] System.Int32 p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_SortedArrayStatistics_Percentile_Internal(data, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.SortedArrayStatistics.LowerQuartile", Description=@"Estimates the first quartile value from the sorted data array (ascending).
        Approximately median-unbiased regardless of the sample distribution (R8).")]
        public static object Statistics_SortedArrayStatistics_LowerQuartile([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_SortedArrayStatistics_LowerQuartile_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.SortedArrayStatistics.UpperQuartile", Description=@"Estimates the third quartile value from the sorted data array (ascending).
        Approximately median-unbiased regardless of the sample distribution (R8).")]
        public static object Statistics_SortedArrayStatistics_UpperQuartile([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_SortedArrayStatistics_UpperQuartile_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.SortedArrayStatistics.InterquartileRange", Description=@"Estimates the inter-quartile range from the sorted data array (ascending).
        Approximately median-unbiased regardless of the sample distribution (R8).")]
        public static object Statistics_SortedArrayStatistics_InterquartileRange([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_SortedArrayStatistics_InterquartileRange_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.SortedArrayStatistics.FiveNumberSummary", Description=@"Estimates {min, lower-quantile, median, upper-quantile, max} from the sorted data array (ascending).
        Approximately median-unbiased regardless of the sample distribution (R8).")]
        public static object Statistics_SortedArrayStatistics_FiveNumberSummary([ExcelArgument(Name = "data")] System.Double[] data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_SortedArrayStatistics_FiveNumberSummary_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.SortedArrayStatistics.Quantile", Description=@"Estimates the tau-th quantile from the sorted data array (ascending).
        The tau-th quantile is the data value where the cumulative distribution
        function crosses tau.
        Approximately median-unbiased regardless of the sample distribution (R8).")]
        public static object Statistics_SortedArrayStatistics_Quantile([ExcelArgument(Name = "data")] System.Double[] data, [ExcelArgument(Name = "tau")] System.Double tau)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_SortedArrayStatistics_Quantile_Internal(data, tau);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.SortedArrayStatistics.QuantileCustom", Description=@"Estimates the tau-th quantile from the sorted data array (ascending).
        The tau-th quantile is the data value where the cumulative distribution
        function crosses tau. The quantile defintion can be specified
        by 4 parameters a, b, c and d, consistent with Mathematica.")]
        public static object Statistics_SortedArrayStatistics_QuantileCustom([ExcelArgument(Name = "data")] System.Double[] data, [ExcelArgument(Name = "tau")] System.Double tau, [ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "c")] System.Double c, [ExcelArgument(Name = "d")] System.Double d)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_SortedArrayStatistics_QuantileCustom_Internal(data, tau, a, b, c, d);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.SortedArrayStatistics.EmpiricalCDF", Description=@"Estimates the empirical cumulative distribution function (CDF) at x from the sorted data array (ascending).")]
        public static object Statistics_SortedArrayStatistics_EmpiricalCDF([ExcelArgument(Name = "data")] System.Double[] data, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_SortedArrayStatistics_EmpiricalCDF_Internal(data, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.Minimum")]
        public static object Statistics_StreamingStatistics_Minimum([ExcelArgument(Name = "stream")] System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_Minimum_Internal(stream);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.Maximum")]
        public static object Statistics_StreamingStatistics_Maximum([ExcelArgument(Name = "stream")] System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_Maximum_Internal(stream);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.MinimumAbsolute")]
        public static object Statistics_StreamingStatistics_MinimumAbsolute([ExcelArgument(Name = "stream")] System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_MinimumAbsolute_Internal(stream);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.MaximumAbsolute")]
        public static object Statistics_StreamingStatistics_MaximumAbsolute([ExcelArgument(Name = "stream")] System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_MaximumAbsolute_Internal(stream);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.MinimumMagnitudePhase")]
        public static object Statistics_StreamingStatistics_MinimumMagnitudePhase([ExcelArgument(Name = "stream")] System.Collections.Generic.IEnumerable<System.Numerics.Complex> stream)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_MinimumMagnitudePhase_Internal(stream);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.MaximumMagnitudePhase")]
        public static object Statistics_StreamingStatistics_MaximumMagnitudePhase([ExcelArgument(Name = "stream")] System.Collections.Generic.IEnumerable<System.Numerics.Complex> stream)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_MaximumMagnitudePhase_Internal(stream);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.Mean")]
        public static object Statistics_StreamingStatistics_Mean([ExcelArgument(Name = "stream")] System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_Mean_Internal(stream);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.GeometricMean")]
        public static object Statistics_StreamingStatistics_GeometricMean([ExcelArgument(Name = "stream")] System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_GeometricMean_Internal(stream);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.HarmonicMean")]
        public static object Statistics_StreamingStatistics_HarmonicMean([ExcelArgument(Name = "stream")] System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_HarmonicMean_Internal(stream);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.Variance")]
        public static object Statistics_StreamingStatistics_Variance([ExcelArgument(Name = "samples")] System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_Variance_Internal(samples);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.PopulationVariance")]
        public static object Statistics_StreamingStatistics_PopulationVariance([ExcelArgument(Name = "population")] System.Collections.Generic.IEnumerable<System.Double> population)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_PopulationVariance_Internal(population);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.StandardDeviation")]
        public static object Statistics_StreamingStatistics_StandardDeviation([ExcelArgument(Name = "samples")] System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_StandardDeviation_Internal(samples);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.PopulationStandardDeviation")]
        public static object Statistics_StreamingStatistics_PopulationStandardDeviation([ExcelArgument(Name = "population")] System.Collections.Generic.IEnumerable<System.Double> population)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_PopulationStandardDeviation_Internal(population);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.Covariance")]
        public static object Statistics_StreamingStatistics_Covariance([ExcelArgument(Name = "samples1")] System.Collections.Generic.IEnumerable<System.Double> samples1, [ExcelArgument(Name = "samples2")] System.Collections.Generic.IEnumerable<System.Double> samples2)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_Covariance_Internal(samples1, samples2);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.PopulationCovariance")]
        public static object Statistics_StreamingStatistics_PopulationCovariance([ExcelArgument(Name = "population1")] System.Collections.Generic.IEnumerable<System.Double> population1, [ExcelArgument(Name = "population2")] System.Collections.Generic.IEnumerable<System.Double> population2)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_PopulationCovariance_Internal(population1, population2);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.RootMeanSquare")]
        public static object Statistics_StreamingStatistics_RootMeanSquare([ExcelArgument(Name = "stream")] System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_RootMeanSquare_Internal(stream);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.StreamingStatistics.Entropy")]
        public static object Statistics_StreamingStatistics_Entropy([ExcelArgument(Name = "stream")] System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_StreamingStatistics_Entropy_Internal(stream);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Correlation.Pearson")]
        public static object Statistics_Correlation_Pearson([ExcelArgument(Name = "dataA")] System.Collections.Generic.IEnumerable<System.Double> dataA, [ExcelArgument(Name = "dataB")] System.Collections.Generic.IEnumerable<System.Double> dataB)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Correlation_Pearson_Internal(dataA, dataB);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Correlation.WeightedPearson")]
        public static object Statistics_Correlation_WeightedPearson([ExcelArgument(Name = "dataA")] System.Collections.Generic.IEnumerable<System.Double> dataA, [ExcelArgument(Name = "dataB")] System.Collections.Generic.IEnumerable<System.Double> dataB, [ExcelArgument(Name = "weights")] System.Collections.Generic.IEnumerable<System.Double> weights)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Correlation_WeightedPearson_Internal(dataA, dataB, weights);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Correlation.Spearman")]
        public static object Statistics_Correlation_Spearman([ExcelArgument(Name = "dataA")] System.Collections.Generic.IEnumerable<System.Double> dataA, [ExcelArgument(Name = "dataB")] System.Collections.Generic.IEnumerable<System.Double> dataB)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Correlation_Spearman_Internal(dataA, dataB);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.FiveNumberSummary")]
        public static object Statistics_Statistics_FiveNumberSummary([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_FiveNumberSummary_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.OrderStatistic")]
        public static object Statistics_Statistics_OrderStatistic([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data, [ExcelArgument(Name = "order")] System.Int32 order)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_OrderStatistic_Internal(data, order);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.EmpiricalCDF")]
        public static object Statistics_Statistics_EmpiricalCDF([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_EmpiricalCDF_Internal(data, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.EmpiricalInvCDF")]
        public static object Statistics_Statistics_EmpiricalInvCDF([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data, [ExcelArgument(Name = "tau")] System.Double tau)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_EmpiricalInvCDF_Internal(data, tau);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.Entropy")]
        public static object Statistics_Statistics_Entropy([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_Entropy_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.MovingAverage")]
        public static object Statistics_Statistics_MovingAverage([ExcelArgument(Name = "samples")] System.Collections.Generic.IEnumerable<System.Double> samples, [ExcelArgument(Name = "windowSize")] System.Int32 windowSize)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_MovingAverage_Internal(samples, windowSize);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.Minimum")]
        public static object Statistics_Statistics_Minimum([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_Minimum_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.Maximum")]
        public static object Statistics_Statistics_Maximum([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_Maximum_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.MinimumAbsolute")]
        public static object Statistics_Statistics_MinimumAbsolute([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_MinimumAbsolute_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.MaximumAbsolute")]
        public static object Statistics_Statistics_MaximumAbsolute([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_MaximumAbsolute_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.MinimumMagnitudePhase")]
        public static object Statistics_Statistics_MinimumMagnitudePhase([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Numerics.Complex> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_MinimumMagnitudePhase_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.MaximumMagnitudePhase")]
        public static object Statistics_Statistics_MaximumMagnitudePhase([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Numerics.Complex> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_MaximumMagnitudePhase_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.Mean")]
        public static object Statistics_Statistics_Mean([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_Mean_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.GeometricMean")]
        public static object Statistics_Statistics_GeometricMean([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_GeometricMean_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.HarmonicMean")]
        public static object Statistics_Statistics_HarmonicMean([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_HarmonicMean_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.Variance")]
        public static object Statistics_Statistics_Variance([ExcelArgument(Name = "samples")] System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_Variance_Internal(samples);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.PopulationVariance")]
        public static object Statistics_Statistics_PopulationVariance([ExcelArgument(Name = "population")] System.Collections.Generic.IEnumerable<System.Double> population)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_PopulationVariance_Internal(population);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.StandardDeviation")]
        public static object Statistics_Statistics_StandardDeviation([ExcelArgument(Name = "samples")] System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_StandardDeviation_Internal(samples);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.PopulationStandardDeviation")]
        public static object Statistics_Statistics_PopulationStandardDeviation([ExcelArgument(Name = "population")] System.Collections.Generic.IEnumerable<System.Double> population)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_PopulationStandardDeviation_Internal(population);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.Skewness")]
        public static object Statistics_Statistics_Skewness([ExcelArgument(Name = "samples")] System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_Skewness_Internal(samples);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.PopulationSkewness")]
        public static object Statistics_Statistics_PopulationSkewness([ExcelArgument(Name = "population")] System.Collections.Generic.IEnumerable<System.Double> population)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_PopulationSkewness_Internal(population);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.Kurtosis")]
        public static object Statistics_Statistics_Kurtosis([ExcelArgument(Name = "samples")] System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_Kurtosis_Internal(samples);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.PopulationKurtosis")]
        public static object Statistics_Statistics_PopulationKurtosis([ExcelArgument(Name = "population")] System.Collections.Generic.IEnumerable<System.Double> population)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_PopulationKurtosis_Internal(population);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.Covariance")]
        public static object Statistics_Statistics_Covariance([ExcelArgument(Name = "samples1")] System.Collections.Generic.IEnumerable<System.Double> samples1, [ExcelArgument(Name = "samples2")] System.Collections.Generic.IEnumerable<System.Double> samples2)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_Covariance_Internal(samples1, samples2);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.PopulationCovariance")]
        public static object Statistics_Statistics_PopulationCovariance([ExcelArgument(Name = "population1")] System.Collections.Generic.IEnumerable<System.Double> population1, [ExcelArgument(Name = "population2")] System.Collections.Generic.IEnumerable<System.Double> population2)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_PopulationCovariance_Internal(population1, population2);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.RootMeanSquare")]
        public static object Statistics_Statistics_RootMeanSquare([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_RootMeanSquare_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.Median")]
        public static object Statistics_Statistics_Median([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_Median_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.Quantile")]
        public static object Statistics_Statistics_Quantile([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data, [ExcelArgument(Name = "tau")] System.Double tau)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_Quantile_Internal(data, tau);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.Percentile")]
        public static object Statistics_Statistics_Percentile([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data, [ExcelArgument(Name = "p")] System.Int32 p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_Percentile_Internal(data, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.LowerQuartile")]
        public static object Statistics_Statistics_LowerQuartile([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_LowerQuartile_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.UpperQuartile")]
        public static object Statistics_Statistics_UpperQuartile([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_UpperQuartile_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Statistics.Statistics.InterquartileRange")]
        public static object Statistics_Statistics_InterquartileRange([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Statistics_Statistics_InterquartileRange_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.SystemRandomSource.FastDoubles", Description=@"Returns an array of uniform random numbers greater than or equal to 0.0 and less than 1.0.
        WARNING: potentially very short random sequence length, can generate repeated partial sequences.")]
        public static object Random_SystemRandomSource_FastDoubles([ExcelArgument(Name = "length")] System.Int32 length)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_SystemRandomSource_FastDoubles_Internal(length);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.SystemRandomSource.DoubleSequence_0")]
        public static object Random_SystemRandomSource_DoubleSequence_0()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_SystemRandomSource_DoubleSequence_0_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.SystemRandomSource.DoubleSequence_1", Description=@"Returns an infinite sequence of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_SystemRandomSource_DoubleSequence_1([ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_SystemRandomSource_DoubleSequence_1_Internal(seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.SystemRandomSource.Doubles", Description=@"Returns an array of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_SystemRandomSource_Doubles([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_SystemRandomSource_Doubles_Internal(length, seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.RandomSeed.Time")]
        public static object Random_RandomSeed_Time()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_RandomSeed_Time_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.RandomSeed.Guid")]
        public static object Random_RandomSeed_Guid()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_RandomSeed_Guid_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.RandomSeed.Robust")]
        public static object Random_RandomSeed_Robust()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_RandomSeed_Robust_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.Mcg31m1.Doubles", Description=@"Returns an array of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_Mcg31m1_Doubles([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_Mcg31m1_Doubles_Internal(length, seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.Mcg31m1.DoubleSequence", Description=@"Returns an infinite sequence of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_Mcg31m1_DoubleSequence([ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_Mcg31m1_DoubleSequence_Internal(seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.Mcg59.Doubles", Description=@"Returns an array of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_Mcg59_Doubles([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_Mcg59_Doubles_Internal(length, seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.Mcg59.DoubleSequence", Description=@"Returns an infinite sequence of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_Mcg59_DoubleSequence([ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_Mcg59_DoubleSequence_Internal(seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.MersenneTwister.Doubles", Description=@"Returns an array of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_MersenneTwister_Doubles([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_MersenneTwister_Doubles_Internal(length, seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.MersenneTwister.DoubleSequence", Description=@"Returns an infinite sequence of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_MersenneTwister_DoubleSequence([ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_MersenneTwister_DoubleSequence_Internal(seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.Mrg32k3a.Doubles", Description=@"Returns an array of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_Mrg32k3a_Doubles([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_Mrg32k3a_Doubles_Internal(length, seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.Mrg32k3a.DoubleSequence", Description=@"Returns an infinite sequence of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_Mrg32k3a_DoubleSequence([ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_Mrg32k3a_DoubleSequence_Internal(seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.Palf.Doubles", Description=@"Returns an array of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_Palf_Doubles([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_Palf_Doubles_Internal(length, seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.Palf.DoubleSequence", Description=@"Returns an infinite sequence of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_Palf_DoubleSequence([ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_Palf_DoubleSequence_Internal(seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.CryptoRandomSource.Doubles", Description=@"Returns an array of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_CryptoRandomSource_Doubles([ExcelArgument(Name = "length")] System.Int32 length)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_CryptoRandomSource_Doubles_Internal(length);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.CryptoRandomSource.DoubleSequence")]
        public static object Random_CryptoRandomSource_DoubleSequence()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_CryptoRandomSource_DoubleSequence_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.WH1982.Doubles", Description=@"Returns an array of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_WH1982_Doubles([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_WH1982_Doubles_Internal(length, seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.WH1982.DoubleSequence", Description=@"Returns an infinite sequence of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_WH1982_DoubleSequence([ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_WH1982_DoubleSequence_Internal(seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.WH2006.Doubles", Description=@"Returns an array of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_WH2006_Doubles([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_WH2006_Doubles_Internal(length, seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Random.WH2006.DoubleSequence", Description=@"Returns an infinite sequence of random numbers greater than or equal to 0.0 and less than 1.0.")]
        public static object Random_WH2006_DoubleSequence([ExcelArgument(Name = "seed")] System.Int32 seed)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Random_WH2006_DoubleSequence_Internal(seed);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Financial.AbsoluteReturnMeasures.CompoundReturn")]
        public static object Financial_AbsoluteReturnMeasures_CompoundReturn([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Financial_AbsoluteReturnMeasures_CompoundReturn_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Financial.AbsoluteReturnMeasures.GainMean")]
        public static object Financial_AbsoluteReturnMeasures_GainMean([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Financial_AbsoluteReturnMeasures_GainMean_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Financial.AbsoluteReturnMeasures.LossMean")]
        public static object Financial_AbsoluteReturnMeasures_LossMean([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Financial_AbsoluteReturnMeasures_LossMean_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Financial.AbsoluteRiskMeasures.GainStandardDeviation")]
        public static object Financial_AbsoluteRiskMeasures_GainStandardDeviation([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Financial_AbsoluteRiskMeasures_GainStandardDeviation_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Financial.AbsoluteRiskMeasures.LossStandardDeviation")]
        public static object Financial_AbsoluteRiskMeasures_LossStandardDeviation([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Financial_AbsoluteRiskMeasures_LossStandardDeviation_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Financial.AbsoluteRiskMeasures.DownsideDeviation")]
        public static object Financial_AbsoluteRiskMeasures_DownsideDeviation([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data, [ExcelArgument(Name = "minimalAcceptableReturn")] System.Double minimalAcceptableReturn)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Financial_AbsoluteRiskMeasures_DownsideDeviation_Internal(data, minimalAcceptableReturn);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Financial.AbsoluteRiskMeasures.SemiDeviation")]
        public static object Financial_AbsoluteRiskMeasures_SemiDeviation([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Financial_AbsoluteRiskMeasures_SemiDeviation_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Financial.AbsoluteRiskMeasures.GainLossRatio")]
        public static object Financial_AbsoluteRiskMeasures_GainLossRatio([ExcelArgument(Name = "data")] System.Collections.Generic.IEnumerable<System.Double> data)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Financial_AbsoluteRiskMeasures_GainLossRatio_Internal(data);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Providers.LinearAlgebra.LinearAlgebraControl.TryUseNativeCUDA")]
        public static object Providers_LinearAlgebra_LinearAlgebraControl_TryUseNativeCUDA()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Providers_LinearAlgebra_LinearAlgebraControl_TryUseNativeCUDA_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Providers.LinearAlgebra.LinearAlgebraControl.TryUseNativeOpenBLAS")]
        public static object Providers_LinearAlgebra_LinearAlgebraControl_TryUseNativeOpenBLAS()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Providers_LinearAlgebra_LinearAlgebraControl_TryUseNativeOpenBLAS_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Providers.LinearAlgebra.LinearAlgebraControl.TryUseNative")]
        public static object Providers_LinearAlgebra_LinearAlgebraControl_TryUseNative()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Providers_LinearAlgebra_LinearAlgebraControl_TryUseNative_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Providers.FourierTransform.FourierTransformControl.TryUseNativeMKL")]
        public static object Providers_FourierTransform_FourierTransformControl_TryUseNativeMKL()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Providers_FourierTransform_FourierTransformControl_TryUseNativeMKL_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Providers.FourierTransform.FourierTransformControl.TryUseNative")]
        public static object Providers_FourierTransform_FourierTransformControl_TryUseNative()
        {
            try
            {
                return math.net.xladdin.generated.Internal.Providers_FourierTransform_FourierTransformControl_TryUseNative_Internal();
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.IntegralTransforms.Fourier.FrequencyScale", Description=@"Generate the frequencies corresponding to each index in frequency space.
        The frequency space has a resolution of sampleRate/N.
        Index 0 corresponds to the DC part, the following indices correspond to
        the positive frequencies up to the Nyquist frequency (sampleRate/2),
        followed by the negative frequencies wrapped around.")]
        public static object IntegralTransforms_Fourier_FrequencyScale([ExcelArgument(Name = "length")] System.Int32 length, [ExcelArgument(Name = "sampleRate")] System.Double sampleRate)
        {
            try
            {
                return math.net.xladdin.generated.Internal.IntegralTransforms_Fourier_FrequencyScale_Internal(length, sampleRate);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.BetaScaled.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_BetaScaled_IsValidParameterSet([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_BetaScaled_IsValidParameterSet_Internal(a, b, location, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.BetaScaled.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_BetaScaled_PDF([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_BetaScaled_PDF_Internal(a, b, location, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.BetaScaled.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_BetaScaled_PDFLn([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_BetaScaled_PDFLn_Internal(a, b, location, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.BetaScaled.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_BetaScaled_CDF([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_BetaScaled_CDF_Internal(a, b, location, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.BetaScaled.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_BetaScaled_InvCDF([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_BetaScaled_InvCDF_Internal(a, b, location, scale, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.BetaScaled.Sample", Description=@"Generates a sample from the distribution.")]
        public static object Distributions_BetaScaled_Sample([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_BetaScaled_Sample_Internal(a, b, location, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.BetaScaled.Samples", Description=@"Generates a sequence of samples from the distribution.")]
        public static object Distributions_BetaScaled_Samples([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_BetaScaled_Samples_Internal(a, b, location, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Triangular.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Triangular_IsValidParameterSet([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper, [ExcelArgument(Name = "mode")] System.Double mode)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Triangular_IsValidParameterSet_Internal(lower, upper, mode);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Triangular.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_Triangular_PDF([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper, [ExcelArgument(Name = "mode")] System.Double mode, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Triangular_PDF_Internal(lower, upper, mode, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Triangular.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_Triangular_PDFLn([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper, [ExcelArgument(Name = "mode")] System.Double mode, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Triangular_PDFLn_Internal(lower, upper, mode, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Triangular.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Triangular_CDF([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper, [ExcelArgument(Name = "mode")] System.Double mode, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Triangular_CDF_Internal(lower, upper, mode, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Triangular.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_Triangular_InvCDF([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper, [ExcelArgument(Name = "mode")] System.Double mode, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Triangular_InvCDF_Internal(lower, upper, mode, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Triangular.Sample", Description=@"Generates a sample from the Triangular distribution.")]
        public static object Distributions_Triangular_Sample([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper, [ExcelArgument(Name = "mode")] System.Double mode)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Triangular_Sample_Internal(lower, upper, mode);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Triangular.Samples", Description=@"Generates a sequence of samples from the Triangular distribution.")]
        public static object Distributions_Triangular_Samples([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper, [ExcelArgument(Name = "mode")] System.Double mode)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Triangular_Samples_Internal(lower, upper, mode);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Bernoulli.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Bernoulli_IsValidParameterSet([ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Bernoulli_IsValidParameterSet_Internal(p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Bernoulli.PMF", Description=@"Computes the probability mass (PMF) at k, i.e. P(X = k).")]
        public static object Distributions_Bernoulli_PMF([ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Bernoulli_PMF_Internal(p, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Bernoulli.PMFLn", Description=@"Computes the log probability mass (lnPMF) at k, i.e. ln(P(X = k)).")]
        public static object Distributions_Bernoulli_PMFLn([ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Bernoulli_PMFLn_Internal(p, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Bernoulli.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Bernoulli_CDF([ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Bernoulli_CDF_Internal(p, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Bernoulli.Sample", Description=@"Samples a Bernoulli distributed random variable.")]
        public static object Distributions_Bernoulli_Sample([ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Bernoulli_Sample_Internal(p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Bernoulli.Samples", Description=@"Samples a sequence of Bernoulli distributed random variables.")]
        public static object Distributions_Bernoulli_Samples([ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Bernoulli_Samples_Internal(p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Beta.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Beta_IsValidParameterSet([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Beta_IsValidParameterSet_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Beta.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_Beta_PDF([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Beta_PDF_Internal(a, b, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Beta.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_Beta_PDFLn([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Beta_PDFLn_Internal(a, b, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Beta.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Beta_CDF([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Beta_CDF_Internal(a, b, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Beta.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_Beta_InvCDF([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Beta_InvCDF_Internal(a, b, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Beta.Sample", Description=@"Generates a sample from the distribution.")]
        public static object Distributions_Beta_Sample([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Beta_Sample_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Beta.Samples", Description=@"Generates a sequence of samples from the distribution.")]
        public static object Distributions_Beta_Samples([ExcelArgument(Name = "a")] System.Double a, [ExcelArgument(Name = "b")] System.Double b)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Beta_Samples_Internal(a, b);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Binomial.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Binomial_IsValidParameterSet([ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "n")] System.Int32 n)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Binomial_IsValidParameterSet_Internal(p, n);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Binomial.PMF", Description=@"Computes the probability mass (PMF) at k, i.e. P(X = k).")]
        public static object Distributions_Binomial_PMF([ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Binomial_PMF_Internal(p, n, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Binomial.PMFLn", Description=@"Computes the log probability mass (lnPMF) at k, i.e. ln(P(X = k)).")]
        public static object Distributions_Binomial_PMFLn([ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Binomial_PMFLn_Internal(p, n, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Binomial.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Binomial_CDF([ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Binomial_CDF_Internal(p, n, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Binomial.Sample", Description=@"Samples a binomially distributed random variable.")]
        public static object Distributions_Binomial_Sample([ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "n")] System.Int32 n)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Binomial_Sample_Internal(p, n);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Binomial.Samples", Description=@"Samples a sequence of binomially distributed random variable.")]
        public static object Distributions_Binomial_Samples([ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "n")] System.Int32 n)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Binomial_Samples_Internal(p, n);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Categorical.IsValidProbabilityMass", Description=@"Checks whether the parameters of the distribution are valid.")]
        public static object Distributions_Categorical_IsValidProbabilityMass([ExcelArgument(Name = "p")] System.Double[] p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Categorical_IsValidProbabilityMass_Internal(p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Categorical.IsValidCumulativeDistribution", Description=@"Checks whether the parameters of the distribution are valid.")]
        public static object Distributions_Categorical_IsValidCumulativeDistribution([ExcelArgument(Name = "cdf")] System.Double[] cdf)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Categorical_IsValidCumulativeDistribution_Internal(cdf);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Categorical.PMF", Description=@"Computes the probability mass (PMF) at k, i.e. P(X = k).")]
        public static object Distributions_Categorical_PMF([ExcelArgument(Name = "probabilityMass")] System.Double[] probabilityMass, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Categorical_PMF_Internal(probabilityMass, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Categorical.PMFLn", Description=@"Computes the log probability mass (lnPMF) at k, i.e. ln(P(X = k)).")]
        public static object Distributions_Categorical_PMFLn([ExcelArgument(Name = "probabilityMass")] System.Double[] probabilityMass, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Categorical_PMFLn_Internal(probabilityMass, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Categorical.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Categorical_CDF([ExcelArgument(Name = "probabilityMass")] System.Double[] probabilityMass, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Categorical_CDF_Internal(probabilityMass, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Categorical.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability.")]
        public static object Distributions_Categorical_InvCDF([ExcelArgument(Name = "probabilityMass")] System.Double[] probabilityMass, [ExcelArgument(Name = "probability")] System.Double probability)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Categorical_InvCDF_Internal(probabilityMass, probability);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Categorical.InvCDFWithCumulativeDistribution", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability.")]
        public static object Distributions_Categorical_InvCDFWithCumulativeDistribution([ExcelArgument(Name = "cdfUnnormalized")] System.Double[] cdfUnnormalized, [ExcelArgument(Name = "probability")] System.Double probability)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Categorical_InvCDFWithCumulativeDistribution_Internal(cdfUnnormalized, probability);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Categorical.Sample", Description=@"Samples one categorical distributed random variable; also known as the Discrete distribution.")]
        public static object Distributions_Categorical_Sample([ExcelArgument(Name = "probabilityMass")] System.Double[] probabilityMass)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Categorical_Sample_Internal(probabilityMass);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Categorical.Samples", Description=@"Samples a categorically distributed random variable.")]
        public static object Distributions_Categorical_Samples([ExcelArgument(Name = "probabilityMass")] System.Double[] probabilityMass)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Categorical_Samples_Internal(probabilityMass);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Categorical.SampleWithCumulativeDistribution", Description=@"Samples one categorical distributed random variable; also known as the Discrete distribution.")]
        public static object Distributions_Categorical_SampleWithCumulativeDistribution([ExcelArgument(Name = "cdfUnnormalized")] System.Double[] cdfUnnormalized)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Categorical_SampleWithCumulativeDistribution_Internal(cdfUnnormalized);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Categorical.SamplesWithCumulativeDistribution", Description=@"Samples a categorically distributed random variable.")]
        public static object Distributions_Categorical_SamplesWithCumulativeDistribution([ExcelArgument(Name = "cdfUnnormalized")] System.Double[] cdfUnnormalized)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Categorical_SamplesWithCumulativeDistribution_Internal(cdfUnnormalized);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Cauchy.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Cauchy_IsValidParameterSet([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Cauchy_IsValidParameterSet_Internal(location, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Cauchy.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_Cauchy_PDF([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Cauchy_PDF_Internal(location, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Cauchy.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_Cauchy_PDFLn([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Cauchy_PDFLn_Internal(location, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Cauchy.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Cauchy_CDF([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Cauchy_CDF_Internal(location, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Cauchy.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_Cauchy_InvCDF([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Cauchy_InvCDF_Internal(location, scale, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Cauchy.Sample", Description=@"Generates a sample from the distribution.")]
        public static object Distributions_Cauchy_Sample([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Cauchy_Sample_Internal(location, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Cauchy.Samples", Description=@"Generates a sequence of samples from the distribution.")]
        public static object Distributions_Cauchy_Samples([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Cauchy_Samples_Internal(location, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Chi.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Chi_IsValidParameterSet([ExcelArgument(Name = "freedom")] System.Double freedom)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Chi_IsValidParameterSet_Internal(freedom);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Chi.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_Chi_PDF([ExcelArgument(Name = "freedom")] System.Double freedom, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Chi_PDF_Internal(freedom, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Chi.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_Chi_PDFLn([ExcelArgument(Name = "freedom")] System.Double freedom, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Chi_PDFLn_Internal(freedom, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Chi.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Chi_CDF([ExcelArgument(Name = "freedom")] System.Double freedom, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Chi_CDF_Internal(freedom, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Chi.Sample", Description=@"Generates a sample from the distribution.")]
        public static object Distributions_Chi_Sample([ExcelArgument(Name = "freedom")] System.Int32 freedom)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Chi_Sample_Internal(freedom);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Chi.Samples", Description=@"Generates a sequence of samples from the distribution.")]
        public static object Distributions_Chi_Samples([ExcelArgument(Name = "freedom")] System.Int32 freedom)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Chi_Samples_Internal(freedom);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ChiSquared.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_ChiSquared_IsValidParameterSet([ExcelArgument(Name = "freedom")] System.Double freedom)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ChiSquared_IsValidParameterSet_Internal(freedom);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ChiSquared.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_ChiSquared_PDF([ExcelArgument(Name = "freedom")] System.Double freedom, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ChiSquared_PDF_Internal(freedom, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ChiSquared.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_ChiSquared_PDFLn([ExcelArgument(Name = "freedom")] System.Double freedom, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ChiSquared_PDFLn_Internal(freedom, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ChiSquared.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_ChiSquared_CDF([ExcelArgument(Name = "freedom")] System.Double freedom, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ChiSquared_CDF_Internal(freedom, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ChiSquared.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_ChiSquared_InvCDF([ExcelArgument(Name = "freedom")] System.Double freedom, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ChiSquared_InvCDF_Internal(freedom, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ChiSquared.Sample", Description=@"Generates a sample from the ChiSquare distribution.")]
        public static object Distributions_ChiSquared_Sample([ExcelArgument(Name = "freedom")] System.Double freedom)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ChiSquared_Sample_Internal(freedom);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ChiSquared.Samples", Description=@"Generates a sequence of samples from the distribution.")]
        public static object Distributions_ChiSquared_Samples([ExcelArgument(Name = "freedom")] System.Double freedom)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ChiSquared_Samples_Internal(freedom);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ContinuousUniform.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_ContinuousUniform_IsValidParameterSet([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ContinuousUniform_IsValidParameterSet_Internal(lower, upper);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ContinuousUniform.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_ContinuousUniform_PDF([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ContinuousUniform_PDF_Internal(lower, upper, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ContinuousUniform.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_ContinuousUniform_PDFLn([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ContinuousUniform_PDFLn_Internal(lower, upper, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ContinuousUniform.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_ContinuousUniform_CDF([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ContinuousUniform_CDF_Internal(lower, upper, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ContinuousUniform.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_ContinuousUniform_InvCDF([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ContinuousUniform_InvCDF_Internal(lower, upper, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ContinuousUniform.Sample", Description=@"Generates a sample from the ContinuousUniform distribution.")]
        public static object Distributions_ContinuousUniform_Sample([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ContinuousUniform_Sample_Internal(lower, upper);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ContinuousUniform.Samples", Description=@"Generates a sequence of samples from the ContinuousUniform distribution.")]
        public static object Distributions_ContinuousUniform_Samples([ExcelArgument(Name = "lower")] System.Double lower, [ExcelArgument(Name = "upper")] System.Double upper)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ContinuousUniform_Samples_Internal(lower, upper);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ConwayMaxwellPoisson.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_ConwayMaxwellPoisson_IsValidParameterSet([ExcelArgument(Name = "lambda")] System.Double lambda, [ExcelArgument(Name = "nu")] System.Double nu)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ConwayMaxwellPoisson_IsValidParameterSet_Internal(lambda, nu);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ConwayMaxwellPoisson.PMF", Description=@"Computes the probability mass (PMF) at k, i.e. P(X = k).")]
        public static object Distributions_ConwayMaxwellPoisson_PMF([ExcelArgument(Name = "lambda")] System.Double lambda, [ExcelArgument(Name = "nu")] System.Double nu, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ConwayMaxwellPoisson_PMF_Internal(lambda, nu, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ConwayMaxwellPoisson.PMFLn", Description=@"Computes the log probability mass (lnPMF) at k, i.e. ln(P(X = k)).")]
        public static object Distributions_ConwayMaxwellPoisson_PMFLn([ExcelArgument(Name = "lambda")] System.Double lambda, [ExcelArgument(Name = "nu")] System.Double nu, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ConwayMaxwellPoisson_PMFLn_Internal(lambda, nu, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ConwayMaxwellPoisson.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_ConwayMaxwellPoisson_CDF([ExcelArgument(Name = "lambda")] System.Double lambda, [ExcelArgument(Name = "nu")] System.Double nu, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ConwayMaxwellPoisson_CDF_Internal(lambda, nu, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ConwayMaxwellPoisson.Sample", Description=@"Samples a random variable.")]
        public static object Distributions_ConwayMaxwellPoisson_Sample([ExcelArgument(Name = "lambda")] System.Double lambda, [ExcelArgument(Name = "nu")] System.Double nu)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ConwayMaxwellPoisson_Sample_Internal(lambda, nu);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.ConwayMaxwellPoisson.Samples", Description=@"Samples a sequence of this random variable.")]
        public static object Distributions_ConwayMaxwellPoisson_Samples([ExcelArgument(Name = "lambda")] System.Double lambda, [ExcelArgument(Name = "nu")] System.Double nu)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_ConwayMaxwellPoisson_Samples_Internal(lambda, nu);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Dirichlet.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.
        No parameter can be less than zero and at least one parameter should be larger than zero.")]
        public static object Distributions_Dirichlet_IsValidParameterSet([ExcelArgument(Name = "alpha")] System.Double[] alpha)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Dirichlet_IsValidParameterSet_Internal(alpha);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.DiscreteUniform.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_DiscreteUniform_IsValidParameterSet([ExcelArgument(Name = "lower")] System.Int32 lower, [ExcelArgument(Name = "upper")] System.Int32 upper)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_DiscreteUniform_IsValidParameterSet_Internal(lower, upper);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.DiscreteUniform.PMF", Description=@"Computes the probability mass (PMF) at k, i.e. P(X = k).")]
        public static object Distributions_DiscreteUniform_PMF([ExcelArgument(Name = "lower")] System.Int32 lower, [ExcelArgument(Name = "upper")] System.Int32 upper, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_DiscreteUniform_PMF_Internal(lower, upper, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.DiscreteUniform.PMFLn", Description=@"Computes the log probability mass (lnPMF) at k, i.e. ln(P(X = k)).")]
        public static object Distributions_DiscreteUniform_PMFLn([ExcelArgument(Name = "lower")] System.Int32 lower, [ExcelArgument(Name = "upper")] System.Int32 upper, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_DiscreteUniform_PMFLn_Internal(lower, upper, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.DiscreteUniform.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_DiscreteUniform_CDF([ExcelArgument(Name = "lower")] System.Int32 lower, [ExcelArgument(Name = "upper")] System.Int32 upper, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_DiscreteUniform_CDF_Internal(lower, upper, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.DiscreteUniform.Sample", Description=@"Samples a uniformly distributed random variable.")]
        public static object Distributions_DiscreteUniform_Sample([ExcelArgument(Name = "lower")] System.Int32 lower, [ExcelArgument(Name = "upper")] System.Int32 upper)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_DiscreteUniform_Sample_Internal(lower, upper);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.DiscreteUniform.Samples", Description=@"Samples a sequence of uniformly distributed random variables.")]
        public static object Distributions_DiscreteUniform_Samples([ExcelArgument(Name = "lower")] System.Int32 lower, [ExcelArgument(Name = "upper")] System.Int32 upper)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_DiscreteUniform_Samples_Internal(lower, upper);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Erlang.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Erlang_IsValidParameterSet([ExcelArgument(Name = "shape")] System.Int32 shape, [ExcelArgument(Name = "rate")] System.Double rate)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Erlang_IsValidParameterSet_Internal(shape, rate);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Erlang.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_Erlang_PDF([ExcelArgument(Name = "shape")] System.Int32 shape, [ExcelArgument(Name = "rate")] System.Double rate, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Erlang_PDF_Internal(shape, rate, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Erlang.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_Erlang_PDFLn([ExcelArgument(Name = "shape")] System.Int32 shape, [ExcelArgument(Name = "rate")] System.Double rate, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Erlang_PDFLn_Internal(shape, rate, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Erlang.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Erlang_CDF([ExcelArgument(Name = "shape")] System.Int32 shape, [ExcelArgument(Name = "rate")] System.Double rate, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Erlang_CDF_Internal(shape, rate, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Erlang.Sample", Description=@"Generates a sample from the distribution.")]
        public static object Distributions_Erlang_Sample([ExcelArgument(Name = "shape")] System.Int32 shape, [ExcelArgument(Name = "rate")] System.Double rate)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Erlang_Sample_Internal(shape, rate);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Erlang.Samples", Description=@"Generates a sequence of samples from the distribution.")]
        public static object Distributions_Erlang_Samples([ExcelArgument(Name = "shape")] System.Int32 shape, [ExcelArgument(Name = "rate")] System.Double rate)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Erlang_Samples_Internal(shape, rate);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Exponential.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Exponential_IsValidParameterSet([ExcelArgument(Name = "rate")] System.Double rate)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Exponential_IsValidParameterSet_Internal(rate);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Exponential.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_Exponential_PDF([ExcelArgument(Name = "rate")] System.Double rate, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Exponential_PDF_Internal(rate, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Exponential.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_Exponential_PDFLn([ExcelArgument(Name = "rate")] System.Double rate, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Exponential_PDFLn_Internal(rate, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Exponential.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Exponential_CDF([ExcelArgument(Name = "rate")] System.Double rate, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Exponential_CDF_Internal(rate, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Exponential.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_Exponential_InvCDF([ExcelArgument(Name = "rate")] System.Double rate, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Exponential_InvCDF_Internal(rate, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Exponential.Sample", Description=@"Draws a random sample from the distribution.")]
        public static object Distributions_Exponential_Sample([ExcelArgument(Name = "rate")] System.Double rate)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Exponential_Sample_Internal(rate);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Exponential.Samples", Description=@"Generates a sequence of samples from the Exponential distribution.")]
        public static object Distributions_Exponential_Samples([ExcelArgument(Name = "rate")] System.Double rate)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Exponential_Samples_Internal(rate);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.FisherSnedecor.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_FisherSnedecor_IsValidParameterSet([ExcelArgument(Name = "d1")] System.Double d1, [ExcelArgument(Name = "d2")] System.Double d2)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_FisherSnedecor_IsValidParameterSet_Internal(d1, d2);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.FisherSnedecor.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_FisherSnedecor_PDF([ExcelArgument(Name = "d1")] System.Double d1, [ExcelArgument(Name = "d2")] System.Double d2, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_FisherSnedecor_PDF_Internal(d1, d2, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.FisherSnedecor.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_FisherSnedecor_PDFLn([ExcelArgument(Name = "d1")] System.Double d1, [ExcelArgument(Name = "d2")] System.Double d2, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_FisherSnedecor_PDFLn_Internal(d1, d2, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.FisherSnedecor.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_FisherSnedecor_CDF([ExcelArgument(Name = "d1")] System.Double d1, [ExcelArgument(Name = "d2")] System.Double d2, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_FisherSnedecor_CDF_Internal(d1, d2, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.FisherSnedecor.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_FisherSnedecor_InvCDF([ExcelArgument(Name = "d1")] System.Double d1, [ExcelArgument(Name = "d2")] System.Double d2, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_FisherSnedecor_InvCDF_Internal(d1, d2, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.FisherSnedecor.Sample", Description=@"Generates a sample from the distribution.")]
        public static object Distributions_FisherSnedecor_Sample([ExcelArgument(Name = "d1")] System.Double d1, [ExcelArgument(Name = "d2")] System.Double d2)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_FisherSnedecor_Sample_Internal(d1, d2);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.FisherSnedecor.Samples", Description=@"Generates a sequence of samples from the distribution.")]
        public static object Distributions_FisherSnedecor_Samples([ExcelArgument(Name = "d1")] System.Double d1, [ExcelArgument(Name = "d2")] System.Double d2)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_FisherSnedecor_Samples_Internal(d1, d2);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Gamma.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Gamma_IsValidParameterSet([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "rate")] System.Double rate)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Gamma_IsValidParameterSet_Internal(shape, rate);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Gamma.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_Gamma_PDF([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "rate")] System.Double rate, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Gamma_PDF_Internal(shape, rate, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Gamma.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_Gamma_PDFLn([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "rate")] System.Double rate, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Gamma_PDFLn_Internal(shape, rate, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Gamma.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Gamma_CDF([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "rate")] System.Double rate, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Gamma_CDF_Internal(shape, rate, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Gamma.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_Gamma_InvCDF([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "rate")] System.Double rate, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Gamma_InvCDF_Internal(shape, rate, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Gamma.Sample", Description=@"Generates a sample from the Gamma distribution.")]
        public static object Distributions_Gamma_Sample([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "rate")] System.Double rate)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Gamma_Sample_Internal(shape, rate);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Gamma.Samples", Description=@"Generates a sequence of samples from the Gamma distribution.")]
        public static object Distributions_Gamma_Samples([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "rate")] System.Double rate)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Gamma_Samples_Internal(shape, rate);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Geometric.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Geometric_IsValidParameterSet([ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Geometric_IsValidParameterSet_Internal(p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Geometric.PMF", Description=@"Computes the probability mass (PMF) at k, i.e. P(X = k).")]
        public static object Distributions_Geometric_PMF([ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Geometric_PMF_Internal(p, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Geometric.PMFLn", Description=@"Computes the log probability mass (lnPMF) at k, i.e. ln(P(X = k)).")]
        public static object Distributions_Geometric_PMFLn([ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Geometric_PMFLn_Internal(p, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Geometric.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Geometric_CDF([ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Geometric_CDF_Internal(p, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Geometric.Sample", Description=@"Samples a random variable.")]
        public static object Distributions_Geometric_Sample([ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Geometric_Sample_Internal(p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Geometric.Samples", Description=@"Samples a sequence of this random variable.")]
        public static object Distributions_Geometric_Samples([ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Geometric_Samples_Internal(p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Hypergeometric.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Hypergeometric_IsValidParameterSet([ExcelArgument(Name = "population")] System.Int32 population, [ExcelArgument(Name = "success")] System.Int32 success, [ExcelArgument(Name = "draws")] System.Int32 draws)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Hypergeometric_IsValidParameterSet_Internal(population, success, draws);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Hypergeometric.PMF", Description=@"Computes the probability mass (PMF) at k, i.e. P(X = k).")]
        public static object Distributions_Hypergeometric_PMF([ExcelArgument(Name = "population")] System.Int32 population, [ExcelArgument(Name = "success")] System.Int32 success, [ExcelArgument(Name = "draws")] System.Int32 draws, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Hypergeometric_PMF_Internal(population, success, draws, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Hypergeometric.PMFLn", Description=@"Computes the log probability mass (lnPMF) at k, i.e. ln(P(X = k)).")]
        public static object Distributions_Hypergeometric_PMFLn([ExcelArgument(Name = "population")] System.Int32 population, [ExcelArgument(Name = "success")] System.Int32 success, [ExcelArgument(Name = "draws")] System.Int32 draws, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Hypergeometric_PMFLn_Internal(population, success, draws, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Hypergeometric.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Hypergeometric_CDF([ExcelArgument(Name = "population")] System.Int32 population, [ExcelArgument(Name = "success")] System.Int32 success, [ExcelArgument(Name = "draws")] System.Int32 draws, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Hypergeometric_CDF_Internal(population, success, draws, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Hypergeometric.Sample", Description=@"Samples a random variable.")]
        public static object Distributions_Hypergeometric_Sample([ExcelArgument(Name = "population")] System.Int32 population, [ExcelArgument(Name = "success")] System.Int32 success, [ExcelArgument(Name = "draws")] System.Int32 draws)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Hypergeometric_Sample_Internal(population, success, draws);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Hypergeometric.Samples", Description=@"Samples a sequence of this random variable.")]
        public static object Distributions_Hypergeometric_Samples([ExcelArgument(Name = "population")] System.Int32 population, [ExcelArgument(Name = "success")] System.Int32 success, [ExcelArgument(Name = "draws")] System.Int32 draws)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Hypergeometric_Samples_Internal(population, success, draws);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.InverseGamma.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_InverseGamma_IsValidParameterSet([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_InverseGamma_IsValidParameterSet_Internal(shape, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.InverseGamma.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_InverseGamma_PDF([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_InverseGamma_PDF_Internal(shape, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.InverseGamma.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_InverseGamma_PDFLn([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_InverseGamma_PDFLn_Internal(shape, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.InverseGamma.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_InverseGamma_CDF([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_InverseGamma_CDF_Internal(shape, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.InverseGamma.Sample", Description=@"Generates a sample from the distribution.")]
        public static object Distributions_InverseGamma_Sample([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_InverseGamma_Sample_Internal(shape, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.InverseGamma.Samples", Description=@"Generates a sequence of samples from the distribution.")]
        public static object Distributions_InverseGamma_Samples([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_InverseGamma_Samples_Internal(shape, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Laplace.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Laplace_IsValidParameterSet([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Laplace_IsValidParameterSet_Internal(location, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Laplace.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_Laplace_PDF([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Laplace_PDF_Internal(location, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Laplace.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_Laplace_PDFLn([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Laplace_PDFLn_Internal(location, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Laplace.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Laplace_CDF([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Laplace_CDF_Internal(location, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Laplace.Sample", Description=@"Generates a sample from the distribution.")]
        public static object Distributions_Laplace_Sample([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Laplace_Sample_Internal(location, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Laplace.Samples", Description=@"Generates a sequence of samples from the distribution.")]
        public static object Distributions_Laplace_Samples([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Laplace_Samples_Internal(location, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.LogNormal.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_LogNormal_IsValidParameterSet([ExcelArgument(Name = "mu")] System.Double mu, [ExcelArgument(Name = "sigma")] System.Double sigma)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_LogNormal_IsValidParameterSet_Internal(mu, sigma);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.LogNormal.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_LogNormal_PDF([ExcelArgument(Name = "mu")] System.Double mu, [ExcelArgument(Name = "sigma")] System.Double sigma, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_LogNormal_PDF_Internal(mu, sigma, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.LogNormal.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_LogNormal_PDFLn([ExcelArgument(Name = "mu")] System.Double mu, [ExcelArgument(Name = "sigma")] System.Double sigma, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_LogNormal_PDFLn_Internal(mu, sigma, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.LogNormal.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_LogNormal_CDF([ExcelArgument(Name = "mu")] System.Double mu, [ExcelArgument(Name = "sigma")] System.Double sigma, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_LogNormal_CDF_Internal(mu, sigma, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.LogNormal.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_LogNormal_InvCDF([ExcelArgument(Name = "mu")] System.Double mu, [ExcelArgument(Name = "sigma")] System.Double sigma, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_LogNormal_InvCDF_Internal(mu, sigma, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.LogNormal.Sample", Description=@"Generates a sample from the log-normal distribution using the Box-Muller algorithm.")]
        public static object Distributions_LogNormal_Sample([ExcelArgument(Name = "mu")] System.Double mu, [ExcelArgument(Name = "sigma")] System.Double sigma)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_LogNormal_Sample_Internal(mu, sigma);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.LogNormal.Samples", Description=@"Generates a sequence of samples from the log-normal distribution using the Box-Muller algorithm.")]
        public static object Distributions_LogNormal_Samples([ExcelArgument(Name = "mu")] System.Double mu, [ExcelArgument(Name = "sigma")] System.Double sigma)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_LogNormal_Samples_Internal(mu, sigma);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Multinomial.IsValidParameterSet")]
        public static object Distributions_Multinomial_IsValidParameterSet([ExcelArgument(Name = "p")] System.Collections.Generic.IEnumerable<System.Double> p, [ExcelArgument(Name = "n")] System.Int32 n)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Multinomial_IsValidParameterSet_Internal(p, n);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.NegativeBinomial.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_NegativeBinomial_IsValidParameterSet([ExcelArgument(Name = "r")] System.Double r, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_NegativeBinomial_IsValidParameterSet_Internal(r, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.NegativeBinomial.PMF", Description=@"Computes the probability mass (PMF) at k, i.e. P(X = k).")]
        public static object Distributions_NegativeBinomial_PMF([ExcelArgument(Name = "r")] System.Double r, [ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_NegativeBinomial_PMF_Internal(r, p, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.NegativeBinomial.PMFLn", Description=@"Computes the log probability mass (lnPMF) at k, i.e. ln(P(X = k)).")]
        public static object Distributions_NegativeBinomial_PMFLn([ExcelArgument(Name = "r")] System.Double r, [ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_NegativeBinomial_PMFLn_Internal(r, p, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.NegativeBinomial.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_NegativeBinomial_CDF([ExcelArgument(Name = "r")] System.Double r, [ExcelArgument(Name = "p")] System.Double p, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_NegativeBinomial_CDF_Internal(r, p, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.NegativeBinomial.Sample", Description=@"Samples a random variable.")]
        public static object Distributions_NegativeBinomial_Sample([ExcelArgument(Name = "r")] System.Double r, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_NegativeBinomial_Sample_Internal(r, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.NegativeBinomial.Samples", Description=@"Samples a sequence of this random variable.")]
        public static object Distributions_NegativeBinomial_Samples([ExcelArgument(Name = "r")] System.Double r, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_NegativeBinomial_Samples_Internal(r, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Normal.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Normal_IsValidParameterSet([ExcelArgument(Name = "mean")] System.Double mean, [ExcelArgument(Name = "stddev")] System.Double stddev)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Normal_IsValidParameterSet_Internal(mean, stddev);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Normal.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_Normal_PDF([ExcelArgument(Name = "mean")] System.Double mean, [ExcelArgument(Name = "stddev")] System.Double stddev, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Normal_PDF_Internal(mean, stddev, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Normal.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_Normal_PDFLn([ExcelArgument(Name = "mean")] System.Double mean, [ExcelArgument(Name = "stddev")] System.Double stddev, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Normal_PDFLn_Internal(mean, stddev, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Normal.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Normal_CDF([ExcelArgument(Name = "mean")] System.Double mean, [ExcelArgument(Name = "stddev")] System.Double stddev, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Normal_CDF_Internal(mean, stddev, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Normal.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_Normal_InvCDF([ExcelArgument(Name = "mean")] System.Double mean, [ExcelArgument(Name = "stddev")] System.Double stddev, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Normal_InvCDF_Internal(mean, stddev, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Normal.Sample", Description=@"Generates a sample from the normal distribution using the Box-Muller algorithm.")]
        public static object Distributions_Normal_Sample([ExcelArgument(Name = "mean")] System.Double mean, [ExcelArgument(Name = "stddev")] System.Double stddev)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Normal_Sample_Internal(mean, stddev);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Normal.Samples", Description=@"Generates a sequence of samples from the normal distribution using the Box-Muller algorithm.")]
        public static object Distributions_Normal_Samples([ExcelArgument(Name = "mean")] System.Double mean, [ExcelArgument(Name = "stddev")] System.Double stddev)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Normal_Samples_Internal(mean, stddev);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.NormalGamma.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_NormalGamma_IsValidParameterSet([ExcelArgument(Name = "meanLocation")] System.Double meanLocation, [ExcelArgument(Name = "meanScale")] System.Double meanScale, [ExcelArgument(Name = "precShape")] System.Double precShape, [ExcelArgument(Name = "precInvScale")] System.Double precInvScale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_NormalGamma_IsValidParameterSet_Internal(meanLocation, meanScale, precShape, precInvScale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Pareto.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Pareto_IsValidParameterSet([ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "shape")] System.Double shape)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Pareto_IsValidParameterSet_Internal(scale, shape);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Pareto.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_Pareto_PDF([ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Pareto_PDF_Internal(scale, shape, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Pareto.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_Pareto_PDFLn([ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Pareto_PDFLn_Internal(scale, shape, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Pareto.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Pareto_CDF([ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Pareto_CDF_Internal(scale, shape, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Pareto.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_Pareto_InvCDF([ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Pareto_InvCDF_Internal(scale, shape, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Pareto.Sample", Description=@"Generates a sample from the distribution.")]
        public static object Distributions_Pareto_Sample([ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "shape")] System.Double shape)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Pareto_Sample_Internal(scale, shape);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Pareto.Samples", Description=@"Generates a sequence of samples from the distribution.")]
        public static object Distributions_Pareto_Samples([ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "shape")] System.Double shape)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Pareto_Samples_Internal(scale, shape);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Poisson.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Poisson_IsValidParameterSet([ExcelArgument(Name = "lambda")] System.Double lambda)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Poisson_IsValidParameterSet_Internal(lambda);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Poisson.PMF", Description=@"Computes the probability mass (PMF) at k, i.e. P(X = k).")]
        public static object Distributions_Poisson_PMF([ExcelArgument(Name = "lambda")] System.Double lambda, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Poisson_PMF_Internal(lambda, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Poisson.PMFLn", Description=@"Computes the log probability mass (lnPMF) at k, i.e. ln(P(X = k)).")]
        public static object Distributions_Poisson_PMFLn([ExcelArgument(Name = "lambda")] System.Double lambda, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Poisson_PMFLn_Internal(lambda, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Poisson.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Poisson_CDF([ExcelArgument(Name = "lambda")] System.Double lambda, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Poisson_CDF_Internal(lambda, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Poisson.Sample", Description=@"Samples a Poisson distributed random variable.")]
        public static object Distributions_Poisson_Sample([ExcelArgument(Name = "lambda")] System.Double lambda)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Poisson_Sample_Internal(lambda);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Poisson.Samples", Description=@"Samples a sequence of Poisson distributed random variables.")]
        public static object Distributions_Poisson_Samples([ExcelArgument(Name = "lambda")] System.Double lambda)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Poisson_Samples_Internal(lambda);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Rayleigh.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Rayleigh_IsValidParameterSet([ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Rayleigh_IsValidParameterSet_Internal(scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Rayleigh.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_Rayleigh_PDF([ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Rayleigh_PDF_Internal(scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Rayleigh.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_Rayleigh_PDFLn([ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Rayleigh_PDFLn_Internal(scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Rayleigh.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Rayleigh_CDF([ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Rayleigh_CDF_Internal(scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Rayleigh.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_Rayleigh_InvCDF([ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Rayleigh_InvCDF_Internal(scale, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Rayleigh.Sample", Description=@"Generates a sample from the distribution.")]
        public static object Distributions_Rayleigh_Sample([ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Rayleigh_Sample_Internal(scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Rayleigh.Samples", Description=@"Generates a sequence of samples from the distribution.")]
        public static object Distributions_Rayleigh_Samples([ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Rayleigh_Samples_Internal(scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Stable.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Stable_IsValidParameterSet([ExcelArgument(Name = "alpha")] System.Double alpha, [ExcelArgument(Name = "beta")] System.Double beta, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "location")] System.Double location)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Stable_IsValidParameterSet_Internal(alpha, beta, scale, location);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Stable.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_Stable_PDF([ExcelArgument(Name = "alpha")] System.Double alpha, [ExcelArgument(Name = "beta")] System.Double beta, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Stable_PDF_Internal(alpha, beta, scale, location, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Stable.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_Stable_PDFLn([ExcelArgument(Name = "alpha")] System.Double alpha, [ExcelArgument(Name = "beta")] System.Double beta, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Stable_PDFLn_Internal(alpha, beta, scale, location, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Stable.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Stable_CDF([ExcelArgument(Name = "alpha")] System.Double alpha, [ExcelArgument(Name = "beta")] System.Double beta, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Stable_CDF_Internal(alpha, beta, scale, location, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Stable.Sample", Description=@"Generates a sample from the distribution.")]
        public static object Distributions_Stable_Sample([ExcelArgument(Name = "alpha")] System.Double alpha, [ExcelArgument(Name = "beta")] System.Double beta, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "location")] System.Double location)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Stable_Sample_Internal(alpha, beta, scale, location);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Stable.Samples", Description=@"Generates a sequence of samples from the distribution.")]
        public static object Distributions_Stable_Samples([ExcelArgument(Name = "alpha")] System.Double alpha, [ExcelArgument(Name = "beta")] System.Double beta, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "location")] System.Double location)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Stable_Samples_Internal(alpha, beta, scale, location);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.StudentT.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_StudentT_IsValidParameterSet([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "freedom")] System.Double freedom)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_StudentT_IsValidParameterSet_Internal(location, scale, freedom);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.StudentT.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_StudentT_PDF([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "freedom")] System.Double freedom, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_StudentT_PDF_Internal(location, scale, freedom, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.StudentT.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_StudentT_PDFLn([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "freedom")] System.Double freedom, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_StudentT_PDFLn_Internal(location, scale, freedom, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.StudentT.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_StudentT_CDF([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "freedom")] System.Double freedom, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_StudentT_CDF_Internal(location, scale, freedom, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.StudentT.InvCDF", Description=@"Computes the inverse of the cumulative distribution function (InvCDF) for the distribution
        at the given probability. This is also known as the quantile or percent point function.")]
        public static object Distributions_StudentT_InvCDF([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "freedom")] System.Double freedom, [ExcelArgument(Name = "p")] System.Double p)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_StudentT_InvCDF_Internal(location, scale, freedom, p);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.StudentT.Sample", Description=@"Generates a sample from the Student t-distribution.")]
        public static object Distributions_StudentT_Sample([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "freedom")] System.Double freedom)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_StudentT_Sample_Internal(location, scale, freedom);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.StudentT.Samples", Description=@"Generates a sequence of samples from the Student t-distribution using the Box-Muller algorithm.")]
        public static object Distributions_StudentT_Samples([ExcelArgument(Name = "location")] System.Double location, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "freedom")] System.Double freedom)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_StudentT_Samples_Internal(location, scale, freedom);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Weibull.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Weibull_IsValidParameterSet([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Weibull_IsValidParameterSet_Internal(shape, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Weibull.PDF", Description=@"Computes the probability density of the distribution (PDF) at x, i.e. ∂P(X ≤ x)/∂x.")]
        public static object Distributions_Weibull_PDF([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Weibull_PDF_Internal(shape, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Weibull.PDFLn", Description=@"Computes the log probability density of the distribution (lnPDF) at x, i.e. ln(∂P(X ≤ x)/∂x).")]
        public static object Distributions_Weibull_PDFLn([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Weibull_PDFLn_Internal(shape, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Weibull.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Weibull_CDF([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "scale")] System.Double scale, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Weibull_CDF_Internal(shape, scale, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Weibull.Sample", Description=@"Generates a sample from the Weibull distribution.")]
        public static object Distributions_Weibull_Sample([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Weibull_Sample_Internal(shape, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Weibull.Samples", Description=@"Generates a sequence of samples from the Weibull distribution.")]
        public static object Distributions_Weibull_Samples([ExcelArgument(Name = "shape")] System.Double shape, [ExcelArgument(Name = "scale")] System.Double scale)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Weibull_Samples_Internal(shape, scale);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Zipf.IsValidParameterSet", Description=@"Tests whether the provided values are valid parameters for this distribution.")]
        public static object Distributions_Zipf_IsValidParameterSet([ExcelArgument(Name = "s")] System.Double s, [ExcelArgument(Name = "n")] System.Int32 n)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Zipf_IsValidParameterSet_Internal(s, n);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Zipf.PMF", Description=@"Computes the probability mass (PMF) at k, i.e. P(X = k).")]
        public static object Distributions_Zipf_PMF([ExcelArgument(Name = "s")] System.Double s, [ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Zipf_PMF_Internal(s, n, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Zipf.PMFLn", Description=@"Computes the log probability mass (lnPMF) at k, i.e. ln(P(X = k)).")]
        public static object Distributions_Zipf_PMFLn([ExcelArgument(Name = "s")] System.Double s, [ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "k")] System.Int32 k)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Zipf_PMFLn_Internal(s, n, k);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Zipf.CDF", Description=@"Computes the cumulative distribution (CDF) of the distribution at x, i.e. P(X ≤ x).")]
        public static object Distributions_Zipf_CDF([ExcelArgument(Name = "s")] System.Double s, [ExcelArgument(Name = "n")] System.Int32 n, [ExcelArgument(Name = "x")] System.Double x)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Zipf_CDF_Internal(s, n, x);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Zipf.Sample", Description=@"Samples a random variable.")]
        public static object Distributions_Zipf_Sample([ExcelArgument(Name = "s")] System.Double s, [ExcelArgument(Name = "n")] System.Int32 n)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Zipf_Sample_Internal(s, n);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }

        [ExcelFunction(Name = "MN.Distributions.Zipf.Samples", Description=@"Samples a sequence of this random variable.")]
        public static object Distributions_Zipf_Samples([ExcelArgument(Name = "s")] System.Double s, [ExcelArgument(Name = "n")] System.Int32 n)
        {
            try
            {
                return math.net.xladdin.generated.Internal.Distributions_Zipf_Samples_Internal(s, n);
            }
            catch (Exception ex)
            {
                return Error.ExcelHandle(ex);
            }
        }
    }
}