#pragma checksum "C:\Users\enriq\source\repos\Inventario\Inventario\Components\Ejercicios\Forms\Form002.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3be9328ff53df4fd8a4ed2fa3522c5082a5450b8"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventario.Components.Ejercicios.Forms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\enriq\source\repos\Inventario\Inventario\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\enriq\source\repos\Inventario\Inventario\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\enriq\source\repos\Inventario\Inventario\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\enriq\source\repos\Inventario\Inventario\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\enriq\source\repos\Inventario\Inventario\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\enriq\source\repos\Inventario\Inventario\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\enriq\source\repos\Inventario\Inventario\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\enriq\source\repos\Inventario\Inventario\_Imports.razor"
using Inventario;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\enriq\source\repos\Inventario\Inventario\_Imports.razor"
using Inventario.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\enriq\source\repos\Inventario\Inventario\_Imports.razor"
using Inventario.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\enriq\source\repos\Inventario\Inventario\_Imports.razor"
using Inventario.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
    public partial class Form002 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<input type=\"text\" name=\"name\" value>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591