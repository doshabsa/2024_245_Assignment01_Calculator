<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2024_245_Assignment01_Calculator.WebForm1" StylesheetTheme="Theme1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>245 Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="CalculatorContainer">
            <!-- row 1 -->
            <div class="textDisplay">
                <asp:TextBox ID="TxtDisplay" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <!-- row 2 -->
            <div class="allClear">
                <asp:Button class="Button glow-button" ID="AllClear" runat="server" Text="AC" OnClick="Clear_Click" />
            </div>
            <div class="clear">
                <asp:Button class="Button glow-button" ID="Clear" runat="server" Text="C" OnClick="Clear_Click" />
            </div>
            <div>
                <asp:Button class="Button glow-button" ID="Plus" runat="server" OnClick="Input" Text="+" />
            </div>

            <!-- row 3 -->
            <div>
                <asp:Button class="Button glow-button" ID="Seven" runat="server" OnClick="Input" Text="7" />
            </div>
            <div>
                <asp:Button class="Button glow-button" ID="Eight" runat="server" OnClick="Input" Text="8" />
            </div>
            <div>
                <asp:Button class="Button glow-button" ID="Nine" runat="server" OnClick="Input" Text="9" />
            </div>
            <div>
                <asp:Button class="Button glow-button" ID="Minus" runat="server" OnClick="Input" Text="-" />
            </div>

            <!-- row 4 -->
            <div>
                <asp:Button class="Button glow-button" ID="Four" runat="server" OnClick="Input" Text="4" />
            </div>
            <div>
                <asp:Button class="Button glow-button" ID="Five" runat="server" OnClick="Input" Text="5" />
            </div>
            <div>
                <asp:Button class="Button glow-button" ID="Six" runat="server" OnClick="Input" Text="6" />
            </div>
            <div>
                <asp:Button class="Button glow-button" ID="Multiply" runat="server" OnClick="Input" Text="*" />
            </div>

            <!-- row 5 -->
            <div>
                <asp:Button class="Button glow-button" ID="One" runat="server" OnClick="Input" Text="1" />
            </div>
            <div>
                <asp:Button class="Button glow-button" ID="Two" runat="server" OnClick="Input" Text="2" />
            </div>
            <div>
                <asp:Button class="Button glow-button" ID="Three" runat="server" OnClick="Input" Text="3" />
            </div>
            <div>
                <asp:Button class="Button glow-button" ID="Divide" runat="server" OnClick="Input" Text="/" />
            </div>

            <!-- row 6 -->
            <div class="allClear">
                <asp:Button class="Button glow-button" ID="Zero" runat="server" OnClick="Input" Text="0" />
            </div>
            <div>
                <asp:Button class="Button glow-button" ID="Decimal" runat="server" OnClick="Input" Text="." />
            </div>
            <div>
                <asp:Button class="Button glow-button" ID="Equals" runat="server" OnClick="Calculate" Text="=" />
            </div>
        </div>
    </form>
</body>
</html>
