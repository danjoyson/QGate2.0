   M S B A M L   `   `   `  ����D  @QGATEv1.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:QGATEv1._0.ViewQGATEv1._0.View  5   	   ;"clr-namespace:QGATEv1._0.ModelViewQGATEv1._0.ModelView  65   E'clr-namespace:QGATEv1._0.CustomControlsQGATEv1._0.CustomControls  6j        QGATEv1._0.View.AdminLogin   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:QGATEv1._0.View     5   	   8	ModelView"clr-namespace:QGATEv1._0.ModelView     65   Bcustomcontrols'clr-namespace:QGATEv1._0.CustomControls     6j     � Title$  
AdminLogin��5   	   $	��450��6   $	��800��6)    � DataContext 5	      )   #QGATEv1._0.ModelView.LoginViewModel  5
   
   ��5      �� 5   
    �� Color$ #D8D8D8��6    � 	Resources 5         BooleanToVisibility��%   &	        �� 5   
   6E   5      y�5      �� 5   
    �� Path$ IsViewVisible�6    �� Mode$ TwoWay=�6'    �� 	Converter# [  65   .��5      �� $	��350��6   $	��400��5      
������� �� CornerRadius$ 6��5       J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      	   
BlurRadius$	 15Q�6   
   	Direction$	
 -90Q�5         RenderingBias$ Quality=�5         ShadowDepth$ 2Q�5         Color$
 Gray��5      ._�5    
   �� $��
20,0,20,21q�6   .+�5!   
   �� $��Login��6   $��25(�5"      $��Center=�5#      $	��Top=�5$      $
��Bold"�5%       �� Padding$ 10q�5&      � 5(   
   $��Center=�6    � RowDefinitions 5)      �� 5*      $��* �6    �� 5+      $��* �6    �� 5,      $��* �6    �� 5-      $��* �6    .+�5/      �� $��Nombre de Usuario��6   $��0��50      $
��0,15q�51      $
��Left=�52      $��16(�6/   �� 53      -   5         ��Name$ txtUser��53      $��1��54      $��1��55      $	��0,5q�56      $	��255��57      $��0,0,0,1q�58      $
��Left=�59      ��5:      �� *
Username+�� 5;      $��Contraseña��6   $��2��5<      $
��0,15q�5=      $
��Left=�5>      $��16(�6/   3   -QGATEv1._0.CustomControls.BindablePasswordBox  5?      $��28��5@   9   $��0,5,55,0q�5A   9   $��3��6K   $	��Top=�6X      Password 5?   5   �� *
Password+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5C      5E      �� 5F   
   $��forgot password?��6   $��Right=�5G      $��
0,10,01,11q�64   �� 5H      -   5         ��Name$ LoginBtn��5H      $��Acceder��5I      
����������#084B8A$��35��5L      $	��250��5M      ��5N      �� *LoginCommand+��5O      �� 5P       �� 
TargetType" ��6   .�5Q      ��  �� Property � �� �� Value 5R      �� 5S   "    �� 
TargetType" ��62   .R�5T   &   ��  ��Name$ LoginBorder��6-   #��z��6B   $ 16��5U   -   ._�5V   *   �� $��Center=�6;   $��Center=�5W   ;   5X   '    �� Triggers 5Y   &   P� 5Z   *    P� Property �@J�IsMouseOver P� Value$
 True��6I   . �5[   .   ��  �� 
TargetName$ LoginBorder��6]    � ��
 ������� 5\   .   $ LoginBorder��6d    � ��
 �   �5]   +   5_   #   5a      5b      5d      5o      5p      5q      