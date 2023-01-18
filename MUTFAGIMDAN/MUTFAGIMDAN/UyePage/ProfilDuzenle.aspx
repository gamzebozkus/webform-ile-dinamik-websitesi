<%@ Page Title="" Language="C#" MasterPageFile="~/UyePage/Profil.Master" AutoEventWireup="true" CodeBehind="ProfilDuzenle.aspx.cs" Inherits="MUTFAGIMDAN.ProfilDuzenle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   


  <div class="profile">
    <div style="font-size:13px;" class="content">
        <fieldset>
          <div class="grid-35">
            <label for="avatar" >Profil Fotoğrafı</label>
          </div>
          <div class="grid-65">
            <span class="photo" title="Upload your Avatar!"></span>
              <asp:FileUpload ID="FileUpload1" Cssclass="btn" runat="server" />
          </div>
        </fieldset>
        <fieldset>
          <div class="grid-35">
            <label for="fname">Ad</label>
          </div>
          <div class="grid-65">
       <asp:TextBox ID="TextBoxAd" runat="server"></asp:TextBox>
          </div>
        </fieldset>
        <fieldset>
          <div class="grid-35">
            <label for="lname">Soyad</label>
          </div>
          <div class="grid-65">
              <asp:TextBox ID="TextBoxSoyad" runat="server"></asp:TextBox>
          </div>
        </fieldset>
        <fieldset>
          <div class="grid-35">
            <label for="description">Telefon Numarası(*Gerekli)</label>
          </div>
          <div class="grid-65">
      <asp:TextBox ID="TextBoxTel" runat="server"  TextMode="SingleLine" ></asp:TextBox>
          </div>
        </fieldset>
  <asp:Button ID="ButtonGiris" runat="server" Text="Kaydet" CssClass="info" Style="color: #FFFFFF; background-color: #33CC33; margin-left: 14px;" Width="384px" OnClick="ButtonGiris_Click"  />   
    </div>
  </div>
</asp:Content>
