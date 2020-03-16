//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using NUnit.Framework;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.PerformanceTesting;
using Unity.Burst;

namespace Unity.Mathematics.PerformanceTests
{
    public partial class TestFastInverse
    {
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class float4x4_fastinverse
        {
            public struct Arguments : IDisposable
            {
                public float4x4* m1;

                public void Init()
                {
                    m1 = (float4x4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float4x4>() * 10000, UnsafeUtility.AlignOf<float4x4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        m1[i] = float4x4.identity;
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(m1, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m1[i] = math.fastinverse(args.m1[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float4x4_fastinverse_mono()
        {
            float4x4_fastinverse.TestFunction testFunction = float4x4_fastinverse.MonoTestFunction;
            var args = new float4x4_fastinverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void float4x4_fastinverse_burst()
        {
            FunctionPointer<float4x4_fastinverse.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float4x4_fastinverse.TestFunction>(float4x4_fastinverse.BurstTestFunction);
            var args = new float4x4_fastinverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class double4x4_fastinverse
        {
            public struct Arguments : IDisposable
            {
                public double4x4* m1;

                public void Init()
                {
                    m1 = (double4x4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<double4x4>() * 10000, UnsafeUtility.AlignOf<double4x4>(), Allocator.Persistent);
                    for (int i = 0; i < 10000; ++i)
                    {
                        m1[i] = double4x4.identity;
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(m1, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 10000; ++i)
                {
                    args.m1[i] = math.fastinverse(args.m1[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void double4x4_fastinverse_mono()
        {
            double4x4_fastinverse.TestFunction testFunction = double4x4_fastinverse.MonoTestFunction;
            var args = new double4x4_fastinverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void double4x4_fastinverse_burst()
        {
            FunctionPointer<double4x4_fastinverse.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<double4x4_fastinverse.TestFunction>(double4x4_fastinverse.BurstTestFunction);
            var args = new double4x4_fastinverse.Arguments();
            args.Init();

            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .Definition(sampleUnit: SampleUnit.Microsecond)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
    }
}
