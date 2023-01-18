<%@ Page Title="" Language="C#" MasterPageFile="~/UyePage/Profil.Master" AutoEventWireup="true" CodeBehind="tarifguncelle.aspx.cs" Inherits="MUTFAGIMDAN.tarifguncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>button{
    border-radius: 5px;
    border: 1px solid transparent;
    padding: 10px 5px;
    text-transform: uppercase;
    cursor: pointer;
}

button.accept{
    background-color: #16a34a;
    color: white;
}

button.accept:hover{
    background-color: #22c55e;
    color: white;
}

button.cancel{
    background-color: #e11d48;
    color: white;
}

button.cancel:hover{
    background-color: #f43f5e;
    color: white;
}

.center{
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
}


dialog{
    border: 5px solid green;
    border-radius: 5px;
    pointer-events: none;
}

#dialog-accept[open] {
    animation: showBottomRight 1s ease normal;
    pointer-events: all;
}

#dialog-cancel[open] {
    animation: showTopRight 1s ease normal;
    pointer-events: all;
}



@keyframes showBottomRight{
    from {
        transform: translateY(50vw) translateX(50vh);
    }
    to {
        transform: translateY(0%) translateX(0);
    }
}

@keyframes showTopRight{
    from {
        transform: translateY(-50vw) translateX(50vh);
    }
    to {
        transform: translateY(0%) translateX(0);
    }
}
        .auto-style1 {
            margin-left: 77px;
        }
    </style>
         <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="profile">
    <div style="font-size:13px;" class="content">
    
   
        <!-- Photo -->
        <fieldset>
          <div class="grid-35">
            <label for="avatar" >Tarif Fotoğrafı</label>
          </div>
          <div style="margin-top:30px;" class="grid-65">

              <asp:FileUpload ID="TarifFoto" runat="server" />
          </div>
        </fieldset>
           <fieldset>
          <div class="grid-35">
            <label for="fname">Kategori Seç:</label>
          </div>
          <div class="grid-65">
              <asp:DropDownList ID="DropDownListKategori" runat="server"></asp:DropDownList>
          </div>
        </fieldset>
        <fieldset>
          <div class="grid-35">
            <label for="fname">Yemek Adı:</label>
          </div>
          <div class="grid-65">
              <asp:TextBox ID="TxtAd" runat="server"></asp:TextBox>
          </div>
        </fieldset>
        <fieldset>
          <div class="grid-35">
            <label for="lname">Yemek Malzemeler:</label>
          </div>
          <div class="grid-65">
              <asp:TextBox ID="TxtMalzeme" TextMode="MultiLine" runat="server"></asp:TextBox>
          </div>
        </fieldset>
        <!-- Description about User -->
        <fieldset>
          <div class="grid-35">
            <label for="description">Yapılış:</label>
          </div>
          <div class="grid-65">
              <asp:TextBox ID="TxtYapilis" TextMode="MultiLine" runat="server"></asp:TextBox>
          </div>
        </fieldset>
          
         <asp:Button   ID="ButtonGuncelle" runat="server" Text="Güncelle" CssClass="info"  Style="color: #FFFFFF; background-color: #33CC33; margin-left: 14px;" Width="384px" OnClick="ButtonGuncelle_Click"  />
    </div>
  </div>
  <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    </asp:Content>
