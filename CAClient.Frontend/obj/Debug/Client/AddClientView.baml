   M S B A M L   `   `   `  ����L  HCAClient.Frontend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:CAClient.Frontend.ClientCAClient.Frontend.Client  5   
   ,    &CAClient.Frontend.Client.AddClientView   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   7view&clr-namespace:CAClient.Frontend.Client     5   
   $	��500��5   "   $	��500��6/     � 
ResizeMode$  NoResize=�6;    � WindowStartupLocation$ CenterScreen=�6Q    � Title 6	   �� *Title+ � DataContext 5      1   +CAClient.Frontend.Client.AddClientViewModel  5   
    � 	Resources 5	       �� 
TargetType   DefaultTextBoxStyle �� BasedOn  ControlLabelStyle  DefaultButtonStyle��%�   '��       7   '�� "     7  '�� D     7  �� 5
   
   " ��6   8   6%   �� 5   
   " ��6   8   6'   �� 5   
   " ��6   8   6$   5      .��5      ��   ContentBorderStyle#��[ 6   ._�5   
   �� .+�5      �� .+�5      �� $��
10 10 0 10q�64   ��6   �� *Title+.��5      �� .+�5      �� 
����  �$��30��63   $��0 10 0 0q�6?   ._�5      �� 
�������$��15(�6<   $��10 2 0 0q�6J   Client Details6l   5      �� 5       �� Orientation$ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5      �� $��
First Name��6(    �� TextAlignment$
 Left=�6:   $	��100��6O   �� 5      $	��200��6Q   $��Center=�6]   ��6&   �� *ClientInfoModel.FirstName+6]   5      �� 5      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5      �� $��Middle Name��6(   $	��100��6;   �� 5      $	��200��6R   ��6&   �� *ClientInfoModel.MiddleName+6R   5      �� 5      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5      �� $��	Last Name��6(   $	��100��69   �� 5       $	��200��6P   $��Center=�6\   ��6&   �� *ClientInfoModel.LastName+6\   5!      �� 5"      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5#      �� $��	Phone No.��6(   $	��100��69   �� 5$      $	��200��6S   ��6&   �� *ClientInfoModel.PhoneNumber+6S   5%      �� 5&      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5'      �� $��Address��6(   $	��100��67   �� 5(      $	��200��6O   ��6&   �� *ClientInfoModel.Address+6O   5)      �� 5*      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5+      �� $
��City��6(   $	��100��64   �� 5,      $	��200��6L   ��6&   �� *ClientInfoModel.City+6L   5-      �� 5.      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5/      �� $��Country��6(   $	��100��67   �� 50      -   5        $��	ComboBox1��50   '   $	��200��68   $��30��6D   $	��Top=�6Q   $
��Left=�6i   ��6�   �� *CountryDetails+��51   "   �� 52   &   .R�53   *   �� $ 
Horizontal=�65   .+�54   .   �� ��68   �� *	CountryId+�� 55   .   ��68   �� *Name+56   +   57   '   59      5:      �� 5;      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5<      �� $��State��6(   $	��100��65   �� 5=      $	��200��6M   ��6&   �� *ClientInfoModel.State+6M   5>      �� 5?      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5@      �� $��Pin Code��6(   $	��100��68   �� 5A      $	��200��6O   ��6&   �� *ClientInfoModel.PinCode+6O   5B      5C      5D      5E      �� 5F      $��0 0 20 0q�6   .+�5G      �� $
��Save��6   $��30��6(   $��60��64   $��Right=�6?   ��6[   �� *AddClientDataCommand+5H      5I      5J      5K      