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

namespace Optimism.Contracts.Libraries.Trie.Lib_MerkleTrie.ContractDefinition
{
    public partial class Lib_MerkleTrieDeployment : Lib_MerkleTrieDeploymentBase
    {
        public Lib_MerkleTrieDeployment() : base(BYTECODE) { }
        public Lib_MerkleTrieDeployment(string byteCode) : base(byteCode) { }
    }

    public class Lib_MerkleTrieDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60566023600b82828239805160001a607314601657fe5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea26469706673582212205be302b79a2048c877af91d0ff2b0d3ea7a4060c81a0bd6cfe15998ad48dba4f64736f6c63430007060033";
        public Lib_MerkleTrieDeploymentBase() : base(BYTECODE) { }
        public Lib_MerkleTrieDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
