<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DDLEstadosCidades.aspx.cs" Inherits="DDLEstadosCidades.DDLEstadosCidades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DropDownList de Estados e Cidades</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
</head>
<body>
    <div class="container">
        <div class="col-md-12">
            <form id="frmDDLs" runat="server">
                <div class="form-row display-4">                    
                    <div class="form-group col-md-6">
                        <label for="ddlEstado">Estado</label>
                        <asp:DropDownList ID="ddlEstado" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlEstado_SelectedIndexChanged">
                            <asp:ListItem Text="Selecione" />
                        </asp:DropDownList>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="ddlCidade">Cidade</label>
                        <asp:DropDownList ID="ddlCidade" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlCidade_SelectedIndexChanged">
                            <asp:ListItem Text="Selecione" />
                        </asp:DropDownList>
                    </div>
                </div>
                <asp:Label ID="lblSelecaoEstadoCidade" style="font-size: 25px;" runat="server"></asp:Label>
            </form>
        </div>
    </div>
</body>
</html>
