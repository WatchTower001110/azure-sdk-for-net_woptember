// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql.FlexibleServers;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> A list of long term retention backup operations for server. </summary>
    internal partial class PostgreSqlLtrServerBackupOperationList
    {
        /// <summary> Initializes a new instance of PostgreSqlLtrServerBackupOperationList. </summary>
        internal PostgreSqlLtrServerBackupOperationList()
        {
            Value = new ChangeTrackingList<PostgreSqlLtrServerBackupOperationData>();
        }

        /// <summary> Initializes a new instance of PostgreSqlLtrServerBackupOperationList. </summary>
        /// <param name="value"> The list of long term retention server backup operations. </param>
        /// <param name="nextLink"> The link used to get the next page of operations. </param>
        internal PostgreSqlLtrServerBackupOperationList(IReadOnlyList<PostgreSqlLtrServerBackupOperationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of long term retention server backup operations. </summary>
        public IReadOnlyList<PostgreSqlLtrServerBackupOperationData> Value { get; }
        /// <summary> The link used to get the next page of operations. </summary>
        public string NextLink { get; }
    }
}
