using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PETSurv;
using PETSurv.Model;

namespace PETUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        PETFunc func = new PETFunc();
        [TestMethod]
        public void AddAgentTest()
        {
            Persons agentPerson = new Persons
            {
                Name = "test name",
                Address = "test address",
                CPR = "test cpr",
                Height = 1,
                EyeColor = "eyecolor test"
            };

            Agents agent = new Agents()
            {
                Persons = agentPerson
            };

            func.AddAgent(agent);

            Assert.AreEqual(agent.Persons.Name, "test name");
            Assert.AreEqual(agent.Persons, agentPerson);
        }
    }
}
