#pragma checksum "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c82cb4430e86a7d7cb3d4e20ac18435df05bf68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clovece_Mapa), @"mvc.1.0.view", @"/Views/Clovece/Mapa.cshtml")]
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
#nullable restore
#line 1 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\_ViewImports.cshtml"
using CloveceWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
using CloveceWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c82cb4430e86a7d7cb3d4e20ac18435df05bf68", @"/Views/Clovece/Mapa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"351f0bce16635c37a1fceb013f395be4457cc985", @"/Views/_ViewImports.cshtml")]
    public class Views_Clovece_Mapa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CloveceModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
  
    ViewData["Title"] = "Mapa";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Mapa Hry</h1>\n\n\n<table>\n");
#nullable restore
#line 11 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
     for (int x = 0; x <= 10; x++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n");
#nullable restore
#line 14 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
         for (int y = 0; y <= 10; y++)
        {
            string cierna = "#000000";
            string modra = "#0000FF";
            string zelena = "#008000";
            string cervena = "#FF0000";
            string zlta = "#bfbf00";

            bool inserted = false;


            for (int i = 0; i < 16; i++)
            {


                if ((x == Model.data.Hrac_x[i]) && (y == Model.data.Hrac_y[i]) && (!inserted))
                {
                    System.Diagnostics.Debug.WriteLine(i);
                    if (Model.data.Farba[i] == "zelena")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 777, "\"", 799, 2);
            WriteAttributeValue("", 785, "color:", 785, 6, true);
#nullable restore
#line 34 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 791, zelena, 792, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 803, "\"", 846, 2);
            WriteAttributeValue("", 810, "/Clovece/HodKocku?farba=zelena&id=", 810, 34, true);
#nullable restore
#line 34 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue("", 844, i, 844, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">+ </a></td>\n");
#nullable restore
#line 35 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                    else if (Model.data.Farba[i] == "cervena")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 1020, "\"", 1043, 2);
            WriteAttributeValue("", 1028, "color:", 1028, 6, true);
#nullable restore
#line 39 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 1034, cervena, 1035, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 1047, "\"", 1091, 2);
            WriteAttributeValue("", 1054, "/Clovece/HodKocku?farba=cervena&id=", 1054, 35, true);
#nullable restore
#line 39 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue("", 1089, i, 1089, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">+ </a></td>\n");
#nullable restore
#line 40 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                    else if (Model.data.Farba[i] == "modra")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 1263, "\"", 1284, 2);
            WriteAttributeValue("", 1271, "color:", 1271, 6, true);
#nullable restore
#line 44 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 1277, modra, 1278, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 1288, "\"", 1330, 2);
            WriteAttributeValue("", 1295, "/Clovece/HodKocku?farba=modra&id=", 1295, 33, true);
#nullable restore
#line 44 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue("", 1328, i, 1328, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">+ </a></td>\n");
#nullable restore
#line 45 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                    else if (Model.data.Farba[i] == "zlta")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 1501, "\"", 1521, 2);
            WriteAttributeValue("", 1509, "color:", 1509, 6, true);
#nullable restore
#line 49 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 1515, zlta, 1516, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 1525, "\"", 1566, 2);
            WriteAttributeValue("", 1532, "/Clovece/HodKocku?farba=zlta&id=", 1532, 32, true);
#nullable restore
#line 49 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue("", 1564, i, 1564, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">+ </a></td>\n");
#nullable restore
#line 50 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                    inserted = true;
                }

            }


            if (!inserted)
            {
                if (x == 0 || x == 1 || x == 2 || x == 3 || x == 7 || x == 8 || x == 9 || x == 10)
                {
                    if (x == 0 && y == 6)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 1949, "\"", 1971, 2);
            WriteAttributeValue("", 1957, "color:", 1957, 6, true);
#nullable restore
#line 64 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 1963, zelena, 1964, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 65 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                    else if ((y == 5 && x == 1) || (y == 5 && x == 2) || (y == 5 && x == 3))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 2171, "\"", 2193, 2);
            WriteAttributeValue("", 2179, "color:", 2179, 6, true);
#nullable restore
#line 69 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 2185, zelena, 2186, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 70 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }

                    else if ((y == 5 && x == 7) || (y == 5 && x == 8) || (y == 5 && x == 9))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 2394, "\"", 2415, 2);
            WriteAttributeValue("", 2402, "color:", 2402, 6, true);
#nullable restore
#line 75 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 2408, modra, 2409, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 76 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }

                    else if (x == 10 && y == 4)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 2571, "\"", 2592, 2);
            WriteAttributeValue("", 2579, "color:", 2579, 6, true);
