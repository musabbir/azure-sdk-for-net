// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The VNet solution for linker. </summary>
    internal partial class VnetSolution
    {
        /// <summary> Initializes a new instance of VnetSolution. </summary>
        public VnetSolution()
        {
        }

        /// <summary> Initializes a new instance of VnetSolution. </summary>
        /// <param name="solutionType"> Type of VNet solution. </param>
        internal VnetSolution(VnetSolutionType? solutionType)
        {
            SolutionType = solutionType;
        }

        /// <summary> Type of VNet solution. </summary>
        public VnetSolutionType? SolutionType { get; set; }
    }
}
