   M S B A M L   `   `   `  ����K  GLibaryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibaryManagement.WindowsLibaryManagement.Windows  5   	   2    ,LibaryManagement.Windows.ChangePasswordStaff   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:LibaryManagement.Windows     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Change Password��5	   	   $	��200��6!   $	��400��6.   .��5
      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��New Password:��6   $��1��6)   $��0��66   $��Center=�6F   $��0,0,10,0q�6a   $��16(�6s   G� 5   
   -   5        $��txtNewPassword��5      $��1��6,   $��1��69   $��Center=�6I   $��16(�6d   $��0,5,0,5q�6r   �� 5   
   $��Confirm Password:��6   $��2��6-   $��0��6:   $��Center=�6J   $��0,0,10,0q�6e   $��16(�6w   G� 5   
   -   5        $��txtConfirmPassword��5      $��2��60   $��1��6=   $��Center=�6M   $��16(�6h   $��0,5,0,5q�6v   �� 5   
   -   5        $��Save New Password��5      
����·�$��3��6B   $��0��6O   $��2��6_   $	��Top=�6s   $��Center=�6�   $��0,20,0,0q�6�   $	��150��6�   $��30��6�   6�   �� 5   
   -   5        $��
txtMessage��5      $��4��6&   $��0��63   $��2��6C   $��Center=�6W   $��Center=�6r   $��0,10,0,0q�6�   $��14(�6�   
���  ��6�   5       5!      