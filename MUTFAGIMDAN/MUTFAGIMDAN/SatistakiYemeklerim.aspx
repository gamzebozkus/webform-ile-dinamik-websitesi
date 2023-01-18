<%@ Page Title="" Language="C#" MasterPageFile="~/UyePage/Profil.Master" AutoEventWireup="true" CodeBehind="SatistakiYemeklerim.aspx.cs" Inherits="MUTFAGIMDAN.SatistakiYemeklerim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-left:50px; padding-top:80px;">
   <div style="padding-left:3rem;" class="container table-responsive py-5"> 
<table class="table table-bordered table-hover">
  <thead style="background-color:darkslategrey;" class="thead-dark">
    <tr>
      
      <th scope="col" style="background-color:#89f267;font-size:15px;">
          <asp:Label ID="Label1" runat="server"  Text="TARİF ADI"></asp:Label>
      </th> 
         <th scope="col" style="background-color:#89f267;font-size:15px;">
          <asp:Label ID="Label3"  runat="server" Text="KATEGORİ ADI"></asp:Label>
      </th> 
      <th style="background-color:#89f267;font-size:15px;" scope="col">Düzenle</th>
      <th style="background-color:#89f267; font-size:15px;" scope="col">Sil</th>
    </tr>
  </thead>
     <asp:DataList ID="DataList1" runat="server"> <ItemTemplate>
  <tbody>
     
       
    <tr >
  
      <td style="padding-left:0px; font-size:18px;" scope="col">
          <asp:Label ID="Label2" runat="server" Text='<%# Eval("YemekIsim")%>'></asp:Label>
      </td>
   
       <td style="padding-left:350px; font-size:18px;"><asp:Label ID="Label4" runat="server" Text='<%# Eval("KategoriIsim")%>'></asp:Label></td>
        
       <td style="padding-left:480px;  ">
           <br />
           <a href="/YapSatDuzenle.aspx?Uyeid=<%#Eval("Uyeid")%>&&Yemekid=<%#Eval("Yemekid")%>"><asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/images/update.png" Width="30px" /></a> 
         <%--  <asp:Button style=" font-size:15px; width:70px; "  ID="Button2" runat="server" Text="Düzenle"  />--%>
       
       </td>
        
       <td style="padding-left:200px; ">
          <%-- <asp:Button style=" font-size:15px; width:60px; box-shadow:0 0 0 1px red;" ID="Button1" runat="server" Text="Sil"  />--%>
             <a href="/SatistakiYemeklerim.aspx?Uyeid=<%#Eval("Uyeid") %>&&Yemekid=<%#Eval("Yemekid") %>&islem=sil"> <asp:Image ID="Image1" runat="server" Height="30px" ImageUrl="~/images/delete.png" Width="30px" /></a>
       </td>
       
    </tr>

    
      
    

  </tbody></ItemTemplate></asp:DataList>
</table>
</div></div>
</asp:Content>
