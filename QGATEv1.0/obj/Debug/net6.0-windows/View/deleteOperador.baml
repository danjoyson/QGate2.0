   M S B A M L   `   `   `  ����D  @QGATEv1.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:QGATEv1._0.ViewQGATEv1._0.View  5   	   $    QGATEv1._0.View.deleteOperador   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:QGATEv1._0.View     5   	     � Title$  deleteOperador��5   	   $	��550��6    $	��800��6-   ��5	      �� 5
   
    �� Color$ #D8D8D8��6   .��5      �� .+�5   
   � $��0,0,20,0q�6    � RowDefinitions 5      �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��1��6!   $��/Resources/logowb.png��61   $��60��6P   $
��Auto��6\   $��Right=�6i   $��100,10,10,0q�6�   5      5      � 5   
   $��
0,20,10,30q�6    5      �� 5      $
��Auto �6     5      �� 5       $��* �6#   �� 5!      $��* �6#   �� 5"      $
��Auto �6#   .+�5%      �� -   5         ��Name$ 	ReturnBtn��5%      $�� ��5&      
�������$��	60,0,10,0q�5(      $��80��5)      $��80��5*      $��0��5,      $��0��6)   ��5-      �� 5.       �� 
TargetType" ��6   .�5/      ��  �� Property � �� �� Value 50      �� 51   "    �� 
TargetType" ��62   .R�52   &   �� 	 ��Name$	 LoginBorder��6-   #��z��6B   
 �� CornerRadius$
 2��53   1   ._�54   *   �� $��Center=�6;   $��Center=�55   ?   56   '    �� Triggers 57   &   P� 58   *    P� Property �@J�IsMouseOver P� Value$
 True��6I   . �59   .   ��  �� 
TargetName$ LoginBorder��6]    � ��
 ������� 5:   .   $ LoginBorder��6d    � ��
 �   �5;   +   5=   #   5?      5@      ��5B      �� 5C       �� ImageSource$ /Resources/return.png��6!   5E      �� 5H      $��0��6   $��3��6!   $��	10,0,60,0q�61   .��5I      �� $��/Resources/opIcon.png��6   $	��100��67   $	��100��6C   5J      5K      � 5L   
   $��	0,30,0,30q�6    5M      �� 5N      $
��Auto �6     5P      �� 5Q      $
��Auto �6#   �� 5R      $��* �6#   .+�5T      �� $��
110,0,60,0q�6   $��0��6,   $��0��6<   �� 6J   .�6O   .�6d   Número de operador a�� 
eliminar6y   6�   �� 5U      $��1��6   $��0��5V      $��	10,0,50,0q�5W      
�������$��50��5Y      $��0,0,0,1q�5Z      $��Stretch=�5[      $�� ��5\      5]      � 5^   
   $��10,20,10,10q�6    5_      �� 5`      $
��Auto �6     5b      �� 5c      $
��Auto �6#   �� 5d      $��* �6#   .+�5g      �� -   5        $ DeletePiezaBtn��5g      $��Eliminar��5h      
����������#FA5858$��160,5,150,0q�5k      $��60��5l      $��1��5m   )   $��0��69   ��5n      �� 5o      " ��6   .�5p      ��  � �� 5q      �� 5r   "   " ��62   .R�5s   &   �� $	 LoginBorder��6-   #��z��6B   $
 20��5t   1   ._�5u   *   �� $��Center=�6;   $��Center=�5v   ?   5w   '    5x   &   P� 5y   *    �@J�IsMouseOver$
 True��6I   . �5z   .   �� $ LoginBorder��6]    � ��
 ������� 5{   .   $ LoginBorder��6d    � ��
 �   �5|   +   5~   #   5�      5�      5�      5�      5�      5�      