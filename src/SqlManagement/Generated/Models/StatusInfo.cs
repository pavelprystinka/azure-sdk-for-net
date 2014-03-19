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

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// Status of a DAC import.
    /// </summary>
    public partial class StatusInfo
    {
        private Uri _blobUri;
        
        /// <summary>
        /// Optional. Gets or sets the URI of the DAC file stored in Windows
        /// Azure Blob Storage to be imported.
        /// </summary>
        public Uri BlobUri
        {
            get { return this._blobUri; }
            set { this._blobUri = value; }
        }
        
        private string _databaseName;
        
        /// <summary>
        /// Optional. Gets or sets the name of the database into which this DAC
        /// will be imported.
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }
        
        private string _errorMessage;
        
        /// <summary>
        /// Optional. Gets or sets the error message of the request if the
        /// request failed in some way.
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }
        
        private DateTime _lastModifiedTime;
        
        /// <summary>
        /// Optional. Gets or sets the last time the status changed.
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }
        
        private DateTime _queuedTime;
        
        /// <summary>
        /// Optional. Gets or sets the time at which the import/export request
        /// was queued and the process initiated.
        /// </summary>
        public DateTime QueuedTime
        {
            get { return this._queuedTime; }
            set { this._queuedTime = value; }
        }
        
        private string _requestId;
        
        /// <summary>
        /// Optional. Gets or sets the request ID of this import/export
        /// request, so that it can be tracked with future calls to GetStatus.
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }
        
        private string _requestType;
        
        /// <summary>
        /// Optional. Gets or sets the type (Import/Export) of this request.
        /// </summary>
        public string RequestType
        {
            get { return this._requestType; }
            set { this._requestType = value; }
        }
        
        private string _serverName;
        
        /// <summary>
        /// Optional. Gets or sets the name of the SQL database server into
        /// which this DAC will be imported or from which it will be exported.
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Gets or sets the status of the import/export request.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StatusInfo class.
        /// </summary>
        public StatusInfo()
        {
        }
    }
}
