   M S B A M L   `   `   `  ����K  GLibaryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:LibaryManagement.WindowsLibaryManagement.Windows  5   	   *    $LibaryManagement.Windows.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:LibaryManagement.Windows     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ LoginWindow��5	   	   $	��550��6   $	��450��6*    � WindowStyle$
 None=�5
   	   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      .+�5   
   �  � ColumnDefinitions 5      �� 5      �� 5      $��25 �6#   �� 5      $��25 �6#   �� 5      $��5 �6#   .+�5      �� $��LOG IN��6   
���   �$��15(�69   $��0��6G   $��Center=�6W   $��10,0,0,0q�6r   �� 5      -   5         ��Name$ btnMinimize��5      
�������$��0q�6=   $��-��6Q   
���   �$��21(�5       � Cursor$
 Hand��6   $��1��6)   69   �� 5      -   5        $ btnClose��5      
�������$��0q�6:   $��X��6N   
���   �$��16(�5      $
 Hand��6   $��2��6)   69   5      �� 5    
   $��1��6    �� Orientation$ Vertical=�6"   $��	29,0,25,0q�69   .+�5!      �� $��FPT Library��6   
���   �$��30(�5"      $��Medium"�6"   $��Center=�5#      �� 5$      $��Library Management��6   
�������$��30(�5%      $��Medium"�6"   $��Center=�5&      $��0,5,0,0q�61   �� 5(      $��Username��6   
���   �$��20(�6;   $��Medium"�5)      $��0,35,0,0q�6(   �� 5*      -   5         ��Name$ txtUser��5*      $��13(�6'   $��Medium"�65   
������ 
���   �$��0,0,0,1q�5,      
�������$��34��5-      $��0,20,0,0q�6   .��60   5/      �� 51      $��Password��6   
���   �$��20(�6;   $��Medium"�52      $��0,35,0,0q�6(   G� 53      -   5        	 G�Name$	 txtPass��53      $��13(�6+   $��Medium"�69   
������ 
���   �$��0,0,0,1q�55      
�������$��32��56      $��0,20,0,0q�6   57      �� 59      -   5        $��txtFail��59      $��Login failed!!��6'   
���  ��$��0,20,0,0q�6N   
 �� TextAlignment$
 Center=�6`   $��Medium"�6w   $��12(�5:      $y�Hidden=�6"   �� 5;      -   5        $ btnLogin��5;      
�������$��Login��6;   
���   �$	��138��5<      $��35��6   $��2,2,2,2q�6%   $
��Bold"�6?   $��16(�5=      $
 Hand��6   6-   �� 5>      -   5        $ btnRegister��5>      
����·�$��Register Staff��6?   
���   �$	��138��5?      $��35��6   $��2,2,2,2q�6%   $
��Bold"�6?   $��16(�5@      $
 Hand��6   $��0,20,0,0q�6)   6;   �� 5A      -   5        $ btnForgotPassword��5A      
����·�$��Forgot Password��6E   
���   �$	��136��5B      $��35��6   $��2,2,2,2q�6%   $
��Bold"�6?   $��16(�5C      $
 Hand��6   $��0,20,0,0q�6)   6;   5D      5E      5F      