<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="ProjectPortal.university.SignUp" %>

<!DOCTYPE html>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<meta http-equiv="X-UA-Compatible" content="ie=edge">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title>تسجيل حساب جديد</title>
    <link href="../assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../assets2/css/style.css" rel="stylesheet" />
    
</head>
<body>
    <div class="main">

        <div class="container">
            <form id="form1" runat="server" method="post">

                <div class="appointment-form" id="appointment-form" dir="rtl">
                    <h2>انشاء حساب جامعة </h2>
                    <div class="form-group-1">

                        <%-- اسم الجامعة  --%>

                        <asp:TextBox ID="txtUnivName" placeholder="اسم الجامعة" runat="server"></asp:TextBox>

                        <%-- نوع الجامعة --%>

                        <asp:DropDownList ID="DropUnvertype" CssClass="select-list custom-select" placeholder="نوع الجامعة" runat="server" AutoPostBack="True">
                                                   
                        </asp:DropDownList>

                        <%-- رقم التواصل الاول --%>

                        <asp:TextBox ID="txtUnivFphone" TextMode="Number" CssClass="" placeholder="هاتف(1)" runat="server"></asp:TextBox>

                        <%--رقم التواصل الثاني--%>

                        <asp:TextBox ID="txtUnivSphone" TextMode="Number" placeholder="هاتف(2)" runat="server"></asp:TextBox>

                        <%-- الاسم الشخصي --%>

                        <asp:TextBox ID="txtUnivSpokman" placeholder="الاسم" runat="server"></asp:TextBox>

                        <%-- اسم المستخدم --%>

                        <asp:TextBox ID="txtUserName" placeholder="اسم المستخدم" runat="server"></asp:TextBox>

                       <%-- كلمة المرور --%>

                        <asp:TextBox ID="txtPassowrd" placeholder="كلمة المرور" runat="server"></asp:TextBox>

                        <%-- البريد الالكتروني --%>

                        <asp:TextBox ID="txtEmail" TextMode="Email" placeholder="البريد الالكتروني" runat="server"></asp:TextBox>
                        
                        <%-- رقم الهاتف --%>

                        <asp:TextBox ID="txtUnivSpPhone" placeholder="الهاتف الشخصي" runat="server"></asp:TextBox>
                        
                        <asp:TextBox ID="txtComercRegistNo" placeholder="رقم السجل التجاري" runat="server"></asp:TextBox>


                        <%--<input type="email" name="email" id="email" placeholder="Email" required />--%>

                        <%--  <input type="number" name="phone_number" id="phone_number" placeholder="Phone number" required />--%>
                    <%--    <div class="select-list">
                            <select name="course_type" id="course_type">
                                <option selected value="">Course Type</option>
                                <option value="society">Society</option>
                                <option value="language">Language</option>
                            </select>
                        </div>--%>
                    </div>
                    <asp:Label ID="feedback" runat="server" Text="Label"></asp:Label>
                    <div class="form-submit" dir="ltr">
                        <asp:Button ID="Submit" CssClass="submit" runat="server" Text="تأكيد " OnClick="Submit_Click" />

                    </div>
                </div>
                <script src="../assets2/vendor/jquery/jquery.min.js"></script>
            
            </form>
        </div>
    </div>

</body>
</html>
