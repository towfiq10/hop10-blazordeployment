#pragma checksum "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ccca2895a07dcd9d21b02556edf46dbe4590666"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Login.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 7 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Login.razor"
     status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
#nullable restore
#line 9 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Login.razor"
 if (@status==1)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, "Welcome ");
            __builder.AddContent(6, 
#nullable restore
#line 11 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Login.razor"
                member.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "  \r\n");
#nullable restore
#line 12 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Login.razor"
    //<button @onclick="logout">Logout</button>
}
else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "    ");
            __builder.AddMarkupContent(9, "<p>Welcome, please login</p>\r\n    ");
            __builder.AddMarkupContent(10, "<label for=\"fname\">Username</label>\r\n    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "id", "username");
            __builder.AddAttribute(14, "name", "username");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Login.razor"
                               username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "<br><br>\r\n    ");
            __builder.AddMarkupContent(18, "<label for=\"lname\">Password</label>\r\n    ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "password");
            __builder.AddAttribute(21, "id", "password");
            __builder.AddAttribute(22, "name", "password");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Login.razor"
                                   password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "<br><br>\r\n    ");
            __builder.OpenElement(26, "p");
            __builder.AddContent(27, " ");
            __builder.AddContent(28, 
#nullable restore
#line 20 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Login.razor"
         message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "class", "btn btn-primary");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Login.razor"
                                              login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 22 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Login.razor"
       
    private string username;
    private string password;

    private string message;

    private int status {get; set;} = 0; //1 means login; o means not login

    private MemberData member;

    async Task login() //Task is a built in class, to perform asynchronous operations
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\waran\CS504\hop01-c-hello-world-towfiq10\Module 9\BlazorApp\Pages\Login.razor"
                                              
        //MyLogin.setLogin(1);//delete

        if(await MyLogin.LoginVerify(this.username, this.password)){
          status= MyLogin.getlogin();
          member=MyLogin.getLoggedinUserInfo();
          //NavigationeManager.NavigateTo("/"); //navigate back to home
        }else {
            message = "Username or password is incorrect";
        }        

    }

    //protected override async Task OnInitializedAsync() {
        //db.connectDB();
       // db.createTable();
       // db.createNewMember("Hussein", "cityu"); //fix
       // this.status = await MyLogin.GetLoginAsync();
        //this.member = await MyLogin.GetMemberInfo();
    //}
    
    
    void logout(){
        MyLogin.setlogin(0);
        status= MyLogin.getlogin();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SqliteService db { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginService MyLogin { get; set; }
    }
}
#pragma warning restore 1591
