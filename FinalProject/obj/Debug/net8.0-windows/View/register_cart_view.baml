   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FinalProject.ViewFinalProject.View  5      *    $FinalProject.View.register_cart_view   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:FinalProject.View     5        N� Title$  register_cart_view��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   � $��0��6   
����d�$��30 30 30 30q�68   $��2��6M   .+�5      �� $��StepApp��6   $	��130(�6'   
�������$��
UltraLight"�6K   $��220,10,0,-10q�6d   6}   5      � 5   
   $��1��6   .+�5      �� .+�5!      � .+�5"      �� -   5         ��Name$ PlaceholderFinText��5"       $��XXXX-XXXX-XXXX-XXXX��5#      $��35(�5$      
�������$	��Top=�5&      $��Center=�5'       J� IsHitTestVisible$ False��5(      $��	10,10,0,0q�5)      $	��500��6-    K� ZIndex$ 1��5*      $y�Visible=�5+      �� 5-      -   5        $��
FinTextBox��5.      $��50��5-      $	��750��6*   $��35(�5/      
����  �$��Right=�51      $y�Visible=�53   8   
 � Tag 55      ��  �� ElementName$ PlaceholderFinText��.��6I   57      59      � 5>      .+�5@      �� -   5        $ PlaceholderExpireText��5@       $��Expire Data��5A      $��35(�5B      
�������$��Center=�5D      $��Right=�5E      $ False��5F      $��	10,10,0,0q�5G      $	��550��6.   $ 1��5H      $y�Visible=�5I      �� 5N      -   5        $��ExpireTextBox��5O      $��50��5N      $	��550��6*   $��35(�5P      $��0 20 0 0q�5Q      
����  �$��Right=�5R      $y�Visible=�5T   8    5V      �� $ PlaceholderExpireText��.��6L   5X      5Z      � 5^      .+�5a      �� -   5        $ PlaceholderCVCText��5a       $	��CVC��5b      $��35(�5c      
�������$��Center=�5e      $��Right=�5f      $ False��5g      $��	10,10,0,0q�5h      $	��350��6,   $ 1��5i      $y�Visible=�5j      �� 5s      -   5        $��
CVCTextBox��5t      $��50��5s      $	��350��6*   $��35(�5u      $��0 20 0 0q�5v      
����  �$��Right=�5w      $y�Visible=�5y   8    5{      �� $ PlaceholderCVCText��5|      5      5�      5�      � 5�   
   $��2��6   .+�5�      �� -   5        $	��150��5�      
����d�$
��Save��6=   $��35(�6L   $��
UltraLight"�6Z   $��Right=�6r   $��	0 20 30 0q�6�   $��51��6�   $	��Top=�6�   �� 5�      -   5        $��50��5�      
����d�$
��back��6=   $��35(�6L   $��
UltraLight"�6Z   $
��Left=�6r   $	��150��6�   $��	0 0 250 0q�6�   5�      5�      5�      5�      