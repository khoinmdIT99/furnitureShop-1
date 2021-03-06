#pragma checksum "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\ProductType\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d33eaaf0d6e6410a118ad34906f6465f7d4c02ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_ProductType_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/ProductType/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Infrastructure.Common.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d33eaaf0d6e6410a118ad34906f6465f7d4c02ae", @"/Areas/Administrator/Views/ProductType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daee3a04158b1f2edb8411932491d235e3bcd21a", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_ProductType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Shop.Dto.ProductTypes.ProductTypeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <h5 class=""card-title"">Danh sách loại danh mục</h5>
                    <div class=""card-tools"">

                        <a");
            BeginWriteAttribute("href", " href=\"", 389, "\"", 421, 1);
#nullable restore
#line 11 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\ProductType\Index.cshtml"
WriteAttributeValue("", 396, Url.ActionLink("Create"), 396, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"" class=""btn bg-gradient-success btn-sm"">
                            Thêm mới
                        </a>
                    </div>
                </div>
                <!-- /.card-header -->
                <div class=""card-body"" style=""overflow-x: auto;"">
                    <table id=""table-product-type"" class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>Type Name</th>
                                <th style=""width: 80px;""></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 26 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\ProductType\Index.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 30 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\ProductType\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        <div class=\"btn-group\">\n                            <a role=\"button\" class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1392, "\"", 1461, 1);
#nullable restore
#line 33 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\ProductType\Index.cshtml"
WriteAttributeValue("", 1399, Url.ActionLink("Update", "ProductType", new { id = item.Id }), 1399, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                <i class=\"fas fa-edit\"></i>\n                            </a>\n                            <a role=\"button\" class=\"btn btn-danger\" href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1633, "\"", 1661, 3);
            WriteAttributeValue("", 1643, "Delete(\'", 1643, 8, true);
#nullable restore
#line 36 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\ProductType\Index.cshtml"
WriteAttributeValue("", 1651, item.Id, 1651, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1659, "\')", 1659, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                <i class=\"fas fa-trash\"></i>\n                            </a>\n                        </div>\n                    </td>\n                </tr>");
#nullable restore
#line 41 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\ProductType\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                    <!-- /.row -->\n                </div>\n            </div>\n            <!-- /.card -->\n        </div>\n        <!-- /.col -->\n    </div>\n</section>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <!-- page script -->
    <script>
    $(function () {
        $('#table-product-type').DataTable({
			""columnDefs"": [
				{ ""orderable"": false, ""targets"": 2 }
			]
		});
    });
    function Delete(id){
		var r = confirm(""Bạn có chắc chắn muốn xóa loại hàng hóa này?"");
        if (r == true) {
            $.ajax(
            {
                type: ""POST"",
                url: '");
#nullable restore
#line 71 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\ProductType\Index.cshtml"
                 Write(Url.ActionLink("Delete", "ProductType"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                data: {
                    id: id
                },
                error: function (result) {
                    alert(""error"");
                },
                success: function (result) {
                    if (result == true) {
                        window.location.reload();
                    }
                    else {
						alert(""Có lỗi xảy ra, vui lòng thử lại sau!"");
                    }
                }
            });
        }
    }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Shop.Dto.ProductTypes.ProductTypeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
