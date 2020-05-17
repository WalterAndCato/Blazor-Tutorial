using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorServerApp2.Shared;
using BlazorServerApp2.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorServerApp2.Pages
{
    public partial class Counter
    {

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}