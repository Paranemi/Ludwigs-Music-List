using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBConnection1.Controls
{
    public class ValidationInputBase : ComponentBase
    {
        [Parameter]
        public EventCallback<string> ValueChangedCallback { get; set; }

        [Parameter]
        public string Value { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> InputAttributes { get; set; }

        protected async void HandleInoutChanged(ChangeEventArgs eventArgs)
        {
           await ValueChangedCallback.InvokeAsync(eventArgs.Value.ToString());
        }
    }
}
