#pragma checksum "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8595145734be8ebda3d45ec8b934bd6429fc85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewPlan), @"mvc.1.0.view", @"/Views/Home/ViewPlan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewPlan.cshtml", typeof(AspNetCore.Views_Home_ViewPlan))]
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
#line 1 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/_ViewImports.cshtml"
using BeltExam;

#line default
#line hidden
#line 2 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/_ViewImports.cshtml"
using BeltExam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8595145734be8ebda3d45ec8b934bd6429fc85", @"/Views/Home/ViewPlan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84119000702c45f5036e3e300b27d647b6aca13", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewPlan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
  
    ViewData["Title"] = "View Activity";

#line default
#line hidden
            BeginContext(46, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 10, true);
            WriteLiteral("\n<br>\n<h1>");
            EndContext();
            BeginContext(70, 11, false);
#line 8 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(81, 11, true);
            WriteLiteral("</h1>\n<br>\n");
            EndContext();
#line 10 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
  
    if(@ViewBag.UserId == @Model.PlannerId)
    {

#line default
#line hidden
            BeginContext(145, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 151, "\"", 179, 2);
            WriteAttributeValue("", 158, "/delete/", 158, 8, true);
#line 13 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
WriteAttributeValue("", 166, Model.PlanId, 166, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(180, 35, true);
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\n");
            EndContext();
#line 14 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
    }
    else
    {
        bool joined = false;
        foreach(var join in @ViewBag.Joins)
        {
            if(join.UserId == @ViewBag.UserId)
            {
                joined=true;
            }
        }
        if (joined)
        {

#line default
#line hidden
            BeginContext(463, 38, true);
            WriteLiteral("            <a class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 501, "\"", 528, 2);
            WriteAttributeValue("", 508, "/leave/", 508, 7, true);
#line 27 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
WriteAttributeValue("", 515, Model.PlanId, 515, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(529, 11, true);
            WriteLiteral(">Leave</a>\n");
            EndContext();
#line 28 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(573, 38, true);
            WriteLiteral("            <a class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 611, "\"", 637, 2);
            WriteAttributeValue("", 618, "/join/", 618, 6, true);
#line 31 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
WriteAttributeValue("", 624, Model.PlanId, 624, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(638, 10, true);
            WriteLiteral(">Join</a>\n");
            EndContext();
#line 32 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(666, 55, true);
            WriteLiteral("\n<div>\n    <ul>\n        <h3>Event Coordinator: </h3><p>");
            EndContext();
            BeginContext(722, 18, false);
#line 38 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
                                  Write(Model.Planner.Name);

#line default
#line hidden
            EndContext();
            BeginContext(740, 50, true);
            WriteLiteral("</p>\n        <br>\n        <h3>Description:</h3><p>");
            EndContext();
            BeginContext(791, 17, false);
#line 40 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
                           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(808, 50, true);
            WriteLiteral("</p>\n        <br>\n        <h3>Participants: </h3>\n");
            EndContext();
#line 43 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
         foreach(var joins in Model.AttendingUsers)
        {

#line default
#line hidden
            BeginContext(920, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(936, 17, false);
#line 45 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
          Write(joins.Joiner.Name);

#line default
#line hidden
            EndContext();
            BeginContext(953, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 46 "/Users/lisawelde/Desktop/assignments/c#/BeltExam/Views/Home/ViewPlan.cshtml"
        }

#line default
#line hidden
            BeginContext(968, 16, true);
            WriteLiteral("    </ul>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Plan> Html { get; private set; }
    }
}
#pragma warning restore 1591