   M S B A M L   `   `   `  ����  CAClient.Frontend3    -CAClient.Frontend.Configurations.TurnoverView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Turnover Types��5   	   $	��400��6    $	��600��6-    � 
ResizeMode$ NoResize=�69    � WindowStartupLocation$ CenterScreen=�6O    � 	Resources 5       �� 
TargetType   DefaultTextBoxStyle �� BasedOn  ControlLabelStyle  DefaultButtonStyle��%�   '��       7   '�� "     7  '�� D     7  �� 5   
   " ��6   8   6%   �� 5   
   " ��6   8   6'   �� 5   
   " ��6   8   6$   5	      .��5
      �� .+�5   
   �� $��Turnover Types��6   .��5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0 10 0 0q�66   .+�5      �� $��Turnover Types��6     �� TextAlignment$
 Left=�66   $	��100��6K   �� 5      $	��200��6J   $��Center=�6V   ��6   �� *TurnoverModel.TurnoverType+6V   5      �� 5      $��0 10 0 0q�6   .+�5      �� $
��Save��6   $��50��6,   ��67   �� *SaveTurnoverCommand+5      �� 5      $��0 10 0 0q�6   .+�5      �� -   5        $��lstProducts��5   *   $��5q�6   $	��200��6c   $
��Auto=�6p   $
��Auto=�5       �� AlternationCount$ 2��5      ��5   =   �� *TurnoverLists+	 � ContextMenu	 5      �� 5      .@�5   "   m� $��Edit Turnover Type��6+   m� 5   "   $��Delete Turnover Type��6+   5      
 �� View
 5      �� 5      P�5    "   �� 5!   &   $��Id��65    �� Width$ 50��6j    �� DisplayMemberBinding 6A   ��  �� Path$ Id�6j   �� 5"   &   $��Turover Type��65   $	 100��6~    6K   �� $ TurnoverType�6~   �� 5#   &   $��Last Updated��65   $	 100��6}    6K   �� $ LastUpdated�6}   5%      5'      5(      5)      5*      5+      5,      