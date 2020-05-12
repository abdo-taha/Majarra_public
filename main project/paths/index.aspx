<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="paths.index" %>

<!DOCTYPE html>
<html dir="rtl" lang="ar">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

	<!-- Bootstrap CSS -->
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"
		integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">

    <script src="Scripts/script.js"></script>
    <script src="Scripts/jquery-3.4.1.js"></script>


	<!-- Material Icons CSS-->
	<link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">

	<!-- Majarra CSS -->
	<link rel="stylesheet" href="css/style.css">
    <link href="Content/style.css" rel="stylesheet" />
	<!-- Tab title and icon -->
	<title>مجرة | الرئيسية</title>
	<link rel="icon" href="images/bg-sm.jpg" type="imag/icon type">
</head>
<body>
    <form id="Home" runat="server">
        
	<nav class="navbar navbar-expand-lg ">

		<a class="navbar-brand" id="majara-logo" href="index.aspx">مجرة</a>

		<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="		#navbarSupportedContent"
			aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
			<span class="navbar-toggler-icon"></span>
		</button>

		<div class="collapse navbar-collapse" id="navbarSupportedContent">

			<ul class="navbar-nav">
				<li class="nav-item active">
					<a class="nav-link" href="#">تصفح التقنيات<span class="sr-only">(current)</span></a>
				</li>

				<li class="nav-item">
					<a class="nav-link" href="#">مسارات التعلم</a>
				</li>
				<li class="nav-item">
					<a class="nav-link" href="#">المجتمع </a>
				</li>
			</ul>

			<ul class="navbar-nav mr-auto align-items-lg-center">

				<li class="nav-item">
					<a class="nav-link" href="#">
						<i class="material-icons text-icon">search</i>
						بحث
					</a>
				</li>

				<li class="nav-item" id="sign_up_link" runat="server">
					<a class="nav-link" href="#register-modal" data-toggle="modal">
						<i class="material-icons text-icon">person_outline</i>
						تسجيل
					</a>
				</li>
				

				<li class="nav-item" id="login_link" runat="server">
					<a class="nav-link" href="#login-modal" data-toggle="modal">
						<i class="material-icons text-icon">lock_outline</i>
						دخول
					</a>
				</li>
				<li class="nav-item" id="profile" runat="server">
					<a class="nav-link" runat ="server"  id ="profile_name" style="color:white;" href="#">
						
					</a>
				</li>
				<li class="nav-item" id="sign_out_link" runat="server">
					<a class="nav-link" runat ="server" OnServerClick="sign_out_click" >
						
						تسجيل خروج
					</a>
				</li>
				<li class="nav-item">
					<a class="nav-link navbar-btn" href="#login-modal" data-toggle="modal">
						<i class="material-icons text-icon">add</i>
						اقترح مصدرًا
					</a>
				</li>

			</ul>
		</div>
	</nav>

	<!-- Header -->
	<header class="header-lg container-fluid">
		<div class="row no-gutters justify-content-center">
			<div class="col-12 col-md-6 text-center">
				<h1 class="header-title">
					مجرة ... مصادر و مسارات متكاملة <br>لتتعلم ما تحب
				</h1>
				<div class="header-search">
					<input class="form-control" type="search" name="navsearch" placeholder="ماذا تحب أن تتعلم ؟">
					<button id="searchcontrol" class="btn" type="button" name="">
						<span class="material-icons">search</span>
					</button>
				</div>
				<div class="most-searched">
					<h6>الأكثر بحثًا:</h6>
					<ul>
						<li><a href="#">تطوير الويب</a></li>
						<li><a href="#">فوتوتشوب</a></li>
						<li><a href="#">الذكاء الاصطناعي</a></li>
						<li><a href="#">تصميم تجربة المستخدم</a></li>
						<li><a href="#">التصوير</a></li>
					</ul>
				</div>
			</div>
		</div>
	</header>

	<!-- Courses Section -->
	<!-- Courses Section -->
    <section id="tools-section" class="container">
        <div class="row">
            <div class="col text-center">
                <h4 class="section-title">الأدوات و التقنيات</h4>


                <svg id="showbutton" class="bi bi-caret-right-fill" width="1em" height="1em" viewBox="0 0 16 16" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                    <path d="M12.14 8.753l-5.482 4.796c-.646.566-1.658.106-1.658-.753V3.204a1 1 0 011.659-.753l5.48 4.796a1 1 0 010 1.506z"/>
                  </svg>

                <svg id="previous" class="bi bi-caret-left-fill" width="1em" height="1em" viewBox="0 0 16 16" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                    <path d="M3.86 8.753l5.482 4.796c.646.566 1.658.106 1.658-.753V3.204a1 1 0 00-1.659-.753l-5.48 4.796a1 1 0 000 1.506z"/>
                  </svg>

                <!--<ul id="courses" style="list-style-type:none;"></ul>-->
                <div class="container">
                    <div class="row" id="courses">
                    </div>
                </div>
            </div>

	 <!-- Courses Section -->
    <section id="tools-section" class="container">
        <div class="row">
            <div class="col text-center">
                <h4 class="section-title">المسارات التعليمية</h4>


                <svg id="showbutton2" class="bi bi-caret-right-fill" width="1em" height="1em" viewBox="0 0 16 16" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                    <path d="M12.14 8.753l-5.482 4.796c-.646.566-1.658.106-1.658-.753V3.204a1 1 0 011.659-.753l5.48 4.796a1 1 0 010 1.506z"/>
                  </svg>

                <svg id="previous2" class="bi bi-caret-left-fill" width="1em" height="1em" viewBox="0 0 16 16" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                    <path d="M3.86 8.753l5.482 4.796c.646.566 1.658.106 1.658-.753V3.204a1 1 0 00-1.659-.753l-5.48 4.796a1 1 0 000 1.506z"/>
                  </svg>

                <!--<ul id="courses" style="list-style-type:none;"></ul>-->
                <div class="container">
                    <div class="row" id="paths">
                    </div>
                </div>
            </div>
	</section>

	<footer class="container">
		<div class="footer-content">
			<div class="row align-items-center">
				<div class="col-12 col-md-6">
					<a href="#" class="footer-logo">مجرة</a>
					<ul class="footer-list mb-3 mb-md-0">
						<li>
							<a href="#">عن مجرة</a>
						</li>
						<li>
							<a href="#">سياسة الخصوصية</a>
						</li>
						<li>
							<a href="#">شروط الاستخدام</a>
						</li>
						<li>
							<a href="#">تواصل معنا</a>
						</li>
					</ul>
				</div>
				<div class="col-12 col-md-6 text-right text-md-left">
					صنع ب <span class="material-icons text-icon m-0" style="color: #EF5350;">favorite</span> في طنطا
				</div>
			</div>
			<div class="row">
				<div class="col">
					<p class="credits">
						© المحتوى منشور تحت
						<a href="#l">رخصة المشاع الإبداعي BY-SA</a>
					</p>
				</div>
			</div>
		</div>
	</footer>

	<!-- Login Modal -->
	<div class="modal modal-custom fade" id="login-modal" tabindex="-1" role="dialog" aria-labelledby="loginModalLabel"
		aria-hidden="true">
		<div class="modal-dialog" role="document">
			<div class="modal-content">
				<button type="button" class="close" data-dismiss="modal" aria-label="Close">
					<span aria-hidden="true">&times;</span>
					إغلاق
				</button>
				<div class="modal-header">
					<h5 class="modal-title" id="loginModalLabel">تسجيل الدخول</h5>
				</div>
				<div class="modal-body">
					<div class="form-group">
						<a href="#" class="btn btn-outline-white btn-block">
							المتابعة باستخدام تويتر
						</a>
					</div>
					<div class="modal-divider">
						<span>أو</span>
					</div>
					
						<div class="form-group">
							<asp:TextBox runat="server" ID="email_login" CssClass="form-control modal-control" placeholder="البريد الإلكتروني"  TextMode="Email" ></asp:TextBox>
						</div>
						<div class="form-group">
							<asp:TextBox runat="server" ID="password_login" CssClass="form-control modal-control" placeholder="كلمة المرور"   TextMode="Password"></asp:TextBox>
						</div>
						<div class="form-group text-center  mb-4">
							<a href="#" class="text-white"><u>نسيت كلمة المرور؟</u></a>
						</div>
						<div class="form-row justify-content-center">
							<div class="col-12 col-md-6">
								<asp:Button type="submit" ID="login_button" runat="server"  Text="دخول" CssClass="btn btn-white btn-block" OnClick="login_Click"  UseSubmitBehavior="false" />
							</div>
						</div>
					
				</div>
				<div class="modal-footer">
					<span>ليس لديك حساب؟</span>
					<a href="#register-modal" data-toggle="modal" data-dismiss="modal">سجل الآن!</a>
					
				</div>
			</div>
		</div>
	</div>

	<!-- Register Modal -->
	<div class="modal modal-custom fade" id="register-modal" tabindex="-1" role="dialog"
		aria-labelledby="RegisterModalLabel" aria-hidden="true">
		<div class="modal-dialog" role="document">
			<div class="modal-content">
				<button type="button" class="close" data-dismiss="modal" aria-label="Close">
					<span aria-hidden="true">&times;</span>
					إغلاق
				</button>
				
				<div class="modal-header">
					<h5 class="modal-title" id="RegisterModalLabel">حساب جديد</h5>
				</div>
				<div class="modal-body">
					<div class="form-group">
						<a href="#" class="btn btn-outline-white btn-block">
							المتابعة باستخدام تويتر
						</a>
					</div>
					<div class="modal-divider">
						<span>أو</span>
					</div>
					
						<div class="form-group" >
							
							<asp:TextBox runat="server" ID="user_name_signup" CssClass="form-control modal-control" placeholder="اسم المستخدم" ></asp:TextBox>
						</div>
						<div class="form-group">
							
							<asp:TextBox runat="server"  ID="email_signup" CssClass="form-control modal-control" placeholder="البريد الإلكتروني" TextMode="Email" ></asp:TextBox>
						</div>
						<div class="form-group">
							<asp:TextBox runat="server" ID="password_signup" CssClass="form-control modal-control" placeholder="كلمة المرور" TextMode="Password"></asp:TextBox>
						</div>
						<div class="form-row justify-content-center">
							<div class="col-12 col-md-6">
								<asp:Button type="submit" ID="signup_button" runat="server"  Text="تسجيل" CssClass="btn btn-white btn-block" OnClick="Sign_Up_Click"  UseSubmitBehavior="false" />
							</div>
						</div>
					
				</div>
				<div class="modal-footer">
					<span>لديك حساب بالفعل؟</span>
					<a href="#login-modal" data-toggle="modal" data-dismiss="modal">سجل الدخول!</a>
				</div>

			</div>
		</div>
	</div>

	<!-- Optional JavaScript -->
	<!-- jQuery first, then Popper.js, then Bootstrap JS -->
	<%--<script src=" https://code.jquery.com/jquery-3.4.1.slim.min.js"
	integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"
	crossorigin="anonymous"></script>--%>
	<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"
		integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"
		crossorigin="anonymous"></script>
	<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"
		integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"
		crossorigin="anonymous"></script>

	<!-- Majarra Javascript -->
	<script src="javascript/script.js"></script>
	<%--<script type="text/javascript">
        
	</script>--%>

			
    <script type="text/javascript">
		$(document).ready(function () {

            function init() {
                var element = $('#register-modal').detach();
                var element1 = $('#login-modal').detach();
                $($("form")[0]).append(element);
                $($("form")[0]).append(element1);
            }

			window.addEventListener('DOMContentLoaded', init, false);


            var max = 0;
            var b = 9;

            $.ajax({
                type: 'GET',
                url: "https://localhost:44339/api/courses",
                dataType: 'json',
                success: function (data) {

                    $.each(data, function (index, val) {

						max++;
						if (max <= b) {

                            ulEmployees.append('<div class="col-12 col-md-4"> ' +
                                '<div class = "card card-tool" >' +
                                '<a href ="' + val.Course_link + '"target="_blank">' +
                                '<img src = "' + val.icon + ' "class = "card-img"alt = "..." >' +
                                '<div class = "card-body" >' +
                                '<h5 class = "card-title"> ' + val.name + ' </h5>' +
                                '<p class="card-text">' + val.added_by + ' مصدر</p>' +
                                '</a>' +
                                '</div>' +
                                '</div>'
                            );
                        }



                    });


                }
            })

            var a = -b;
            var ulEmployees = $('#courses');
            $('#showbutton').click(function () {
                a += b;
                if (a > max - b) {
                    a = max - b;
                }
                $.ajax({
                    type: 'GET',
                    url: "https://localhost:44339/api/courses",
                    dataType: 'json',
                    success: function (data) {
                        ulEmployees.empty();
                        $.each(data, function (index, val) {
                            if (index < b + a && index >= a) {

                                ulEmployees.append('<div class="col-12 col-md-4"> ' +
                                    '<div class = "card card-tool" >' +
                                    '<a href ="' + val.Course_link + '" target="_blank">' +
                                    '<img src = "' + val.icon + ' "class = "card-img"alt = "..." >' +
                                    '<div class = "card-body" >' +
                                    '<h5 class = "card-title"> ' + val.name + ' </h5>' +
                                    '<p class="card-text">' + val.added_by + ' مصدر</p>' +
                                    '</a>' +
                                    '</div>' +
                                    '</div>'
                                );
                            }




                        });
                    }
                });
            });


            $('#previous').click(function () {
                a -= b;
                if (a < b) {
                    a = 0;
                }


                $.ajax({
                    type: 'GET',
                    url: "https://localhost:44339/api/courses",
                    dataType: 'json',
                    success: function (data) {
                        ulEmployees.empty();
                        $.each(data, function (index, val) {

                            if (index < b + a && index >= a) {

                                ulEmployees.append('<div class="col-12 col-md-4"> ' +
                                    '<div class = "card card-tool" >' +
                                    '<a href ="' + val.Course_link + '"target="_blank">' +
                                    '<img src = "' + val.icon + '" class = "card-img"alt = "..." >' +
                                    '<div class = "card-body" >' +
                                    '<h5 class = "card-title">' + val.name + '</h5>' +
                                    '</a>' +
                                    '</div >' +
                                    '</div>');
                            }



                        });
                    }
                });
			});


            var max2 = 0;
            var b2 = 3;

            $.ajax({
                type: 'GET',
                url: "https://localhost:44339/api/paths",
                dataType: 'json',
                success: function (data) {

                    $.each(data, function (index, val) {

                        max2++;
                        if (max2 <= b2) {
                            
                            ulEmployees2.append('<div class ="col-12 col-md-6 col-lg-4">' +
                                '<div class="card card-path">' +
                                '<a href="' + 'course.aspx?id=' + val.id + '">' +
                                '<img src="' + val.Pic + '" class="card-img-top" alt="' + val.name + '">' +
                                '<div class="card-body">' +
                                '<h5 class="card-title">' + val.name + '</h5>' +
                                '<p class="card-text">' +
                                val.about +
                                '</p>' +
                                '<div class="card-meta row">' +
                                '<div class="col">' +
                                '<span class="material-icons text-icon">collections_bookmark</span>' +
                                '12 مصدر' +
                                '</div>' +
                                '<div class="col">' +
                                +'<span class="material-icons text-icon">thumb_up</span>' +
                                '20 تقييم إيجابي' +
                                '</div>' +
                                '</div>' +
                                '</div>' +
                                '</a>' +
                                '</div>' +
                                '</div>'
                            );
                        }



                    });


                }
            })

            var a2 = 0;
            var ulEmployees2 = $('#paths');
            $('#showbutton2').click(function () {
                a2 += b2;
                if (a2 > max2 - b2) {
                    a2 = max2 - b2;
                }
                $.ajax({
                    type: 'GET',
                    url: "https://localhost:44339/api/paths",
                    dataType: 'json',
                    success: function (data) {
                        ulEmployees2.empty();
                        $.each(data, function (index, val) {
                            if (index < b2 + a2 && index >= a2) {
                               
                                ulEmployees2.append('<div class ="col-12 col-md-6 col-lg-4">' +
                                    '<div class="card card-path">' +
                                    '<a href="' + 'course.aspx?id=' + val.id + '">' +
                                    '<img src="' + val.Pic + '" class="card-img-top" alt="' + val.name + '">' +
                                    '<div class="card-body">' +
                                    '<h5 class="card-title">' + val.name + '</h5>' +
                                    '<p class="card-text">' +
                                    val.about +
                                    '</p>' +
                                    '<div class="card-meta row">' +
                                    '<div class="col">' +
                                    '<span class="material-icons text-icon">collections_bookmark</span>' +
                                    '12 مصدر' +
                                    '</div>' +
                                    '<div class="col">' +
                                    +'<span class="material-icons text-icon">thumb_up</span>' +
                                    '20 تقييم إيجابي' +
                                    '</div>' +
                                    '</div>' +
                                    '</div>' +
                                    '</a>' +
                                    '</div>' +
                                    '</div>'
                                );
                            }




                        });
                    }
                });
            });


            $('#previous2').click(function () {
                a2 -= b2;
                if (a2 < b2) {
                    a2 = 0;
                }


                $.ajax({
                    type: 'GET',
                    url: "https://localhost:44339/api/paths",
                    dataType: 'json',
                    success: function (data) {
                        ulEmployees2.empty();
                        $.each(data, function (index, val) {

                            if (index < b2 + a2 && index >= a2) {
                              

                                ulEmployees2.append('<div class ="col-12 col-md-6 col-lg-4">' +
                                    '<div class="card card-path">' +
                                    '<a href="' + 'course.aspx?id=' + val.id + '">' +
                                    '<img src="' + val.Pic + '" class="card-img-top" alt="' + val.name + '">' +
                                    '<div class="card-body">' +
                                    '<h5 class="card-title">' + val.name + '</h5>' +
                                    '<p class="card-text">' +
                                    val.about +
                                    '</p>' +
                                    '<div class="card-meta row">' +
                                    '<div class="col">' +
                                    '<span class="material-icons text-icon">collections_bookmark</span>' +
                                    '12 مصدر' +
                                    '</div>' +
                                    '<div class="col">' +
                                    +'<span class="material-icons text-icon">thumb_up</span>' +
                                    '20 تقييم إيجابي' +
                                    '</div>' +
                                    '</div>' +
                                    '</div>' +
                                    '</a>' +
                                    '</div>' +
                                    '</div>');
                            }



                        });
                    }
                });
            });


        });
    </script>


    </form>
</body>
</html>
