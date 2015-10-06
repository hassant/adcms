/*******************************************************************************
 * Copyright 2014 Persistent Systems Ltd.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 ******************************************************************************/
using System;

namespace Azure.DataCenterMigration.Models
{
    /// <summary>
    ///  Model class for Blob
    /// </summary>
    public class Blob
    {
        #region Properties
        /// <summary>
        /// Blob name
        /// </summary>
        public string BlobName { get; set; }

        /// <summary>
        /// Blob storage uri
        /// </summary>
        public Uri BlobURI { get; set; }

        /// <summary>
        /// Type of blob. (page blob or block blob)
        /// </summary>
        public string BlobType { get; set; }

        /// <summary>
        /// Blob content type
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        ///  Exclude the blob from import 
        /// </summary>
        public bool IsExcluded { get; set; }

        /// <summary>
        ///  Status of blob import 
        /// </summary>
        public bool IsImported { get; set; }
        #endregion
    }
}
