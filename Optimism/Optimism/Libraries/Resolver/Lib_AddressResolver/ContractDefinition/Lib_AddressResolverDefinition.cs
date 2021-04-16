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

namespace Optimism.Contracts.Libraries.Resolver.Lib_AddressResolver.ContractDefinition
{


    public partial class Lib_AddressResolverDeployment : Lib_AddressResolverDeploymentBase
    {
        public Lib_AddressResolverDeployment() : base(BYTECODE) { }
        public Lib_AddressResolverDeployment(string byteCode) : base(byteCode) { }
    }

    public class Lib_AddressResolverDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public Lib_AddressResolverDeploymentBase() : base(BYTECODE) { }
        public Lib_AddressResolverDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class LibAddressManagerFunction : LibAddressManagerFunctionBase { }

    [Function("libAddressManager", "address")]
    public class LibAddressManagerFunctionBase : FunctionMessage
    {

    }

    public partial class ResolveFunction : ResolveFunctionBase { }

    [Function("resolve", "address")]
    public class ResolveFunctionBase : FunctionMessage
    {
        [Parameter("string", "_name", 1)]
        public virtual string Name { get; set; }
    }

    public partial class LibAddressManagerOutputDTO : LibAddressManagerOutputDTOBase { }

    [FunctionOutput]
    public class LibAddressManagerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class ResolveOutputDTO : ResolveOutputDTOBase { }

    [FunctionOutput]
    public class ResolveOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "_contract", 1)]
        public virtual string Contract { get; set; }
    }
}
