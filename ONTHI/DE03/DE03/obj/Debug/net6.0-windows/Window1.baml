   M S B A M L   `   `   `  ?????  ;DE03, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DE03DE03  5   	       DE03.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:DE03     5   	     ? Title$  Window1??5   	   $	??450??6   $	??800??6&    ? 	Resources 5	       ?? 
TargetType ?? Property ?? Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 	Resources??%?  '??       '  J     '?? ?     ?? 5
   
   " ??6   .?5      ??  ? ??
 ??  ?6+   5      ?? 5   
   "  6   .?5      ??  ? ??$
 Bold"?6+   ?? 5       ? ??$ Center=?6;   ?? 5       ? ??$
 14px(?6)   5      ?? 5   
   " ??6    5      ???? 5      '??       " ??6   .?5      ??  ?@??CornerRadius$ 20??65   5      5      .?5      ??  ? ??
 ??  ?6+   ?? 5       ? ??
 ?????6+   5      5      .??5      ? .+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??dgDSTK??5      $??65,108,65,108q?6!      AutoGenerateColumns$ False??68      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Mã phòng??6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 150 67   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6C   ?? *	MaPhong+6a     5       $ Tên Phòng??6%   $		 180 68   
 6D   ?? *
TenPhong+6c     5!      $ Số lượng nhân viên??6%   $		 150 6A   
 6M   ?? *slnv+6h     5"      $ Tổng Lương??6%   $		 150 69      
Foreground
 ??  ?
 6E   ?? *	TongLuong+ ?? StringFormat$ {0:n0}??   	CellStyle 5#      ?? 5$      *  $System.Windows.Controls.DataGridCell"  6    .?5%      ??  ? ??$ Right=?6D   5&      5(      5*      5+      5,      