<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="course.aspx.cs" Inherits="Majarra.course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" dir="rtl" lang="ar">
<head runat="server">
    <!-- Required meta tags -->
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

	<!-- Bootstrap CSS -->
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"
		integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">

	<!-- Material Icons CSS-->
	<link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">

	<!-- Majarra CSS -->
	<link rel="stylesheet" href="css/coursePath.css">

	<!-- Tab title and icon -->
	<title>مجرة | مسار مطور الواجهات الأمامية</title>
	<link rel="icon" href="images/bg-sm.jpg" type="imag/icon type">
</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg ">

		<a class="navbar-brand" id="majara-logo" href="#">مجرة</a>

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
						<i style="vertical-align: middle;" class="material-icons text-icon">add</i>
						اقترح مصدرًا
					</a>
				</li>

			</ul>
		</div>
	</nav><!-- End of Navigation Bar -->

	<header class="header-lg container-fluid">
		<div class="container">
			<div class="row no-gutters justify-content-center">
				<div class="col-md-9">
					<h2 class="header-title" id="page_course_name" runat="server"></h2>
					<p style="width: 700px;" id="page_course_about" runat="server"> </p>
					<button class="btn btn-light">
						<i class="material-icons text-icon">thumb_up</i>
						<p style="display: inline; vertical-align: top;">تقييم مفيد </p> </button>
					<p style="display: inline; margin-right: 10px;" runat="server" id="page_course_rate"> وجدوه مفيدًا</p>
				
				</div>
				<div class="col-md-2" >
					<div class="header-img" runat="server" id ="page_course_img" ></div>
				</div>


		</div>
		</div>
	</header><!-- End of Header -->

	<section id="aboutPath">
		<div class="container">
		<div class="description col-md-9">
			<p runat ="server" id ="page_course_details"></p>
           <h5>ماذا ستتعلم في هذا المسار ؟</h5>
           <div>
           	<ul runat="server" id="page_course_to_learn">
           		
           	</ul>
           </div>
           <div class="accordion" id="accordionExample" runat="server">
			   <asp:PlaceHolder id="page_sub_courses" runat="server"></asp:PlaceHolder>

  				
 
			</div><!--End of Ocordion -->
			
		</div><!-- End of Description -->
		</div><!-- End of Container -->
		
	</section>
	<section class="discussion">
		<div class="container">
			<div class="col-md-9  col-xs-12">
				<h5>ناقش هذا المسار </h5>
				<p>اطرح الأسئلة ,اقترح و ناقش هذا المسار</p>
				<div class="add-comment mb-3">
					<div class="input-group mb-3">
						  <div class="profile-Pic"></div>
						  <input runat="server" id="new_comment" type="text" class="form-control" placeholder="ماذا تريد أن تقول" aria-label="Username" aria-describedby="basic-addon1"/>
						  <button class="btn btn-danger" runat ="server"  OnServerClick="add_comment">إرسال</button>
					</div>
					
				</div>
				<div class="comments-list" runat="server" id="comments_list">


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
						<a href="#">رخصة المشاع الإبداعي BY-SA</a>
					</p>
				</div>
			</div>
		</div>
	</footer>


	<!-- Optional JavaScript -->
	<!-- jQuery first, then Popper.js, then Bootstrap JS -->
	<script src=" https://code.jquery.com/jquery-3.4.1.slim.min.js"
	integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"
	crossorigin="anonymous"></script>
	<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"
		integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"
		crossorigin="anonymous"></script>
	<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"
		integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"
		crossorigin="anonymous"></script>

	<!-- Majarra Javascript -->
	<script src="javascript/script.js"></script>


    </form>
</body>
</html>
