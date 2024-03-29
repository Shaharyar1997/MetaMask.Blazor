﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaMask.Blazor.Enums
{
    /// <summary>
    /// https://docs.metamask.io/guide/ethereum-provider.html#chain-ids
    /// </summary>
    public enum Chain
    {
        Mainnet = 1,
        Ganache=2,
        Ropsten = 3,
        Rinkeby = 4,
        Goerli = 5,
        Kovan = 42,
        BinanceSmartChain = 56,
        BinanceTestnet = 97
    }
}
