using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorTest.Components
{
    public class BaseViewComponent : ComponentBase
    {
        protected void ExecuteJsSync(IJSRuntime jsRuntime, string jsFunction, params object[] args)
        {
            ((IJSInProcessRuntime)jsRuntime).Invoke<string>(jsFunction, args);
        }

        protected T ExecuteJsSync<T>(IJSRuntime jsRuntime, string jsFunction, params object[] args)
        {
            return ((IJSInProcessRuntime)jsRuntime).Invoke<T>(jsFunction, args);
        }

        protected Task<T> ExecuteJsAsync<T>(IJSRuntime jsRuntime, string jsFunction, params object[] args)
        {
            return ((IJSInProcessRuntime)jsRuntime).InvokeAsync<T>(jsFunction, args);
        }
    }
}
