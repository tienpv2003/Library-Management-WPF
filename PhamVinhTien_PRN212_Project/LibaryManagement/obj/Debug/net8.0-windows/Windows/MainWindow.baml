   M S B A M L   `   `   `  ����K  GLibaryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibaryManagement.WindowsLibaryManagement.Windows  5   	   )    #LibaryManagement.Windows.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:LibaryManagement.Windows     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ StaffWindow��5	   	   $	��500��6   $
��1000��6*   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��171 �6   �� 5      .+�5   
   �� -   5         ��Name$ sidebar��5      $��0��6#    �� SelectionMode$ Single=�63   $��0q�5      $��0,90,0,0q�6   .@�5      �� $��1,1,1,1q�6   $��40��64   
������� � Cursor$
 Hand��6W   $��Stretch=�6e   $	��0,5q�5      .��5      �� $��Center=�6   .+�5      �� $��Center=�6    $
��Bold"�6=   	Home Page6Z   5      5      �� 5      $��1,1,1,1q�6   $��40��64   
�������$
 Hand��6W   $��Stretch=�6e   $	��0,5q�6�   .��5      �� $��Center=�6   .+�5      �� $��Center=�6    $
��Bold"�6=   User Manage6\   5      5      �� 5      $��1,1,1,1q�6   $��40��64   
�������$
 Hand��6W   $��Stretch=�6e   $	��0,5q�5      .��5       �� $��Center=�6   .+�5!      �� $��Center=�6    $
��Bold"�6=   Book Manage6\   5"      5#      �� 5%      $��1,1,1,1q�6   $��40��64   
�������$
 Hand��6W   $��Stretch=�6e   $	��0,5q�5&      .��5'      �� $��Center=�6   .+�5(      �� $��Center=�6    $
��Bold"�6=   Reader Manage6^   5)      5*      �� 5,      $��1,1,1,1q�6   $��40��64   
�������$
 Hand��6W   $��Stretch=�6e   $	��0,5q�6�   .��5-      �� $��Center=�6   .+�5.      �� $��Center=�6    $
��Bold"�6=   Publisher Manage6a   5/      50      �� 52      $��1,1,1,1q�6   $��40��64   
�������$
 Hand��6W   $��Stretch=�6e   $	��0,5q�6�   .��53      �� $��Center=�6   .+�54      �� $��Center=�6    $
��Bold"�6=   Author Manage6^   55      56      �� 58      $��1,1,1,1q�6   $��40��64   
�������$
 Hand��6W   $��Stretch=�6e   $	��0,5q�59      .��5:      �� $��Center=�6   .+�5;      �� $��Center=�6    $
��Bold"�6=   Borrow Book Manage6c   5<      5=      �� 5?      $��1,1,1,1q�6   $��40��64   
�������$
 Hand��6W   $��Stretch=�6e   $	��0,5q�5@      .��5A      �� $��Center=�6   .+�5B      �� $��Center=�6    $
��Bold"�6=   	Statistic6Z   5C      5D      �� 5E      -   5        $��Logout��5E      $��60��6&   
���  ��
�������$��	50,30,0,0q�6U   6h   5F       � 5H   
   -   5          �Name$ navFrame��5H       $��1��6     � NavigationUIVisibility$ Hidden=�62   ���#e9ecef6g   5I      5J      