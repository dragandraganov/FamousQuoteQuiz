<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="FamousQuoteQuiz.Web.WebForms.Main" %>
<%@ Import Namespace="FamousQuoteQuiz.Common" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label runat="server" CssClass="hidden_el question" ID="hidden_questionId" ClientIDMode="Static">
        </asp:Label>
        <div class="gray-label mb10">Who Said It?</div>

        <asp:Panel runat="server" CssClass="description" ID="description"></asp:Panel>

        <div id="result_view">
            <span class="hidden_el" id="result_success">Correct! The right answer is: </span>
            <span class="hidden_el" id="result_mistake">Sorry, you are wrong! The right answer is: </span>
            <span id="result_authorName"></span>
        </div>
        <div class="btn-wrapper">
            <asp:LinkButton runat="server" ID="btn_next" ClientIDMode="Static" CssClass="hidden_el btn btn-info" OnClick="btn_next_Click" Text="Next">
            </asp:LinkButton>
        </div>

        <div id="authors_container">
            <%if (GlobalVariables.BinaryMode)
              {%>
            <asp:Label runat="server" CssClass="authorId hidden_el" ID="hidden_authorId" ClientIDMode="Static">
            </asp:Label>
            <asp:Panel runat="server" CssClass="text-center mb30 author-name" ID="author_name"></asp:Panel>
            <div class="row">
                <div class="col-sm-3 btn btn-xs btn_guess btn-yes" id="answer_true">Yes</div>
                <div class="col-sm-offset-6 col-sm-3 btn btn-xs btn_guess btn-no" id="answer_false">No</div>
            </div>
            <%}
              else
              {%>
            <asp:ListView runat="server" ID="authors_list">
                <ItemTemplate>
                    <div class="authors-wrapper" runat="server">
                        <a class="authors" id="<%# Eval("Id") %>">-> <%# Eval("FullName") %></a>
                    </div>
                </ItemTemplate>
            </asp:ListView>
            <%} %>
        </div>
    </div>
     <script type="text/javascript">
         $("#btnMainPage").addClass('page-active');
    </script>
</asp:Content>
