using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorServerApp2.Shared.Helpers
{
    public static class IjsRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            return await js.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask MyFunction(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("myfuncion", message);
        }
    }
}