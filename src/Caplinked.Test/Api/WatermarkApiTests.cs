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
    ///  Class for testing WatermarkApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WatermarkApiTests
    {
        private WatermarkApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WatermarkApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WatermarkApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WatermarkApi
            //Assert.IsInstanceOfType(typeof(WatermarkApi), instance, "instance is a WatermarkApi");
        }

        
        /// <summary>
        /// Test DeleteWatermarkId
        /// </summary>
        [Test]
        public void DeleteWatermarkIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.DeleteWatermarkId(id);
            //Assert.IsInstanceOf<StatusMessage> (response, "response is StatusMessage");
        }
        
        /// <summary>
        /// Test GetWatermarkId
        /// </summary>
        [Test]
        public void GetWatermarkIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //var response = instance.GetWatermarkId(id);
            //Assert.IsInstanceOf<CustomWatermarkSetting> (response, "response is CustomWatermarkSetting");
        }
        
        /// <summary>
        /// Test PostWatermark
        /// </summary>
        [Test]
        public void PostWatermarkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? teamId = null;
            //string customText = null;
            //string color = null;
            //float? opacity = null;
            //int? fontSize = null;
            //int? rotation = null;
            //string hposition = null;
            //string vposition = null;
            //bool? displayUserName = null;
            //bool? displayUserEmail = null;
            //bool? displayIpAddress = null;
            //bool? displayTime = null;
            //bool? displayWorkspaceName = null;
            //var response = instance.PostWatermark(teamId, customText, color, opacity, fontSize, rotation, hposition, vposition, displayUserName, displayUserEmail, displayIpAddress, displayTime, displayWorkspaceName);
            //Assert.IsInstanceOf<CustomWatermarkSetting> (response, "response is CustomWatermarkSetting");
        }
        
        /// <summary>
        /// Test PutWatermarkId
        /// </summary>
        [Test]
        public void PutWatermarkIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //string customText = null;
            //string color = null;
            //float? opacity = null;
            //int? fontSize = null;
            //int? rotation = null;
            //string hposition = null;
            //string vposition = null;
            //bool? displayUserName = null;
            //bool? displayUserEmail = null;
            //bool? displayIpAddress = null;
            //bool? displayTime = null;
            //bool? displayWorkspaceName = null;
            //var response = instance.PutWatermarkId(id, customText, color, opacity, fontSize, rotation, hposition, vposition, displayUserName, displayUserEmail, displayIpAddress, displayTime, displayWorkspaceName);
            //Assert.IsInstanceOf<CustomWatermarkSetting> (response, "response is CustomWatermarkSetting");
        }
        
    }

}
