   M S B A M L   `   `   `  ����  CAClient.Frontend0    *CAClient.Frontend.Configurations.AddCAView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$(  "Add New Charter Accountant Details��5   	    � SizeToContent$ Height=�64   $	��800��6K    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�6.    � 	Resources 5       �� 
TargetType   DefaultTextBoxStyle �� BasedOn  ControlLabelStyle  DefaultButtonStyle��%�   '��       7   '�� "     7  '�� D     7  �� 5   
   " ��6   8   6%   �� 5   
   " ��6   8   6'   �� 5	   
   " ��6   8   6$   5
      .��5      ��   ContentBorderStyle#��[ 6   ._�5   
   �� $��Add New CA Details��6   $��10 10 10 10q�6/   .��5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0 10 0 0q�66   .+�5      �� .+�5      �� 
����  �$��30��63   ._�5      �� 
�������$��15(�6<   $��10 2 0 0q�6J   CA Personal Details6q   5      �� 5      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5      �� $��CA Name��6(    �� TextAlignment$
 Left=�67   $	��100��6L   �� 5      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   5      �� 5      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5      �� $��Father's Name��6(   $
 Left=�6=   $	��100��6R   �� 5      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   5      �� 5      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5      �� $	��PAN��6(   $
 Left=�63   $	��100��6H   �� 5      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   5      �� 5      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5       �� $��Gender��6(   $
 Left=�66   $	��100��6K   �� 5!      $	��200��6'   $��26��63   .@�5"   "   �� 
	 � Tag$
	 Male��6/   
 �� 
IsSelected
 . .��6L   Male6R   �� 5#   "   $	 Female��6/   .��6<   Female6D   5$      5%      �� 5&      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5'      �� $��Date of Birth��6(   $
 Left=�6=   $	��100��6R   �� 5(      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   5)      �� 5*      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5+      �� $��Status��6(   $
 Left=�66   $	��100��6K   �� 5,      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   5-      �� 5.      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5/      �� $��Address��6(   $
 Left=�67   $	��100��6L   �� 50      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   51      �� 52      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�53      �� $
��City��6(   $
 Left=�64   $	��100��6I   �� 54      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   55      �� 56      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�57      �� $��State��6(   $
 Left=�65   $	��100��6J   �� 58      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   59      �� 5:      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5;      �� $��Country��6(   $
 Left=�67   $	��100��6L   �� 5<      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   5=      �� 5>      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5?      �� $	��PIN��6(   $
 Left=�63   $	��100��6H   �� 5@      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   5A      �� 5B      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5C      �� $��Mobile��6(   $
 Left=�66   $	��100��6K   �� 5D      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   5E      �� 5F      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5G      �� $��Phone��6(   $
 Left=�65   $	��100��6J   �� 5H      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   5I      �� 5J      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5K      �� $��Email��6(   $
 Left=�65   $	��100��6J   �� 5L      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   5M      5N      �� 5O      $��	100 0 0 0q�6!   .+�5P      �� 
����  �$��30��63   ._�5Q      �� 
�������$��15(�6;   $��10 2 0 0q�6I   CA Designation Details6s   5R      �� 5S      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5T      �� $��Designation��6(   $
 Left=�6;   $	��100��6P   �� 5U      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   5V      �� 5W      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5X      �� $��
Department��6(   $
 Left=�6:   $	��100��6O   �� 5Y      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   5Z      �� 5[      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5\      �� $��Manager��6(   $
 Left=�67   $	��100��6L   �� 5]      $	��200��6U   $��Center=�6a   ��6&   �� *CharterAccountantModel.CaName+6a   5^      �� 5_      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5`      �� $��Is Power User?��6(   $
 Left=�6>   $	��100��6S   �� 5a       d� 	IsChecked$
 TrueY�6'   6:   5b      �� 5c      $ 
Horizontal=�6%   $��0 10 0 0q�6>   .+�5d      �� $��Active��6(   $
 Left=�66   $	��100��6K   �� 5e      $
 TrueY�6'   6:   5f      5g      5h      �� 5i      $��0 0 20 0q�6   .+�5j      �� $
��Save��6   $��30��6,   $��60��68   $��Right=�6C   5k      5l      5m      5n      5o      