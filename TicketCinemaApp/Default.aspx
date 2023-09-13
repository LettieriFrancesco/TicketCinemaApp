<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TicketCinemaApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/Site.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <h1 class="text-center">Cinema Multisala</h1>
                <div class="d-flex flex-column">
                    <div class="col-12 d-flex mt-5 justify-content-center">
                        <asp:Label ID="Label1" runat="server" CssClass="align-items-center" Text="Username"></asp:Label>
                        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-12 d-flex justify-content-center">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" runat="server" ForeColor="Red" ErrorMessage="Campo Obbligatorio"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-12 d-flex mt-3 justify-content-center">
                        <asp:Label ID="Label2" runat="server" CssClass="align-items-center" Text="Password"></asp:Label>
                        <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-12 d-flex justify-content-center">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBox2" runat="server" ForeColor="Red" ErrorMessage="Campo Obbligatorio"></asp:RequiredFieldValidator>
                    </div>
                    <div class="col-12 d-flex mt-2 justify-content-center">
                        <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="Login" OnClick="Button1_Click" />
                    </div>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
