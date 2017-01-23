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
    [ApiVersion(2, 0)]
    public class BankChestsPlugin : TerrariaPlugin
    {
        public override string Name { get { return "BankChests"; } }
        public override string Description { get { return "More Piggy Bank (AKA Dimensional Box for box lovers)"; } }
        public override string Author { get { return "AquaBlitz11"; } }
        public override Version Version { get { return Assembly.GetExecutingAssembly().GetName().Version; } }
        public BankChestsPlugin(Main game) : base(game) { }

        IBankChestsConfig config;
        IWorldBankChestManager worldChestDB;
        IBankChestContentManager chestContentDB;

        IDictionary<Vector2, IWorldBankChest> bankChests;
        IDictionary<int, IList<IBankChestContent>> chestContents;

        public override void Initialize()
        {
            ServerApi.Hooks.GameInitialize.Register(this, onInitialize);
            // add onWorldLoaded hook
            PlayerHooks.PlayerPostLogin += onPlayerLogin;
            ServerApi.Hooks.NetGetData.Register(this, onGetData);
            PlayerHooks.PlayerLogout += onPlayerLogout;
        }

        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                ServerApi.Hooks.GameInitialize.Deregister(this, onInitialize);
                // remove onWorldLoaded hook
                PlayerHooks.PlayerPostLogin -= onPlayerLogin;
                ServerApi.Hooks.NetGetData.Deregister(this, onGetData);
                PlayerHooks.PlayerLogout -= onPlayerLogout;
            }
            base.Dispose(Disposing);
        }


        private void onInitialize(EventArgs args)
        {
            // read config
            // initialize player db
        }

        private void onWorldLoaded(EventArgs args)
        {
            // initialize world db
        }

        private void onPlayerLogin(PlayerPostLoginEventArgs args)
        {
            // load player data
        }

        private void onGetData(GetDataEventArgs args)
        {
            // chest open
            // chest edit
            // chest name
        }

        private void onPlayerLogout(PlayerLogoutEventArgs args)
        {
            // save player data
        }
    }
}
