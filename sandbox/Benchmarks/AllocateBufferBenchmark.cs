using System.Buffers;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks;

[MemoryDiagnoser]
[MinColumn, MaxColumn, MeanColumn, MedianColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class AllocateBufferBenchmark
{
    [Params(32, 64, 128, 256, 512, 1024)]
    public int N;

    [Benchmark(Baseline = true)]
    public char[] Allocate()
    {
        return new char[N];
    }

    [Benchmark]
    public unsafe void AllocateWithStackalloc()
    {
        var array = stackalloc char[N];
        Consume(array);
    }

    [SkipLocalsInit]
    [Benchmark]
    public unsafe void AllocateWithStackallocWithSkipLocalsInit()
    {
        var array = stackalloc char[N];
        Consume(array);
    }

    [Benchmark]
    public void AllocateWithArrayPool()
    {
        var data = ArrayPool<char>.Shared.Rent(N);
        Consume(data);
        ArrayPool<char>.Shared.Return(data);
    }

    [Benchmark]
    public char[] AllocateWithGCAllocateUninitializedArray()
    {
        return GC.AllocateUninitializedArray<char>(N);
    }

    [Benchmark]
    public char[] AllocateWithGCAllocateArray()
    {
        return GC.AllocateArray<char>(N);
    }

    [Benchmark]
    public char[] AllocateWithArrayCreateInstance()
    {
        return (char[])Array.CreateInstance(typeof(char), N);
    }

    [Benchmark]
    public char[] AllocateWithActivatorCreateInstance()
    {
        return (char[])Activator.CreateInstance(typeof(char[]), N);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static unsafe void Consume(char* input)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Consume(ReadOnlySpan<char> input)
    {
    }
}