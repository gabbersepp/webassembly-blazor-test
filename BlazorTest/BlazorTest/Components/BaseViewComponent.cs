using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

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
    }
}
