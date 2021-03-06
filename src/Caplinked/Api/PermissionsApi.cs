/* 
 * CapLinked API v1.0
 *
 * Core information security endpoints for managing files/folders, users/groups, uploads/downloads, and more.
 *
 * OpenAPI spec version: 2017-05-23
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Caplinked.Client;
using Caplinked.Model;

namespace Caplinked.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPermissionsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List subfolder permissions
        /// </summary>
        /// <remarks>
        /// List subfolder permissions for a group. Will return an array of subfolders under the specified folder, along with their permissions information. For is_mixed_view, is_mixed_download, and is_mixed_upload: if attribute is set to true, it indicates that at least one (but not all) child folder with view, download, or upload attributes set to true, respectively. \&quot;All Folders\&quot; is the parent of all other folders within the workspace; its permissions will be returned if a folder is not specified.
        /// </remarks>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <returns>FolderList</returns>
        FolderList GetPermissionsFoldersId (int? id, int? workspaceId, int? groupId);

        /// <summary>
        /// List subfolder permissions
        /// </summary>
        /// <remarks>
        /// List subfolder permissions for a group. Will return an array of subfolders under the specified folder, along with their permissions information. For is_mixed_view, is_mixed_download, and is_mixed_upload: if attribute is set to true, it indicates that at least one (but not all) child folder with view, download, or upload attributes set to true, respectively. \&quot;All Folders\&quot; is the parent of all other folders within the workspace; its permissions will be returned if a folder is not specified.
        /// </remarks>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <returns>ApiResponse of FolderList</returns>
        ApiResponse<FolderList> GetPermissionsFoldersIdWithHttpInfo (int? id, int? workspaceId, int? groupId);
        /// <summary>
        /// Update folder permissions
        /// </summary>
        /// <remarks>
        /// Update folder permissions for a group. View &#x3D; TRUE, this means that group members can return the folder/file and its viewer image. Download &#x3D; TRUE, this means tha that group members can create download containing the folder. Upload &#x3D; TRUE, this mean that group members can create an upload object with the folder as a parent.
        /// </remarks>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <param name="verb">Grant or revoke permission for folder</param>
        /// <param name="folderAction">Permission type for folder</param>
        /// <returns>FolderUpdate</returns>
        FolderUpdate PutPermissionsFoldersId (int? id, int? workspaceId, int? groupId, string verb, string folderAction);

        /// <summary>
        /// Update folder permissions
        /// </summary>
        /// <remarks>
        /// Update folder permissions for a group. View &#x3D; TRUE, this means that group members can return the folder/file and its viewer image. Download &#x3D; TRUE, this means tha that group members can create download containing the folder. Upload &#x3D; TRUE, this mean that group members can create an upload object with the folder as a parent.
        /// </remarks>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <param name="verb">Grant or revoke permission for folder</param>
        /// <param name="folderAction">Permission type for folder</param>
        /// <returns>ApiResponse of FolderUpdate</returns>
        ApiResponse<FolderUpdate> PutPermissionsFoldersIdWithHttpInfo (int? id, int? workspaceId, int? groupId, string verb, string folderAction);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// List subfolder permissions
        /// </summary>
        /// <remarks>
        /// List subfolder permissions for a group. Will return an array of subfolders under the specified folder, along with their permissions information. For is_mixed_view, is_mixed_download, and is_mixed_upload: if attribute is set to true, it indicates that at least one (but not all) child folder with view, download, or upload attributes set to true, respectively. \&quot;All Folders\&quot; is the parent of all other folders within the workspace; its permissions will be returned if a folder is not specified.
        /// </remarks>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <returns>Task of FolderList</returns>
        System.Threading.Tasks.Task<FolderList> GetPermissionsFoldersIdAsync (int? id, int? workspaceId, int? groupId);

        /// <summary>
        /// List subfolder permissions
        /// </summary>
        /// <remarks>
        /// List subfolder permissions for a group. Will return an array of subfolders under the specified folder, along with their permissions information. For is_mixed_view, is_mixed_download, and is_mixed_upload: if attribute is set to true, it indicates that at least one (but not all) child folder with view, download, or upload attributes set to true, respectively. \&quot;All Folders\&quot; is the parent of all other folders within the workspace; its permissions will be returned if a folder is not specified.
        /// </remarks>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <returns>Task of ApiResponse (FolderList)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderList>> GetPermissionsFoldersIdAsyncWithHttpInfo (int? id, int? workspaceId, int? groupId);
        /// <summary>
        /// Update folder permissions
        /// </summary>
        /// <remarks>
        /// Update folder permissions for a group. View &#x3D; TRUE, this means that group members can return the folder/file and its viewer image. Download &#x3D; TRUE, this means tha that group members can create download containing the folder. Upload &#x3D; TRUE, this mean that group members can create an upload object with the folder as a parent.
        /// </remarks>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <param name="verb">Grant or revoke permission for folder</param>
        /// <param name="folderAction">Permission type for folder</param>
        /// <returns>Task of FolderUpdate</returns>
        System.Threading.Tasks.Task<FolderUpdate> PutPermissionsFoldersIdAsync (int? id, int? workspaceId, int? groupId, string verb, string folderAction);

        /// <summary>
        /// Update folder permissions
        /// </summary>
        /// <remarks>
        /// Update folder permissions for a group. View &#x3D; TRUE, this means that group members can return the folder/file and its viewer image. Download &#x3D; TRUE, this means tha that group members can create download containing the folder. Upload &#x3D; TRUE, this mean that group members can create an upload object with the folder as a parent.
        /// </remarks>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <param name="verb">Grant or revoke permission for folder</param>
        /// <param name="folderAction">Permission type for folder</param>
        /// <returns>Task of ApiResponse (FolderUpdate)</returns>
        System.Threading.Tasks.Task<ApiResponse<FolderUpdate>> PutPermissionsFoldersIdAsyncWithHttpInfo (int? id, int? workspaceId, int? groupId, string verb, string folderAction);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PermissionsApi : IPermissionsApi
    {
        private Caplinked.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PermissionsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Caplinked.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PermissionsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Caplinked.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Caplinked.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// List subfolder permissions List subfolder permissions for a group. Will return an array of subfolders under the specified folder, along with their permissions information. For is_mixed_view, is_mixed_download, and is_mixed_upload: if attribute is set to true, it indicates that at least one (but not all) child folder with view, download, or upload attributes set to true, respectively. \&quot;All Folders\&quot; is the parent of all other folders within the workspace; its permissions will be returned if a folder is not specified.
        /// </summary>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <returns>FolderList</returns>
        public FolderList GetPermissionsFoldersId (int? id, int? workspaceId, int? groupId)
        {
             ApiResponse<FolderList> localVarResponse = GetPermissionsFoldersIdWithHttpInfo(id, workspaceId, groupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List subfolder permissions List subfolder permissions for a group. Will return an array of subfolders under the specified folder, along with their permissions information. For is_mixed_view, is_mixed_download, and is_mixed_upload: if attribute is set to true, it indicates that at least one (but not all) child folder with view, download, or upload attributes set to true, respectively. \&quot;All Folders\&quot; is the parent of all other folders within the workspace; its permissions will be returned if a folder is not specified.
        /// </summary>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <returns>ApiResponse of FolderList</returns>
        public ApiResponse< FolderList > GetPermissionsFoldersIdWithHttpInfo (int? id, int? workspaceId, int? groupId)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PermissionsApi->GetPermissionsFoldersId");
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling PermissionsApi->GetPermissionsFoldersId");
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling PermissionsApi->GetPermissionsFoldersId");

            var localVarPath = "/permissions/folders/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (workspaceId != null) localVarQueryParams.Add("workspace_id", Configuration.ApiClient.ParameterToString(workspaceId)); // query parameter
            if (groupId != null) localVarQueryParams.Add("group_id", Configuration.ApiClient.ParameterToString(groupId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPermissionsFoldersId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FolderList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FolderList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FolderList)));
        }

        /// <summary>
        /// List subfolder permissions List subfolder permissions for a group. Will return an array of subfolders under the specified folder, along with their permissions information. For is_mixed_view, is_mixed_download, and is_mixed_upload: if attribute is set to true, it indicates that at least one (but not all) child folder with view, download, or upload attributes set to true, respectively. \&quot;All Folders\&quot; is the parent of all other folders within the workspace; its permissions will be returned if a folder is not specified.
        /// </summary>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <returns>Task of FolderList</returns>
        public async System.Threading.Tasks.Task<FolderList> GetPermissionsFoldersIdAsync (int? id, int? workspaceId, int? groupId)
        {
             ApiResponse<FolderList> localVarResponse = await GetPermissionsFoldersIdAsyncWithHttpInfo(id, workspaceId, groupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List subfolder permissions List subfolder permissions for a group. Will return an array of subfolders under the specified folder, along with their permissions information. For is_mixed_view, is_mixed_download, and is_mixed_upload: if attribute is set to true, it indicates that at least one (but not all) child folder with view, download, or upload attributes set to true, respectively. \&quot;All Folders\&quot; is the parent of all other folders within the workspace; its permissions will be returned if a folder is not specified.
        /// </summary>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <returns>Task of ApiResponse (FolderList)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FolderList>> GetPermissionsFoldersIdAsyncWithHttpInfo (int? id, int? workspaceId, int? groupId)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PermissionsApi->GetPermissionsFoldersId");
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling PermissionsApi->GetPermissionsFoldersId");
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling PermissionsApi->GetPermissionsFoldersId");

            var localVarPath = "/permissions/folders/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (workspaceId != null) localVarQueryParams.Add("workspace_id", Configuration.ApiClient.ParameterToString(workspaceId)); // query parameter
            if (groupId != null) localVarQueryParams.Add("group_id", Configuration.ApiClient.ParameterToString(groupId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPermissionsFoldersId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FolderList>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FolderList) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FolderList)));
        }

        /// <summary>
        /// Update folder permissions Update folder permissions for a group. View &#x3D; TRUE, this means that group members can return the folder/file and its viewer image. Download &#x3D; TRUE, this means tha that group members can create download containing the folder. Upload &#x3D; TRUE, this mean that group members can create an upload object with the folder as a parent.
        /// </summary>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <param name="verb">Grant or revoke permission for folder</param>
        /// <param name="folderAction">Permission type for folder</param>
        /// <returns>FolderUpdate</returns>
        public FolderUpdate PutPermissionsFoldersId (int? id, int? workspaceId, int? groupId, string verb, string folderAction)
        {
             ApiResponse<FolderUpdate> localVarResponse = PutPermissionsFoldersIdWithHttpInfo(id, workspaceId, groupId, verb, folderAction);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update folder permissions Update folder permissions for a group. View &#x3D; TRUE, this means that group members can return the folder/file and its viewer image. Download &#x3D; TRUE, this means tha that group members can create download containing the folder. Upload &#x3D; TRUE, this mean that group members can create an upload object with the folder as a parent.
        /// </summary>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <param name="verb">Grant or revoke permission for folder</param>
        /// <param name="folderAction">Permission type for folder</param>
        /// <returns>ApiResponse of FolderUpdate</returns>
        public ApiResponse< FolderUpdate > PutPermissionsFoldersIdWithHttpInfo (int? id, int? workspaceId, int? groupId, string verb, string folderAction)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PermissionsApi->PutPermissionsFoldersId");
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling PermissionsApi->PutPermissionsFoldersId");
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling PermissionsApi->PutPermissionsFoldersId");
            // verify the required parameter 'verb' is set
            if (verb == null)
                throw new ApiException(400, "Missing required parameter 'verb' when calling PermissionsApi->PutPermissionsFoldersId");
            // verify the required parameter 'folderAction' is set
            if (folderAction == null)
                throw new ApiException(400, "Missing required parameter 'folderAction' when calling PermissionsApi->PutPermissionsFoldersId");

            var localVarPath = "/permissions/folders/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (workspaceId != null) localVarFormParams.Add("workspace_id", Configuration.ApiClient.ParameterToString(workspaceId)); // form parameter
            if (groupId != null) localVarFormParams.Add("group_id", Configuration.ApiClient.ParameterToString(groupId)); // form parameter
            if (verb != null) localVarFormParams.Add("verb", Configuration.ApiClient.ParameterToString(verb)); // form parameter
            if (folderAction != null) localVarFormParams.Add("folder_action", Configuration.ApiClient.ParameterToString(folderAction)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutPermissionsFoldersId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FolderUpdate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FolderUpdate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FolderUpdate)));
        }

        /// <summary>
        /// Update folder permissions Update folder permissions for a group. View &#x3D; TRUE, this means that group members can return the folder/file and its viewer image. Download &#x3D; TRUE, this means tha that group members can create download containing the folder. Upload &#x3D; TRUE, this mean that group members can create an upload object with the folder as a parent.
        /// </summary>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <param name="verb">Grant or revoke permission for folder</param>
        /// <param name="folderAction">Permission type for folder</param>
        /// <returns>Task of FolderUpdate</returns>
        public async System.Threading.Tasks.Task<FolderUpdate> PutPermissionsFoldersIdAsync (int? id, int? workspaceId, int? groupId, string verb, string folderAction)
        {
             ApiResponse<FolderUpdate> localVarResponse = await PutPermissionsFoldersIdAsyncWithHttpInfo(id, workspaceId, groupId, verb, folderAction);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update folder permissions Update folder permissions for a group. View &#x3D; TRUE, this means that group members can return the folder/file and its viewer image. Download &#x3D; TRUE, this means tha that group members can create download containing the folder. Upload &#x3D; TRUE, this mean that group members can create an upload object with the folder as a parent.
        /// </summary>
        /// <exception cref="Caplinked.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of folder (0 for root)</param>
        /// <param name="workspaceId">ID of workspace</param>
        /// <param name="groupId">ID of group</param>
        /// <param name="verb">Grant or revoke permission for folder</param>
        /// <param name="folderAction">Permission type for folder</param>
        /// <returns>Task of ApiResponse (FolderUpdate)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FolderUpdate>> PutPermissionsFoldersIdAsyncWithHttpInfo (int? id, int? workspaceId, int? groupId, string verb, string folderAction)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling PermissionsApi->PutPermissionsFoldersId");
            // verify the required parameter 'workspaceId' is set
            if (workspaceId == null)
                throw new ApiException(400, "Missing required parameter 'workspaceId' when calling PermissionsApi->PutPermissionsFoldersId");
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new ApiException(400, "Missing required parameter 'groupId' when calling PermissionsApi->PutPermissionsFoldersId");
            // verify the required parameter 'verb' is set
            if (verb == null)
                throw new ApiException(400, "Missing required parameter 'verb' when calling PermissionsApi->PutPermissionsFoldersId");
            // verify the required parameter 'folderAction' is set
            if (folderAction == null)
                throw new ApiException(400, "Missing required parameter 'folderAction' when calling PermissionsApi->PutPermissionsFoldersId");

            var localVarPath = "/permissions/folders/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (workspaceId != null) localVarFormParams.Add("workspace_id", Configuration.ApiClient.ParameterToString(workspaceId)); // form parameter
            if (groupId != null) localVarFormParams.Add("group_id", Configuration.ApiClient.ParameterToString(groupId)); // form parameter
            if (verb != null) localVarFormParams.Add("verb", Configuration.ApiClient.ParameterToString(verb)); // form parameter
            if (folderAction != null) localVarFormParams.Add("folder_action", Configuration.ApiClient.ParameterToString(folderAction)); // form parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutPermissionsFoldersId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FolderUpdate>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FolderUpdate) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FolderUpdate)));
        }

    }
}
