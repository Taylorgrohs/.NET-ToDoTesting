using System;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList.Models;
using Xunit;

namespace ToDoList.Tests
{
    public class ItemsControllerTest
    {
        [Fact]
        public void Post_MethodAddsItem_Test()
        {
            // Arrange
            ItemsController controller = new ItemsController();
            Item testItem = new Item();
            testItem.Description = "test item";

            // Act
            controller.Create(testItem);
            ViewResult indexView = new ItemsController().Index() as ViewResult;
            var collection = indexView.ViewData.Model as IEnumerable<Item>;

            // Assert
            Assert.Contains<Item>(testItem, collection);
        }
    }
}