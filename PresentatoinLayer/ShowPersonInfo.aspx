<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowPersonInfo.aspx.cs" Inherits="PersonalInfoDemoNTire.ShowPersonInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:100%; height:550px;  margin:0 auto; background:#e0dada">
           <h3 class="formTitle">List All People Information </h3>
           <asp:Button ID="btnAddNewPerson" runat="server" OnClick="btnAddNewPerson_Click" Text="AddNewPerson" Width="141px" Height="50px" />
           <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit"
                OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BorderColor="Silver"
                BorderStyle="Solid" BorderWidth="1px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging">
                <FooterStyle BackColor="#507CD1" Font-Bold="false" ForeColor="White" />
                <RowStyle BackColor="#EFF3FB" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="false" ForeColor="#333333" />
                <HeaderStyle BackColor="#e2e2e2" Font-Bold="false" ForeColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="PersonID" Visible="false">
                        <EditItemTemplate>
                            <asp:Label ID="lblID" Enabled="false" runat="server" Text='<%# Eval("PersonID") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" Enabled="false" runat="server" Text='<%# Bind("PersonID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="LastName">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtLastName" runat="server" Text='<%# Bind("LastName") %>' Width="100px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("LastName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="FirstName">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtFirstName" runat="server" Text='<%# Bind("FirstName") %>' Width="100px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("FirstName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Gender">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtGender" runat="server" Text='<%# Bind("Gender") %>' Width="100px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("Gender") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="City">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCity" runat="server" Text='<%# Bind("City") %>' Width="100px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label8" runat="server" Text='<%# Bind("City") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Country">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCountry" runat="server" Text='<%# Bind("Country") %>' Width="100px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label9" runat="server" Text='<%# Bind("Country") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PhoneNumber">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtPhoneNumber" runat="server" Text='<%# Bind("PhoneNumber") %>' Width="100px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label20" runat="server" Text='<%# Bind("PhoneNumber") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtEmail" runat="server" Text='<%# Bind("Email") %>' Width="100px"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label21" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                        </ItemTemplate>
                   </asp:TemplateField>

                    <asp:HyperLinkField Text="Edit" DataNavigateUrlFields="PersonID" DataNavigateUrlFormatString="~/UpdatePersonInfo.aspx?id={0}" />
                    <asp:HyperLinkField Text="Delete" DataNavigateUrlFields="PersonID" DataNavigateUrlFormatString="~/DeletePersonInfo.aspx?id={0}" />
                    <asp:HyperLinkField Text="Show Details" DataNavigateUrlFields="PersonID" DataNavigateUrlFormatString="~/ShowPersonInfo.aspx?id={0}" />
                    
               </Columns>
            </asp:GridView>
        </div>
        <div style="width:100%; height:400px;  margin:0 auto; background:#e0dada">
            <fieldset style="width:97%;  margin-left:1px;">
                <legend style="color:green">Other Information</legend>
                    <div class="groupBox1">       
                        <fieldset style="width:400px;">
                            <legend style="color:green">Graduated Information</legend>
                            <table>
                                <tr>
                                    <td>High School</td>
                                    <td> <asp:TextBox ID="txtHighSchool" runat="server" Text ="" ReadOnly="true"></asp:TextBox> </td>
                                </tr>
            
                                <tr>
                                    <td>College</td>
                                    <td> <asp:TextBox ID="txtCollege" runat="server" Text ="" ReadOnly="true"></asp:TextBox> </td>
                                </tr>
                                <tr>
                                    <td>Graduated School</td>
                                    <td> <asp:TextBox ID="txtGraduatedSchool" runat="server" Text ="" ReadOnly="true"></asp:TextBox> </td>
                                </tr>
            
                                <tr>
                                    <td>Major</td>
                                    <td> <asp:TextBox ID="txtMajor" runat="server" Text ="" ReadOnly="true"></asp:TextBox> </td>
                                </tr>
                        
                            </table>
                            <table style="border-collapse:collapse">
                                <tr>
                                    <td>StartDate</td>
                                    <td> <asp:TextBox ID="txtStartDate" runat="server" Width ="100px" Text ="" ReadOnly="true"></asp:TextBox> </td>
                                    <td>EndDate</td>
                                    <td> <asp:TextBox ID="txtEndDate" runat="server" Width ="100px" Text ="" ReadOnly="true"></asp:TextBox> </td>
                                </tr>
                            </table>
                        </fieldset>
                    </div> 

                    <div class="groupBox1">       
                        <fieldset style="width:400px;">
                            <legend style="color:green">Work Information</legend>
                            <table>
                                <tr>
                                    <td>Role</td>
                                    <td> <asp:TextBox ID="txtRole" runat="server" Text ="" ReadOnly="true"></asp:TextBox> </td>
                                </tr>
            
                                <tr>
                                    <td>Industry</td>
                                    <td> <asp:TextBox ID="txtIndustry" runat="server" Text ="" ReadOnly="true"></asp:TextBox> </td>
                                </tr>
                                <tr>
                                    <td>Company</td>
                                    <td> <asp:TextBox ID="txtCompany" runat="server" Text ="" ReadOnly="true"></asp:TextBox> </td>
                                </tr>
            
                                <tr>
                                    <td>Contract Type</td>
                                    <td> <asp:TextBox ID="txtContractType" runat="server" Text ="" ReadOnly="true"></asp:TextBox> </td>
                                </tr>
                        
                            </table>
                            <table>
                                <tr>
                                    <td>FromDate</td>
                                    <td><asp:TextBox ID="txtFromDate" runat="server" Width ="100px" Text ="" ReadOnly="true"></asp:TextBox> </td>
                                    <td>ToDate</td>
                                    <td> <asp:TextBox ID="txtToDate" runat="server" Width ="100px" Text ="" ReadOnly="true"></asp:TextBox> </td>
                                </tr>
                            </table>
                        </fieldset>
                    </div> 
                    <div style="width:30%; height:200px;float:left;margin-left:3px;padding:10px;">
                        <fieldset style="width:95%">
                          <legend style="color:green">Address Information</legend>
                            <table>
                               <tr class="tdwidth">
                                    <td>Address1</td>
                                    <td style="width: 250px"> <asp:TextBox Width="250px" ID="txtAddress1" runat="server" ReadOnly="true"></asp:TextBox> </td>
                                </tr>
            
                                <tr class="tdwidth">
                                    <td>Address2</td>
                                    <td style="width: 250px"> <asp:TextBox Width="250px" ID="txtAddress2" runat="server" ReadOnly="true"></asp:TextBox> </td>
                                </tr>
                            </table>
                        </fieldset>
                    </div>
               </fieldset>
        </div>
    </form>
</body>
</html> 
