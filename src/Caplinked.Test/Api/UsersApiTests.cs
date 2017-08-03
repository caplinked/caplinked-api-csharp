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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UsersApiTests
    {
        private UsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersApi
            //Assert.IsInstanceOfType(typeof(UsersApi), instance, "instance is a UsersApi");
        }

        
        /// <summary>
        /// Test DeleteUsers
        /// </summary>
        [Test]
        public void DeleteUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //var response = instance.DeleteUsers(userId);
            //Assert.IsInstanceOf<StatusMessage> (response, "response is StatusMessage");
        }
        
        /// <summary>
        /// Test GetUsersMe
        /// </summary>
        [Test]
        public void GetUsersMeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUsersMe();
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test PostUsers
        /// </summary>
        [Test]
        public void PostUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userEmail = null;
            //string userFirstName = null;
            //string userLastName = null;
            //string userTimeZone = null;
            //var response = instance.PostUsers(userEmail, userFirstName, userLastName, userTimeZone);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
        /// <summary>
        /// Test PutUsersMe
        /// </summary>
        [Test]
        public void PutUsersMeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userEmail = null;
            //string userFirstName = null;
            //string userLastName = null;
            //string userTimeZone = null;
            //var response = instance.PutUsersMe(userEmail, userFirstName, userLastName, userTimeZone);
            //Assert.IsInstanceOf<User> (response, "response is User");
        }
        
    }

}
