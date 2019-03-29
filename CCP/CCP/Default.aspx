<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CCP.Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Details</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="Script.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
</head>
<body>
<form id="form1" runat="server">
      
<section>
    <div>
        <table class="table">
          <thead class="thead-light">
            <tr>
              <th>Name</th>
              <th>Value</th>
            </tr>
          </thead>
        </table>
    </div>
    <div>
        <table class="table" >
      <tbody>
                <tr id="onWatchListLabel">
                    <td>Note*</td>
                    <td id="note"></td>
                </tr>
                <tr>
                    <td>Customer ID</td>
                    <td id="CustID"></td>
                </tr>
                <tr>
                    <td>Login ID</td>
                    <td id="LoginID"></td>
                </tr>
                <tr>
                    <td>Customer Type</td>
                    <td id="CustType"></td>
                </tr>
                <tr>
                    <td>Brand Name</td>
                    <td id="BrandName"></td>
                </tr>
                <tr>
                    <td>Customer Name</td>
                    <td id="CustomerName"></td>
                </tr>
                
                <tr>
                    <td>Trade Name</td>
                    <td id="TradName"></td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td id="Email"></td>
                </tr>
                <tr>
                    <td>User Name</td>
                    <td id="UserName"></td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td id="Password"></td>
                </tr>
                <tr>
                    <td>Vat No</td>
                    <td id="VAT"></td>
                </tr>
                <tr>
                    <td>Credit Limit</td>
                    <td id="Credit"></td>
                </tr>

                <tr>
                    <td>Payment Term</td>
                    <td id="PaymentTerm"></td>
                </tr>
                <tr>
                    <td>Sales Channel</td>
                    <td id="SalesChannel"></td>
                </tr>
                <tr>
                    <td>Sage Account Ref</td>
                    <td id="SageAccount"></td>
                </tr>
      </tbody>
    </table>
    </div>
</section>
</form>
</body>
</html>