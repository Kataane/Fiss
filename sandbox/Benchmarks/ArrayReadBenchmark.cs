using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks;

[MeanColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
public class ArrayReadBenchmark
{
    [Params(32, 64, 128, 256, 512, 1024)]
    public int N;

    private int[] array = null!;

    [GlobalSetup]
    public void Init()
    {
        array = new int[N];

        var rnd = new Random(1234);
        for (var i = 0; i < N; i++)
        {
            array[i] = rnd.Next(0, 10);
        }
    }

    [Benchmark]
    public int For()
    {
        var sum = 0;
        for (var i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    [Benchmark(Baseline = true)]
    public int Foreach()
    {
        var sum = 0;
        foreach (var element in array)
        {
            sum += element;
        }

        return sum;
    }

    [Benchmark]
    public int ForeachSpan()
    {
        var sum = 0;
        foreach (var element in array.AsSpan())
        {
            sum += element;
        }

        return sum;
    }

    [Benchmark]
    public int ForUnsafeRef()
    {
        var sum = 0;
        ref var refStart = ref MemoryMarshal.GetReference<int>(array);
        for (var i = 0; i < array.Length; i++)
        {
            sum += Unsafe.Add(ref refStart, i);
        }

        return sum;
    }

    [Benchmark]
    public int ForUnsafe2Refs()
    {
        var sum = 0;
        for (ref int refItem = ref MemoryMarshal.GetReference<int>(array),
             refEnd = ref Unsafe.Add(ref refItem, array.Length);
             Unsafe.IsAddressLessThan(ref refItem, ref refEnd);
             refItem = ref Unsafe.Add(ref refItem, 1))
        {
            sum += refItem;
        }

        return sum;
    }

    [Benchmark]
    public unsafe int ForUnsafePointer()
    {
        var sum = 0;
        fixed (int* arrayPtr = &array[0])
        {
            for (var index = 0; index < array.Length; index++)
            {
                sum += *(arrayPtr + index);
            }
        }

        return sum;
    }

    [Benchmark]
    public unsafe int ForUnsafe2Pointers()
    {
        var sum = 0;
        fixed (int* arrayPtr = array)
        {
            for (int* ptr = arrayPtr, endPtr = arrayPtr + array.Length; ptr < endPtr; ptr++)
            {
                sum += *ptr;
            }
        }

        return sum;
    }
}