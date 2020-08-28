#pragma checksum "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cafaded4683eaa3be573e49132715e40de6ee46c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Shared__MenuItem), @"mvc.1.0.view", @"/Areas/Administrator/Views/Shared/_MenuItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cafaded4683eaa3be573e49132715e40de6ee46c", @"/Areas/Administrator/Views/Shared/_MenuItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daee3a04158b1f2edb8411932491d235e3bcd21a", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Shared__MenuItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Infrastructure.Web.Models.CacheMenuViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MenuItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
  
	//var hasChild = Model.Childs != null && Model.Childs.Count > 0;
	List<Infrastructure.Web.Models.CacheMenu> menus;
	if (string.IsNullOrEmpty(Model.HierarchyCode))
	{
		menus = Model.menus.Where(p => p.HierarchyCode.Length == Domain.Common.Consts.Infrastructure.HierarchyCodeLength).OrderBy(p => p.Order).ToList();
	}
	else
	{
		menus = Model.menus.Where(p => p.HierarchyCode.StartsWith(Model.HierarchyCode) && p.HierarchyCode.Length - Model.HierarchyCode.Length == Domain.Common.Consts.Infrastructure.HierarchyCodeLength).OrderBy(p => p.Order).ToList();
	}
	var childMenus = new List<Infrastructure.Web.Models.CacheMenu>();

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
 foreach (var item in menus)
{
	childMenus = Model.menus.Where(p => p.HierarchyCode.Length > item.HierarchyCode.Length && p.HierarchyCode.StartsWith(item.HierarchyCode)).OrderBy(p=>p.Order).ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<li");
            BeginWriteAttribute("class", " class=\"", 903, "\"", 1096, 3);
            WriteAttributeValue("", 911, "nav-item", 911, 8, true);
#nullable restore
#line 18 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
WriteAttributeValue(" ", 919, childMenus.Any() ? "has-treeview" : "", 920, 41, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
WriteAttributeValue(" ", 961, !string.IsNullOrEmpty(Model.SelectedHierarchyCode) && Model.SelectedHierarchyCode.StartsWith(item.HierarchyCode) ? "menu-open" : "", 962, 134, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1104, "\"", 1227, 1);
#nullable restore
#line 19 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
WriteAttributeValue("", 1111, !string.IsNullOrEmpty(item.Controller) && item.Controller != "#" ? Url.ActionLink("Index", item.Controller) : "#", 1111, 116, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", "\r\n\t\t   class=\"", 1228, "\"", 1382, 2);
            WriteAttributeValue("", 1242, "nav-link", 1242, 8, true);
#nullable restore
#line 20 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
WriteAttributeValue(" ", 1250, !string.IsNullOrEmpty(Model.SelectedHierarchyCode) && Model.SelectedHierarchyCode.StartsWith(item.HierarchyCode) ? "active" : "", 1251, 131, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t<i");
            BeginWriteAttribute("class", " class=\"", 1391, "\"", 1422, 3);
            WriteAttributeValue("", 1399, "nav-icon", 1399, 8, true);
            WriteAttributeValue(" ", 1407, "fas", 1408, 4, true);
#nullable restore
#line 21 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
WriteAttributeValue(" ", 1411, item.Icon, 1412, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n\t\t\t<p>\r\n\t\t\t\t");
#nullable restore
#line 23 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 24 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
                 if (childMenus.Any())
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<i class=\"fas fa-angle-left right\"></i>\r\n");
#nullable restore
#line 27 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</p>\r\n\t\t</a>\r\n");
#nullable restore
#line 30 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
         if (childMenus.Any())
		{
			Infrastructure.Web.Models.CacheMenuViewModel menuViewModel = new Infrastructure.Web.Models.CacheMenuViewModel()
			{
				HierarchyCode = item.HierarchyCode,
				menus = Model.menus,
				SelectedHierarchyCode = Model.SelectedHierarchyCode
			};

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<ul class=\"nav nav-treeview\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cafaded4683eaa3be573e49132715e40de6ee46c8757", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 39 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = menuViewModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</ul>\r\n");
#nullable restore
#line 41 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</li>\r\n");
#nullable restore
#line 43 "D:\PROJECT-TTS-D6\BlogManagement\Web\Areas\Administrator\Views\Shared\_MenuItem.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Infrastructure.Web.Models.CacheMenuViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
