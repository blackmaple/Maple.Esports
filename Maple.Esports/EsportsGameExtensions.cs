using Maple.MonoGameAssistant.WebApi;
using Maple.MonoGameAssistant.Windows.Service;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.Esports.GameService
{
    static partial class EsportsGameExtensions
    {
        internal static async Task RunWebApiServiceAsync(int millisecondsDelay = 18 * 1000)
        {
            var webapp = WebApiServiceExtensions.AsRunWebApiService(p =>
            {
                p.GameName = "电竞教父";
                p.QQ = "0";
                p.Http = true;
                p.AutoOpenUrl = true;
                p.Port = 49009;
            }, services =>
            {
                services.UseGameContextService<EsportsGameService>();
            });

            //延迟启动
            await Task.Delay(millisecondsDelay).ConfigureAwait(false);
            await webapp.RunAsync().ConfigureAwait(false);

        }



        [ModuleInitializer]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2255:不应在库中使用 “ModuleInitializer” 属性", Justification = "<挂起>")]
        public static void Initializer()
        {
            _ = RunWebApiServiceAsync();
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)], EntryPoint = nameof(DllMain))]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static bool DllMain(nint hModule, uint ul_reason_for_call, nint lpReserved)
        {
            return InitDllMain(hModule, ul_reason_for_call, lpReserved);
        }


        [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall), typeof(CallConvSuppressGCTransition)])]
        [LibraryImport("*")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool InitDllMain(nint hModule, uint ul_reason_for_call, nint lpReserved);

    }
}
