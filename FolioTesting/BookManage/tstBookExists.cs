﻿using System;
using FolioClasses.BookManage;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FolioTesting.BookManage
{
    [TestClass]
    public class tstBookExists
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsBook ABook = new clsBook();
            Assert.IsNotNull(ABook);
        }
    }
}
