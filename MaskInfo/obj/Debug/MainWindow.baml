   M S B A M L   `   `   `  ����C  ?MaskInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MaskInfo.ControlMaskInfo.Control  5   	   #clr-namespace:MaskInfoMaskInfo  5   	       MaskInfo.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /ctrlclr-namespace:MaskInfo.Control     5   	   (localclr-namespace:MaskInfo     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Title$ MaskInfo��5   	    � 	Resources 5         NavigationButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers	 P� Property
 P� Value  btnStyle �� CornerRadius��%s  &	        &	 l    �� 5   
   " ��6)   .�5      ��  � ��
 �����6+   �� 5       � ��$ 50��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      �� $��Center=�6/   5       5      P� 5      	 �@J�IsMouseOver
 . . �5   "   ��  � ��
 �����6?   5      5      5      5      �� 5    
   " ��6!   .�5!      ��  � �� �#FDD4CB6+   �� 5"       � ��$	 130��6'   �� 5#       � ��$	 300��6&   �� 5$       � ��$	 Top=�62   �� 5%       � ��$ Right=�64   �� 5&       � �� 5'      �� 5(      " ��6&   .R�5)      �� #��z��6!   $ 5��6K   ._�5*      �� $��Center=�6/   5+       5,      P� 5-      	 �@J�IsMouseOver
 . . �5.   "   ��  � �� �#FD967E6?   5/      51      53      54      56      .��57      �  � ColumnDefinitions 58   
   �� 59      $	��150 �6   �� 5:      $��* �6   .+�5=   
   � $��0��6   .+�5>      �� $	��Top=�6   .+�5?      �� -   5         ��Name$ btnSearchByDrugstore��5?      #��[  67   .��5@      ��  �� Orientation$ 
Horizontal=�6!   .+�5A      �� $��/Assets/drug.png��6    $��70��6:   $��30��6F   �� 5B      $��약국 검색��6$   $��15(�61   $��	ExtraBold"�6?   $��Center=�6V   $��15 0 0 0q�6q   5C      5D      �� 5E      -   5        $ btnSearchByAddress��5E      #��[  65   .��5F      �� $ 
Horizontal=�6!   .+�5G      �� $��/Assets/address.png��6    $��70��6=   $��30��6I   �� 5H      $��위치 검색��6$   $��15(�61   $��	ExtraBold"�6?   $��Center=�6V   $��15 0 0 0q�6q   5I      5J      �� 5K      -   5        $ 	btnNotice��5K      #��[  6,   .��5L      �� $ 
Horizontal=�6!   .+�5M      �� $��/Assets/month.png��6    $��70��6;   $��30��6G   �� 5N      $��주의사항��6$   $��15(�60   $��	ExtraBold"�6>   $��Center=�6U   $��15 0 0 0q�6p   5O      5P      5Q      5R      � 5T   
   $��1��6   ���#166ABA 5U      �� 5V      $��* �6#   �� 5W      $
��1180 �6#   �� 5X      $��* �6#   .+�5[      � $��1��6   .+�5\      �� $��약국 목록��6   $��	0 100 0 0q�6)   
�������$��30(�5]   /   $
��Bold"�6=   $
��Left=�5^      $	��150��67   �� 5_      	 �� X1$ 0��6   	 �� Y1$	 155��6   	 �� X2$
 1180��6'   	 �� Y2$	 155��61   
�������$��2��6I   /   )MaskInfo.Control.SearchByDrugstoreControl  5`      -   5          Name$ ctrlSearchByDrugstore��5`   0   -   'MaskInfo.Control.SearchByAddressControl  5a      -   5          Name$ ctrlSearchByAddress��5a   .   $y�	Collapsed=�6K   5c      5d      5e      5f      