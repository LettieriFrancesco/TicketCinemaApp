<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prenotazione.aspx.cs" Inherits="TicketCinemaApp.Prenotazione" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <h1 class="text-center">Prenotazione Ticket</h1>
                <div class="d-flex justify-content-between">
                     <h3 id="DatiUtenteUsername" runat="server" class="text-warning mt-3 text-decoration-underline"></h3>
                    <asp:Button ID="Button2" CssClass="btn btn-danger" runat="server" Text="Logout" OnClick="Button2_Click" />
                </div>
                <div class="col-12 d-flex mt-5 justify-content-center">
                    <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-12 d-flex justify-content-center">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" ForeColor="Red" runat="server" ErrorMessage="Campo nome obbligatorio"></asp:RequiredFieldValidator>
                </div>
                <div class="col-12 d-flex mt-3 justify-content-center">
                    <asp:Label ID="Label2" runat="server" Text="Cognome"></asp:Label>
                    <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-12 d-flex justify-content-center">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox2" ForeColor="Red" runat="server" ErrorMessage="Campo cognome obbligatorio"></asp:RequiredFieldValidator>
                </div>
                <div class="d-flex justify-content-center mt-3">
                    <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                        <asp:ListItem Value="Ticket" Text="Seleziona Sala"></asp:ListItem>
                        <asp:ListItem Value="Ticket SalaNord" Text="Ticket SalaNord"></asp:ListItem>
                        <asp:ListItem Value="Ticket SalaEst" Text="Ticket SalaEst"></asp:ListItem>
                        <asp:ListItem Value="Ticket SalaSud" Text="Ticket SalaSud"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="d-flex justify-content-center mt-2">
                    <asp:CheckBoxList ID="CheckBoxList1" CssClass="ms-4" runat="server">
                        <asp:ListItem Value="Ticket ridotto" Text="Ticket ridotto"></asp:ListItem>
                    </asp:CheckBoxList>
                </div>
                <div class="d-flex justify-content-center mt-5">
                    <asp:Button ID="Button1" CssClass="btn btn-success" runat="server" Text="Prenota" OnClick="Button1_Click" />
                </div>
                <div class="mt-5 ">
                    <h3 id="Riepilogo" class="text-center" runat="server"></h3>
                    <div class="d-flex align-items-center flex-column">
                        <asp:Label ID="LabelMessaggio" runat="server" Text=""></asp:Label>
                        <asp:Label ID="LabelDettagliPrenotazione" runat="server" Text=""></asp:Label>
                        <asp:Label ID="LabelBigliettiVendutiNord" runat="server" Text=""></asp:Label>
                        <asp:Label ID="LabelBigliettiVendutiEst" runat="server" Text=""></asp:Label>
                        <asp:Label ID="LabelBigliettiVendutiSud" runat="server" Text=""></asp:Label>
                        <asp:Label ID="LabelPostiRimanentiNord" runat="server" Text=""></asp:Label>
                        <asp:Label ID="LabelPostiRimanentiEst" runat="server" Text=""></asp:Label>
                        <asp:Label ID="LabelPostiRimanentiSud" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
