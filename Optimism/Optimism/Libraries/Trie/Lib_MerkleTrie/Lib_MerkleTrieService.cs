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
using Optimism.Contracts.Libraries.Trie.Lib_MerkleTrie.ContractDefinition;

namespace Optimism.Contracts.Libraries.Trie.Lib_MerkleTrie
{
    public partial class Lib_MerkleTrieService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, Lib_MerkleTrieDeployment lib_MerkleTrieDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<Lib_MerkleTrieDeployment>().SendRequestAndWaitForReceiptAsync(lib_MerkleTrieDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, Lib_MerkleTrieDeployment lib_MerkleTrieDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<Lib_MerkleTrieDeployment>().SendRequestAsync(lib_MerkleTrieDeployment);
        }

        public static async Task<Lib_MerkleTrieService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, Lib_MerkleTrieDeployment lib_MerkleTrieDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, lib_MerkleTrieDeployment, cancellationTokenSource);
            return new Lib_MerkleTrieService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public Lib_MerkleTrieService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}
