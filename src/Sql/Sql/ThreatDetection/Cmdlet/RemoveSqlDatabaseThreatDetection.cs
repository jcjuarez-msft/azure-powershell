﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Sql.ThreatDetection.Model;
using System.Management.Automation;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;

namespace Microsoft.Azure.Commands.Sql.ThreatDetection.Cmdlet
{
    /// <summary>
    /// Clears advanced threat protection on a specific database.
    /// </summary>
    [GenericBreakingChange("Clear-AzSqlDatabaseAdvancedThreatProtectionSetting cmdlet will be removed in an upcoming breaking change release", "9.0.0")]
    [Cmdlet("Clear", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "SqlDatabaseAdvancedThreatProtectionSetting", SupportsShouldProcess = true),OutputType(typeof(DatabaseThreatDetectionPolicyModel))]
    public class AzureRmSqlDatabaseThreatDetection : SqlDatabaseThreatDetectionCmdletBase
    {
        /// <summary>
        ///  Defines whether the cmdlets will output the model object at the end of its execution
        /// </summary>
        [Parameter(Mandatory = false)]
        public SwitchParameter PassThru { get; set; }

        /// <summary>
        /// Returns true if the model object that was constructed by this cmdlet should be written out
        /// </summary>
        /// <returns>True if the model object should be written out, False otherwise</returns>
        protected override bool WriteResult() { return PassThru; }

        /// <summary>
        /// Updates the given model element with the cmdlet specific operation 
        /// </summary>
        /// <param name="model">A model object</param>
        protected override DatabaseThreatDetectionPolicyModel ApplyUserInputToModel(
            DatabaseThreatDetectionPolicyModel model)
        {
            model = base.ApplyUserInputToModel(model);
            model.ThreatDetectionState = ThreatDetectionStateType.Disabled;
            return model;
        }
    }
}
