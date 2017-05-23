namespace math.net.xladdin.generated
{
    using System;
    using System.Runtime.CompilerServices;

    internal static class Internal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Differentiation.NumericalDerivative Differentiate_Points_Internal(System.Int32 points, System.Int32 center)
        {
            return MathNet.Numerics.Differentiate.Points(points, center);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Differentiation.NumericalDerivative Differentiate_Order_Internal(System.Int32 order)
        {
            return MathNet.Numerics.Differentiate.Order(order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Differentiate_Derivative_Internal(System.Func<System.Double, System.Double> f, System.Double x, System.Int32 order)
        {
            return MathNet.Numerics.Differentiate.Derivative(f, x, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Differentiate_DerivativeFunc_Internal(System.Func<System.Double, System.Double> f, System.Int32 order)
        {
            return MathNet.Numerics.Differentiate.DerivativeFunc(f, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Differentiate_FirstDerivative_Internal(System.Func<System.Double, System.Double> f, System.Double x)
        {
            return MathNet.Numerics.Differentiate.FirstDerivative(f, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Differentiate_FirstDerivativeFunc_Internal(System.Func<System.Double, System.Double> f)
        {
            return MathNet.Numerics.Differentiate.FirstDerivativeFunc(f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Differentiate_SecondDerivative_Internal(System.Func<System.Double, System.Double> f, System.Double x)
        {
            return MathNet.Numerics.Differentiate.SecondDerivative(f, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Differentiate_SecondDerivativeFunc_Internal(System.Func<System.Double, System.Double> f)
        {
            return MathNet.Numerics.Differentiate.SecondDerivativeFunc(f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Differentiate_PartialDerivative_Internal(System.Func<System.Double[], System.Double> f, System.Double[] x, System.Int32 parameterIndex, System.Int32 order)
        {
            return MathNet.Numerics.Differentiate.PartialDerivative(f, x, parameterIndex, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double[], System.Double> Differentiate_PartialDerivativeFunc_Internal(System.Func<System.Double[], System.Double> f, System.Int32 parameterIndex, System.Int32 order)
        {
            return MathNet.Numerics.Differentiate.PartialDerivativeFunc(f, parameterIndex, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Differentiate_FirstPartialDerivative_Internal(System.Func<System.Double[], System.Double> f, System.Double[] x, System.Int32 parameterIndex)
        {
            return MathNet.Numerics.Differentiate.FirstPartialDerivative(f, x, parameterIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double[], System.Double> Differentiate_FirstPartialDerivativeFunc_Internal(System.Func<System.Double[], System.Double> f, System.Int32 parameterIndex)
        {
            return MathNet.Numerics.Differentiate.FirstPartialDerivativeFunc(f, parameterIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Differentiate_PartialDerivative2_Internal(System.Func<System.Double, System.Double, System.Double> f, System.Double x, System.Double y, System.Int32 parameterIndex, System.Int32 order)
        {
            return MathNet.Numerics.Differentiate.PartialDerivative2(f, x, y, parameterIndex, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double, System.Double> Differentiate_PartialDerivative2Func_Internal(System.Func<System.Double, System.Double, System.Double> f, System.Int32 parameterIndex, System.Int32 order)
        {
            return MathNet.Numerics.Differentiate.PartialDerivative2Func(f, parameterIndex, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Differentiate_FirstPartialDerivative2_Internal(System.Func<System.Double, System.Double, System.Double> f, System.Double x, System.Double y, System.Int32 parameterIndex)
        {
            return MathNet.Numerics.Differentiate.FirstPartialDerivative2(f, x, y, parameterIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double, System.Double> Differentiate_FirstPartialDerivative2Func_Internal(System.Func<System.Double, System.Double, System.Double> f, System.Int32 parameterIndex)
        {
            return MathNet.Numerics.Differentiate.FirstPartialDerivative2Func(f, parameterIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Euclid_Modulus_Internal(System.Double dividend, System.Double divisor)
        {
            return MathNet.Numerics.Euclid.Modulus(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Euclid_Modulus_Internal(System.Single dividend, System.Single divisor)
        {
            return MathNet.Numerics.Euclid.Modulus(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Euclid_Modulus_Internal(System.Int32 dividend, System.Int32 divisor)
        {
            return MathNet.Numerics.Euclid.Modulus(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int64 Euclid_Modulus_Internal(System.Int64 dividend, System.Int64 divisor)
        {
            return MathNet.Numerics.Euclid.Modulus(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.BigInteger Euclid_Modulus_Internal(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor)
        {
            return MathNet.Numerics.Euclid.Modulus(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Euclid_Remainder_Internal(System.Double dividend, System.Double divisor)
        {
            return MathNet.Numerics.Euclid.Remainder(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Euclid_Remainder_Internal(System.Single dividend, System.Single divisor)
        {
            return MathNet.Numerics.Euclid.Remainder(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Euclid_Remainder_Internal(System.Int32 dividend, System.Int32 divisor)
        {
            return MathNet.Numerics.Euclid.Remainder(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int64 Euclid_Remainder_Internal(System.Int64 dividend, System.Int64 divisor)
        {
            return MathNet.Numerics.Euclid.Remainder(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.BigInteger Euclid_Remainder_Internal(System.Numerics.BigInteger dividend, System.Numerics.BigInteger divisor)
        {
            return MathNet.Numerics.Euclid.Remainder(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Euclid_IsEven_Internal(System.Int32 number)
        {
            return MathNet.Numerics.Euclid.IsEven(number);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Euclid_IsEven_Internal(System.Int64 number)
        {
            return MathNet.Numerics.Euclid.IsEven(number);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Euclid_IsOdd_Internal(System.Int32 number)
        {
            return MathNet.Numerics.Euclid.IsOdd(number);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Euclid_IsOdd_Internal(System.Int64 number)
        {
            return MathNet.Numerics.Euclid.IsOdd(number);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Euclid_IsPowerOfTwo_Internal(System.Int32 number)
        {
            return MathNet.Numerics.Euclid.IsPowerOfTwo(number);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Euclid_IsPowerOfTwo_Internal(System.Int64 number)
        {
            return MathNet.Numerics.Euclid.IsPowerOfTwo(number);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Euclid_IsPerfectSquare_Internal(System.Int32 number)
        {
            return MathNet.Numerics.Euclid.IsPerfectSquare(number);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Euclid_IsPerfectSquare_Internal(System.Int64 number)
        {
            return MathNet.Numerics.Euclid.IsPerfectSquare(number);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Euclid_PowerOfTwo_Internal(System.Int32 exponent)
        {
            return MathNet.Numerics.Euclid.PowerOfTwo(exponent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int64 Euclid_PowerOfTwo_Internal(System.Int64 exponent)
        {
            return MathNet.Numerics.Euclid.PowerOfTwo(exponent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Euclid_Log2_Internal(System.Int32 number)
        {
            return MathNet.Numerics.Euclid.Log2(number);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Euclid_CeilingToPowerOfTwo_Internal(System.Int32 number)
        {
            return MathNet.Numerics.Euclid.CeilingToPowerOfTwo(number);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int64 Euclid_CeilingToPowerOfTwo_Internal(System.Int64 number)
        {
            return MathNet.Numerics.Euclid.CeilingToPowerOfTwo(number);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int64 Euclid_GreatestCommonDivisor_2_Internal(System.Int64 a, System.Int64 b)
        {
            return MathNet.Numerics.Euclid.GreatestCommonDivisor(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int64 Euclid_GreatestCommonDivisor_Internal(System.Collections.Generic.IList<System.Int64> integers)
        {
            return MathNet.Numerics.Euclid.GreatestCommonDivisor(integers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int64 Euclid_GreatestCommonDivisor_1_Internal(System.Int64[] integers)
        {
            return MathNet.Numerics.Euclid.GreatestCommonDivisor(integers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int64 Euclid_ExtendedGreatestCommonDivisor_Internal(System.Int64 a, System.Int64 b, out System.Int64 x, out System.Int64 y)
        {
            return MathNet.Numerics.Euclid.ExtendedGreatestCommonDivisor(a, b,  out x,  out y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int64 Euclid_LeastCommonMultiple_2_Internal(System.Int64 a, System.Int64 b)
        {
            return MathNet.Numerics.Euclid.LeastCommonMultiple(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int64 Euclid_LeastCommonMultiple_Internal(System.Collections.Generic.IList<System.Int64> integers)
        {
            return MathNet.Numerics.Euclid.LeastCommonMultiple(integers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int64 Euclid_LeastCommonMultiple_1_Internal(System.Int64[] integers)
        {
            return MathNet.Numerics.Euclid.LeastCommonMultiple(integers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.BigInteger Euclid_GreatestCommonDivisor_Internal(System.Numerics.BigInteger a, System.Numerics.BigInteger b)
        {
            return MathNet.Numerics.Euclid.GreatestCommonDivisor(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.BigInteger Euclid_GreatestCommonDivisor_Internal(System.Collections.Generic.IList<System.Numerics.BigInteger> integers)
        {
            return MathNet.Numerics.Euclid.GreatestCommonDivisor(integers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.BigInteger Euclid_GreatestCommonDivisor_Internal(System.Numerics.BigInteger[] integers)
        {
            return MathNet.Numerics.Euclid.GreatestCommonDivisor(integers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.BigInteger Euclid_ExtendedGreatestCommonDivisor_Internal(System.Numerics.BigInteger a, System.Numerics.BigInteger b, out System.Numerics.BigInteger x, out System.Numerics.BigInteger y)
        {
            return MathNet.Numerics.Euclid.ExtendedGreatestCommonDivisor(a, b,  out x,  out y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.BigInteger Euclid_LeastCommonMultiple_Internal(System.Numerics.BigInteger a, System.Numerics.BigInteger b)
        {
            return MathNet.Numerics.Euclid.LeastCommonMultiple(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.BigInteger Euclid_LeastCommonMultiple_Internal(System.Collections.Generic.IList<System.Numerics.BigInteger> integers)
        {
            return MathNet.Numerics.Euclid.LeastCommonMultiple(integers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.BigInteger Euclid_LeastCommonMultiple_Internal(System.Numerics.BigInteger[] integers)
        {
            return MathNet.Numerics.Euclid.LeastCommonMultiple(integers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_LinearSpaced_Internal(System.Int32 length, System.Double start, System.Double stop)
        {
            return MathNet.Numerics.Generate.LinearSpaced(length, start, stop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_LogSpaced_Internal(System.Int32 length, System.Double startExponent, System.Double stopExponent)
        {
            return MathNet.Numerics.Generate.LogSpaced(length, startExponent, stopExponent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_LinearRange_2_Internal(System.Int32 start, System.Int32 stop)
        {
            return MathNet.Numerics.Generate.LinearRange(start, stop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32[] Generate_LinearRangeInt32_2_Internal(System.Int32 start, System.Int32 stop)
        {
            return MathNet.Numerics.Generate.LinearRangeInt32(start, stop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_LinearRange_3_Internal(System.Int32 start, System.Int32 step, System.Int32 stop)
        {
            return MathNet.Numerics.Generate.LinearRange(start, step, stop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32[] Generate_LinearRangeInt32_3_Internal(System.Int32 start, System.Int32 step, System.Int32 stop)
        {
            return MathNet.Numerics.Generate.LinearRangeInt32(start, step, stop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_LinearRange_Internal(System.Double start, System.Double step, System.Double stop)
        {
            return MathNet.Numerics.Generate.LinearRange(start, step, stop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_Periodic_Internal(System.Int32 length, System.Double samplingRate, System.Double frequency, System.Double amplitude, System.Double phase, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.Periodic(length, samplingRate, frequency, amplitude, phase, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_PeriodicSequence_Internal(System.Double samplingRate, System.Double frequency, System.Double amplitude, System.Double phase, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.PeriodicSequence(samplingRate, frequency, amplitude, phase, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_Sinusoidal_Internal(System.Int32 length, System.Double samplingRate, System.Double frequency, System.Double amplitude, System.Double mean, System.Double phase, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.Sinusoidal(length, samplingRate, frequency, amplitude, mean, phase, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_SinusoidalSequence_Internal(System.Double samplingRate, System.Double frequency, System.Double amplitude, System.Double mean, System.Double phase, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.SinusoidalSequence(samplingRate, frequency, amplitude, mean, phase, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_Square_Internal(System.Int32 length, System.Int32 highDuration, System.Int32 lowDuration, System.Double lowValue, System.Double highValue, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.Square(length, highDuration, lowDuration, lowValue, highValue, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_SquareSequence_Internal(System.Int32 highDuration, System.Int32 lowDuration, System.Double lowValue, System.Double highValue, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.SquareSequence(highDuration, lowDuration, lowValue, highValue, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_Triangle_Internal(System.Int32 length, System.Int32 raiseDuration, System.Int32 fallDuration, System.Double lowValue, System.Double highValue, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.Triangle(length, raiseDuration, fallDuration, lowValue, highValue, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_TriangleSequence_Internal(System.Int32 raiseDuration, System.Int32 fallDuration, System.Double lowValue, System.Double highValue, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.TriangleSequence(raiseDuration, fallDuration, lowValue, highValue, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_Sawtooth_Internal(System.Int32 length, System.Int32 period, System.Double lowValue, System.Double highValue, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.Sawtooth(length, period, lowValue, highValue, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_SawtoothSequence_Internal(System.Int32 period, System.Double lowValue, System.Double highValue, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.SawtoothSequence(period, lowValue, highValue, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_Step_Internal(System.Int32 length, System.Double amplitude, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.Step(length, amplitude, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_StepSequence_Internal(System.Double amplitude, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.StepSequence(amplitude, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_Impulse_Internal(System.Int32 length, System.Double amplitude, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.Impulse(length, amplitude, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_ImpulseSequence_Internal(System.Double amplitude, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.ImpulseSequence(amplitude, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_PeriodicImpulse_Internal(System.Int32 length, System.Int32 period, System.Double amplitude, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.PeriodicImpulse(length, period, amplitude, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_PeriodicImpulseSequence_Internal(System.Int32 period, System.Double amplitude, System.Int32 delay)
        {
            return MathNet.Numerics.Generate.PeriodicImpulseSequence(period, amplitude, delay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.BigInteger[] Generate_Fibonacci_Internal(System.Int32 length)
        {
            return MathNet.Numerics.Generate.Fibonacci(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Numerics.BigInteger> Generate_FibonacciSequence_Internal()
        {
            return MathNet.Numerics.Generate.FibonacciSequence();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_Uniform_Internal(System.Int32 length)
        {
            return MathNet.Numerics.Generate.Uniform(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_UniformSequence_Internal()
        {
            return MathNet.Numerics.Generate.UniformSequence();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_Standard_Internal(System.Int32 length)
        {
            return MathNet.Numerics.Generate.Standard(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_StandardSequence_Internal()
        {
            return MathNet.Numerics.Generate.StandardSequence();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_Normal_Internal(System.Int32 length, System.Double mean, System.Double standardDeviation)
        {
            return MathNet.Numerics.Generate.Normal(length, mean, standardDeviation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_NormalSequence_Internal(System.Double mean, System.Double standardDeviation)
        {
            return MathNet.Numerics.Generate.NormalSequence(mean, standardDeviation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_Gaussian_Internal(System.Int32 length, System.Double mean, System.Double standardDeviation)
        {
            return MathNet.Numerics.Generate.Gaussian(length, mean, standardDeviation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_GaussianSequence_Internal(System.Double mean, System.Double standardDeviation)
        {
            return MathNet.Numerics.Generate.GaussianSequence(mean, standardDeviation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_Stable_Internal(System.Int32 length, System.Double alpha, System.Double beta, System.Double scale, System.Double location)
        {
            return MathNet.Numerics.Generate.Stable(length, alpha, beta, scale, location);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_StableSequence_Internal(System.Double alpha, System.Double beta, System.Double scale, System.Double location)
        {
            return MathNet.Numerics.Generate.StableSequence(alpha, beta, scale, location);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Generate_Random_Internal(System.Int32 length, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.Generate.Random(length, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Generate_Random_Internal(MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.Generate.Random(distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single[] Generate_RandomSingle_Internal(System.Int32 length, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.Generate.RandomSingle(length, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Single> Generate_RandomSingle_Internal(MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.Generate.RandomSingle(distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex[] Generate_RandomComplex_Internal(System.Int32 length, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.Generate.RandomComplex(length, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Numerics.Complex> Generate_RandomComplex_Internal(MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.Generate.RandomComplex(distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32[] Generate_RandomComplex32_Internal(System.Int32 length, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.Generate.RandomComplex32(length, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32> Generate_RandomComplex32_Internal(MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.Generate.RandomComplex32(distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double GoodnessOfFit_RSquared_Internal(System.Collections.Generic.IEnumerable<System.Double> modelledValues, System.Collections.Generic.IEnumerable<System.Double> observedValues)
        {
            return MathNet.Numerics.GoodnessOfFit.RSquared(modelledValues, observedValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double GoodnessOfFit_R_Internal(System.Collections.Generic.IEnumerable<System.Double> modelledValues, System.Collections.Generic.IEnumerable<System.Double> observedValues)
        {
            return MathNet.Numerics.GoodnessOfFit.R(modelledValues, observedValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double GoodnessOfFit_PopulationStandardError_Internal(System.Collections.Generic.IEnumerable<System.Double> modelledValues, System.Collections.Generic.IEnumerable<System.Double> observedValues)
        {
            return MathNet.Numerics.GoodnessOfFit.PopulationStandardError(modelledValues, observedValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double GoodnessOfFit_StandardError_Internal(System.Collections.Generic.IEnumerable<System.Double> modelledValues, System.Collections.Generic.IEnumerable<System.Double> observedValues, System.Int32 degreesOfFreedom)
        {
            return MathNet.Numerics.GoodnessOfFit.StandardError(modelledValues, observedValues, degreesOfFreedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Precision_Magnitude_Internal(System.Double value)
        {
            return MathNet.Numerics.Precision.Magnitude(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Precision_Magnitude_Internal(System.Single value)
        {
            return MathNet.Numerics.Precision.Magnitude(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Precision_ScaleUnitMagnitude_Internal(System.Double value)
        {
            return MathNet.Numerics.Precision.ScaleUnitMagnitude(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Precision_Increment_Internal(System.Double value, System.Int32 count)
        {
            return MathNet.Numerics.Precision.Increment(value, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Precision_Decrement_Internal(System.Double value, System.Int32 count)
        {
            return MathNet.Numerics.Precision.Decrement(value, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Precision_CoerceZero_2_Internal(System.Double a, System.Int32 maxNumbersBetween)
        {
            return MathNet.Numerics.Precision.CoerceZero(a, maxNumbersBetween);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Precision_CoerceZero_Internal(System.Double a, System.Int64 maxNumbersBetween)
        {
            return MathNet.Numerics.Precision.CoerceZero(a, maxNumbersBetween);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Precision_CoerceZero_Internal(System.Double a, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.CoerceZero(a, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Precision_CoerceZero_1_Internal(System.Double a)
        {
            return MathNet.Numerics.Precision.CoerceZero(a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Precision_RangeOfMatchingFloatingPointNumbers_Internal(System.Double value, System.Int64 maxNumbersBetween)
        {
            return MathNet.Numerics.Precision.RangeOfMatchingFloatingPointNumbers(value, maxNumbersBetween);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Precision_MaximumMatchingFloatingPointNumber_Internal(System.Double value, System.Int64 maxNumbersBetween)
        {
            return MathNet.Numerics.Precision.MaximumMatchingFloatingPointNumber(value, maxNumbersBetween);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Precision_MinimumMatchingFloatingPointNumber_Internal(System.Double value, System.Int64 maxNumbersBetween)
        {
            return MathNet.Numerics.Precision.MinimumMatchingFloatingPointNumber(value, maxNumbersBetween);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Int64, System.Int64> Precision_RangeOfMatchingNumbers_Internal(System.Double value, System.Double relativeDifference)
        {
            return MathNet.Numerics.Precision.RangeOfMatchingNumbers(value, relativeDifference);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.UInt64 Precision_NumbersBetween_Internal(System.Double a, System.Double b)
        {
            return MathNet.Numerics.Precision.NumbersBetween(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Precision_EpsilonOf_Internal(System.Double value)
        {
            return MathNet.Numerics.Precision.EpsilonOf(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Precision_EpsilonOf_Internal(System.Single value)
        {
            return MathNet.Numerics.Precision.EpsilonOf(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Precision_PositiveEpsilonOf_Internal(System.Double value)
        {
            return MathNet.Numerics.Precision.PositiveEpsilonOf(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Precision_PositiveEpsilonOf_Internal(System.Single value)
        {
            return MathNet.Numerics.Precision.PositiveEpsilonOf(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Precision_CompareTo_Internal(System.Double a, System.Double b, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.CompareTo(a, b, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Precision_CompareTo_Internal(System.Double a, System.Double b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.CompareTo(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Precision_CompareToRelative_Internal(System.Double a, System.Double b, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.CompareToRelative(a, b, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Precision_CompareToRelative_Internal(System.Double a, System.Double b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.CompareToRelative(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Precision_CompareToNumbersBetween_Internal(System.Double a, System.Double b, System.Int64 maxNumbersBetween)
        {
            return MathNet.Numerics.Precision.CompareToNumbersBetween(a, b, maxNumbersBetween);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsLarger_Internal(System.Double a, System.Double b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.IsLarger(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsLarger_Internal(System.Single a, System.Single b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.IsLarger(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsLarger_Internal(System.Double a, System.Double b, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.IsLarger(a, b, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsLarger_Internal(System.Single a, System.Single b, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.IsLarger(a, b, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsLargerRelative_Internal(System.Double a, System.Double b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.IsLargerRelative(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsLargerRelative_Internal(System.Single a, System.Single b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.IsLargerRelative(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsLargerRelative_Internal(System.Double a, System.Double b, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.IsLargerRelative(a, b, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsLargerRelative_Internal(System.Single a, System.Single b, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.IsLargerRelative(a, b, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsLargerNumbersBetween_Internal(System.Double a, System.Double b, System.Int64 maxNumbersBetween)
        {
            return MathNet.Numerics.Precision.IsLargerNumbersBetween(a, b, maxNumbersBetween);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsLargerNumbersBetween_Internal(System.Single a, System.Single b, System.Int64 maxNumbersBetween)
        {
            return MathNet.Numerics.Precision.IsLargerNumbersBetween(a, b, maxNumbersBetween);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsSmaller_Internal(System.Double a, System.Double b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.IsSmaller(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsSmaller_Internal(System.Single a, System.Single b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.IsSmaller(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsSmaller_Internal(System.Double a, System.Double b, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.IsSmaller(a, b, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsSmaller_Internal(System.Single a, System.Single b, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.IsSmaller(a, b, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsSmallerRelative_Internal(System.Double a, System.Double b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.IsSmallerRelative(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsSmallerRelative_Internal(System.Single a, System.Single b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.IsSmallerRelative(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsSmallerRelative_Internal(System.Double a, System.Double b, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.IsSmallerRelative(a, b, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsSmallerRelative_Internal(System.Single a, System.Single b, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.IsSmallerRelative(a, b, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsSmallerNumbersBetween_Internal(System.Double a, System.Double b, System.Int64 maxNumbersBetween)
        {
            return MathNet.Numerics.Precision.IsSmallerNumbersBetween(a, b, maxNumbersBetween);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_IsSmallerNumbersBetween_Internal(System.Single a, System.Single b, System.Int64 maxNumbersBetween)
        {
            return MathNet.Numerics.Precision.IsSmallerNumbersBetween(a, b, maxNumbersBetween);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualNorm_Internal(System.Double a, System.Double b, System.Double diff, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.AlmostEqualNorm(a, b, diff, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualNormRelative_Internal(System.Double a, System.Double b, System.Double diff, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.AlmostEqualNormRelative(a, b, diff, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqual_3_Internal(System.Double a, System.Double b, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.AlmostEqual(a, b, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqual_Internal(System.Single a, System.Single b, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.AlmostEqual(a, b, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqual_Internal(System.Numerics.Complex a, System.Numerics.Complex b, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.AlmostEqual(a, b, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqual_Internal(MathNet.Numerics.Complex32 a, MathNet.Numerics.Complex32 b, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.AlmostEqual(a, b, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualRelative_3_Internal(System.Double a, System.Double b, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.AlmostEqualRelative(a, b, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualRelative_Internal(System.Single a, System.Single b, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.AlmostEqualRelative(a, b, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualRelative_Internal(System.Numerics.Complex a, System.Numerics.Complex b, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.AlmostEqualRelative(a, b, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualRelative_Internal(MathNet.Numerics.Complex32 a, MathNet.Numerics.Complex32 b, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.AlmostEqualRelative(a, b, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqual_2_Internal(System.Double a, System.Double b)
        {
            return MathNet.Numerics.Precision.AlmostEqual(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqual_Internal(System.Single a, System.Single b)
        {
            return MathNet.Numerics.Precision.AlmostEqual(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqual_Internal(System.Numerics.Complex a, System.Numerics.Complex b)
        {
            return MathNet.Numerics.Precision.AlmostEqual(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqual_Internal(MathNet.Numerics.Complex32 a, MathNet.Numerics.Complex32 b)
        {
            return MathNet.Numerics.Precision.AlmostEqual(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualRelative_2_Internal(System.Double a, System.Double b)
        {
            return MathNet.Numerics.Precision.AlmostEqualRelative(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualRelative_Internal(System.Single a, System.Single b)
        {
            return MathNet.Numerics.Precision.AlmostEqualRelative(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualRelative_Internal(System.Numerics.Complex a, System.Numerics.Complex b)
        {
            return MathNet.Numerics.Precision.AlmostEqualRelative(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualRelative_Internal(MathNet.Numerics.Complex32 a, MathNet.Numerics.Complex32 b)
        {
            return MathNet.Numerics.Precision.AlmostEqualRelative(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualNorm_Internal(System.Double a, System.Double b, System.Double diff, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.AlmostEqualNorm(a, b, diff, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualNormRelative_Internal(System.Double a, System.Double b, System.Double diff, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.AlmostEqualNormRelative(a, b, diff, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqual_Internal(System.Double a, System.Double b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.AlmostEqual(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqual_Internal(System.Single a, System.Single b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.AlmostEqual(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqual_Internal(System.Numerics.Complex a, System.Numerics.Complex b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.AlmostEqual(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqual_Internal(MathNet.Numerics.Complex32 a, MathNet.Numerics.Complex32 b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.AlmostEqual(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualRelative_Internal(System.Double a, System.Double b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.AlmostEqualRelative(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualRelative_Internal(System.Single a, System.Single b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.AlmostEqualRelative(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualRelative_Internal(System.Numerics.Complex a, System.Numerics.Complex b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.AlmostEqualRelative(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualRelative_Internal(MathNet.Numerics.Complex32 a, MathNet.Numerics.Complex32 b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.AlmostEqualRelative(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualNumbersBetween_Internal(System.Double a, System.Double b, System.Int64 maxNumbersBetween)
        {
            return MathNet.Numerics.Precision.AlmostEqualNumbersBetween(a, b, maxNumbersBetween);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_AlmostEqualNumbersBetween_Internal(System.Single a, System.Single b, System.Int32 maxNumbersBetween)
        {
            return MathNet.Numerics.Precision.AlmostEqualNumbersBetween(a, b, maxNumbersBetween);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqual_Internal(System.Collections.Generic.IList<System.Double> a, System.Collections.Generic.IList<System.Double> b, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.ListAlmostEqual(a, b, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqual_Internal(System.Collections.Generic.IList<System.Single> a, System.Collections.Generic.IList<System.Single> b, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.ListAlmostEqual(a, b, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqual_Internal(System.Collections.Generic.IList<System.Numerics.Complex> a, System.Collections.Generic.IList<System.Numerics.Complex> b, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.ListAlmostEqual(a, b, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqual_Internal(System.Collections.Generic.IList<MathNet.Numerics.Complex32> a, System.Collections.Generic.IList<MathNet.Numerics.Complex32> b, System.Double maximumAbsoluteError)
        {
            return MathNet.Numerics.Precision.ListAlmostEqual(a, b, maximumAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqualRelative_Internal(System.Collections.Generic.IList<System.Double> a, System.Collections.Generic.IList<System.Double> b, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.ListAlmostEqualRelative(a, b, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqualRelative_Internal(System.Collections.Generic.IList<System.Single> a, System.Collections.Generic.IList<System.Single> b, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.ListAlmostEqualRelative(a, b, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqualRelative_Internal(System.Collections.Generic.IList<System.Numerics.Complex> a, System.Collections.Generic.IList<System.Numerics.Complex> b, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.ListAlmostEqualRelative(a, b, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqualRelative_Internal(System.Collections.Generic.IList<MathNet.Numerics.Complex32> a, System.Collections.Generic.IList<MathNet.Numerics.Complex32> b, System.Double maximumError)
        {
            return MathNet.Numerics.Precision.ListAlmostEqualRelative(a, b, maximumError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqual_Internal(System.Collections.Generic.IList<System.Double> a, System.Collections.Generic.IList<System.Double> b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.ListAlmostEqual(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqual_Internal(System.Collections.Generic.IList<System.Single> a, System.Collections.Generic.IList<System.Single> b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.ListAlmostEqual(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqual_Internal(System.Collections.Generic.IList<System.Numerics.Complex> a, System.Collections.Generic.IList<System.Numerics.Complex> b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.ListAlmostEqual(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqual_Internal(System.Collections.Generic.IList<MathNet.Numerics.Complex32> a, System.Collections.Generic.IList<MathNet.Numerics.Complex32> b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.ListAlmostEqual(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqualRelative_Internal(System.Collections.Generic.IList<System.Double> a, System.Collections.Generic.IList<System.Double> b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.ListAlmostEqualRelative(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqualRelative_Internal(System.Collections.Generic.IList<System.Single> a, System.Collections.Generic.IList<System.Single> b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.ListAlmostEqualRelative(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqualRelative_Internal(System.Collections.Generic.IList<System.Numerics.Complex> a, System.Collections.Generic.IList<System.Numerics.Complex> b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.ListAlmostEqualRelative(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Precision_ListAlmostEqualRelative_Internal(System.Collections.Generic.IList<MathNet.Numerics.Complex32> a, System.Collections.Generic.IList<MathNet.Numerics.Complex32> b, System.Int32 decimalPlaces)
        {
            return MathNet.Numerics.Precision.ListAlmostEqualRelative(a, b, decimalPlaces);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Combinatorics_Variations_Internal(System.Int32 n, System.Int32 k)
        {
            return MathNet.Numerics.Combinatorics.Variations(n, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Combinatorics_VariationsWithRepetition_Internal(System.Int32 n, System.Int32 k)
        {
            return MathNet.Numerics.Combinatorics.VariationsWithRepetition(n, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Combinatorics_Combinations_Internal(System.Int32 n, System.Int32 k)
        {
            return MathNet.Numerics.Combinatorics.Combinations(n, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Combinatorics_CombinationsWithRepetition_Internal(System.Int32 n, System.Int32 k)
        {
            return MathNet.Numerics.Combinatorics.CombinationsWithRepetition(n, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Combinatorics_Permutations_Internal(System.Int32 n)
        {
            return MathNet.Numerics.Combinatorics.Permutations(n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32[] Combinatorics_GeneratePermutation_Internal(System.Int32 n, System.Random randomSource)
        {
            return MathNet.Numerics.Combinatorics.GeneratePermutation(n, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean[] Combinatorics_GenerateCombination_Internal(System.Int32 n, System.Random randomSource)
        {
            return MathNet.Numerics.Combinatorics.GenerateCombination(n, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean[] Combinatorics_GenerateCombination_Internal(System.Int32 n, System.Int32 k, System.Random randomSource)
        {
            return MathNet.Numerics.Combinatorics.GenerateCombination(n, k, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32[] Combinatorics_GenerateCombinationWithRepetition_Internal(System.Int32 n, System.Int32 k, System.Random randomSource)
        {
            return MathNet.Numerics.Combinatorics.GenerateCombinationWithRepetition(n, k, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32[] Combinatorics_GenerateVariation_Internal(System.Int32 n, System.Int32 k, System.Random randomSource)
        {
            return MathNet.Numerics.Combinatorics.GenerateVariation(n, k, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32[] Combinatorics_GenerateVariationWithRepetition_Internal(System.Int32 n, System.Int32 k, System.Random randomSource)
        {
            return MathNet.Numerics.Combinatorics.GenerateVariationWithRepetition(n, k, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ComplexExtensions_MagnitudeSquared_Internal(MathNet.Numerics.Complex32 complex)
        {
            return MathNet.Numerics.ComplexExtensions.MagnitudeSquared(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ComplexExtensions_MagnitudeSquared_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.MagnitudeSquared(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex ComplexExtensions_Sign_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.Sign(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex ComplexExtensions_Conjugate_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.Conjugate(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex ComplexExtensions_Reciprocal_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.Reciprocal(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex ComplexExtensions_Exp_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.Exp(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex ComplexExtensions_Ln_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.Ln(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex ComplexExtensions_Log10_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.Log10(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex ComplexExtensions_Log_Internal(System.Numerics.Complex complex, System.Double baseValue)
        {
            return MathNet.Numerics.ComplexExtensions.Log(complex, baseValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex ComplexExtensions_Power_Internal(System.Numerics.Complex complex, System.Numerics.Complex exponent)
        {
            return MathNet.Numerics.ComplexExtensions.Power(complex, exponent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex ComplexExtensions_Root_Internal(System.Numerics.Complex complex, System.Numerics.Complex rootExponent)
        {
            return MathNet.Numerics.ComplexExtensions.Root(complex, rootExponent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex ComplexExtensions_Square_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.Square(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex ComplexExtensions_SquareRoot_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.SquareRoot(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Numerics.Complex, System.Numerics.Complex> ComplexExtensions_SquareRoots_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.SquareRoots(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Numerics.Complex, System.Numerics.Complex, System.Numerics.Complex> ComplexExtensions_CubicRoots_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.CubicRoots(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean ComplexExtensions_IsZero_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.IsZero(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean ComplexExtensions_IsOne_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.IsOne(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean ComplexExtensions_IsImaginaryOne_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.IsImaginaryOne(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean ComplexExtensions_IsNaN_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.IsNaN(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean ComplexExtensions_IsInfinity_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.IsInfinity(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean ComplexExtensions_IsReal_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.IsReal(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean ComplexExtensions_IsRealNonNegative_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.IsRealNonNegative(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ComplexExtensions_Norm_Internal(System.Numerics.Complex complex)
        {
            return MathNet.Numerics.ComplexExtensions.Norm(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ComplexExtensions_Norm_Internal(MathNet.Numerics.Complex32 complex)
        {
            return MathNet.Numerics.ComplexExtensions.Norm(complex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ComplexExtensions_NormOfDifference_Internal(System.Numerics.Complex complex, System.Numerics.Complex otherValue)
        {
            return MathNet.Numerics.ComplexExtensions.NormOfDifference(complex, otherValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ComplexExtensions_NormOfDifference_Internal(MathNet.Numerics.Complex32 complex, MathNet.Numerics.Complex32 otherValue)
        {
            return MathNet.Numerics.ComplexExtensions.NormOfDifference(complex, otherValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex ComplexExtensions_ToComplex_Internal(System.String value)
        {
            return MathNet.Numerics.ComplexExtensions.ToComplex(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex ComplexExtensions_ToComplex_Internal(System.String value, System.IFormatProvider formatProvider)
        {
            return MathNet.Numerics.ComplexExtensions.ToComplex(value, formatProvider);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean ComplexExtensions_TryToComplex_Internal(System.String value, out System.Numerics.Complex result)
        {
            return MathNet.Numerics.ComplexExtensions.TryToComplex(value,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean ComplexExtensions_TryToComplex_Internal(System.String value, System.IFormatProvider formatProvider, out System.Numerics.Complex result)
        {
            return MathNet.Numerics.ComplexExtensions.TryToComplex(value, formatProvider,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 ComplexExtensions_ToComplex32_Internal(System.String value)
        {
            return MathNet.Numerics.ComplexExtensions.ToComplex32(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 ComplexExtensions_ToComplex32_Internal(System.String value, System.IFormatProvider formatProvider)
        {
            return MathNet.Numerics.ComplexExtensions.ToComplex32(value, formatProvider);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean ComplexExtensions_TryToComplex32_Internal(System.String value, out MathNet.Numerics.Complex32 result)
        {
            return MathNet.Numerics.ComplexExtensions.TryToComplex32(value,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean ComplexExtensions_TryToComplex32_Internal(System.String value, System.IFormatProvider formatProvider, out MathNet.Numerics.Complex32 result)
        {
            return MathNet.Numerics.ComplexExtensions.TryToComplex32(value, formatProvider,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Control_TryUseNativeMKL_Internal()
        {
            return MathNet.Numerics.Control.TryUseNativeMKL();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Control_TryUseNativeCUDA_Internal()
        {
            return MathNet.Numerics.Control.TryUseNativeCUDA();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Control_TryUseNativeOpenBLAS_Internal()
        {
            return MathNet.Numerics.Control.TryUseNativeOpenBLAS();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Control_TryUseNative_Internal()
        {
            return MathNet.Numerics.Control.TryUseNative();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Control_CheckDistributionParameters_Internal()
        {
            return MathNet.Numerics.Control.CheckDistributionParameters;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Control_ThreadSafeRandomNumberGenerators_Internal()
        {
            return MathNet.Numerics.Control.ThreadSafeRandomNumberGenerators;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Control_NativeProviderPath_Internal()
        {
            return MathNet.Numerics.Control.NativeProviderPath;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Providers.LinearAlgebra.ILinearAlgebraProvider Control_LinearAlgebraProvider_Internal()
        {
            return MathNet.Numerics.Control.LinearAlgebraProvider;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Providers.FourierTransform.IFourierTransformProvider Control_FourierTransformProvider_Internal()
        {
            return MathNet.Numerics.Control.FourierTransformProvider;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Control_MaxDegreeOfParallelism_Internal()
        {
            return MathNet.Numerics.Control.MaxDegreeOfParallelism;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Threading.Tasks.TaskScheduler Control_TaskScheduler_Internal()
        {
            return MathNet.Numerics.Control.TaskScheduler;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Control_BlockSize_Internal()
        {
            return MathNet.Numerics.Control.BlockSize;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Log_Internal(MathNet.Numerics.Complex32 value, System.Single baseValue)
        {
            return MathNet.Numerics.Complex32.Log(value, baseValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Log10_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Log10(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Sin_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Sin(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Cos_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Cos(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Tan_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Tan(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Asin_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Asin(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Acos_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Acos(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Atan_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Atan(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Sinh_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Sinh(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Cosh_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Cosh(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Tanh_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Tanh(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_FromPolarCoordinates_Internal(System.Single magnitude, System.Single phase)
        {
            return MathNet.Numerics.Complex32.FromPolarCoordinates(magnitude, phase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Complex32_op_Equality_Internal(MathNet.Numerics.Complex32 complex1, MathNet.Numerics.Complex32 complex2)
        {
            return complex1 == complex2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Complex32_op_Inequality_Internal(MathNet.Numerics.Complex32 complex1, MathNet.Numerics.Complex32 complex2)
        {
            return complex1 != complex2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_UnaryPlus_Internal(MathNet.Numerics.Complex32 summand)
        {
            return +summand;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_UnaryNegation_Internal(MathNet.Numerics.Complex32 subtrahend)
        {
            return -subtrahend;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Addition_Internal(MathNet.Numerics.Complex32 summand1, MathNet.Numerics.Complex32 summand2)
        {
            return summand1 + summand2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Subtraction_Internal(MathNet.Numerics.Complex32 minuend, MathNet.Numerics.Complex32 subtrahend)
        {
            return minuend - subtrahend;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Addition_Internal(MathNet.Numerics.Complex32 summand1, System.Single summand2)
        {
            return summand1 + summand2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Subtraction_Internal(MathNet.Numerics.Complex32 minuend, System.Single subtrahend)
        {
            return minuend - subtrahend;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Addition_Internal(System.Single summand1, MathNet.Numerics.Complex32 summand2)
        {
            return summand1 + summand2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Subtraction_Internal(System.Single minuend, MathNet.Numerics.Complex32 subtrahend)
        {
            return minuend - subtrahend;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Multiply_Internal(MathNet.Numerics.Complex32 multiplicand, MathNet.Numerics.Complex32 multiplier)
        {
            return multiplicand * multiplier;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Multiply_Internal(System.Single multiplicand, MathNet.Numerics.Complex32 multiplier)
        {
            return multiplicand * multiplier;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Multiply_Internal(MathNet.Numerics.Complex32 multiplicand, System.Single multiplier)
        {
            return multiplicand * multiplier;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Division_Internal(MathNet.Numerics.Complex32 dividend, MathNet.Numerics.Complex32 divisor)
        {
            return dividend / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Division_Internal(System.Single dividend, MathNet.Numerics.Complex32 divisor)
        {
            return dividend / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Division_Internal(MathNet.Numerics.Complex32 dividend, System.Single divisor)
        {
            return dividend / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Parse_Internal(System.String value, System.IFormatProvider formatProvider)
        {
            return MathNet.Numerics.Complex32.Parse(value, formatProvider);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Complex32_TryParse_Internal(System.String value, out MathNet.Numerics.Complex32 result)
        {
            return MathNet.Numerics.Complex32.TryParse(value,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Complex32_TryParse_Internal(System.String value, System.IFormatProvider formatProvider, out MathNet.Numerics.Complex32 result)
        {
            return MathNet.Numerics.Complex32.TryParse(value, formatProvider,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Explicit_Internal(System.Decimal value)
        {
            return (MathNet.Numerics.Complex32)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Explicit_Internal(System.Numerics.Complex value)
        {
            return (MathNet.Numerics.Complex32)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Implicit_Internal(System.Byte value)
        {
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Implicit_Internal(System.Int16 value)
        {
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Implicit_Internal(System.SByte value)
        {
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Implicit_Internal(System.UInt16 value)
        {
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Implicit_Internal(System.Int32 value)
        {
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Implicit_Internal(System.Numerics.BigInteger value)
        {
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Implicit_Internal(System.Int64 value)
        {
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Implicit_Internal(System.UInt32 value)
        {
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Implicit_Internal(System.UInt64 value)
        {
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Implicit_Internal(System.Single value)
        {
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_op_Explicit_Internal(System.Double value)
        {
            return (MathNet.Numerics.Complex32)value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Negate_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Negate(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Conjugate_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Conjugate(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Add_Internal(MathNet.Numerics.Complex32 left, MathNet.Numerics.Complex32 right)
        {
            return MathNet.Numerics.Complex32.Add(left, right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Subtract_Internal(MathNet.Numerics.Complex32 left, MathNet.Numerics.Complex32 right)
        {
            return MathNet.Numerics.Complex32.Subtract(left, right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Multiply_Internal(MathNet.Numerics.Complex32 left, MathNet.Numerics.Complex32 right)
        {
            return MathNet.Numerics.Complex32.Multiply(left, right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Divide_Internal(MathNet.Numerics.Complex32 dividend, MathNet.Numerics.Complex32 divisor)
        {
            return MathNet.Numerics.Complex32.Divide(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Reciprocal_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Reciprocal(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Sqrt_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Sqrt(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Complex32_Abs_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Abs(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Exp_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Exp(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Pow_Internal(MathNet.Numerics.Complex32 value, MathNet.Numerics.Complex32 power)
        {
            return MathNet.Numerics.Complex32.Pow(value, power);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Pow_Internal(MathNet.Numerics.Complex32 value, System.Single power)
        {
            return MathNet.Numerics.Complex32.Pow(value, power);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Complex32_Log_Internal(MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.Complex32.Log(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_SAD_Internal(System.Double[] a, System.Double[] b)
        {
            return MathNet.Numerics.Distance.SAD(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Distance_SAD_Internal(System.Single[] a, System.Single[] b)
        {
            return MathNet.Numerics.Distance.SAD(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_MAE_Internal(System.Double[] a, System.Double[] b)
        {
            return MathNet.Numerics.Distance.MAE(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Distance_MAE_Internal(System.Single[] a, System.Single[] b)
        {
            return MathNet.Numerics.Distance.MAE(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_SSD_Internal(System.Double[] a, System.Double[] b)
        {
            return MathNet.Numerics.Distance.SSD(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Distance_SSD_Internal(System.Single[] a, System.Single[] b)
        {
            return MathNet.Numerics.Distance.SSD(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_MSE_Internal(System.Double[] a, System.Double[] b)
        {
            return MathNet.Numerics.Distance.MSE(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Distance_MSE_Internal(System.Single[] a, System.Single[] b)
        {
            return MathNet.Numerics.Distance.MSE(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_Euclidean_Internal(System.Double[] a, System.Double[] b)
        {
            return MathNet.Numerics.Distance.Euclidean(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Distance_Euclidean_Internal(System.Single[] a, System.Single[] b)
        {
            return MathNet.Numerics.Distance.Euclidean(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_Manhattan_Internal(System.Double[] a, System.Double[] b)
        {
            return MathNet.Numerics.Distance.Manhattan(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Distance_Manhattan_Internal(System.Single[] a, System.Single[] b)
        {
            return MathNet.Numerics.Distance.Manhattan(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_Chebyshev_Internal(System.Double[] a, System.Double[] b)
        {
            return MathNet.Numerics.Distance.Chebyshev(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Distance_Chebyshev_Internal(System.Single[] a, System.Single[] b)
        {
            return MathNet.Numerics.Distance.Chebyshev(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_Minkowski_Internal(System.Double p, System.Double[] a, System.Double[] b)
        {
            return MathNet.Numerics.Distance.Minkowski(p, a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Distance_Minkowski_Internal(System.Double p, System.Single[] a, System.Single[] b)
        {
            return MathNet.Numerics.Distance.Minkowski(p, a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_Canberra_Internal(System.Double[] a, System.Double[] b)
        {
            return MathNet.Numerics.Distance.Canberra(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Distance_Canberra_Internal(System.Single[] a, System.Single[] b)
        {
            return MathNet.Numerics.Distance.Canberra(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_Cosine_Internal(System.Double[] a, System.Double[] b)
        {
            return MathNet.Numerics.Distance.Cosine(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Distance_Cosine_Internal(System.Single[] a, System.Single[] b)
        {
            return MathNet.Numerics.Distance.Cosine(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_Hamming_Internal(System.Double[] a, System.Double[] b)
        {
            return MathNet.Numerics.Distance.Hamming(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Distance_Hamming_Internal(System.Single[] a, System.Single[] b)
        {
            return MathNet.Numerics.Distance.Hamming(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_Pearson_Internal(System.Collections.Generic.IEnumerable<System.Double> a, System.Collections.Generic.IEnumerable<System.Double> b)
        {
            return MathNet.Numerics.Distance.Pearson(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_Jaccard_Internal(System.Double[] a, System.Double[] b)
        {
            return MathNet.Numerics.Distance.Jaccard(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distance_Jaccard_Internal(System.Single[] a, System.Single[] b)
        {
            return MathNet.Numerics.Distance.Jaccard(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Fit_Line_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Fit.Line(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Fit_LineFunc_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Fit.LineFunc(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Fit_MultiDim_Internal(System.Double[][] x, System.Double[] y, System.Boolean intercept, MathNet.Numerics.LinearRegression.DirectRegressionMethod method)
        {
            return MathNet.Numerics.Fit.MultiDim(x, y, intercept, method);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double[], System.Double> Fit_MultiDimFunc_Internal(System.Double[][] x, System.Double[] y, System.Boolean intercept, MathNet.Numerics.LinearRegression.DirectRegressionMethod method)
        {
            return MathNet.Numerics.Fit.MultiDimFunc(x, y, intercept, method);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Fit_MultiDimWeighted_Internal(System.Double[][] x, System.Double[] y, System.Double[] w)
        {
            return MathNet.Numerics.Fit.MultiDimWeighted(x, y, w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Fit_Polynomial_Internal(System.Double[] x, System.Double[] y, System.Int32 order, MathNet.Numerics.LinearRegression.DirectRegressionMethod method)
        {
            return MathNet.Numerics.Fit.Polynomial(x, y, order, method);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Fit_PolynomialFunc_Internal(System.Double[] x, System.Double[] y, System.Int32 order, MathNet.Numerics.LinearRegression.DirectRegressionMethod method)
        {
            return MathNet.Numerics.Fit.PolynomialFunc(x, y, order, method);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Fit_PolynomialWeighted_Internal(System.Double[] x, System.Double[] y, System.Double[] w, System.Int32 order)
        {
            return MathNet.Numerics.Fit.PolynomialWeighted(x, y, w, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Fit_LinearCombination_Internal(System.Double[] x, System.Double[] y, System.Func<System.Double, System.Double>[] functions)
        {
            return MathNet.Numerics.Fit.LinearCombination(x, y, functions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Fit_LinearCombinationFunc_Internal(System.Double[] x, System.Double[] y, System.Func<System.Double, System.Double>[] functions)
        {
            return MathNet.Numerics.Fit.LinearCombinationFunc(x, y, functions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Fit_LinearCombination_Internal(System.Double[] x, System.Double[] y, MathNet.Numerics.LinearRegression.DirectRegressionMethod method, System.Func<System.Double, System.Double>[] functions)
        {
            return MathNet.Numerics.Fit.LinearCombination(x, y, method, functions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Fit_LinearCombinationFunc_Internal(System.Double[] x, System.Double[] y, MathNet.Numerics.LinearRegression.DirectRegressionMethod method, System.Func<System.Double, System.Double>[] functions)
        {
            return MathNet.Numerics.Fit.LinearCombinationFunc(x, y, method, functions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Fit_LinearMultiDim_Internal(System.Double[][] x, System.Double[] y, System.Func<System.Double[], System.Double>[] functions)
        {
            return MathNet.Numerics.Fit.LinearMultiDim(x, y, functions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double[], System.Double> Fit_LinearMultiDimFunc_Internal(System.Double[][] x, System.Double[] y, System.Func<System.Double[], System.Double>[] functions)
        {
            return MathNet.Numerics.Fit.LinearMultiDimFunc(x, y, functions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Fit_LinearMultiDim_Internal(System.Double[][] x, System.Double[] y, MathNet.Numerics.LinearRegression.DirectRegressionMethod method, System.Func<System.Double[], System.Double>[] functions)
        {
            return MathNet.Numerics.Fit.LinearMultiDim(x, y, method, functions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double[], System.Double> Fit_LinearMultiDimFunc_Internal(System.Double[][] x, System.Double[] y, MathNet.Numerics.LinearRegression.DirectRegressionMethod method, System.Func<System.Double[], System.Double>[] functions)
        {
            return MathNet.Numerics.Fit.LinearMultiDimFunc(x, y, method, functions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double FindRoots_OfFunction_Internal(System.Func<System.Double, System.Double> f, System.Double lowerBound, System.Double upperBound, System.Double accuracy, System.Int32 maxIterations)
        {
            return MathNet.Numerics.FindRoots.OfFunction(f, lowerBound, upperBound, accuracy, maxIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double FindRoots_OfFunctionDerivative_Internal(System.Func<System.Double, System.Double> f, System.Func<System.Double, System.Double> df, System.Double lowerBound, System.Double upperBound, System.Double accuracy, System.Int32 maxIterations)
        {
            return MathNet.Numerics.FindRoots.OfFunctionDerivative(f, df, lowerBound, upperBound, accuracy, maxIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Numerics.Complex, System.Numerics.Complex> FindRoots_Quadratic_Internal(System.Double c, System.Double b, System.Double a)
        {
            return MathNet.Numerics.FindRoots.Quadratic(c, b, a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Numerics.Complex, System.Numerics.Complex, System.Numerics.Complex> FindRoots_Cubic_Internal(System.Double d, System.Double c, System.Double b, System.Double a)
        {
            return MathNet.Numerics.FindRoots.Cubic(d, c, b, a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] FindRoots_ChebychevPolynomialFirstKind_Internal(System.Int32 degree, System.Double intervalBegin, System.Double intervalEnd)
        {
            return MathNet.Numerics.FindRoots.ChebychevPolynomialFirstKind(degree, intervalBegin, intervalEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] FindRoots_ChebychevPolynomialSecondKind_Internal(System.Int32 degree, System.Double intervalBegin, System.Double intervalEnd)
        {
            return MathNet.Numerics.FindRoots.ChebychevPolynomialSecondKind(degree, intervalBegin, intervalEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Evaluate_Polynomial_Internal(System.Double z, System.Double[] coefficients)
        {
            return MathNet.Numerics.Evaluate.Polynomial(z, coefficients);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Evaluate_Polynomial_Internal(System.Numerics.Complex z, System.Double[] coefficients)
        {
            return MathNet.Numerics.Evaluate.Polynomial(z, coefficients);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Evaluate_Polynomial_Internal(System.Numerics.Complex z, System.Numerics.Complex[] coefficients)
        {
            return MathNet.Numerics.Evaluate.Polynomial(z, coefficients);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_NormSDist_Internal(System.Double z)
        {
            return MathNet.Numerics.ExcelFunctions.NormSDist(z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_NormSInv_Internal(System.Double probability)
        {
            return MathNet.Numerics.ExcelFunctions.NormSInv(probability);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_NormDist_Internal(System.Double x, System.Double mean, System.Double standardDev, System.Boolean cumulative)
        {
            return MathNet.Numerics.ExcelFunctions.NormDist(x, mean, standardDev, cumulative);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_NormInv_Internal(System.Double probability, System.Double mean, System.Double standardDev)
        {
            return MathNet.Numerics.ExcelFunctions.NormInv(probability, mean, standardDev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_TDist_Internal(System.Double x, System.Int32 degreesFreedom, System.Int32 tails)
        {
            return MathNet.Numerics.ExcelFunctions.TDist(x, degreesFreedom, tails);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_TInv_Internal(System.Double probability, System.Int32 degreesFreedom)
        {
            return MathNet.Numerics.ExcelFunctions.TInv(probability, degreesFreedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_FDist_Internal(System.Double x, System.Int32 degreesFreedom1, System.Int32 degreesFreedom2)
        {
            return MathNet.Numerics.ExcelFunctions.FDist(x, degreesFreedom1, degreesFreedom2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_FInv_Internal(System.Double probability, System.Int32 degreesFreedom1, System.Int32 degreesFreedom2)
        {
            return MathNet.Numerics.ExcelFunctions.FInv(probability, degreesFreedom1, degreesFreedom2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_BetaDist_Internal(System.Double x, System.Double alpha, System.Double beta)
        {
            return MathNet.Numerics.ExcelFunctions.BetaDist(x, alpha, beta);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_BetaInv_Internal(System.Double probability, System.Double alpha, System.Double beta)
        {
            return MathNet.Numerics.ExcelFunctions.BetaInv(probability, alpha, beta);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_GammaDist_Internal(System.Double x, System.Double alpha, System.Double beta, System.Boolean cumulative)
        {
            return MathNet.Numerics.ExcelFunctions.GammaDist(x, alpha, beta, cumulative);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_GammaInv_Internal(System.Double probability, System.Double alpha, System.Double beta)
        {
            return MathNet.Numerics.ExcelFunctions.GammaInv(probability, alpha, beta);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_Quartile_Internal(System.Double[] array, System.Int32 quant)
        {
            return MathNet.Numerics.ExcelFunctions.Quartile(array, quant);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_Percentile_Internal(System.Double[] array, System.Double k)
        {
            return MathNet.Numerics.ExcelFunctions.Percentile(array, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double ExcelFunctions_PercentRank_Internal(System.Double[] array, System.Double x)
        {
            return MathNet.Numerics.ExcelFunctions.PercentRank(array, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_ExponentialIntegral_Internal(System.Double x, System.Int32 n)
        {
            return MathNet.Numerics.SpecialFunctions.ExponentialIntegral(x, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_StruveL0_Internal(System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.StruveL0(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_StruveL1_Internal(System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.StruveL1(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_BesselI0MStruveL0_Internal(System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.BesselI0MStruveL0(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_BesselI1MStruveL1_Internal(System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.BesselI1MStruveL1(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_BesselI0_Internal(System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.BesselI0(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_BesselI1_Internal(System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.BesselI1(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_BesselK0_Internal(System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.BesselK0(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_BesselK0e_Internal(System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.BesselK0e(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_BesselK1_Internal(System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.BesselK1(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_BesselK1e_Internal(System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.BesselK1e(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_Logistic_Internal(System.Double p)
        {
            return MathNet.Numerics.SpecialFunctions.Logistic(p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_Logit_Internal(System.Double p)
        {
            return MathNet.Numerics.SpecialFunctions.Logit(p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_Harmonic_Internal(System.Int32 t)
        {
            return MathNet.Numerics.SpecialFunctions.Harmonic(t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_GeneralHarmonic_Internal(System.Int32 n, System.Double m)
        {
            return MathNet.Numerics.SpecialFunctions.GeneralHarmonic(n, m);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_BetaLn_Internal(System.Double z, System.Double w)
        {
            return MathNet.Numerics.SpecialFunctions.BetaLn(z, w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_Beta_Internal(System.Double z, System.Double w)
        {
            return MathNet.Numerics.SpecialFunctions.Beta(z, w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_BetaIncomplete_Internal(System.Double a, System.Double b, System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.BetaIncomplete(a, b, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_BetaRegularized_Internal(System.Double a, System.Double b, System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.BetaRegularized(a, b, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_Erf_Internal(System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.Erf(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_Erfc_Internal(System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.Erfc(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_ErfInv_Internal(System.Double z)
        {
            return MathNet.Numerics.SpecialFunctions.ErfInv(z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_ErfcInv_Internal(System.Double z)
        {
            return MathNet.Numerics.SpecialFunctions.ErfcInv(z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_Factorial_Internal(System.Int32 x)
        {
            return MathNet.Numerics.SpecialFunctions.Factorial(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.BigInteger SpecialFunctions_Factorial_Internal(System.Numerics.BigInteger x)
        {
            return MathNet.Numerics.SpecialFunctions.Factorial(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_FactorialLn_Internal(System.Int32 x)
        {
            return MathNet.Numerics.SpecialFunctions.FactorialLn(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_Binomial_Internal(System.Int32 n, System.Int32 k)
        {
            return MathNet.Numerics.SpecialFunctions.Binomial(n, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_BinomialLn_Internal(System.Int32 n, System.Int32 k)
        {
            return MathNet.Numerics.SpecialFunctions.BinomialLn(n, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_Multinomial_Internal(System.Int32 n, System.Int32[] ni)
        {
            return MathNet.Numerics.SpecialFunctions.Multinomial(n, ni);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_GammaLn_Internal(System.Double z)
        {
            return MathNet.Numerics.SpecialFunctions.GammaLn(z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_Gamma_Internal(System.Double z)
        {
            return MathNet.Numerics.SpecialFunctions.Gamma(z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_GammaUpperRegularized_Internal(System.Double a, System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.GammaUpperRegularized(a, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_GammaUpperIncomplete_Internal(System.Double a, System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.GammaUpperIncomplete(a, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_GammaLowerIncomplete_Internal(System.Double a, System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.GammaLowerIncomplete(a, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_GammaLowerRegularized_Internal(System.Double a, System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.GammaLowerRegularized(a, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_GammaLowerRegularizedInv_Internal(System.Double a, System.Double y0)
        {
            return MathNet.Numerics.SpecialFunctions.GammaLowerRegularizedInv(a, y0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_DiGamma_Internal(System.Double x)
        {
            return MathNet.Numerics.SpecialFunctions.DiGamma(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_DiGammaInv_Internal(System.Double p)
        {
            return MathNet.Numerics.SpecialFunctions.DiGammaInv(p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_ExponentialMinusOne_Internal(System.Double power)
        {
            return MathNet.Numerics.SpecialFunctions.ExponentialMinusOne(power);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex SpecialFunctions_Hypotenuse_Internal(System.Numerics.Complex a, System.Numerics.Complex b)
        {
            return MathNet.Numerics.SpecialFunctions.Hypotenuse(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 SpecialFunctions_Hypotenuse_Internal(MathNet.Numerics.Complex32 a, MathNet.Numerics.Complex32 b)
        {
            return MathNet.Numerics.SpecialFunctions.Hypotenuse(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double SpecialFunctions_Hypotenuse_Internal(System.Double a, System.Double b)
        {
            return MathNet.Numerics.SpecialFunctions.Hypotenuse(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single SpecialFunctions_Hypotenuse_Internal(System.Single a, System.Single b)
        {
            return MathNet.Numerics.SpecialFunctions.Hypotenuse(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double TestFunctions_Rosenbrock_2_Internal(System.Double x, System.Double y)
        {
            return MathNet.Numerics.TestFunctions.Rosenbrock(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double TestFunctions_Rosenbrock_1_Internal(System.Double[] x)
        {
            return MathNet.Numerics.TestFunctions.Rosenbrock(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double TestFunctions_Himmelblau_Internal(System.Double x, System.Double y)
        {
            return MathNet.Numerics.TestFunctions.Himmelblau(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double TestFunctions_Rastrigin_Internal(System.Double[] x)
        {
            return MathNet.Numerics.TestFunctions.Rastrigin(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double TestFunctions_DropWave_Internal(System.Double x, System.Double y)
        {
            return MathNet.Numerics.TestFunctions.DropWave(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double TestFunctions_Ackley_Internal(System.Double[] x)
        {
            return MathNet.Numerics.TestFunctions.Ackley(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double TestFunctions_Bohachevsky1_Internal(System.Double x, System.Double y)
        {
            return MathNet.Numerics.TestFunctions.Bohachevsky1(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double TestFunctions_Matyas_Internal(System.Double x, System.Double y)
        {
            return MathNet.Numerics.TestFunctions.Matyas(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double TestFunctions_SixHumpCamel_Internal(System.Double x, System.Double y)
        {
            return MathNet.Numerics.TestFunctions.SixHumpCamel(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Permutation Permutation_FromInversions_Internal(System.Int32[] inv)
        {
            return MathNet.Numerics.Permutation.FromInversions(inv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Integrate_OnClosedInterval_Internal(System.Func<System.Double, System.Double> f, System.Double intervalBegin, System.Double intervalEnd, System.Double targetAbsoluteError)
        {
            return MathNet.Numerics.Integrate.OnClosedInterval(f, intervalBegin, intervalEnd, targetAbsoluteError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Integrate_OnClosedInterval_Internal(System.Func<System.Double, System.Double> f, System.Double intervalBegin, System.Double intervalEnd)
        {
            return MathNet.Numerics.Integrate.OnClosedInterval(f, intervalBegin, intervalEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Integrate_OnRectangle_Internal(System.Func<System.Double, System.Double, System.Double> f, System.Double invervalBeginA, System.Double invervalEndA, System.Double invervalBeginB, System.Double invervalEndB, System.Int32 order)
        {
            return MathNet.Numerics.Integrate.OnRectangle(f, invervalBeginA, invervalEndA, invervalBeginB, invervalEndB, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Integrate_OnRectangle_Internal(System.Func<System.Double, System.Double, System.Double> f, System.Double invervalBeginA, System.Double invervalEndA, System.Double invervalBeginB, System.Double invervalEndB)
        {
            return MathNet.Numerics.Integrate.OnRectangle(f, invervalBeginA, invervalEndA, invervalBeginB, invervalEndB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.IInterpolation Interpolate_Common_Internal(System.Collections.Generic.IEnumerable<System.Double> points, System.Collections.Generic.IEnumerable<System.Double> values)
        {
            return MathNet.Numerics.Interpolate.Common(points, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.IInterpolation Interpolate_RationalWithoutPoles_Internal(System.Collections.Generic.IEnumerable<System.Double> points, System.Collections.Generic.IEnumerable<System.Double> values)
        {
            return MathNet.Numerics.Interpolate.RationalWithoutPoles(points, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.IInterpolation Interpolate_RationalWithPoles_Internal(System.Collections.Generic.IEnumerable<System.Double> points, System.Collections.Generic.IEnumerable<System.Double> values)
        {
            return MathNet.Numerics.Interpolate.RationalWithPoles(points, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.IInterpolation Interpolate_PolynomialEquidistant_Internal(System.Collections.Generic.IEnumerable<System.Double> points, System.Collections.Generic.IEnumerable<System.Double> values)
        {
            return MathNet.Numerics.Interpolate.PolynomialEquidistant(points, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.IInterpolation Interpolate_Polynomial_Internal(System.Collections.Generic.IEnumerable<System.Double> points, System.Collections.Generic.IEnumerable<System.Double> values)
        {
            return MathNet.Numerics.Interpolate.Polynomial(points, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.IInterpolation Interpolate_Linear_Internal(System.Collections.Generic.IEnumerable<System.Double> points, System.Collections.Generic.IEnumerable<System.Double> values)
        {
            return MathNet.Numerics.Interpolate.Linear(points, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.IInterpolation Interpolate_LogLinear_Internal(System.Collections.Generic.IEnumerable<System.Double> points, System.Collections.Generic.IEnumerable<System.Double> values)
        {
            return MathNet.Numerics.Interpolate.LogLinear(points, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.IInterpolation Interpolate_LinearSpline_Internal(System.Collections.Generic.IEnumerable<System.Double> points, System.Collections.Generic.IEnumerable<System.Double> values)
        {
            return MathNet.Numerics.Interpolate.LinearSpline(points, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.IInterpolation Interpolate_CubicSpline_Internal(System.Collections.Generic.IEnumerable<System.Double> points, System.Collections.Generic.IEnumerable<System.Double> values)
        {
            return MathNet.Numerics.Interpolate.CubicSpline(points, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.IInterpolation Interpolate_CubicSplineRobust_Internal(System.Collections.Generic.IEnumerable<System.Double> points, System.Collections.Generic.IEnumerable<System.Double> values)
        {
            return MathNet.Numerics.Interpolate.CubicSplineRobust(points, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.IInterpolation Interpolate_CubicSplineWithDerivatives_Internal(System.Collections.Generic.IEnumerable<System.Double> points, System.Collections.Generic.IEnumerable<System.Double> values, System.Collections.Generic.IEnumerable<System.Double> firstDerivatives)
        {
            return MathNet.Numerics.Interpolate.CubicSplineWithDerivatives(points, values, firstDerivatives);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.IInterpolation Interpolate_Step_Internal(System.Collections.Generic.IEnumerable<System.Double> points, System.Collections.Generic.IEnumerable<System.Double> values)
        {
            return MathNet.Numerics.Interpolate.Step(points, values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_DegreeToGrad_Internal(System.Double degree)
        {
            return MathNet.Numerics.Trig.DegreeToGrad(degree);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_DegreeToRadian_Internal(System.Double degree)
        {
            return MathNet.Numerics.Trig.DegreeToRadian(degree);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_GradToDegree_Internal(System.Double grad)
        {
            return MathNet.Numerics.Trig.GradToDegree(grad);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_GradToRadian_Internal(System.Double grad)
        {
            return MathNet.Numerics.Trig.GradToRadian(grad);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_RadianToDegree_Internal(System.Double radian)
        {
            return MathNet.Numerics.Trig.RadianToDegree(radian);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_RadianToGrad_Internal(System.Double radian)
        {
            return MathNet.Numerics.Trig.RadianToGrad(radian);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Sinc_Internal(System.Double x)
        {
            return MathNet.Numerics.Trig.Sinc(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Sin_Internal(System.Double radian)
        {
            return MathNet.Numerics.Trig.Sin(radian);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Sin_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Sin(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Cos_Internal(System.Double radian)
        {
            return MathNet.Numerics.Trig.Cos(radian);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Cos_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Cos(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Tan_Internal(System.Double radian)
        {
            return MathNet.Numerics.Trig.Tan(radian);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Tan_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Tan(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Cot_Internal(System.Double radian)
        {
            return MathNet.Numerics.Trig.Cot(radian);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Cot_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Cot(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Sec_Internal(System.Double radian)
        {
            return MathNet.Numerics.Trig.Sec(radian);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Sec_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Sec(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Csc_Internal(System.Double radian)
        {
            return MathNet.Numerics.Trig.Csc(radian);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Csc_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Csc(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Asin_Internal(System.Double opposite)
        {
            return MathNet.Numerics.Trig.Asin(opposite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Asin_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Asin(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Acos_Internal(System.Double adjacent)
        {
            return MathNet.Numerics.Trig.Acos(adjacent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Acos_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Acos(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Atan_Internal(System.Double opposite)
        {
            return MathNet.Numerics.Trig.Atan(opposite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Atan_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Atan(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Acot_Internal(System.Double adjacent)
        {
            return MathNet.Numerics.Trig.Acot(adjacent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Acot_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Acot(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Asec_Internal(System.Double hypotenuse)
        {
            return MathNet.Numerics.Trig.Asec(hypotenuse);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Asec_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Asec(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Acsc_Internal(System.Double hypotenuse)
        {
            return MathNet.Numerics.Trig.Acsc(hypotenuse);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Acsc_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Acsc(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Sinh_Internal(System.Double angle)
        {
            return MathNet.Numerics.Trig.Sinh(angle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Sinh_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Sinh(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Cosh_Internal(System.Double angle)
        {
            return MathNet.Numerics.Trig.Cosh(angle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Cosh_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Cosh(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Tanh_Internal(System.Double angle)
        {
            return MathNet.Numerics.Trig.Tanh(angle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Tanh_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Tanh(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Coth_Internal(System.Double angle)
        {
            return MathNet.Numerics.Trig.Coth(angle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Coth_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Coth(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Sech_Internal(System.Double angle)
        {
            return MathNet.Numerics.Trig.Sech(angle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Sech_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Sech(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Csch_Internal(System.Double angle)
        {
            return MathNet.Numerics.Trig.Csch(angle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Csch_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Csch(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Asinh_Internal(System.Double value)
        {
            return MathNet.Numerics.Trig.Asinh(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Asinh_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Asinh(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Acosh_Internal(System.Double value)
        {
            return MathNet.Numerics.Trig.Acosh(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Acosh_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Acosh(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Atanh_Internal(System.Double value)
        {
            return MathNet.Numerics.Trig.Atanh(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Atanh_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Atanh(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Acoth_Internal(System.Double value)
        {
            return MathNet.Numerics.Trig.Acoth(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Acoth_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Acoth(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Asech_Internal(System.Double value)
        {
            return MathNet.Numerics.Trig.Asech(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Asech_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Asech(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Trig_Acsch_Internal(System.Double value)
        {
            return MathNet.Numerics.Trig.Acsch(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Trig_Acsch_Internal(System.Numerics.Complex value)
        {
            return MathNet.Numerics.Trig.Acsch(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_Hamming_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.Hamming(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_HammingPeriodic_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.HammingPeriodic(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_Hann_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.Hann(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_HannPeriodic_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.HannPeriodic(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_Cosine_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.Cosine(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_CosinePeriodic_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.CosinePeriodic(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_Lanczos_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.Lanczos(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_LanczosPeriodic_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.LanczosPeriodic(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_Gauss_Internal(System.Int32 width, System.Double sigma)
        {
            return MathNet.Numerics.Window.Gauss(width, sigma);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_Blackman_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.Blackman(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_BlackmanHarris_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.BlackmanHarris(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_BlackmanNuttall_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.BlackmanNuttall(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_Bartlett_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.Bartlett(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_BartlettHann_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.BartlettHann(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_Nuttall_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.Nuttall(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_FlatTop_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.FlatTop(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_Dirichlet_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.Dirichlet(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Window_Triangular_Internal(System.Int32 width)
        {
            return MathNet.Numerics.Window.Triangular(width);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_Minimum_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.Minimum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_Maximum_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.Maximum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_MinimumAbsolute_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MinimumAbsolute(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_MaximumAbsolute_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MaximumAbsolute(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_Mean_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.Mean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_GeometricMean_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.GeometricMean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_HarmonicMean_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.HarmonicMean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_Variance_Internal(System.Double[] samples)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.Variance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_PopulationVariance_Internal(System.Double[] population)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.PopulationVariance(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_StandardDeviation_Internal(System.Double[] samples)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.StandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_PopulationStandardDeviation_Internal(System.Double[] population)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.PopulationStandardDeviation(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_ArrayStatistics_MeanVariance_Internal(System.Double[] samples)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MeanVariance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_ArrayStatistics_MeanStandardDeviation_Internal(System.Double[] samples)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MeanStandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_Covariance_Internal(System.Double[] samples1, System.Double[] samples2)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.Covariance(samples1, samples2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_PopulationCovariance_Internal(System.Double[] population1, System.Double[] population2)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.PopulationCovariance(population1, population2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_RootMeanSquare_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.RootMeanSquare(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_OrderStatisticInplace_Internal(System.Double[] data, System.Int32 order)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.OrderStatisticInplace(data, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_MedianInplace_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MedianInplace(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_PercentileInplace_Internal(System.Double[] data, System.Int32 p)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.PercentileInplace(data, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_LowerQuartileInplace_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.LowerQuartileInplace(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_UpperQuartileInplace_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.UpperQuartileInplace(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_InterquartileRangeInplace_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.InterquartileRangeInplace(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Statistics_ArrayStatistics_FiveNumberSummaryInplace_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.FiveNumberSummaryInplace(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_QuantileInplace_Internal(System.Double[] data, System.Double tau)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.QuantileInplace(data, tau);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_QuantileCustomInplace_Internal(System.Double[] data, System.Double tau, System.Double a, System.Double b, System.Double c, System.Double d)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.QuantileCustomInplace(data, tau, a, b, c, d);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_QuantileCustomInplace_Internal(System.Double[] data, System.Double tau, MathNet.Numerics.Statistics.QuantileDefinition definition)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.QuantileCustomInplace(data, tau, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Statistics_ArrayStatistics_RanksInplace_Internal(System.Double[] data, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.RanksInplace(data, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Statistics_ArrayStatistics_MinimumMagnitudePhase_Internal(System.Numerics.Complex[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MinimumMagnitudePhase(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Statistics_ArrayStatistics_MinimumMagnitudePhase_Internal(MathNet.Numerics.Complex32[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MinimumMagnitudePhase(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Statistics_ArrayStatistics_MaximumMagnitudePhase_Internal(System.Numerics.Complex[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MaximumMagnitudePhase(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Statistics_ArrayStatistics_MaximumMagnitudePhase_Internal(MathNet.Numerics.Complex32[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MaximumMagnitudePhase(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_Mean_Internal(System.Int32[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.Mean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_GeometricMean_Internal(System.Int32[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.GeometricMean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_HarmonicMean_Internal(System.Int32[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.HarmonicMean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_Variance_Internal(System.Int32[] samples)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.Variance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_PopulationVariance_Internal(System.Int32[] population)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.PopulationVariance(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_StandardDeviation_Internal(System.Int32[] samples)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.StandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_PopulationStandardDeviation_Internal(System.Int32[] population)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.PopulationStandardDeviation(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_ArrayStatistics_MeanVariance_Internal(System.Int32[] samples)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MeanVariance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_ArrayStatistics_MeanStandardDeviation_Internal(System.Int32[] samples)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MeanStandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_Covariance_Internal(System.Int32[] samples1, System.Int32[] samples2)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.Covariance(samples1, samples2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_PopulationCovariance_Internal(System.Int32[] population1, System.Int32[] population2)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.PopulationCovariance(population1, population2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_RootMeanSquare_Internal(System.Int32[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.RootMeanSquare(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_ArrayStatistics_Minimum_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.Minimum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_ArrayStatistics_Maximum_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.Maximum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_ArrayStatistics_MinimumAbsolute_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MinimumAbsolute(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_ArrayStatistics_MaximumAbsolute_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MaximumAbsolute(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_Mean_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.Mean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_GeometricMean_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.GeometricMean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_HarmonicMean_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.HarmonicMean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_Variance_Internal(System.Single[] samples)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.Variance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_PopulationVariance_Internal(System.Single[] population)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.PopulationVariance(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_StandardDeviation_Internal(System.Single[] samples)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.StandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_PopulationStandardDeviation_Internal(System.Single[] population)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.PopulationStandardDeviation(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_ArrayStatistics_MeanVariance_Internal(System.Single[] samples)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MeanVariance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_ArrayStatistics_MeanStandardDeviation_Internal(System.Single[] samples)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MeanStandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_Covariance_Internal(System.Single[] samples1, System.Single[] samples2)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.Covariance(samples1, samples2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_PopulationCovariance_Internal(System.Single[] population1, System.Single[] population2)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.PopulationCovariance(population1, population2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_ArrayStatistics_RootMeanSquare_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.RootMeanSquare(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_ArrayStatistics_OrderStatisticInplace_Internal(System.Single[] data, System.Int32 order)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.OrderStatisticInplace(data, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_ArrayStatistics_MedianInplace_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.MedianInplace(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_ArrayStatistics_PercentileInplace_Internal(System.Single[] data, System.Int32 p)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.PercentileInplace(data, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_ArrayStatistics_LowerQuartileInplace_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.LowerQuartileInplace(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_ArrayStatistics_UpperQuartileInplace_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.UpperQuartileInplace(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_ArrayStatistics_InterquartileRangeInplace_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.InterquartileRangeInplace(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single[] Statistics_ArrayStatistics_FiveNumberSummaryInplace_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.FiveNumberSummaryInplace(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_ArrayStatistics_QuantileInplace_Internal(System.Single[] data, System.Double tau)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.QuantileInplace(data, tau);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_ArrayStatistics_QuantileCustomInplace_Internal(System.Single[] data, System.Double tau, System.Double a, System.Double b, System.Double c, System.Double d)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.QuantileCustomInplace(data, tau, a, b, c, d);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_ArrayStatistics_QuantileCustomInplace_Internal(System.Single[] data, System.Double tau, MathNet.Numerics.Statistics.QuantileDefinition definition)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.QuantileCustomInplace(data, tau, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Statistics_ArrayStatistics_RanksInplace_Internal(System.Single[] data, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.ArrayStatistics.RanksInplace(data, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Statistics.RunningStatistics Statistics_RunningStatistics_Combine_Internal(MathNet.Numerics.Statistics.RunningStatistics a, MathNet.Numerics.Statistics.RunningStatistics b)
        {
            return MathNet.Numerics.Statistics.RunningStatistics.Combine(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Statistics.RunningStatistics Statistics_RunningStatistics_op_Addition_Internal(MathNet.Numerics.Statistics.RunningStatistics a, MathNet.Numerics.Statistics.RunningStatistics b)
        {
            return a + b;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_SortedArrayStatistics_Minimum_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.Minimum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_SortedArrayStatistics_Maximum_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.Maximum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_SortedArrayStatistics_OrderStatistic_Internal(System.Single[] data, System.Int32 order)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.OrderStatistic(data, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_SortedArrayStatistics_Median_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.Median(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_SortedArrayStatistics_Percentile_Internal(System.Single[] data, System.Int32 p)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.Percentile(data, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_SortedArrayStatistics_LowerQuartile_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.LowerQuartile(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_SortedArrayStatistics_UpperQuartile_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.UpperQuartile(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_SortedArrayStatistics_InterquartileRange_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.InterquartileRange(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single[] Statistics_SortedArrayStatistics_FiveNumberSummary_Internal(System.Single[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.FiveNumberSummary(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_SortedArrayStatistics_Quantile_Internal(System.Single[] data, System.Double tau)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.Quantile(data, tau);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_SortedArrayStatistics_QuantileCustom_Internal(System.Single[] data, System.Double tau, System.Double a, System.Double b, System.Double c, System.Double d)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.QuantileCustom(data, tau, a, b, c, d);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_SortedArrayStatistics_QuantileCustom_Internal(System.Single[] data, System.Double tau, MathNet.Numerics.Statistics.QuantileDefinition definition)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.QuantileCustom(data, tau, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_EmpiricalCDF_Internal(System.Single[] data, System.Single x)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.EmpiricalCDF(data, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_QuantileRank_Internal(System.Single[] data, System.Single x, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.QuantileRank(data, x, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Statistics_SortedArrayStatistics_Ranks_Internal(System.Single[] data, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.Ranks(data, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_Minimum_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.Minimum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_Maximum_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.Maximum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_OrderStatistic_Internal(System.Double[] data, System.Int32 order)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.OrderStatistic(data, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_Median_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.Median(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_Percentile_Internal(System.Double[] data, System.Int32 p)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.Percentile(data, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_LowerQuartile_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.LowerQuartile(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_UpperQuartile_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.UpperQuartile(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_InterquartileRange_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.InterquartileRange(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Statistics_SortedArrayStatistics_FiveNumberSummary_Internal(System.Double[] data)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.FiveNumberSummary(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_Quantile_Internal(System.Double[] data, System.Double tau)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.Quantile(data, tau);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_QuantileCustom_Internal(System.Double[] data, System.Double tau, System.Double a, System.Double b, System.Double c, System.Double d)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.QuantileCustom(data, tau, a, b, c, d);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_QuantileCustom_Internal(System.Double[] data, System.Double tau, MathNet.Numerics.Statistics.QuantileDefinition definition)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.QuantileCustom(data, tau, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_EmpiricalCDF_Internal(System.Double[] data, System.Double x)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.EmpiricalCDF(data, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_SortedArrayStatistics_QuantileRank_Internal(System.Double[] data, System.Double x, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.QuantileRank(data, x, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Statistics_SortedArrayStatistics_Ranks_Internal(System.Double[] data, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.SortedArrayStatistics.Ranks(data, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_Minimum_Internal(System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.Minimum(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_StreamingStatistics_Minimum_Internal(System.Collections.Generic.IEnumerable<System.Single> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.Minimum(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_Maximum_Internal(System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.Maximum(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_StreamingStatistics_Maximum_Internal(System.Collections.Generic.IEnumerable<System.Single> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.Maximum(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_MinimumAbsolute_Internal(System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.MinimumAbsolute(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_StreamingStatistics_MinimumAbsolute_Internal(System.Collections.Generic.IEnumerable<System.Single> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.MinimumAbsolute(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_MaximumAbsolute_Internal(System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.MaximumAbsolute(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_StreamingStatistics_MaximumAbsolute_Internal(System.Collections.Generic.IEnumerable<System.Single> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.MaximumAbsolute(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Statistics_StreamingStatistics_MinimumMagnitudePhase_Internal(System.Collections.Generic.IEnumerable<System.Numerics.Complex> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.MinimumMagnitudePhase(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Statistics_StreamingStatistics_MinimumMagnitudePhase_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.MinimumMagnitudePhase(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Statistics_StreamingStatistics_MaximumMagnitudePhase_Internal(System.Collections.Generic.IEnumerable<System.Numerics.Complex> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.MaximumMagnitudePhase(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Statistics_StreamingStatistics_MaximumMagnitudePhase_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.MaximumMagnitudePhase(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_Mean_Internal(System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.Mean(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_Mean_Internal(System.Collections.Generic.IEnumerable<System.Single> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.Mean(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_GeometricMean_Internal(System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.GeometricMean(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_GeometricMean_Internal(System.Collections.Generic.IEnumerable<System.Single> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.GeometricMean(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_HarmonicMean_Internal(System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.HarmonicMean(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_HarmonicMean_Internal(System.Collections.Generic.IEnumerable<System.Single> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.HarmonicMean(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_Variance_Internal(System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.Variance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_Variance_Internal(System.Collections.Generic.IEnumerable<System.Single> samples)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.Variance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_PopulationVariance_Internal(System.Collections.Generic.IEnumerable<System.Double> population)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.PopulationVariance(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_PopulationVariance_Internal(System.Collections.Generic.IEnumerable<System.Single> population)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.PopulationVariance(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_StandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.StandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_StandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Single> samples)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.StandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_PopulationStandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Double> population)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.PopulationStandardDeviation(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_PopulationStandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Single> population)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.PopulationStandardDeviation(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_StreamingStatistics_MeanVariance_Internal(System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.MeanVariance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_StreamingStatistics_MeanVariance_Internal(System.Collections.Generic.IEnumerable<System.Single> samples)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.MeanVariance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_StreamingStatistics_MeanStandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.MeanStandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_StreamingStatistics_MeanStandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Single> samples)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.MeanStandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_Covariance_Internal(System.Collections.Generic.IEnumerable<System.Double> samples1, System.Collections.Generic.IEnumerable<System.Double> samples2)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.Covariance(samples1, samples2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_Covariance_Internal(System.Collections.Generic.IEnumerable<System.Single> samples1, System.Collections.Generic.IEnumerable<System.Single> samples2)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.Covariance(samples1, samples2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_PopulationCovariance_Internal(System.Collections.Generic.IEnumerable<System.Double> population1, System.Collections.Generic.IEnumerable<System.Double> population2)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.PopulationCovariance(population1, population2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_PopulationCovariance_Internal(System.Collections.Generic.IEnumerable<System.Single> population1, System.Collections.Generic.IEnumerable<System.Single> population2)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.PopulationCovariance(population1, population2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_RootMeanSquare_Internal(System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.RootMeanSquare(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_RootMeanSquare_Internal(System.Collections.Generic.IEnumerable<System.Single> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.RootMeanSquare(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_StreamingStatistics_Entropy_Internal(System.Collections.Generic.IEnumerable<System.Double> stream)
        {
            return MathNet.Numerics.Statistics.StreamingStatistics.Entropy(stream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Correlation_Pearson_Internal(System.Collections.Generic.IEnumerable<System.Double> dataA, System.Collections.Generic.IEnumerable<System.Double> dataB)
        {
            return MathNet.Numerics.Statistics.Correlation.Pearson(dataA, dataB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Correlation_WeightedPearson_Internal(System.Collections.Generic.IEnumerable<System.Double> dataA, System.Collections.Generic.IEnumerable<System.Double> dataB, System.Collections.Generic.IEnumerable<System.Double> weights)
        {
            return MathNet.Numerics.Statistics.Correlation.WeightedPearson(dataA, dataB, weights);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> Statistics_Correlation_PearsonMatrix_Internal(System.Double[][] vectors)
        {
            return MathNet.Numerics.Statistics.Correlation.PearsonMatrix(vectors);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> Statistics_Correlation_PearsonMatrix_Internal(System.Collections.Generic.IEnumerable<System.Double[]> vectors)
        {
            return MathNet.Numerics.Statistics.Correlation.PearsonMatrix(vectors);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Correlation_Spearman_Internal(System.Collections.Generic.IEnumerable<System.Double> dataA, System.Collections.Generic.IEnumerable<System.Double> dataB)
        {
            return MathNet.Numerics.Statistics.Correlation.Spearman(dataA, dataB);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> Statistics_Correlation_SpearmanMatrix_Internal(System.Double[][] vectors)
        {
            return MathNet.Numerics.Statistics.Correlation.SpearmanMatrix(vectors);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> Statistics_Correlation_SpearmanMatrix_Internal(System.Collections.Generic.IEnumerable<System.Double[]> vectors)
        {
            return MathNet.Numerics.Statistics.Correlation.SpearmanMatrix(vectors);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IComparer<MathNet.Numerics.Statistics.Bucket> Statistics_Bucket_DefaultPointComparer_Internal()
        {
            return MathNet.Numerics.Statistics.Bucket.DefaultPointComparer;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_InterquartileRange_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.InterquartileRange(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Statistics_Statistics_FiveNumberSummary_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.FiveNumberSummary(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single[] Statistics_Statistics_FiveNumberSummary_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.FiveNumberSummary(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Statistics_Statistics_FiveNumberSummary_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.FiveNumberSummary(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_OrderStatistic_Internal(System.Collections.Generic.IEnumerable<System.Double> data, System.Int32 order)
        {
            return MathNet.Numerics.Statistics.Statistics.OrderStatistic(data, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_Statistics_OrderStatistic_Internal(System.Collections.Generic.IEnumerable<System.Single> data, System.Int32 order)
        {
            return MathNet.Numerics.Statistics.Statistics.OrderStatistic(data, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Int32, System.Double> Statistics_Statistics_OrderStatisticFunc_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.OrderStatisticFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Int32, System.Single> Statistics_Statistics_OrderStatisticFunc_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.OrderStatisticFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Statistics_Statistics_Ranks_Internal(System.Collections.Generic.IEnumerable<System.Double> data, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.Ranks(data, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Statistics_Statistics_Ranks_Internal(System.Collections.Generic.IEnumerable<System.Single> data, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.Ranks(data, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Statistics_Statistics_Ranks_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.Ranks(data, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_QuantileRank_Internal(System.Collections.Generic.IEnumerable<System.Double> data, System.Double x, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileRank(data, x, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_QuantileRank_Internal(System.Collections.Generic.IEnumerable<System.Single> data, System.Single x, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileRank(data, x, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_QuantileRank_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data, System.Double x, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileRank(data, x, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Statistics_Statistics_QuantileRankFunc_Internal(System.Collections.Generic.IEnumerable<System.Double> data, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileRankFunc(data, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Single, System.Double> Statistics_Statistics_QuantileRankFunc_Internal(System.Collections.Generic.IEnumerable<System.Single> data, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileRankFunc(data, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Statistics_Statistics_QuantileRankFunc_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data, MathNet.Numerics.Statistics.RankDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileRankFunc(data, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_EmpiricalCDF_Internal(System.Collections.Generic.IEnumerable<System.Double> data, System.Double x)
        {
            return MathNet.Numerics.Statistics.Statistics.EmpiricalCDF(data, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_EmpiricalCDF_Internal(System.Collections.Generic.IEnumerable<System.Single> data, System.Single x)
        {
            return MathNet.Numerics.Statistics.Statistics.EmpiricalCDF(data, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_EmpiricalCDF_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data, System.Double x)
        {
            return MathNet.Numerics.Statistics.Statistics.EmpiricalCDF(data, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Statistics_Statistics_EmpiricalCDFFunc_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.EmpiricalCDFFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Single, System.Double> Statistics_Statistics_EmpiricalCDFFunc_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.EmpiricalCDFFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Statistics_Statistics_EmpiricalCDFFunc_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.EmpiricalCDFFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_EmpiricalInvCDF_Internal(System.Collections.Generic.IEnumerable<System.Double> data, System.Double tau)
        {
            return MathNet.Numerics.Statistics.Statistics.EmpiricalInvCDF(data, tau);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_Statistics_EmpiricalInvCDF_Internal(System.Collections.Generic.IEnumerable<System.Single> data, System.Double tau)
        {
            return MathNet.Numerics.Statistics.Statistics.EmpiricalInvCDF(data, tau);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_EmpiricalInvCDF_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data, System.Double tau)
        {
            return MathNet.Numerics.Statistics.Statistics.EmpiricalInvCDF(data, tau);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Statistics_Statistics_EmpiricalInvCDFFunc_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.EmpiricalInvCDFFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Single> Statistics_Statistics_EmpiricalInvCDFFunc_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.EmpiricalInvCDFFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Statistics_Statistics_EmpiricalInvCDFFunc_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.EmpiricalInvCDFFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Entropy_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Entropy(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Entropy_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Entropy(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Statistics_Statistics_MovingAverage_Internal(System.Collections.Generic.IEnumerable<System.Double> samples, System.Int32 windowSize)
        {
            return MathNet.Numerics.Statistics.Statistics.MovingAverage(samples, windowSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Minimum_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Minimum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_Statistics_Minimum_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Minimum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Minimum_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Minimum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Maximum_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Maximum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_Statistics_Maximum_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Maximum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Maximum_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Maximum(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_MinimumAbsolute_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.MinimumAbsolute(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_Statistics_MinimumAbsolute_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.MinimumAbsolute(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_MaximumAbsolute_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.MaximumAbsolute(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_Statistics_MaximumAbsolute_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.MaximumAbsolute(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Statistics_Statistics_MinimumMagnitudePhase_Internal(System.Collections.Generic.IEnumerable<System.Numerics.Complex> data)
        {
            return MathNet.Numerics.Statistics.Statistics.MinimumMagnitudePhase(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Statistics_Statistics_MinimumMagnitudePhase_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32> data)
        {
            return MathNet.Numerics.Statistics.Statistics.MinimumMagnitudePhase(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex Statistics_Statistics_MaximumMagnitudePhase_Internal(System.Collections.Generic.IEnumerable<System.Numerics.Complex> data)
        {
            return MathNet.Numerics.Statistics.Statistics.MaximumMagnitudePhase(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 Statistics_Statistics_MaximumMagnitudePhase_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32> data)
        {
            return MathNet.Numerics.Statistics.Statistics.MaximumMagnitudePhase(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Mean_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Mean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Mean_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Mean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Mean_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Mean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_GeometricMean_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.GeometricMean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_GeometricMean_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.GeometricMean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_HarmonicMean_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.HarmonicMean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_HarmonicMean_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.HarmonicMean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Variance_Internal(System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.Variance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Variance_Internal(System.Collections.Generic.IEnumerable<System.Single> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.Variance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Variance_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.Variance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_PopulationVariance_Internal(System.Collections.Generic.IEnumerable<System.Double> population)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationVariance(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_PopulationVariance_Internal(System.Collections.Generic.IEnumerable<System.Single> population)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationVariance(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_PopulationVariance_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> population)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationVariance(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_StandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.StandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_StandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Single> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.StandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_StandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.StandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_PopulationStandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Double> population)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationStandardDeviation(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_PopulationStandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Single> population)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationStandardDeviation(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_PopulationStandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> population)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationStandardDeviation(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Skewness_Internal(System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.Skewness(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Skewness_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.Skewness(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_PopulationSkewness_Internal(System.Collections.Generic.IEnumerable<System.Double> population)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationSkewness(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_PopulationSkewness_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> population)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationSkewness(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Kurtosis_Internal(System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.Kurtosis(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Kurtosis_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.Kurtosis(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_PopulationKurtosis_Internal(System.Collections.Generic.IEnumerable<System.Double> population)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationKurtosis(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_PopulationKurtosis_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> population)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationKurtosis(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_Statistics_MeanVariance_Internal(System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.MeanVariance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_Statistics_MeanVariance_Internal(System.Collections.Generic.IEnumerable<System.Single> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.MeanVariance(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_Statistics_MeanStandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.MeanStandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_Statistics_MeanStandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Single> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.MeanStandardDeviation(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_Statistics_SkewnessKurtosis_Internal(System.Collections.Generic.IEnumerable<System.Double> samples)
        {
            return MathNet.Numerics.Statistics.Statistics.SkewnessKurtosis(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> Statistics_Statistics_PopulationSkewnessKurtosis_Internal(System.Collections.Generic.IEnumerable<System.Double> population)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationSkewnessKurtosis(population);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Covariance_Internal(System.Collections.Generic.IEnumerable<System.Double> samples1, System.Collections.Generic.IEnumerable<System.Double> samples2)
        {
            return MathNet.Numerics.Statistics.Statistics.Covariance(samples1, samples2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Covariance_Internal(System.Collections.Generic.IEnumerable<System.Single> samples1, System.Collections.Generic.IEnumerable<System.Single> samples2)
        {
            return MathNet.Numerics.Statistics.Statistics.Covariance(samples1, samples2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Covariance_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> samples1, System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> samples2)
        {
            return MathNet.Numerics.Statistics.Statistics.Covariance(samples1, samples2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_PopulationCovariance_Internal(System.Collections.Generic.IEnumerable<System.Double> population1, System.Collections.Generic.IEnumerable<System.Double> population2)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationCovariance(population1, population2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_PopulationCovariance_Internal(System.Collections.Generic.IEnumerable<System.Single> population1, System.Collections.Generic.IEnumerable<System.Single> population2)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationCovariance(population1, population2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_PopulationCovariance_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> population1, System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> population2)
        {
            return MathNet.Numerics.Statistics.Statistics.PopulationCovariance(population1, population2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_RootMeanSquare_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.RootMeanSquare(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_RootMeanSquare_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.RootMeanSquare(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_RootMeanSquare_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.RootMeanSquare(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Median_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Median(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_Statistics_Median_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Median(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Median_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.Median(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Quantile_Internal(System.Collections.Generic.IEnumerable<System.Double> data, System.Double tau)
        {
            return MathNet.Numerics.Statistics.Statistics.Quantile(data, tau);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_Statistics_Quantile_Internal(System.Collections.Generic.IEnumerable<System.Single> data, System.Double tau)
        {
            return MathNet.Numerics.Statistics.Statistics.Quantile(data, tau);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Quantile_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data, System.Double tau)
        {
            return MathNet.Numerics.Statistics.Statistics.Quantile(data, tau);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Statistics_Statistics_QuantileFunc_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Single, System.Single> Statistics_Statistics_QuantileFunc_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Statistics_Statistics_QuantileFunc_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_QuantileCustom_Internal(System.Collections.Generic.IEnumerable<System.Double> data, System.Double tau, MathNet.Numerics.Statistics.QuantileDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileCustom(data, tau, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_Statistics_QuantileCustom_Internal(System.Collections.Generic.IEnumerable<System.Single> data, System.Double tau, MathNet.Numerics.Statistics.QuantileDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileCustom(data, tau, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_QuantileCustom_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data, System.Double tau, MathNet.Numerics.Statistics.QuantileDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileCustom(data, tau, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Statistics_Statistics_QuantileCustomFunc_Internal(System.Collections.Generic.IEnumerable<System.Double> data, MathNet.Numerics.Statistics.QuantileDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileCustomFunc(data, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Single, System.Single> Statistics_Statistics_QuantileCustomFunc_Internal(System.Collections.Generic.IEnumerable<System.Single> data, MathNet.Numerics.Statistics.QuantileDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileCustomFunc(data, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Double, System.Double> Statistics_Statistics_QuantileCustomFunc_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data, MathNet.Numerics.Statistics.QuantileDefinition definition)
        {
            return MathNet.Numerics.Statistics.Statistics.QuantileCustomFunc(data, definition);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Percentile_Internal(System.Collections.Generic.IEnumerable<System.Double> data, System.Int32 p)
        {
            return MathNet.Numerics.Statistics.Statistics.Percentile(data, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_Statistics_Percentile_Internal(System.Collections.Generic.IEnumerable<System.Single> data, System.Int32 p)
        {
            return MathNet.Numerics.Statistics.Statistics.Percentile(data, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_Percentile_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data, System.Int32 p)
        {
            return MathNet.Numerics.Statistics.Statistics.Percentile(data, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Int32, System.Double> Statistics_Statistics_PercentileFunc_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.PercentileFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Int32, System.Single> Statistics_Statistics_PercentileFunc_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.PercentileFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Func<System.Int32, System.Double> Statistics_Statistics_PercentileFunc_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.PercentileFunc(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_LowerQuartile_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.LowerQuartile(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_Statistics_LowerQuartile_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.LowerQuartile(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_LowerQuartile_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.LowerQuartile(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_UpperQuartile_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.UpperQuartile(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_Statistics_UpperQuartile_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.UpperQuartile(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_UpperQuartile_Internal(System.Collections.Generic.IEnumerable<System.Nullable<System.Double>> data)
        {
            return MathNet.Numerics.Statistics.Statistics.UpperQuartile(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Statistics_Statistics_InterquartileRange_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Statistics.Statistics.InterquartileRange(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single Statistics_Statistics_InterquartileRange_Internal(System.Collections.Generic.IEnumerable<System.Single> data)
        {
            return MathNet.Numerics.Statistics.Statistics.InterquartileRange(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] RootFinding_Broyden_FindRoot_Internal(System.Func<System.Double[], System.Double[]> f, System.Double[] initialGuess, System.Double accuracy, System.Int32 maxIterations)
        {
            return MathNet.Numerics.RootFinding.Broyden.FindRoot(f, initialGuess, accuracy, maxIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean RootFinding_Broyden_TryFindRoot_Internal(System.Func<System.Double[], System.Double[]> f, System.Double[] initialGuess, System.Double accuracy, System.Int32 maxIterations, out System.Double[] root)
        {
            return MathNet.Numerics.RootFinding.Broyden.TryFindRoot(f, initialGuess, accuracy, maxIterations,  out root);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double, System.Double> RootFinding_Cubic_RealRoots_Internal(System.Double a0, System.Double a1, System.Double a2)
        {
            return MathNet.Numerics.RootFinding.Cubic.RealRoots(a0, a1, a2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Numerics.Complex, System.Numerics.Complex, System.Numerics.Complex> RootFinding_Cubic_Roots_Internal(System.Double d, System.Double c, System.Double b, System.Double a)
        {
            return MathNet.Numerics.RootFinding.Cubic.Roots(d, c, b, a);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double RootFinding_NewtonRaphson_FindRoot_Internal(System.Func<System.Double, System.Double> f, System.Func<System.Double, System.Double> df, System.Double lowerBound, System.Double upperBound, System.Double accuracy, System.Int32 maxIterations)
        {
            return MathNet.Numerics.RootFinding.NewtonRaphson.FindRoot(f, df, lowerBound, upperBound, accuracy, maxIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double RootFinding_NewtonRaphson_FindRootNearGuess_Internal(System.Func<System.Double, System.Double> f, System.Func<System.Double, System.Double> df, System.Double initialGuess, System.Double lowerBound, System.Double upperBound, System.Double accuracy, System.Int32 maxIterations)
        {
            return MathNet.Numerics.RootFinding.NewtonRaphson.FindRootNearGuess(f, df, initialGuess, lowerBound, upperBound, accuracy, maxIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean RootFinding_NewtonRaphson_TryFindRoot_Internal(System.Func<System.Double, System.Double> f, System.Func<System.Double, System.Double> df, System.Double initialGuess, System.Double lowerBound, System.Double upperBound, System.Double accuracy, System.Int32 maxIterations, out System.Double root)
        {
            return MathNet.Numerics.RootFinding.NewtonRaphson.TryFindRoot(f, df, initialGuess, lowerBound, upperBound, accuracy, maxIterations,  out root);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double RootFinding_RobustNewtonRaphson_FindRoot_Internal(System.Func<System.Double, System.Double> f, System.Func<System.Double, System.Double> df, System.Double lowerBound, System.Double upperBound, System.Double accuracy, System.Int32 maxIterations, System.Int32 subdivision)
        {
            return MathNet.Numerics.RootFinding.RobustNewtonRaphson.FindRoot(f, df, lowerBound, upperBound, accuracy, maxIterations, subdivision);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean RootFinding_RobustNewtonRaphson_TryFindRoot_Internal(System.Func<System.Double, System.Double> f, System.Func<System.Double, System.Double> df, System.Double lowerBound, System.Double upperBound, System.Double accuracy, System.Int32 maxIterations, System.Int32 subdivision, out System.Double root)
        {
            return MathNet.Numerics.RootFinding.RobustNewtonRaphson.TryFindRoot(f, df, lowerBound, upperBound, accuracy, maxIterations, subdivision,  out root);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double RootFinding_Secant_FindRoot_Internal(System.Func<System.Double, System.Double> f, System.Double guess, System.Double secondGuess, System.Double lowerBound, System.Double upperBound, System.Double accuracy, System.Int32 maxIterations)
        {
            return MathNet.Numerics.RootFinding.Secant.FindRoot(f, guess, secondGuess, lowerBound, upperBound, accuracy, maxIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean RootFinding_Secant_TryFindRoot_Internal(System.Func<System.Double, System.Double> f, System.Double guess, System.Double secondGuess, System.Double lowerBound, System.Double upperBound, System.Double accuracy, System.Int32 maxIterations, out System.Double root)
        {
            return MathNet.Numerics.RootFinding.Secant.TryFindRoot(f, guess, secondGuess, lowerBound, upperBound, accuracy, maxIterations,  out root);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Tuple<System.Double, System.Double>> RootFinding_ZeroCrossingBracketing_FindIntervalsWithin_Internal(System.Func<System.Double, System.Double> f, System.Double lowerBound, System.Double upperBound, System.Int32 subdivisions)
        {
            return MathNet.Numerics.RootFinding.ZeroCrossingBracketing.FindIntervalsWithin(f, lowerBound, upperBound, subdivisions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean RootFinding_ZeroCrossingBracketing_Expand_Internal(System.Func<System.Double, System.Double> f, ref System.Double lowerBound, ref System.Double upperBound, System.Double factor, System.Int32 maxIterations)
        {
            return MathNet.Numerics.RootFinding.ZeroCrossingBracketing.Expand(f,  ref lowerBound,  ref upperBound, factor, maxIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean RootFinding_ZeroCrossingBracketing_Reduce_Internal(System.Func<System.Double, System.Double> f, ref System.Double lowerBound, ref System.Double upperBound, System.Int32 subdivisions)
        {
            return MathNet.Numerics.RootFinding.ZeroCrossingBracketing.Reduce(f,  ref lowerBound,  ref upperBound, subdivisions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean RootFinding_ZeroCrossingBracketing_ExpandReduce_Internal(System.Func<System.Double, System.Double> f, ref System.Double lowerBound, ref System.Double upperBound, System.Double expansionFactor, System.Int32 expansionMaxIterations, System.Int32 reduceSubdivisions)
        {
            return MathNet.Numerics.RootFinding.ZeroCrossingBracketing.ExpandReduce(f,  ref lowerBound,  ref upperBound, expansionFactor, expansionMaxIterations, reduceSubdivisions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double RootFinding_Brent_FindRootExpand_Internal(System.Func<System.Double, System.Double> f, System.Double guessLowerBound, System.Double guessUpperBound, System.Double accuracy, System.Int32 maxIterations, System.Double expandFactor, System.Int32 maxExpandIteratons)
        {
            return MathNet.Numerics.RootFinding.Brent.FindRootExpand(f, guessLowerBound, guessUpperBound, accuracy, maxIterations, expandFactor, maxExpandIteratons);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double RootFinding_Brent_FindRoot_Internal(System.Func<System.Double, System.Double> f, System.Double lowerBound, System.Double upperBound, System.Double accuracy, System.Int32 maxIterations)
        {
            return MathNet.Numerics.RootFinding.Brent.FindRoot(f, lowerBound, upperBound, accuracy, maxIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean RootFinding_Brent_TryFindRoot_Internal(System.Func<System.Double, System.Double> f, System.Double lowerBound, System.Double upperBound, System.Double accuracy, System.Int32 maxIterations, out System.Double root)
        {
            return MathNet.Numerics.RootFinding.Brent.TryFindRoot(f, lowerBound, upperBound, accuracy, maxIterations,  out root);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double RootFinding_Bisection_FindRootExpand_Internal(System.Func<System.Double, System.Double> f, System.Double guessLowerBound, System.Double guessUpperBound, System.Double accuracy, System.Int32 maxIterations, System.Double expandFactor, System.Int32 maxExpandIteratons)
        {
            return MathNet.Numerics.RootFinding.Bisection.FindRootExpand(f, guessLowerBound, guessUpperBound, accuracy, maxIterations, expandFactor, maxExpandIteratons);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double RootFinding_Bisection_FindRoot_Internal(System.Func<System.Double, System.Double> f, System.Double lowerBound, System.Double upperBound, System.Double accuracy, System.Int32 maxIterations)
        {
            return MathNet.Numerics.RootFinding.Bisection.FindRoot(f, lowerBound, upperBound, accuracy, maxIterations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean RootFinding_Bisection_TryFindRoot_Internal(System.Func<System.Double, System.Double> f, System.Double lowerBound, System.Double upperBound, System.Double accuracy, System.Int32 maxIterations, out System.Double root)
        {
            return MathNet.Numerics.RootFinding.Bisection.TryFindRoot(f, lowerBound, upperBound, accuracy, maxIterations,  out root);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Random.SystemRandomSource Random_SystemRandomSource_Default_Internal()
        {
            return MathNet.Numerics.Random.SystemRandomSource.Default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Random_SystemRandomSource_FastDoubles_Internal(System.Int32 length)
        {
            return MathNet.Numerics.Random.SystemRandomSource.FastDoubles(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Random_SystemRandomSource_DoubleSequence_0_Internal()
        {
            return MathNet.Numerics.Random.SystemRandomSource.DoubleSequence();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Random_SystemRandomSource_Doubles_Internal(System.Int32 length, System.Int32 seed)
        {
            return MathNet.Numerics.Random.SystemRandomSource.Doubles(length, seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Random_SystemRandomSource_DoubleSequence_1_Internal(System.Int32 seed)
        {
            return MathNet.Numerics.Random.SystemRandomSource.DoubleSequence(seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Random_RandomSeed_Time_Internal()
        {
            return MathNet.Numerics.Random.RandomSeed.Time();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Random_RandomSeed_Guid_Internal()
        {
            return MathNet.Numerics.Random.RandomSeed.Guid();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Random_RandomSeed_Robust_Internal()
        {
            return MathNet.Numerics.Random.RandomSeed.Robust();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Random_Mcg31m1_Doubles_Internal(System.Int32 length, System.Int32 seed)
        {
            return MathNet.Numerics.Random.Mcg31m1.Doubles(length, seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Random_Mcg31m1_DoubleSequence_Internal(System.Int32 seed)
        {
            return MathNet.Numerics.Random.Mcg31m1.DoubleSequence(seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Random_Mcg59_Doubles_Internal(System.Int32 length, System.Int32 seed)
        {
            return MathNet.Numerics.Random.Mcg59.Doubles(length, seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Random_Mcg59_DoubleSequence_Internal(System.Int32 seed)
        {
            return MathNet.Numerics.Random.Mcg59.DoubleSequence(seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Random.MersenneTwister Random_MersenneTwister_Default_Internal()
        {
            return MathNet.Numerics.Random.MersenneTwister.Default;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Random_MersenneTwister_Doubles_Internal(System.Int32 length, System.Int32 seed)
        {
            return MathNet.Numerics.Random.MersenneTwister.Doubles(length, seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Random_MersenneTwister_DoubleSequence_Internal(System.Int32 seed)
        {
            return MathNet.Numerics.Random.MersenneTwister.DoubleSequence(seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Random_Mrg32k3a_Doubles_Internal(System.Int32 length, System.Int32 seed)
        {
            return MathNet.Numerics.Random.Mrg32k3a.Doubles(length, seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Random_Mrg32k3a_DoubleSequence_Internal(System.Int32 seed)
        {
            return MathNet.Numerics.Random.Mrg32k3a.DoubleSequence(seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Random_Palf_Doubles_Internal(System.Int32 length, System.Int32 seed)
        {
            return MathNet.Numerics.Random.Palf.Doubles(length, seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Random_Palf_DoubleSequence_Internal(System.Int32 seed)
        {
            return MathNet.Numerics.Random.Palf.DoubleSequence(seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Random_CryptoRandomSource_Doubles_Internal(System.Int32 length)
        {
            return MathNet.Numerics.Random.CryptoRandomSource.Doubles(length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Random_CryptoRandomSource_DoubleSequence_Internal()
        {
            return MathNet.Numerics.Random.CryptoRandomSource.DoubleSequence();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Random_RandomExtensions_NextDoubles_Internal(System.Random rnd, System.Int32 count)
        {
            return MathNet.Numerics.Random.RandomExtensions.NextDoubles(rnd, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Random_RandomExtensions_NextDoubleSequence_Internal(System.Random rnd)
        {
            return MathNet.Numerics.Random.RandomExtensions.NextDoubleSequence(rnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Byte[] Random_RandomExtensions_NextBytes_Internal(System.Random rnd, System.Int32 count)
        {
            return MathNet.Numerics.Random.RandomExtensions.NextBytes(rnd, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Random_RandomExtensions_NextInt32Sequence_Internal(System.Random rnd, System.Int32 minInclusive, System.Int32 maxExclusive)
        {
            return MathNet.Numerics.Random.RandomExtensions.NextInt32Sequence(rnd, minInclusive, maxExclusive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int64 Random_RandomExtensions_NextInt64_Internal(System.Random rnd)
        {
            return MathNet.Numerics.Random.RandomExtensions.NextInt64(rnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Random_RandomExtensions_NextFullRangeInt32_Internal(System.Random rnd)
        {
            return MathNet.Numerics.Random.RandomExtensions.NextFullRangeInt32(rnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int64 Random_RandomExtensions_NextFullRangeInt64_Internal(System.Random rnd)
        {
            return MathNet.Numerics.Random.RandomExtensions.NextFullRangeInt64(rnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Decimal Random_RandomExtensions_NextDecimal_Internal(System.Random rnd)
        {
            return MathNet.Numerics.Random.RandomExtensions.NextDecimal(rnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Random_RandomExtensions_NextBoolean_Internal(System.Random rnd)
        {
            return MathNet.Numerics.Random.RandomExtensions.NextBoolean(rnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Random_WH1982_Doubles_Internal(System.Int32 length, System.Int32 seed)
        {
            return MathNet.Numerics.Random.WH1982.Doubles(length, seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Random_WH1982_DoubleSequence_Internal(System.Int32 seed)
        {
            return MathNet.Numerics.Random.WH1982.DoubleSequence(seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Random_WH2006_Doubles_Internal(System.Int32 length, System.Int32 seed)
        {
            return MathNet.Numerics.Random.WH2006.Doubles(length, seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Random_WH2006_DoubleSequence_Internal(System.Int32 seed)
        {
            return MathNet.Numerics.Random.WH2006.DoubleSequence(seed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Random_Xorshift_Doubles_Internal(System.Int32 length, System.Int32 seed, System.UInt64 a, System.UInt64 c, System.UInt64 x1, System.UInt64 x2)
        {
            return MathNet.Numerics.Random.Xorshift.Doubles(length, seed, a, c, x1, x2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Random_Xorshift_DoubleSequence_Internal(System.Int32 seed, System.UInt64 a, System.UInt64 c, System.UInt64 x1, System.UInt64 x2)
        {
            return MathNet.Numerics.Random.Xorshift.DoubleSequence(seed, a, c, x1, x2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Financial_AbsoluteReturnMeasures_CompoundMonthlyReturn_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Financial.AbsoluteReturnMeasures.CompoundMonthlyReturn(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Financial_AbsoluteReturnMeasures_CompoundReturn_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Financial.AbsoluteReturnMeasures.CompoundReturn(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Financial_AbsoluteReturnMeasures_GainMean_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Financial.AbsoluteReturnMeasures.GainMean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Financial_AbsoluteReturnMeasures_LossMean_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Financial.AbsoluteReturnMeasures.LossMean(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Financial_AbsoluteRiskMeasures_GainStandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Financial.AbsoluteRiskMeasures.GainStandardDeviation(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Financial_AbsoluteRiskMeasures_LossStandardDeviation_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Financial.AbsoluteRiskMeasures.LossStandardDeviation(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Financial_AbsoluteRiskMeasures_DownsideDeviation_Internal(System.Collections.Generic.IEnumerable<System.Double> data, System.Double minimalAcceptableReturn)
        {
            return MathNet.Numerics.Financial.AbsoluteRiskMeasures.DownsideDeviation(data, minimalAcceptableReturn);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Financial_AbsoluteRiskMeasures_SemiDeviation_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Financial.AbsoluteRiskMeasures.SemiDeviation(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Financial_AbsoluteRiskMeasures_GainLossRatio_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.Financial.AbsoluteRiskMeasures.GainLossRatio(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Providers_LinearAlgebra_LinearAlgebraControl_TryUseNativeMKL_Internal(MathNet.Numerics.Providers.Common.Mkl.MklConsistency consistency, MathNet.Numerics.Providers.Common.Mkl.MklPrecision precision, MathNet.Numerics.Providers.Common.Mkl.MklAccuracy accuracy)
        {
            return MathNet.Numerics.Providers.LinearAlgebra.LinearAlgebraControl.TryUseNativeMKL(consistency, precision, accuracy);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Providers_LinearAlgebra_LinearAlgebraControl_TryUseNativeCUDA_Internal()
        {
            return MathNet.Numerics.Providers.LinearAlgebra.LinearAlgebraControl.TryUseNativeCUDA();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Providers_LinearAlgebra_LinearAlgebraControl_TryUseNativeOpenBLAS_Internal()
        {
            return MathNet.Numerics.Providers.LinearAlgebra.LinearAlgebraControl.TryUseNativeOpenBLAS();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Providers_LinearAlgebra_LinearAlgebraControl_TryUseNative_Internal()
        {
            return MathNet.Numerics.Providers.LinearAlgebra.LinearAlgebraControl.TryUseNative();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Providers_FourierTransform_FourierTransformControl_TryUseNativeMKL_Internal()
        {
            return MathNet.Numerics.Providers.FourierTransform.FourierTransformControl.TryUseNativeMKL();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Providers_FourierTransform_FourierTransformControl_TryUseNative_Internal()
        {
            return MathNet.Numerics.Providers.FourierTransform.FourierTransformControl.TryUseNative();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_MemoryAllocation_Internal()
        {
            return MathNet.Numerics.Properties.Resources.MemoryAllocation;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_MoreThan2D_Internal()
        {
            return MathNet.Numerics.Properties.Resources.MoreThan2D;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_MustContainAtLeast_Internal()
        {
            return MathNet.Numerics.Properties.Resources.MustContainAtLeast;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_NameCannotContainASpace_Internal()
        {
            return MathNet.Numerics.Properties.Resources.NameCannotContainASpace;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_NotSupportedType_Internal()
        {
            return MathNet.Numerics.Properties.Resources.NotSupportedType;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_NumericalBreakdown_Internal()
        {
            return MathNet.Numerics.Properties.Resources.NumericalBreakdown;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_PartialOrderException_Internal()
        {
            return MathNet.Numerics.Properties.Resources.PartialOrderException;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_PermutationAsIntArrayInvalid_Internal()
        {
            return MathNet.Numerics.Properties.Resources.PermutationAsIntArrayInvalid;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ProposalDistributionNoUpperBound_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ProposalDistributionNoUpperBound;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_RegressionNotEnoughSamples_Internal()
        {
            return MathNet.Numerics.Properties.Resources.RegressionNotEnoughSamples;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_RootFindingFailed_Internal()
        {
            return MathNet.Numerics.Properties.Resources.RootFindingFailed;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_RootFindingFailedRecommendRobustNewtonRaphson_Internal()
        {
            return MathNet.Numerics.Properties.Resources.RootFindingFailedRecommendRobustNewtonRaphson;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_RootMustBeBracketedByBounds_Internal()
        {
            return MathNet.Numerics.Properties.Resources.RootMustBeBracketedByBounds;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_RootNotFound_Internal()
        {
            return MathNet.Numerics.Properties.Resources.RootNotFound;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_RowsLessThanColumns_Internal()
        {
            return MathNet.Numerics.Properties.Resources.RowsLessThanColumns;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_SampleVectorsSameLength_Internal()
        {
            return MathNet.Numerics.Properties.Resources.SampleVectorsSameLength;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_SingularUMatrix_Internal()
        {
            return MathNet.Numerics.Properties.Resources.SingularUMatrix;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_SingularUMatrixWithElement_Internal()
        {
            return MathNet.Numerics.Properties.Resources.SingularUMatrixWithElement;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_SingularVectorsNotComputed_Internal()
        {
            return MathNet.Numerics.Properties.Resources.SingularVectorsNotComputed;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_SpecialCasePlannedButNotImplementedYet_Internal()
        {
            return MathNet.Numerics.Properties.Resources.SpecialCasePlannedButNotImplementedYet;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_StopCriterionDuplicate_Internal()
        {
            return MathNet.Numerics.Properties.Resources.StopCriterionDuplicate;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_StopCriterionMissing_Internal()
        {
            return MathNet.Numerics.Properties.Resources.StopCriterionMissing;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_StringNullOrEmpty_Internal()
        {
            return MathNet.Numerics.Properties.Resources.StringNullOrEmpty;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_TooManyElements_Internal()
        {
            return MathNet.Numerics.Properties.Resources.TooManyElements;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_UndefinedMoment_Internal()
        {
            return MathNet.Numerics.Properties.Resources.UndefinedMoment;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_UserDefinedProviderNotSpecified_Internal()
        {
            return MathNet.Numerics.Properties.Resources.UserDefinedProviderNotSpecified;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_UserWorkBufferNotSupported_Internal()
        {
            return MathNet.Numerics.Properties.Resources.UserWorkBufferNotSupported;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_VectorCanNotBeEmpty_Internal()
        {
            return MathNet.Numerics.Properties.Resources.VectorCanNotBeEmpty;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_WorkArrayTooSmall_Internal()
        {
            return MathNet.Numerics.Properties.Resources.WorkArrayTooSmall;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Resources.ResourceManager Properties_Resources_ResourceManager_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ResourceManager;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Globalization.CultureInfo Properties_Resources_Culture_Internal()
        {
            return MathNet.Numerics.Properties.Resources.Culture;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_AccuracyNotReached_Internal()
        {
            return MathNet.Numerics.Properties.Resources.AccuracyNotReached;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentArraysSameLength_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentArraysSameLength;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentArrayWrongLength_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentArrayWrongLength;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentBetween0And1_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentBetween0And1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentCannotBeBetweenOneAndNegativeOne_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentCannotBeBetweenOneAndNegativeOne;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentEven_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentEven;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentHistogramContainsNot_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentHistogramContainsNot;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentInIntervalXYInclusive_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentInIntervalXYInclusive;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentItemNull_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentItemNull;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentLessThanOne_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentLessThanOne;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixDimensions_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixDimensions;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixDimensions1_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixDimensions1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixDimensions2_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixDimensions2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixDimensions3_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixDimensions3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixDoesNotExist_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixDoesNotExist;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixIndexOutOfRange_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixIndexOutOfRange;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixNotRankDeficient_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixNotRankDeficient;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixNotSingular_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixNotSingular;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixPositiveDefinite_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixPositiveDefinite;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixSameColumnDimension_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixSameColumnDimension;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixSameRowDimension_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixSameRowDimension;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixSingleColumn_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixSingleColumn;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixSingleColumnRow_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixSingleColumnRow;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixSingleRow_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixSingleRow;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixSquare_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixSquare;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixSymmetric_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixSymmetric;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMatrixSymmetricPositiveDefinite_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMatrixSymmetricPositiveDefinite;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMaxExclusiveMustBeLargerThanMinInclusive_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMaxExclusiveMustBeLargerThanMinInclusive;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMinValueGreaterThanMaxValue_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMinValueGreaterThanMaxValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentMustBePositive_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentMustBePositive;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentNotInfinityNaN_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentNotInfinityNaN;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentNotNegative_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentNotNegative;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentNull_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentNull;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentOdd_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentOdd;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentOutOfRangeGreater_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentOutOfRangeGreater;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentOutOfRangeGreaterEqual_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentOutOfRangeGreaterEqual;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentOutOfRangeSmaller_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentOutOfRangeSmaller;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentOutOfRangeSmallerEqual_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentOutOfRangeSmallerEqual;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentParameterSetInvalid_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentParameterSetInvalid;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentParseComplexNumber_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentParseComplexNumber;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentPositive_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentPositive;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentPowerOfTwo_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentPowerOfTwo;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentPowerOfTwoEveryDimension_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentPowerOfTwoEveryDimension;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentRangeLessEqual_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentRangeLessEqual;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentReferenceDifferent_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentReferenceDifferent;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentSingleDimensionArray_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentSingleDimensionArray;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentTooLarge_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentTooLarge;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentTooLargeForIterationLimit_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentTooLargeForIterationLimit;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentTypeMismatch_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentTypeMismatch;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentUpperBoundMustBeLargerThanLowerBound_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentUpperBoundMustBeLargerThanLowerBound;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentUpperBoundMustBeLargerThanOrEqualToLowerBound_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentUpperBoundMustBeLargerThanOrEqualToLowerBound;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentVectorLengthsMultipleOf_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentVectorLengthsMultipleOf;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentVectorsSameLength_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentVectorsSameLength;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArgumentVectorThreeDimensional_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArgumentVectorThreeDimensional;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ArrayTooSmall_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ArrayTooSmall;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_BigEndianNotSupported_Internal()
        {
            return MathNet.Numerics.Properties.Resources.BigEndianNotSupported;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_CollectionEmpty_Internal()
        {
            return MathNet.Numerics.Properties.Resources.CollectionEmpty;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ComplexMatricesNotSupported_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ComplexMatricesNotSupported;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_ConvergenceFailed_Internal()
        {
            return MathNet.Numerics.Properties.Resources.ConvergenceFailed;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_DegreesOfFreedomMustBeLessThanSampleSize_Internal()
        {
            return MathNet.Numerics.Properties.Resources.DegreesOfFreedomMustBeLessThanSampleSize;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_FeaturePlannedButNotImplementedYet_Internal()
        {
            return MathNet.Numerics.Properties.Resources.FeaturePlannedButNotImplementedYet;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_FileDoesNotExist_Internal()
        {
            return MathNet.Numerics.Properties.Resources.FileDoesNotExist;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_Interpolation_Initialize_SamplePointsNotStrictlyAscendingOrder_Internal()
        {
            return MathNet.Numerics.Properties.Resources.Interpolation_Initialize_SamplePointsNotStrictlyAscendingOrder;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_Interpolation_Initialize_SamplePointsNotUnique_Internal()
        {
            return MathNet.Numerics.Properties.Resources.Interpolation_Initialize_SamplePointsNotUnique;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_InvalidDistributionParameters_Internal()
        {
            return MathNet.Numerics.Properties.Resources.InvalidDistributionParameters;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_InvalidLeftBoundaryCondition_Internal()
        {
            return MathNet.Numerics.Properties.Resources.InvalidLeftBoundaryCondition;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_InvalidOperationAccumulatorEmpty_Internal()
        {
            return MathNet.Numerics.Properties.Resources.InvalidOperationAccumulatorEmpty;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_InvalidOperationHistogramEmpty_Internal()
        {
            return MathNet.Numerics.Properties.Resources.InvalidOperationHistogramEmpty;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_InvalidOperationHistogramNotEnoughPoints_Internal()
        {
            return MathNet.Numerics.Properties.Resources.InvalidOperationHistogramNotEnoughPoints;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_InvalidOperationNoSamplesProvided_Internal()
        {
            return MathNet.Numerics.Properties.Resources.InvalidOperationNoSamplesProvided;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_InvalidParameter_Internal()
        {
            return MathNet.Numerics.Properties.Resources.InvalidParameter;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_InvalidParameterWithNumber_Internal()
        {
            return MathNet.Numerics.Properties.Resources.InvalidParameterWithNumber;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_InvalidRightBoundaryCondition_Internal()
        {
            return MathNet.Numerics.Properties.Resources.InvalidRightBoundaryCondition;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_LagMustBePositive_Internal()
        {
            return MathNet.Numerics.Properties.Resources.LagMustBePositive;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_LagMustBeSmallerThanTheSampleSize_Internal()
        {
            return MathNet.Numerics.Properties.Resources.LagMustBeSmallerThanTheSampleSize;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_MatlabDateHeaderFormat_Internal()
        {
            return MathNet.Numerics.Properties.Resources.MatlabDateHeaderFormat;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_MatrixCanNotBeEmpty_Internal()
        {
            return MathNet.Numerics.Properties.Resources.MatrixCanNotBeEmpty;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_MatrixColumnsMustBePositive_Internal()
        {
            return MathNet.Numerics.Properties.Resources.MatrixColumnsMustBePositive;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_MatrixMustBeSparse_Internal()
        {
            return MathNet.Numerics.Properties.Resources.MatrixMustBeSparse;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_MatrixRowsMustBePositive_Internal()
        {
            return MathNet.Numerics.Properties.Resources.MatrixRowsMustBePositive;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.String Properties_Resources_MatrixRowsOrColumnsMustBePositive_Internal()
        {
            return MathNet.Numerics.Properties.Resources.MatrixRowsOrColumnsMustBePositive;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] OdeSolvers_AdamsBashforth_FirstOrder_Internal(System.Double y0, System.Double start, System.Double end, System.Int32 N, System.Func<System.Double, System.Double, System.Double> f)
        {
            return MathNet.Numerics.OdeSolvers.AdamsBashforth.FirstOrder(y0, start, end, N, f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] OdeSolvers_AdamsBashforth_SecondOrder_Internal(System.Double y0, System.Double start, System.Double end, System.Int32 N, System.Func<System.Double, System.Double, System.Double> f)
        {
            return MathNet.Numerics.OdeSolvers.AdamsBashforth.SecondOrder(y0, start, end, N, f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] OdeSolvers_AdamsBashforth_ThirdOrder_Internal(System.Double y0, System.Double start, System.Double end, System.Int32 N, System.Func<System.Double, System.Double, System.Double> f)
        {
            return MathNet.Numerics.OdeSolvers.AdamsBashforth.ThirdOrder(y0, start, end, N, f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] OdeSolvers_AdamsBashforth_FourthOrder_Internal(System.Double y0, System.Double start, System.Double end, System.Int32 N, System.Func<System.Double, System.Double, System.Double> f)
        {
            return MathNet.Numerics.OdeSolvers.AdamsBashforth.FourthOrder(y0, start, end, N, f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] OdeSolvers_RungeKutta_SecondOrder_Internal(System.Double y0, System.Double start, System.Double end, System.Int32 N, System.Func<System.Double, System.Double, System.Double> f)
        {
            return MathNet.Numerics.OdeSolvers.RungeKutta.SecondOrder(y0, start, end, N, f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] OdeSolvers_RungeKutta_FourthOrder_Internal(System.Double y0, System.Double start, System.Double end, System.Int32 N, System.Func<System.Double, System.Double, System.Double> f)
        {
            return MathNet.Numerics.OdeSolvers.RungeKutta.FourthOrder(y0, start, end, N, f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double>[] OdeSolvers_RungeKutta_SecondOrder_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> y0, System.Double start, System.Double end, System.Int32 N, System.Func<System.Double, MathNet.Numerics.LinearAlgebra.Vector<System.Double>, MathNet.Numerics.LinearAlgebra.Vector<System.Double>> f)
        {
            return MathNet.Numerics.OdeSolvers.RungeKutta.SecondOrder(y0, start, end, N, f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double>[] OdeSolvers_RungeKutta_FourthOrder_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> y0, System.Double start, System.Double end, System.Int32 N, System.Func<System.Double, MathNet.Numerics.LinearAlgebra.Vector<System.Double>, MathNet.Numerics.LinearAlgebra.Vector<System.Double>> f)
        {
            return MathNet.Numerics.OdeSolvers.RungeKutta.FourthOrder(y0, start, end, N, f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double LinearRegression_WeightedRegression_GaussianKernel_Internal(System.Double normalizedDistance)
        {
            return MathNet.Numerics.LinearRegression.WeightedRegression.GaussianKernel(normalizedDistance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> LinearRegression_SimpleRegression_Fit_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.LinearRegression.SimpleRegression.Fit(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Tuple<System.Double, System.Double> LinearRegression_SimpleRegression_Fit_Internal(System.Collections.Generic.IEnumerable<System.Tuple<System.Double, System.Double>> samples)
        {
            return MathNet.Numerics.LinearRegression.SimpleRegression.Fit(samples);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Single> LinearAlgebra_MatrixExtensions_ToSingle_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.MatrixExtensions.ToSingle(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_MatrixExtensions_ToDouble_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Single> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.MatrixExtensions.ToDouble(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<MathNet.Numerics.Complex32> LinearAlgebra_MatrixExtensions_ToComplex32_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Numerics.Complex> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.MatrixExtensions.ToComplex32(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Numerics.Complex> LinearAlgebra_MatrixExtensions_ToComplex_Internal(MathNet.Numerics.LinearAlgebra.Matrix<MathNet.Numerics.Complex32> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.MatrixExtensions.ToComplex(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<MathNet.Numerics.Complex32> LinearAlgebra_MatrixExtensions_ToComplex32_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Single> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.MatrixExtensions.ToComplex32(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Numerics.Complex> LinearAlgebra_MatrixExtensions_ToComplex_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.MatrixExtensions.ToComplex(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_MatrixExtensions_Real_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Numerics.Complex> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.MatrixExtensions.Real(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Single> LinearAlgebra_MatrixExtensions_Real_Internal(MathNet.Numerics.LinearAlgebra.Matrix<MathNet.Numerics.Complex32> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.MatrixExtensions.Real(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_MatrixExtensions_Imaginary_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Numerics.Complex> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.MatrixExtensions.Imaginary(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Single> LinearAlgebra_MatrixExtensions_Imaginary_Internal(MathNet.Numerics.LinearAlgebra.Matrix<MathNet.Numerics.Complex32> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.MatrixExtensions.Imaginary(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Single> LinearAlgebra_VectorExtensions_ToSingle_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> vector)
        {
            return MathNet.Numerics.LinearAlgebra.VectorExtensions.ToSingle(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_VectorExtensions_ToDouble_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Single> vector)
        {
            return MathNet.Numerics.LinearAlgebra.VectorExtensions.ToDouble(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32> LinearAlgebra_VectorExtensions_ToComplex32_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> vector)
        {
            return MathNet.Numerics.LinearAlgebra.VectorExtensions.ToComplex32(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> LinearAlgebra_VectorExtensions_ToComplex_Internal(MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32> vector)
        {
            return MathNet.Numerics.LinearAlgebra.VectorExtensions.ToComplex(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32> LinearAlgebra_VectorExtensions_ToComplex32_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Single> vector)
        {
            return MathNet.Numerics.LinearAlgebra.VectorExtensions.ToComplex32(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> LinearAlgebra_VectorExtensions_ToComplex_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> vector)
        {
            return MathNet.Numerics.LinearAlgebra.VectorExtensions.ToComplex(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_VectorExtensions_Real_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> vector)
        {
            return MathNet.Numerics.LinearAlgebra.VectorExtensions.Real(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Single> LinearAlgebra_VectorExtensions_Real_Internal(MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32> vector)
        {
            return MathNet.Numerics.LinearAlgebra.VectorExtensions.Real(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_VectorExtensions_Imaginary_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> vector)
        {
            return MathNet.Numerics.LinearAlgebra.VectorExtensions.Imaginary(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Single> LinearAlgebra_VectorExtensions_Imaginary_Internal(MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32> vector)
        {
            return MathNet.Numerics.LinearAlgebra.VectorExtensions.Imaginary(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_UnaryPlus_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> rightSide)
        {
            return +rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> leftSide, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> leftSide, System.Double rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Addition_Internal(System.Double leftSide, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> leftSide, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> leftSide, System.Double rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Subtraction_Internal(System.Double leftSide, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> leftSide, System.Double rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Multiply_Internal(System.Double leftSide, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> leftSide, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Matrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> leftSide, MathNet.Numerics.LinearAlgebra.Vector<System.Double> rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Matrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> leftSide, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Division_Internal(System.Double dividend, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> divisor)
        {
            return dividend / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Division_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> dividend, System.Double divisor)
        {
            return dividend / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> dividend, System.Double divisor)
        {
            return dividend % divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Modulus_Internal(System.Double dividend, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> divisor)
        {
            return dividend % divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> dividend, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> divisor)
        {
            return dividend % divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_DotMultiply_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> y)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.op_DotMultiply(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_DotDivide_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> dividend, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> divisor)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.op_DotDivide(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_DotPercent_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> dividend, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> divisor)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.op_DotPercent(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_DotHat_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> matrix, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> exponent)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.op_DotHat(matrix, exponent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_op_DotHat_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> matrix, System.Double exponent)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.op_DotHat(matrix, exponent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Sqrt_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Sqrt(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Exp_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Exp(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Log_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Log(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Log10_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Log10(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Sin_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Sin(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Cos_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Cos(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Tan_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Tan(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Asin_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Asin(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Acos_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Acos(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Atan_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Atan(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Sinh_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Sinh(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Cosh_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Cosh(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Tanh_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Tanh(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Abs_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Abs(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Floor_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Floor(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Ceiling_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Ceiling(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Matrix_Round_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Matrix<System.Double>.Round(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Log_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Log(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Log10_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Log10(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Sin_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Sin(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Cos_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Cos(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Tan_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Tan(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Asin_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Asin(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Acos_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Acos(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Atan_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Atan(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Sinh_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Sinh(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Cosh_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Cosh(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Tanh_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Tanh(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Abs_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Abs(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Floor_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Floor(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Ceiling_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Ceiling(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Round_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Round(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> LinearAlgebra_Vector_OuterProduct_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> u, MathNet.Numerics.LinearAlgebra.Vector<System.Double> v)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.OuterProduct(u, v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_UnaryPlus_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> rightSide)
        {
            return +rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> leftSide, MathNet.Numerics.LinearAlgebra.Vector<System.Double> rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> leftSide, System.Double rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Addition_Internal(System.Double leftSide, MathNet.Numerics.LinearAlgebra.Vector<System.Double> rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> leftSide, MathNet.Numerics.LinearAlgebra.Vector<System.Double> rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> leftSide, System.Double rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Subtraction_Internal(System.Double leftSide, MathNet.Numerics.LinearAlgebra.Vector<System.Double> rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> leftSide, System.Double rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Multiply_Internal(System.Double leftSide, MathNet.Numerics.LinearAlgebra.Vector<System.Double> rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double LinearAlgebra_Vector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> leftSide, MathNet.Numerics.LinearAlgebra.Vector<System.Double> rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Division_Internal(System.Double dividend, MathNet.Numerics.LinearAlgebra.Vector<System.Double> divisor)
        {
            return dividend / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Division_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> dividend, System.Double divisor)
        {
            return dividend / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Division_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> dividend, MathNet.Numerics.LinearAlgebra.Vector<System.Double> divisor)
        {
            return dividend / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> dividend, System.Double divisor)
        {
            return dividend % divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Modulus_Internal(System.Double dividend, MathNet.Numerics.LinearAlgebra.Vector<System.Double> divisor)
        {
            return dividend % divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> dividend, MathNet.Numerics.LinearAlgebra.Vector<System.Double> divisor)
        {
            return dividend % divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_DotMultiply_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x, MathNet.Numerics.LinearAlgebra.Vector<System.Double> y)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.op_DotMultiply(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_DotDivide_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> dividend, MathNet.Numerics.LinearAlgebra.Vector<System.Double> divisor)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.op_DotDivide(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_DotPercent_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> dividend, MathNet.Numerics.LinearAlgebra.Vector<System.Double> divisor)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.op_DotPercent(dividend, divisor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_DotHat_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> vector, MathNet.Numerics.LinearAlgebra.Vector<System.Double> exponent)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.op_DotHat(vector, exponent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_op_DotHat_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> vector, System.Double exponent)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.op_DotHat(vector, exponent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Sqrt_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Sqrt(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Double> LinearAlgebra_Vector_Exp_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> x)
        {
            return MathNet.Numerics.LinearAlgebra.Vector<System.Double>.Exp(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<System.Double> LinearAlgebra_Storage_SparseVectorStorage_OfVector_Internal(MathNet.Numerics.LinearAlgebra.Storage.VectorStorage<System.Double> vector)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<System.Double>.OfVector(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<System.Double> LinearAlgebra_Storage_SparseVectorStorage_OfValue_Internal(System.Int32 length, System.Double value)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<System.Double>.OfValue(length, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<System.Double> LinearAlgebra_Storage_SparseVectorStorage_OfInit_Internal(System.Int32 length, System.Func<System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<System.Double>.OfInit(length, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<System.Double> LinearAlgebra_Storage_SparseVectorStorage_OfEnumerable_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<System.Double>.OfEnumerable(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<System.Double> LinearAlgebra_Storage_SparseVectorStorage_OfIndexedEnumerable_Internal(System.Int32 length, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseVectorStorage<System.Double>.OfIndexedEnumerable(length, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseVectorStorage<System.Double> LinearAlgebra_Storage_DenseVectorStorage_OfVector_Internal(MathNet.Numerics.LinearAlgebra.Storage.VectorStorage<System.Double> vector)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseVectorStorage<System.Double>.OfVector(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseVectorStorage<System.Double> LinearAlgebra_Storage_DenseVectorStorage_OfValue_Internal(System.Int32 length, System.Double value)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseVectorStorage<System.Double>.OfValue(length, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseVectorStorage<System.Double> LinearAlgebra_Storage_DenseVectorStorage_OfInit_Internal(System.Int32 length, System.Func<System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseVectorStorage<System.Double>.OfInit(length, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseVectorStorage<System.Double> LinearAlgebra_Storage_DenseVectorStorage_OfEnumerable_Internal(System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseVectorStorage<System.Double>.OfEnumerable(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseVectorStorage<System.Double> LinearAlgebra_Storage_DenseVectorStorage_OfIndexedEnumerable_Internal(System.Int32 length, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseVectorStorage<System.Double>.OfIndexedEnumerable(length, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Storage.MatrixStorage<System.Double> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfValue_Internal(System.Int32 rows, System.Int32 columns, System.Double value)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfValue(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfInit_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfInit(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfDiagonalInit_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfDiagonalInit(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfArray_Internal(System.Double[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfColumnArrays_Internal(System.Double[][] data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfColumnArrays(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfRowArrays_Internal(System.Double[][] data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfRowArrays(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfColumnMajorArray_Internal(System.Int32 rows, System.Int32 columns, System.Double[] data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfColumnMajorArray(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfRowMajorArray_Internal(System.Int32 rows, System.Int32 columns, System.Double[] data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfRowMajorArray(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfColumnVectors_Internal(MathNet.Numerics.LinearAlgebra.Storage.VectorStorage<System.Double>[] data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfColumnVectors(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfRowVectors_Internal(MathNet.Numerics.LinearAlgebra.Storage.VectorStorage<System.Double>[] data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfRowVectors(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfIndexedEnumerable_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Int32, System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfIndexedEnumerable(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfColumnMajorEnumerable_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfColumnMajorEnumerable(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfRowMajorEnumerable_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfRowMajorEnumerable(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfColumnEnumerables_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfColumnEnumerables(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double> LinearAlgebra_Storage_DenseColumnMajorMatrixStorage_OfRowEnumerables_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DenseColumnMajorMatrixStorage<System.Double>.OfRowEnumerables(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Storage.MatrixStorage<System.Double> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfValue_Internal(System.Int32 rows, System.Int32 columns, System.Double value)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfValue(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfInit_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfInit(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfDiagonalInit_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfDiagonalInit(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfArray_Internal(System.Double[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfRowArrays_Internal(System.Double[][] data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfRowArrays(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfColumnArrays_Internal(System.Double[][] data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfColumnArrays(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfRowVectors_Internal(MathNet.Numerics.LinearAlgebra.Storage.VectorStorage<System.Double>[] data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfRowVectors(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfColumnVectors_Internal(MathNet.Numerics.LinearAlgebra.Storage.VectorStorage<System.Double>[] data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfColumnVectors(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfIndexedEnumerable_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Int32, System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfIndexedEnumerable(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfRowEnumerables_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfRowEnumerables(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfColumnEnumerables_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfColumnEnumerables(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfRowMajorEnumerable_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfRowMajorEnumerable(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double> LinearAlgebra_Storage_SparseCompressedRowMatrixStorage_OfColumnMajorList_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IList<System.Double> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.SparseCompressedRowMatrixStorage<System.Double>.OfColumnMajorList(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DiagonalMatrixStorage<System.Double> LinearAlgebra_Storage_DiagonalMatrixStorage_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Storage.MatrixStorage<System.Double> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DiagonalMatrixStorage<System.Double>.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DiagonalMatrixStorage<System.Double> LinearAlgebra_Storage_DiagonalMatrixStorage_OfArray_Internal(System.Double[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DiagonalMatrixStorage<System.Double>.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DiagonalMatrixStorage<System.Double> LinearAlgebra_Storage_DiagonalMatrixStorage_OfValue_Internal(System.Int32 rows, System.Int32 columns, System.Double diagonalValue)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DiagonalMatrixStorage<System.Double>.OfValue(rows, columns, diagonalValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DiagonalMatrixStorage<System.Double> LinearAlgebra_Storage_DiagonalMatrixStorage_OfInit_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DiagonalMatrixStorage<System.Double>.OfInit(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DiagonalMatrixStorage<System.Double> LinearAlgebra_Storage_DiagonalMatrixStorage_OfEnumerable_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Double> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DiagonalMatrixStorage<System.Double>.OfEnumerable(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Storage.DiagonalMatrixStorage<System.Double> LinearAlgebra_Storage_DiagonalMatrixStorage_OfIndexedEnumerable_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Storage.DiagonalMatrixStorage<System.Double>.OfIndexedEnumerable(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Matrix<MathNet.Numerics.Complex32> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfArray_Internal(MathNet.Numerics.Complex32[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfIndexed_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Int32, MathNet.Numerics.Complex32>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfIndexed(rows, columns, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfColumnMajor_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32> columnMajor)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfColumnMajor(rows, columns, columnMajor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfColumns_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfColumns(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfColumns_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfColumns(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfColumnArrays_Internal(MathNet.Numerics.Complex32[][] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfColumnArrays_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32[]> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfColumnVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32>[] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfColumnVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32>> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfRows_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfRows(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfRows_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfRows(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfRowArrays_Internal(MathNet.Numerics.Complex32[][] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfRowArrays_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32[]> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfRowVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32>[] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfRowVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32>> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfDiagonalVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfDiagonalVector(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfDiagonalVector_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfDiagonalVector(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfDiagonalArray_Internal(MathNet.Numerics.Complex32[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfDiagonalArray(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_OfDiagonalArray_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Complex32[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.OfDiagonalArray(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.Create(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Int32, MathNet.Numerics.Complex32> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.Create(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.CreateDiagonal(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, MathNet.Numerics.Complex32> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.CreateDiagonal(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_CreateIdentity_Internal(System.Int32 order)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.CreateIdentity(order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_CreateRandom_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix.CreateRandom(rows, columns, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_op_UnaryPlus_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix rightSide)
        {
            return +rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix leftSide, MathNet.Numerics.Complex32 rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.Complex32 leftSide, MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex32.DenseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix LinearAlgebra_Complex32_DenseMatrix_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseMatrix leftSide, MathNet.Numerics.Complex32 rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix LinearAlgebra_Complex32_DiagonalMatrix_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Matrix<MathNet.Numerics.Complex32> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix LinearAlgebra_Complex32_DiagonalMatrix_OfArray_Internal(MathNet.Numerics.Complex32[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix LinearAlgebra_Complex32_DiagonalMatrix_OfIndexedDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, MathNet.Numerics.Complex32>> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix.OfIndexedDiagonal(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix LinearAlgebra_Complex32_DiagonalMatrix_OfDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix.OfDiagonal(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix LinearAlgebra_Complex32_DiagonalMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, MathNet.Numerics.Complex32> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix.Create(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix LinearAlgebra_Complex32_DiagonalMatrix_CreateIdentity_Internal(System.Int32 order)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix.CreateIdentity(order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix LinearAlgebra_Complex32_DiagonalMatrix_CreateRandom_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DiagonalMatrix.CreateRandom(rows, columns, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Matrix<MathNet.Numerics.Complex32> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfArray_Internal(MathNet.Numerics.Complex32[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfIndexed_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Int32, MathNet.Numerics.Complex32>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfIndexed(rows, columns, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfRowMajor_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32> rowMajor)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfRowMajor(rows, columns, rowMajor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfColumnMajor_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IList<MathNet.Numerics.Complex32> columnMajor)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfColumnMajor(rows, columns, columnMajor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfColumns_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfColumns(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfColumns_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfColumns(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfColumnArrays_Internal(MathNet.Numerics.Complex32[][] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfColumnArrays_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32[]> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfColumnVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32>[] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfColumnVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32>> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfRows_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfRows(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfRows_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfRows(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfRowArrays_Internal(MathNet.Numerics.Complex32[][] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfRowArrays_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32[]> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfRowVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32>[] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfRowVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32>> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfDiagonalVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfDiagonalVector(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfDiagonalVector_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfDiagonalVector(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfDiagonalArray_Internal(MathNet.Numerics.Complex32[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfDiagonalArray(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_OfDiagonalArray_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Complex32[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.OfDiagonalArray(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.Create(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Int32, MathNet.Numerics.Complex32> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.Create(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.CreateDiagonal(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, MathNet.Numerics.Complex32> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.CreateDiagonal(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_CreateIdentity_Internal(System.Int32 order)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix.CreateIdentity(order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_op_UnaryPlus_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix rightSide)
        {
            return +rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix leftSide, MathNet.Numerics.Complex32 rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.Complex32 leftSide, MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex32.SparseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix LinearAlgebra_Complex32_SparseMatrix_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseMatrix leftSide, MathNet.Numerics.Complex32 rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_OfVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32> vector)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseVector.OfVector(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_OfArray_Internal(MathNet.Numerics.Complex32[] array)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseVector.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_OfEnumerable_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseVector.OfEnumerable(enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_OfIndexedEnumerable_Internal(System.Int32 length, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, MathNet.Numerics.Complex32>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseVector.OfIndexedEnumerable(length, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_Create_Internal(System.Int32 length, MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseVector.Create(length, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_Create_Internal(System.Int32 length, System.Func<System.Int32, MathNet.Numerics.Complex32> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseVector.Create(length, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_CreateRandom_Internal(System.Int32 length, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseVector.CreateRandom(length, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32[] LinearAlgebra_Complex32_DenseVector_op_Explicit_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseVector vector)
        {
            return (MathNet.Numerics.Complex32[])vector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_op_Implicit_Internal(MathNet.Numerics.Complex32[] array)
        {
            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex32.DenseVector rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseVector rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex32.DenseVector rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseVector leftSide, MathNet.Numerics.Complex32 rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_op_Multiply_Internal(MathNet.Numerics.Complex32 leftSide, MathNet.Numerics.LinearAlgebra.Complex32.DenseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 LinearAlgebra_Complex32_DenseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex32.DenseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_op_Division_Internal(MathNet.Numerics.LinearAlgebra.Complex32.DenseVector leftSide, MathNet.Numerics.Complex32 rightSide)
        {
            return leftSide / rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.DenseVector LinearAlgebra_Complex32_DenseVector_Parse_Internal(System.String value, System.IFormatProvider formatProvider)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseVector.Parse(value, formatProvider);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Complex32_DenseVector_TryParse_Internal(System.String value, out MathNet.Numerics.LinearAlgebra.Complex32.DenseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseVector.TryParse(value,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Complex32_DenseVector_TryParse_Internal(System.String value, System.IFormatProvider formatProvider, out MathNet.Numerics.LinearAlgebra.Complex32.DenseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.DenseVector.TryParse(value, formatProvider,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseVector_OfVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<MathNet.Numerics.Complex32> vector)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseVector.OfVector(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseVector_OfEnumerable_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.Complex32> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseVector.OfEnumerable(enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseVector_OfIndexedEnumerable_Internal(System.Int32 length, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, MathNet.Numerics.Complex32>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseVector.OfIndexedEnumerable(length, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseVector_Create_Internal(System.Int32 length, MathNet.Numerics.Complex32 value)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseVector.Create(length, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseVector_Create_Internal(System.Int32 length, System.Func<System.Int32, MathNet.Numerics.Complex32> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseVector.Create(length, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseVector_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex32.SparseVector rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseVector_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseVector rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseVector_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex32.SparseVector rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseVector leftSide, MathNet.Numerics.Complex32 rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseVector_op_Multiply_Internal(MathNet.Numerics.Complex32 leftSide, MathNet.Numerics.LinearAlgebra.Complex32.SparseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32 LinearAlgebra_Complex32_SparseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex32.SparseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseVector_op_Division_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseVector leftSide, MathNet.Numerics.Complex32 rightSide)
        {
            return leftSide / rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseVector_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Complex32.SparseVector leftSide, MathNet.Numerics.Complex32 rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex32.SparseVector LinearAlgebra_Complex32_SparseVector_Parse_Internal(System.String value, System.IFormatProvider formatProvider)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseVector.Parse(value, formatProvider);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Complex32_SparseVector_TryParse_Internal(System.String value, out MathNet.Numerics.LinearAlgebra.Complex32.SparseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseVector.TryParse(value,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Complex32_SparseVector_TryParse_Internal(System.String value, System.IFormatProvider formatProvider, out MathNet.Numerics.LinearAlgebra.Complex32.SparseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Complex32.SparseVector.TryParse(value, formatProvider,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Numerics.Complex> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfArray_Internal(System.Numerics.Complex[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfIndexed_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Int32, System.Numerics.Complex>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfIndexed(rows, columns, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfColumnMajor_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Numerics.Complex> columnMajor)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfColumnMajor(rows, columns, columnMajor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfColumns_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Numerics.Complex>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfColumns(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfColumns_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Numerics.Complex>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfColumns(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfColumnArrays_Internal(System.Numerics.Complex[][] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfColumnArrays_Internal(System.Collections.Generic.IEnumerable<System.Numerics.Complex[]> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfColumnVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex>[] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfColumnVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex>> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfRows_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Numerics.Complex>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfRows(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfRows_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Numerics.Complex>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfRows(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfRowArrays_Internal(System.Numerics.Complex[][] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfRowArrays_Internal(System.Collections.Generic.IEnumerable<System.Numerics.Complex[]> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfRowVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex>[] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfRowVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex>> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfDiagonalVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfDiagonalVector(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfDiagonalVector_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfDiagonalVector(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfDiagonalArray_Internal(System.Numerics.Complex[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfDiagonalArray(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_OfDiagonalArray_Internal(System.Int32 rows, System.Int32 columns, System.Numerics.Complex[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.OfDiagonalArray(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Numerics.Complex value)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.Create(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Int32, System.Numerics.Complex> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.Create(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Numerics.Complex value)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.CreateDiagonal(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Numerics.Complex> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.CreateDiagonal(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_CreateIdentity_Internal(System.Int32 order)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.CreateIdentity(order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_CreateRandom_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix.CreateRandom(rows, columns, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_op_UnaryPlus_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix rightSide)
        {
            return +rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix leftSide, System.Numerics.Complex rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_op_Multiply_Internal(System.Numerics.Complex leftSide, MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex.DenseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix LinearAlgebra_Complex_DenseMatrix_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseMatrix leftSide, System.Numerics.Complex rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseVector_OfVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> vector)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseVector.OfVector(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseVector_OfArray_Internal(System.Numerics.Complex[] array)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseVector.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseVector_OfEnumerable_Internal(System.Collections.Generic.IEnumerable<System.Numerics.Complex> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseVector.OfEnumerable(enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseVector_OfIndexedEnumerable_Internal(System.Int32 length, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Numerics.Complex>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseVector.OfIndexedEnumerable(length, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseVector_Create_Internal(System.Int32 length, System.Numerics.Complex value)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseVector.Create(length, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseVector_Create_Internal(System.Int32 length, System.Func<System.Int32, System.Numerics.Complex> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseVector.Create(length, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseVector_CreateRandom_Internal(System.Int32 length, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseVector.CreateRandom(length, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex[] LinearAlgebra_Complex_DenseVector_op_Explicit_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseVector vector)
        {
            return (System.Numerics.Complex[])vector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseVector_op_Implicit_Internal(System.Numerics.Complex[] array)
        {
            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> LinearAlgebra_Complex_DenseVector_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex.DenseVector rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> LinearAlgebra_Complex_DenseVector_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseVector rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> LinearAlgebra_Complex_DenseVector_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex.DenseVector rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseVector leftSide, System.Numerics.Complex rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseVector_op_Multiply_Internal(System.Numerics.Complex leftSide, MathNet.Numerics.LinearAlgebra.Complex.DenseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex LinearAlgebra_Complex_DenseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex.DenseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseVector_op_Division_Internal(MathNet.Numerics.LinearAlgebra.Complex.DenseVector leftSide, System.Numerics.Complex rightSide)
        {
            return leftSide / rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DenseVector LinearAlgebra_Complex_DenseVector_Parse_Internal(System.String value, System.IFormatProvider formatProvider)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseVector.Parse(value, formatProvider);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Complex_DenseVector_TryParse_Internal(System.String value, out MathNet.Numerics.LinearAlgebra.Complex.DenseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseVector.TryParse(value,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Complex_DenseVector_TryParse_Internal(System.String value, System.IFormatProvider formatProvider, out MathNet.Numerics.LinearAlgebra.Complex.DenseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DenseVector.TryParse(value, formatProvider,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix LinearAlgebra_Complex_DiagonalMatrix_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Numerics.Complex> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix LinearAlgebra_Complex_DiagonalMatrix_OfArray_Internal(System.Numerics.Complex[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix LinearAlgebra_Complex_DiagonalMatrix_OfIndexedDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Numerics.Complex>> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix.OfIndexedDiagonal(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix LinearAlgebra_Complex_DiagonalMatrix_OfDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Numerics.Complex> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix.OfDiagonal(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix LinearAlgebra_Complex_DiagonalMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Numerics.Complex> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix.Create(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix LinearAlgebra_Complex_DiagonalMatrix_CreateIdentity_Internal(System.Int32 order)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix.CreateIdentity(order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix LinearAlgebra_Complex_DiagonalMatrix_CreateRandom_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.DiagonalMatrix.CreateRandom(rows, columns, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Numerics.Complex> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfArray_Internal(System.Numerics.Complex[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfIndexed_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Int32, System.Numerics.Complex>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfIndexed(rows, columns, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfRowMajor_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Numerics.Complex> rowMajor)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfRowMajor(rows, columns, rowMajor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfColumnMajor_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IList<System.Numerics.Complex> columnMajor)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfColumnMajor(rows, columns, columnMajor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfColumns_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Numerics.Complex>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfColumns(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfColumns_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Numerics.Complex>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfColumns(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfColumnArrays_Internal(System.Numerics.Complex[][] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfColumnArrays_Internal(System.Collections.Generic.IEnumerable<System.Numerics.Complex[]> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfColumnVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex>[] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfColumnVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex>> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfRows_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Numerics.Complex>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfRows(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfRows_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Numerics.Complex>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfRows(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfRowArrays_Internal(System.Numerics.Complex[][] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfRowArrays_Internal(System.Collections.Generic.IEnumerable<System.Numerics.Complex[]> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfRowVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex>[] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfRowVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex>> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfDiagonalVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfDiagonalVector(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfDiagonalVector_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfDiagonalVector(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfDiagonalArray_Internal(System.Numerics.Complex[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfDiagonalArray(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_OfDiagonalArray_Internal(System.Int32 rows, System.Int32 columns, System.Numerics.Complex[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.OfDiagonalArray(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Numerics.Complex value)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.Create(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Int32, System.Numerics.Complex> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.Create(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Numerics.Complex value)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.CreateDiagonal(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Numerics.Complex> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.CreateDiagonal(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_CreateIdentity_Internal(System.Int32 order)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix.CreateIdentity(order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_op_UnaryPlus_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix rightSide)
        {
            return +rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix leftSide, System.Numerics.Complex rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_op_Multiply_Internal(System.Numerics.Complex leftSide, MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Complex.SparseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix LinearAlgebra_Complex_SparseMatrix_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseMatrix leftSide, System.Numerics.Complex rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseVector_OfVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Numerics.Complex> vector)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseVector.OfVector(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseVector_OfEnumerable_Internal(System.Collections.Generic.IEnumerable<System.Numerics.Complex> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseVector.OfEnumerable(enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseVector_OfIndexedEnumerable_Internal(System.Int32 length, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Numerics.Complex>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseVector.OfIndexedEnumerable(length, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseVector_Create_Internal(System.Int32 length, System.Numerics.Complex value)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseVector.Create(length, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseVector_Create_Internal(System.Int32 length, System.Func<System.Int32, System.Numerics.Complex> init)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseVector.Create(length, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseVector_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex.SparseVector rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseVector_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseVector rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseVector_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex.SparseVector rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseVector leftSide, System.Numerics.Complex rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseVector_op_Multiply_Internal(System.Numerics.Complex leftSide, MathNet.Numerics.LinearAlgebra.Complex.SparseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex LinearAlgebra_Complex_SparseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Complex.SparseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseVector_op_Division_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseVector leftSide, System.Numerics.Complex rightSide)
        {
            return leftSide / rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseVector_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Complex.SparseVector leftSide, System.Numerics.Complex rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Complex.SparseVector LinearAlgebra_Complex_SparseVector_Parse_Internal(System.String value, System.IFormatProvider formatProvider)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseVector.Parse(value, formatProvider);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Complex_SparseVector_TryParse_Internal(System.String value, out MathNet.Numerics.LinearAlgebra.Complex.SparseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseVector.TryParse(value,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Complex_SparseVector_TryParse_Internal(System.String value, System.IFormatProvider formatProvider, out MathNet.Numerics.LinearAlgebra.Complex.SparseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Complex.SparseVector.TryParse(value, formatProvider,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Single> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfArray_Internal(System.Single[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfIndexed_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Int32, System.Single>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfIndexed(rows, columns, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfColumnMajor_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Single> columnMajor)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfColumnMajor(rows, columns, columnMajor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfColumns_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Single>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfColumns(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfColumns_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Single>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfColumns(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfColumnArrays_Internal(System.Single[][] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfColumnArrays_Internal(System.Collections.Generic.IEnumerable<System.Single[]> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfColumnVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Single>[] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfColumnVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<System.Single>> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfRows_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Single>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfRows(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfRows_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Single>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfRows(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfRowArrays_Internal(System.Single[][] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfRowArrays_Internal(System.Collections.Generic.IEnumerable<System.Single[]> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfRowVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Single>[] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfRowVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<System.Single>> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfDiagonalVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Single> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfDiagonalVector(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfDiagonalVector_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.LinearAlgebra.Vector<System.Single> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfDiagonalVector(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfDiagonalArray_Internal(System.Single[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfDiagonalArray(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_OfDiagonalArray_Internal(System.Int32 rows, System.Int32 columns, System.Single[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.OfDiagonalArray(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Single value)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.Create(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Int32, System.Single> init)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.Create(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Single value)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.CreateDiagonal(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Single> init)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.CreateDiagonal(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_CreateIdentity_Internal(System.Int32 order)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.CreateIdentity(order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_CreateRandom_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseMatrix.CreateRandom(rows, columns, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Single.DenseMatrix rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_op_UnaryPlus_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseMatrix rightSide)
        {
            return +rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Single.DenseMatrix rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseMatrix rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseMatrix leftSide, System.Single rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_op_Multiply_Internal(System.Single leftSide, MathNet.Numerics.LinearAlgebra.Single.DenseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Single.DenseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Single.DenseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Single.DenseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseMatrix LinearAlgebra_Single_DenseMatrix_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseMatrix leftSide, System.Single rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_OfVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Single> vector)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseVector.OfVector(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_OfArray_Internal(System.Single[] array)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseVector.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_OfEnumerable_Internal(System.Collections.Generic.IEnumerable<System.Single> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseVector.OfEnumerable(enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_OfIndexedEnumerable_Internal(System.Int32 length, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Single>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseVector.OfIndexedEnumerable(length, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_Create_Internal(System.Int32 length, System.Single value)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseVector.Create(length, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_Create_Internal(System.Int32 length, System.Func<System.Int32, System.Single> init)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseVector.Create(length, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_CreateRandom_Internal(System.Int32 length, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseVector.CreateRandom(length, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single[] LinearAlgebra_Single_DenseVector_op_Explicit_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseVector vector)
        {
            return (System.Single[])vector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_op_Implicit_Internal(System.Single[] array)
        {
            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Single.DenseVector rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseVector rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Single.DenseVector rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseVector leftSide, System.Single rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_op_Multiply_Internal(System.Single leftSide, MathNet.Numerics.LinearAlgebra.Single.DenseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single LinearAlgebra_Single_DenseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Single.DenseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_op_Division_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseVector leftSide, System.Single rightSide)
        {
            return leftSide / rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Single.DenseVector leftSide, System.Single rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DenseVector LinearAlgebra_Single_DenseVector_Parse_Internal(System.String value, System.IFormatProvider formatProvider)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseVector.Parse(value, formatProvider);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Single_DenseVector_TryParse_Internal(System.String value, out MathNet.Numerics.LinearAlgebra.Single.DenseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseVector.TryParse(value,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Single_DenseVector_TryParse_Internal(System.String value, System.IFormatProvider formatProvider, out MathNet.Numerics.LinearAlgebra.Single.DenseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DenseVector.TryParse(value, formatProvider,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix LinearAlgebra_Single_DiagonalMatrix_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Single> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix LinearAlgebra_Single_DiagonalMatrix_OfArray_Internal(System.Single[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix LinearAlgebra_Single_DiagonalMatrix_OfIndexedDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Single>> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix.OfIndexedDiagonal(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix LinearAlgebra_Single_DiagonalMatrix_OfDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Single> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix.OfDiagonal(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix LinearAlgebra_Single_DiagonalMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Single> init)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix.Create(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix LinearAlgebra_Single_DiagonalMatrix_CreateIdentity_Internal(System.Int32 order)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix.CreateIdentity(order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix LinearAlgebra_Single_DiagonalMatrix_CreateRandom_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.LinearAlgebra.Single.DiagonalMatrix.CreateRandom(rows, columns, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Single> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfArray_Internal(System.Single[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfIndexed_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Int32, System.Single>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfIndexed(rows, columns, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfRowMajor_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Single> rowMajor)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfRowMajor(rows, columns, rowMajor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfColumnMajor_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IList<System.Single> columnMajor)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfColumnMajor(rows, columns, columnMajor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfColumns_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Single>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfColumns(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfColumns_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Single>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfColumns(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfColumnArrays_Internal(System.Single[][] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfColumnArrays_Internal(System.Collections.Generic.IEnumerable<System.Single[]> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfColumnVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Single>[] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfColumnVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<System.Single>> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfRows_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Single>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfRows(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfRows_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Single>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfRows(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfRowArrays_Internal(System.Single[][] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfRowArrays_Internal(System.Collections.Generic.IEnumerable<System.Single[]> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfRowVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Single>[] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfRowVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<System.Single>> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfDiagonalVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Single> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfDiagonalVector(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfDiagonalVector_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.LinearAlgebra.Vector<System.Single> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfDiagonalVector(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfDiagonalArray_Internal(System.Single[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfDiagonalArray(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_OfDiagonalArray_Internal(System.Int32 rows, System.Int32 columns, System.Single[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.OfDiagonalArray(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Single value)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.Create(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Int32, System.Single> init)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.Create(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Single value)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.CreateDiagonal(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Single> init)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.CreateDiagonal(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_CreateIdentity_Internal(System.Int32 order)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseMatrix.CreateIdentity(order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Single.SparseMatrix rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_op_UnaryPlus_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseMatrix rightSide)
        {
            return +rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Single.SparseMatrix rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseMatrix rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseMatrix leftSide, System.Single rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_op_Multiply_Internal(System.Single leftSide, MathNet.Numerics.LinearAlgebra.Single.SparseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Single.SparseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Single.SparseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Single.SparseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseMatrix LinearAlgebra_Single_SparseMatrix_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseMatrix leftSide, System.Single rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseVector_OfVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Single> vector)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseVector.OfVector(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseVector_OfEnumerable_Internal(System.Collections.Generic.IEnumerable<System.Single> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseVector.OfEnumerable(enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseVector_OfIndexedEnumerable_Internal(System.Int32 length, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Single>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseVector.OfIndexedEnumerable(length, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseVector_Create_Internal(System.Int32 length, System.Single value)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseVector.Create(length, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseVector_Create_Internal(System.Int32 length, System.Func<System.Int32, System.Single> init)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseVector.Create(length, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseVector_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Single.SparseVector rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseVector_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseVector rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseVector_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Single.SparseVector rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseVector leftSide, System.Single rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseVector_op_Multiply_Internal(System.Single leftSide, MathNet.Numerics.LinearAlgebra.Single.SparseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Single LinearAlgebra_Single_SparseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Single.SparseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseVector_op_Division_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseVector leftSide, System.Single rightSide)
        {
            return leftSide / rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseVector_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Single.SparseVector leftSide, System.Single rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Single.SparseVector LinearAlgebra_Single_SparseVector_Parse_Internal(System.String value, System.IFormatProvider formatProvider)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseVector.Parse(value, formatProvider);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Single_SparseVector_TryParse_Internal(System.String value, out MathNet.Numerics.LinearAlgebra.Single.SparseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseVector.TryParse(value,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Single_SparseVector_TryParse_Internal(System.String value, System.IFormatProvider formatProvider, out MathNet.Numerics.LinearAlgebra.Single.SparseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Single.SparseVector.TryParse(value, formatProvider,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfArray_Internal(System.Double[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfIndexed_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Int32, System.Double>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfIndexed(rows, columns, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfColumnMajor_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Double> columnMajor)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfColumnMajor(rows, columns, columnMajor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfColumns_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfColumns(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfColumns_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfColumns(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfColumnArrays_Internal(System.Double[][] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfColumnArrays_Internal(System.Collections.Generic.IEnumerable<System.Double[]> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfColumnVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double>[] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfColumnVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<System.Double>> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfRows_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfRows(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfRows_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfRows(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfRowArrays_Internal(System.Double[][] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfRowArrays_Internal(System.Collections.Generic.IEnumerable<System.Double[]> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfRowVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double>[] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfRowVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<System.Double>> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfDiagonalVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfDiagonalVector(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfDiagonalVector_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.LinearAlgebra.Vector<System.Double> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfDiagonalVector(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfDiagonalArray_Internal(System.Double[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfDiagonalArray(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_OfDiagonalArray_Internal(System.Int32 rows, System.Int32 columns, System.Double[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.OfDiagonalArray(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Double value)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.Create(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.Create(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Double value)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.CreateDiagonal(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.CreateDiagonal(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_CreateIdentity_Internal(System.Int32 order)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.CreateIdentity(order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_CreateRandom_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseMatrix.CreateRandom(rows, columns, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Double.DenseMatrix rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_op_UnaryPlus_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseMatrix rightSide)
        {
            return +rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Double.DenseMatrix rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseMatrix rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseMatrix leftSide, System.Double rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_op_Multiply_Internal(System.Double leftSide, MathNet.Numerics.LinearAlgebra.Double.DenseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Double.DenseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Double.DenseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Double.DenseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseMatrix LinearAlgebra_Double_DenseMatrix_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseMatrix leftSide, System.Double rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix LinearAlgebra_Double_DiagonalMatrix_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix LinearAlgebra_Double_DiagonalMatrix_OfArray_Internal(System.Double[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix LinearAlgebra_Double_DiagonalMatrix_OfIndexedDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Double>> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix.OfIndexedDiagonal(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix LinearAlgebra_Double_DiagonalMatrix_OfDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Double> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix.OfDiagonal(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix LinearAlgebra_Double_DiagonalMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix.Create(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix LinearAlgebra_Double_DiagonalMatrix_CreateIdentity_Internal(System.Int32 order)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix.CreateIdentity(order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix LinearAlgebra_Double_DiagonalMatrix_CreateRandom_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DiagonalMatrix.CreateRandom(rows, columns, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfMatrix_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> matrix)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfMatrix(matrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfArray_Internal(System.Double[,] array)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfIndexed_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Int32, System.Double>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfIndexed(rows, columns, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfRowMajor_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Double> rowMajor)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfRowMajor(rows, columns, rowMajor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfColumnMajor_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IList<System.Double> columnMajor)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfColumnMajor(rows, columns, columnMajor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfColumns_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfColumns(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfColumns_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfColumns(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfColumnArrays_Internal(System.Double[][] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfColumnArrays_Internal(System.Collections.Generic.IEnumerable<System.Double[]> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfColumnArrays(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfColumnVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double>[] columns)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfColumnVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<System.Double>> columns)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfColumnVectors(columns);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfRows_Internal(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfRows(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfRows_Internal(System.Int32 rows, System.Int32 columns, System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<System.Double>> data)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfRows(rows, columns, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfRowArrays_Internal(System.Double[][] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfRowArrays_Internal(System.Collections.Generic.IEnumerable<System.Double[]> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfRowArrays(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfRowVectors_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double>[] rows)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfRowVectors_Internal(System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Vector<System.Double>> rows)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfRowVectors(rows);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfDiagonalVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfDiagonalVector(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfDiagonalVector_Internal(System.Int32 rows, System.Int32 columns, MathNet.Numerics.LinearAlgebra.Vector<System.Double> diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfDiagonalVector(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfDiagonalArray_Internal(System.Double[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfDiagonalArray(diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_OfDiagonalArray_Internal(System.Int32 rows, System.Int32 columns, System.Double[] diagonal)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.OfDiagonalArray(rows, columns, diagonal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Double value)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.Create(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_Create_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.Create(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Double value)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.CreateDiagonal(rows, columns, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_CreateDiagonal_Internal(System.Int32 rows, System.Int32 columns, System.Func<System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.CreateDiagonal(rows, columns, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_CreateIdentity_Internal(System.Int32 order)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseMatrix.CreateIdentity(order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Double.SparseMatrix rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_op_UnaryPlus_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseMatrix rightSide)
        {
            return +rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Double.SparseMatrix rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseMatrix rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseMatrix leftSide, System.Double rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_op_Multiply_Internal(System.Double leftSide, MathNet.Numerics.LinearAlgebra.Double.SparseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Double.SparseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseMatrix leftSide, MathNet.Numerics.LinearAlgebra.Double.SparseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseMatrix_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Double.SparseMatrix rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseMatrix LinearAlgebra_Double_SparseMatrix_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseMatrix leftSide, System.Double rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_OfVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> vector)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseVector.OfVector(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_OfArray_Internal(System.Double[] array)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseVector.OfArray(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_OfEnumerable_Internal(System.Collections.Generic.IEnumerable<System.Double> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseVector.OfEnumerable(enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_OfIndexedEnumerable_Internal(System.Int32 length, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Double>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseVector.OfIndexedEnumerable(length, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_Create_Internal(System.Int32 length, System.Double value)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseVector.Create(length, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_Create_Internal(System.Int32 length, System.Func<System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseVector.Create(length, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_CreateRandom_Internal(System.Int32 length, MathNet.Numerics.Distributions.IContinuousDistribution distribution)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseVector.CreateRandom(length, distribution);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] LinearAlgebra_Double_DenseVector_op_Explicit_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseVector vector)
        {
            return (System.Double[])vector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_op_Implicit_Internal(System.Double[] array)
        {
            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Double.DenseVector rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseVector rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Double.DenseVector rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseVector leftSide, System.Double rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_op_Multiply_Internal(System.Double leftSide, MathNet.Numerics.LinearAlgebra.Double.DenseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double LinearAlgebra_Double_DenseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseVector leftSide, MathNet.Numerics.LinearAlgebra.Double.DenseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_op_Division_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseVector leftSide, System.Double rightSide)
        {
            return leftSide / rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Double.DenseVector leftSide, System.Double rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.DenseVector LinearAlgebra_Double_DenseVector_Parse_Internal(System.String value, System.IFormatProvider formatProvider)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseVector.Parse(value, formatProvider);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Double_DenseVector_TryParse_Internal(System.String value, out MathNet.Numerics.LinearAlgebra.Double.DenseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseVector.TryParse(value,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Double_DenseVector_TryParse_Internal(System.String value, System.IFormatProvider formatProvider, out MathNet.Numerics.LinearAlgebra.Double.DenseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Double.DenseVector.TryParse(value, formatProvider,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseVector_OfVector_Internal(MathNet.Numerics.LinearAlgebra.Vector<System.Double> vector)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseVector.OfVector(vector);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseVector_OfEnumerable_Internal(System.Collections.Generic.IEnumerable<System.Double> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseVector.OfEnumerable(enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseVector_OfIndexedEnumerable_Internal(System.Int32 length, System.Collections.Generic.IEnumerable<System.Tuple<System.Int32, System.Double>> enumerable)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseVector.OfIndexedEnumerable(length, enumerable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseVector_Create_Internal(System.Int32 length, System.Double value)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseVector.Create(length, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseVector_Create_Internal(System.Int32 length, System.Func<System.Int32, System.Double> init)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseVector.Create(length, init);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseVector_op_Addition_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Double.SparseVector rightSide)
        {
            return leftSide + rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseVector_op_UnaryNegation_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseVector rightSide)
        {
            return -rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseVector_op_Subtraction_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Double.SparseVector rightSide)
        {
            return leftSide - rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseVector leftSide, System.Double rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseVector_op_Multiply_Internal(System.Double leftSide, MathNet.Numerics.LinearAlgebra.Double.SparseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double LinearAlgebra_Double_SparseVector_op_Multiply_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseVector leftSide, MathNet.Numerics.LinearAlgebra.Double.SparseVector rightSide)
        {
            return leftSide * rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseVector_op_Division_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseVector leftSide, System.Double rightSide)
        {
            return leftSide / rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseVector_op_Modulus_Internal(MathNet.Numerics.LinearAlgebra.Double.SparseVector leftSide, System.Double rightSide)
        {
            return leftSide % rightSide;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Double.SparseVector LinearAlgebra_Double_SparseVector_Parse_Internal(System.String value, System.IFormatProvider formatProvider)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseVector.Parse(value, formatProvider);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Double_SparseVector_TryParse_Internal(System.String value, out MathNet.Numerics.LinearAlgebra.Double.SparseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseVector.TryParse(value,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean LinearAlgebra_Double_SparseVector_TryParse_Internal(System.String value, System.IFormatProvider formatProvider, out MathNet.Numerics.LinearAlgebra.Double.SparseVector result)
        {
            return MathNet.Numerics.LinearAlgebra.Double.SparseVector.TryParse(value, formatProvider,  out result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Solvers.IIterativeSolverSetup<System.Double>> LinearAlgebra_Solvers_SolverSetup_LoadFromAssembly_Internal(System.Reflection.Assembly assembly, System.Boolean ignoreFailed, System.Type[] typesToExclude)
        {
            return MathNet.Numerics.LinearAlgebra.Solvers.SolverSetup<System.Double>.LoadFromAssembly(assembly, ignoreFailed, typesToExclude);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Solvers.IIterativeSolverSetup<System.Double>> LinearAlgebra_Solvers_SolverSetup_LoadFromAssembly_Internal(System.Type typeInAssembly, System.Boolean ignoreFailed, System.Type[] typesToExclude)
        {
            return MathNet.Numerics.LinearAlgebra.Solvers.SolverSetup<System.Double>.LoadFromAssembly(typeInAssembly, ignoreFailed, typesToExclude);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Solvers.IIterativeSolverSetup<System.Double>> LinearAlgebra_Solvers_SolverSetup_LoadFromAssembly_Internal(System.Reflection.AssemblyName assemblyName, System.Boolean ignoreFailed, System.Type[] typesToExclude)
        {
            return MathNet.Numerics.LinearAlgebra.Solvers.SolverSetup<System.Double>.LoadFromAssembly(assemblyName, ignoreFailed, typesToExclude);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Solvers.IIterativeSolverSetup<System.Double>> LinearAlgebra_Solvers_SolverSetup_Load_Internal(System.Type[] typesToExclude)
        {
            return MathNet.Numerics.LinearAlgebra.Solvers.SolverSetup<System.Double>.Load(typesToExclude);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<MathNet.Numerics.LinearAlgebra.Solvers.IIterativeSolverSetup<System.Double>> LinearAlgebra_Solvers_SolverSetup_Load_Internal()
        {
            return MathNet.Numerics.LinearAlgebra.Solvers.SolverSetup<System.Double>.Load();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.Barycentric Interpolation_Barycentric_InterpolatePolynomialEquidistantSorted_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.Barycentric.InterpolatePolynomialEquidistantSorted(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.Barycentric Interpolation_Barycentric_InterpolatePolynomialEquidistantInplace_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.Barycentric.InterpolatePolynomialEquidistantInplace(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.Barycentric Interpolation_Barycentric_InterpolatePolynomialEquidistant_Internal(System.Collections.Generic.IEnumerable<System.Double> x, System.Collections.Generic.IEnumerable<System.Double> y)
        {
            return MathNet.Numerics.Interpolation.Barycentric.InterpolatePolynomialEquidistant(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.Barycentric Interpolation_Barycentric_InterpolatePolynomialEquidistant_Internal(System.Double leftBound, System.Double rightBound, System.Collections.Generic.IEnumerable<System.Double> y)
        {
            return MathNet.Numerics.Interpolation.Barycentric.InterpolatePolynomialEquidistant(leftBound, rightBound, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.Barycentric Interpolation_Barycentric_InterpolateRationalFloaterHormannSorted_Internal(System.Double[] x, System.Double[] y, System.Int32 order)
        {
            return MathNet.Numerics.Interpolation.Barycentric.InterpolateRationalFloaterHormannSorted(x, y, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.Barycentric Interpolation_Barycentric_InterpolateRationalFloaterHormannInplace_Internal(System.Double[] x, System.Double[] y, System.Int32 order)
        {
            return MathNet.Numerics.Interpolation.Barycentric.InterpolateRationalFloaterHormannInplace(x, y, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.Barycentric Interpolation_Barycentric_InterpolateRationalFloaterHormann_Internal(System.Collections.Generic.IEnumerable<System.Double> x, System.Collections.Generic.IEnumerable<System.Double> y, System.Int32 order)
        {
            return MathNet.Numerics.Interpolation.Barycentric.InterpolateRationalFloaterHormann(x, y, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.Barycentric Interpolation_Barycentric_InterpolateRationalFloaterHormannSorted_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.Barycentric.InterpolateRationalFloaterHormannSorted(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.Barycentric Interpolation_Barycentric_InterpolateRationalFloaterHormannInplace_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.Barycentric.InterpolateRationalFloaterHormannInplace(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.Barycentric Interpolation_Barycentric_InterpolateRationalFloaterHormann_Internal(System.Collections.Generic.IEnumerable<System.Double> x, System.Collections.Generic.IEnumerable<System.Double> y)
        {
            return MathNet.Numerics.Interpolation.Barycentric.InterpolateRationalFloaterHormann(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.CubicSpline Interpolation_CubicSpline_InterpolateHermiteSorted_Internal(System.Double[] x, System.Double[] y, System.Double[] firstDerivatives)
        {
            return MathNet.Numerics.Interpolation.CubicSpline.InterpolateHermiteSorted(x, y, firstDerivatives);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.CubicSpline Interpolation_CubicSpline_InterpolateHermiteInplace_Internal(System.Double[] x, System.Double[] y, System.Double[] firstDerivatives)
        {
            return MathNet.Numerics.Interpolation.CubicSpline.InterpolateHermiteInplace(x, y, firstDerivatives);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.CubicSpline Interpolation_CubicSpline_InterpolateHermite_Internal(System.Collections.Generic.IEnumerable<System.Double> x, System.Collections.Generic.IEnumerable<System.Double> y, System.Collections.Generic.IEnumerable<System.Double> firstDerivatives)
        {
            return MathNet.Numerics.Interpolation.CubicSpline.InterpolateHermite(x, y, firstDerivatives);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.CubicSpline Interpolation_CubicSpline_InterpolateAkimaSorted_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.CubicSpline.InterpolateAkimaSorted(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.CubicSpline Interpolation_CubicSpline_InterpolateAkimaInplace_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.CubicSpline.InterpolateAkimaInplace(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.CubicSpline Interpolation_CubicSpline_InterpolateAkima_Internal(System.Collections.Generic.IEnumerable<System.Double> x, System.Collections.Generic.IEnumerable<System.Double> y)
        {
            return MathNet.Numerics.Interpolation.CubicSpline.InterpolateAkima(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.CubicSpline Interpolation_CubicSpline_InterpolateBoundariesSorted_Internal(System.Double[] x, System.Double[] y, MathNet.Numerics.Interpolation.SplineBoundaryCondition leftBoundaryCondition, System.Double leftBoundary, MathNet.Numerics.Interpolation.SplineBoundaryCondition rightBoundaryCondition, System.Double rightBoundary)
        {
            return MathNet.Numerics.Interpolation.CubicSpline.InterpolateBoundariesSorted(x, y, leftBoundaryCondition, leftBoundary, rightBoundaryCondition, rightBoundary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.CubicSpline Interpolation_CubicSpline_InterpolateBoundariesInplace_Internal(System.Double[] x, System.Double[] y, MathNet.Numerics.Interpolation.SplineBoundaryCondition leftBoundaryCondition, System.Double leftBoundary, MathNet.Numerics.Interpolation.SplineBoundaryCondition rightBoundaryCondition, System.Double rightBoundary)
        {
            return MathNet.Numerics.Interpolation.CubicSpline.InterpolateBoundariesInplace(x, y, leftBoundaryCondition, leftBoundary, rightBoundaryCondition, rightBoundary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.CubicSpline Interpolation_CubicSpline_InterpolateBoundaries_Internal(System.Collections.Generic.IEnumerable<System.Double> x, System.Collections.Generic.IEnumerable<System.Double> y, MathNet.Numerics.Interpolation.SplineBoundaryCondition leftBoundaryCondition, System.Double leftBoundary, MathNet.Numerics.Interpolation.SplineBoundaryCondition rightBoundaryCondition, System.Double rightBoundary)
        {
            return MathNet.Numerics.Interpolation.CubicSpline.InterpolateBoundaries(x, y, leftBoundaryCondition, leftBoundary, rightBoundaryCondition, rightBoundary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.CubicSpline Interpolation_CubicSpline_InterpolateNaturalSorted_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.CubicSpline.InterpolateNaturalSorted(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.CubicSpline Interpolation_CubicSpline_InterpolateNaturalInplace_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.CubicSpline.InterpolateNaturalInplace(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.CubicSpline Interpolation_CubicSpline_InterpolateNatural_Internal(System.Collections.Generic.IEnumerable<System.Double> x, System.Collections.Generic.IEnumerable<System.Double> y)
        {
            return MathNet.Numerics.Interpolation.CubicSpline.InterpolateNatural(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.LogLinear Interpolation_LogLinear_InterpolateSorted_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.LogLinear.InterpolateSorted(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.LogLinear Interpolation_LogLinear_InterpolateInplace_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.LogLinear.InterpolateInplace(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.LogLinear Interpolation_LogLinear_Interpolate_Internal(System.Collections.Generic.IEnumerable<System.Double> x, System.Collections.Generic.IEnumerable<System.Double> y)
        {
            return MathNet.Numerics.Interpolation.LogLinear.Interpolate(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.StepInterpolation Interpolation_StepInterpolation_InterpolateSorted_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.StepInterpolation.InterpolateSorted(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.StepInterpolation Interpolation_StepInterpolation_InterpolateInplace_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.StepInterpolation.InterpolateInplace(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.StepInterpolation Interpolation_StepInterpolation_Interpolate_Internal(System.Collections.Generic.IEnumerable<System.Double> x, System.Collections.Generic.IEnumerable<System.Double> y)
        {
            return MathNet.Numerics.Interpolation.StepInterpolation.Interpolate(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.TransformedInterpolation Interpolation_TransformedInterpolation_InterpolateSorted_Internal(System.Func<System.Double, System.Double> transform, System.Func<System.Double, System.Double> transformInverse, System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.TransformedInterpolation.InterpolateSorted(transform, transformInverse, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.TransformedInterpolation Interpolation_TransformedInterpolation_InterpolateInplace_Internal(System.Func<System.Double, System.Double> transform, System.Func<System.Double, System.Double> transformInverse, System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.TransformedInterpolation.InterpolateInplace(transform, transformInverse, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.TransformedInterpolation Interpolation_TransformedInterpolation_Interpolate_Internal(System.Func<System.Double, System.Double> transform, System.Func<System.Double, System.Double> transformInverse, System.Collections.Generic.IEnumerable<System.Double> x, System.Collections.Generic.IEnumerable<System.Double> y)
        {
            return MathNet.Numerics.Interpolation.TransformedInterpolation.Interpolate(transform, transformInverse, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.BulirschStoerRationalInterpolation Interpolation_BulirschStoerRationalInterpolation_InterpolateSorted_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.BulirschStoerRationalInterpolation.InterpolateSorted(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.BulirschStoerRationalInterpolation Interpolation_BulirschStoerRationalInterpolation_InterpolateInplace_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.BulirschStoerRationalInterpolation.InterpolateInplace(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.BulirschStoerRationalInterpolation Interpolation_BulirschStoerRationalInterpolation_Interpolate_Internal(System.Collections.Generic.IEnumerable<System.Double> x, System.Collections.Generic.IEnumerable<System.Double> y)
        {
            return MathNet.Numerics.Interpolation.BulirschStoerRationalInterpolation.Interpolate(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.LinearSpline Interpolation_LinearSpline_InterpolateSorted_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.LinearSpline.InterpolateSorted(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.LinearSpline Interpolation_LinearSpline_InterpolateInplace_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.LinearSpline.InterpolateInplace(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.LinearSpline Interpolation_LinearSpline_Interpolate_Internal(System.Collections.Generic.IEnumerable<System.Double> x, System.Collections.Generic.IEnumerable<System.Double> y)
        {
            return MathNet.Numerics.Interpolation.LinearSpline.Interpolate(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.NevillePolynomialInterpolation Interpolation_NevillePolynomialInterpolation_InterpolateSorted_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.NevillePolynomialInterpolation.InterpolateSorted(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.NevillePolynomialInterpolation Interpolation_NevillePolynomialInterpolation_InterpolateInplace_Internal(System.Double[] x, System.Double[] y)
        {
            return MathNet.Numerics.Interpolation.NevillePolynomialInterpolation.InterpolateInplace(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Interpolation.NevillePolynomialInterpolation Interpolation_NevillePolynomialInterpolation_Interpolate_Internal(System.Collections.Generic.IEnumerable<System.Double> x, System.Collections.Generic.IEnumerable<System.Double> y)
        {
            return MathNet.Numerics.Interpolation.NevillePolynomialInterpolation.Interpolate(x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Integration_GaussLegendreRule_Integrate_Internal(System.Func<System.Double, System.Double> f, System.Double invervalBegin, System.Double invervalEnd, System.Int32 order)
        {
            return MathNet.Numerics.Integration.GaussLegendreRule.Integrate(f, invervalBegin, invervalEnd, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Integration_GaussLegendreRule_Integrate_Internal(System.Func<System.Double, System.Double, System.Double> f, System.Double invervalBeginA, System.Double invervalEndA, System.Double invervalBeginB, System.Double invervalEndB, System.Int32 order)
        {
            return MathNet.Numerics.Integration.GaussLegendreRule.Integrate(f, invervalBeginA, invervalEndA, invervalBeginB, invervalEndB, order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Integration_DoubleExponentialTransformation_Integrate_Internal(System.Func<System.Double, System.Double> f, System.Double intervalBegin, System.Double intervalEnd, System.Double targetRelativeError)
        {
            return MathNet.Numerics.Integration.DoubleExponentialTransformation.Integrate(f, intervalBegin, intervalEnd, targetRelativeError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Integration_SimpsonRule_IntegrateThreePoint_Internal(System.Func<System.Double, System.Double> f, System.Double intervalBegin, System.Double intervalEnd)
        {
            return MathNet.Numerics.Integration.SimpsonRule.IntegrateThreePoint(f, intervalBegin, intervalEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Integration_SimpsonRule_IntegrateComposite_Internal(System.Func<System.Double, System.Double> f, System.Double intervalBegin, System.Double intervalEnd, System.Int32 numberOfPartitions)
        {
            return MathNet.Numerics.Integration.SimpsonRule.IntegrateComposite(f, intervalBegin, intervalEnd, numberOfPartitions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Integration_NewtonCotesTrapeziumRule_IntegrateTwoPoint_Internal(System.Func<System.Double, System.Double> f, System.Double intervalBegin, System.Double intervalEnd)
        {
            return MathNet.Numerics.Integration.NewtonCotesTrapeziumRule.IntegrateTwoPoint(f, intervalBegin, intervalEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Integration_NewtonCotesTrapeziumRule_IntegrateComposite_Internal(System.Func<System.Double, System.Double> f, System.Double intervalBegin, System.Double intervalEnd, System.Int32 numberOfPartitions)
        {
            return MathNet.Numerics.Integration.NewtonCotesTrapeziumRule.IntegrateComposite(f, intervalBegin, intervalEnd, numberOfPartitions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Integration_NewtonCotesTrapeziumRule_IntegrateAdaptive_Internal(System.Func<System.Double, System.Double> f, System.Double intervalBegin, System.Double intervalEnd, System.Double targetError)
        {
            return MathNet.Numerics.Integration.NewtonCotesTrapeziumRule.IntegrateAdaptive(f, intervalBegin, intervalEnd, targetError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Integration_NewtonCotesTrapeziumRule_IntegrateAdaptiveTransformedOdd_Internal(System.Func<System.Double, System.Double> f, System.Double intervalBegin, System.Double intervalEnd, System.Collections.Generic.IEnumerable<System.Double[]> levelAbscissas, System.Collections.Generic.IEnumerable<System.Double[]> levelWeights, System.Double levelOneStep, System.Double targetRelativeError)
        {
            return MathNet.Numerics.Integration.NewtonCotesTrapeziumRule.IntegrateAdaptiveTransformedOdd(f, intervalBegin, intervalEnd, levelAbscissas, levelWeights, levelOneStep, targetRelativeError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32[] IntegralTransforms_Fourier_NaiveForward_Internal(MathNet.Numerics.Complex32[] samples, MathNet.Numerics.IntegralTransforms.FourierOptions options)
        {
            return MathNet.Numerics.IntegralTransforms.Fourier.NaiveForward(samples, options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex[] IntegralTransforms_Fourier_NaiveForward_Internal(System.Numerics.Complex[] samples, MathNet.Numerics.IntegralTransforms.FourierOptions options)
        {
            return MathNet.Numerics.IntegralTransforms.Fourier.NaiveForward(samples, options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Complex32[] IntegralTransforms_Fourier_NaiveInverse_Internal(MathNet.Numerics.Complex32[] spectrum, MathNet.Numerics.IntegralTransforms.FourierOptions options)
        {
            return MathNet.Numerics.IntegralTransforms.Fourier.NaiveInverse(spectrum, options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Numerics.Complex[] IntegralTransforms_Fourier_NaiveInverse_Internal(System.Numerics.Complex[] spectrum, MathNet.Numerics.IntegralTransforms.FourierOptions options)
        {
            return MathNet.Numerics.IntegralTransforms.Fourier.NaiveInverse(spectrum, options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] IntegralTransforms_Fourier_FrequencyScale_Internal(System.Int32 length, System.Double sampleRate)
        {
            return MathNet.Numerics.IntegralTransforms.Fourier.FrequencyScale(length, sampleRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] IntegralTransforms_Hartley_NaiveForward_Internal(System.Double[] timeSpace, MathNet.Numerics.IntegralTransforms.HartleyOptions options)
        {
            return MathNet.Numerics.IntegralTransforms.Hartley.NaiveForward(timeSpace, options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] IntegralTransforms_Hartley_NaiveInverse_Internal(System.Double[] frequencySpace, MathNet.Numerics.IntegralTransforms.HartleyOptions options)
        {
            return MathNet.Numerics.IntegralTransforms.Hartley.NaiveInverse(frequencySpace, options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.BetaScaled Distributions_BetaScaled_PERT_Internal(System.Double min, System.Double max, System.Double likely, System.Random randomSource)
        {
            return MathNet.Numerics.Distributions.BetaScaled.PERT(min, max, likely, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_BetaScaled_IsValidParameterSet_Internal(System.Double a, System.Double b, System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.BetaScaled.IsValidParameterSet(a, b, location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_BetaScaled_PDF_Internal(System.Double a, System.Double b, System.Double location, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.BetaScaled.PDF(a, b, location, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_BetaScaled_PDFLn_Internal(System.Double a, System.Double b, System.Double location, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.BetaScaled.PDFLn(a, b, location, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_BetaScaled_CDF_Internal(System.Double a, System.Double b, System.Double location, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.BetaScaled.CDF(a, b, location, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_BetaScaled_InvCDF_Internal(System.Double a, System.Double b, System.Double location, System.Double scale, System.Double p)
        {
            return MathNet.Numerics.Distributions.BetaScaled.InvCDF(a, b, location, scale, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_BetaScaled_Sample_Internal(System.Random rnd, System.Double a, System.Double b, System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.BetaScaled.Sample(rnd, a, b, location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_BetaScaled_Samples_Internal(System.Random rnd, System.Double a, System.Double b, System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.BetaScaled.Samples(rnd, a, b, location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_BetaScaled_Sample_Internal(System.Double a, System.Double b, System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.BetaScaled.Sample(a, b, location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_BetaScaled_Samples_Internal(System.Double a, System.Double b, System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.BetaScaled.Samples(a, b, location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Triangular_IsValidParameterSet_Internal(System.Double lower, System.Double upper, System.Double mode)
        {
            return MathNet.Numerics.Distributions.Triangular.IsValidParameterSet(lower, upper, mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Triangular_PDF_Internal(System.Double lower, System.Double upper, System.Double mode, System.Double x)
        {
            return MathNet.Numerics.Distributions.Triangular.PDF(lower, upper, mode, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Triangular_PDFLn_Internal(System.Double lower, System.Double upper, System.Double mode, System.Double x)
        {
            return MathNet.Numerics.Distributions.Triangular.PDFLn(lower, upper, mode, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Triangular_CDF_Internal(System.Double lower, System.Double upper, System.Double mode, System.Double x)
        {
            return MathNet.Numerics.Distributions.Triangular.CDF(lower, upper, mode, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Triangular_InvCDF_Internal(System.Double lower, System.Double upper, System.Double mode, System.Double p)
        {
            return MathNet.Numerics.Distributions.Triangular.InvCDF(lower, upper, mode, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Triangular_Sample_Internal(System.Random rnd, System.Double lower, System.Double upper, System.Double mode)
        {
            return MathNet.Numerics.Distributions.Triangular.Sample(rnd, lower, upper, mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Triangular_Samples_Internal(System.Random rnd, System.Double lower, System.Double upper, System.Double mode)
        {
            return MathNet.Numerics.Distributions.Triangular.Samples(rnd, lower, upper, mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Triangular_Sample_Internal(System.Double lower, System.Double upper, System.Double mode)
        {
            return MathNet.Numerics.Distributions.Triangular.Sample(lower, upper, mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Triangular_Samples_Internal(System.Double lower, System.Double upper, System.Double mode)
        {
            return MathNet.Numerics.Distributions.Triangular.Samples(lower, upper, mode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Bernoulli_IsValidParameterSet_Internal(System.Double p)
        {
            return MathNet.Numerics.Distributions.Bernoulli.IsValidParameterSet(p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Bernoulli_PMF_Internal(System.Double p, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Bernoulli.PMF(p, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Bernoulli_PMFLn_Internal(System.Double p, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Bernoulli.PMFLn(p, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Bernoulli_CDF_Internal(System.Double p, System.Double x)
        {
            return MathNet.Numerics.Distributions.Bernoulli.CDF(p, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Bernoulli_Sample_Internal(System.Random rnd, System.Double p)
        {
            return MathNet.Numerics.Distributions.Bernoulli.Sample(rnd, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Bernoulli_Samples_Internal(System.Random rnd, System.Double p)
        {
            return MathNet.Numerics.Distributions.Bernoulli.Samples(rnd, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Bernoulli_Sample_Internal(System.Double p)
        {
            return MathNet.Numerics.Distributions.Bernoulli.Sample(p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Bernoulli_Samples_Internal(System.Double p)
        {
            return MathNet.Numerics.Distributions.Bernoulli.Samples(p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Beta_IsValidParameterSet_Internal(System.Double a, System.Double b)
        {
            return MathNet.Numerics.Distributions.Beta.IsValidParameterSet(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Beta_PDF_Internal(System.Double a, System.Double b, System.Double x)
        {
            return MathNet.Numerics.Distributions.Beta.PDF(a, b, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Beta_PDFLn_Internal(System.Double a, System.Double b, System.Double x)
        {
            return MathNet.Numerics.Distributions.Beta.PDFLn(a, b, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Beta_CDF_Internal(System.Double a, System.Double b, System.Double x)
        {
            return MathNet.Numerics.Distributions.Beta.CDF(a, b, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Beta_InvCDF_Internal(System.Double a, System.Double b, System.Double p)
        {
            return MathNet.Numerics.Distributions.Beta.InvCDF(a, b, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Beta_Sample_Internal(System.Random rnd, System.Double a, System.Double b)
        {
            return MathNet.Numerics.Distributions.Beta.Sample(rnd, a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Beta_Samples_Internal(System.Random rnd, System.Double a, System.Double b)
        {
            return MathNet.Numerics.Distributions.Beta.Samples(rnd, a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Beta_Sample_Internal(System.Double a, System.Double b)
        {
            return MathNet.Numerics.Distributions.Beta.Sample(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Beta_Samples_Internal(System.Double a, System.Double b)
        {
            return MathNet.Numerics.Distributions.Beta.Samples(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Binomial_IsValidParameterSet_Internal(System.Double p, System.Int32 n)
        {
            return MathNet.Numerics.Distributions.Binomial.IsValidParameterSet(p, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Binomial_PMF_Internal(System.Double p, System.Int32 n, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Binomial.PMF(p, n, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Binomial_PMFLn_Internal(System.Double p, System.Int32 n, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Binomial.PMFLn(p, n, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Binomial_CDF_Internal(System.Double p, System.Int32 n, System.Double x)
        {
            return MathNet.Numerics.Distributions.Binomial.CDF(p, n, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Binomial_Sample_Internal(System.Random rnd, System.Double p, System.Int32 n)
        {
            return MathNet.Numerics.Distributions.Binomial.Sample(rnd, p, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Binomial_Samples_Internal(System.Random rnd, System.Double p, System.Int32 n)
        {
            return MathNet.Numerics.Distributions.Binomial.Samples(rnd, p, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Binomial_Sample_Internal(System.Double p, System.Int32 n)
        {
            return MathNet.Numerics.Distributions.Binomial.Sample(p, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Binomial_Samples_Internal(System.Double p, System.Int32 n)
        {
            return MathNet.Numerics.Distributions.Binomial.Samples(p, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Categorical_IsValidProbabilityMass_Internal(System.Double[] p)
        {
            return MathNet.Numerics.Distributions.Categorical.IsValidProbabilityMass(p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Categorical_IsValidCumulativeDistribution_Internal(System.Double[] cdf)
        {
            return MathNet.Numerics.Distributions.Categorical.IsValidCumulativeDistribution(cdf);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Categorical_PMF_Internal(System.Double[] probabilityMass, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Categorical.PMF(probabilityMass, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Categorical_PMFLn_Internal(System.Double[] probabilityMass, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Categorical.PMFLn(probabilityMass, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Categorical_CDF_Internal(System.Double[] probabilityMass, System.Double x)
        {
            return MathNet.Numerics.Distributions.Categorical.CDF(probabilityMass, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Categorical_InvCDF_Internal(System.Double[] probabilityMass, System.Double probability)
        {
            return MathNet.Numerics.Distributions.Categorical.InvCDF(probabilityMass, probability);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Categorical_InvCDFWithCumulativeDistribution_Internal(System.Double[] cdfUnnormalized, System.Double probability)
        {
            return MathNet.Numerics.Distributions.Categorical.InvCDFWithCumulativeDistribution(cdfUnnormalized, probability);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Categorical_Sample_Internal(System.Random rnd, System.Double[] probabilityMass)
        {
            return MathNet.Numerics.Distributions.Categorical.Sample(rnd, probabilityMass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Categorical_Samples_Internal(System.Random rnd, System.Double[] probabilityMass)
        {
            return MathNet.Numerics.Distributions.Categorical.Samples(rnd, probabilityMass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Categorical_Sample_Internal(System.Double[] probabilityMass)
        {
            return MathNet.Numerics.Distributions.Categorical.Sample(probabilityMass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Categorical_Samples_Internal(System.Double[] probabilityMass)
        {
            return MathNet.Numerics.Distributions.Categorical.Samples(probabilityMass);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Categorical_SampleWithCumulativeDistribution_Internal(System.Random rnd, System.Double[] cdfUnnormalized)
        {
            return MathNet.Numerics.Distributions.Categorical.SampleWithCumulativeDistribution(rnd, cdfUnnormalized);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Categorical_SamplesWithCumulativeDistribution_Internal(System.Random rnd, System.Double[] cdfUnnormalized)
        {
            return MathNet.Numerics.Distributions.Categorical.SamplesWithCumulativeDistribution(rnd, cdfUnnormalized);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Categorical_SampleWithCumulativeDistribution_Internal(System.Double[] cdfUnnormalized)
        {
            return MathNet.Numerics.Distributions.Categorical.SampleWithCumulativeDistribution(cdfUnnormalized);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Categorical_SamplesWithCumulativeDistribution_Internal(System.Double[] cdfUnnormalized)
        {
            return MathNet.Numerics.Distributions.Categorical.SamplesWithCumulativeDistribution(cdfUnnormalized);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Cauchy_IsValidParameterSet_Internal(System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Cauchy.IsValidParameterSet(location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Cauchy_PDF_Internal(System.Double location, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.Cauchy.PDF(location, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Cauchy_PDFLn_Internal(System.Double location, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.Cauchy.PDFLn(location, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Cauchy_CDF_Internal(System.Double location, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.Cauchy.CDF(location, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Cauchy_InvCDF_Internal(System.Double location, System.Double scale, System.Double p)
        {
            return MathNet.Numerics.Distributions.Cauchy.InvCDF(location, scale, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Cauchy_Sample_Internal(System.Random rnd, System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Cauchy.Sample(rnd, location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Cauchy_Samples_Internal(System.Random rnd, System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Cauchy.Samples(rnd, location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Cauchy_Sample_Internal(System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Cauchy.Sample(location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Cauchy_Samples_Internal(System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Cauchy.Samples(location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Chi_IsValidParameterSet_Internal(System.Double freedom)
        {
            return MathNet.Numerics.Distributions.Chi.IsValidParameterSet(freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Chi_PDF_Internal(System.Double freedom, System.Double x)
        {
            return MathNet.Numerics.Distributions.Chi.PDF(freedom, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Chi_PDFLn_Internal(System.Double freedom, System.Double x)
        {
            return MathNet.Numerics.Distributions.Chi.PDFLn(freedom, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Chi_CDF_Internal(System.Double freedom, System.Double x)
        {
            return MathNet.Numerics.Distributions.Chi.CDF(freedom, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Chi_Sample_Internal(System.Random rnd, System.Int32 freedom)
        {
            return MathNet.Numerics.Distributions.Chi.Sample(rnd, freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Chi_Samples_Internal(System.Random rnd, System.Int32 freedom)
        {
            return MathNet.Numerics.Distributions.Chi.Samples(rnd, freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Chi_Sample_Internal(System.Int32 freedom)
        {
            return MathNet.Numerics.Distributions.Chi.Sample(freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Chi_Samples_Internal(System.Int32 freedom)
        {
            return MathNet.Numerics.Distributions.Chi.Samples(freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_ChiSquared_IsValidParameterSet_Internal(System.Double freedom)
        {
            return MathNet.Numerics.Distributions.ChiSquared.IsValidParameterSet(freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ChiSquared_PDF_Internal(System.Double freedom, System.Double x)
        {
            return MathNet.Numerics.Distributions.ChiSquared.PDF(freedom, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ChiSquared_PDFLn_Internal(System.Double freedom, System.Double x)
        {
            return MathNet.Numerics.Distributions.ChiSquared.PDFLn(freedom, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ChiSquared_CDF_Internal(System.Double freedom, System.Double x)
        {
            return MathNet.Numerics.Distributions.ChiSquared.CDF(freedom, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ChiSquared_InvCDF_Internal(System.Double freedom, System.Double p)
        {
            return MathNet.Numerics.Distributions.ChiSquared.InvCDF(freedom, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ChiSquared_Sample_Internal(System.Random rnd, System.Double freedom)
        {
            return MathNet.Numerics.Distributions.ChiSquared.Sample(rnd, freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_ChiSquared_Samples_Internal(System.Random rnd, System.Double freedom)
        {
            return MathNet.Numerics.Distributions.ChiSquared.Samples(rnd, freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ChiSquared_Sample_Internal(System.Double freedom)
        {
            return MathNet.Numerics.Distributions.ChiSquared.Sample(freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_ChiSquared_Samples_Internal(System.Double freedom)
        {
            return MathNet.Numerics.Distributions.ChiSquared.Samples(freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_ContinuousUniform_IsValidParameterSet_Internal(System.Double lower, System.Double upper)
        {
            return MathNet.Numerics.Distributions.ContinuousUniform.IsValidParameterSet(lower, upper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ContinuousUniform_PDF_Internal(System.Double lower, System.Double upper, System.Double x)
        {
            return MathNet.Numerics.Distributions.ContinuousUniform.PDF(lower, upper, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ContinuousUniform_PDFLn_Internal(System.Double lower, System.Double upper, System.Double x)
        {
            return MathNet.Numerics.Distributions.ContinuousUniform.PDFLn(lower, upper, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ContinuousUniform_CDF_Internal(System.Double lower, System.Double upper, System.Double x)
        {
            return MathNet.Numerics.Distributions.ContinuousUniform.CDF(lower, upper, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ContinuousUniform_InvCDF_Internal(System.Double lower, System.Double upper, System.Double p)
        {
            return MathNet.Numerics.Distributions.ContinuousUniform.InvCDF(lower, upper, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ContinuousUniform_Sample_Internal(System.Random rnd, System.Double lower, System.Double upper)
        {
            return MathNet.Numerics.Distributions.ContinuousUniform.Sample(rnd, lower, upper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_ContinuousUniform_Samples_Internal(System.Random rnd, System.Double lower, System.Double upper)
        {
            return MathNet.Numerics.Distributions.ContinuousUniform.Samples(rnd, lower, upper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ContinuousUniform_Sample_Internal(System.Double lower, System.Double upper)
        {
            return MathNet.Numerics.Distributions.ContinuousUniform.Sample(lower, upper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_ContinuousUniform_Samples_Internal(System.Double lower, System.Double upper)
        {
            return MathNet.Numerics.Distributions.ContinuousUniform.Samples(lower, upper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_ConwayMaxwellPoisson_IsValidParameterSet_Internal(System.Double lambda, System.Double nu)
        {
            return MathNet.Numerics.Distributions.ConwayMaxwellPoisson.IsValidParameterSet(lambda, nu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ConwayMaxwellPoisson_PMF_Internal(System.Double lambda, System.Double nu, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.ConwayMaxwellPoisson.PMF(lambda, nu, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ConwayMaxwellPoisson_PMFLn_Internal(System.Double lambda, System.Double nu, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.ConwayMaxwellPoisson.PMFLn(lambda, nu, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_ConwayMaxwellPoisson_CDF_Internal(System.Double lambda, System.Double nu, System.Double x)
        {
            return MathNet.Numerics.Distributions.ConwayMaxwellPoisson.CDF(lambda, nu, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_ConwayMaxwellPoisson_Sample_Internal(System.Random rnd, System.Double lambda, System.Double nu)
        {
            return MathNet.Numerics.Distributions.ConwayMaxwellPoisson.Sample(rnd, lambda, nu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_ConwayMaxwellPoisson_Samples_Internal(System.Random rnd, System.Double lambda, System.Double nu)
        {
            return MathNet.Numerics.Distributions.ConwayMaxwellPoisson.Samples(rnd, lambda, nu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_ConwayMaxwellPoisson_Sample_Internal(System.Double lambda, System.Double nu)
        {
            return MathNet.Numerics.Distributions.ConwayMaxwellPoisson.Sample(lambda, nu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_ConwayMaxwellPoisson_Samples_Internal(System.Double lambda, System.Double nu)
        {
            return MathNet.Numerics.Distributions.ConwayMaxwellPoisson.Samples(lambda, nu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Dirichlet_IsValidParameterSet_Internal(System.Double[] alpha)
        {
            return MathNet.Numerics.Distributions.Dirichlet.IsValidParameterSet(alpha);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double[] Distributions_Dirichlet_Sample_Internal(System.Random rnd, System.Double[] alpha)
        {
            return MathNet.Numerics.Distributions.Dirichlet.Sample(rnd, alpha);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_DiscreteUniform_IsValidParameterSet_Internal(System.Int32 lower, System.Int32 upper)
        {
            return MathNet.Numerics.Distributions.DiscreteUniform.IsValidParameterSet(lower, upper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_DiscreteUniform_PMF_Internal(System.Int32 lower, System.Int32 upper, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.DiscreteUniform.PMF(lower, upper, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_DiscreteUniform_PMFLn_Internal(System.Int32 lower, System.Int32 upper, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.DiscreteUniform.PMFLn(lower, upper, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_DiscreteUniform_CDF_Internal(System.Int32 lower, System.Int32 upper, System.Double x)
        {
            return MathNet.Numerics.Distributions.DiscreteUniform.CDF(lower, upper, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_DiscreteUniform_Sample_Internal(System.Random rnd, System.Int32 lower, System.Int32 upper)
        {
            return MathNet.Numerics.Distributions.DiscreteUniform.Sample(rnd, lower, upper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_DiscreteUniform_Samples_Internal(System.Random rnd, System.Int32 lower, System.Int32 upper)
        {
            return MathNet.Numerics.Distributions.DiscreteUniform.Samples(rnd, lower, upper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_DiscreteUniform_Sample_Internal(System.Int32 lower, System.Int32 upper)
        {
            return MathNet.Numerics.Distributions.DiscreteUniform.Sample(lower, upper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_DiscreteUniform_Samples_Internal(System.Int32 lower, System.Int32 upper)
        {
            return MathNet.Numerics.Distributions.DiscreteUniform.Samples(lower, upper);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.Erlang Distributions_Erlang_WithShapeScale_Internal(System.Int32 shape, System.Double scale, System.Random randomSource)
        {
            return MathNet.Numerics.Distributions.Erlang.WithShapeScale(shape, scale, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.Erlang Distributions_Erlang_WithShapeRate_Internal(System.Int32 shape, System.Double rate, System.Random randomSource)
        {
            return MathNet.Numerics.Distributions.Erlang.WithShapeRate(shape, rate, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Erlang_IsValidParameterSet_Internal(System.Int32 shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Erlang.IsValidParameterSet(shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Erlang_IsValidParameterSet_Internal(System.Double shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Erlang.IsValidParameterSet(shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Erlang_PDF_Internal(System.Int32 shape, System.Double rate, System.Double x)
        {
            return MathNet.Numerics.Distributions.Erlang.PDF(shape, rate, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Erlang_PDF_Internal(System.Double shape, System.Double rate, System.Double x)
        {
            return MathNet.Numerics.Distributions.Erlang.PDF(shape, rate, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Erlang_PDFLn_Internal(System.Int32 shape, System.Double rate, System.Double x)
        {
            return MathNet.Numerics.Distributions.Erlang.PDFLn(shape, rate, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Erlang_PDFLn_Internal(System.Double shape, System.Double rate, System.Double x)
        {
            return MathNet.Numerics.Distributions.Erlang.PDFLn(shape, rate, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Erlang_CDF_Internal(System.Int32 shape, System.Double rate, System.Double x)
        {
            return MathNet.Numerics.Distributions.Erlang.CDF(shape, rate, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Erlang_CDF_Internal(System.Double shape, System.Double rate, System.Double x)
        {
            return MathNet.Numerics.Distributions.Erlang.CDF(shape, rate, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Erlang_Sample_Internal(System.Random rnd, System.Int32 shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Erlang.Sample(rnd, shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Erlang_Sample_Internal(System.Random rnd, System.Double shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Erlang.Sample(rnd, shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Erlang_Samples_Internal(System.Random rnd, System.Int32 shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Erlang.Samples(rnd, shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Erlang_Samples_Internal(System.Random rnd, System.Double shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Erlang.Samples(rnd, shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Erlang_Sample_Internal(System.Int32 shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Erlang.Sample(shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Erlang_Sample_Internal(System.Double shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Erlang.Sample(shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Erlang_Samples_Internal(System.Int32 shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Erlang.Samples(shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Erlang_Samples_Internal(System.Double shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Erlang.Samples(shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Exponential_IsValidParameterSet_Internal(System.Double rate)
        {
            return MathNet.Numerics.Distributions.Exponential.IsValidParameterSet(rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Exponential_PDF_Internal(System.Double rate, System.Double x)
        {
            return MathNet.Numerics.Distributions.Exponential.PDF(rate, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Exponential_PDFLn_Internal(System.Double rate, System.Double x)
        {
            return MathNet.Numerics.Distributions.Exponential.PDFLn(rate, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Exponential_CDF_Internal(System.Double rate, System.Double x)
        {
            return MathNet.Numerics.Distributions.Exponential.CDF(rate, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Exponential_InvCDF_Internal(System.Double rate, System.Double p)
        {
            return MathNet.Numerics.Distributions.Exponential.InvCDF(rate, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Exponential_Sample_Internal(System.Random rnd, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Exponential.Sample(rnd, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Exponential_Samples_Internal(System.Random rnd, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Exponential.Samples(rnd, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Exponential_Sample_Internal(System.Double rate)
        {
            return MathNet.Numerics.Distributions.Exponential.Sample(rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Exponential_Samples_Internal(System.Double rate)
        {
            return MathNet.Numerics.Distributions.Exponential.Samples(rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_FisherSnedecor_IsValidParameterSet_Internal(System.Double d1, System.Double d2)
        {
            return MathNet.Numerics.Distributions.FisherSnedecor.IsValidParameterSet(d1, d2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_FisherSnedecor_PDF_Internal(System.Double d1, System.Double d2, System.Double x)
        {
            return MathNet.Numerics.Distributions.FisherSnedecor.PDF(d1, d2, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_FisherSnedecor_PDFLn_Internal(System.Double d1, System.Double d2, System.Double x)
        {
            return MathNet.Numerics.Distributions.FisherSnedecor.PDFLn(d1, d2, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_FisherSnedecor_CDF_Internal(System.Double d1, System.Double d2, System.Double x)
        {
            return MathNet.Numerics.Distributions.FisherSnedecor.CDF(d1, d2, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_FisherSnedecor_InvCDF_Internal(System.Double d1, System.Double d2, System.Double p)
        {
            return MathNet.Numerics.Distributions.FisherSnedecor.InvCDF(d1, d2, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_FisherSnedecor_Sample_Internal(System.Random rnd, System.Double d1, System.Double d2)
        {
            return MathNet.Numerics.Distributions.FisherSnedecor.Sample(rnd, d1, d2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_FisherSnedecor_Samples_Internal(System.Random rnd, System.Double d1, System.Double d2)
        {
            return MathNet.Numerics.Distributions.FisherSnedecor.Samples(rnd, d1, d2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_FisherSnedecor_Sample_Internal(System.Double d1, System.Double d2)
        {
            return MathNet.Numerics.Distributions.FisherSnedecor.Sample(d1, d2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_FisherSnedecor_Samples_Internal(System.Double d1, System.Double d2)
        {
            return MathNet.Numerics.Distributions.FisherSnedecor.Samples(d1, d2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.Gamma Distributions_Gamma_WithShapeScale_Internal(System.Double shape, System.Double scale, System.Random randomSource)
        {
            return MathNet.Numerics.Distributions.Gamma.WithShapeScale(shape, scale, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.Gamma Distributions_Gamma_WithShapeRate_Internal(System.Double shape, System.Double rate, System.Random randomSource)
        {
            return MathNet.Numerics.Distributions.Gamma.WithShapeRate(shape, rate, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Gamma_IsValidParameterSet_Internal(System.Double shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Gamma.IsValidParameterSet(shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Gamma_PDF_Internal(System.Double shape, System.Double rate, System.Double x)
        {
            return MathNet.Numerics.Distributions.Gamma.PDF(shape, rate, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Gamma_PDFLn_Internal(System.Double shape, System.Double rate, System.Double x)
        {
            return MathNet.Numerics.Distributions.Gamma.PDFLn(shape, rate, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Gamma_CDF_Internal(System.Double shape, System.Double rate, System.Double x)
        {
            return MathNet.Numerics.Distributions.Gamma.CDF(shape, rate, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Gamma_InvCDF_Internal(System.Double shape, System.Double rate, System.Double p)
        {
            return MathNet.Numerics.Distributions.Gamma.InvCDF(shape, rate, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Gamma_Sample_Internal(System.Random rnd, System.Double shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Gamma.Sample(rnd, shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Gamma_Samples_Internal(System.Random rnd, System.Double shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Gamma.Samples(rnd, shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Gamma_Sample_Internal(System.Double shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Gamma.Sample(shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Gamma_Samples_Internal(System.Double shape, System.Double rate)
        {
            return MathNet.Numerics.Distributions.Gamma.Samples(shape, rate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Geometric_IsValidParameterSet_Internal(System.Double p)
        {
            return MathNet.Numerics.Distributions.Geometric.IsValidParameterSet(p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Geometric_PMF_Internal(System.Double p, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Geometric.PMF(p, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Geometric_PMFLn_Internal(System.Double p, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Geometric.PMFLn(p, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Geometric_CDF_Internal(System.Double p, System.Double x)
        {
            return MathNet.Numerics.Distributions.Geometric.CDF(p, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Geometric_Sample_Internal(System.Random rnd, System.Double p)
        {
            return MathNet.Numerics.Distributions.Geometric.Sample(rnd, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Geometric_Samples_Internal(System.Random rnd, System.Double p)
        {
            return MathNet.Numerics.Distributions.Geometric.Samples(rnd, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Geometric_Sample_Internal(System.Double p)
        {
            return MathNet.Numerics.Distributions.Geometric.Sample(p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Geometric_Samples_Internal(System.Double p)
        {
            return MathNet.Numerics.Distributions.Geometric.Samples(p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Hypergeometric_IsValidParameterSet_Internal(System.Int32 population, System.Int32 success, System.Int32 draws)
        {
            return MathNet.Numerics.Distributions.Hypergeometric.IsValidParameterSet(population, success, draws);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Hypergeometric_PMF_Internal(System.Int32 population, System.Int32 success, System.Int32 draws, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Hypergeometric.PMF(population, success, draws, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Hypergeometric_PMFLn_Internal(System.Int32 population, System.Int32 success, System.Int32 draws, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Hypergeometric.PMFLn(population, success, draws, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Hypergeometric_CDF_Internal(System.Int32 population, System.Int32 success, System.Int32 draws, System.Double x)
        {
            return MathNet.Numerics.Distributions.Hypergeometric.CDF(population, success, draws, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Hypergeometric_Sample_Internal(System.Random rnd, System.Int32 population, System.Int32 success, System.Int32 draws)
        {
            return MathNet.Numerics.Distributions.Hypergeometric.Sample(rnd, population, success, draws);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Hypergeometric_Samples_Internal(System.Random rnd, System.Int32 population, System.Int32 success, System.Int32 draws)
        {
            return MathNet.Numerics.Distributions.Hypergeometric.Samples(rnd, population, success, draws);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Hypergeometric_Sample_Internal(System.Int32 population, System.Int32 success, System.Int32 draws)
        {
            return MathNet.Numerics.Distributions.Hypergeometric.Sample(population, success, draws);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Hypergeometric_Samples_Internal(System.Int32 population, System.Int32 success, System.Int32 draws)
        {
            return MathNet.Numerics.Distributions.Hypergeometric.Samples(population, success, draws);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_InverseGamma_IsValidParameterSet_Internal(System.Double shape, System.Double scale)
        {
            return MathNet.Numerics.Distributions.InverseGamma.IsValidParameterSet(shape, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_InverseGamma_PDF_Internal(System.Double shape, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.InverseGamma.PDF(shape, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_InverseGamma_PDFLn_Internal(System.Double shape, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.InverseGamma.PDFLn(shape, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_InverseGamma_CDF_Internal(System.Double shape, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.InverseGamma.CDF(shape, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_InverseGamma_Sample_Internal(System.Random rnd, System.Double shape, System.Double scale)
        {
            return MathNet.Numerics.Distributions.InverseGamma.Sample(rnd, shape, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_InverseGamma_Samples_Internal(System.Random rnd, System.Double shape, System.Double scale)
        {
            return MathNet.Numerics.Distributions.InverseGamma.Samples(rnd, shape, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_InverseGamma_Sample_Internal(System.Double shape, System.Double scale)
        {
            return MathNet.Numerics.Distributions.InverseGamma.Sample(shape, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_InverseGamma_Samples_Internal(System.Double shape, System.Double scale)
        {
            return MathNet.Numerics.Distributions.InverseGamma.Samples(shape, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_InverseWishart_IsValidParameterSet_Internal(System.Double degreesOfFreedom, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> scale)
        {
            return MathNet.Numerics.Distributions.InverseWishart.IsValidParameterSet(degreesOfFreedom, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> Distributions_InverseWishart_Sample_Internal(System.Random rnd, System.Double degreesOfFreedom, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> scale)
        {
            return MathNet.Numerics.Distributions.InverseWishart.Sample(rnd, degreesOfFreedom, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Laplace_IsValidParameterSet_Internal(System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Laplace.IsValidParameterSet(location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Laplace_PDF_Internal(System.Double location, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.Laplace.PDF(location, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Laplace_PDFLn_Internal(System.Double location, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.Laplace.PDFLn(location, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Laplace_CDF_Internal(System.Double location, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.Laplace.CDF(location, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Laplace_Sample_Internal(System.Random rnd, System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Laplace.Sample(rnd, location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Laplace_Samples_Internal(System.Random rnd, System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Laplace.Samples(rnd, location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Laplace_Sample_Internal(System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Laplace.Sample(location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Laplace_Samples_Internal(System.Double location, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Laplace.Samples(location, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.LogNormal Distributions_LogNormal_WithMuSigma_Internal(System.Double mu, System.Double sigma, System.Random randomSource)
        {
            return MathNet.Numerics.Distributions.LogNormal.WithMuSigma(mu, sigma, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.LogNormal Distributions_LogNormal_WithMeanVariance_Internal(System.Double mean, System.Double var, System.Random randomSource)
        {
            return MathNet.Numerics.Distributions.LogNormal.WithMeanVariance(mean, var, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.LogNormal Distributions_LogNormal_Estimate_Internal(System.Collections.Generic.IEnumerable<System.Double> samples, System.Random randomSource)
        {
            return MathNet.Numerics.Distributions.LogNormal.Estimate(samples, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_LogNormal_IsValidParameterSet_Internal(System.Double mu, System.Double sigma)
        {
            return MathNet.Numerics.Distributions.LogNormal.IsValidParameterSet(mu, sigma);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_LogNormal_PDF_Internal(System.Double mu, System.Double sigma, System.Double x)
        {
            return MathNet.Numerics.Distributions.LogNormal.PDF(mu, sigma, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_LogNormal_PDFLn_Internal(System.Double mu, System.Double sigma, System.Double x)
        {
            return MathNet.Numerics.Distributions.LogNormal.PDFLn(mu, sigma, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_LogNormal_CDF_Internal(System.Double mu, System.Double sigma, System.Double x)
        {
            return MathNet.Numerics.Distributions.LogNormal.CDF(mu, sigma, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_LogNormal_InvCDF_Internal(System.Double mu, System.Double sigma, System.Double p)
        {
            return MathNet.Numerics.Distributions.LogNormal.InvCDF(mu, sigma, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_LogNormal_Sample_Internal(System.Random rnd, System.Double mu, System.Double sigma)
        {
            return MathNet.Numerics.Distributions.LogNormal.Sample(rnd, mu, sigma);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_LogNormal_Samples_Internal(System.Random rnd, System.Double mu, System.Double sigma)
        {
            return MathNet.Numerics.Distributions.LogNormal.Samples(rnd, mu, sigma);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_LogNormal_Sample_Internal(System.Double mu, System.Double sigma)
        {
            return MathNet.Numerics.Distributions.LogNormal.Sample(mu, sigma);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_LogNormal_Samples_Internal(System.Double mu, System.Double sigma)
        {
            return MathNet.Numerics.Distributions.LogNormal.Samples(mu, sigma);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_MatrixNormal_IsValidParameterSet_Internal(MathNet.Numerics.LinearAlgebra.Matrix<System.Double> m, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> v, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> k)
        {
            return MathNet.Numerics.Distributions.MatrixNormal.IsValidParameterSet(m, v, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> Distributions_MatrixNormal_Sample_Internal(System.Random rnd, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> m, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> v, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> k)
        {
            return MathNet.Numerics.Distributions.MatrixNormal.Sample(rnd, m, v, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Multinomial_IsValidParameterSet_Internal(System.Collections.Generic.IEnumerable<System.Double> p, System.Int32 n)
        {
            return MathNet.Numerics.Distributions.Multinomial.IsValidParameterSet(p, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32[] Distributions_Multinomial_Sample_Internal(System.Random rnd, System.Double[] p, System.Int32 n)
        {
            return MathNet.Numerics.Distributions.Multinomial.Sample(rnd, p, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32[]> Distributions_Multinomial_Samples_Internal(System.Random rnd, System.Double[] p, System.Int32 n)
        {
            return MathNet.Numerics.Distributions.Multinomial.Samples(rnd, p, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_NegativeBinomial_IsValidParameterSet_Internal(System.Double r, System.Double p)
        {
            return MathNet.Numerics.Distributions.NegativeBinomial.IsValidParameterSet(r, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_NegativeBinomial_PMF_Internal(System.Double r, System.Double p, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.NegativeBinomial.PMF(r, p, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_NegativeBinomial_PMFLn_Internal(System.Double r, System.Double p, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.NegativeBinomial.PMFLn(r, p, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_NegativeBinomial_CDF_Internal(System.Double r, System.Double p, System.Double x)
        {
            return MathNet.Numerics.Distributions.NegativeBinomial.CDF(r, p, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_NegativeBinomial_Sample_Internal(System.Random rnd, System.Double r, System.Double p)
        {
            return MathNet.Numerics.Distributions.NegativeBinomial.Sample(rnd, r, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_NegativeBinomial_Samples_Internal(System.Random rnd, System.Double r, System.Double p)
        {
            return MathNet.Numerics.Distributions.NegativeBinomial.Samples(rnd, r, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_NegativeBinomial_Sample_Internal(System.Double r, System.Double p)
        {
            return MathNet.Numerics.Distributions.NegativeBinomial.Sample(r, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_NegativeBinomial_Samples_Internal(System.Double r, System.Double p)
        {
            return MathNet.Numerics.Distributions.NegativeBinomial.Samples(r, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.Normal Distributions_Normal_WithMeanStdDev_Internal(System.Double mean, System.Double stddev, System.Random randomSource)
        {
            return MathNet.Numerics.Distributions.Normal.WithMeanStdDev(mean, stddev, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.Normal Distributions_Normal_WithMeanVariance_Internal(System.Double mean, System.Double var, System.Random randomSource)
        {
            return MathNet.Numerics.Distributions.Normal.WithMeanVariance(mean, var, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.Normal Distributions_Normal_WithMeanPrecision_Internal(System.Double mean, System.Double precision, System.Random randomSource)
        {
            return MathNet.Numerics.Distributions.Normal.WithMeanPrecision(mean, precision, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.Normal Distributions_Normal_Estimate_Internal(System.Collections.Generic.IEnumerable<System.Double> samples, System.Random randomSource)
        {
            return MathNet.Numerics.Distributions.Normal.Estimate(samples, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Normal_IsValidParameterSet_Internal(System.Double mean, System.Double stddev)
        {
            return MathNet.Numerics.Distributions.Normal.IsValidParameterSet(mean, stddev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Normal_PDF_Internal(System.Double mean, System.Double stddev, System.Double x)
        {
            return MathNet.Numerics.Distributions.Normal.PDF(mean, stddev, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Normal_PDFLn_Internal(System.Double mean, System.Double stddev, System.Double x)
        {
            return MathNet.Numerics.Distributions.Normal.PDFLn(mean, stddev, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Normal_CDF_Internal(System.Double mean, System.Double stddev, System.Double x)
        {
            return MathNet.Numerics.Distributions.Normal.CDF(mean, stddev, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Normal_InvCDF_Internal(System.Double mean, System.Double stddev, System.Double p)
        {
            return MathNet.Numerics.Distributions.Normal.InvCDF(mean, stddev, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Normal_Sample_Internal(System.Random rnd, System.Double mean, System.Double stddev)
        {
            return MathNet.Numerics.Distributions.Normal.Sample(rnd, mean, stddev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Normal_Samples_Internal(System.Random rnd, System.Double mean, System.Double stddev)
        {
            return MathNet.Numerics.Distributions.Normal.Samples(rnd, mean, stddev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Normal_Sample_Internal(System.Double mean, System.Double stddev)
        {
            return MathNet.Numerics.Distributions.Normal.Sample(mean, stddev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Normal_Samples_Internal(System.Double mean, System.Double stddev)
        {
            return MathNet.Numerics.Distributions.Normal.Samples(mean, stddev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_NormalGamma_IsValidParameterSet_Internal(System.Double meanLocation, System.Double meanScale, System.Double precShape, System.Double precInvScale)
        {
            return MathNet.Numerics.Distributions.NormalGamma.IsValidParameterSet(meanLocation, meanScale, precShape, precInvScale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.MeanPrecisionPair Distributions_NormalGamma_Sample_Internal(System.Random rnd, System.Double meanLocation, System.Double meanScale, System.Double precisionShape, System.Double precisionInverseScale)
        {
            return MathNet.Numerics.Distributions.NormalGamma.Sample(rnd, meanLocation, meanScale, precisionShape, precisionInverseScale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<MathNet.Numerics.Distributions.MeanPrecisionPair> Distributions_NormalGamma_Samples_Internal(System.Random rnd, System.Double meanLocation, System.Double meanScale, System.Double precisionShape, System.Double precisionInvScale)
        {
            return MathNet.Numerics.Distributions.NormalGamma.Samples(rnd, meanLocation, meanScale, precisionShape, precisionInvScale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Pareto_IsValidParameterSet_Internal(System.Double scale, System.Double shape)
        {
            return MathNet.Numerics.Distributions.Pareto.IsValidParameterSet(scale, shape);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Pareto_PDF_Internal(System.Double scale, System.Double shape, System.Double x)
        {
            return MathNet.Numerics.Distributions.Pareto.PDF(scale, shape, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Pareto_PDFLn_Internal(System.Double scale, System.Double shape, System.Double x)
        {
            return MathNet.Numerics.Distributions.Pareto.PDFLn(scale, shape, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Pareto_CDF_Internal(System.Double scale, System.Double shape, System.Double x)
        {
            return MathNet.Numerics.Distributions.Pareto.CDF(scale, shape, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Pareto_InvCDF_Internal(System.Double scale, System.Double shape, System.Double p)
        {
            return MathNet.Numerics.Distributions.Pareto.InvCDF(scale, shape, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Pareto_Sample_Internal(System.Random rnd, System.Double scale, System.Double shape)
        {
            return MathNet.Numerics.Distributions.Pareto.Sample(rnd, scale, shape);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Pareto_Samples_Internal(System.Random rnd, System.Double scale, System.Double shape)
        {
            return MathNet.Numerics.Distributions.Pareto.Samples(rnd, scale, shape);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Pareto_Sample_Internal(System.Double scale, System.Double shape)
        {
            return MathNet.Numerics.Distributions.Pareto.Sample(scale, shape);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Pareto_Samples_Internal(System.Double scale, System.Double shape)
        {
            return MathNet.Numerics.Distributions.Pareto.Samples(scale, shape);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Poisson_IsValidParameterSet_Internal(System.Double lambda)
        {
            return MathNet.Numerics.Distributions.Poisson.IsValidParameterSet(lambda);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Poisson_PMF_Internal(System.Double lambda, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Poisson.PMF(lambda, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Poisson_PMFLn_Internal(System.Double lambda, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Poisson.PMFLn(lambda, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Poisson_CDF_Internal(System.Double lambda, System.Double x)
        {
            return MathNet.Numerics.Distributions.Poisson.CDF(lambda, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Poisson_Sample_Internal(System.Random rnd, System.Double lambda)
        {
            return MathNet.Numerics.Distributions.Poisson.Sample(rnd, lambda);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Poisson_Samples_Internal(System.Random rnd, System.Double lambda)
        {
            return MathNet.Numerics.Distributions.Poisson.Samples(rnd, lambda);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Poisson_Sample_Internal(System.Double lambda)
        {
            return MathNet.Numerics.Distributions.Poisson.Sample(lambda);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Poisson_Samples_Internal(System.Double lambda)
        {
            return MathNet.Numerics.Distributions.Poisson.Samples(lambda);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Rayleigh_IsValidParameterSet_Internal(System.Double scale)
        {
            return MathNet.Numerics.Distributions.Rayleigh.IsValidParameterSet(scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Rayleigh_PDF_Internal(System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.Rayleigh.PDF(scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Rayleigh_PDFLn_Internal(System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.Rayleigh.PDFLn(scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Rayleigh_CDF_Internal(System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.Rayleigh.CDF(scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Rayleigh_InvCDF_Internal(System.Double scale, System.Double p)
        {
            return MathNet.Numerics.Distributions.Rayleigh.InvCDF(scale, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Rayleigh_Sample_Internal(System.Random rnd, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Rayleigh.Sample(rnd, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Rayleigh_Samples_Internal(System.Random rnd, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Rayleigh.Samples(rnd, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Rayleigh_Sample_Internal(System.Double scale)
        {
            return MathNet.Numerics.Distributions.Rayleigh.Sample(scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Rayleigh_Samples_Internal(System.Double scale)
        {
            return MathNet.Numerics.Distributions.Rayleigh.Samples(scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Stable_IsValidParameterSet_Internal(System.Double alpha, System.Double beta, System.Double scale, System.Double location)
        {
            return MathNet.Numerics.Distributions.Stable.IsValidParameterSet(alpha, beta, scale, location);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Stable_PDF_Internal(System.Double alpha, System.Double beta, System.Double scale, System.Double location, System.Double x)
        {
            return MathNet.Numerics.Distributions.Stable.PDF(alpha, beta, scale, location, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Stable_PDFLn_Internal(System.Double alpha, System.Double beta, System.Double scale, System.Double location, System.Double x)
        {
            return MathNet.Numerics.Distributions.Stable.PDFLn(alpha, beta, scale, location, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Stable_CDF_Internal(System.Double alpha, System.Double beta, System.Double scale, System.Double location, System.Double x)
        {
            return MathNet.Numerics.Distributions.Stable.CDF(alpha, beta, scale, location, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Stable_Sample_Internal(System.Random rnd, System.Double alpha, System.Double beta, System.Double scale, System.Double location)
        {
            return MathNet.Numerics.Distributions.Stable.Sample(rnd, alpha, beta, scale, location);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Stable_Samples_Internal(System.Random rnd, System.Double alpha, System.Double beta, System.Double scale, System.Double location)
        {
            return MathNet.Numerics.Distributions.Stable.Samples(rnd, alpha, beta, scale, location);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Stable_Sample_Internal(System.Double alpha, System.Double beta, System.Double scale, System.Double location)
        {
            return MathNet.Numerics.Distributions.Stable.Sample(alpha, beta, scale, location);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Stable_Samples_Internal(System.Double alpha, System.Double beta, System.Double scale, System.Double location)
        {
            return MathNet.Numerics.Distributions.Stable.Samples(alpha, beta, scale, location);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_StudentT_IsValidParameterSet_Internal(System.Double location, System.Double scale, System.Double freedom)
        {
            return MathNet.Numerics.Distributions.StudentT.IsValidParameterSet(location, scale, freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_StudentT_PDF_Internal(System.Double location, System.Double scale, System.Double freedom, System.Double x)
        {
            return MathNet.Numerics.Distributions.StudentT.PDF(location, scale, freedom, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_StudentT_PDFLn_Internal(System.Double location, System.Double scale, System.Double freedom, System.Double x)
        {
            return MathNet.Numerics.Distributions.StudentT.PDFLn(location, scale, freedom, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_StudentT_CDF_Internal(System.Double location, System.Double scale, System.Double freedom, System.Double x)
        {
            return MathNet.Numerics.Distributions.StudentT.CDF(location, scale, freedom, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_StudentT_InvCDF_Internal(System.Double location, System.Double scale, System.Double freedom, System.Double p)
        {
            return MathNet.Numerics.Distributions.StudentT.InvCDF(location, scale, freedom, p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_StudentT_Sample_Internal(System.Random rnd, System.Double location, System.Double scale, System.Double freedom)
        {
            return MathNet.Numerics.Distributions.StudentT.Sample(rnd, location, scale, freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_StudentT_Samples_Internal(System.Random rnd, System.Double location, System.Double scale, System.Double freedom)
        {
            return MathNet.Numerics.Distributions.StudentT.Samples(rnd, location, scale, freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_StudentT_Sample_Internal(System.Double location, System.Double scale, System.Double freedom)
        {
            return MathNet.Numerics.Distributions.StudentT.Sample(location, scale, freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_StudentT_Samples_Internal(System.Double location, System.Double scale, System.Double freedom)
        {
            return MathNet.Numerics.Distributions.StudentT.Samples(location, scale, freedom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Weibull_IsValidParameterSet_Internal(System.Double shape, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Weibull.IsValidParameterSet(shape, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Weibull_PDF_Internal(System.Double shape, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.Weibull.PDF(shape, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Weibull_PDFLn_Internal(System.Double shape, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.Weibull.PDFLn(shape, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Weibull_CDF_Internal(System.Double shape, System.Double scale, System.Double x)
        {
            return MathNet.Numerics.Distributions.Weibull.CDF(shape, scale, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.Distributions.Weibull Distributions_Weibull_Estimate_Internal(System.Collections.Generic.IEnumerable<System.Double> samples, System.Random randomSource)
        {
            return MathNet.Numerics.Distributions.Weibull.Estimate(samples, randomSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Weibull_Sample_Internal(System.Random rnd, System.Double shape, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Weibull.Sample(rnd, shape, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Weibull_Samples_Internal(System.Random rnd, System.Double shape, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Weibull.Samples(rnd, shape, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Weibull_Sample_Internal(System.Double shape, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Weibull.Sample(shape, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Double> Distributions_Weibull_Samples_Internal(System.Double shape, System.Double scale)
        {
            return MathNet.Numerics.Distributions.Weibull.Samples(shape, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Wishart_IsValidParameterSet_Internal(System.Double degreesOfFreedom, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> scale)
        {
            return MathNet.Numerics.Distributions.Wishart.IsValidParameterSet(degreesOfFreedom, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static MathNet.Numerics.LinearAlgebra.Matrix<System.Double> Distributions_Wishart_Sample_Internal(System.Random rnd, System.Double degreesOfFreedom, MathNet.Numerics.LinearAlgebra.Matrix<System.Double> scale)
        {
            return MathNet.Numerics.Distributions.Wishart.Sample(rnd, degreesOfFreedom, scale);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Boolean Distributions_Zipf_IsValidParameterSet_Internal(System.Double s, System.Int32 n)
        {
            return MathNet.Numerics.Distributions.Zipf.IsValidParameterSet(s, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Zipf_PMF_Internal(System.Double s, System.Int32 n, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Zipf.PMF(s, n, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Zipf_PMFLn_Internal(System.Double s, System.Int32 n, System.Int32 k)
        {
            return MathNet.Numerics.Distributions.Zipf.PMFLn(s, n, k);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Double Distributions_Zipf_CDF_Internal(System.Double s, System.Int32 n, System.Double x)
        {
            return MathNet.Numerics.Distributions.Zipf.CDF(s, n, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Zipf_Sample_Internal(System.Random rnd, System.Double s, System.Int32 n)
        {
            return MathNet.Numerics.Distributions.Zipf.Sample(rnd, s, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Zipf_Samples_Internal(System.Random rnd, System.Double s, System.Int32 n)
        {
            return MathNet.Numerics.Distributions.Zipf.Samples(rnd, s, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Int32 Distributions_Zipf_Sample_Internal(System.Double s, System.Int32 n)
        {
            return MathNet.Numerics.Distributions.Zipf.Sample(s, n);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static System.Collections.Generic.IEnumerable<System.Int32> Distributions_Zipf_Samples_Internal(System.Double s, System.Int32 n)
        {
            return MathNet.Numerics.Distributions.Zipf.Samples(s, n);
        }
    }
}