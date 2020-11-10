#pragma checksum "C:\Users\edmar\source\repos\DineOut\DineOut\Views\OrderDetails\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df2623a55918d8cf958bb69a54f174fc1e8f9415"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetails_Order), @"mvc.1.0.view", @"/Views/OrderDetails/Order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderDetails/Order.cshtml", typeof(AspNetCore.Views_OrderDetails_Order))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\_ViewImports.cshtml"
using DineOut;

#line default
#line hidden
#line 2 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\_ViewImports.cshtml"
using DineOut.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df2623a55918d8cf958bb69a54f174fc1e8f9415", @"/Views/OrderDetails/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c2cebbd3840c3b18d6a0efb5833584bb8a9f925", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderDetails_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\OrderDetails\Order.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "_Layout";

#line default
#line hidden
            BeginContext(78, 396, true);
            WriteLiteral(@"
<h2>Order Details</h2>

<div class=""orderDetailsBody"">
	<table class=""table table-striped orderDetailsTable "">
		<thead>
			<tr>
				<th>Order Number</th>
				<th>Date</th>
				<th>Restaurant</th>
				<th>Table #</th>
				<th>Costumer</th>
				<th>Price</th>
				<th>Order Status</th>
				<th>Item</th>
				<th>Quantity</th>


			</tr>
		</thead>
		<tbody>
			<tr>
				<td>");
            EndContext();
            BeginContext(475, 12, false);
#line 28 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\OrderDetails\Order.cshtml"
               Write(Model.Orders);

#line default
#line hidden
            EndContext();
            BeginContext(487, 5, true);
            WriteLiteral("</td>");
            EndContext();
            BeginContext(505, 10, true);
            WriteLiteral("\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(516, 12, false);
#line 29 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\OrderDetails\Order.cshtml"
               Write(Model.Orders);

#line default
#line hidden
            EndContext();
            BeginContext(528, 5, true);
            WriteLiteral("</td>");
            EndContext();
            BeginContext(548, 10, true);
            WriteLiteral("\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(559, 17, false);
#line 30 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\OrderDetails\Order.cshtml"
               Write(Model.Restaurants);

#line default
#line hidden
            EndContext();
            BeginContext(576, 5, true);
            WriteLiteral("</td>");
            EndContext();
            BeginContext(598, 10, true);
            WriteLiteral("\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(609, 12, false);
#line 31 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\OrderDetails\Order.cshtml"
               Write(Model.Orders);

#line default
#line hidden
            EndContext();
            BeginContext(621, 5, true);
            WriteLiteral("</td>");
            EndContext();
            BeginContext(639, 10, true);
            WriteLiteral("\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(650, 12, false);
#line 32 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\OrderDetails\Order.cshtml"
               Write(Model.Orders);

#line default
#line hidden
            EndContext();
            BeginContext(662, 5, true);
            WriteLiteral("</td>");
            EndContext();
            BeginContext(681, 10, true);
            WriteLiteral("\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(692, 12, false);
#line 33 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\OrderDetails\Order.cshtml"
               Write(Model.Orders);

#line default
#line hidden
            EndContext();
            BeginContext(704, 5, true);
            WriteLiteral("</td>");
            EndContext();
            BeginContext(718, 10, true);
            WriteLiteral("\r\n\t\t\t\t<td>");
            EndContext();
            BeginContext(729, 12, false);
#line 34 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\OrderDetails\Order.cshtml"
               Write(Model.Orders);

#line default
#line hidden
            EndContext();
            BeginContext(741, 5, true);
            WriteLiteral("</td>");
            EndContext();
            BeginContext(761, 16, true);
            WriteLiteral("\r\n\r\n\r\n\t\t\t</tr>\r\n");
            EndContext();
#line 38 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\OrderDetails\Order.cshtml"
             foreach (var item in Model.Order_Items)
			{

#line default
#line hidden
            BeginContext(828, 19, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(848, 11, false);
#line 41 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\OrderDetails\Order.cshtml"
                   Write(item.ItemId);

#line default
#line hidden
            EndContext();
            BeginContext(859, 16, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(876, 13, false);
#line 42 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\OrderDetails\Order.cshtml"
                   Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(889, 18, true);
            WriteLiteral("</td>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 44 "C:\Users\edmar\source\repos\DineOut\DineOut\Views\OrderDetails\Order.cshtml"
			}

#line default
#line hidden
            BeginContext(913, 37, true);
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n\r\n</div>\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
