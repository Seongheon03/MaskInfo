   M S B A M L   `   `   `  ����C  ?MaskInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MaskInfoMaskInfo  5      P LLoadingIndicators.WPF, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null\Bclr-namespace:LoadingIndicators.WPF;assembly=LoadingIndicators.WPFLoadingIndicators.WPF 5      -    'MaskInfo.Control.SearchByAddressControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:MaskInfo     5      UloadinBclr-namespace:LoadingIndicators.WPF;assembly=LoadingIndicators.WPF     5      .��5
      � .+�5   
   �   � RowDefinitions  5      �� 5      $	��100 �6    �� 5      $��* �6    �� 5      $	��530 �6    .+�5      � $��0��6   .+�5      ��    	SearchBox#��[  6]   
 � Tag$ 주소를 입력하세요��5      ��5      �� *SearchedText+ �� UpdateSourceTrigger$ PropertyChanged=�.��5   *    J� InputBindings 5      �� 5      
 �� Key$ Enter��6Q    �� Command 6%   �� *SearchByAddressCommand+6Q   .��5   -   5      5      � 5      $��2��6   .+�5      �� .��5      �� $
��1180��6K   
�������$��Center=�5   6   $��Disabled=�5   #   ��5   #   �� *StoresByAddress+��5       �� 5!      .R�5"   "   � 5#      ��5%      �� 5&      .R�5'   "   �� .+�5(   &   �� ���#166ABA$��2q�6C    �� CornerRadius$ 20��6W   $	��539��6i   $��	30 20 0 0q�6u   ._�5)   *   �� $	��150��65   .+�5*   .   ��  �� Orientation$ 
Horizontal=�69   $��	10 15 0 0q�6R   .+�5+   2   �� $��30��6T   ��68   �� *
ImageUrl+6T   �� 5,   2     ItemTextblock#��[ 6R   $��23(�5-   <   $
��Bold"�6J   ��5,   <   �� *Name+5-   J   5.   /   �� 5/   .   $ 
Horizontal=�69   $��	10 12 0 0q�6R   .+�50   2   �� $��/Assets/mask.png��68   $��30��6R   �� 51   2   #��[ 6W   $��20(�52   <   $
��Bold"�6p   ��51   <   �� *	Inventory+��52   J   �� *InventoryColor+6p   53   /   �� 54   .   $ 
Horizontal=�69   $��	10 12 0 0q�6R   .+�55   2   �� $��/Assets/address.png��68   $��30��6U   �� 56   2   #��[ 6R   $��16(�57   <   $	��460��6J   $
��Wrap=�6V   ��56   <   �� *Addr+57   V   58   /   59   +   5:   '   5;   #   5<      5>      5?      �� 5@      $��Center=�5A      $��Center=�69   
�������$
��Bold"�5B   .   $��30(�6@   ��5@      �� *TbAddressGuideText+y�5C      �� *TbAddressGuideVisibility+  boolToVisibility �� 	Converter# [ ,  &LoadingIndicators.WPF.LoadingIndicator  5D      $��2��6*   	   
SpeedRatio$	 1Q�5E   &   
����iA�  LoadingIndicatorWaveStyle#���  5G   &   
   IsActive
 5E   5   �� *ProgressRingActivated+5G   &   5H      5I      5J      5K      