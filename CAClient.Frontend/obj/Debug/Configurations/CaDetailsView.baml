   M S B A M L   `   `   `  ����  CAClient.Frontend4    .CAClient.Frontend.Configurations.CaDetailsView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  CA Information Details��5   	   $	��600��6(   $
��1200��65    � WindowStartupLocation$ CenterScreen=�6B    � 
ResizeMode$ NoResize=�6g   .��5      ��    ContentBorderStyle#��[  6   ._�5   
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
 �����6;   5      5      5      .+�5       �� $��CA Information Details��6   $��0 10 0 0q�67   .��5!      �� .+�5"      �� .+�5#      �� 
����  �$��30��63   $��0 10 0 0q�6?   ._�5$      �� 
�������$��15(�6<   $��10 2 0 0q�6J   CA Information Details6t   5%      5&      �� 5'      .+�5(      �� -   5        $��lstProducts��5(   .   $��5q�6#   $	��500��6f   $
��Auto=�6s   $
��Auto=�5)       �� AlternationCount$ 2��5*      ��5(   A   �� *ClientDetail+ �� SelectedItem 5)   G   �� *ClientSelected+ � ContextMenu 5+      �� 5,   "   .@�5-   &   m� $��Edit Client��6/    m� Command 6D   �� *EditClientDetailsCommand+m� 5.   &   $��Delete Client��6/    6F   �� *DeleteClientCommand+5/   #    �� View 51      �� 52   "   P�53   &   �� 54   *   $��Id��69    �� Width$ 50��6t    �� DisplayMemberBinding 6E   ��  �� Path$ ClientId�6t   �� 55   *   $��
First Name��69   $	 100��6}    6M   �� $ 	FirstName�6}   �� 56   *   $��Middle Name��69   $	 100��6    6N   �� $ 
MiddleName�6   �� 57   *   $��	Last Name��69   $	 100��6{    6L   �� $ LastName�6{   �� 58   *   $��Address��69   $	 100��6x    6J   �� $ Address�6x   �� 59   *   $
��City��69   $	 100��6r    6G   �� $
 City�6r   �� 5:   *   $��Country��69   $	 100��6x    6J   �� $ Country�6x   �� 5;   *   $��Pin Code��69   $	 100��6y    6K   �� $ PinCode�6y   �� 5<   *   $��	Phone No.��69   $	 100��6~    6L   �� $ PhoneNumber�6~   �� 5=   *   $��Last Updated��69   $	 150��6�    6O   �� $ LastUpdated�6�   5?   #   5A      5B      5C      5D      5E      5F      5G      