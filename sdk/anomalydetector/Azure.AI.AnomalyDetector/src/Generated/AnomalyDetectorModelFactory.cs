// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.AnomalyDetector.Models;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class AnomalyDetectorModelFactory
    {
        /// <summary> Initializes a new instance of EntireDetectResponse. </summary>
        /// <param name="period"> Frequency extracted from the series, zero means no recurrent pattern has been found. </param>
        /// <param name="expectedValues"> ExpectedValues contain expected value for each input point. The index of the array is consistent with the input series. </param>
        /// <param name="upperMargins"> UpperMargins contain upper margin of each input point. UpperMargin is used to calculate upperBoundary, which equals to expectedValue + (100 - marginScale)*upperMargin. Anomalies in response can be filtered by upperBoundary and lowerBoundary. By adjusting marginScale value, less significant anomalies can be filtered in client side. The index of the array is consistent with the input series. </param>
        /// <param name="lowerMargins"> LowerMargins contain lower margin of each input point. LowerMargin is used to calculate lowerBoundary, which equals to expectedValue - (100 - marginScale)*lowerMargin. Points between the boundary can be marked as normal ones in client side. The index of the array is consistent with the input series. </param>
        /// <param name="isAnomaly"> IsAnomaly contains anomaly properties for each input point. True means an anomaly either negative or positive has been detected. The index of the array is consistent with the input series. </param>
        /// <param name="isNegativeAnomaly"> IsNegativeAnomaly contains anomaly status in negative direction for each input point. True means a negative anomaly has been detected. A negative anomaly means the point is detected as an anomaly and its real value is smaller than the expected one. The index of the array is consistent with the input series. </param>
        /// <param name="isPositiveAnomaly"> IsPositiveAnomaly contain anomaly status in positive direction for each input point. True means a positive anomaly has been detected. A positive anomaly means the point is detected as an anomaly and its real value is larger than the expected one. The index of the array is consistent with the input series. </param>
        /// <returns> A new <see cref="Models.EntireDetectResponse"/> instance for mocking. </returns>
        public static EntireDetectResponse EntireDetectResponse(int period = default, IEnumerable<float> expectedValues = null, IEnumerable<float> upperMargins = null, IEnumerable<float> lowerMargins = null, IEnumerable<bool> isAnomaly = null, IEnumerable<bool> isNegativeAnomaly = null, IEnumerable<bool> isPositiveAnomaly = null)
        {
            expectedValues ??= new List<float>();
            upperMargins ??= new List<float>();
            lowerMargins ??= new List<float>();
            isAnomaly ??= new List<bool>();
            isNegativeAnomaly ??= new List<bool>();
            isPositiveAnomaly ??= new List<bool>();

            return new EntireDetectResponse(period, expectedValues?.ToList(), upperMargins?.ToList(), lowerMargins?.ToList(), isAnomaly?.ToList(), isNegativeAnomaly?.ToList(), isPositiveAnomaly?.ToList());
        }

        /// <summary> Initializes a new instance of LastDetectResponse. </summary>
        /// <param name="period"> Frequency extracted from the series, zero means no recurrent pattern has been found. </param>
        /// <param name="suggestedWindow"> Suggested input series points needed for detecting the latest point. </param>
        /// <param name="expectedValue"> Expected value of the latest point. </param>
        /// <param name="upperMargin"> Upper margin of the latest point. UpperMargin is used to calculate upperBoundary, which equals to expectedValue + (100 - marginScale)*upperMargin. If the value of latest point is between upperBoundary and lowerBoundary, it should be treated as normal value. By adjusting marginScale value, anomaly status of latest point can be changed. </param>
        /// <param name="lowerMargin"> Lower margin of the latest point. LowerMargin is used to calculate lowerBoundary, which equals to expectedValue - (100 - marginScale)*lowerMargin. </param>
        /// <param name="isAnomaly"> Anomaly status of the latest point, true means the latest point is an anomaly either in negative direction or positive direction. </param>
        /// <param name="isNegativeAnomaly"> Anomaly status in negative direction of the latest point. True means the latest point is an anomaly and its real value is smaller than the expected one. </param>
        /// <param name="isPositiveAnomaly"> Anomaly status in positive direction of the latest point. True means the latest point is an anomaly and its real value is larger than the expected one. </param>
        /// <returns> A new <see cref="Models.LastDetectResponse"/> instance for mocking. </returns>
        public static LastDetectResponse LastDetectResponse(int period = default, int suggestedWindow = default, float expectedValue = default, float upperMargin = default, float lowerMargin = default, bool isAnomaly = default, bool isNegativeAnomaly = default, bool isPositiveAnomaly = default)
        {
            return new LastDetectResponse(period, suggestedWindow, expectedValue, upperMargin, lowerMargin, isAnomaly, isNegativeAnomaly, isPositiveAnomaly);
        }

        /// <summary> Initializes a new instance of ChangePointDetectResponse. </summary>
        /// <param name="period"> Frequency extracted from the series, zero means no recurrent pattern has been found. </param>
        /// <param name="isChangePoint"> isChangePoint contains change point properties for each input point. True means an anomaly either negative or positive has been detected. The index of the array is consistent with the input series. </param>
        /// <param name="confidenceScores"> the change point confidence of each point. </param>
        /// <returns> A new <see cref="Models.ChangePointDetectResponse"/> instance for mocking. </returns>
        public static ChangePointDetectResponse ChangePointDetectResponse(int? period = null, IEnumerable<bool> isChangePoint = null, IEnumerable<float> confidenceScores = null)
        {
            isChangePoint ??= new List<bool>();
            confidenceScores ??= new List<float>();

            return new ChangePointDetectResponse(period, isChangePoint?.ToList(), confidenceScores?.ToList());
        }

        /// <summary> Initializes a new instance of ModelInfo. </summary>
        /// <param name="slidingWindow"> An optional field, indicates how many history points will be used to determine the anomaly score of one subsequent point. </param>
        /// <param name="alignPolicy"> An optional field, since those multivariate need to be aligned in the same timestamp before starting the detection. </param>
        /// <param name="source"> source file link of the input variables, each variable will be a csv with two columns, the first column will be timestamp, the second column will be value.Besides these variable csv files, an extra meta.json can be included in th zip file if you would like to rename a variable.Be default, the file name of the variable will be used as the variable name. </param>
        /// <param name="startTime"> require field, start time of data be used for generating multivariate anomaly detection model, should be data-time. </param>
        /// <param name="endTime"> require field, end time of data be used for generating multivariate anomaly detection model, should be data-time. </param>
        /// <param name="displayName"> optional field, name of the model. </param>
        /// <param name="status"> Model training status. </param>
        /// <param name="errors"> Error message when fails to create a model. </param>
        /// <param name="diagnosticsInfo"> Used for deep analysis model and variables. </param>
        /// <returns> A new <see cref="Models.ModelInfo"/> instance for mocking. </returns>
        public static ModelInfo ModelInfo(int? slidingWindow = null, AlignPolicy alignPolicy = null, string source = null, DateTimeOffset startTime = default, DateTimeOffset endTime = default, string displayName = null, ModelStatus? status = null, IEnumerable<ErrorResponse> errors = null, DiagnosticsInfo diagnosticsInfo = null)
        {
            errors ??= new List<ErrorResponse>();

            return new ModelInfo(slidingWindow, alignPolicy, source, startTime, endTime, displayName, status, errors?.ToList(), diagnosticsInfo);
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="code"> The error Code. </param>
        /// <param name="message"> A message explaining the error reported by the service. </param>
        /// <returns> A new <see cref="Models.ErrorResponse"/> instance for mocking. </returns>
        public static ErrorResponse ErrorResponse(string code = null, string message = null)
        {
            return new ErrorResponse(code, message);
        }

        /// <summary> Initializes a new instance of DiagnosticsInfo. </summary>
        /// <param name="modelState"> . </param>
        /// <param name="variableStates"> . </param>
        /// <returns> A new <see cref="Models.DiagnosticsInfo"/> instance for mocking. </returns>
        public static DiagnosticsInfo DiagnosticsInfo(ModelState modelState = null, IEnumerable<VariableState> variableStates = null)
        {
            variableStates ??= new List<VariableState>();

            return new DiagnosticsInfo(modelState, variableStates?.ToList());
        }

        /// <summary> Initializes a new instance of ModelState. </summary>
        /// <param name="epochIds"> Epoch id. </param>
        /// <param name="trainLosses"> . </param>
        /// <param name="validationLosses"> . </param>
        /// <param name="latenciesInSeconds"> . </param>
        /// <returns> A new <see cref="Models.ModelState"/> instance for mocking. </returns>
        public static ModelState ModelState(IEnumerable<int> epochIds = null, IEnumerable<float> trainLosses = null, IEnumerable<float> validationLosses = null, IEnumerable<float> latenciesInSeconds = null)
        {
            epochIds ??= new List<int>();
            trainLosses ??= new List<float>();
            validationLosses ??= new List<float>();
            latenciesInSeconds ??= new List<float>();

            return new ModelState(epochIds?.ToList(), trainLosses?.ToList(), validationLosses?.ToList(), latenciesInSeconds?.ToList());
        }

        /// <summary> Initializes a new instance of VariableState. </summary>
        /// <param name="variable"> Variable name. </param>
        /// <param name="filledNARatio"> Merged NA ratio of a variable. </param>
        /// <param name="effectiveCount"> Effective time-series points count. </param>
        /// <param name="startTime"> Start time of a variable. </param>
        /// <param name="endTime"> End time of a variable. </param>
        /// <param name="errors"> Error message when parse variable. </param>
        /// <returns> A new <see cref="Models.VariableState"/> instance for mocking. </returns>
        public static VariableState VariableState(string variable = null, float? filledNARatio = null, int? effectiveCount = null, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, IEnumerable<ErrorResponse> errors = null)
        {
            errors ??= new List<ErrorResponse>();

            return new VariableState(variable, filledNARatio, effectiveCount, startTime, endTime, errors?.ToList());
        }

        /// <summary> Initializes a new instance of Model. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="createdTime"> Date and time (UTC) when the model was created. </param>
        /// <param name="lastUpdatedTime"> Date and time (UTC) when the model was last updated. </param>
        /// <param name="modelInfo"> Training Status of the model. </param>
        /// <returns> A new <see cref="Models.Model"/> instance for mocking. </returns>
        public static Model Model(Guid modelId = default, DateTimeOffset createdTime = default, DateTimeOffset lastUpdatedTime = default, ModelInfo modelInfo = null)
        {
            return new Model(modelId, createdTime, lastUpdatedTime, modelInfo);
        }

        /// <summary> Initializes a new instance of DetectionResult. </summary>
        /// <param name="resultId"> . </param>
        /// <param name="summary"> Multivariate anomaly detection status. </param>
        /// <param name="results"> anomaly status of each timestamp. </param>
        /// <returns> A new <see cref="Models.DetectionResult"/> instance for mocking. </returns>
        public static DetectionResult DetectionResult(Guid resultId = default, DetectionResultSummary summary = null, IEnumerable<AnomalyState> results = null)
        {
            results ??= new List<AnomalyState>();

            return new DetectionResult(resultId, summary, results?.ToList());
        }

        /// <summary> Initializes a new instance of DetectionResultSummary. </summary>
        /// <param name="status"> Multivariate anomaly detection status. </param>
        /// <param name="errors"> Error message when creating or training model fails. </param>
        /// <param name="variableStates"> . </param>
        /// <param name="setupInfo"> Request when creating the model. </param>
        /// <returns> A new <see cref="Models.DetectionResultSummary"/> instance for mocking. </returns>
        public static DetectionResultSummary DetectionResultSummary(DetectionStatus status = default, IEnumerable<ErrorResponse> errors = null, IEnumerable<VariableState> variableStates = null, DetectionRequest setupInfo = null)
        {
            errors ??= new List<ErrorResponse>();
            variableStates ??= new List<VariableState>();

            return new DetectionResultSummary(status, errors?.ToList(), variableStates?.ToList(), setupInfo);
        }

        /// <summary> Initializes a new instance of AnomalyState. </summary>
        /// <param name="timestamp"> timestamp. </param>
        /// <param name="value"> . </param>
        /// <param name="errors"> Error message when inference this timestamp. </param>
        /// <returns> A new <see cref="Models.AnomalyState"/> instance for mocking. </returns>
        public static AnomalyState AnomalyState(DateTimeOffset timestamp = default, AnomalyValue value = null, IEnumerable<ErrorResponse> errors = null)
        {
            errors ??= new List<ErrorResponse>();

            return new AnomalyState(timestamp, value, errors?.ToList());
        }

        /// <summary> Initializes a new instance of AnomalyValue. </summary>
        /// <param name="contributors"> If current timestamp is an anomaly, contributors will show potential root cause for thus anomaly. Contributors can help us understand why current timestamp has been detected as an anomaly. </param>
        /// <param name="isAnomaly"> To indicate whether current timestamp is anomaly or not. </param>
        /// <param name="severity"> anomaly score of the current timestamp, the more significant an anomaly is, the higher the score will be. </param>
        /// <param name="score"> anomaly score of the current timestamp, the more significant an anomaly is, the higher the score will be, score measures global significance. </param>
        /// <returns> A new <see cref="Models.AnomalyValue"/> instance for mocking. </returns>
        public static AnomalyValue AnomalyValue(IEnumerable<AnomalyContributor> contributors = null, bool isAnomaly = default, float severity = default, float? score = null)
        {
            contributors ??= new List<AnomalyContributor>();

            return new AnomalyValue(contributors?.ToList(), isAnomaly, severity, score);
        }

        /// <summary> Initializes a new instance of AnomalyContributor. </summary>
        /// <param name="contributionScore"> The higher the contribution score is, the more likely the variable to be the root cause of a anomaly. </param>
        /// <param name="variable"> Variable name of a contributor. </param>
        /// <returns> A new <see cref="Models.AnomalyContributor"/> instance for mocking. </returns>
        public static AnomalyContributor AnomalyContributor(float? contributionScore = null, string variable = null)
        {
            return new AnomalyContributor(contributionScore, variable);
        }

        /// <summary> Initializes a new instance of ModelSnapshot. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="createdTime"> Date and time (UTC) when the model was created. </param>
        /// <param name="lastUpdatedTime"> Date and time (UTC) when the model was last updated. </param>
        /// <param name="status"> Model training status. </param>
        /// <param name="displayName"> . </param>
        /// <param name="variablesCount"> Count of variables. </param>
        /// <returns> A new <see cref="Models.ModelSnapshot"/> instance for mocking. </returns>
        public static ModelSnapshot ModelSnapshot(Guid modelId = default, DateTimeOffset createdTime = default, DateTimeOffset lastUpdatedTime = default, ModelStatus status = default, string displayName = null, int variablesCount = default)
        {
            return new ModelSnapshot(modelId, createdTime, lastUpdatedTime, status, displayName, variablesCount);
        }
    }
}
