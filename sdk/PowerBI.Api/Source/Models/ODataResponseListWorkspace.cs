// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V1.Models
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
    using Microsoft.PowerBI.Api.V1;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Odata response wrapper for a Power BI Workspace list
    /// </summary>
    public partial class ODataResponseListWorkspace
    {
        /// <summary>
        /// Initializes a new instance of the ODataResponseListWorkspace class.
        /// </summary>
        public ODataResponseListWorkspace()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataResponseListWorkspace class.
        /// </summary>
        /// <param name="value">The workspaces</param>
        public ODataResponseListWorkspace(string odatacontext = default(string), IList<Workspace> value = default(IList<Workspace>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// Gets or sets the workspaces
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Workspace> Value { get; set; }

    }
}
