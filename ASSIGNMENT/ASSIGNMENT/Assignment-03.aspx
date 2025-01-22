<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assignment-03.aspx.cs" Inherits="ASSIGNMENT.Assignment_03" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
      <form id="form1" runat="server">
        <div style="text-align: center; margin: 20px;">
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <!-- View 1: Personal Info -->
                <asp:View ID="View1" runat="server">
                    <h2>Student Personal Info</h2>
                    <table style="margin: auto;">
                        <tr>
                            <td>Name:</td>
                            <td>
                                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvName" runat="server" 
                                    ControlToValidate="txtName" ErrorMessage="Name is required." ForeColor="Red" />
                            </td>
                        </tr>
                        <tr>
                            <td>Gender:</td>
                            <td>
                                <asp:RadioButtonList ID="rblGender" runat="server">
                                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                                </asp:RadioButtonList>
                                <asp:RequiredFieldValidator ID="rfvGender" runat="server" 
                                    ControlToValidate="rblGender" InitialValue="" 
                                    ErrorMessage="Select a gender." ForeColor="Red" />
                            </td>
                        </tr>
                        <tr>
                            <td>Address:</td>
                            <td>
                                <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>Degree:</td>
                            <td>
                                <asp:DropDownList ID="ddlDegree" runat="server">
                                    <asp:ListItem Text="Select Degree" Value="" />
                                    <asp:ListItem Text="B.Sc" Value="B.Sc" />
                                    <asp:ListItem Text="B.Tech" Value="B.Tech" />
                                    <asp:ListItem Text="M.Sc" Value="M.Sc" />
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvDegree" runat="server" 
                                    ControlToValidate="ddlDegree" InitialValue="" 
                                    ErrorMessage="Select a degree." ForeColor="Red" />
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="btnNextToView2" runat="server" Text="Next" OnClick="btnNextToView2_Click" />
                </asp:View>

                <!-- View 2: Contact Info -->
                <asp:View ID="View2" runat="server">
                    <h2>Student Contact Info</h2>
                    <table style="margin: auto;">
                        <tr>
                            <td>Email:</td>
                            <td>
                                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                                    ControlToValidate="txtEmail" ErrorMessage="Email is required." ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                                    ControlToValidate="txtEmail" 
                                    ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$" 
                                    ErrorMessage="Invalid email format." ForeColor="Red" />
                            </td>
                        </tr>
                        <tr>
                            <td>Contact No:</td>
                            <td>
                                <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvContact" runat="server" 
                                    ControlToValidate="txtContact" ErrorMessage="Contact number is required." ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revContact" runat="server" 
                                    ControlToValidate="txtContact" 
                                    ValidationExpression="^\d{10}$" 
                                    ErrorMessage="Contact number must be 10 digits." ForeColor="Red" />
                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="btnPreviousToView1" runat="server" Text="Previous" OnClick="btnPreviousToView1_Click" />
                    <asp:Button ID="btnNextToView3" runat="server" Text="Next" OnClick="btnNextToView3_Click" />
                </asp:View>

                <!-- View 3: Summary -->
                <asp:View ID="View3" runat="server">
                    <h2>Summary</h2>
                    <div id="summaryDiv" runat="server" style="text-align: left; margin: auto; width: 50%;">
                        <!-- Summary will be populated from code-behind -->
                    </div>
                    <asp:Button ID="btnPreviousToView2" runat="server" Text="Previous" OnClick="btnPreviousToView2_Click" />
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
 
</body>
</html>
