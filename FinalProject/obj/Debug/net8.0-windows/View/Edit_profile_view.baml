   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FinalProject.ViewFinalProject.View  5      )    #FinalProject.View.Edit_profile_view   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:FinalProject.View     5        N� Title$  Edit_profile_view��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   � $��0��6   
����d�$��30 30 30 30q�68   $��2��6M   .+�5      �� $��StepApp��6   $	��130(�6'   
�������$��
UltraLight"�6K   $��220,10,0,-10q�6d   6}   5      � 5   
   $��1��6   .+�5       �� .+�5"      � .+�5%      �� -   5        $��PlaceholderNameText��5%       $
��Name��5&       $��15(�6,   
�������$	��Top=�5(       $��Center=�5)        J� IsHitTestVisible$ False��5*       $��	10,10,0,0q�5+       $	��300��63    K� ZIndex$ 1��5,       $y�Visible=�5-       5/      �� 51      -   5        $��NameTextBox��52      $	��300��51      $
��0,10q�6*   $��25��53      $��15(�54      
����  �$��Center=�56      $y�Visible=�58   <   
 � Tag 5:      ��  �� ElementName$ PlaceholderNameText��5>      � 5B      .+�5E      �� -   5        $��PlaceholderSurnameText��5E       $��Surname��5F       $��15(�6/   
�������$	��Top=�5H       $��Center=�5I       $ False��5J       $��	10,10,0,0q�5K       $	��300��63   $ 1��5L       $y�Visible=�5M       5O      �� 5Q      -   5        $��SurnameTextBox��5R      $	��300��5Q      $
��0,10q�6*   $��25��5S      $��15(�5T      
����  �$��Center=�5V      $y�Visible=�5X   <    5Z      �� $ PlaceholderSurnameText��5^      � 5c      .+�5f      �� -   5        $��PlaceholderEmailText��5f       $��Email��5g       $��15(�6-   
�������$	��Top=�5i       $��Center=�5j       $ False��5k       $��	10,10,0,0q�5l       $	��300��63   $ 1��5m       $y�Visible=�5n       5p      �� 5r      -   5        $��EmailTextBox��5s      $	��300��5r      $
��0,10q�6*   $��25��5t      $��15(�5u      
����  �$��Center=�5w      $y�Visible=�5y   <    5{      �� $ PlaceholderEmailText��5      � 5�      .+�5�      �� -   5        $��PlaceholderPasswordText��5�       $��Email��5�       $��15(�6-   
�������$	��Top=�5�       $��Center=�5�       $ False��5�       $��	10,10,0,0q�5�       $	��300��63   $ 1��5�       $y�Visible=�5�       5�      �� 5�      -   5        $��PasswordTextBox��5�      $	��300��5�      $
��0,10q�6*   $��25��5�      $��15(�5�      
����  �$��Center=�5�      $y�Visible=�5�   <    5�      �� $ PlaceholderPasswordText��5�      �� 5�      -	   5        $
��Save��5�      $	��100��6(   $��40��64   
����d�
�������$
��Bold"�6o   6�   �� 5�      -
   5        $��50��5�      
����d�$
��back��6A   $��35(�6P   $��
UltraLight"�6^   $
��Left=�6v   $	��150��6�   $��	0 0 250 0q�6�   5�      5�      5�      5�      5�      