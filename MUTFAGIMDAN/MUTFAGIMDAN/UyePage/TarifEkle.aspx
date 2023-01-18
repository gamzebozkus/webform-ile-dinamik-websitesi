<%@ Page Title="" Language="C#" MasterPageFile="~/UyePage/Profil.Master" AutoEventWireup="true" CodeBehind="TarifEkle.aspx.cs" Inherits="MUTFAGIMDAN.TarifEkle" %>
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
          
         <asp:Button   ID="ButtonEkle" runat="server" Text="Ekle" CssClass="info"  Style="color: #FFFFFF; background-color: #33CC33; margin-left: 14px;" Width="384px" OnClick="ButtonEkle_Click"  />
 
      <%-- <asp:Label ID="Label1"   runat="server" BackColor="#00CC66" BorderColor="#006600" CssClass="auto-style1" ForeColor="Black" Height="30px" Width="224px"></asp:Label>
        <strong>
        <asp:Button ID="Button1" runat="server" BackColor="White" CssClass="Btn" ForeColor="Black" Height="38px" OnClick="Button1_Click" style="margin-left: 16%; margin-top: 6px" Text="Tamam" Width="258px" />
        </strong>--%>
       
<%--        <asp:Button ID="submitBtn" runat="server" OnClick="Submit" Text="Submit"
                                        Width="90px"  CausesValidation="true"  />
         --%>
        
  
 
    </div>
  </div>
   <%-- <script type="text/javascript">
    document.querySelectorAll("[data-dialog]").forEach(button => {
    button.addEventListener("click", (e) =>{
        document.getElementById(button.dataset.dialog).showModal();
        setTimeout(() => {
            document.getElementById(button.dataset.dialog).close();
        }, (8000))
        const elm = document.getElementById(button.dataset.dialog)
        const clickToClose = function (event) {
            const rect = elm.getBoundingClientRect();
            const isInDialog=(rect.top <= event.clientY && event.clientY <= rect.top + rect.height
              && rect.left <= event.clientX && event.clientX <= rect.left + rect.width);
            if (!isInDialog) {
                elm.close();
            }
        }
        elm.addEventListener('click', clickToClose);
        elm.addEventListener('close', () => {
            elm.removeEventListener("click", clickToClose , false);
          });
    })
})
</script>--%>
    <%--<asp:Panel ID="success" runat="server" Visible="False">
   <script>
  <% int Uyeid = Convert.ToInt32(Request.QueryString["Uyeid"].ToString());%>
        swal({
            title: "Tarif Başarıyla Eklendi",
            text: "",
            icon: "success",
            button: "OK",
        }).then(value)=> {<%Response.Redirect("/UyePage/Tariflerim.aspx?Uyeid=" + Uyeid.ToString());%> });
    </script>
</asp:Panel>--%>
    <%--<script>
        function Confirm() {
            if (Page_ClientValidate()) {
                var confirm_value = document.createElement("INPUT");
                confirm_value.type = "hidden";
                confirm_value.name = "confirm_value";
                if (confirm("Data has been Added. Do you wish to Continue ?")) {
                    confirm_value.value = "Yes";
                }
                //else {
                //    confirm_value.value = "No";
                //}
                document.forms[0].appendChild(confirm_value);
            }
        }
    </script>--%>
      <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>

</asp:Content>
