using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Orleans.Runtime.Configuration;
using Orleans;
using Author.WriteContract.IFacade;
using Author.WriteContract.Dtos;
using System.Threading.Tasks;

namespace Author.API.Tests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public async Task  TestMethod1()
        {
            var config = ClientConfiguration.LocalhostSilo();
            GrainClient.Initialize(config);
            var userService = GrainClient.GrainFactory.GetGrain<IRoleFacades>(0);
            var _model = new RouleDto() { RoleName = "111111" };
            await userService.CreateRoule(_model);
        }
    }
}
