   M S B A M L   `   `   `  ����M  IClinicaVeterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ClinicaVeterinaria.ViewsClinicaVeterinaria.Views  5   	   2    ,ClinicaVeterinaria.Views.ClienteCadastroView   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ClinicaVeterinaria.Views     5   	     � Title$/  )Clínica Veterinária Felinos da Montanha��5   	   $	��450��69   $	��800��6F    � WindowStartupLocation$ CenterScreen=�6R    � 
ResizeMode$ NoResize=�6w    � Icon$ /Views/logo2.png��6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $��20 �6   �� 5      $��25 �6   �� 5      $��10 �6   �� 5      $��* �6   �� 5      $��30 �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   � $��1��6   $��1��6   .+�5      �� $��Novo Cliente��6   $��16(�6,   5      � 5   
   $��3��6   $��1��6!   $	��Top=�61   .+�5      ��  �� Orientation$ Vertical=�6   $	��170��60   $��50��6<   $��	0 0 10 10q�6H   .+�5      �� $��Nome*��6   $��20��6)   �� 5       �� 	MaxLength$ 45��6C   $��30��6R   ��6   �� *Controller.Cliente.Nome+6R   5       �� 5"      $ Vertical=�6   $	��230��60   $��50��6<   $��	0 0 10 10q�6H   .+�5#      �� $��
Sobrenome*��6   $��20��6.   �� 5$      $��30��6   $ 45��6&   ��5%      �� *Controller.Cliente.Sobrenome+5&      �� 5(      $ Vertical=�6   $	��290��60   $��50��6<   $��	0 0 10 10q�6H   .+�5)      �� $
��Sexo��6   $��50��6)   .��5*      �� $ 
Horizontal=�6!   .+�5+      	� $	��100��6&   $��Center=�62   $��Não Informar��6T    d� 	IsChecked$
 TrueY�6m   	� 5,      $��75��6&   $��Center=�61   $��Feminino��6S   	� 5-      $��75��6&   $��Center=�61   $��	Masculino��6S   5.      5/      50      �� 52      $ Vertical=�6   $	��100��60   $��50��6<   $��	0 0 10 10q�6H   .+�53      �� $	��CPF��6   $��20��6'   �� 54      -   5        $��30��54      $ 11��6&   ��55      �� *Controller.Cliente.CPF+6B   56      �� 58      $ Vertical=�6   $	��100��60   $��50��6<   $��	0 0 10 10q�6H   .+�59      �� $��RG��6   $��20��6&   �� 5:      -   5        $��30��5:      $ 9��6&   ��5;      �� *Controller.Cliente.RG+6A   5<      �� 5>      $ Vertical=�6   $	��100��60   $��50��6<   $��	0 0 10 10q�6H   .+�5?      �� $��Telefone��6   $��20��6,   �� 5@      $��30��6   $ 12��6&   ��65   �� *Controller.Cliente.Telefone+5A      �� 5C      $ Vertical=�6   $	��400��60   $��	0 0 10 10q�6<   .+�5D      �� $��Email��6   $��20��6)   �� 5E      $��30��6   $	 100��6&   ��66   �� *Controller.Cliente.Email+5F      �� 5H      $ Vertical=�6   $	��400��60   $��50��6<   $��	0 0 10 10q�6H   .+�5I      �� $��
Logradouro��6   $��20��6.   �� 5J      $��30��6   $ 50��6&   ��65   �� *" Controller.Cliente.EndLogradouro+5K      �� 5M      $ Vertical=�6   $	��100��60   $��50��6<   $��	0 0 10 10q�6H   .+�5N      �� $��Numero��6   $��20��6*   �� 5O      -   5        $��30��5O      $ 5��6&   ��64   �� *Controller.Cliente.EndNumero+6b   5P      �� 5R      $ Vertical=�6   $	��200��60   $��50��6<   $��	0 0 10 10q�6H   .+�5S      �� $��Bairro��6   $��20��6*   �� 5T      $��30��6   $ 30��6&   ��65   �� *Controller.Cliente.EndBairro+5U      �� 5W      $ Vertical=�6   $	��250��60   $��50��6<   $��	0 0 10 10q�6H   .+�5X      �� $��Cidade��6   $��20��6*   �� 5Y      $��30��6   $ 30��6&   ��65   �� *Controller.Cliente.EndCidade+5Z      �� 5\      $ Vertical=�6   $	��100��60   $��50��6<   $��	0 0 10 10q�6H   .+�5]      �� $	��CEP��6   $��20��6'   �� 5^      $��30��6   $ 8��6&   ��64   �� *Controller.Cliente.EndCEP+5_      �� 5a      $ Vertical=�6   $	��100��60   $��50��6<   $��	0 0 10 10q�6H   .+�5b      �� $��Estado��6   $��20��6*   �� 5c      $��30��6   	 �� SelectedIndex	 6'   �� *#!Controller.Cliente.EndEstadoIndex+.@�5d      �� 

 � Tag$
 0��6#   $��AC��6+   �� 5e      $
 1��6#   $��AL��6+   �� 5f      $
 2��6#   $��AP��6+   �� 5g      $
 3��6#   $��AM��6+   �� 5h      $
 4��6#   $��BA��6+   �� 5i      $
 5��6#   $��CE��6+   �� 5j      $
 6��6#   $��ES��6+   �� 5k      $
 7��6#   $��GO��6+   �� 5l      $
 8��6#   $��MA��6+   �� 5m      $
 9��6#   $��MT��6+   �� 5n      $
 10��6#   $��MS��6,   �� 5o      $
 11��6#   $��MG��6,   �� 5p      $
 12��6#   $��PA��6,   �� 5q      $
 13��6#   $��PB��6,   �� 5r      $
 14��6#   $��PR��6,   �� 5s      $
 15��6#   $��PE��6,   �� 5t      $
 16��6#   $��PI��6,   �� 5u      $
 17��6#   $��RR��6,   �� 5v      $
 18��6#   $��RO��6,   �� 5w      $
 19��6#   $��RJ��6,   �� 5x      $
 20��6#   $��RN��6,   �� 5y      $
 21��6#   $��RS��6,   �� 5z      $
 22��6#   $��SC��6,   �� 5{      $
 23��6#   $��SP��6,   �� 5|      $
 24��6#   $��SE��6,   �� 5}      $
 25��6#   $��TO��6,   5~      5      5�      �� 5�   
   -   5        $��	btnSalvar��5�   .   $��4��6   $��1��6   $��Salvar��6?   $	��150��6P   $��Right=�6\   6x   5�      5�      