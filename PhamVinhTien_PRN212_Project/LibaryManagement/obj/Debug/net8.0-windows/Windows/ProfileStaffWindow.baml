   M S B A M L   `   `   `  ����K  GLibaryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibaryManagement.WindowsLibaryManagement.Windows  5   	   1    +LibaryManagement.Windows.ProfileStaffWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:LibaryManagement.Windows     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ ProfileStaffWindow��5	   	   $	��400��6$   $	��350��61   .��5      � $��20q�6   
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   $	��141��6*   �� 5      $
��Auto �6   $��34��6*   �� 5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��	Username:��6   $��0��6%   $	��Top=�65   $��5,97,5,0q�6M   $��16(�6_   $��22��6m   �� 5   
   -   5        $��txtUsername��5      $��1��6'   $	��Top=�67   $��16(�6O   $��22��6]   $��0,97,0,0q�6i   �� 5   
   $��Role:��6   $��1��6!   $��0��6.   $��Center=�6>   $��5,0,26,0q�6Y   $��16(�6k   $��22��6y   �� 5   
   -   5        $��txtRole��5      $��1��6#   $��1��60   $��Center=�6@   $��16(�6[   $��22��6i   �� 5   
   -   5        $��Change Password��5      
����·�$��2��6@   $
��Left=�6M   $��
67,22,0,97q�6h   $	��150��6|   $��2��6�   �� 5"   
   -   5        $
��Back��5"      
�������$��2��62   $��1��6?   $	��Top=�6O   $��Right=�6g   $��0,101,113,0q�6�   $	��100��6�   $��30��6�   6�   �� 5$   
   $��Your Profile��6   $��30(�6'   $
��Bold"�65   $
��Left=�6G   $��	67,10,0,0q�6b   $��0��6u   $	��Top=�6�   $��50��6�   $	��175��6�   $��2��6�   5%      5&      