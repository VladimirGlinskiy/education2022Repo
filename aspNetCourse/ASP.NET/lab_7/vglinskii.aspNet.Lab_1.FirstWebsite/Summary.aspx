<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="vglinskii.aspNet.Lab_1.FirstWebsite.Summary" MasterPageFile="~/Site.Master" %>


<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div>
            <h2>Приглашения</h2>
            <h3>Выступающие с докладом:</h3>
            <table>
                <thread>
                    <tr>
                        <th>Имя</th>
                        <th>Email</th>
                        <th>Телефон</th>
                    </tr>
                </thread>
                <tbody>
    <%var yesData = vglinskii.aspNet.Lab_1.FirstWebsite.ResponseRepository.GetRepository().GetAllResponses().Where(r => r.WillAttend.Value);
    foreach (var response in yesData) {
        string htmlString =
                String.Format(
                    "<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td></tr>", response.Name, response.Email, response.Phone, response.Rdata);
        Response.Write(htmlString);
    }
        %>
        </tbody>
    </table>    
</div>

</asp:Content>

