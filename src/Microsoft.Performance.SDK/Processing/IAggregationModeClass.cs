using System;

namespace Microsoft.Performance.SDK.Processing
{
    public interface IAggregationModeClass
    {
        Type AggregationType { get; }

        string AggregationName { get; }

        object AggrgateRows<TProjectionResult, TKeyProjectionResult>(int[] rowIndices, int start, int count,
            IProjection<int, TProjectionResult> projection, IProjection<int, TKeyProjectionResult> keyColumnProjection,
            Func<TProjectionResult, TProjectionResult, TProjectionResult> aggegationFuncBaseOnKeyColumn,
            TProjectionResult defaultTProjectionResult);
    }
}
