   M S B A M L   `   `   `  ����K  GLibaryManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:LibaryManagement.PagesLibaryManagement.Pages  5      4    .LibaryManagement.Pages.PublisherManagementPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:LibaryManagement.Pages     5        N� Title$  PublisherManagementPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      �� 5      $��0 �6   .+�5   
   �� $��PUBLISHER MANAGEMENT��6   
���   � �� TextAlignment$ Center=�6C   $��Center=�6Z   $��30��6u   $��18(�6�   $
��Bold"�6�   � 5   
   $��1��6   $��10,10,10,10q�6    � ColumnDefinitions 5      �� 5      $	��88* �6#   �� 5      $
��107* �6#   .+�5      �� $��Center=�6   $��0,10,0,0q�65   $
��Wrap=�6G   $��ADD PUBLISHER��6[   $
��Bold"�6p   $��20(�6�   $	��Top=�6�   �� 5      $��0��6   $��10,43,10,10q�6)   .+�5      �� $��Publisher ID��6   $
��Bold"�60   �� 5      -   5         ��Name$ tbPublisherId��5      $	��0,5q�61   �� 5      $��Publisher Name��6   $
��Bold"�62   �� 5      -   5        $ tbPublisherName��5      $	��0,5q�63   �� 5!       �� Orientation$ 
Horizontal=�6   $
��Left=�66   $
��0,10q�6Q   .+�5"      �� -   5        $	��ADD��5"      $��75��6+   66   �� 5#      -   5        $
��EDIT��5#      $��75��6,   $	��5,0q�67   6D   �� 5$      -   5        $��DELETE��5$      $��75��6.   $	��5,0q�69   6F   �� 5%      -   5        $��REFRESH��5%      $��75��6/   $	��5,0q�6:   6G   5&      �� 5'      $��INFORMATION��6   $��20(�6.   $��	80,0,0,20q�6<   �� 5(      $ 
Horizontal=�6   $��0,0,0,20q�66   .+�5)      �� $��Publisher ID��6    $
��Bold"�64   �� 5*      -   5        $ txtPublisherId��5*      ${�False��66   $	��214��6�   $��40,0,0,0q�6�   ��6H   �� *PublisherId+ � DataContext 6e   �� *SelectedItem+ �� ElementName$ lvPublishers��6�   5+      �� 5,      $ 
Horizontal=�6   .+�5-      �� $��Publisher Name��6    $
��Bold"�66   �� 5.      -   5        $ txtPublisherName��5.      ${�False��68   $	��213��6�   $��20,0,0,0q�6�   ��6J   �� *PublisherName+ 6i   �� *SelectedItem+$ lvPublishers��6�   5/      50      �� 52      -	   5         ��Name$ lvPublishers��52      $��1��6-   $��10,10,10,10q�6=   	 �� View	 53      �� 54      .P�55      �� $��Publisher ID��6)   
 �� Width$	
 150��6?    �� DisplayMemberBinding 6K   �� *PublisherId+�� 56      $��Publisher Name��6)   $	
 250��6A    6M   �� *PublisherName+57      59      5:      5;      5<      