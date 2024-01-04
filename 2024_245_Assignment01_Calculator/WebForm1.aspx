<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2024_245_Assignment01_Calculator.WebForm1" StyleSheetTheme="Theme1"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>245 Calculator</title>
</head>
<body>
<form id="form1" runat="server">
        <div class="CalculatorContainer">
            <div class="ButtonContainer"> 
                <asp:TextBox ID="TxtDisplay" runat="server" ReadOnly="True"></asp:TextBox>
                <asp:Button class="Clear" ID="Clear" runat="server" Text="C" OnClick="Clear_Click" />
                <asp:Button class="OpButton" ID="Divide" runat="server" OnClick="Number" Text="/" />

                <asp:Button class="Button" ID="Seven" runat="server" OnClick="Number" Text="7" />
                <asp:Button class="Button" ID="Eight" runat="server" OnClick="Number" Text="8" />
                <asp:Button class="Button" ID="Nine" runat="server" OnClick="Number" Text="9" />
                <asp:Button class="OpButton" ID="Multiply" runat="server" OnClick="NonNumber" Text="*" />

                <asp:Button class="Button" ID="Four" runat="server" OnClick="Number" Text="4" />
                <asp:Button class="Button" ID="Five" runat="server" OnClick="Number" Text="5" />
                <asp:Button class="Button" ID="Six" runat="server" OnClick="Number" Text="6" />
                <asp:Button class="OpButton" ID="Minus" runat="server" OnClick="NonNumber" Text="-" />

                <asp:Button class="Button" ID="One" runat="server" OnClick="Number" Text="1" />
                <asp:Button class="Button" ID="Two" runat="server" OnClick="Number" Text="2" />
                <asp:Button class="Button" ID="Three" runat="server" OnClick="Number" Text="3" />
                <asp:Button class="OpButton" ID="Plus" runat="server" OnClick="NonNumber" Text="+" />

                <asp:Button class="OpButton" ID="Decimal" runat="server" OnClick="Number" Text="." />
                <asp:Button class="Button" ID="Zero" runat="server" OnClick="Number" Text="0" />
                <asp:Button class="Equals" ID="Equals" runat="server" OnClick="Calculate" Text="=" />
            </div>
        </div>
    </form>
</body>
</html>
