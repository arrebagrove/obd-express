   M S B A M L   `   `   `  ����E  AObdExpress, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ObdExpress.Ui.UserControlsObdExpress.Ui.UserControls  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      M ISystem, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089A-clr-namespace:System.IO.Ports;assembly=SystemSystem.IO.Ports 5      C    =ObdExpress.Ui.UserControls.TroubleCodePanels.TroubleCodePanel   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7uc(clr-namespace:ObdExpress.Ui.UserControls     5      6sys&clr-namespace:System;assembly=mscorlib     5      ?ports-clr-namespace:System.IO.Ports;assembly=System     5        � 	Resources  5         parities S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName  stopbits��%�   &	        &	 h     S� 5   
   $ GetNames��6.   "  6D    5      M� 5      $ ports:Parity��6   5      S� 5   
   $ GetNames��6.   "  6D    5      M� 5      $ ports:StopBits��6   5      5      ��5      �� 5   
    �� Color$ White��6   .��5      �� 
���   �$	��1.0q�6!   
������  J� SnapsToDevicePixels . ._�5   
   � -   5         �Name$ MainPanelGrid��5      $
��Auto��6&   $��Stretch=�64    � RowDefinitions 5      �� 5       $
��Auto �6    �� 5!      $��* �6    .+�5$      �� 
���   �$��0,0,0,1q�6)   $��0��6C    . ��5%      �� 5&      	 �� 
StartPoint$	 0.5,0&�6*   
 �� EndPoint$
 0.5,1&�6=   .��5'      �  � Color$ 	#FF838383��6'    � Offset$ 0Q�69   � 5(      $ 	#FF666666��6'   $ .5Q�69   � 5)      $ 	#FF474747��6'   $ 1Q�69   5*      ._�5,      ]�  � DataContext 6   ��  �� Mode$ OneWay=� �� RelativeSource �� *FindAncestor+ �� AncestorType" >� �� AncestorLevel$ 1��.+�5-      �� 
�������$
��Left=�6I   $��5,4,0,4q�6_   $��Center=�6q   ��6   �� *Title+6q   o� 5.      $��Right=�6   $��Right=�62   
������ .@�5/      m� $��0q�6#   ��50      �� 51   "    �� Orientation$ 
Horizontal=�6-   .+�52   &   �� $��Options��6,   
�������$	��5,4q�6Q   $��Center=�6_   �� 53   &   $N��Hpack://application:,,,/ObdExpress;component/UI/Images/down_arrow_512.png��6,   $��16��6~   $��16��6�   $
��Fill=�6�   54   #   .@�56      m� -   5        $��Remove��56   '   67   57      58      59      5:      �� 5<      
������ $��0q�6/   
������ $��1��6\    . ._�5=      &   System.Windows.Controls.DataGrid  $��Stretch=�6   $��Stretch=�67      HeadersVisibility$
 None=�6U      Columns 5>      0  *System.Windows.Controls.DataGridTextColumn  5?      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.3* 6-     5@      $
 0.7* 6-   5B      5C      5D      5E      5F      