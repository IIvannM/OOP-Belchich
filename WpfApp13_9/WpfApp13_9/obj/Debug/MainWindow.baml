   M S B A M L   `   `   `  ����E  AWpfApp13_9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WpfApp13_9
WpfApp13_9  5   	       WpfApp13_9.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WpfApp13_9     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��30* �6   �� 5      $��9* �6   �� 5      $
��461* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ sliderSourse��5       � Value$ 18Q�6'    � Maximum$ 80Q�62    � Minimum$ 1Q�6?    �� TickFrequency$ 2Q�5       �� TickPlacement$
 Both=�6#   $��0��5      $��5,5,5,5q�6   	 �� AutoToolTipPlacement$	 TopLeft=�6/   $��3��6N   ]� 5   
   $��1��6   $��3��6!   .+�5      �� -   5        
 ��Name$
 
colorsList��5      $
��Left=�6*   $	��150��6@    �� SelectedIndex$ 0��6L   .@�5      �� $��Черный��6   
 � Tag$ #Black��6/    �� 
IsSelected . $
��Bold"�6N   �� 5      $��Красный��6   $	 Red��60   $
��Bold"�6:   
���  ��6L   �� 5      $��Зеленый��6   $ Green��60   $
��Bold"�6<   ���	#FF00BF036N   �� 5      $��
Синий��6   $
 Blue��6.   $
��Bold"�69   ���	#FF0004F76K   �� 5      $��Розовый��6   $
 Pink��60   $
��Bold"�6;   ���	#FFFD00FF6M   �� 5      $��Оранжевый��6   $ Orange��62   $
��Bold"�6?   
��� ���6Q   �� 5       $��Фиолетовый��6   $ Purple��63   $
��Bold"�6@   
���� ��6R   �� 5!      $��Желтый��6   $ Yellow��6/   $
��Bold"�6<   ���	#FFCCCC006N   5"      �� 5#      -   5        $
 
stylesList��5#      $ 0��6*   $	��100��6<   .@�5$      �� $��Normal��6   $ Normal��6/   �� 5%      $��Italic��6   $ Italic��6/   $��Italic$�6<   �� 5&      $
��Bold��6   $
 Bold��6-   $
��Bold"�68   5'      �� 5(      -   5         ��Name$ 
textTarget��5(      $��Right=�6,    �� TextAlignment$ Center=�5)      $��Center=�6/   ��5*      �� *Value+ �� ElementName$ sliderSourse�� �� Mode$ TwoWay=���5+      �� *SelectedItem.Tag+$ 
colorsList����5,      �� *SelectedItem.Tag+$ 
stylesList����5-      �� *SelectedItem.Tag+$ fontFamilyCombo��5/      �� 50   
   -   5         ��Name$ textSourseText��50      $��Text Example��6*   $��1��6>   $��3��6K   $��	0,296,0,0q�6_   $��2��6r   �� 52   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $
��Left=�6;   $��
20,34,0,-3q�6V   $��2��6j   $��3��6{   $	��770��6�   .+�53      �� -   5         ��Name$ normalButton��53      $��Default Size��6+   $��15q�6B   $	��100��6N   ���	#FF56A0BF
�������54   I   �� 55      -   5        $ maximizeButton��55      $��Maximize Size��6-   $��15q�6E   $	��100��6Q   ���	#FF56A0BF
�������56   K   �� 57      -   5        $ minimizeButton��57      $��Minimize Size��6-   $��15q�6E   $	��100��6Q   ���	#FF56A0BF
�������58   K   �� 59      -	   5         ��Name$ fontFamilyCombo��59      $ 0��60   $��20��6B   $��150,15,15,15q�6N   $	��144��6d   .@�5:      �� $��Times New Roman��6   $ Times New Roman��69   $��Times New Roman)�6O   �� 5;      $��Arial��6   $ Arial��6/   $��Arial)�6;   �� 5<      $��Tahoma��6   $ Tahoma��60   $��Tahoma)�6=   �� 5=      $��
Arial Bold��6   $ 
Arial Bold��64   $��
Arial Bold)�6E   �� 5>      $��Algerian��6   $ Algerian��62   $��Algerian)�6A   �� 5?      $��Blackadder ITC��6   $ Blackadder ITC��68   $��Blackadder ITC)�6M   �� 5@      $��Cooper Black��6   $ Cooper Black��66   $��Cooper Black)�6I   �� 5A      $��Haettenschweiler��6   $ Haettenschweiler��6:   $��Haettenschweiler)�6Q   5B      5C      5D      5E      