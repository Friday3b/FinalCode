   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FinalProject.ViewFinalProject.View  5      &     FinalProject.View.myprofile_view   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:FinalProject.View     5        N� Title$  myprofile_view��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   .+�5   
   � $��0��6   
����d�$��30 30 30 30q�68   .+�5      �� $��StepApp��6   $	��130(�6'   
�������$��
UltraLight"�6K   $��220,10,0,-10q�6d   6}   5      � 5   
   $��1��6   .+�5      �� .+�5      � .+�5      �� -   5         ��Name$ PlaceholderEmailText��5       $��Email��5!      $��35(�5"      
�������$	��Top=�5$      $��Center=�5%       J� IsHitTestVisible$ False��5&      $��0,52,0,0q�5'      $	��500��6*    K� ZIndex$ 1��5(       $y�Visible=�5)        +� FocusedElement 5       Z� 5)       �� 5-      -   5         ��Name$ EmailTextBox��5-      $��Center=�5.      $��50��5/      $	��500��50      $��35(�51      $��	0 50 0 20q�52      
����  �$��2q�54      $y�Visible=�56   4   
 � Tag 58      ��  �� ElementName$ PlaceholderEmailText��5;      5>      5A      � 5E   
   $��1��6   $��Bottom=�6   $��0 0 0 40q�67   .+�5F      �� .+�5H      � $��0,10,0,0q�6   .+�5I      �� -   5        $ PlaceholderPasswordText��5I       $��Password��5J       $��35(�5K       
�������$	��Top=�5M       $��Center=�5N       $ False��5O       $��	10,10,0,0q�5P       $	��500��63   $ 1��5Q       $y�Visible=�5R       G� 5S      -   5        	 G�Name$	 PasswordTextBox��5S   "   $��Center=�5T      $��50��5U      $	��500��5V      $��35(�5W      $��0,10,0,0q�5X      
����  �$��2q�5Z       5^      �� $ PlaceholderPasswordText��5_      5f      5i      � 5l   
   $��3��6   $	��Top=�6   .+�5n      �� .+�5o      �� -   5        $��50��5o      
����d�$��Sign in��6A   $��35(�6S   $��
UltraLight"�6a   $��Center=�6y   $	��500��6�   
 �� 	IsDefault$

 True��6�   5q      �� 5t      -   5        $��50��5t      
����d�$��Sign up��6A   $��35(�6S   $��
UltraLight"�6a   $��Right=�6y   $	��150��6�   $��
0 80 250 0q�6�   5v      �� 5y      -   5        $��50��5y      
����d�$
��back��6A   $��35(�6P   $��
UltraLight"�6^   $
��Left=�6v   $	��150��6�   $��	0 0 250 0q�6�   5{      5      5�      5�      5�      