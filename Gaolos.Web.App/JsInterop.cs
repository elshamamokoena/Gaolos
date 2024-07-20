using Microsoft.JSInterop;

namespace Gaolos.ComponentLibrary
{
    // This class provides an example of how JavaScript functionality can be wrapped
    // in a .NET class for easy consumption. The associated JavaScript module is
    // loaded on demand when first needed.
    //
    // This class can be registered as scoped DI service and then injected into Blazor
    // components for use.

    public class JsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> FetchCardJs;
        private readonly Lazy<Task<IJSObjectReference>> FetchCard;


        public JsInterop(IJSRuntime jsRuntime)
        {
            FetchCardJs = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "/js/card.min.js").AsTask());
            FetchCard = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "/js/newcard.js").AsTask());

        }

        public async ValueTask<string> Prompt(string message)
        {
            var module = await FetchCardJs.Value;
            return await module.InvokeAsync<string>("showPrompt", message);
        }
        public async ValueTask FormatInput()
        {
            await (await FetchCard.Value).InvokeVoidAsync("card");

            await (await FetchCardJs.Value).InvokeVoidAsync("card");
           

        }

        public async ValueTask DisposeAsync()
        {
            if (FetchCardJs.IsValueCreated)
            {
                var module = await FetchCardJs.Value;
                await module.DisposeAsync();
            }
        }
    }
}
