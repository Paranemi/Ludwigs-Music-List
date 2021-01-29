using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorServerSide.Controls
{
    public class ValidationInputBase : ComponentBase
    {
        [Parameter]
        public EventCallback<string> ValueChangedCallback { get; set; }

        [Parameter]
        public string Value { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> InputAttributes { get; set; }

        protected async Task HandleInoutChanged(ChangeEventArgs eventArgs)
        {
            await ValueChangedCallback.InvokeAsync(eventArgs.Value.ToString());
        }
    }
}
