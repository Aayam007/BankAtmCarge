#pragma checksum "C:\Users\User\Desktop\BankCharge\BankCharge\Views\Bank\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d76c7661a441f2b0c416fa4711c938a7c8d4bbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bank_Index), @"mvc.1.0.view", @"/Views/Bank/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bank/Index.cshtml", typeof(AspNetCore.Views_Bank_Index))]
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
#line 1 "C:\Users\User\Desktop\BankCharge\BankCharge\Views\_ViewImports.cshtml"
using BankCharge;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\BankCharge\BankCharge\Views\_ViewImports.cshtml"
using BankCharge.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d76c7661a441f2b0c416fa4711c938a7c8d4bbd", @"/Views/Bank/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb8ed2e37bad520f3ce627c145902d1f32f0279", @"/Views/_ViewImports.cshtml")]
    public class Views_Bank_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BankCharge.Models.Bank>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\Desktop\BankCharge\BankCharge\Views\Bank\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(85, 891, true);
            WriteLiteral(@"
<section class=""content-header"">
    <h1>
        Bank

    </h1>
</section>

<section>
    <h4 align=""right"">
        <a href=""/Bank/New""><i class=""fa fa-plus-square"" aria-hidden=""true"">Add Bank</i> </a>
    </h4>
    <div>
        <input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Search for names.."" title=""Type in a name"">
        <br />

        <br />
        <table class=""table table-responsive table-striped table-bordered table-hover table-condensed "" id=""mytable"">
            <thead>
                <tr style=""background-color:cadetblue"">
                    <th style=""width:200px; "">Bank Name</th>
                    <th>Image</th>
                    <th>Charge</th>
                    <th>CardType</th>
                    <th>Action</th>
                   

                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 35 "C:\Users\User\Desktop\BankCharge\BankCharge\Views\Bank\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1041, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1088, 35, false);
#line 38 "C:\Users\User\Desktop\BankCharge\BankCharge\Views\Bank\Index.cshtml"
                   Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1123, 58, true);
            WriteLiteral("</td>\r\n                    <td><img class=\"img-responsive\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1181, "\"", 1198, 1);
#line 39 "C:\Users\User\Desktop\BankCharge\BankCharge\Views\Bank\Index.cshtml"
WriteAttributeValue("", 1187, item.Image, 1187, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1199, 107, true);
            WriteLiteral(" alt=\"sala image aayena\" height=\"50\" width=\"50\" style=\"border-radius:50%\" /></td>\r\n                    <td>");
            EndContext();
            BeginContext(1307, 37, false);
#line 40 "C:\Users\User\Desktop\BankCharge\BankCharge\Views\Bank\Index.cshtml"
                   Write(Html.DisplayFor(model => item.Charge));

#line default
#line hidden
            EndContext();
            BeginContext(1344, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1376, 39, false);
#line 41 "C:\Users\User\Desktop\BankCharge\BankCharge\Views\Bank\Index.cshtml"
                   Write(Html.DisplayFor(model => item.CardType));

#line default
#line hidden
            EndContext();
            BeginContext(1415, 81, true);
            WriteLiteral("</td>\r\n                    \r\n                    <td>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1496, "\"", 1533, 2);
            WriteAttributeValue("", 1503, "/Bank/EditBank?id=", 1503, 18, true);
#line 44 "C:\Users\User\Desktop\BankCharge\BankCharge\Views\Bank\Index.cshtml"
WriteAttributeValue("", 1521, item.BankId, 1521, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1534, 127, true);
            WriteLiteral("><i class=\"fa fa-pencil-square-o\" aria-hidden=\"true\" style=\"color:green;margin:5px; \"></i>edit</a>|\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1661, "\"", 1700, 2);
            WriteAttributeValue("", 1668, "/Bank/DeleteBank?id=", 1668, 20, true);
#line 45 "C:\Users\User\Desktop\BankCharge\BankCharge\Views\Bank\Index.cshtml"
WriteAttributeValue("", 1688, item.BankId, 1688, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1701, 142, true);
            WriteLiteral("><i class=\"fa fa-trash-o\" aria-hidden=\"true\" style=\"color:red; margin:5px;\"></i>delete</a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 48 "C:\Users\User\Desktop\BankCharge\BankCharge\Views\Bank\Index.cshtml"

                }

#line default
#line hidden
            BeginContext(1864, 798, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</section>
<script>
    function myFunction() {
        var input, filter, table, tr, td, i, txtValue;
        input = document.getElementById(""myInput"");
        filter = input.value.toUpperCase();
        table = document.getElementById(""myTable"");
        tr = table.getElementsByTagName(""tbody tr"");
        for (i = 0; i < tr.length; i++) {
            td = tr[i].getElementsByTagName(""td"")[0];
            if (td) {
                txtValue = td.textContent || td.innerText;
                if (txtValue.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = """";
                } else {
                    tr[i].style.display = ""none"";
                }
            }
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BankCharge.Models.Bank>> Html { get; private set; }
    }
}
#pragma warning restore 1591