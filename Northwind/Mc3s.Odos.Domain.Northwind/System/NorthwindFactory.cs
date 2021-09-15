using Mc3s.Odos.Client;
using Mc3s.Odos.Library;
using Mc3s.Odos.Security;
using Mc3s.SharedLib.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mc3s.Odos.Domain.Northwind
{
    public class NorthwindFactory: DataItemDomainFactory
    {
        [Setting(_DefaultValue = false,
         _Description = @"Create Data during server initialization if not exist.")]
        public class CreateTestDataOnInitSetting : AppStructSetting<CreateTestDataOnInitSetting, bool> { }

        // Return DOMAIN Assembly
        protected override Assembly getFactoryAssembly() { return GetType().Assembly; }

        // Return DOMAIN Description
        protected override string getDomainDescription() { return "This is Northwind Domain"; }

        protected override void OnDomainStateChange(object source, ServerDomainStateChangeEventArgs e)
        {
            // Call base
            base.OnDomainStateChange(source, e);

            // Check Design Time
            if (!Mc3s.SharedLib.Util.IsDesignTime)
            {
                // Check CLIENT and create test data if needed
                if (CreateTestDataOnInitSetting._Value && e._Client._ClientAppType == ClientAppType.ServerMgmt && e._DomainStateInfo._IsAvailable)
                {
                    Task.Run(() =>
                    {             
                        // Init
                        NorthwindDbCreator.CreateAllNorthwindDataIfNotExist();
                        
                    });
                }
            }
        }
    }
}
