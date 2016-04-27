﻿using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using ToDoList.Controllers;
using ToDoList.Models;
using Xunit;

namespace ToDoLists.Tests
{
    public class ItemsControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            ItemsController controller = new ItemsController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            ViewResult indexView = new ItemsController().Index() as ViewResult;


         
            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Item>>(result);
        }
    }
}