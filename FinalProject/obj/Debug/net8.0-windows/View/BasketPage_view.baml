   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FinalProject.ViewFinalProject.View  5      '    !FinalProject.View.BasketPage_view   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:FinalProject.View     5        N� Title$  BasketPage_view��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   .+�5   
   � $��0��6   
����d�$��30 30 30 30q�68   .+�5      �� $��StepApp��6   $	��130(�6'   
�������$��
UltraLight"�6K   $��220,10,0,-10q�6d   6}   5      � 5U   
   $��1��6   
��� ���.+�5V      ��  � DataContext 6   �� *SelectedProduct+.+�5X      �� -   5        $��ProductName��5X      
�������$��35��6`   $	��300��6l   $
��Left=�6x   $��
10 10 10 0q�6�   ��6/   �� *ProductName+6�   �� 5Z      -   5        $��ProductQuantity��5Z      
�������$��35��6b   $	��300��6n   $
��Left=�6z   $��
10 10 10 0q�6�   ��64   �� *
Quantity+6�   �� 5\      -   5        $��ProductPrice��5\      
�������$��35��6[   $	��300��6g   $
��Left=�6s   $��
10 10 10 0q�6�   ��60   �� *Price+6�   5_      5b      � 5f      $��2��6   .+�5h      ��  �� Orientation$ Vertical=�6   $��Right=�64   $
��0,10q�6P   .+�5i      �� $��Total Price��6   $	��150��63   $��50��6?   
����� �
���   �$
��0,10q�6p   �� 5j      $��Checkout��6   $	��150��60   $��50��6<   
����� �
���   �6Z   5m      �� 5n      -   5        $��40��5n      
����d�$
��back��6A   $��30(�6P   $��
UltraLight"�6^   $
��Left=�6v   $	��150��6�   $��0 200 250 0q�6�   5p      5r      5v      5w      