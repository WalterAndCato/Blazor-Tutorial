using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorServerApp2.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorServerApp2.Pages
{
    public partial class Counter
    {
        [Inject] private SingletonService singleton { get; set; }
        [Inject] private TransientService transient { get; set; }
        
        private int currentCount = 0;
        private static int currentCountStatic = 0;

        private void IncrementCount()
        {
            currentCountStatic++;
            currentCount++;
            transient.Value = currentCount;
            singleton.Value = currentCount;
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
        
 
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}