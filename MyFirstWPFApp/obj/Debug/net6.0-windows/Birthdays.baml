   M S B A M L   `   `   `  ����E  AMyfirstapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MyFirstWPFAppMyFirstWPFApp  5   	       MyFirstWPFApp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:MyFirstWPFApp     5   	     � Title$  Upcoming Events��5   	   $	��450��6!   $	��800��6.    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ ResourceDictionary.xaml?�6%   %    5      .��5      � -   5        $��MainGrid��5      
��� ��� � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5        
�������$��2q�5   B   
���   �$��29,10,682,329q�6j    5       �� 
TargetType �� Property �� Value��%^   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 5��65   5      5      .��5      �� $
��Wrap=�6   Add�� 62   6>   New�� 6N   6Z   Date6j   5       �� 5"   
   $L��Fhttps://cdn.pixabay.com/photo/2016/08/19/23/34/banner-1606562_1280.png��6   $��153,-36,193,252q�6`   �� 5#   
   -   5         ��Name$ BirthdayText��5#      $
��Left=�6*   $	��270��6E   $
��Wrap=�6R   $	��Top=�6f   $	��332��6~   $��212,106,0,0q�6�   �� 5$   
   $
��Wrap=�6   $��291,40,294,329q�6(   �� 6A   	 �� BaselineAlignment$	 Center=�6E   $��15(�6`   $
��Bold"�6n   $�Days until our birthdays��6�   6�   �� 5%   
   $y�Hidden=�6   $��
300,0,46,0q�6)   .+�5&      �� $��20(�6   $��Name:��6#   
 �� Target
 64   ��  �� ElementName$ newName���� 5'      -   5         ��Name$ newName��5'   &   $��10,10q�6   6&   �� 5(      $��15,10q�6   $
��Bold"�6%   
��� ���
���   �$��Confirm��6b    J� RenderTransformOrigin$ 0.5,0.5&�6t   z�5)      V� 5*      .~�5+      �� �� 5,       �� AngleX$ -1.147Q�6(   �� 5-      T� 5.       T� X$
 0.38Q�6-   5/      51      52      � 53   
   -   5        $��DisplayWrapPanel��53      $��65,152,65,33q�6-   55      �� 57   
   -   5        
�������$��2q�57   8   
���   �$��665,10,46,329q�6`    58      ��%^   '��       �� 59      " ��6   .�5:      ��  �@��CornerRadius$ 5��65   5;      5<      .��5=      �� $
��Wrap=�6   �� 6.   $�Delete��62   6C   5>      5@      5A      