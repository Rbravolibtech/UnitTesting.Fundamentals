using System;
using System.Collections.Generic;
using System.Linq;
using Castle.Core.Smtp;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class HouseKeeperServiceTests
    {
        private string _statementFileName;
        private object _statementGenerator;
        private Mock<TestNinja.Mocking.IEmailSender> _emailSender;
        private Mock<IXtraMessageBox> _messageBox;
        private HouseKeeperService _service;
        private Housekeeper _houseKeeper;

        [Test]
        public void SendStatementEmails_WhenCalled_GenerateStatements()
        {
            [SetUp]
            public void SetUp()
            {
                _houseKeeper = new Housekeeper { Email = "a", FullName = "b", Oid = 1, StatementEmailBody = "c" };

                var unitOfWork = new Mock<IUnitOfWork>();
                unitOfWork.Setup(uow => uow.Query<Housekeeper>()).Returns(new List<Housekeeper>
            {
                _houseKeeper
            }.AsQueryable());

                _statementFileName = "fileName";
                _statementGenerator = new Mock<IStatementGenerator>();
                _statementGenerator
                    .Setup(sg => sg.SaveStatement(_houseKeeper.Oid, _houseKeeper.FullName, _statementDate))
                    .Returns(() => _statementFileName);

                _emailSender = new Mock<TestNinja.Mocking.IEmailSender>();
                _messageBox = new Mock<IXtraMessageBox>();

                _service = new HouseKeeperService(
                    unitOfWork.Object,
                    _statementGenerator.Object,
                    _emailSender.Object,
                    _messageBox.Object);
            }


            [Test]
            public void SendStatementEmails_WhenCalled_GenerateStatements()
            {
                _service.SendStatementEmails(new DateTime(2017, 1, 1));

                _statementGenerator.Verify(sg => sg.SaveStatement(1, "b", (new DateTime(2017, 1, 1))));
            }

           


        }
    }

}
