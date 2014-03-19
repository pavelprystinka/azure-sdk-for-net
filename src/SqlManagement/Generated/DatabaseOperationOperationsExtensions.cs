// 
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

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Sql;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The SQL Database Management API is a REST API for managing SQL Database
    /// servers and the firewall rules associated with SQL Database servers.
    /// (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715283.aspx for
    /// more information)
    /// </summary>
    public static partial class DatabaseOperationOperationsExtensions
    {
        /// <summary>
        /// Returns information about one operation on a given operation Guid.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperationOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the SQL Server on which the operation was
        /// executed.
        /// </param>
        /// <param name='operationGuid'>
        /// Required. The Guid of the SQL Server database operation to be
        /// obtained.
        /// </param>
        /// <returns>
        /// Response containing the database operation for a given operation
        /// Guid.
        /// </returns>
        public static DatabaseOperationGetResponse Get(this IDatabaseOperationOperations operations, string serverName, string operationGuid)
        {
            try
            {
                return operations.GetAsync(serverName, operationGuid).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Returns information about one operation on a given operation Guid.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperationOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the SQL Server on which the operation was
        /// executed.
        /// </param>
        /// <param name='operationGuid'>
        /// Required. The Guid of the SQL Server database operation to be
        /// obtained.
        /// </param>
        /// <returns>
        /// Response containing the database operation for a given operation
        /// Guid.
        /// </returns>
        public static Task<DatabaseOperationGetResponse> GetAsync(this IDatabaseOperationOperations operations, string serverName, string operationGuid)
        {
            return operations.GetAsync(serverName, operationGuid, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns the list database operations for a given server and
        /// database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperationOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the SQL Server to be queried.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Database to be queried.
        /// </param>
        /// <returns>
        /// Response containing the list of database operations for a given
        /// server or database.
        /// </returns>
        public static DatabaseOperationListResponse ListByDatabase(this IDatabaseOperationOperations operations, string serverName, string databaseName)
        {
            try
            {
                return operations.ListByDatabaseAsync(serverName, databaseName).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Returns the list database operations for a given server and
        /// database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperationOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the SQL Server to be queried.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of the Database to be queried.
        /// </param>
        /// <returns>
        /// Response containing the list of database operations for a given
        /// server or database.
        /// </returns>
        public static Task<DatabaseOperationListResponse> ListByDatabaseAsync(this IDatabaseOperationOperations operations, string serverName, string databaseName)
        {
            return operations.ListByDatabaseAsync(serverName, databaseName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns the list database operations for a given server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperationOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the SQL Server to be queried.
        /// </param>
        /// <returns>
        /// Response containing the list of database operations for a given
        /// server or database.
        /// </returns>
        public static DatabaseOperationListResponse ListByServer(this IDatabaseOperationOperations operations, string serverName)
        {
            try
            {
                return operations.ListByServerAsync(serverName).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// Returns the list database operations for a given server.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Sql.IDatabaseOperationOperations.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the SQL Server to be queried.
        /// </param>
        /// <returns>
        /// Response containing the list of database operations for a given
        /// server or database.
        /// </returns>
        public static Task<DatabaseOperationListResponse> ListByServerAsync(this IDatabaseOperationOperations operations, string serverName)
        {
            return operations.ListByServerAsync(serverName, CancellationToken.None);
        }
    }
}
