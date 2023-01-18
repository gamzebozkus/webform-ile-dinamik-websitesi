<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GirisEkrani.aspx.cs" Inherits="MUTFAGIMDAN.GirisEkrani" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-page">
            <div class="form">
                  <a  class="logo"><i class="fas fa-utensils" style="font-size:30px;margin-bottom:20px;">MUTFAĞIMDAN</i></a>
                <asp:TextBox placeholder="Mail" class="username" ID="TextMail" runat="server"></asp:TextBox>
                <asp:TextBox type="password" placeholder="Şifre" class="password" ID="TextSifre" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonGiris" runat="server" Text="Giriş" CssClass="info" Style="color: #FFFFFF; background-color: #33CC33" OnClick="ButtonGiris_Click" />
                
                <p class="message">Kayıtlı Değil misiniz? <a href="KayitEkrani.aspx">Hesap Oluşturun</a></p>
            </div>
        </div>

    </form>
</body>
</html>
