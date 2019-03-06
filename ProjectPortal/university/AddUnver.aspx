<%@ Page Title="" Language="C#" MasterPageFile="~/main1.Master" AutoEventWireup="true" CodeBehind="AddUnver.aspx.cs" Inherits="ProjectPortal.university.AddUnver" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <style>
        .upload-zone {
            display: -webkit-flex;
            display: -ms-flexbox;
            display: flex;
            height: 110px;
            background: #f2f7ff;
            border: 1px #b5b5b5 dashed;
            position: relative;
            overflow: hidden;
        }
    </style>

    <div class="project-clean">

        <section method="post">

            <h2 class="text-center">ادخل اسم المشروع </h2>

            <%--1 Project Name --%>
            <div class="form-group" dir="rtl">

                <small class="form-text text-secondary">اسم المشروع.</small>

                <asp:TextBox ID="txtProjName" CssClass="form-control" runat="server"></asp:TextBox>

            </div>


            <%--2 الجهة المقترحة  --%>
            <div class="form-group" dir="rtl">
                <small class="form-text text-secondary">الجهة المقترحة.</small>
                <asp:DropDownList ID="txtSuggestSide" CssClass="form-control" runat="server" Enabled="True"></asp:DropDownList>

            </div>


            <%--3 Project Idea --%>
            <div class="form-group" dir="rtl">
                <small class="form-text text-secondary">فكرة المشروع المشروع .</small>

                <asp:TextBox ID="txtProjIdea" CssClass="form-control" runat="server" TextMode="MultiLine" Rows="14"></asp:TextBox>

            </div>
            <%--4 Project Details --%>
            <div class="form-group" dir="rtl">
                <small class="form-text text-secondary">تفاصيل المشروع .</small>

                <asp:TextBox ID="txtProjDetails" CssClass="form-control" runat="server" TextMode="MultiLine" Rows="14"></asp:TextBox>

            </div>


            <%--5 Standers --%>
            <div class="form-group" dir="rtl">
                <small class="form-text text-secondary">المعايير المطلوبة.</small>

                <asp:DropDownList ID="DropRequirStandar" CssClass="form-control" runat="server"></asp:DropDownList>


            </div>


            <%--6 Project Duration --%>
            <div class="form-group" dir="rtl">
                <small class="form-text text-secondary">نوع السيارة.</small>

                <asp:TextBox ID="txtRequirCompletPer" CssClass="form-control" runat="server"></asp:TextBox>

            </div>

            <div class="form-group">

                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <%--    <form id="fileupload" class="">
            <div class="upload-zone">
                <input type="file" class="custom-file-input" name="files[]" multiple="">
                <span><span>أضف صور</span></span>
            </div>

            <div class="upload-stat"><span><span id="pic_counter">10</span> صور</span></div>

            <div class="upload-files row ui-sortable"></div>

            <div class="fileupload-buttonbar hide">
                <input id="start_upload" type="button" class="start disabled" value="تحميل" data-default-value="تحميل" disabled="disabled">
            </div>
        </form>--%>
            </div>
            <%-- inserting button --%>
            <div class="form-group">

                <asp:Button ID="btnbrand" CssClass="btn btn-primary" runat="server" Text="تأكيد" OnClick="btnbrand_Click" />

            </div>
        </section>


    </div>

</asp:Content>
