// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Event availability information when environment contains events. Contains time range of events and approximate distribution of events over time. </summary>
    public partial class EventAvailability
    {
        /// <summary> Initializes a new instance of EventAvailability. </summary>
        internal EventAvailability()
        {
            Distribution = new ChangeTrackingDictionary<string, int>();
        }

        /// <summary> Initializes a new instance of EventAvailability. </summary>
        /// <param name="range"> Minimum and maximum values of event timestamp ($ts) property. </param>
        /// <param name="intervalSize"> Interval size for the returned distribution of the events. Returned interval is selected to return a reasonable number of points. All intervals are the same size. On the wire interval is specified in ISO-8601 duration format. One month is always converted to 30 days, and one year is always 365 days. Examples: 1 minute is &quot;PT1M&quot;, 1 millisecond is &quot;PT0.001S&quot;. For more information, see https://www.w3.org/TR/xmlschema-2/#duration. </param>
        /// <param name="distribution"> Dictionary of &lt;integer&gt;. </param>
        internal EventAvailability(DateTimeRange range, TimeSpan? intervalSize, IReadOnlyDictionary<string, int> distribution)
        {
            Range = range;
            IntervalSize = intervalSize;
            Distribution = distribution;
        }

        /// <summary> Minimum and maximum values of event timestamp ($ts) property. </summary>
        public DateTimeRange Range { get; }
        /// <summary> Interval size for the returned distribution of the events. Returned interval is selected to return a reasonable number of points. All intervals are the same size. On the wire interval is specified in ISO-8601 duration format. One month is always converted to 30 days, and one year is always 365 days. Examples: 1 minute is &quot;PT1M&quot;, 1 millisecond is &quot;PT0.001S&quot;. For more information, see https://www.w3.org/TR/xmlschema-2/#duration. </summary>
        public TimeSpan? IntervalSize { get; }
        /// <summary> Dictionary of &lt;integer&gt;. </summary>
        public IReadOnlyDictionary<string, int> Distribution { get; }
    }
}
