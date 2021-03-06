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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Caplinked.Client;
using Caplinked.Api;
using Caplinked.Model;

namespace Caplinked.Test
{
    /// <summary>
    ///  Class for testing FoldersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FoldersApiTests
    {
        private FoldersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FoldersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FoldersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FoldersApi
            //Assert.IsInstanceOfType(typeof(FoldersApi), instance, "instance is a FoldersApi");
        }

        
        /// <summary>
        /// Test DeleteFoldersId
        /// </summary>
        [Test]
        public void DeleteFoldersIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string workspaceId = null;
            //var response = instance.DeleteFoldersId(id, workspaceId);
            //Assert.IsInstanceOf<FolderDelete> (response, "response is FolderDelete");
        }
        
        /// <summary>
        /// Test GetFoldersId
        /// </summary>
        [Test]
        public void GetFoldersIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string workspaceId = null;
            //var response = instance.GetFoldersId(id, workspaceId);
            //Assert.IsInstanceOf<FolderContent> (response, "response is FolderContent");
        }
        
        /// <summary>
        /// Test PostFolders
        /// </summary>
        [Test]
        public void PostFoldersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workspaceId = null;
            //string name = null;
            //int? parentId = null;
            //var response = instance.PostFolders(workspaceId, name, parentId);
            //Assert.IsInstanceOf<FolderMeta> (response, "response is FolderMeta");
        }
        
        /// <summary>
        /// Test PostFoldersIdCopy
        /// </summary>
        [Test]
        public void PostFoldersIdCopyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string workspaceId = null;
            //int? destinationFolderId = null;
            //var response = instance.PostFoldersIdCopy(id, workspaceId, destinationFolderId);
            //Assert.IsInstanceOf<FolderCopyMove> (response, "response is FolderCopyMove");
        }
        
        /// <summary>
        /// Test PostFoldersIdMove
        /// </summary>
        [Test]
        public void PostFoldersIdMoveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string workspaceId = null;
            //int? destinationFolderId = null;
            //var response = instance.PostFoldersIdMove(id, workspaceId, destinationFolderId);
            //Assert.IsInstanceOf<FolderCopyMove> (response, "response is FolderCopyMove");
        }
        
        /// <summary>
        /// Test PutFoldersId
        /// </summary>
        [Test]
        public void PutFoldersIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string workspaceId = null;
            //string folderName = null;
            //int? folderIndex = null;
            //var response = instance.PutFoldersId(id, workspaceId, folderName, folderIndex);
            //Assert.IsInstanceOf<FolderMeta> (response, "response is FolderMeta");
        }
        
    }

}
