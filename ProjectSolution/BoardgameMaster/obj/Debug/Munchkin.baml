   M S B A M L   `   `   `  ����J  FBoardgameMaster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BoardgameMasterBoardgameMaster  5   	       BoardgameMaster.Munchkin   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BoardgameMaster     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        � Title$  Munchkin��5   	   $	��450��6   $	��820��6'      MaterialDesignBody#���   5
   	   $��Regular"�5      $��18(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      �  � RowDefinitions 5      �� 5      $��3* �6   5      �� 5      $	��10* �6   6"   �� 5      $
��0.7* �6   6#   .+�5      �� -   5        $��	addPlayer��5      $��0��6   $��50��6)   $��50��65   $��30(�6@   $��+��6N   $��
0, 0, 0, 0q�6[   $��10,10,733.6,29.6q�6�   �� 5      -   5        $
��Save��5      $
��Auto��6   $��35(�6%   $
��Save��63   $��445,10,198.6,26.4q�6B   6]   �� 5      -   5        $
��Load��5      $
��Auto��6   $��35(�6%   $
��Load��63   $��625,10,18.6,26.4q�6B   6\   �� 5      $��Disabled=�6   $��Visible=�6;   $��1��6a   .��5      � -   5        $��Field��5      $
��Auto��6    �� Left$ 10��6+   
 �� Top$ 85��6<    � Orientation$ 
Horizontal=�6L   5      5      5       5!      