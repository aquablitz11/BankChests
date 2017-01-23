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
    interface IBankChestContentManager
    {
        void SaveUserChests(int userID, IList<IBankChestContent> chestContents);
        IList<IBankChestContent> GetUserChests(int userID);
    }
}
