<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QuickEmailer._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="emailContainer">
        <h1>Email Agencies</h1>
    </div>


    <div class="container">

        <div class="emailContainer">
            <asp:Label runat="server" Text="Select Agencies" Font-Size="Medium"></asp:Label>

            <asp:Button ID="button_SelectAll" runat="server" Text="Select All" CssClass="btn btn-primary" OnClick="button_SelectAll_Click" />
            <asp:Button ID="button_DeselectAll" runat="server" Text="Deselect All" CssClass="btn btn-primary" OnClick="button_DeselectAll_Click" />
        </div>

        <div class="emailContainer">

            <asp:CheckBoxList runat="server" ID="CheckBoxList_agencies" RepeatColumns="5" RepeatDirection="Horizontal" CssClass="agencies-checkBox"></asp:CheckBoxList>
        </div>


        <div class="container emailContainer">
            <div class="col-md-2 text-right emailTitleLabels">
                <asp:Label runat="server" ID="label_EDH_Title" Text="[EDH]"></asp:Label>
            </div>
            <div class="col-md-7">
                <asp:TextBox ID="TextBox_Title" runat="server" CssClass="form-control" placeholder="Enter Title"></asp:TextBox>
            </div>
            <div class="col-md-2 text-left emailTitleLabels">
                <asp:Label runat="server" ID="label_Agency" Text="[Agency Name]"></asp:Label>
            </div>
        </div>

        <div class="container emailContainer">
            <asp:TextBox ID="TextBox_emailBody" runat="server" CssClass="form-control emailBody" TextMode="MultiLine" Height="200px" placeholder="Enter Message"></asp:TextBox>
        </div>
        <div class="container emailContainer">
            <asp:Button ID="button_submitEmail" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="button_submitEmail_Click" />
        </div>

    </div>
</asp:Content>





