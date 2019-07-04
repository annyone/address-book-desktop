using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address_book_desktop
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            List<GroupData> oldList = app.Groups.GetList();

            GroupData newGroup = new GroupData()
            {
                Name = "Group"
            };

            app.Groups.Add(newGroup);

            List<GroupData> newList = app.Groups.GetList();
            oldList.Add(newGroup);
            oldList.Sort();
            newList.Sort();

            Assert.AreEqual(newList, oldList);
        }
    }
}
