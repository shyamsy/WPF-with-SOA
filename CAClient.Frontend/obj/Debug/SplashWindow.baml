   M S B A M L   `   `   `  ����  CAClient.Frontend$    CAClient.Frontend.SplashWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  SplashWindow��5   	    � SizeToContent$ WidthAndHeight=�5   	    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������ .��5      � .+�5   
   ��  �� CornerRadius$ 10��5      
�������$��1q�5       J� SnapsToDevicePixels . $��	0 0 10 10q�5      
����  � �� Padding$ 10q�5      	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   Color$

 Gray��5         
BlurRadius$ 10Q�5      ._�5      �� .+�5      �� $)��#Complex Situation, Simple Solution ��5      
�������$��14(�5      $
��Bold"�5      $��Center=�5      $	��Top=�5       $��	0 10 0 10q�5!      �� 5"      $	��278��5#      $��80��6!   ��5$      �� 5%       �� 	UriSource$! Resources/Images/CALogo.jpg?�5&      5(      �� 5)      -   5         ��Name$ lblProgress��5*      $��Loading.��5+      
�������$
��Bold"�5-      $
��Left=�5.      $	��Top=�5/      $��	0 10 0 10q�50      � 51      $��20��52      $��Stretch=�53       � IsIndeterminate . 54      55      56      57      58      