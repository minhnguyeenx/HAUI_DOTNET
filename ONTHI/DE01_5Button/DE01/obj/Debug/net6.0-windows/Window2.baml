   M S B A M L   `   `   `  ?????  ;DE01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DE01DE01  5   	       DE01.Window2   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:DE01     5   	     ? Title$  Window2??5   	   $	??450??6   $	??800??6&    ? 	Resources 5	       ?? 
TargetType ?? Property ?? Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 	Resources??%?  '??       '  J     '?? ?     ?? 5
   
   " ??6   .?5      ??  ? ??
 ??  ?6+   5      ?? 5   
   "  6   .?5      ??  ? ??$
 Bold"?6+   ?? 5       ? ??$ Center=?6;   5      ?? 5   
   " ??6    5      ???? 5      '??       " ??6   .?5      ??  ?@??CornerRadius$	 150??65   5      5      .?5      ??  ? ??
 ?????6+   5      5      .??5      ? .+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??dgDSPK??5      $??97,59,97,115q?6!      AutoGenerateColumns$ False??67      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã khoa??6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 66   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6B   ?? *MaKhoa+6_     5      $ 	Tên khoa??6%   $		 200 67   
 6C   ?? *	TenKhoa+6a     5      $ Số lượng nhân viên??6%   $		 150 6A   
 6M   ?? *SLNV+6h     5       $ Tổng viện phí??6%   $		 150 6<   
 6H   ?? *TongVP+ ?? StringFormat$ {0:n0}??6~   5"      5#      5$      