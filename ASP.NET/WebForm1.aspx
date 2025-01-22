<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP.NET.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.6.4.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
       
       <div>
            <div>
            <h2>Student Registration</h2>

            <label>Name:</label>
            <asp:TextBox ID="txtName" runat="server" OnTextChanged="txtName_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required!" ForeColor="Red"></asp:RequiredFieldValidator>
            <br/><br/>

            <label>Semester:</label>
            <asp:TextBox ID="txtSem" runat="server" OnTextChanged="txtSem_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvSem" runat="server" ControlToValidate="txtSem" ErrorMessage="Semester is required!" ForeColor="Red"></asp:RequiredFieldValidator>
            <br/><br/>

            <label>Branch:</label>
            <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvBranch" runat="server" ControlToValidate="txtBranch" ErrorMessage="Branch is required!" ForeColor="Red"></asp:RequiredFieldValidator>
            <br/><br/>

            <label>Email:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is required!" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$" ErrorMessage="Invalid email format!" ForeColor="Red"></asp:RegularExpressionValidator>
            <br/><br/>

            <label>Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revPassword" runat="server" ControlToValidate="txtPassword"
                ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$" ErrorMessage="Password must be at least 6 characters with a letter and a number!" ForeColor="Red"></asp:RegularExpressionValidator>
            <br/><br/>

            <label>Confirm Password:</label>
            <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="Confirm Password is required!" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="cvPassword" runat="server" ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword"
                ErrorMessage="Passwords do not match!" ForeColor="Red"></asp:CompareValidator>
            <br/>
                <asp:Button ID="Button2" runat="server" Text="Register" OnClick="Button2_Click" />
                <br/>

        </div>
    </form>
    
</body>
</html>
