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
    ///  Class for testing PermissionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PermissionsApiTests
    {
        private PermissionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PermissionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PermissionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PermissionsApi
            //Assert.IsInstanceOfType(typeof(PermissionsApi), instance, "instance is a PermissionsApi");
        }

        
        /// <summary>
        /// Test GetPermissionsFoldersId
        /// </summary>
        [Test]
        public void GetPermissionsFoldersIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //int? workspaceId = null;
            //int? groupId = null;
            //var response = instance.GetPermissionsFoldersId(id, workspaceId, groupId);
            //Assert.IsInstanceOf<FolderList> (response, "response is FolderList");
        }
        
        /// <summary>
        /// Test PutPermissionsFoldersId
        /// </summary>
        [Test]
        public void PutPermissionsFoldersIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //int? workspaceId = null;
            //int? groupId = null;
            //string verb = null;
            //string folderAction = null;
            //var response = instance.PutPermissionsFoldersId(id, workspaceId, groupId, verb, folderAction);
            //Assert.IsInstanceOf<FolderUpdate> (response, "response is FolderUpdate");
        }
        
    }

}
