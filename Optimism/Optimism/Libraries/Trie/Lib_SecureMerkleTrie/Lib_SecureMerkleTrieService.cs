using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using Optimism.Contracts.Libraries.Trie.Lib_SecureMerkleTrie.ContractDefinition;

namespace Optimism.Contracts.Libraries.Trie.Lib_SecureMerkleTrie
{
    public partial class Lib_SecureMerkleTrieService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, Lib_SecureMerkleTrieDeployment lib_SecureMerkleTrieDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<Lib_SecureMerkleTrieDeployment>().SendRequestAndWaitForReceiptAsync(lib_SecureMerkleTrieDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, Lib_SecureMerkleTrieDeployment lib_SecureMerkleTrieDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<Lib_SecureMerkleTrieDeployment>().SendRequestAsync(lib_SecureMerkleTrieDeployment);
        }

        public static async Task<Lib_SecureMerkleTrieService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, Lib_SecureMerkleTrieDeployment lib_SecureMerkleTrieDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, lib_SecureMerkleTrieDeployment, cancellationTokenSource);
            return new Lib_SecureMerkleTrieService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public Lib_SecureMerkleTrieService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}
