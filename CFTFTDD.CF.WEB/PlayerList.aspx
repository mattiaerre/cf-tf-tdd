<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayerList.aspx.cs" Inherits="CFTFTDD.CF.WEB.PlayerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
  <script src="Scripts/jquery-1.10.2.js"></script>
  <link href="Content/bootstrap.css" rel="stylesheet" />
  <script src="Scripts/bootstrap.js"></script>
</head>
<body>
  <form id="form1" runat="server">
    <div class="container">
      <div class="row col-xs-12">
        <h1>Players</h1>
      </div>
      <div class="row col-xs-4">
        <table class="table table-bordered">
          <asp:Repeater ID="rpPlayers" runat="server">
            <HeaderTemplate>
              <thead>
                <tr>
                  <th>First Name</th>
                  <th>Last Name</th>
                  <%--<th>Shirt Number</th>--%>
                </tr>
              </thead>
            </HeaderTemplate>
            <ItemTemplate>
              <tr>
                <td>
                  <asp:Label runat="server" ID="lblFirstName" Text='<%# Eval("FirstName") %>' /></td>
                <td>
                  <asp:Label runat="server" ID="lblLastName" Text='<%# Eval("LastName") %>' /></td>
                <%--<td>
                  <asp:Label runat="server" ID="lblShirtNumber" Text='<%# Eval("ShirtNumber") %>' /></td>--%>
              </tr>
            </ItemTemplate>
          </asp:Repeater>
        </table>
      </div>
    </div>
  </form>
</body>
</html>
