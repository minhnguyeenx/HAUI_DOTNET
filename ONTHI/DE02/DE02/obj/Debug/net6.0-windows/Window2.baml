   M S B A M L   `   `   `  ?????  ;DE02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DE02DE02  5   	       DE02.Window2   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:DE02     5   	     ? Title$  Window2??5   	   $	??450??6   $	??800??6&    ? 	Resources 5	       ?? 
TargetType ?? Property ?? Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 	Resources??%?  '??       '  J     '?? ?     ?? 5
   
   " ??6   .?5      ??  ? ??
 ??  ?6+   5      ?? 5   
   "  6   .?5      ??  ? ??$
 Bold"?6+   ?? 5       ? ??$ Center=?6;   5      ?? 5   
   " ??6    5      ???? 5      '??       " ??6   .?5      ??  ?@??CornerRadius$	 150??65   5      5      .?5      ??  ? ??
 ??? ?6+   5      5      .??5      ? .+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??dgDSTK??5         AutoGenerateColumns$ False??6!   $??133,134,163,134q?6=      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã nhóm hàng??6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6;   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6G   ?? *
MaNhomHang+6h     5      $ Tên nhóm hàng??6%   $		 150 6<   
 6H   ?? *TenNhomHang+6j     5      $ Tổng nhân viên??6%   $		 100 6=   
 6I   ?? *TongNV+6f     5       $ Tổng tiền??6%   $		 120 68   
 6D   ?? *TongTienBan+ ?? StringFormat$ {0:n0}??   	CellStyle 5!      ?? 5"      *  $System.Windows.Controls.DataGridCell"  6    .?5#      ??  ? ??$
 Bold"?6;   5$      5&      5(      5)      5*      