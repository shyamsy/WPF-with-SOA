   M S B A M L   `   `   `  ����  CAClient.Frontend/    )CAClient.Frontend.Login.CaClientLoginView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$"  CA Client Coordination Login��5   	    � SizeToContent$ WidthAndHeight=�6.    � WindowStartupLocation$ CenterScreen=�6M    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5       �� 
TargetType   DefaultTextBoxStyle �� BasedOn  ControlLabelStyle  DefaultButtonStyle��%�   '��       7   '�� "     7  '�� D     7  �� 5   
   " ��6   8   6%   �� 5   
   " ��6   8   6'   �� 5	   
   " ��6   8   6$   5
      .��5      ��   ContentBorderStyle#��[ 6   ._�5   
   �� $��10 10 10 10q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0 10 0 0q�62   .+�5      �� .+�5      �� 
����  �$��30��6/   ._�5      �� 
�������$��15(�68   $��50 2 0 0q�6F   CA Client Coordination Login6v   5      �� 5      $ 
Horizontal=�6!   $��0 10 0 0q�6:   .+�5      �� $��	User Name��6$    �� TextAlignment$
 Left=�65   $��70��6J   �� 5      $	��200��6Q   $��Center=�6]   ��6"   �� *CharterAccountantModel.CaName+6]   5      �� 5      $ 
Horizontal=�6!   $��0 10 0 0q�6:   .+�5      �� $��Password��6$   $
 Left=�64   $��70��6I   �� 5      $	��200��6Q   $��Center=�6]   ��6"   �� *CharterAccountantModel.CaName+6]   5      5      5      �� 5      $��0 10 0 0q�6   $ 
Horizontal=�6+   $��Center=�6D   .+�5      �� $��Login��6   $��30��6)   $��60��65   $��Center=�6@   ��6]   �� *LoginCommand+5      5      5       5!      