<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebUI.aspx.cs" Inherits="Web.WebUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator App-ASMX</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <style>
        #btnAction, #btnInc, #btnMul, #btnDiv {
            width: 100%;
            height: 100%;
            font-size: 19px;
            font-weight: bold;
        }

        div.row .res {
            padding-right: 0px;
            padding-bottom: 16px;
        }
        #lblSol{
            font-size:5em;
            color:white;
        }
    </style>
</head>
<body style="background-color: gray;">
    <div class="row">
        <div style="width: 100%; border-bottom: 1px dashed white; text-align: center; background-color: black; position: relative;">
            <div style="font-size: 35px; color: white">
                ASMX Calculator
        <span style="position: absolute; right: 3%; top: 59%; color: white; font-size: 12px;">Fehmi AKSAKAL</span>
            </div>
        </div>
    </div>
    <div class="container mt-5" style="background: #333; border-radius: 10px;">
        <form runat="server" class="row ">
            <div class="col-lg-4 col-md-4 col-sm-4 mt-2">
                <div class="form-group">
                    <label for="txtNumberOne" style="color: white">First Number</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtnumberOne"></asp:TextBox>
                </div>

                <div class="form-group">
                    <label for="txtNumberOne" style="color: white">Second Number</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="txtnumberTwo"></asp:TextBox>
                </div>
            </div>
            <div class="col-lg-4 col-md-4 col-sm-4 mt-3 row">
                <div class="col-lg-3 col-md-3 col-sm-3 res">
                    <asp:Button runat="server" ID="btnAction" CssClass="btn btn-primary" OnClick="btnAction_Click" Text="+"></asp:Button>
                </div>
                <div class="col-lg-3 col-md-3 col-sm-3 res">
                    <asp:Button runat="server" ID="btnInc" CssClass="btn btn-danger" OnClick="btnInc_Click" Text="-"></asp:Button>
                </div>
                <div class="col-lg-3 col-md-3 col-sm-3 res">
                    <asp:Button runat="server" ID="btnMul" CssClass="btn btn-warning" OnClick="btnMul_Click" Text="*"></asp:Button>
                </div>
                <div class="col-lg-3 col-md-3 col-sm-3 res">
                    <asp:Button runat="server" ID="btnDiv" CssClass="btn btn-success" OnClick="btnDiv_Click" Text="/"></asp:Button>
                </div>
            </div>
            <div class="col-lg-4 col-md-4 col-sm-4 mt-3" style="text-align:center">
            <asp:Label runat="server" ID="lblSol" CssClass="Solution"></asp:Label>
            </div>
    </form>
    </div>

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</body>
</html>
