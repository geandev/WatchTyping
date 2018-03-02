using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WatchTyping.Core.Models;
using WatchTyping.Core.Repositories;
using WatchTyping.Infra.Repositories;

namespace WatchTyping.Infra.Test.Repositories
{
    [TestClass]
    public class MessageRepositoryTest
    {
        private IMessageRepository _sut;

        public MessageRepositoryTest()
        {
            _sut = new MessageRepository();
        }

        [TestMethod]
        public void TestSaveMessage()
        {
            _sut.SaveMessageAsync(Message.CreateNew(Guid.NewGuid(), "Gean Alexandre")).Wait();
        }
    }
}
