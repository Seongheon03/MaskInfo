   M S B A M L   `   `   `  ����C  ?MaskInfo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:MaskInfoMaskInfo  5      P LLoadingIndicators.WPF, Version=0.0.1.0, Culture=neutral, PublicKeyToken=null\Bclr-namespace:LoadingIndicators.WPF;assembly=LoadingIndicators.WPFLoadingIndicators.WPF 5      /    )MaskInfo.Control.SearchByDrugstoreControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:MaskInfo     5      UloadinBclr-namespace:LoadingIndicators.WPF;assembly=LoadingIndicators.WPF     5      .��5
      �   � RowDefinitions  5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $	��530 �6   .+�5   
   � $��0��6   .+�5      ��    	SearchBox#��[  6Y   
 � Tag$% 약국이름을 입력하세요��5      ��5      �� *SearchedText+ �� UpdateSourceTrigger$ PropertyChanged=�.��5   (    J� InputBindings 5      �� 5      
 �� Key$ Enter��6N    �� Command 6!   �� *SearchByDrugstoreCommand+6N   .��5   )   5      5      � 5   
   $��2��6   .+�5      �� -   5         ��Name$ lvDrugstores��5      $
��1180��5      $��Center=�6$   $��Disabled=�5      
���������5   -   �� *StoresByDrugstore+��5      �� 5       .R�5!      � 5"      ��5$      �� 5%      .R�5&      �� .+�5'      �� ���#166ABA$��2q�6;    �� CornerRadius$ 20��6O   $	��549��6a   $��10 10 10 10q�6m   ._�5(   "   �� $	��100��6-   $��Center=�6:   .+�5)   &   ��  �� Orientation$ 
Horizontal=�61   $��	10 15 0 0q�6J   .+�5*   *   �� $��30��6L   ��60   �� *
ImageUrl+6L   �� 5+   *     ItemTextblock#��[ 6J   $��23(�5,   <   $
��Bold"�6J   ��5+   4   �� *Name+5,   J   5-   '   �� 5.   &   $ 
Horizontal=�61   $��	10 12 0 0q�6J   .+�5/   *   �� $��/Assets/address.png��60   $��30��6M   �� 50   *   #��[ 6J   $��16(�51   <   $	��460��6J   $
��Wrap=�6V   ��50   4   �� *Addr+51   V   52   '   53   #   54      55      56      58      �� 5:      $��Center=�5;      $��Center=�65   
�������$
��Bold"�5<   *   $��30(�6<   ��5:      �� *TbDrugstoreGuideText+y�5=      �� *TbDrugstoreGuideVisibility+  boolToVisibility	 �� 	Converter#	 [ ,  &LoadingIndicators.WPF.LoadingIndicator  5?      $��2��6&   
   
SpeedRatio$
 1Q�5@   &   
����iA�  LoadingIndicatorWaveStyle#���  5B   &      IsActive 5@   5   �� *ProgressRingActivated+5B   &   5C      5D      5E      