#nullable restore
#line 81 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 2585, modra, 2586, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 82 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                    else if (y == 4 || y == 5 || y == 6)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <b><td");
            BeginWriteAttribute("style", " style=\"", 2759, "\"", 2781, 2);
            WriteAttributeValue("", 2767, "color:", 2767, 6, true);
#nullable restore
#line 86 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 2773, cierna, 2774, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td></b>\n");
#nullable restore
#line 87 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                    else if ((x == 0 && (y == 0 || y == 1)) || (x == 1 && (y == 0 || y == 1)))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 2987, "\"", 3007, 2);
            WriteAttributeValue("", 2995, "color:", 2995, 6, true);
#nullable restore
#line 91 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 3001, zlta, 3002, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 92 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                    else if ((x == 0 && (y == 9 || y == 10)) || (x == 1 && (y == 9 || y == 10)))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 3211, "\"", 3233, 2);
            WriteAttributeValue("", 3219, "color:", 3219, 6, true);
#nullable restore
#line 96 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 3225, zelena, 3226, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 97 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                    else if ((x == 9 && (y == 0 || y == 1)) || (x == 10 && (y == 0 || y == 1)))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 3436, "\"", 3457, 2);
            WriteAttributeValue("", 3444, "color:", 3444, 6, true);
#nullable restore
#line 101 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 3450, modra, 3451, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 102 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                    else if ((x == 9 && (y == 9 || y == 10)) || (x == 10 && (y == 9 || y == 10)))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 3662, "\"", 3685, 2);
            WriteAttributeValue("", 3670, "color:", 3670, 6, true);
#nullable restore
#line 106 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 3676, cervena, 3677, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 107 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>  </td>\n");
#nullable restore
#line 112 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }

                }

                else if (x == 4 || x == 6)
                {
                    if (x == 4 && y == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 4046, "\"", 4066, 2);
            WriteAttributeValue("", 4054, "color:", 4054, 6, true);
#nullable restore
#line 121 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 4060, zlta, 4061, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 122 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }

                    else if (x == 6 && y == 10)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 4222, "\"", 4245, 2);
            WriteAttributeValue("", 4230, "color:", 4230, 6, true);
#nullable restore
#line 127 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 4236, cervena, 4237, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 128 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }

                    else if (x == 4 && y == 5)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 4400, "\"", 4422, 2);
            WriteAttributeValue("", 4408, "color:", 4408, 6, true);
#nullable restore
#line 133 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 4414, zelena, 4415, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 134 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                    else if (x == 6 && y == 5)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 4576, "\"", 4597, 2);
            WriteAttributeValue("", 4584, "color:", 4584, 6, true);
#nullable restore
#line 138 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 4590, modra, 4591, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 139 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <b><td");
            BeginWriteAttribute("style", " style=\"", 4732, "\"", 4754, 2);
            WriteAttributeValue("", 4740, "color:", 4740, 6, true);
#nullable restore
#line 143 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 4746, cierna, 4747, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td></b>\n");
#nullable restore
#line 144 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                }



                else if (x == 5)
                {
                    if (y == 1 || y == 2 || y == 3 || y == 4)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 4999, "\"", 5019, 2);
            WriteAttributeValue("", 5007, "color:", 5007, 6, true);
#nullable restore
#line 154 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 5013, zlta, 5014, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 155 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }

                    else if (y == 6 || y == 7 || y == 8 || y == 9)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td");
            BeginWriteAttribute("style", " style=\"", 5194, "\"", 5217, 2);
            WriteAttributeValue("", 5202, "color:", 5202, 6, true);
#nullable restore
#line 160 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 5208, cervena, 5209, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td>\n");
#nullable restore
#line 161 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }

                    else if (y == 0 || y == 10)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <b><td");
            BeginWriteAttribute("style", " style=\"", 5376, "\"", 5398, 2);
            WriteAttributeValue("", 5384, "color:", 5384, 6, true);
#nullable restore
#line 166 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
WriteAttributeValue(" ", 5390, cierna, 5391, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">O </td></b>\n");
#nullable restore
#line 167 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }

                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>  </td>\n");
#nullable restore
#line 173 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
                        ;
                    }
                }
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n");
#nullable restore
#line 179 "D:\Projekty\dotnet-clovecenehnevajsa-master\CloveceWeb\Views\Clovece\Mapa.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<h1>Klikni na panačika, ktorý má vykonať pohyb</h1>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CloveceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
