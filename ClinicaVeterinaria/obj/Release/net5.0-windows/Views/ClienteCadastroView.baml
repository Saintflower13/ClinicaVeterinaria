   M S B A M L   `   `   `  ���� M  IClinicaVeterinaria, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ClinicaVeterinaria.ViewsClinicaVeterinaria.Views  2    ,ClinicaVeterinaria.Views.ClienteCadastroView   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8local&clr-namespace:ClinicaVeterinaria.Views       � Title$/  )Clínica Veterinária Felinos da Montanha��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � Icon$ /Views/logo2.png��.���  � RowDefinitions �� $��20 ��� $��25 ��� $��10 ��� $��* ��� $��30 ��� $��20 � � ColumnDefinitions �� $��20 ��� $��* ��� $��20 �.+�� $��1��$��1��.+��� $��Novo Cliente��$��16(�� $��3��$��1��$	��Top=�.+���  �� Orientation$ Vertical=�$	��170��$��50��$��	0 0 10 10q�.+��� $��Nome*��$��20����  �� 	MaxLength$ 45��$��30������ *Controller.Cliente.Nome+�� $ Vertical=�$	��230��$��50��$��	0 0 10 10q�.+��� $��
Sobrenome*��$��20���� $��30��$ 45������ *Controller.Cliente.Sobrenome+�� $ Vertical=�$	��290��$��50��$��	0 0 10 10q�.+��� $
��Sexo��$��50��.���� $ 
Horizontal=�.+�	� $	��100��$��Center=�$��Não Informar�� d� 	IsChecked$
 TrueY�	� $��75��$��Center=�$��Feminino��	� $��75��$��Center=�$��	Masculino���� $ Vertical=�$	��100��$��50��$��	0 0 10 10q�.+��� $	��CPF��$��20���� -   $��30��$ 11������ *Controller.Cliente.CPF+�� $ Vertical=�$	��100��$��50��$��	0 0 10 10q�.+��� $��RG��$��20���� -   $��30��$ 9������ *Controller.Cliente.RG+�� $ Vertical=�$	��100��$��50��$��	0 0 10 10q�.+��� $��Telefone��$��20���� $��30��$ 12������ *Controller.Cliente.Telefone+�� $ Vertical=�$	��400��$��	0 0 10 10q�.+��� $��Email��$��20���� $��30��$	 100������ *Controller.Cliente.Email+�� $ Vertical=�$	��400��$��50��$��	0 0 10 10q�.+��� $��
Logradouro��$��20���� $��30��$ 50������ *" Controller.Cliente.EndLogradouro+�� $ Vertical=�$	��100��$��50��$��	0 0 10 10q�.+��� $��Numero��$��20���� -   $��30��$ 5������ *Controller.Cliente.EndNumero+�� $ Vertical=�$	��200��$��50��$��	0 0 10 10q�.+��� $��Bairro��$��20���� $��30��$ 30������ *Controller.Cliente.EndBairro+�� $ Vertical=�$	��250��$��50��$��	0 0 10 10q�.+��� $��Cidade��$��20���� $��30��$ 30������ *Controller.Cliente.EndCidade+�� $ Vertical=�$	��100��$��50��$��	0 0 10 10q�.+��� $	��CEP��$��20���� $��30��$ 8������ *Controller.Cliente.EndCEP+�� $ Vertical=�$	��100��$��50��$��	0 0 10 10q�.+��� $��Estado��$��20���� $��30��	 �� SelectedIndex	 �� *#!Controller.Cliente.EndEstadoIndex+.@��� 

 � Tag$
 0��$��AC���� $
 1��$��AL���� $
 2��$��AP���� $
 3��$��AM���� $
 4��$��BA���� $
 5��$��CE���� $
 6��$��ES���� $
 7��$��GO���� $
 8��$��MA���� $
 9��$��MT���� $
 10��$��MS���� $
 11��$��MG���� $
 12��$��PA���� $
 13��$��PB���� $
 14��$��PR���� $
 15��$��PE���� $
 16��$��PI���� $
 17��$��RR���� $
 18��$��RO���� $
 19��$��RJ���� $
 20��$��RN���� $
 21��$��RS���� $
 22��$��SC���� $
 23��$��SP���� $
 24��$��SE���� $
 25��$��TO���� -   $��	btnSalvar��$��4��$��1��$��Salvar��$	��150��$��Right=