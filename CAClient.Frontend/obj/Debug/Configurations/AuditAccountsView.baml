   M S B A M L   `   `   `  ����  CAClient.Frontend8    2CAClient.Frontend.Configurations.AuditAccountsView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Accounts Audit Types��5   	   $	��500��6&   $	��600��63    � 
ResizeMode$ NoResize=�6?    � WindowStartupLocation$ CenterScreen=�6U    � 	Resources 5       �� 
TargetType   DefaultTextBoxStyle �� BasedOn  ControlLabelStyle  DefaultButtonStyle��%�   '��       7   '�� "     7  '�� D     7  �� 5   
   " ��6   8   6%   �� 5   
   " ��6   8   6'   �� 5   
   " ��6   8   6$   5	      .��5
      �� .+�5   
   �� $5��/Who are required to get their accounts audited?��6   .��5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0 10 0 0q�66   .+�5      �� $��Accounts Type��6     �� TextAlignment$
 Left=�65   $	��150��6J   �� 5      $	��200��6H   $��Center=�6T   ��6   �� *AccountType.AccountsType+6T   5      �� 5      $ 
Horizontal=�6   $��0 10 0 0q�66   .+�5      �� $��Account Type Code��6    $
 Left=�69   $	��150��6N   �� 5      $	��200��6L   $��Center=�6X   ��6   �� *AccountType.AccountsTypeCode+6X   5      �� 5      $ 
Horizontal=�6   $��0 10 0 0q�66   .+�5      �� $��Limit��6    $
 Left=�6-   $	��150��6B   �� 5      $	��200��6A   $��Center=�6M   ��6   �� *AccountType.Limit+6M   5      �� 5      $��0 10 0 0q�6   .+�5      �� $
��Save��6   $��50��6,   ��67   �� *SaveAccountTypeCommand+5      �� 5      $��0 10 0 0q�6   .+�5      �� -   5        $��lstProducts��5   *   $��5q�6   $	��200��6f   $
��Auto=�6s   $
��Auto=�5       �� AlternationCount$ 2��5      ��5   =   �� *AudtAccountTypes+	 � ContextMenu	 5       �� 5!      .@�5"   "   m� $��Edit Accounts Audited��6+   m� 5#   "   $��Delete Accounts Audited��6+   5$      
 �� View
 5&      �� 5'      P�5(   "   �� 5)   &   $��Id��65    �� Width$ 50��6j    �� DisplayMemberBinding 6A   ��  �� Path$ Id�6j   �� 5*   &   $��Account Type��65   $	 100��6~    6K   �� $ AccountsType�6~   �� 5+   &   $��Account Code��65   $	 100��6�    6K   �� $ AccountsTypeCode�6�   �� 5,   &   $��Limit��65   $	 100��6p    6D   �� $ Limit�6p   �� 5-   &   $��Last Updated��65   $	 100��6}    6K   �� $ LastUpdated�6}   5/      51      52      53      54      55      56      