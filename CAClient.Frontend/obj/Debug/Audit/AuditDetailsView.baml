   M S B A M L   `   `   `  ����  CAClient.Frontend.    (CAClient.Frontend.Audit.AuditDetailsView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Audit Details��5   	   $	��600��6   $
��1200��6,    � WindowStartupLocation$ CenterScreen=�69    � 
ResizeMode$ NoResize=�6^   .��5      ��    ContentBorderStyle#��[  6   ._�5   
   ��  � 	Resources 5       �� 
TargetType  myControlTemplateStyle �� BasedOn �� Property �� Value  	TextBrush  ContentFontFamily  ContentFontSize&   System.Windows.Media.TextOptions �� Triggers	 P� Property
 P� Value��%�  '��       7  '�� "     7  7  7  �� 5      " ��6   8   6:   �� 5	      " ��6   .�5
      ��  � ��
 ���� 63   �� 5       � ��$ Stretch=�6C   �� 5       � ��$ Stretch=�6A   �� 5       � ��8   63   �� 5       � ��8  63   �� 5       � ��8  61   �� 5       �@ TextHintingMode$ Animated=�6D   �� 5       � �� .  62    5      P� 5      	 �@��AlternationIndex$
 0��6L   . �5      ��  � ��
 ��ح�6;   5      P� 5      	 �@��AlternationIndex$
 1��6L   . �5      ��  � ��
 �����6;   5      P� 5      	 �@J�IsMouseOver
 . . �5      ��  � ��
 ��  �6;   �� 5       � ��
 �����6;   5      5      5      .+�5       �� .+�5!      �� $��Audit Details��6   .��5"      �� .+�5#      �� .+�5$      �� 
����  �$��30��67   $��0 10 0 0q�6C   ._�5%   "   �� 
�������$��15(�6@   $��10 2 0 0q�6N   Audit Details6o   5&      5'      �� 5(      .+�5)      �� -   5        $��lstProducts��5)   2   $��5q�6'   $	��500��6j   $
��Auto=�6w   $
��Auto=�5*       �� AlternationCount$ 2��5+      ��5)   E   �� *AuditRecords+ �� SelectedItem 5*   G   �� *AuditRecord+ � ContextMenu 5,   "   �� 5-   &   .@�5.   *   m� $��Edit Audit Detail��63    m� Command 6N   �� *EditAuditDetailCommand+m� 5/   *   $��Delete Audit Detail��63    6P   �� *DeleteAuditDetailCommand+50   '    �� View 52   "   �� 53   &   P�54   *   �� 55   .   $��Audit Id��6=    �� Width$	 100��6}    �� DisplayMemberBinding 6O   ��  �� Path$ AuditId�6}   �� 56   .   $��	Client Id��6=   $	 100��6    6P   �� $ ClientId�6   �� 57   .   $��TuronOver Money��6=   $	 150��6�    6V   �� $ TuronOverMoney�6�   �� 58   .   $��Audit Required��6=   $	 120��6�    6U   �� $ AuditRequired�6�   �� 59   .   $��Audit Start Date��6=   $	 150��6�    6W   �� $ AuditStartDate�6�   �� 5:   .   $��Audit End Date��6=   $	 150��6�    6U   �� $ AuditEndDate�6�   �� 5;   .   $��Country��6=   $	 100��6|    6N   �� $ Country�6|   �� 5<   .   $��
Audited By��6=   $	 150��6    6Q   �� $ AuditBy�6   �� 5=   .   $��	Audit Fee��6=   $	 100��6    6P   �� $ AuditFee�6   5?   '   5A      5B      5C      5D      5E      5F      5G      5H      