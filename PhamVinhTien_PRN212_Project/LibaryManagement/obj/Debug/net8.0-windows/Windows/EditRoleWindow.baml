   M S B A M L   `   `   `  ����K  GLibaryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibaryManagement.WindowsLibaryManagement.Windows  5   	   -    'LibaryManagement.Windows.EditRoleWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:LibaryManagement.Windows     5   	     � WindowStartupLocation$  CenterScreen=�5       � Title$ EditRoleWindow��5   	   $	��350��6    $	��300��6-   .��5	      � .+�5
   
   �� $��Role Management��6   $��Center=�6*   $	��Top=�6G   $��0,20,0,0q�6_   $��16(�6q   $
��Bold"�6   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Center=�6I   .+�5      	� -   5         	�Name$ AdminRadioButton��5      $��Admin��64    	� 	GroupName$ 	RoleGroup��6D   $��	0,10,0,10q�6Z   	� 5      -   5        $ StaffRadioButton��5      $��Staff��64   $ 	RoleGroup��6D   $��
20,10,0,10q�6Z   5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   $��0,0,0,20q�6f   .+�5      �� -   5        $
��Save��5      $��75��6$   $��	10,0,10,0q�6/   6B   �� 5      -   5        $
��Back��5      $��75��6$   $��	10,0,10,0q�6/   6B   5      �� 5   
   $��Set Role of:��6   $
��Left=�6'   $��
45,100,0,0q�6B   $	��Top=�6V   �� 5   
   -   5         ��Name$ txtName��5      $
��Left=�6#   $��125,104,0,0q�6>    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��120��6    �� 
IsReadOnly$
 True��6�   5      5      