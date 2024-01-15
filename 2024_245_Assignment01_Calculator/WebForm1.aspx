<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2024_245_Assignment01_Calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>245 Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="CalculatorContainer">
        <asp:DropDownList runat="server" ID="ThemeDropDown" OnSelectedIndexChanged="ThemeDropDown_SelectedIndexChanged"></asp:DropDownList>
            <!-- row 1 -->
            <div class="textDisplay">
                <asp:TextBox ID="TxtDisplay" runat="server" ReadOnly="True"></asp:TextBox>
            </div>

            <!-- row 2 -->
            <div class="allClear">
                <asp:Button class="Button" ID="AllClear" runat="server" Text="AC" OnClick="AllClear_Click" />
            </div>
            <div class="clear">
                <asp:Button class="Button" ID="Clear" runat="server" Text="C" OnClick="Clear_Click" />
            </div>
            <div>
                <asp:Button class="Button" ID="Plus" runat="server" OnClick="Press" Text="+" />
            </div>

            <!-- row 3 -->
            <div>
                <asp:Button class="Button" ID="Seven" runat="server" OnClick="Press" Text="7" />
            </div>
            <div>
                <asp:Button class="Button" ID="Eight" runat="server" OnClick="Press" Text="8" />
            </div>
            <div>
                <asp:Button class="Button" ID="Nine" runat="server" OnClick="Press" Text="9" />
            </div>
            <div>
                <asp:Button class="Button" ID="Minus" runat="server" OnClick="Press" Text="-" />
            </div>

            <!-- row 4 -->
            <div>
                <asp:Button class="Button" ID="Four" runat="server" OnClick="Press" Text="4" />
            </div>
            <div>
                <asp:Button class="Button" ID="Five" runat="server" OnClick="Press" Text="5" />
            </div>
            <div>
                <asp:Button class="Button" ID="Six" runat="server" OnClick="Press" Text="6" />
            </div>
            <div>
                <asp:Button class="Button" ID="Multiply" runat="server" OnClick="Press" Text="*" />
            </div>

            <!-- row 5 -->
            <div>
                <asp:Button class="Button" ID="One" runat="server" OnClick="Press" Text="1" />
            </div>
            <div>
                <asp:Button class="Button" ID="Two" runat="server" OnClick="Press" Text="2" />
            </div>
            <div>
                <asp:Button class="Button" ID="Three" runat="server" OnClick="Press" Text="3" />
            </div>
            <div>
                <asp:Button class="Button" ID="Divide" runat="server" OnClick="Press" Text="/" />
            </div>

            <!-- row 6 -->
            <div class="allClear">
                <asp:Button class="Button" ID="Zero" runat="server" OnClick="Press" Text="0" />
            </div>
            <div>
                <asp:Button class="Button" ID="Decimal" runat="server" OnClick="Press" Text="." />
            </div>
            <div>
                <asp:Button class="Button" ID="Equals" runat="server" OnClick="Calculate" Text="=" />
            </div>
        </div>
    </form>
</body>
</html>
