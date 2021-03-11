<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="project01.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    	#container {
    	    width: 700px;
            height: 700px;
            border-radius: 50px;
            background-color: bisque;
            position: absolute;
			top: 10px;
			left: 290px;
		}

    	#LabelBackground {
    		width: 700px;
    		height: 90px;
    		position: relative;
    	}

    	#Label1 {
    	    position: absolute;
            width: 430px;
            font-size: 32pt;
			top: 20px;
			left: 155px;
		}

    	#display {
    	    position: absolute;
            width: 275px;
            height: 60px;
			top: 90px;
			left: 195px;
			right: 222px;
			margin-top: 0px;
            text-align: center;
        }
        
    	#Btn0 {
    	    position: absolute;
            width: 100px;
            height: 100px;
            font-size: 24pt;
			top: 515px;
			left: 290px;
		}

    	#Btn1 {
    	    position: absolute;
            width: 100px;
            height: 100px;
            font-size: 24pt;
			top: 170px;
			left: 170px;
            right: 430px;
        }
        
    	#Btn2 {
    	    position: absolute;
            width: 100px;
            height: 100px;
            font-size: 24pt;
			top: 170px;
			left: 290px;
		}

    	#Btn3 {
    	    position: absolute;
            width: 100px;
            height: 100px;
            font-size: 24pt;
			top: 170px;
			left: 410px;
		}
        
    	#Btn4 {
    	    position: absolute;
            width: 100px;
            height: 100px;
            font-size: 24pt;
			top: 285px;
			left: 170px;
		}
        
    	#Btn5 {
    	    position: absolute;
            width: 100px;
            height: 100px;
            font-size: 24pt;
			top: 285px;
			left: 290px;
		}
        
    	#Btn6 {
    	    position: absolute;
            width: 100px;
            height: 100px;
            font-size: 24pt;
			top: 285px;
			left: 410px;
		}
        
    	#Btn7 {
    	    position: absolute;
            width: 100px;
            height: 100px;
            font-size: 24pt;
			top: 400px;
			left: 170px;
		}
        
    	#Btn8 {
    	    position: absolute;
            width: 100px;
            height: 100px;
            font-size: 24pt;
			top: 400px;
			left: 290px;
		}
        
    	#Btn9 {
    	    position: absolute;
            width: 100px;
            height: 100px;
            font-size: 24pt;
			top: 400px;
			left: 410px;
		}
        
    	#start {
    	    position: absolute;
            width: 100px;
            height: 100px;
            font-size: 24pt;
			top: 515px;
			left: 410px;
		}
        
    	#clear {
    	    position: absolute;
            width: 100px;
            height: 100px;
            font-size: 24pt;
			top: 515px;
			left: 170px;
		}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div id="LabelBackground">
				<asp:Label ID="Label1" runat="server" Text="Microwave Interface"></asp:Label>
            </div> <!-- LabelBackground -->

			<asp:TextBox ID="display" runat="server" BorderColor ="Black" BorderStyle="Solid" Font-Bold="False" Font-Size="40pt" MaxLength="6" OnTextChanged="display_TextChanged">00:00</asp:TextBox>

	        <asp:Button ID="Btn0" runat="server" Text="0" OnClick="Btn0_Click" />
            <asp:Button ID="Btn1" runat="server" Text="1" OnClick="Btn1_Click" />
            <asp:Button ID="Btn2" runat="server" Text="2" OnClick="Btn2_Click" />
            <asp:Button ID="Btn3" runat="server" Text="3" OnClick="Btn3_Click" />
            <asp:Button ID="Btn4" runat="server" Text="4" OnClick="Btn4_Click" />
            <asp:Button ID="Btn5" runat="server" Text="5" OnClick="Btn5_Click" />
            <asp:Button ID="Btn6" runat="server" Text="6" OnClick="Btn6_Click" />
            <asp:Button ID="Btn7" runat="server" Text="7" OnClick="Btn7_Click" />
            <asp:Button ID="Btn8" runat="server" Text="8" OnClick="Btn8_Click" />
            <asp:Button ID="Btn9" runat="server" Text="9" OnClick="Btn9_Click" />
            <asp:Button ID="start" runat="server" Text="start" />
            <asp:Button ID="clear" runat="server" Text="clear" OnClick="clear_Click" />

        </div> <!-- container -->
    </form>
</body>
</html>
