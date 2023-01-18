<%@ Page Title="" Language="C#" MasterPageFile="~/KullaniciPage/Kullanici.Master" AutoEventWireup="true" CodeBehind="Tarifler.aspx.cs" Inherits="MUTFAGIMDAN.Tarifler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form runat="server">
    <section class="menu" id="menu">
        <br />
        <h3 class="sub-heading"> our dishes </h3>
        <h1 class="heading" style="padding:2rem;"> BUGÜN NE YAPSAK?</h1>
        <div style="padding:2rem;">  <nav class="navbar">
 <a style="background-color:white; color:#27ae60; font-weight:bold; text-align:left;font-size:2rem;" >Şehir Filtrele &nbsp;&nbsp; 
     <asp:DropDownList ID="DropDownkat" AutoPostBack="True"  runat="server" DataSourceID="SqlDataSource2" DataTextField="KategoriIsim"  OnSelectedIndexChanged="DropDownkat_SelectedIndexChanged" DataValueField="Kategoriid"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MutfagimdanConnectionString %>" SelectCommand="SELECT [KategoriIsim], [Kategoriid] FROM [Tbl_Kategoriler]">
                        
                    </asp:SqlDataSource></a>
    </nav></div>
        <asp:Repeater ID="Repeater1" runat="server">
<ItemTemplate>
         <div class="box-container" style="display:inline-grid;">

            <div class="box" style="margin:1rem; width:350px;">
                <div class="image">
                    <img src="<%#Eval("TarifResim") %>" alt="">
               <%--  <a href="/Favoriler.aspx?Uyeid=<%#Eval("Uyeid") %>" ID="favori" runat="server" ></a>--%>
                   
                </div>
                <div class="avatar-profil"><a href=#> <img src="<%#Eval("UyeResim") %>" style="width:40px; height:40px; border-radius:50%;margin-left:25px; margin-bottom:-7px; cursor:pointer; " /><span style="font-size:1.7rem; color:black; margin-bottom:15px;font-weight:bold; font-style:italic; font-family:'Nunito', sans-serif"><%#Eval("UyeAd")%> <%#Eval("UyeSoyad") %></span></a>

                </div>
           
                <div class="content">
                   <%-- <div class="stars">
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star-half-alt"></i>
                    </div>--%>
                    <h3><%#Eval("TarifIsim") %></h3>
                    <p><%#Eval("TarifMalzeme") %></p>
                  <%--  <a href="/KullaniciPage/TarifDetay.aspx=" class="btn">Tarif Detay</a>
                    --%>
                  <a class="btn" href="TarifDetay.aspx?Uyeid=<%#Eval("Uyeid")%>&&Tarifid=<%#Eval("Tarifid") %>">Tarif Detay</a>
                </div>
            </div>
            </div></ItemTemplate></asp:Repeater>
        </section>
         </form>
</asp:Content>
