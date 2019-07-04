using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace address_book_desktop
{
    [TestFixture]
    public class GroupDeleteTests : TestBase
    {
        [Test]
        public void TestGroupDelete()
        {
            List<GroupData> oldList = app.Groups.GetList();

            GroupData forDelete = oldList[0];

            app.Groups.Delete(forDelete);

            List<GroupData> newList = app.Groups.GetList();
            oldList.RemoveAt(1);
            oldList.Sort();
            newList.Sort();

            Assert.AreEqual(newList, oldList);
        }

    }
}
