// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.Azure.AcceptanceTestsAzureParameterGrouping.Models
{
    using Fixtures.Azure;
    using Fixtures.Azure.AcceptanceTestsAzureParameterGrouping;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional parameters for the ParameterGrouping_PostMultiParamGroups
    /// operation.
    /// </summary>
    public partial class ParameterGroupingPostMultiParamGroupsSecondParamGroupInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ParameterGroupingPostMultiParamGroupsSecondParamGroupInner class.
        /// </summary>
        public ParameterGroupingPostMultiParamGroupsSecondParamGroupInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ParameterGroupingPostMultiParamGroupsSecondParamGroupInner class.
        /// </summary>
        /// <param name="queryTwo">Query parameter with default</param>
        public ParameterGroupingPostMultiParamGroupsSecondParamGroupInner(string headerTwo = default(string), int? queryTwo = default(int?))
        {
            HeaderTwo = headerTwo;
            QueryTwo = queryTwo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public string HeaderTwo { get; set; }

        /// <summary>
        /// Gets or sets query parameter with default
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public int? QueryTwo { get; set; }

    }
}
