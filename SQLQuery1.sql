--công ty
insert into Company(name) values('FPT Telecom')
insert into Company(name) values('Sunway Alohal')
insert into Company(name) values('Viettel')
select * from Company

--phân loại, số người theo dõi
insert into Category(Levers, Following, Title) values(1, 1000, N'Lập trình')
insert into Category(Levers, Following, Title) values(2, 800, N'Thiết kế')
insert into Category(Levers, Following, Title) values(3, 850, N'Giảng dạy')
select * from Category

--phỏng vấn
insert into Interview(Inter_Date, Static, FullName) values('2/1/2020', 'Ban Da Duoc Nhan', 'Pham Tuan Ngoc')
insert into Interview(Inter_Date, Static, FullName) values('2/4/2020', 'Ban Khong Du Yeu Cau', 'Nguyen Minh Tuan')
insert into Interview(Inter_Date, Static, FullName) values('3/5/2020', 'Ban Hay Cho Chut', 'Dam Anh Quan')
insert into Interview(Inter_Date, Static, FullName) values('2/1/2020', 'Ban Hay Cho Chut', 'Duong Vinh')

select * from Interview

insert into Account(Email, Password, Role) values('ngocgai@gmail.com', '12345678', 'staff')
insert into Account(Email, Password, Role) values('vinhdz@gmail.com', '12345678', 'employ')
insert into Account(Email, Password, Role) values('quanss@gmail.com', '12345678', 'staff')
select * from Account
--ung vien
insert into Candidate(Fullname, Age, Address, Phone, Literacy, Majors, Graduate, Vacancy,Description, AccountID) values(N'Nguyen Van Anh', 20, N'Hà Nội', '0986785603', 'High School', 'Game', 'High School', 'Leader', N'Trở thành đơn vị cung cấp giải pháp Công nghệ giúp kết nối và phát triển nguồn nhân lực hàng đầu tại Việt Nam', 1)
insert into Candidate(Fullname, Age, Address, Phone, Literacy, Majors, Graduate, Vacancy,Description, AccountID) values(N'Trần Văn Dũng', 21, N'Thái Bình', '09452237665', 'High School1', 'Sql', 'High School1', 'Member', N'Nâng cấp toàn diện Nền tảng tuyển dụng ứng dụng sâu trí thông minh nhân tạo. Đa dạng hóa các sản phẩm công nghệ trong cùng hệ sinh thái Quản trị nhân sự.', 2)
select * from Interview
--cong viec
insert into Job(Title, Wage, Image, Date_create, Modification, Job_description, Vacancy, Address, Tag, CatID, CompanyID) values(N'Giảng viên lập trình game', 1000, 'hinhanhfpt.jpg', '10/2/2019', '12/5/2019', N'Giảng dạy một trong các học phần về:
1. Lập trình Game: 2D và 3D đa nền tảng Unity (PC/Mobile)
2. Xây dựng Game AR và VR với Unity
- Thực hiện các công việc khác theo sự phân công của CBQL', N'Nhân viên', N'Cầu Giấy - Hà Nội', 'game', 1, 1)
insert into Job(Title, Wage, Image, Date_create, Modification, Job_description, Vacancy, Address, Tag, CatID, CompanyID) values(N'Nhân viên thiết kế tài liệu', 2000, 'hinhanhsunway.jpg', '12/3/2019', '12/19/2019', N'1. Thiết kế, chỉnh sửa hình ảnh, dựng video phù hợp với từng dự án, sự kiện khác nhau của Trung tâm đào tạo.
2. Xây dựng kế hoạch, tài liệu videos giảng dạy
3. Làm phim tài liệu Elearning
4. Thông kê dữ liệu đào tạo và báo cáo Trưởng bộ phận
5. Thực hiện các công việc khác theo yêu cầu của TBP
6. Làm việc tại Trung tâm đào tạo.', N'Nhân Viên', N'Hà Đông - Hà Nội', 'thietke', 2, 2)
insert into Job(Title, Wage, Image, Date_create, Modification, Job_description, Vacancy, Address, Tag, CatID, CompanyID) values(N'Gia sư', 1500, 'hinhanhgs.jpg', '2/1/2020', '3/2/2020', N' là hình thức 1 giáo viên dạy kèm 1 hoặc nhiều học viên với chương trình học được thiết kế theo yêu cầu để mức độ hiệu quả cao.
Gia sư giúp đánh giá năng lực học sinh, củng cố kiến thức cơ bản và dạy nâng cao theo nhu cầu của người học.
Gia sư chia thành các nhóm: ôn thi cơ bản, ôn thi tốt nghiệp, ôn thi đại học, ôn Chuyên…
Gia sư dạy về mảng ngoại ngữ: ôn thi HSG ngoại ngữ, ôn thi lấy chứng chỉ quốc tế như Ielts, Toeic…
Gia sư đồng hành và gắn bó lâu dài với lớp học mình nhận, đánh giá, chọn lọc và điều chỉnh phù hợp giúp các em tiến bộ từng ngày, cam kết đầu ra cho học sinh và phụ huynh như mong muốn.', N'Gia sư', N'Đống Đa - Hà Nội', 'giasu', 3, 3)
--test 0 sử dụng để seedData
insert into Job(Title, Wage, Image, Date_create, Modification, Job_description, Vacancy, Address, Tag, CatID, CompanyID) values(N'Gia sư', 1500, 'hinhanhgs.jpg', '2/1/2020', '3/2/2020', N' là hình thức 1 giáo viên dạy kèm 1 hoặc nhiều học viên với chương trình học được thiết kế theo yêu cầu để mức độ hiệu quả cao.
Gia sư giúp đánh giá năng lực học sinh, củng cố kiến thức cơ bản và dạy nâng cao theo nhu cầu của người học.
Gia sư chia thành các nhóm: ôn thi cơ bản, ôn thi tốt nghiệp, ôn thi đại học, ôn Chuyên…
Gia sư dạy về mảng ngoại ngữ: ôn thi HSG ngoại ngữ, ôn thi lấy chứng chỉ quốc tế như Ielts, Toeic…
Gia sư đồng hành và gắn bó lâu dài với lớp học mình nhận, đánh giá, chọn lọc và điều chỉnh phù hợp giúp các em tiến bộ từng ngày, cam kết đầu ra cho học sinh và phụ huynh như mong muốn.', N'Gia sư', N'Đống Đa - Hà Nội', 'giasu', 1002, 1003)
select * from Job

insert into Candidate_list(job_id, can_id, interview_id) values(1,1,1)
insert into Candidate_list(job_id, can_id, interview_id) values(2,2,2)

insert into Job(Title, Wage, Image, Date_create, Modification, Job_description, Vacancy, Address, Tag, CatID, CompanyID) values(N'Lập trình Java', 1800, 'hinhanhjs.jpg', '2/6/2020', '4/8/2020', N' là một một ngôn ngữ lập trình hiện đại, bậc cao, hướng đối tượng, bảo mật và mạnh mẽ. Và là một Platform. Để giúp các bạn tìm hiểu và sử dụng thành thạo ngôn ngữ lập trình bậc cao này, eLib đã tổng hợp một số tài liệu, hướng dẫn các vấn đề liên quan đến lập trình Java. Hi vọng đây sẽ là tài liệu ôn tập hiệu quả giúp bạn có thể tự học lập trình, nâng cao khả năng tư duy. Chúc các bạn thành công!
', N'Thực tập', N'Quận 1 - TP.HCM', 'laptrinhjava', 1002, 1003)