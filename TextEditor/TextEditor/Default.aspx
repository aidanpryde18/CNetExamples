<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TextEditor.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 65%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>
            <asp:Label ID="lbl_Header" runat="server" AssociatedControlID="txt_Editor" Text="Simple Text Editor"></asp:Label></h2>
    </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:TextBox ID="txt_Editor" 
                        runat="server"
                        AccessKey="T"
                        TextMode="MultiLine" Columns="50" Rows="10"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn_SingleLine" runat="server" Text="Single Line" OnClick="btn_SingleLine_Click" />
                    <asp:Button ID="btn_MultiLine" runat="server" Text="MultiLine" OnClick="btn_MultiLine_Click" />
                    <asp:Button ID="btn_Clear" runat="server" Text="Clear" OnClick="btn_Clear_Click" />
                    <asp:CheckBox ID="chk_Enable" runat="server" Text="Enable" Checked="true" AutoPostBack="true" OnCheckedChanged="chk_Enable_CheckedChanged" />
                </td>
            </tr>
            <tr>
                <td>Find:
                    <asp:TextBox ID="txt_Find" runat="server"></asp:TextBox>
                    Replace with: 
                    <asp:TextBox ID="txt_Replace" runat="server"></asp:TextBox>
                    <asp:Button ID="btn_Replace" runat="server" Text="OK" OnClick="btn_Replace_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    Text Color:
                    <asp:TextBox ID="txt_Color" 
                        TextMode="Color" Text="#000000" AutoPostBack="true" 
                        runat="server" OnTextChanged="txt_Color_TextChanged"></asp:TextBox>

                    &nbsp;Background Color:
                    <asp:TextBox ID="txt_BackColor"
                        TextMode="Color" Text="#FFFFFF" AutoPostBack="true"
                        runat="server" OnTextChanged="txt_BackColor_TextChanged"></asp:TextBox>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
