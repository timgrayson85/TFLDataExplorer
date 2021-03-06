﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFLDataExplorer.Controllers;
using Microsoft.Extensions.Options;
using TFLDataExplorer.Models;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace TFLDataExplorer.Tests
{
    public class DLRControllerTests
    {

        [Fact]
        public async Task Index_Action_Returns_Line_List()
        {
            // Arrange
            // We're not testing the API call at this stage so just mock a list of lines.
            var mockLineList = new List<LineModel>
            {
                new LineModel { name = "DLR", modeName = "dlr" }
            };

            // Create some mock options to avoid Null Reference Exception
            MyOptions options = new MyOptions() { AppId = "Foo", AppKey = "Bar" }; 
                                                                               
            var mockOptions = new Mock<IOptions<MyOptions>>();
            mockOptions.Setup(x => x.Value)
                .Returns(options);

            // Mock the API caller to return the list of lines
            var mockAPIContextAsyc = new Mock<IAPIContextAsync>();
            mockAPIContextAsyc.Setup(x => x.GetObjectsAsync<LineModel>(It.IsAny<string>()))
                .ReturnsAsync(mockLineList);

            // Act
            DLRController dlrController = new DLRController(mockOptions.Object, mockAPIContextAsyc.Object);
            var actionResult = await dlrController.Index();
            var result = actionResult as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<LineModel>>(result.Model);

        }


    }
}
