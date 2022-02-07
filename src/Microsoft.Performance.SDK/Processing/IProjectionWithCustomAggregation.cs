// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Microsoft.Performance.SDK.Processing
{
    public interface IProjectionWithCustomAggregation<T, TAgg> : IProjection<int, T>
    {
        Type AggregateType { get; } // always return TAgg

        TAgg AggrgateRows(int[] rowIndices, int start, int count, IAggregationModeClass aggregationModeClass);

        IReadOnlyList<IAggregationModeClass> ExtraAggregationMode { get; }
    }
}
