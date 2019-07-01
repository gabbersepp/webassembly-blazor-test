using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Components
{
    public class BaseViewComponent : ComponentBase
    {
        /*protected void executeJsSync(IJSRuntime jsRuntime, string jsFunction, params object[] args)
        {
            var newAr = new object[args.Length + 1];
            newAr[0] = jsFunction;
            args.ToList().Select((i, index) => newAr[index + 1] = i);

            ((IJSInProcessRuntime)jsRuntime).Invoke<string>("executeWithoutReturnValue", jsFunction, newAr);
        }*/

        protected T ExecuteJsSync<T>(IJSRuntime jsRuntime, string jsFunction, params object[] args)
        {
            return ((IJSInProcessRuntime)jsRuntime).Invoke<T>(jsFunction, args);
        }

        /*protected void executeJsAsync(IJSRuntime jsRuntime, string jsFunction, params object[] args)
        {
            var newAr = new object[args.Length + 1];
            newAr[0] = jsFunction;
            args.ToList().Select((i, index) => newAr[index + 1] = i);

            jsRuntime.InvokeAsync<string>("executeWithoutReturnValue", jsFunction, newAr);
        }

        protected Task<T> executeJsAsync<T>(IJSRuntime jsRuntime, string jsFunction, params object[] args)
        {
            return jsRuntime.InvokeAsync<T>(jsFunction, args);
        }*/
    }
}
