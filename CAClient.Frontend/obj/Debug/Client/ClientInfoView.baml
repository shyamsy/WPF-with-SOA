   M S B A M L   `   `   `  ����L  HCAClient.Frontend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:CAClient.Frontend.ClientCAClient.Frontend.Client  5   	   -    'CAClient.Frontend.Client.ClientInfoView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <	viewModel&clr-namespace:CAClient.Frontend.Client     5   	     � Title$   Client Information Details��5   	   $	��600��6,   $
��1200��69    � WindowStartupLocation$ CenterScreen=�6F    � 
ResizeMode$ NoResize=�6k    � DataContext 5      9   3CAClient.Frontend.Client.ClientInfoDetailsViewModel  5   
   .��5	      ��    ContentBorderStyle#��[  6   ._�5
   
   ��  � 	Resources 5       �� 
TargetType  myControlTemplateStyle �� BasedOn �� Property �� Value  	TextBrush  ContentFontFamily  ContentFontSize&   System.Windows.Media.TextOptions	 �� Triggers
 P� Property P� Value��%�  '��       7  '�� "     7  7  7  �� 5      " ��6   8   6:   �� 5      " ��6   .�5      ��  � ��
 ���� 63   �� 5       � ��$ Stretch=�6C   �� 5       � ��$ Stretch=�6A   �� 5       � ��8   63   �� 5       � ��8  63   �� 5       � ��8  61   �� 5       �@ TextHintingMode$ Animated=�6D   �� 5       � �� .  62   	 5      P� 5      
 �@��AlternationIndex$ 0��6L   . �5      ��  � ��
 ��ح�6;   5      P� 5      
 �@��AlternationIndex$ 1��6L   . �5      ��  � ��
 �����6;   5      P� 5      
 �@J�IsMouseOver . . �5      ��  � ��
 ��  �6;   �� 5       � ��
 �����6;   5       5"      5#      .+�5$      �� $ ��Client Information Details��6   $��0 10 0 0q�6;   .��5%      �� .+�5&      �� .+�5'      �� 
����  �$��30��63   $��0 10 0 0q�6?   ._�5(      �� 
�������$��15(�6<   $��10 2 0 0q�6J   Client Details6l   5)      5*      �� 5+      .+�5,      �� -   5        $��lstProducts��5,   .   $��5q�6#   $	��500��6f   $
��Auto=�6s   $
��Auto=�5-       �� AlternationCount$ 2��5.      ��5,   A   �� *ClientDetail+ �� SelectedItem 5-   G   �� *ClientSelected+ � ContextMenu 5/      �� 50   "   .@�51   &   m� $��Edit Client��6/    m� Command 6D   �� *EditClientDetailsCommand+m� 52   &   $��Delete Client��6/    6F   �� *DeleteClientCommand+53   #    �� View 55      �� 56   "   P�57   &   �� 58   *   $��Id��69    �� Width$ 50��6t    �� DisplayMemberBinding 6E   ��  �� Path$ ClientId�6t   �� 59   *   $��
First Name��69   $	 100��6}    6M   �� $ 	FirstName�6}   �� 5:   *   $��Middle Name��69   $	 100��6    6N   �� $ 
MiddleName�6   �� 5;   *   $��	Last Name��69   $	 100��6{    6L   �� $ LastName�6{   �� 5<   *   $��Address��69   $	 100��6x    6J   �� $ Address�6x   �� 5=   *   $
��City��69   $	 100��6r    6G   �� $
 City�6r   �� 5>   *   $��Country��69   $	 100��6x    6J   �� $ Country�6x   �� 5?   *   $��Pin Code��69   $	 100��6y    6K   �� $ PinCode�6y   �� 5@   *   $��	Phone No.��69   $	 100��6~    6L   �� $ PhoneNumber�6~   �� 5A   *   $��Last Updated��69   $	 150��6�    6O   �� $ LastUpdated�6�   5C   #   5E      5F      5G      5H      5I      5J      5K      