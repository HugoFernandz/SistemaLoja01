﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Produtos.aspx.cs" Inherits="SistemaLoja01.Page.Produtos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:Table runat="server" ID="TableBusca">
        <asp:TableRow>
            <asp:TableCell>
                    <asp:Label runat="server">Buscar Produtos</asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Nome: </asp:Label>
                <asp:TextBox runat="server" ID="txtBNome"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Tipo Produto: </asp:Label>
                <asp:DropDownList ID="ddlBTipoProduto" runat="server">
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                    <asp:Button runat="server" OnClick="Busca_Click" Text="Buscar"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    <asp:Table runat="server" ID="TableCadastro">
        <asp:TableRow>
            <asp:TableCell>
                    <asp:Label runat="server">Cadastro Produtos</asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Nome: </asp:Label>
                <asp:TextBox runat="server" ID="txtNome"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Preço: </asp:Label>
                <asp:TextBox runat="server" ID="TxtPreco"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Quantidade: </asp:Label>
                <asp:TextBox runat="server" ID="txtQuantidade"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Tipo Produto: </asp:Label>
                <asp:DropDownList ID="ddlTipoProduto" runat="server">
                </asp:DropDownList>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                    <asp:Button runat="server" OnClick="Cadastro_Click" Text="Cadastrar"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:GridView ID="GridViewProdutos" EmptyDataText="Nenhum Registro Localizado" CellPadding="4" AllowPaging="true" PageSize="20"
                    CellSpacing="0" AutoGenerateColumns="false" BorderWidth="1" CssClass="grid" HeaderStyle-BackColor="#D1D2D4" RowStyle-BackColor="#FFFFFF" runat="server">
                    <Columns>
                        <%--                        <asp:TemplateField>
                            <ItemStyle Width="18px" CssClass="text-center" />
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%# Eval("idStatus") %>' ID="labelStatus" Visible="false" />
                                <asp:Label runat="server" Text='<%# Eval("Removido") %>' ID="lblRemovido" Visible="false" />
                                <asp:Label runat="server" Text='<%# Eval("EnumEquivalente") %>' ID="lblenumerador" Visible="false" />
                                <asp:CheckBox ID="CheckBoxStatus" runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>--%>

                        <%--                        <asp:TemplateField>
                            <ItemStyle CssClass="text-center" Width="18px" />
                            <ItemTemplate>
                                <asp:Label ID="lblStatus" runat="server" Text='<%# Eval("Status") %>' Visible="false" />
                                <asp:ImageButton ID="imgStatus" runat="server" CausesValidation="false" ToolTip="Status" />
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                        <asp:BoundField DataField="TipoProduto" HeaderText="Tipo Produto" HeaderStyle-ForeColor="#4C4C4C" SortExpression="tipoproduto" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" HeaderStyle-ForeColor="#4C4C4C" SortExpression="nome" />
                        <asp:BoundField DataField="Preco" HeaderText="Preco" HeaderStyle-ForeColor="#4C4C4C" SortExpression="preco" />
                        <asp:BoundField DataField="quantidade" HeaderText="Quantidade" HeaderStyle-ForeColor="#4C4C4C" SortExpression="quantidade" />
                        <asp:BoundField DataField="Status" HeaderText="Status" HeaderStyle-ForeColor="#4C4C4C" SortExpression="status" />
                        <%--                        <asp:TemplateField HeaderText="Icone">
                            <ItemStyle Width="18px" CssClass="text-center" />
                            <ItemTemplate>
                                <asp:Label runat="server" Text='<%# Eval("CaminhoIcone") %>' ID="lblcaminho" Visible="false" />
                                <asp:ImageButton ID="imgcaminho" runat="server" CausesValidation="false" ToolTip="Status" heigth="70px" Width="70px" OnClick="pagenewstatus_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>--%>
                    </Columns>
                </asp:GridView>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
