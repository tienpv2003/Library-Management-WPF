   M S B A M L   `   `   `  ����K  GLibaryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:LibaryManagement.PagesLibaryManagement.Pages  5      1    +LibaryManagement.Pages.AuthorManagementPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:LibaryManagement.Pages     5        N� Title$  AuthorManagementPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      �� 5      $��0 �6   .+�5   
   �� $��AUTHOR MANAGEMENT��6   
���   � �� TextAlignment$ Center=�6@   $��Center=�6W   $��30��6r   $��18(�6~   $
��Bold"�6�   � 5   
   $��1��6   $��10,10,10,10q�6    � ColumnDefinitions 5      �� 5      $	��88* �6#   �� 5      $
��107* �6#   .+�5      �� $��Center=�6   $��0,10,0,0q�65   $
��Wrap=�6G   $��
ADD AUTHOR��6[   $
��Bold"�6m   $��20(�6   $	��Top=�6�   �� 5      $��0��6   $��10,43,10,10q�6)   .+�5      �� $��	Author ID��6   $
��Bold"�6-   �� 5      -   5         ��Name$ 
tbAuthorId��5      $	��0,5q�6.   �� 5      $��Author Name��6   $
��Bold"�6/   �� 5      -   5        $ tbAuthorName��5      $	��0,5q�60   �� 5!       �� Orientation$ 
Horizontal=�6   $
��Left=�66   $
��0,10q�6Q   .+�5"      �� -   5        $	��ADD��5"      $��75��6+   66   �� 5#      -   5        $
��EDIT��5#      $��75��6,   $	��5,0q�67   6D   �� 5$      -   5        $��DELETE��5$      $��75��6.   $	��5,0q�69   6F   �� 5%      -   5        $��REFRESH��5%      $��75��6/   $	��5,0q�6:   6G   5&      �� 5'      $��INFORMATION��6   $��20(�6.   $��	80,0,0,20q�6<   �� 5(      $ 
Horizontal=�6   $��0,0,0,20q�66   .+�5)      �� $��	Author ID��6    $
��Bold"�61   �� 5*      -   5        $ txtAuthorId��5*      ${�False��63   $	��235��6�   $��40,0,0,0q�6�   ��6E   �� *
AuthorId+ � DataContext 6_   �� *SelectedItem+ �� ElementName$ 	lvAuthors��6�   5+      �� 5,      $ 
Horizontal=�6   .+�5-      �� $��Author Name��6    $
��Bold"�63   �� 5.      -   5        $ txtAuthorName��5.      ${�False��65   $	��234��6�   $��20,0,0,0q�6�   ��6G   �� *
AuthorName+ 6c   �� *SelectedItem+$ 	lvAuthors��6�   5/      50      �� 52      -	   5         ��Name$ 	lvAuthors��52      $��1��6*   $��10,10,10,10q�6:   	 �� View	 53      �� 54      .P�55      �� $��	Author ID��6)   
 �� Width$	
 150��6<    �� DisplayMemberBinding 6H   �� *
AuthorId+�� 56      $��Author Name��6)   $	
 250��6>    6J   �� *
AuthorName+57      59      5:      5;      5<      