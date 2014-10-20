<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShowVotingResults.aspx.cs" Inherits="PollSystem.ShowVotingResults" %>

<asp:Content ID="ContentVotingResults" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Voting results</h1>
    <h2>Question
        <asp:Label ID="LiteralQuestion" runat="server" Mode="Encode" /></h2>
    <ul>
        <asp:Repeater runat="server" ItemType="PollSystem.Models.Answer" ID="RepeaterAnswers">
            <ItemTemplate>
                <li>
                    <%#: Item.AnswerText %> ==> <%#: Item.Votes %>
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</asp:Content>
