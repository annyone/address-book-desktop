﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace address_book_desktop
{
    public class TestBase
    {
        public ApplicationManager app;

        [TestFixtureSetUp]
        public void InitApp()
        {
            app = new ApplicationManager();
        }

        [TestFixtureTearDown]
        public void StopApp()
        {
            app.Stop();
        }
    }
}
