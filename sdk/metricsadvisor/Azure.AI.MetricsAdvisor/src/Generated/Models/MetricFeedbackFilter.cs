// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.MetricsAdvisor;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The MetricFeedbackFilter. </summary>
    internal partial class MetricFeedbackFilter
    {
        /// <summary> Initializes a new instance of MetricFeedbackFilter. </summary>
        /// <param name="metricId"> filter feedbacks by metric id. </param>
        public MetricFeedbackFilter(Guid metricId)
        {
            MetricId = metricId;
        }

        /// <summary> filter feedbacks by metric id. </summary>
        public Guid MetricId { get; }
        public FeedbackDimensionFilter DimensionFilter { get; set; }
        /// <summary> filter feedbacks by type. </summary>
        public MetricFeedbackKind? FeedbackType { get; set; }
        /// <summary> start time filter under chosen time mode. </summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary> end time filter under chosen time mode. </summary>
        public DateTimeOffset? EndTime { get; set; }
        /// <summary> time mode to filter feedback. </summary>
        public FeedbackQueryTimeMode? TimeMode { get; set; }
    }
}
