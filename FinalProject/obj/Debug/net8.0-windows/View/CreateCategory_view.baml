   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FinalProject.ViewFinalProject.View  5      +    %FinalProject.View.CreateCategory_view   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:FinalProject.View     5        N� Title$  CreateCategory_view��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   .+�5   
   � $��0��6   
����d�$��30 30 30 30q�68   .+�5      �� $��StepApp��6   $	��130(�6'   
�������$��
UltraLight"�6K   $��220,10,0,-10q�6d   6}   5      � 5   
   $��1��6   .+�5       �� .+�5"      � $��2��6   .+�5$      �� -   5         ��Name$! PlaceholderCategoryNameText��5$       $
��Name��5&       $��15(�5'       
�������$	��Top=�5)       $��Center=�5*        J� IsHitTestVisible$ False��5+       $��	10,10,0,0q�5,       $	��500��63    K� ZIndex$ 1��5-       $y�Visible=�5.        +� FocusedElement 5%       Z� 51      �� 54      -   5         ��Name$ NameTextBox��54      $��Center=�55      $��30��56      $	��500��57      $��15(�58      $��0,10,0,0q�59      
����  �$��2q�5;      $y�Visible=�5=   <   
 � Tag 5?      ��  �� ElementName$! PlaceholderCategoryNameText��5C      � 5H      $��2��6   .+�5J      �� -   5        $% PlaceholderCategoryQuantityText��5J       $��Quantity��5L       $��15(�5M       
�������$	��Top=�5O       $��Center=�5P       $ False��5Q       $��	10,10,0,0q�5R       $	��500��63   $ 1��5S       $y�Visible=�5T        5K       Z� 5W      �� 5Z      -   5        $ QuantityTextBox��5Z      $��Center=�5[      $��30��5\      $	��500��5]      $��15(�5^      $��0,10,0,0q�5_      
����  �$��2q�5a      $y�Visible=�5c   <    5e      �� $% PlaceholderCategoryQuantityText��5i      � 5o      $��2��6   .+�5q      �� -   5        $( "PlaceholderCategoryDescriptionText��5q       $��Description��5s       $��15(�5t       
�������$	��Top=�5v       $��Center=�5w       $ False��5x       $��	10,10,0,0q�5y       $	��500��63   $ 1��5z       $y�Visible=�5{        5r       Z� 5~      �� 5�      -   5        $ DescriptionTextBox��5�      $��Center=�5�      $��30��5�      $	��500��5�      $��15(�5�      $��0,10,0,0q�5�      
����  �$��2q�5�      $y�Visible=�5�   <    5�      �� $( "PlaceholderCategoryDescriptionText��5�      � 5�      $��2��6   .+�5�      �� -   5        $" PlaceholderCategoryMediaText��5�       $��Media��5�       $��15(�5�       
�������$	��Top=�5�       $��Center=�5�       $ False��5�       $��	10,10,0,0q�5�       $	��500��63   $ 1��5�       $y�Visible=�5�        5�       Z� 5�      �� 5�      -   5        $ MediaTextBox��5�      $��Center=�5�      $��30��5�      $	��500��5�      $��15(�5�      $��0,10,0,0q�5�      
����  �$��2q�5�      $y�Visible=�5�   <    5�      �� $" PlaceholderCategoryMediaText��5�      5�      5�      � 5�      $��3��6   .+�5�      �� .+�5�      �� -	   5        $��50��5�   %   
����d�$
��Load��6M   $��35(�6\   $��
UltraLight"�6j   $��Center=�6�   $	��500��6�   $��0 20 0 0q�6�   5�      5�      �� 5�      -
   5        $��40��5�   !   
����d�$
��back��6I   $��30(�6X   $��
UltraLight"�6f   $
��Left=�6~   $	��150��6�   $��0 20 0 0q�6�   5�      5�      5�      5�      