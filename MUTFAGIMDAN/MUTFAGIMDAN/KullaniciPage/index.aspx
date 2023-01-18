<%@ Page Title="" Language="C#" MasterPageFile="~/KullaniciPage/Kullanici.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MUTFAGIMDAN.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- home section starts  -->
 <form runat="server">
    <section class="home" id="home">

        <div class="swiper-container home-slider">

            <div class="swiper-wrapper wrapper">

                <div class="swiper-slide slide">
                    <div class="content">
                       
                        <h3>Evinde Yemek Yapmaya vakit Bulamayanlar</h3>
                        
                       
                    </div>
                    <div class="image">
                        <img src="/images/home-img-1.png" alt="">
                    </div>
                </div>

                <div class="swiper-slide slide">
                    <div class="content">
                     
                        <h3>Yemek Yapmayı Sevmeyenler</h3>
                       
                    </div>
                    <div class="image">
                        <img src="/images/home-img-2.png" alt="">
                    </div>
                </div>

                <div class="swiper-slide slide">
                    <div class="content">
                        
                        <h3>Sizin Yerinize Mutfağımdan Aşçıları Yapar</h3>
                      
                    </div>
                    <div class="image">
                        <img src="/images/home-img-3.png" alt="">
                    </div>
                </div>

            </div>

            <div style="bottom:10%;" class="swiper-pagination"></div>

        </div>

    </section>

    <!-- home section ends -->
    <!-- menu section starts  -->
   
    <section class="menu" id="menu">
<div>
    <nav class="navbar">
 <a style="background-color:white; color:#27ae60; font-weight:bold; text-align:left;font-size:2rem;" >Şehir Filtrele &nbsp;&nbsp; 
     <asp:DropDownList ID="DropDownil" AutoPostBack="True"  runat="server" DataSourceID="SqlDataSource1" DataTextField="sehir" DataValueField="sehirid"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MutfagimdanConnectionString %>" SelectCommand="SELECT [sehir], [sehirid] FROM [iller]"></asp:SqlDataSource></a>
    <a  style=" text-align: justify; background-color:white; color:#27ae60; font-weight:bold;  font-size:2rem;">İlçe Filtrele<asp:DropDownList OnSelectedIndexChanged="DropDownilce_SelectedIndexChanged" ID="DropDownilce" AutoPostBack="True" runat="server" DataSourceID="SqlDataSource2" DataTextField="ilce" DataValueField="id"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MutfagimdanConnectionString %>" SelectCommand="SELECT * FROM [ilceler] WHERE ([sehirid] = @sehirid)" >
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownil" Name="sehirid" PropertyName="SelectedValue" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>  </a></nav>
       <div><h1 class="heading">Hadi Yemek Sipariş Edelim</h1></div>
    <asp:Repeater ID="Repeater1" runat="server"><ItemTemplate>
        <div class="box-container" style="display:inline-grid; padding:5px;">

            <div class="box" style="width:350px;">
                <div class="image">
                    <img src="/images/Test.png" alt="">
                   
                </div>
                <div class="avatar-profil"><a href=#> <img src="<%#Eval("UyeResim") %>" style="width:40px; height:40px; border-radius:50%;margin-left:25px; margin-bottom:-7px; cursor:pointer; " /><span style="font-size:1.7rem; margin-bottom:15px;font-weight:bold; font-style:italic; font-family:'Nunito', sans-serif"><%#Eval("UyeAd") %> <%#Eval("UyeSoyad") %></span></a></div>
          
                <div class="content">
                   <%-- <div class="stars">
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star"></i>
                        <i class="fas fa-star-half-alt"></i>
                    </div>--%>
                    <h3><%#Eval("YemekIsim") %></h3>
                    <p><%#Eval("YemekAciklama") %></p>
                    <a href="https://wa.me/9<%#Eval("UteTel") %>" target="_blank" class="btn">Mesaj At</a>
                    <span class="price"><%#Eval("YemekFiyat") %>₺</span>
                </div>
            </div>


          
</div></ItemTemplate></asp:Repeater>
   </div> </section>
     </form>
    <!-- menu section ends -->
    
</asp:Content>
