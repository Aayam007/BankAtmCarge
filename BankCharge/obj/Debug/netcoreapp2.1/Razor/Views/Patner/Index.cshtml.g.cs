#pragma checksum "E:\BankAtmCarge\BankCharge\Views\Patner\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c5a2b22d19a039b3183257a27d8658f3e0314455e09e566059731b2a5aa97f32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patner_Index), @"mvc.1.0.view", @"/Views/Patner/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patner/Index.cshtml", typeof(AspNetCore.Views_Patner_Index))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\BankAtmCarge\BankCharge\Views\_ViewImports.cshtml"
using BankCharge

    ;
#line 2 "E:\BankAtmCarge\BankCharge\Views\_ViewImports.cshtml"
using BankCharge.Models

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c5a2b22d19a039b3183257a27d8658f3e0314455e09e566059731b2a5aa97f32", @"/Views/Patner/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ec0d95ea105c362572c2b8f3997de0520c2620f71ca14338952ba16984a2d030", @"/Views/_ViewImports.cshtml")]
    public class Views_Patner_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BankCharge.Models.PatnerViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\BankAtmCarge\BankCharge\Views\Patner\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden

            BeginContext(96, 611, true);
            WriteLiteral(@"
<h2>Index</h2>

<section>
    <h4 align=""right"">
        <a href=""/Patner/New""><i class=""fa fa-plus-square"" aria-hidden=""true"">Add  PatnerBank</i> </a>
    </h4>
    <div>


        <br />
        <table class=""table table-responsive table-striped table-bordered table-hover table-condensed "" id=""mytable"">
            <thead>
                <tr style=""background-color:cadetblue"">
                    <th style=""width:200px; "">Bank Name</th>
                    <th>Patner Bank</th>

                    <th>Action</th>


                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 28 "E:\BankAtmCarge\BankCharge\Views\Patner\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden

            BeginContext(772, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(827, 40, false);
            Write(
#line 31 "E:\BankAtmCarge\BankCharge\Views\Patner\Index.cshtml"
                             Html.DisplayFor(model => item.Bank.Name)

#line default
#line hidden
            );
            EndContext();
            BeginContext(867, 37, true);
            WriteLiteral("</td>\r\n                        <td>\r\n");
            EndContext();
#line 33 "E:\BankAtmCarge\BankCharge\Views\Patner\Index.cshtml"
                             if (item.PatnerBank != null)
                            {
                                

#line default
#line hidden

#line 35 "E:\BankAtmCarge\BankCharge\Views\Patner\Index.cshtml"
                                 foreach (var patnerbank in item.PatnerBank)
                                {

#line default
#line hidden

            BeginContext(1107, 40, true);
            WriteLiteral("                                    <p> ");
            EndContext();
            BeginContext(1148, 15, false);
            Write(
#line 37 "E:\BankAtmCarge\BankCharge\Views\Patner\Index.cshtml"
                                         patnerbank.Name

#line default
#line hidden
            );
            EndContext();
            BeginContext(1163, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
#line 38 "E:\BankAtmCarge\BankCharge\Views\Patner\Index.cshtml"
                                }

#line default
#line hidden

#line 38 "E:\BankAtmCarge\BankCharge\Views\Patner\Index.cshtml"
                                 
                            }
                            else
                            {

#line default
#line hidden

            BeginContext(1301, 56, true);
            WriteLiteral("                                <p>No Patner Bank </p>\r\n");
            EndContext();
#line 43 "E:\BankAtmCarge\BankCharge\Views\Patner\Index.cshtml"
                            }

#line default
#line hidden

            BeginContext(1388, 93, true);
            WriteLiteral("                        </td>\r\n\r\n                        <td>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1481, "\"", 1516, 2);
            WriteAttributeValue("", 1488, "/Bank/EditBank?id=", 1488, 18, true);
            WriteAttributeValue("", 1506, 
#line 47 "E:\BankAtmCarge\BankCharge\Views\Patner\Index.cshtml"
                                                        item.Bank

#line default
#line hidden
            , 1506, 10, false);
            EndWriteAttribute();
            BeginContext(1517, 131, true);
            WriteLiteral("><i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\" style=\"color:green;margin:5px; \"></i>edit</a>|\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1648, "\"", 1685, 2);
            WriteAttributeValue("", 1655, "/Bank/DeleteBank?id=", 1655, 20, true);
            WriteAttributeValue("", 1675, 
#line 48 "E:\BankAtmCarge\BankCharge\Views\Patner\Index.cshtml"
                                                          item.Bank

#line default
#line hidden
            , 1675, 10, false);
            EndWriteAttribute();
            BeginContext(1686, 150, true);
            WriteLiteral("><i class=\"fa fa-trash-o\" aria-hidden=\"true\" style=\"color:red; margin:5px;\"></i>delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 51 "E:\BankAtmCarge\BankCharge\Views\Patner\Index.cshtml"

                }

#line default
#line hidden

            BeginContext(1857, 64, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BankCharge.Models.PatnerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591