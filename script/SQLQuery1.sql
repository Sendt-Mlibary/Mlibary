select ctpm.ID, ctpm.hantra, ctpm.SoLuong,
case ctpm.trangthai when 1 then N'Đang mượn' 
when 2 then N'Đã trả' 
when 3 then N'Đang gia hạn' 
when 4 then N'Vi phạm' 
else 'N/A'
end as TrangThaiStr , 
pm.Id idPhieuMuon, CONVERT(pm.NgayMuon,""), 
tl.Id idTaiLieu, tl.TenSach, nh.TenNganhHoc, nns.TenNgonNguSach, tls.TenTheLoai, tl.NamXuatBan,
case tl.TrangThai when 1 then N'Được cho mượn' 
when 2 then N'Không được mượn'
else 'N/A'
end as TrangThaiTaiLieuStr 
from ChiTietPhieuMuon ctpm
inner join PhieuMuon pm on ctpm.ID_PhieuMuon = pm.ID
inner join TaiLieu tl on ctpm.ID_TaiLieu = tl.ID 
left join NganhHoc nh on nh.ID = tl.ID_NganhHoc
left join NgonNguSach nns on nns.ID = tl.ID_NgonNguSach
left join TheLoaiSach tls on tls.ID = tl.ID_TheLoaiSach
where pm.ID_BanDoc = 1