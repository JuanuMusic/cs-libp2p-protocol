using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LibP2P.Protocol.Tests
{
    public class ProtocolIdTests
    {
        [Test]
        public void Constructor_GivenProtocol_ReturnsValidProtocolId()
        {
            var pid = new ProtocolId("/test/pid");

            Assert.AreEqual(pid.ToString(), "/test/pid");
        }

        [Test]
        public void Equals_GivenTwoEqualIds_ReturnsEquality()
        {
            var pid1 = new ProtocolId("/test/pid");
            var pid2 = new ProtocolId("/test/pid");

            Assert.AreEqual(pid1, pid2);
        }

        [Test]
        public void Equals_GivenTwoNotEqualIds_ReturnsNoEquality()
        {
            var pid1 = new ProtocolId("/test/pid1");
            var pid2 = new ProtocolId("/test/pid2");

            Assert.AreNotEqual(pid1, pid2);
        }

        [Test]
        public void Cast_GivenString_ReturnsProtocolId()
        {
            var pids = "/test/pid";
            var pid = (ProtocolId) pids;

            Assert.IsInstanceOf<ProtocolId>(pid);
            Assert.AreEqual(pid.ToString(), pids);
        }

        [Test]
        public void Cast_GivenProtocolId_ReturnsString()
        {
            var pid = new ProtocolId("/test/pid");
            var pids = (string) pid;

            Assert.AreEqual(pids, pid.ToString());
        }
    }
}
