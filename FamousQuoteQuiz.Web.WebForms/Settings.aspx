﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Settings.aspx.cs" Inherits="FamousQuoteQuiz.Web.WebForms.Settings" %>

<%@ Import Namespace="FamousQuoteQuiz.Common" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="">Change the mode:</div>

    <div class="mt30">
        <label for="binary_mode">Binary Mode</label>
        <asp:RadioButton runat="server" CssClass="rb_mode" GroupName="mode" ID="binary_mode" ClientIDMode="Static"/>
        <%--<input class="rb_mode" type="radio" id="binary_mode" name="mode" checked="<%= GlobalVariables.BinaryMode %>" />--%>

        <label for="multichoice_mode">Multi choice Mode</label>
        <asp:RadioButton runat="server" CssClass="rb_mode" GroupName="mode" ID="multichoice_mode" ClientIDMode="Static"/>

        <%--<input class="rb_mode" type="radio" id="multichoice_mode" name="mode" />--%>
    </div>
</asp:Content>
