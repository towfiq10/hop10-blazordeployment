#pragma checksum "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf61d4f141f65e4336ccdd152783567b229b45a9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Todo.razor"
       
    private IList<TodoItem> todos = new List<TodoItem>();
        private string newTodo;
        private void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem {Title = newTodo });
                newTodo = string.Empty;
            }
        }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
