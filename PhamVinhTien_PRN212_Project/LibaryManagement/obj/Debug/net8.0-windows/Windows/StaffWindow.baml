   M S B A M L   `   `   `  ����K  GLibaryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibaryManagement.WindowsLibaryManagement.Windows  5   	   *    $LibaryManagement.Windows.StaffWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:LibaryManagement.Windows     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ StaffWindow��5	   	   $	��500��6   $
��1000��6*   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��171 �6   �� 5      .+�5   
   �� -   5         ��Name$ sidebar��5      $��0��6#    �� SelectionMode$ Single=�63   $��0q�5      $��0,90,0,0q�6&   .@�5      �� $��1,1,1,1q�6   $��40��64   
������� � Cursor$
 Hand��6W   $��Stretch=�6e   $	��0,5q�5      .��5      �� $��Center=�6   .+�5      �� $��Center=�6    $
��Bold"�6=   	Home Page6Z   5      5      �� 5      $��1,1,1,1q�6   $��40��64   
�������$
 Hand��6W   $��Stretch=�6e   $	��0,5q�5      .��5      �� $��Center=�6   .+�5      �� $��Center=�6    $
��Bold"�6=   Book Manage6\   5      5      �� 5       $��1,1,1,1q�6   $��40��64   
�������$
 Hand��6W   $��Stretch=�6e   $	��0,5q�5!      .��5"      �� $��Center=�6   .+�5#      �� $��Center=�6    $
��Bold"�6=   Reader Manage6^   5$      5%      �� 5'      $��1,1,1,1q�6   $��40��64   
�������$
 Hand��6W   $��Stretch=�6e   $	��0,5q�5(      .��5)      �� $��Center=�6   .+�5*      �� $��Center=�6    $
��Bold"�6=   Publisher Manage6a   5+      5,      �� 5.      $��1,1,1,1q�6   $��40��64   
�������$
 Hand��6W   $��Stretch=�6e   $	��0,5q�5/      .��50      �� $��Center=�6   .+�51      �� $��Center=�6    $
��Bold"�6=   Author Manage6^   52      53      �� 55      $��1,1,1,1q�6   $��40��64   
�������$
 Hand��6W   $��Stretch=�6e   $	��0,5q�56      .��57      �� $��Center=�6   .+�58      �� $��Center=�6    $
��Bold"�6=   Borrow Book Manage6c   59      5:      �� 5<      $��1,1,1,1q�6   $��40��64   
�������$
 Hand��6W   $��Stretch=�6e   $	��0,5q�5=      .��5>      �� $��Center=�6   .+�5?      �� $��Center=�6    $
��Bold"�6=   	Statistic6Z   5@      5A      5B      �� 5D   
   -   5        $��Profile��5D      $��20��6#   $��60��6/   
����·�
�������$	��Top=�6b   $��
10,383,0,0q�6z   6�   �� 5E   
   -   5        $��Logout��5E      $��20��6"   $��60��6.   
���  ��
�������$	��Top=�6]   $��
10,412,0,0q�6u   6�    � 5G   
   -   5          �Name$ navFrame��5G       $��1��6     � NavigationUIVisibility$ Hidden=�62   ���#e9ecef6g   5H      5I      