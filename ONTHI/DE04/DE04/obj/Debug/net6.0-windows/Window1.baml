   M S B A M L   `   `   `  ?????  ;DE04, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DE04DE04  5   	       DE04.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:DE04     5   	     ? Title$  Window1??5   	   $	??450??6   $	??800??6&    ? 	Resources 5	       ?? 
TargetType ?? Property ?? Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 	Resources??%?  '??       '  J     '?? ?     ?? 5
   
   " ??6   .?5      ??  ? ??
 ??  ?6+   5      ?? 5   
   "  6   .?5      ??  ? ??$
 Bold"?6+   ?? 5       ? ??$ Center=?6;   5      ?? 5   
   " ??6    5      ???? 5      '??       " ??6   .?5      ??  ?@??CornerRadius$ 20??65   5      5      .?5      ??  ? ??
 ??  ?6+   ?? 5       ? ??
 ?????6;   5      5      .??5      ? .+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??dgDSTK??5         AutoGenerateColumns$ False??6!   $??155,111,155,111q?6=      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Mã loại??6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 110 66   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6B   ?? *MaLoai+6_     5      $ Tên loại??6%   $		 110 67   
 6C   ?? *	TenLoai+6a     5       $ Tổng số lượng??6%   $		 110 6<   
 6H   ?? *TongSL+6e     5!      $ Tổng tiền??6%   $		 110 68   
 6D   ?? *
TongTien+ ?? StringFormat$ {0:n0}??6|   5#      5$      5%      