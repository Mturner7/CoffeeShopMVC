#pragma checksum "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\Home\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e7318850eebe9bda4aa3bf9e75315c53f94199"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registration), @"mvc.1.0.view", @"/Views/Home/Registration.cshtml")]
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
#line 1 "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\_ViewImports.cshtml"
using CoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e7318850eebe9bda4aa3bf9e75315c53f94199", @"/Views/Home/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0280a23aa28fddc99a39f5869bf0f0a5a4076c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/UserProfile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validate()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\mturner7\dev\week5labs\CoffeeShop\CoffeeShop\Views\Home\Registration.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>We\'re glad to have you on board</h2> <br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9e7318850eebe9bda4aa3bf9e75315c53f941994518", async() => {
                WriteLiteral(@"
    <fieldset>
        <legend>Enter you information below:</legend> <br />

        <input type=""hidden"" name=""Id"" />

        <div class=""form-group"">
            <div class=""text-danger"" id=""firstnamemsg""></div>
            <label name=""FirstName"">First name</label>
            <input name=""FirstName"" id=""firstname"" class=""form-control"" required />
        </div>
        <div class=""form-group"">
            <div class=""text-danger"" id=""lastnamemsg""></div>
            <label name=""LastName"">Last name</label>
            <input name=""LastName"" id=""lastname"" class=""form-control"" required />
        </div>
        <div class=""form-group"">
            <div class=""text-danger"" id=""usernamemsg""></div>
            <label name=""Username"">Username</label>
            <input name=""Username"" id=""username"" class=""form-control"" required />
        </div>
        <div class=""form-group"">
            <div class=""text-danger"" id=""phonenumbermsg""></div>
            <label name=""PhoneNumber"">Phone num");
                WriteLiteral(@"ber</label>
            <input class=""form-control"" name=""PhoneNumber"" id=""phonenumber""
                   placeholder=""Exanple: 313-676-9494"" />
        </div>
        <div class=""form-group"">
            <div class=""text-danger"" id=""emailmsg""></div>
            <label name=""Email""></label>
            <input class=""form-control"" name=""Email"" id=""email""
                   placeholder=""Example: abc123@faangcorp.com"" required />
        </div>
        <div class=""form-group"">
            <div class=""text-danger"" id=""passwordmsg""></div>
            <label name=""Password"">Password</label>
            <input class=""form-control"" type=""password"" name=""Password"" id=""password""
                   placeholder=""Must be at least 6 characters with a capital, number (0-9), and a special character"" required />
        </div>

        <div class=""form-group"">
            <div class=""text-danger"" id=""confirmpasswordmsg""></div>
            <label name=""Password"">Password</label>
            <input class=""f");
                WriteLiteral("orm-control\" type=\"password\" id=\"confirmpassword\"\r\n                   placeholder=\"Re-enter your password\" required />\r\n        </div>\r\n\r\n        <button type=\"submit\" class=\"btn btn-primary\">Sign Up</button>\r\n\r\n    </fieldset>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
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
            WriteLiteral(@"

<script>
    function validate() {
        var stat = true;
        let firstname = document.getElementById('firstname');
        let firstnamemsg = document.getElementById('firstnamemsg');
        if (firstname.value.match(/^[a-zA-Z]{2,}$/) == null) {
            firstnamemsg.innerHTML = ""Please enter a name with at least 2 letters and no special characters"";
            stat = false;
        }

        let lastname = document.getElementById('lastname');
        let lastnamemsg = document.getElementById('lastnamemsg');
        if (lastname.value.match(/^[a-zA-Z]{2,}$/) == null) {
            lastnamemsg.innerHTML = ""Please enter a name with at least 2 letters and no special characters"";
            stat = false;
        }

        let username = document.getElementById('username');
        let usernamemsg = document.getElementById('usernamemsg');
        if (username.value.match(/^[\w\d]{6,}$/) == null) {
            usernamemsg.innerHTML = ""Please enter a username with at least 6 cha");
            WriteLiteral(@"racters (alphanumeric characters only)"";
            stat = false;
        }

        let phonenumber = document.getElementById('phonenumber');
        let phonenumbermsg = document.getElementById('phonenumbermsg');
        if (phonenumber.value.match(/^(\(\d{3}\)|\d{3})([\.\-\s])?(\d{3})([\.\-\s])?(\d{4})([\.\-\s])?$/) == null) {
            phonenumbermsg.innerHTML = ""Please enter a valid phone number!"";
            stat = false;
        }

        let email = document.getElementById('email');
        let emailmsg = document.getElementById('emailmsg');
        if (email.value.match(/^\w{5,30}\");
            WriteLiteral(@"@\w{5,10}\.\w{1,5}$/) == null) {
            emailmsg.innerHTML = ""Please enter a valid email address!"";
            stat = false;
        }

        let password = document.getElementById('password');
        let passwordmsg = document.getElementById('passwordmsg');
        if (password.value.match(/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$!%*?&])[A-Za-z\d$!%*?&]{6,}$/) == null) {
            passwordmsg.innerHTML = ""Password needs to be at least 6 characters with an uppercase, numeric, and special character"";
            stat = false;
        }

        let confirmpassword = document.getElementById('confirmpassword');
        let confirmpasswordmsg = document.getElementById('confirmpasswordmsg');
        if (confirmpassword === password.innerHTML) {
            confirmpasswordmsg.innerHTML = ""Passwords do not match!"";
            stat = false;
        }

        return stat;
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
