<%@ Page Title="" Language="C#" MasterPageFile="~/KullaniciPage/Kullanici.Master" AutoEventWireup="true" CodeBehind="TarifDetay.aspx.cs" Inherits="MUTFAGIMDAN.TarifDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
       
    <section class="about" id="menu">

        <h1 class="heading" style="padding:5rem;">  </h1>
 <asp:Repeater ID="Repeater1" runat="server">
     <ItemTemplate>
        <div class="row">

            <div class="image">
                <img src="<%#Eval("TarifResim") %>" alt="">
            </div>

            <div class="content">
                <h3><%# Eval("TarifIsim") %></h3>

              <h3 style="font-size:3rem;">Malzemeler:</h3>  <p><%#Eval("TarifMalzeme") %></p>
                <h3 style="font-size:3rem;">Yapılış:</h3><p><%#Eval("TarifYapilis") %></p>
                <div >
    
                </div>
               
            </div>

        </div></ItemTemplate>
</asp:Repeater>
    </section>
        </form>
</asp:Content>
