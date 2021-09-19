#pragma checksum "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecb5681a4f269a1af62085077f54a6f530346d29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
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
#line 1 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\_ViewImports.cshtml"
using Lets2Chat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\_ViewImports.cshtml"
using Lets2Chat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecb5681a4f269a1af62085077f54a6f530346d29", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7ce6e0c08e57810446088fffd2faec69977112", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Message>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("SendMessageForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\Chat\Index.cshtml"
  
    var messages = ViewBag.Messages as List<Message>;
    var username = ViewBag.NowUserName as string;
    var privateMessageUrl = "/Chat/PrivateMessage/";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .chat {
        max-height: 65vh;
        overflow-y: scroll;
        border: 1px solid silver;
    }

        .chat::-webkit-scrollbar {
            width: 5px;
        }

        .chat::-webkit-scrollbar-thumb {
            box-shadow: inset 0 0 6px rgba(0,0,0,.3);
            background-color: silver;
        }

</style>

<div class=""jumbotron bg-light chat"" id=""chat"">
");
#nullable restore
#line 27 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\Chat\Index.cshtml"
     if (messages != null)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\Chat\Index.cshtml"
         foreach (var message in messages.OrderBy(m => m.Datetime))
        {
            var position = username == message.UserName ? "text-right" : "text-left";
            var alert = username == message.UserName ? "alert-info" : "alert-secondary";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 936, "\"", 963, 2);
            WriteAttributeValue("", 944, "col-md-12", 944, 9, true);
#nullable restore
#line 35 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\Chat\Index.cshtml"
WriteAttributeValue(" ", 953, position, 954, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <small class=\"text-dark\">");
#nullable restore
#line 36 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\Chat\Index.cshtml"
                                        Write(message.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1063, "\"", 1088, 3);
            WriteAttributeValue("", 1071, "alert", 1071, 5, true);
            WriteAttributeValue(" ", 1076, "mb-0", 1077, 5, true);
#nullable restore
#line 37 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\Chat\Index.cshtml"
WriteAttributeValue(" ", 1081, alert, 1082, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n                        <span class=\"d-block\">");
#nullable restore
#line 38 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\Chat\Index.cshtml"
                                         Write(message.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <small class=\"text-info\">");
#nullable restore
#line 40 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\Chat\Index.cshtml"
                                        Write(message.Datetime.ToString("dd/MM HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 43 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\Chat\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\Chat\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecb5681a4f269a1af62085077f54a6f530346d298032", async() => {
                WriteLiteral("\r\n    <div class=\"input-group mb-4 col-md-12\">\r\n        <input name=\"Descricao\" id=\"MessageText\" class=\"form-control\" />\r\n        <button type=\"submit\" id=\"submitBtn\" class=\"btn btn-info\">Enviar</button>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/microsoft-signalr/3.1.7/signalr.min.js\"></script>\r\n    <script src=\"https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js\"></script>\r\n\r\n    <script>\r\n        var username = \"");
#nullable restore
#line 61 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\Chat\Index.cshtml"
                   Write(username);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n        var privateUrl = \"");
#nullable restore
#line 62 "D:\Módulo4\ProjetoDoModulo\ChatComPrivate\Lets2Chat\Views\Chat\Index.cshtml"
                     Write(privateMessageUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
        var objDiv = document.getElementById(""chat"");
        objDiv.scrollTop = objDiv.scrollHeight;

        var connection = new signalR.HubConnectionBuilder().withUrl(""/chathub"").build();

        function formataData(dateString) {
        var date = new Date(Date.parse(dateString));
        var dateStr =
            (""00"" + date.getDate()).slice(-2) + ""/"" +
            (""00"" + (date.getMonth() + 1)).slice(-2) + "" "" +
            (""00"" + date.getHours()).slice(-2) + "":"" +
            (""00"" + date.getMinutes()).slice(-2);
        return dateStr;
        }

        connection.on(""ReceiveMessage"", (data) => {
        var position = data.userName === username ? ""text-right"" : ""text-left"";
        var alert = data.userName === username ? ""alert-info"" : ""alert-secondary"";

        var message = document.createElement(""div"");
        message.className = ""row"";

        var messageCol = document.createElement(""div"");
        messageCol.classList = ""col-md-12 "" + position;

        var");
                WriteLiteral(@" messageUser = document.createElement(""a"")
        messageUser.className = ""small text-dark"";
        messageUser.href = privateUrl + data.userName;
        messageUser.textContent = data.userName;

        var messageAlert = document.createElement(""div"");
        messageAlert.classList = ""alert mb-0 "" + alert;

        var messageAlertMessage = document.createElement(""div"");
        messageAlertMessage.className = ""d-block"";
        messageAlertMessage.innerHTML = data.descricao;

        var messageDt = document.createElement(""small"");
        messageDt.className = ""text-info"";
        messageDt.textContent = formataData(data.datetime);

        messageAlert.appendChild(messageAlertMessage);
        messageCol.appendChild(messageUser);
        messageCol.appendChild(messageAlert);
        messageCol.appendChild(messageDt);
        message.appendChild(messageCol);
        console.log(message);
        document.getElementById(""chat"").appendChild(message);
        objDiv.scrollTop = objD");
                WriteLiteral(@"iv.scrollHeight;
        });

        connection.start().then(function () {
        console.log(""Connected"");
        document.getElementById(""SendMessageForm"").addEventListener(""submit"", function (event) {
            event.preventDefault();

            var value = document.getElementById(""MessageText"").value;
            if (value.lenght === 0 || !value.trim()) {
                return false;
            }

            var data = {
                Descricao: value,
                UserName: username
            }

            document.getElementById(""MessageText"").value = """";
            connection.invoke(""SendMessage"", data).catch(function (err) {
                return console.error(err.toString());
            });
        });
        }).catch(function (err) {
        return console.error(err.toString());
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
