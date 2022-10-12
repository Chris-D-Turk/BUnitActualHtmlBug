using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BUnitActualHtmlBug.Pages;

public partial class Counter : ComponentBase
{
    private int currentCount = 0;

    private async Task IncrementCount()
    {
        await Task.Delay(10);
        currentCount++;
    }
}
