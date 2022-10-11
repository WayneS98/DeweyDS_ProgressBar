<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReplacingBooks.aspx.cs" Inherits="PROG7312TASK1WAYNESTEVENS.ReplacingBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Replacing Books</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            height: 20px;
            margin-bottom: 20px;
            overflow: hidden;
            background-color: #f5f5f5;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 2px rgba(0,0,0,.1);
            box-shadow: inset 0 1px 2px rgba(0,0,0,.1);
            width: 607px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
          
</div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" BackColor="#FF3399" Text="Welcome To Replace Books"></asp:Label>
            <br />
            
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" BackColor="#999999" BorderColor="#3366FF" Text="Click Generate To get Started"></asp:Label>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="BtnGen" runat="server" BackColor="Blue" OnClick="BtnGen_Click" Text="Generate Call Numbers" ForeColor="White" />
        &nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        Numbers are here to show user <br />
        <br />
        1-- <asp:Label ID="Lbl1" runat="server" Text="First Number" BorderColor="Black" BorderStyle="Solid"></asp:Label>
        &nbsp;<asp:Label ID="LblLet1" runat="server"></asp:Label>
&nbsp; 2--
        <asp:Label ID="Lbl2" runat="server" Text="Second Number" BorderColor="Lime" BorderStyle="Solid"></asp:Label>
        <asp:Label ID="LblLet2" runat="server"></asp:Label>
        &nbsp; 3--
        <asp:Label ID="Lbl3" runat="server" Text="Third Number" BorderColor="#00FFCC" BorderStyle="Solid"></asp:Label>
        <asp:Label ID="LblLet3" runat="server"></asp:Label>
&nbsp; 4--
        <asp:Label ID="Lbl4" runat="server" Text="Fourth Number" BorderColor="#0033CC" BorderStyle="Solid"></asp:Label>
        <asp:Label ID="LblLet4" runat="server"></asp:Label>
        &nbsp; 5--
        <asp:Label ID="Lbl5" runat="server" Text="Fifth Number" BorderColor="Fuchsia" BorderStyle="Solid"></asp:Label>
        <asp:Label ID="LblLet5" runat="server"></asp:Label>
&nbsp;<br />
        <br />
        6--
        <asp:Label ID="Lbl6" runat="server" Text="Sixth Number" BorderColor="#660066" BorderStyle="Solid"></asp:Label>
        <asp:Label ID="LblLet6" runat="server"></asp:Label>
        &nbsp; 7--
        <asp:Label ID="Lbl7" runat="server" Text="Seventh Number" BorderColor="Red" BorderStyle="Solid"></asp:Label>
        <asp:Label ID="LblLet7" runat="server"></asp:Label>
        &nbsp; 8--
        <asp:Label ID="Lbl8" runat="server" Text="Eight Number" BorderColor="#CC3300" BorderStyle="Solid"></asp:Label>
        <asp:Label ID="LblLet8" runat="server"></asp:Label>
        &nbsp; 9--
        <asp:Label ID="Lbl9" runat="server" Text="Ninth Number" BorderColor="#660033" BorderStyle="Solid"></asp:Label>
        <asp:Label ID="LblLet9" runat="server"></asp:Label>
        &nbsp; 10--
        <asp:Label ID="Lbl10" runat="server" Text="Tenth Number" BorderColor="#CC99FF" BorderStyle="Solid"></asp:Label>
        
            <asp:Label ID="LblLet10" runat="server"></asp:Label>
        
            <br />
        <br />
        <p>All you have to do is get The numbers in Acsending order
        </p>
        <div class="container">
            
            <p>Your Current Progress is :&nbsp;
            <asp:Label ID="LblLevelup" runat="server" Text="LevelUp!"></asp:Label>
            </p> 
  <div class="auto-style1">
  <div class="progress-bar progress-bar-info progress-bar-striped active" role="progressbar" aria-valuenow="15" aria-valuemin="0" aria-valuemax="60" id="progressBar" runat="server">
    <p id="lblPercentage" runat="server"></p>
  </div>
</div>
   
</div>
        <p>
            <asp:Label ID="LblWR" runat="server" BorderStyle="Solid" Text="Correct or Incorrect"></asp:Label>
        </p>
&nbsp;&nbsp;
        <asp:TextBox ID="Txt1" runat="server" BackColor="White" BorderColor="Black" Width="100px"></asp:TextBox>
&nbsp;<asp:TextBox ID="Txt2" runat="server" BorderColor="Lime" Width="100px"></asp:TextBox>
        &nbsp;<asp:TextBox ID="Txt3" runat="server" BorderColor="Aqua" Width="100px"></asp:TextBox>
        &nbsp;<asp:TextBox ID="Txt4" runat="server" BorderColor="Blue" Width="100px"></asp:TextBox>
        &nbsp;<asp:TextBox ID="Txt5" runat="server" BorderColor="#FF33CC" Width="100px"></asp:TextBox>
        <br />
&nbsp;&nbsp; <asp:TextBox ID="Txt6" runat="server" BorderColor="#660066" Width="100px"></asp:TextBox>
        &nbsp;<asp:TextBox ID="Txt7" runat="server" BorderColor="Red" Width="100px"></asp:TextBox>
        &nbsp;<asp:TextBox ID="Txt8" runat="server" BorderColor="#993300" Width="100px"></asp:TextBox>
        &nbsp;<asp:TextBox ID="Txt9" runat="server" BorderColor="Maroon" Width="100px" ></asp:TextBox>
        &nbsp;<asp:TextBox ID="Txt10" runat="server" BorderColor="#CC33FF" Width="100px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:Button ID="BtnInspect" runat="server" BackColor="Red" Text="Check The Order" ForeColor="White" OnClick="BtnInspect_Click" />
        <br />
       
 
<br />
        <br />
        
        <br />
        <br />
    
    </form>
     </body>
</html>
