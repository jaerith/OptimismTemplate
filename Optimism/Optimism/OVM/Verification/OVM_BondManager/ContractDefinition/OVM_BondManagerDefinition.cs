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

namespace Optimism.Contracts.OVM.Verification.OVM_BondManager.ContractDefinition
{


    public partial class OVM_BondManagerDeployment : OVM_BondManagerDeploymentBase
    {
        public OVM_BondManagerDeployment() : base(BYTECODE) { }
        public OVM_BondManagerDeployment(string byteCode) : base(byteCode) { }
    }

    public class OVM_BondManagerDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60a060405234801561001057600080fd5b5060405161132d38038061132d8339818101604052604081101561003357600080fd5b508051602090910151600080546001600160a01b0319166001600160a01b03928316178155606083901b6001600160601b03191660805291169061129a906100939039806107075280610d8f5280610ec35280611004525061129a6000f3fe608060405234801561001057600080fd5b50600436106101005760003560e01c8063abfbbe1311610097578063d0e30db011610066578063d0e30db014610305578063dc6453dc1461030d578063fc0c546a14610339578063fe10d7741461034157610100565b8063abfbbe13146102bb578063b53105a3146102ed578063bc2f8dd8146102f5578063c5b6aa2f146102fd57610100565b80631e83409a116100d35780631e83409a14610193578063299ca478146101b9578063461a4478146101dd5780635b7c615f1461028357610100565b806302ad4d2a146101055780630756183b1461013f5780631e0983bd1461013f5780631e16e92f14610159575b600080fd5b61012b6004803603602081101561011b57600080fd5b50356001600160a01b03166103aa565b604080519115158252519081900360200190f35b6101476103dc565b60408051918252519081900360200190f35b6101916004803603608081101561016f57600080fd5b508035906020810135906001600160a01b0360408201351690606001356103e3565b005b610191600480360360208110156101a957600080fd5b50356001600160a01b031661057c565b6101c1610809565b604080516001600160a01b039092168252519081900360200190f35b6101c1600480360360208110156101f357600080fd5b81019060208101813564010000000081111561020e57600080fd5b82018360208201111561022057600080fd5b8035906020019184600183028401116401000000008311171561024257600080fd5b91908080601f016020809104026020016040519081016040528093929190818152602001838380828437600092019190915250929550610818945050505050565b6102a06004803603602081101561029957600080fd5b50356108f4565b60408051921515835260208301919091528051918290030190f35b610191600480360360608110156102d157600080fd5b508035906001600160a01b036020820135169060400135610913565b610147610b1e565b610191610b2a565b610191610c50565b610191610e8f565b6101476004803603604081101561032357600080fd5b50803590602001356001600160a01b0316610fd7565b6101c1611002565b6103676004803603602081101561035757600080fd5b50356001600160a01b0316611026565b6040518086600281111561037757fe5b81526020018563ffffffff1681526020018481526020018381526020018281526020019550505050505060405180910390f35b600060016001600160a01b03831660009081526001602052604090205460ff1660028111156103d557fe5b1492915050565b62093a8081565b60006104176040518060400160405280601181526020017027ab26afa33930bab22b32b934b334b2b960791b815250610818565b6001600160a01b031663b48ec82086866040518363ffffffff1660e01b8152600401808381526020018281526020019250505060206040518083038186803b15801561046257600080fd5b505afa158015610476573d6000803e3d6000fd5b505050506040513d602081101561048c57600080fd5b5051604080516080810190915260518082529192506001600160a01b03831633149161114f60208301399061053f5760405162461bcd60e51b81526004018080602001828103825283818151815260200191508051906020019080838360005b838110156105045781810151838201526020016104ec565b50505050905090810190601f1680156105315780820380516001836020036101000a031916815260200191505b509250505060405180910390fd5b50506000938452600260208181526040808720600181018054860190556001600160a01b0390951687529390910190529220805490920190915550565b600060016000836001600160a01b03166001600160a01b03168152602001908152602001600020905062093a808160010154014210156040518060600160405280602e81526020016111d2602e9139906106175760405162461bcd60e51b81526020600482018181528351602484015283519092839260449091019190850190808383600083156105045781810151838201526020016104ec565b50600280820154600081815260209283526040908190208054825160608101909352603e8084529394919360ff909116929161105e908301399061069c5760405162461bcd60e51b81526020600482018181528351602484015283519092839260449091019190850190808383600083156105045781810151838201526020016104ec565b5060018101543360009081526002808401602052604082205491920290670de0b6b3a764000002816106ca57fe5b3360008181526002860160209081526040808320839055805163a9059cbb60e01b81526004810194909452949093046024830181905293519394507f00000000000000000000000000000000000000000000000000000000000000006001600160a01b03169363a9059cbb936044808501949193918390030190829087803b15801561075557600080fd5b505af1158015610769573d6000803e3d6000fd5b505050506040513d602081101561077f57600080fd5b50516040805180820190915260208082527f426f6e644d616e616765723a20436f756c64206e6f7420706f737420626f6e6490820152906108015760405162461bcd60e51b81526020600482018181528351602484015283519092839260449091019190850190808383600083156105045781810151838201526020016104ec565b505050505050565b6000546001600160a01b031681565b6000805460405163bf40fac160e01b81526020600482018181528551602484015285516001600160a01b039094169363bf40fac19387938392604490920191908501908083838b5b83811015610878578181015183820152602001610860565b50505050905090810190601f1680156108a55780820380516001836020036101000a031916815260200191505b509250505060206040518083038186803b1580156108c257600080fd5b505afa1580156108d6573d6000803e3d6000fd5b505050506040513d60208110156108ec57600080fd5b505192915050565b6002602052600090815260409020805460019091015460ff9091169082565b6109456040518060400160405280601181526020017027ab26afa33930bab22b32b934b334b2b960791b815250610818565b6001600160a01b0316336001600160a01b0316146040518060600160405280603b815260200161122a603b9139906109be5760405162461bcd60e51b81526020600482018181528351602484015283519092839260449091019190850190808383600083156105045781810151838201526020016104ec565b5060008381526002602090815260409182902054825160808101909352604b80845260ff9091161592916110dd9083013990610a3b5760405162461bcd60e51b81526020600482018181528351602484015283519092839260449091019190850190808383600083156105045781810151838201526020016104ec565b506000838152600260209081526040808320805460ff191660019081179091556001600160a01b03861684529182905290912090810154610a8f574260018201556002810184905560038101829055610abe565b62093a8081600101540142108015610aaa5750806003015482105b15610abe5760028101849055600381018290555b8054610100900463ffffffff1615801590610aea5750805462093a80830161010090910463ffffffff16115b8015610b0557506002815460ff166002811115610b0357fe5b145b15610b105750610b19565b805460ff191690555b505050565b670de0b6b3a764000081565b3360009081526001602090815260409182902080548351606081019094526027808552919361010090910463ffffffff1615929091906111289083013990610bb35760405162461bcd60e51b81526020600482018181528351602484015283519092839260449091019190850190808383600083156105045781810151838201526020016104ec565b506001815460ff166002811115610bc657fe5b146040518060600160405280602a8152602001611200602a913990610c2c5760405162461bcd60e51b81526020600482018181528351602484015283519092839260449091019190850190808383600083156105045781810151838201526020016104ec565b508054600260ff199091161764ffffffff0019166101004263ffffffff1602179055565b3360009081526001602090815260409182902080548351606081019094526032808552919363ffffffff6101009092049190911662093a8001421015929091906111a09083013990610ce35760405162461bcd60e51b81526020600482018181528351602484015283519092839260449091019190850190808383600083156105045781810151838201526020016104ec565b506002815460ff166002811115610cf657fe5b1460405180608001604052806041815260200161109c6041913990610d5c5760405162461bcd60e51b81526020600482018181528351602484015283519092839260449091019190850190808383600083156105045781810151838201526020016104ec565b50805464ffffffffff191681556040805163a9059cbb60e01b8152336004820152670de0b6b3a7640000602482015290517f00000000000000000000000000000000000000000000000000000000000000006001600160a01b03169163a9059cbb9160448083019260209291908290030181600087803b158015610ddf57600080fd5b505af1158015610df3573d6000803e3d6000fd5b505050506040513d6020811015610e0957600080fd5b50516040805180820190915260208082527f426f6e644d616e616765723a20436f756c64206e6f7420706f737420626f6e649082015290610e8b5760405162461bcd60e51b81526020600482018181528351602484015283519092839260449091019190850190808383600083156105045781810151838201526020016104ec565b5050565b604080516323b872dd60e01b8152336004820152306024820152670de0b6b3a7640000604482015290516001600160a01b037f000000000000000000000000000000000000000000000000000000000000000016916323b872dd9160648083019260209291908290030181600087803b158015610f0b57600080fd5b505af1158015610f1f573d6000803e3d6000fd5b505050506040513d6020811015610f3557600080fd5b50516040805180820190915260208082527f426f6e644d616e616765723a20436f756c64206e6f7420706f737420626f6e649082015290610fb75760405162461bcd60e51b81526020600482018181528351602484015283519092839260449091019190850190808383600083156105045781810151838201526020016104ec565b50336000908152600160208190526040909120805460ff19169091179055565b60008281526002602081815260408084206001600160a01b0386168552909201905290205492915050565b7f000000000000000000000000000000000000000000000000000000000000000081565b6001602081905260009182526040909120805491810154600282015460039092015460ff841693610100900463ffffffff1692908556fe426f6e644d616e616765723a2043616e6e6f7420636c61696d207965742e2044697370757465206d7573742062652066696e616c697a6564206669727374426f6e644d616e616765723a2043616e6e6f742066696e616c697a65207769746864726177616c2c20796f752070726f6261626c7920676f7420736c6173686564426f6e644d616e616765723a2046726175642070726f6f6620666f722074686973207072652d737461746520726f6f742068617320616c7265616479206265656e2066696e616c697a6564426f6e644d616e616765723a205769746864726177616c20616c72656164792070656e64696e67426f6e644d616e616765723a204f6e6c7920746865207472616e736974696f6e657220666f722074686973207072652d737461746520726f6f74206d61792063616c6c20746869732066756e6374696f6e426f6e644d616e616765723a20546f6f206561726c7920746f2066696e616c697a6520796f7572207769746864726177616c426f6e644d616e616765723a205761697420666f72206f7468657220706f74656e7469616c206469737075746573426f6e644d616e616765723a2057726f6e6720626f6e6420737461746520666f722070726f706f736572426f6e644d616e616765723a204f6e6c7920746865206672617564207665726966696572206d61792063616c6c20746869732066756e6374696f6ea2646970667358221220735f7c106ecd940c79ad288f97479f964b507dc97967c84701590ba83cc6a1b064736f6c63430007060033";
        public OVM_BondManagerDeploymentBase() : base(BYTECODE) { }
        public OVM_BondManagerDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_token", 1)]
        public virtual string Token { get; set; }
        [Parameter("address", "_libAddressManager", 2)]
        public virtual string LibAddressManager { get; set; }
    }

    public partial class BondsFunction : BondsFunctionBase { }

    [Function("bonds", typeof(BondsOutputDTO))]
    public class BondsFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class ClaimFunction : ClaimFunctionBase { }

    [Function("claim")]
    public class ClaimFunctionBase : FunctionMessage
    {
        [Parameter("address", "who", 1)]
        public virtual string Who { get; set; }
    }

    public partial class DepositFunction : DepositFunctionBase { }

    [Function("deposit")]
    public class DepositFunctionBase : FunctionMessage
    {

    }

    public partial class DisputePeriodSecondsFunction : DisputePeriodSecondsFunctionBase { }

    [Function("disputePeriodSeconds", "uint256")]
    public class DisputePeriodSecondsFunctionBase : FunctionMessage
    {

    }

    public partial class FinalizeFunction : FinalizeFunctionBase { }

    [Function("finalize")]
    public class FinalizeFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "_preStateRoot", 1)]
        public virtual byte[] PreStateRoot { get; set; }
        [Parameter("address", "publisher", 2)]
        public virtual string Publisher { get; set; }
        [Parameter("uint256", "timestamp", 3)]
        public virtual BigInteger Timestamp { get; set; }
    }

    public partial class FinalizeWithdrawalFunction : FinalizeWithdrawalFunctionBase { }

    [Function("finalizeWithdrawal")]
    public class FinalizeWithdrawalFunctionBase : FunctionMessage
    {

    }

    public partial class GetGasSpentFunction : GetGasSpentFunctionBase { }

    [Function("getGasSpent", "uint256")]
    public class GetGasSpentFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "preStateRoot", 1)]
        public virtual byte[] PreStateRoot { get; set; }
        [Parameter("address", "who", 2)]
        public virtual string Who { get; set; }
    }

    public partial class IsCollateralizedFunction : IsCollateralizedFunctionBase { }

    [Function("isCollateralized", "bool")]
    public class IsCollateralizedFunctionBase : FunctionMessage
    {
        [Parameter("address", "who", 1)]
        public virtual string Who { get; set; }
    }

    public partial class LibAddressManagerFunction : LibAddressManagerFunctionBase { }

    [Function("libAddressManager", "address")]
    public class LibAddressManagerFunctionBase : FunctionMessage
    {

    }

    public partial class MultiFraudProofPeriodFunction : MultiFraudProofPeriodFunctionBase { }

    [Function("multiFraudProofPeriod", "uint256")]
    public class MultiFraudProofPeriodFunctionBase : FunctionMessage
    {

    }

    public partial class RecordGasSpentFunction : RecordGasSpentFunctionBase { }

    [Function("recordGasSpent")]
    public class RecordGasSpentFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "_preStateRoot", 1)]
        public virtual byte[] PreStateRoot { get; set; }
        [Parameter("bytes32", "_txHash", 2)]
        public virtual byte[] TxHash { get; set; }
        [Parameter("address", "who", 3)]
        public virtual string Who { get; set; }
        [Parameter("uint256", "gasSpent", 4)]
        public virtual BigInteger GasSpent { get; set; }
    }

    public partial class RequiredCollateralFunction : RequiredCollateralFunctionBase { }

    [Function("requiredCollateral", "uint256")]
    public class RequiredCollateralFunctionBase : FunctionMessage
    {

    }

    public partial class ResolveFunction : ResolveFunctionBase { }

    [Function("resolve", "address")]
    public class ResolveFunctionBase : FunctionMessage
    {
        [Parameter("string", "_name", 1)]
        public virtual string Name { get; set; }
    }

    public partial class StartWithdrawalFunction : StartWithdrawalFunctionBase { }

    [Function("startWithdrawal")]
    public class StartWithdrawalFunctionBase : FunctionMessage
    {

    }

    public partial class TokenFunction : TokenFunctionBase { }

    [Function("token", "address")]
    public class TokenFunctionBase : FunctionMessage
    {

    }

    public partial class WitnessProvidersFunction : WitnessProvidersFunctionBase { }

    [Function("witnessProviders", typeof(WitnessProvidersOutputDTO))]
    public class WitnessProvidersFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class BondsOutputDTO : BondsOutputDTOBase { }

    [FunctionOutput]
    public class BondsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "state", 1)]
        public virtual byte State { get; set; }
        [Parameter("uint32", "withdrawalTimestamp", 2)]
        public virtual uint WithdrawalTimestamp { get; set; }
        [Parameter("uint256", "firstDisputeAt", 3)]
        public virtual BigInteger FirstDisputeAt { get; set; }
        [Parameter("bytes32", "earliestDisputedStateRoot", 4)]
        public virtual byte[] EarliestDisputedStateRoot { get; set; }
        [Parameter("uint256", "earliestTimestamp", 5)]
        public virtual BigInteger EarliestTimestamp { get; set; }
    }





    public partial class DisputePeriodSecondsOutputDTO : DisputePeriodSecondsOutputDTOBase { }

    [FunctionOutput]
    public class DisputePeriodSecondsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }





    public partial class GetGasSpentOutputDTO : GetGasSpentOutputDTOBase { }

    [FunctionOutput]
    public class GetGasSpentOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class IsCollateralizedOutputDTO : IsCollateralizedOutputDTOBase { }

    [FunctionOutput]
    public class IsCollateralizedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class LibAddressManagerOutputDTO : LibAddressManagerOutputDTOBase { }

    [FunctionOutput]
    public class LibAddressManagerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class MultiFraudProofPeriodOutputDTO : MultiFraudProofPeriodOutputDTOBase { }

    [FunctionOutput]
    public class MultiFraudProofPeriodOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class RequiredCollateralOutputDTO : RequiredCollateralOutputDTOBase { }

    [FunctionOutput]
    public class RequiredCollateralOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class ResolveOutputDTO : ResolveOutputDTOBase { }

    [FunctionOutput]
    public class ResolveOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "_contract", 1)]
        public virtual string Contract { get; set; }
    }



    public partial class TokenOutputDTO : TokenOutputDTOBase { }

    [FunctionOutput]
    public class TokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class WitnessProvidersOutputDTO : WitnessProvidersOutputDTOBase { }

    [FunctionOutput]
    public class WitnessProvidersOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "canClaim", 1)]
        public virtual bool CanClaim { get; set; }
        [Parameter("uint256", "total", 2)]
        public virtual BigInteger Total { get; set; }
    }
}