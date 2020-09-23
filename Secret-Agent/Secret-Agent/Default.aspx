<%@ Page Language="C#" Inherits="SecretAgent.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
    <style type="text/css">
            body {
                font-family: Verdana, sans-serif;
                font-size: 13px;
                color: #333;
            }
            input[Type=Text] {
                background: #ededed;
                border: 1px #333 solid;
                border-radius: 3px;
                width: 200px;
                height: 15px;
                padding: 10px;
                margin: 2px 0;
            }
            input[Type=Submit] {
                background: darkgreen;
                color: white;
                width: 150px;
                height: auto;
                padding: 5px;
                border: 1px #333 solid;
                border-radius: 5px;
                margin: 5px;
            }
            #LabelAgentInfo, #HandleAgent {
                font-weight: bold;
            }
            .InfoTxt {
                display: block;
                width: 210px;
                background: lightblue;
                color: black;
                padding: 5px;
                border: 1px #ddd solid;
            }
            #ListBoxAgents {
                width: 300px;
                height: 200px;
            }
    </style>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Label ID="LabelAgentInfo" runat="server" Text="New Agent Info"></asp:Label><br/>
        <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <asp:Label ID="LabelName" runat="server" Text="Real name"></asp:Label><br/>
        <asp:TextBox ID="TextBoxLang1" runat="server"></asp:TextBox>
        <asp:Label ID="LabelLang1" runat="server" Text="Native lang"></asp:Label><br/>
        <asp:TextBox ID="TextBoxLang2" runat="server"></asp:TextBox>
        <asp:Label ID="LabelLang2" runat="server" Text="Other lang"></asp:Label><br/>
        <asp:Button id="button1" runat="server" Text="+ Create New Agent!" OnClick="createAgent" /><br/><br/>
            
        <asp:Label ID="LabelNo_Agents" CssClass="InfoTxt" runat="server" Text="Number of Agents: "></asp:Label>
        <asp:Button id="button2" runat="server" Text="Show All Agents!" OnClick="showAgents" /><br/>
        <asp:ListBox ID="ListBoxAgents" runat="server" name="ListBoxAgents"></asp:ListBox><br/>
        <asp:Button id="button3" runat="server" Text="Handle Chosen Agent" OnClick="handleAgent" /><br/><br/>
        
        <asp:Label ID="HandleAgent" runat="server" Text="Choose an Agent"></asp:Label><br/>
        <asp:TextBox ID="EditName" runat="server"></asp:TextBox>
        <asp:Label runat="server" Text="Real name"></asp:Label><br/>
        <asp:TextBox ID="EditLang1" runat="server"></asp:TextBox>
        <asp:Label runat="server" Text="Native lang"></asp:Label><br/>
        <asp:TextBox ID="EditLang2" runat="server"></asp:TextBox>
        <asp:Label runat="server" Text="Other lang"></asp:Label><br/>
        <asp:TextBox ID="EditCeasarText" runat="server"></asp:TextBox>
        <asp:Label runat="server" Text="Ceaser Encryption String"></asp:Label><br/>
        <asp:TextBox ID="EditCeasarKey" runat="server"></asp:TextBox>
        <asp:Label runat="server" Text="Ceaser Encryption Key (only number)"></asp:Label><br/>
        <asp:Button id="button4" runat="server" Text="Update Agent" OnClick="updateAgent" />
	</form>
</body>
</html>
