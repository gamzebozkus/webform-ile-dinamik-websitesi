<%@ Page Title="" Language="C#" MasterPageFile="~/UyePage/Profil.Master" AutoEventWireup="true" CodeBehind="YapSatDuzenle.aspx.cs" Inherits="MUTFAGIMDAN.YapSatDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
         <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="profile">
        <div style="font-size: 13px;" class="content">


            <fieldset>
                <div class="grid-35">
                  <label for="fname">Kategori Seç:</label>
                </div>
                <div class="grid-65">
                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                </div>
            </fieldset>
            <fieldset>
                <div class="grid-35">
                    <label for="fname">Yemek Ad</label>
                </div>
                <div class="grid-65">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
            </fieldset>
            <fieldset>
                <div class="grid-35">
                    <label for="fname">Yemek Açıklama</label>
                </div>
                <div class="grid-65">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </div>
            </fieldset>
            <fieldset>
                <div class="grid-35">
                    <label for="fname">Yemek Fiyat</label>
                </div>
                <div class="grid-65">
                    <asp:TextBox ID="TextBox3" style="width: 67%;" runat="server"></asp:TextBox>
                   
                    <i class="fa-solid fa-turkish-lira-sign"></i>
                </div>
            </fieldset>
          <%--  <fieldset>
                <div class="grid-35">
                    <label for="">Yemek Fotoğrafı:</label>
                </div>
                <div style="margin-top: 0px;" class="grid-65">

                    <asp:FileUpload ID="TarifFoto" runat="server" />
                </div>
            </fieldset>--%>

            <fieldset>
                <div class="grid-35">
                    <label for="fname">Şehir Seç:</label>
                </div>
                <div class="grid-65">
                    <asp:DropDownList ID="DropDownil" AutoPostBack="True"  runat="server" DataSourceID="SqlDataSource1" DataTextField="sehir" DataValueField="sehirid"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MutfagimdanConnectionString %>" SelectCommand="SELECT [sehir], [sehirid] FROM [iller]"></asp:SqlDataSource>
                </div>
            </fieldset>
            <fieldset>
                <div class="grid-35">
                   <label for="fname">İlçe Seç:</label>
                </div>
                <div class="grid-65">
                    <asp:DropDownList ID="DropDownilce" AutoPostBack="True" runat="server" DataSourceID="SqlDataSource2" DataTextField="ilce" DataValueField="id"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MutfagimdanConnectionString %>" SelectCommand="SELECT * FROM [ilceler] WHERE ([sehirid] = @sehirid)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownil" Name="sehirid" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </div>
            </fieldset>
            <asp:Button ID="ButtonGuncelle" runat="server" Text="Güncelle" CssClass="info" Style="color: #FFFFFF; background-color: #33CC33; margin-left: 14px;" Width="384px" OnClick="ButtonGuncelle_Click" />
            
        </div>
    </div>
</asp:Content>
