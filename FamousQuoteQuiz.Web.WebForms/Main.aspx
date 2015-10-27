<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="FamousQuoteQuiz.Web.WebForms.Main" %>
<%@ Import Namespace="FamousQuoteQuiz.Common" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <%--@Html.HiddenFor(m => m.Question.Id, new { @class = "question", @id = @Model.Question.Id })--%>

    <div class="gray-label mb10">Who Said It?</div>

        <asp:Panel runat="server" CssClass="description" ID="description"></asp:Panel>

       <%-- <div class="description">"@Model.Question.Description"</div>--%>

        <div id="result_view"></div>
        <div class="btn-wrapper">
            <asp:LinkButton runat="server" ID="btn_next" CssClass="hidden_el btn btn-info">

            </asp:LinkButton>
            <%--@Html.ActionLink("Next", "Index", null, new { @class = "hidden_el btn btn-info", @id = "btn_next" })--%>
        </div>
        <div id="authors_container">
            <%if (GlobalVariables.BinaryMode)
              {
                  var author = Model.Authors.FirstOrDefault();
              } %>
           <%-- @if (GlobalVariables.BinaryMode)
        {
            
            var author = Model.Authors.FirstOrDefault();
            
            @Html.Partial("_BinaryModeView", author)
        }
        else
        {
            @Html.DisplayFor(m => m.Authors)
        }--%>
        </div>

    </div>
</asp:Content>
