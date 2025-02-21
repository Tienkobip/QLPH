
- Trước khi mà muốn thao tác với database thì cần phải thiết lập connection string trước với các câu lệnh trong cmd như sau:
    + setx CONNECTION_STRING "Server=(TÊN SERVER SQL);Database=QuanLyPhongHoc;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
    + Nếu muốn kiểm tra giá trị của CONNECTION_STRING thì gõ trong cmd như sau: echo %CONNECTION_STRING%
- Sau khi cài đặt như trên hãy vào cmd project và nhấn update-database để đảm bảo đồng bộ từ code lên sql
  
