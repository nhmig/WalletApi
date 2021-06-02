using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using WalletService;
using WalletService.Model;

namespace WalletApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WalletController : ControllerBase
    {
        private readonly ILogger<WalletController> _logger; //TODO логирование в БД?
        private readonly IWalletService _walletService;


        public WalletController(ILogger<WalletController> logger, IWalletService walletService)
        {
            _logger = logger;
            _walletService = walletService;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> AddCash(OperationDepositAndWithdrawal oper)
        {
            var guid = await _walletService.Put(oper);
            return new OkObjectResult(guid);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> SubCash(OperationDepositAndWithdrawal oper)
        {
            var guid = await _walletService.Withdraw(oper);
            return new OkObjectResult(guid);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> TransferCash(OperationTransferWithinAccount oper)
        {
            var guid = await _walletService.Transfer(oper);
            return new OkObjectResult(guid);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Wallet>> StateWallet(Guid user)
        {
            Wallet wallet = await _walletService.State(user);
            return new OkObjectResult(wallet);
        }
    }
}
