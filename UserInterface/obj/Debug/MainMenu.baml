   M S B A M L   `   `   `  ����H  DUserInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:UserInterfaceUserInterface  5          UserInterface.MainMenu   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:UserInterface     5        N� Title$  MainMenu��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      .+�5   
   �� 
�������.+�5      �� $��35(�6   $
��Bold"�6&   $��Center=�68   	Main Menu6`   5      �� 5   
   
�������$��1��6(    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6   .�5      ��  � ��$	 400��6/   �� 5       � ��$ 60��60   �� 5       � ��$ 30(�62   �� 5       � ��$ 0,15,0,0q�60   �� 5       � ��$ 1q�69   5      5      .+�5      ��  �� Orientation$ 
Horizontal=�6   $��
125,10,0,0q�62   .+�5      �� $��20(�6   $
��Bold"�6&   .��69   	Server:6B   �� 5      -   5        $��uxServer��5   4   $	��400��6   $��22(�6&   .��6D   
(LocalDb)\6P   5       �� 5!      $ 
Horizontal=�6   $��
100,5,0,50q�62   .+�5"      �� $��20(�6   $
��Bold"�6&   .��68   	Database:6C   �� 5#      -   5        $��
uxDatabase��5#   4   $	��400��6   $��22(�6&   6H   5$      �� 5%      -   5        .��5%   +   
New Trip65   �� 5&      -   5        .��5&   /   Search Trips6=   �� 5'      -   5        .��5'   2   Trip Statistics6C   5(      5)      5*      