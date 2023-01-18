<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayitEkrani.aspx.cs" Inherits="MUTFAGIMDAN.KayitEkrani" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml"  lang="tr">
<head runat="server">
    <title></title>
    <link href="css/giris.css" rel="stylesheet" />
      <link rel="stylesheet" href="https://unpkg.com/swiper/swiper-bundle.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css"/> 
    <link href="../css/style.css" rel="stylesheet" />
   <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css"/>
		<link href='https://unpkg.com/boxicons@2.1.2/css/boxicons.min.css' rel='stylesheet'/>
		<script src="https://code.jquery.com/jquery-3.4.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">

        <div class="login-page">
            <div class="form">
                  <a  class="logo"><i class="fas fa-utensils" style="font-size:30px">MUTFAĞIMDAN</i></a>
              
                <asp:TextBox class="username" placeholder="Ad" ID="TextAd" runat="server"></asp:TextBox>
                <asp:TextBox placeholder="Soyad" class="username" ID="TextSoyad" runat="server"></asp:TextBox>
                <asp:TextBox  placeholder="Mail" class="username" ID="TextMail" runat="server"></asp:TextBox>
                <asp:TextBox  placeholder="Telefon Numarası" class="username" ID="TextTel" runat="server"></asp:TextBox>
                <asp:TextBox type="password" placeholder="Şifre" class="password" ID="TextSifre" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonKayit" runat="server" Text="Kayıt Ol" CssClass="info" Style="color: #FFFFFF; background-color: #33CC33" OnClick="ButtonKayit_Click" />
                <p class="message">Hesabın var mı? <a href="GirisEkrani.aspx">Giriş Yap</a></p>
            </div>
        </div>

    </form>

</body>
</html>
