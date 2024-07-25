#pragma checksum "C:\Users\Hp\Source\Repos\TestKandidatFistiani\TestKandidatFistiani\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7927039f9d17aadeae4c37119806f84e188b3041"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Hp\Source\Repos\TestKandidatFistiani\TestKandidatFistiani\Views\_ViewImports.cshtml"
using TestKandidatFistiani;

#line default
#line hidden
#line 2 "C:\Users\Hp\Source\Repos\TestKandidatFistiani\TestKandidatFistiani\Views\_ViewImports.cshtml"
using TestKandidatFistiani.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7927039f9d17aadeae4c37119806f84e188b3041", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89227606b37bcade08edd2dc6a7b1ae495d059eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Hp\Source\Repos\TestKandidatFistiani\TestKandidatFistiani\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(63, 3100, true);
                WriteLiteral(@"
    <script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
    <script>
        $(document).ready(function () {
            $.ajax({
                url: ""/home/salessummary"",
                processData: false,
                contentType: false,
                type: 'POST',
                success: function (r) {
                    if (r.status == ""OK"") {
                        var ctx = document.getElementById(""myChart1"").getContext(""2d"");
                        var myChart = new Chart(ctx, {
                            type: 'line',
                            data: {
                                labels: [],
                                datasets: [
                                    {
                                        label: ""Revenue By Item Group"",
                                        fill: false,
                                        lineTension: 0.1,
                              ");
                WriteLiteral(@"          backgroundColor: ""rgba(75,192,192,0.4)"",
                                        borderColor: ""rgba(75,192,192,1)"",
                                        borderCapStyle: 'butt',
                                        borderDash: [],
                                        borderDashOffset: 0.0,
                                        borderJoinStyle: 'miter',
                                        pointBorderColor: ""rgba(75,192,192,1)"",
                                        pointBackgroundColor: ""#fff"",
                                        pointBorderWidth: 1,
                                        pointHoverRadius: 5,
                                        pointHoverBackgroundColor: ""rgba(75,192,192,1)"",
                                        pointHoverBorderColor: ""rgba(220,220,220,1)"",
                                        pointHoverBorderWidth: 2,
                                        pointRadius: 1,
                                        pointHitRadius: 10,
     ");
                WriteLiteral(@"                                   data: [],
                                        spanGaps: false,
                                    }
                                ]
                            },
                            options: {
                                tooltips: {
                                    mode: 'index',
                                    intersect: false
                                }
                            }
                        });
                        var labels = [];
                        var val = [];
                        $.each(r.items, (i, a) => {
                            labels.push(a.item);
                            val.push(a.revenue);
                        });
                        myChart.data.labels = labels;
                        myChart.data.datasets[0].data = val;
                        myChart.update();
                    } else
                        alert(`Error`);
                }
            });
");
                WriteLiteral("        });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(3166, 97, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <canvas id=\"myChart1\" width=\"400\" height=\"400\"></canvas>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
