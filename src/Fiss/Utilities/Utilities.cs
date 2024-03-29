﻿using Fiss.Exceptions;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Fiss;

internal static class Utilities
{
    private const int maxSizeForStackAlloc = 512;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal static int SelectBucketIndex(int bufferSize)
    {
        // Buffers are bucketed so that a request between 2^(n-1) + 1 and 2^n is given a buffer of 2^n
        // Bucket index is log2(bufferSize - 1) with the exception that buffers between 1 and 16 bytes
        // are combined, and the index is slid down by 3 to compensate.
        // Zero is a valid bufferSize, and it is assigned the highest bucket index so that zero-length
        // buffers are not retained by the pool. The pool will return the Array.Empty singleton for these.
        return BitOperations.Log2((uint)bufferSize - 1 | 15) - 3;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetMaxSizeForBucket(int binIndex)
    {
        var maxSize = 16 << binIndex;
        Debug.Assert(maxSize >= 0);
        return maxSize;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetMaxSizeForStackAlloc(int size)
    {
        FissArgumentException.ThrowIfMoreThan(size, maxSizeForStackAlloc);
        var bucketIndex = SelectBucketIndex(size);
        return GetMaxSizeForBucket(bucketIndex);
    }
}
