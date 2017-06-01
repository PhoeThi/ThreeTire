<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePersonInfo.aspx.cs" Inherits="PersonalInfoDemoNTire.CreatePersonInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="/Scripts/jquery.js" type="text/javascript"></script>
    <script src="/Scripts/jquery.min.js" type="text/javascript"></script>
    <script src="/Scripts/jquery-ui.js" type="text/javascript"></script>
    <script src="/Scripts/jquery-ui.min.js" type="text/javascript"></script>
    <link href="/Content/jquery-ui.css" rel="stylesheet" />
    <%--<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6/jquery.min.js" type="text/javascript"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js" type="text/javascript"></script>
    <link href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" rel="Stylesheet" type="text/css" />--%>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("[id$=txtBirthday]").datepicker({
                dateFormat:'dd-mm-yy'
            });
        });
        $(function () {
            $("[id$=txtStartDate]").datepicker({
                dateFormat: 'dd-mm-yy'
            });
        });
        $(function () {
            $("[id$=txtEndDate]").datepicker({
                dateFormat: 'dd-mm-yy'
            });
        });
        $(function () {
            $("[id$=txtFromDate]").datepicker({
                dateFormat: 'dd-mm-yy'
            });
        });
        $(function () {
            $("[id$=txtToDate]").datepicker({
                dateFormat: 'dd-mm-yy'
            });
        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:960px; height:900px;  margin:0 auto; background:#e0dada">
        
            <h2 class="formTitle">Add a New Person</h2>
            <br />
            <div class="groupBox" >
                 <fieldset style="width:400px">
                    <legend style="color:green">Basic Information</legend>
                    <table>
                        <tr>
                            <td>Last Name</td>
                            <td> <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox> </td>
                        </tr>
                         <tr>
                            <td>First Name</td>
                            <td> <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox> </td>               
                        </tr>
                        <tr>
                            <td>Gender</td>
                            <td> <asp:TextBox ID="txtGender" runat="server"></asp:TextBox> </td>
                        </tr>
                        <tr>
                            <td>BirthDay</td>
                            <td><asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox> </td>
                        </tr>
                   </table>
                </fieldset>
            </div>

           <div class="groupBox">  
                    <fieldset style="width:400px;">
                        <legend style="color:green">Contact Information</legend>
                        <table>
                            <tr>
                                <td>Phone Number</td>
                                <td> <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox> </td>
                            </tr>
            
                            <tr>
                                <td>Email</td>
                                <td> <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox> </td>
                            </tr>
                        </table>
                    </fieldset> 
            </div>

            <div class="addressbox">
                <fieldset style="width:100%">
                  <legend style="color:green">Address Information</legend>
                    <table>
                       <tr class="tdwidth">
                            <td>Address1</td>
                            <td style="width: 500px"> <asp:TextBox Width="550px" ID="txtAddress1" runat="server"></asp:TextBox> </td>
                        </tr>
            
                        <tr class="tdwidth">
                            <td>Address2</td>
                            <td style="width: 500px"> <asp:TextBox Width="550px" ID="txtAddress2" runat="server"></asp:TextBox> </td>
                        </tr>
                        <tr>
                            <td>City</td>
                            <td style="width: 500px"> <asp:TextBox Width="550px" ID="txtCity" runat="server"></asp:TextBox> </td>
                        </tr>
            
                        <tr>
                            <td>Country</td>
                            <td style="width: 500px ; border:1px;"> <asp:TextBox Width="550px" ID="txtCountry" runat="server"></asp:TextBox> </td>
                        </tr>
                   </table>
                </fieldset>
            </div>
       

            <div class="groupBox1">       
                <fieldset style="width:400px;">
                    <legend style="color:green">Graduated Information</legend>
                    <table>
                        <tr>
                            <td>High School</td>
                            <td> <asp:TextBox ID="txtHighSchool" runat="server"></asp:TextBox> </td>
                        </tr>
            
                        <tr>
                            <td>College</td>
                            <td> <asp:TextBox ID="txtCollege" runat="server"></asp:TextBox> </td>
                        </tr>
                        <tr>
                            <td>Graduated School</td>
                            <td> <asp:TextBox ID="txtGraduatedSchool" runat="server"></asp:TextBox> </td>
                        </tr>
            
                        <tr>
                            <td>Major</td>
                            <td> <asp:TextBox ID="txtMajor" runat="server"></asp:TextBox> </td>
                        </tr>
                        
                    </table>
                    <table style="border-collapse:collapse">
                        <tr>
                            <td>StartDate</td>
                            <td> <asp:TextBox ID="txtStartDate" runat="server" Width ="100px"></asp:TextBox> </td>
                            <td>EndDate</td>
                            <td> <asp:TextBox ID="txtEndDate" runat="server" Width ="100px"></asp:TextBox> </td>
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
                            <td> <asp:TextBox ID="txtRole" runat="server"></asp:TextBox> </td>
                        </tr>
            
                        <tr>
                            <td>Industry</td>
                            <td> <asp:TextBox ID="txtIndustry" runat="server"></asp:TextBox> </td>
                        </tr>
                        <tr>
                            <td>Company</td>
                            <td> <asp:TextBox ID="txtCompany" runat="server"></asp:TextBox> </td>
                        </tr>
            
                        <tr>
                            <td>Contract Type</td>
                            <td> <asp:TextBox ID="txtContractType" runat="server"></asp:TextBox> </td>
                        </tr>
                        
                    </table>
                    <table>
                        <tr>
                            <td>FromDate</td>
                            <td><asp:TextBox ID="txtFromDate" runat="server" Width ="100px"></asp:TextBox> </td>
                            <td>ToDate</td>
                            <td> <asp:TextBox ID="txtToDate" runat="server" Width ="100px"></asp:TextBox> </td>
                        </tr>
                    </table>
                </fieldset>
            </div> 

            
            <br />

            <div class="buttonGroup">             
                    <table style="width:100%;">
                        <tr style="padding:20px;">
                            <td style="text-align:right"><asp:Button ID="btnYES" runat="server" OnClick="btnYES_Click" Text="Save"  Width="130px" Height="40px"  /></td>
                            <td style="text-align:left"><asp:Button ID="btnNO" runat="server" OnClick="btnNO_Click" Text="Cancel"  Width="130px" Height="40px" /></td>
                        </tr>
                    </table>               
            </div>
            <div class="formTitle"></div>
        </div>
    </form>
</body>
</html>
