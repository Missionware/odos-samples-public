using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Mc3s.Odos.Library;

// 
// ODOS Information
//
[assembly: DisplayAs(_Label = "Northwind Domain")]
[assembly: RuntimeDomain(_DomainName = "Mc3s.Odos.Domain.Northwind",
                         _DomainShortCode = "NWND",
                         _SecurityEnabled = false,
                         _NoRoleCanLogin = true,
                         _IsReportProvider = true)]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("5bb0ae13-e6fa-4787-9c1b-960f46d9509e")]
