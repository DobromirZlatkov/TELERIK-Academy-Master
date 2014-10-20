<%@ Page Title="Home Page" Language="C#" 
    MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" 
    Inherits="PollSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView ID="ListViewPolls" runat="server" ItemType="PollSystem.Models.Question">
        <LayoutTemplate>
            <div id="itemPlaceholder" runat="server"></div>
        </LayoutTemplate>
        <ItemTemplate>
            <div class="poll-question">
                <%#: Item.QuestionText %>
            </div>
            <ul>
                <asp:Repeater runat="server" DataSource="<%# Item.Answers %>" ItemType="PollSystem.Models.Answer">
                    <ItemTemplate>
                        <li>
                            <%#: Item.AnswerText %>
                            <asp:LinkButton Text="Vote" runat="server" CommandName="Vote" CommandArgument="<%#: Item.AnswerId %>" OnCommand="Vote_Command"/>

                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
