<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cinema_be_s3_l3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">

    <div class="col-4">
        <asp:TextBox ID="nome" runat="server" placeholder="nome"></asp:TextBox>
        <asp:TextBox ID="cognome" runat="server" placeholder="cognome"></asp:TextBox>
        <asp:DropDownList ID="sceltaSala" runat="server" class="my-2">
                        <asp:ListItem Text="Sala rossa" Value="rossa"></asp:ListItem>
                        <asp:ListItem Text="Sala blu" Value="blu"></asp:ListItem>
                        <asp:ListItem Text="Sala verde" Value="verde"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:CheckBox ID="ridotto" runat="server" text="Ridotto"/>
        <br />
        <asp:Button ID="Insert" runat="server" Text="Inserisci spettatore" class="btn btn-primary mt-3" OnClick="Insert_Click"/>
    </div>

    <div class="col-8 border rounded-2 d-flex justify-content-around p-3" id="visualizzaStanze">
        <div class="border border-danger p-3">
            <p>Stanza Rossa</p>
            <p id="showSalaRossa" runat="server"></p>
        </div>

        <div class="border border-success p-3">
            <p>Stanza Verde</p>
            <p id="showSalaVerde" runat="server"></p>
        </div>

        <div class="border border-primary p-3">
            <p>Stanza Blu</p>
            <p id="showSalablu" runat="server"></p>
        </div>
    </div>

        

    </div>
</asp:Content>
