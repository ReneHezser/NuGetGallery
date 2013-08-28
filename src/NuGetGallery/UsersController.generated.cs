// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace NuGetGallery {
    public partial class UsersController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected UsersController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult ConfirmationRequired() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.ConfirmationRequired);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Confirm() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Confirm);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public System.Web.Mvc.ActionResult Profiles() {
            return new T4MVC_ActionResult(Area, Name, ActionNames.Profiles);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public UsersController Actions { get { return MVC.Users; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Users";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Account = "Account";
            public readonly string ConfirmationRequired = "ConfirmationRequired";
            public readonly string Edit = "Edit";
            public readonly string Register = "Register";
            public readonly string Thanks = "Thanks";
            public readonly string Packages = "Packages";
            public readonly string GenerateApiKey = "GenerateApiKey";
            public readonly string ForgotPassword = "ForgotPassword";
            public readonly string ResendConfirmation = "ResendConfirmation";
            public readonly string PasswordSent = "PasswordSent";
            public readonly string ResetPassword = "ResetPassword";
            public readonly string Confirm = "Confirm";
            public readonly string Profiles = "Profiles";
            public readonly string ChangePassword = "ChangePassword";
            public readonly string PasswordChanged = "PasswordChanged";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string Account = "~/Views/Users/Account.cshtml";
            public readonly string ChangePassword = "~/Views/Users/ChangePassword.cshtml";
            public readonly string Confirm = "~/Views/Users/Confirm.cshtml";
            public readonly string ConfirmationRequired = "~/Views/Users/ConfirmationRequired.cshtml";
            public readonly string Edit = "~/Views/Users/Edit.cshtml";
            public readonly string ForgotPassword = "~/Views/Users/ForgotPassword.cshtml";
            public readonly string Packages = "~/Views/Users/Packages.cshtml";
            public readonly string PasswordChanged = "~/Views/Users/PasswordChanged.cshtml";
            public readonly string PasswordSent = "~/Views/Users/PasswordSent.cshtml";
            public readonly string Profiles = "~/Views/Users/Profiles.cshtml";
            public readonly string Register = "~/Views/Users/Register.cshtml";
            public readonly string ResendConfirmation = "~/Views/Users/ResendConfirmation.cshtml";
            public readonly string ResetPassword = "~/Views/Users/ResetPassword.cshtml";
            public readonly string Thanks = "~/Views/Users/Thanks.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_UsersController: NuGetGallery.UsersController {
        public T4MVC_UsersController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Account() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Account);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ConfirmationRequired(string returnUrl) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ConfirmationRequired);
            callInfo.RouteValueDictionary.Add("returnUrl", returnUrl);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Edit() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Edit(NuGetGallery.EditProfileViewModel profile) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
            callInfo.RouteValueDictionary.Add("profile", profile);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Register() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Register);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Register(NuGetGallery.RegisterRequest request) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Register);
            callInfo.RouteValueDictionary.Add("request", request);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Thanks() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Thanks);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Packages() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Packages);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult GenerateApiKey() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.GenerateApiKey);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ForgotPassword() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ForgotPassword);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ForgotPassword(NuGetGallery.ForgotPasswordViewModel model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ForgotPassword);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ResendConfirmation() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ResendConfirmation);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ResendConfirmation(NuGetGallery.ResendConfirmationEmailViewModel model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ResendConfirmation);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult PasswordSent() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.PasswordSent);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ResetPassword() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ResetPassword);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ResetPassword(string username, string token, NuGetGallery.PasswordResetViewModel model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ResetPassword);
            callInfo.RouteValueDictionary.Add("username", username);
            callInfo.RouteValueDictionary.Add("token", token);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Confirm(string username, string token) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Confirm);
            callInfo.RouteValueDictionary.Add("username", username);
            callInfo.RouteValueDictionary.Add("token", token);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Profiles(string username) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Profiles);
            callInfo.RouteValueDictionary.Add("username", username);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ChangePassword() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ChangePassword);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult ChangePassword(NuGetGallery.PasswordChangeViewModel model) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.ChangePassword);
            callInfo.RouteValueDictionary.Add("model", model);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult PasswordChanged() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.PasswordChanged);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
