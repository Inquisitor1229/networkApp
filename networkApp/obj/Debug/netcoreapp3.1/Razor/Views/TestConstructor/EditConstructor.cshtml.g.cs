#pragma checksum "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f353ea367e6f25357b843d61dd7712be34a091d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestConstructor_EditConstructor), @"mvc.1.0.view", @"/Views/TestConstructor/EditConstructor.cshtml")]
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
#line 1 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.ViewModels.TestConstructor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.ViewModels.TestResult;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f353ea367e6f25357b843d61dd7712be34a091d", @"/Views/TestConstructor/EditConstructor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7316a8470aab35e9f06cffd6510345aa656d9ce", @"/Views/_ViewImports.cshtml")]
    public class Views_TestConstructor_EditConstructor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sbtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("visibility:hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetTest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
  
    ViewData["Title"] = "EditConstructor";
    int numAns = 0;
    int NumQuest = ViewBag.Questions.Count;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f353ea367e6f25357b843d61dd7712be34a091d6501", async() => {
                WriteLiteral("\r\n        <div id=\"listErrors\"></div> \r\n        <div class=\"form-group\">\r\n            <label>Введите название теста</label>\r\n            <input");
                BeginWriteAttribute("value", " value=\"", 292, "\"", 317, 1);
#nullable restore
#line 12 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 300, ViewBag.FileName, 300, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" id=\"testname\" name=\"testName\" />\r\n        </div>\r\n\r\n        <div id=\"baseContainer\">\r\n            <button onclick=\"createQuestion()\">Добавить вопрос</button>\r\n");
#nullable restore
#line 17 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
             for (int i = 0; i < ViewBag.Questions.Count; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div");
                BeginWriteAttribute("id", " id=\"", 589, "\"", 603, 2);
                WriteAttributeValue("", 594, "q", 594, 1, true);
#nullable restore
#line 19 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 595, i + 1, 595, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <div");
                BeginWriteAttribute("id", " id=\"", 631, "\"", 645, 2);
                WriteAttributeValue("", 636, "q", 636, 1, true);
#nullable restore
#line 20 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 637, i + 1, 637, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 691, "\"", 725, 1);
#nullable restore
#line 21 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 699, ViewBag.Questions[i].Text, 699, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"nameQuestion\" />\r\n");
#nullable restore
#line 22 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
                         if (ViewBag.Questions[i].AnswerList[0].Type == "checkbox")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <select style=\"display:none;\"");
                BeginWriteAttribute("id", " id=\"", 920, "\"", 937, 2);
                WriteAttributeValue("", 925, "type", 925, 4, true);
#nullable restore
#line 24 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 929, i + 1, 929, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"type\" value=\"checkbox\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f353ea367e6f25357b843d61dd7712be34a091d10085", async() => {
                    WriteLiteral("Несколько из списка");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n");
#nullable restore
#line 27 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
                         if (ViewBag.Questions[i].AnswerList[0].Type == "radio")
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <select style=\"display:none;\"");
                BeginWriteAttribute("id", " id=\"", 1289, "\"", 1306, 2);
                WriteAttributeValue("", 1294, "type", 1294, 4, true);
#nullable restore
#line 30 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 1298, i + 1, 1298, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"type\" value=\"radio\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f353ea367e6f25357b843d61dd7712be34a091d12459", async() => {
                    WriteLiteral("Один из списка");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n");
#nullable restore
#line 33 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button");
                BeginWriteAttribute("onclick", " onclick=\"", 1512, "\"", 1544, 3);
                WriteAttributeValue("", 1522, "createAnswer(", 1522, 13, true);
#nullable restore
#line 34 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 1535, i + 1, 1535, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1543, ")", 1543, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Добавить ответ</button>\r\n                        <button");
                BeginWriteAttribute("onclick", " onclick=\"", 1602, "\"", 1636, 3);
                WriteAttributeValue("", 1612, "deleteQuestion(", 1612, 15, true);
#nullable restore
#line 35 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 1627, i + 1, 1627, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1635, ")", 1635, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Удалить</button>\r\n                    </div>\r\n\r\n");
#nullable restore
#line 38 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
                     foreach (var answer in ViewBag.Questions[i].AnswerList)
                    {
                        numAns++;

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div");
                BeginWriteAttribute("id", " id=\"", 1850, "\"", 1867, 2);
                WriteAttributeValue("", 1855, "ans", 1855, 3, true);
#nullable restore
#line 41 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 1858, numAns, 1858, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <div");
                BeginWriteAttribute("id", " id=\"", 1903, "\"", 1920, 2);
                WriteAttributeValue("", 1908, "ans", 1908, 3, true);
#nullable restore
#line 42 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 1911, numAns, 1911, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"display:inline;\">\r\n");
#nullable restore
#line 43 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
                                 if (answer.ValueAnswer == "true")
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input");
                BeginWriteAttribute("id", " id=\"", 2093, "\"", 2109, 2);
                WriteAttributeValue("", 2098, "ka", 2098, 2, true);
#nullable restore
#line 45 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 2100, numAns, 2100, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2110, "\"", 2130, 1);
#nullable restore
#line 45 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 2118, answer.Type, 2118, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("type", " type=\"", 2131, "\"", 2150, 1);
#nullable restore
#line 45 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 2138, answer.Type, 2138, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2151, "\"", 2174, 3);
                WriteAttributeValue("", 2158, "isTrue[", 2158, 7, true);
#nullable restore
#line 45 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 2165, i + 1, 2165, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2173, "]", 2173, 1, true);
                EndWriteAttribute();
                WriteLiteral(" checked=\"checked\" />\r\n");
#nullable restore
#line 46 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input");
                BeginWriteAttribute("id", " id=\"", 2348, "\"", 2364, 2);
                WriteAttributeValue("", 2353, "ka", 2353, 2, true);
#nullable restore
#line 49 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 2355, numAns, 2355, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2365, "\"", 2385, 1);
#nullable restore
#line 49 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 2373, answer.Type, 2373, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("type", " type=\"", 2386, "\"", 2405, 1);
#nullable restore
#line 49 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 2393, answer.Type, 2393, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2406, "\"", 2429, 3);
                WriteAttributeValue("", 2413, "isTrue[", 2413, 7, true);
#nullable restore
#line 49 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 2420, i + 1, 2420, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2428, "]", 2428, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 50 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input");
                BeginWriteAttribute("id", " id=\"", 2508, "\"", 2524, 2);
                WriteAttributeValue("", 2513, "ia", 2513, 2, true);
#nullable restore
#line 51 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 2515, numAns, 2515, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2537, "\"", 2557, 1);
#nullable restore
#line 51 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 2545, answer.Text, 2545, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2558, "\"", 2581, 3);
                WriteAttributeValue("", 2565, "answer[", 2565, 7, true);
#nullable restore
#line 51 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 2572, i + 1, 2572, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2580, "]", 2580, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <button");
                BeginWriteAttribute("onclick", " onclick=\"", 2626, "\"", 2659, 3);
                WriteAttributeValue("", 2636, "deleteAnswer(", 2636, 13, true);
#nullable restore
#line 52 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
WriteAttributeValue("", 2649, numAns, 2649, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2658, ")", 2658, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Удалить</button>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 55 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n");
#nullable restore
#line 58 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n        <script>\r\n            let listError = [];\r\n            let deletable = new Array();\r\n            let deletableQ = [];\r\n            let numQuestion = ");
#nullable restore
#line 66 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
                         Write(NumQuest);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n            let numAnswer = ");
#nullable restore
#line 67 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\EditConstructor.cshtml"
                       Write(numAns);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

            function createQuestion() {
                document.getElementById(""sbtn"").style.visibility = ""hidden"";
                numQuestion++;
                let str = '\<div id=""q' + numQuestion + '""><input type=""text"" name=""nameQuestion"" placeholder=""Введите вопрос""/>\
                            <select name=""type"" id=""type' + numQuestion + '"">\
                                <option value=""radio"">Один из списка</option>\
                                <option value=""checkbox"">Несколько из списка</option>\
                            </select>\
                            <button onclick=""createAnswer('+ numQuestion + ')"">Добавить ответ</button>\
                            <button onclick=""deleteQuestion('+ numQuestion + ')"">Удалить</button>\
                            </div>';
                let childComp = document.getElementById(""baseContainer"");
                let div = document.createElement('div');
                div.innerHTML = str;
                childComp.appendChi");
                WriteLiteral(@"ld(div).setAttribute(""id"", `q${numQuestion}`);
                event.preventDefault();
            }

            function createAnswer(num) {
                document.getElementById(""sbtn"").style.visibility = ""hidden"";
                numAnswer++;
                console.log()
                let str = '\<div id=""ans' + numAnswer + '"" style=""display:inline;"" num=""' + numAnswer + '""><input id=""ka' + numAnswer + '""  value=""' + numAnswer + '"" type=""' + getType(num) + '"" name=""isTrue[' + num + ']""/>\
                            <input id=""ia' + numAnswer + '"" type=""text"" placeholder=""Введите ответ"" name=""answer[' + num + ']"" />\
                            <button onclick=""deleteAnswer('+ numAnswer + ')"">Удалить</button></div>';

                let childComp = document.getElementById(""q"" + num);
                let div = document.createElement('div');
                div.innerHTML = str;
                childComp.appendChild(div).setAttribute(""id"", `ans${numAnswer}`);

                let typeE");
                WriteLiteral(@"lement = document.getElementById(""type"" + num);
                typeElement.style.display = ""none"";
                event.preventDefault();
            }

            function getType(num) {
                let e = document.getElementById(""type"" + num);
                return e.options[e.selectedIndex].value;
            }

            function deleteAnswer(num) {
                document.getElementById(""sbtn"").style.visibility = ""hidden"";
                document.getElementById(""ans"" + num).remove();
                deletable.push(num);
                event.preventDefault();
            }

            function deleteQuestion(num) {
                deletableQ.push(num);
                document.getElementById(""sbtn"").style.visibility = ""hidden"";
                let quest = document.getElementById(""q"" + num).children;
                for (var i = 1; i < quest.length; i++) {
                   let strAtr = quest.item(i).getAttribute(""id"");
                   deletable.push(Number(strAtr.");
                WriteLiteral(@"replace(""ans"", '')));
                }
                document.getElementById(""q"" + num).remove();
                event.preventDefault();
            }

            function validate() {
                var textName = document.getElementById(""testname"").value;
                console.log(textName)
                if (textName == '') {
                    listError.push(""Enter test name"");
                }

                let counterContainer = document.getElementById(""baseContainer"").children.length;
                console.log(""ob kol"" + counterContainer);

                if (counterContainer == 1) {
                    listError.push(""Add answers"");
                }
                for (var i = 1; i < counterContainer; i++) {
                    if (deletableQ.indexOf(i) >= 0) {
                        continue;
                    }
                    else {
                        let question = document.getElementById(""q"" + i).children;
                        let questNa");
                WriteLiteral(@"me = question.item(0).children.item(0).value//question name input
                        console.log(questName);

                        let counterAnswers = question.length;
                        console.log(""ans kol"" + counterAnswers);

                        if (questName == '') {
                            listError.push(""Enter qestion text for question "" + i);
                        }
                        if (counterAnswers == 1) {
                            listError.push(""Add answer for question "" + i);
                        }
                        let counterBox = 0;
                        for (var j = 1; j < counterAnswers; j++) {
                            let box = question.item(j).children.item(0).children.item(0).checked; // box checked
                            let ansI = question.item(j).children.item(0).children.item(1).value;//answer text input
                            if (box === false) {
                                counterBox++;
                  ");
                WriteLiteral(@"          }

                            if (ansI.length == 0) {
                                listError.push(""Enter text answer for question № "" + i + "" answer "" + j);
                            }
                            console.log(box);
                            console.log(ansI);
                        }
                        if (counterBox == counterAnswers - 1 && counterAnswers > 1) {
                            listError.push(""Chose correct answer/s for question "" + questName);
                        }
                    }
                }
                //
                let counterChild = document.getElementById(""listErrors"").children.length;
                if (counterChild > 0) {
                    for (var i = 0; i < counterChild; i++) {
                        let el = document.getElementById(""error"");
                        document.getElementById(""error"").remove();
                    }
                }

                event.preventDefault();
        ");
                WriteLiteral(@"    }

            function apply() {
                validate();
                for (var i = 1; i <= numAnswer; i++) {
                    if (deletable.indexOf(i) >= 0) {
                        continue;
                    }
                    else {
                        document.getElementById(""ka"" + i).value = document.getElementById(""ia"" + i).value;
                    }
                }
                if (listError.length == 0) {
                    document.getElementById(""sbtn"").style.visibility = ""visible"";
                }
                else {
                    let errors = '';
                    for (var i = 0; i < listError.length; i++) {

                        let childComp = document.getElementById(""listErrors"");
                        let div = document.createElement('div');
                        div.innerHTML = '<div>' + listError[i] + '</div>';
                        childComp.appendChild(div).setAttribute(""id"", ""error"");
                    }

  ");
                WriteLiteral("                  listError = [];\r\n                }\r\n                event.preventDefault();\r\n            }\r\n        </script>\r\n        <div>\r\n            <button onclick=\"apply()\">Сохранить</button>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1f353ea367e6f25357b843d61dd7712be34a091d31865", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
