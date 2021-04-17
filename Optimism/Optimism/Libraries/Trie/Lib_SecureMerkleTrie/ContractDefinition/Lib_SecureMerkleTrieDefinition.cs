using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Optimism.Contracts.Libraries.Trie.Lib_SecureMerkleTrie.ContractDefinition
{
    public partial class Lib_SecureMerkleTrieDeployment : Lib_SecureMerkleTrieDeploymentBase
    {
        public Lib_SecureMerkleTrieDeployment() : base(BYTECODE) { }
        public Lib_SecureMerkleTrieDeployment(string byteCode) : base(byteCode) { }
    }

    public class Lib_SecureMerkleTrieDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60566023600b82828239805160001a607314601657fe5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea2646970667358221220fe09b530abdf2a64d7903e74d249549e51ea1026ba560eb23cb8d9ad0b7db33464736f6c63430007060033";
        public Lib_SecureMerkleTrieDeploymentBase() : base(BYTECODE) { }
        public Lib_SecureMerkleTrieDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
