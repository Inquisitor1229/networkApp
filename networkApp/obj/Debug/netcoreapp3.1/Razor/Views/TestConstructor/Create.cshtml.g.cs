#pragma checksum "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6aabef35e4f235a719ef3cb6b655a2031d410a06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestConstructor_Create), @"mvc.1.0.view", @"/Views/TestConstructor/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aabef35e4f235a719ef3cb6b655a2031d410a06", @"/Views/TestConstructor/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7316a8470aab35e9f06cffd6510345aa656d9ce", @"/Views/_ViewImports.cshtml")]
    public class Views_TestConstructor_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetTest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\Create.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6aabef35e4f235a719ef3cb6b655a2031d410a064493", async() => {
                WriteLiteral(@"
        <div id=""listErrors""></div>
        <div class=""form-group"">
            <label>Введите название теста</label>
            <input type=""text"" id=""testname"" name=""testName"" />
        </div>

        <div>
            <div id=""baseContainer"">
                <button onclick=""createQuestion()"">Добавить вопрос</button>

            </div>
        </div>

        <script>
            let deletableQ = [];
            let listError = [];
            let deletable = new Array();
            let numQuestion = 0;
            let numAnswer = 0;
            function createQuestion() {
                document.getElementById(""sbtn"").style.visibility = ""hidden"";
                numQuestion++;
                let str = '\<div id=""q' + numQuestion + '""><input type=""text"" name=""nameQuestion"" id=""qnm"" placeholder=""Введите вопрос""/>\
                                    <select onchange=""chngType('+ numQuestion +')"" name=""type"" id=""type' + numQuestion + '"">\
                                    ");
                WriteLiteral(@"    <option value=""radio"">Один из списка</option>\
                                        <option value=""checkbox"">Несколько из списка</option>\
                                    </select>\
                                    <button onclick=""createAnswer('+ numQuestion + ')"">Добавить ответ</button>\
                                    <button onclick=""deleteQuestion('+ numQuestion + ')"">Удалить</button>\
                                    </div>';
                let childComp = document.getElementById(""baseContainer"");
                let div = document.createElement('div');
                div.innerHTML = str;
                childComp.appendChild(div).setAttribute(""id"", `q${numQuestion}`);
                event.preventDefault();
            }

            function createAnswer(num) {
                document.getElementById(""sbtn"").style.visibility = ""hidden"";
                numAnswer++;
                console.log()
                let str = '\<div id=""ans' + numAnswer + '"" style=""di");
                WriteLiteral(@"splay:inline;"" num=""' + numAnswer + '""><input id=""ka' + numAnswer + '""  value=""' + numAnswer + '"" type=""' + getType(num) + '"" name=""isTrue[' + num + ']""/>\
                                    <input id=""ia' + numAnswer + '"" type=""text"" placeholder=""Введите ответ"" name=""answer[' + num + ']"" />\
                                    <button onclick=""deleteAnswer('+ numAnswer + ')"">Удалить</button></div>';


                let childComp = document.getElementById(""q"" + num);
                let div = document.createElement('div');
                div.innerHTML = str;
                childComp.appendChild(div).setAttribute(""id"", `ans${numAnswer}`);

                
                event.preventDefault();
            }

            function getType(num) {
                let e = document.getElementById(""type"" + num);                
                return e.options[e.selectedIndex].value;
            }

            function deleteAnswer(num) {
                document.getElementById(""sbtn"").styl");
                WriteLiteral(@"e.visibility = ""hidden"";
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
                    deletable.push(Number(strAtr.replace(""ans"", '')));
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
");
                WriteLiteral(@"
                let counterContainer = document.getElementById(""baseContainer"").children.length;
                console.log(""ob kol"" + counterContainer);

                if (counterContainer == 1) {
                    listError.push(""Add answers"");
                }
                for (var i = 1; i < counterContainer; i++) {
                    let question = document.getElementById(""q"" + i).children;
                    let questName = question.item(0).children.item(0).value//question name input
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
     ");
                WriteLiteral(@"               for (var j = 1; j < counterAnswers; j++) {
                        let box = question.item(j).children.item(0).children.item(0).checked; // box checked
                        let ansI = question.item(j).children.item(0).children.item(1).value;//answer text input
                        if (box === false) {
                            counterBox++;
                        }

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

                let counterChild = document.getElementById(""listErrors"").children.length;
                if (coun");
                WriteLiteral(@"terChild > 0) {
                    for (var i = 0; i < counterChild; i++) {
                        let el = document.getElementById(""error"");
                        document.getElementById(""error"").remove();
                    }
                }
                event.preventDefault();
            }

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
                        le");
                WriteLiteral(@"t childComp = document.getElementById(""listErrors"");
                        let div = document.createElement('div');
                        div.innerHTML = '<div>' + listError[i] + '</div>';
                        childComp.appendChild(div).setAttribute(""id"", ""error"");
                    }
                    listError = [];
                }

                event.preventDefault();
            }

            function chngType(num) {
                let children = document.getElementById(""q"" + num).children;
                console.log(children);
                let len = children.length;
                for (var i = 1; i < len; i++) {
                    let type = children.item(i).children.item(0).children.item(0).type = getType(num);                    
                }
            }
        </script>
        <div>
            <button onclick=""apply()"">Сохранить</button>
            <input id=""sbtn"" style=""visibility:hidden"" type=""submit"" />
        </div>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
