using Mc3s.Odos.Client;
using Mc3s.Odos.Domain.Northwind;
using Mc3s.Odos.Library;
using Mc3s.Odos.Security;
using Mc3s.Odos.Security.Identity.Domain;
using Mc3s.Odos.UI.WinForms.Client;
using Mc3s.SharedLib;
using Mc3s.SharedLib.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindWinFormsApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Winforms standard calls
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initalize the correct (WinForms) ODOS Application through the Application Manager 
            var cApp = ApplicationManager.Initialize(new WinFormsApplication(new WinFormsApplicationFeatures()));

            // Register ODOS' Application main Window Type to be used on startup
            cApp.registerMainWindowType<MainForm>();

            // Initializes a Client Object Manager with the settings from configuration
            // Default initiliaztion makes Client Object Manager available through ClientObjMgr._COM
            var client = ClientObjMgr.Initialize();

            // Registeres domains through Domain Factory classes that reside in Domain assembly
            client.registerDomainFactory<NorthwindFactory>();
            client.registerDomainFactory<IdentityFactory>();

            // Connect to server & Start. This will internally create main form, then connect to server and then show the main form
            cApp.startUpClient(StartupConnectionMode.ConnectAndStart);

        }
    }
}
