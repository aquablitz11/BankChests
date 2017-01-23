using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;

using Terraria;
using TerrariaApi.Server;
using TShockAPI;
using TShockAPI.Hooks;

namespace BankChests
{
    interface IBankChestContent
    {
        int UserID { get; }
        int UserChestID { get; }
        string ChestName { get; set; }
        Item[] Items { get; set; }
    }
}
