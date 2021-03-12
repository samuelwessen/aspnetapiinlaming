#pragma checksum "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\Pages\ServiceWorkers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e49e4f7a8eb0da7afafeb1c324871e940ae89f7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\_Imports.razor"
using SharedLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\_Imports.razor"
using SharedLibrary.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/serviceworkers")]
    public partial class ServiceWorkers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Service Workers</h1>\r\n");
            __builder.AddMarkupContent(1, "<p>This is all the service workers</p>");
#nullable restore
#line 8 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\Pages\ServiceWorkers.razor"
 if (serviceWorkers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p>No service workers found</p>");
#nullable restore
#line 11 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\Pages\ServiceWorkers.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<tr><th>#</th>\r\n            <th>First name</th>\r\n            <th>Last name</th>\r\n            <th>Email</th></tr>");
#nullable restore
#line 23 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\Pages\ServiceWorkers.razor"
         foreach (var serviceworker in serviceWorkers)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 26 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\Pages\ServiceWorkers.razor"
                     serviceworker.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 27 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\Pages\ServiceWorkers.razor"
                     serviceworker.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 28 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\Pages\ServiceWorkers.razor"
                     serviceworker.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 29 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\Pages\ServiceWorkers.razor"
                     serviceworker.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\Pages\ServiceWorkers.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\Pages\ServiceWorkers.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Samuel\OneDrive\Skrivbord\aspnetapiinlaming\AspnetApiInlamning\BlazorApp\Pages\ServiceWorkers.razor"
       
    private IEnumerable<ServiceWorkerViewModel> serviceWorkers;

    protected override async Task OnInitializedAsync()
    {
        serviceWorkers = await Http.GetFromJsonAsync<IEnumerable<ServiceWorkerViewModel>>("https://localhost:44385/api/ServiceWorkers");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
