﻿// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories
{
    /// <summary>
    /// Operations for managing data slice runs.
    /// </summary>
    public interface IDataSliceRunOperations
    {
        /// <summary>
        /// Gets a Data Slice Run instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='runId'>
        /// A unique Data Slice Run Id.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The get Data Slice Run operation response.
        /// </returns>
        Task<DataSliceRunGetResponse> GetAsync(string resourceGroupName, string dataFactoryName, string runId, CancellationToken cancellationToken);

        /// <summary>
        /// Gets logs for a data slice run
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='dataSliceRunId'>
        /// A unique data slice run instance id.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The data slice run get logs operation response.
        /// </returns>
        Task<DataSliceRunGetLogsResponse> GetLogsAsync(
            string resourceGroupName,
            string dataFactoryName,
            string dataSliceRunId,
            CancellationToken cancellationToken);

        /// <summary>
        /// Gets the first page of data slice run instances with the link to
        /// the next page.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data factory.
        /// </param>
        /// <param name='dataFactoryName'>
        /// A unique data factory instance name.
        /// </param>
        /// <param name='tableName'>
        /// A unique table instance name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for specifying the filters to list data slice runs of the table.
        /// format.
        /// </param>
        /// <returns>
        /// The List data slice runs operation response.
        /// </returns>
        Task<DataSliceRunListResponse> ListAsync(
            string resourceGroupName,
            string dataFactoryName,
            string tableName,
            DataSliceRunListParameters parameters,
            CancellationToken cancellationToken);

        /// <summary>
        /// Gets the next page of run instances with the link to the next page.
        /// </summary>
        /// <param name='nextLink'>
        /// The url to the next data slice runs page.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List data slice runs operation response.
        /// </returns>
        Task<DataSliceRunListResponse> ListNextAsync(string nextLink, CancellationToken cancellationToken);
    }
}