using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Nethereum.ABI.Encoders;
using Nethereum.ABI.Util;
using Nethereum.Contracts;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Newtonsoft.Json;
using OptimismTemplate.Contracts.L2AddressRegistry;
using OptimismTemplate.Contracts.L2AddressRegistry.ContractDefinition;
using Xunit;

namespace OptimismTemplate.Testing
{
    public class AddressRegistryTests
    {

        [Fact]
        public async void ShouldDeployContractCreateNftMetadataUploadToIpfsAndMint()
        {
            var encoder = new Bytes32TypeEncoder();

            var web3l2 = new Web3(new Account("0x754fde3f5e60ef2c7649061e06957c29017fe21032a8017132c0078e37f6193a", 420), "http://localhost:8545");
            var ourAdddress = "0x023ffdc1530468eb8c8eebc3e38380b5bc19cc5d";

            var myAddressRegistryDeployment = new L2AddressRegistryDeployment()
            {
                Gas = 7000000
            };

            var receipt = await L2AddressRegistryService.DeployContractAndWaitForReceiptAsync(web3l2, myAddressRegistryDeployment);

            var byteCode = await web3l2.Eth.GetCode.SendRequestAsync(receipt.ContractAddress);

            var service = new L2AddressRegistryService(web3l2, receipt.ContractAddress);

            RegisterAddressFunction registerFunction = new RegisterAddressFunction()
            {
                RegContractAddress = "0x89205A3A3b2A69De6Dbf7f01ED13B2108B2c43e7",
                ContractName = encoder.Encode(new String("AcmeCharityERC20")),
                Gas = 7000000
            };

            var registerReceipt = await service.RegisterAddressRequestAndWaitForReceiptAsync(registerFunction);

            var contractAddress = await service.GetAddressQueryAsync(encoder.Encode("AcmeCharityERC20"));

            Assert.Equal("0x89205A3A3b2A69De6Dbf7f01ED13B2108B2c43e7".ToLower(), contractAddress);

        }

    }
}