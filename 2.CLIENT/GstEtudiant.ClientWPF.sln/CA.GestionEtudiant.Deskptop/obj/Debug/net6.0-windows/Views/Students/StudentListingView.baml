   M S B A M L   `   `   `  ����V  RCA.GestionEtudiant.Deskptop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:CA.GestionEtudiant.Deskptop.Views.Converters,CA.GestionEtudiant.Deskptop.Views.Converters  5      q=clr-namespace:CA.GestionEtudiant.Deskptop.Components.Students/CA.GestionEtudiant.Deskptop.Components.Students  5      q=clr-namespace:CA.GestionEtudiant.Deskptop.ViewModels.Students/CA.GestionEtudiant.Deskptop.ViewModels.Students  5      g8clr-namespace:CA.GestionEtudiant.Deskptop.Views.Students*CA.GestionEtudiant.Deskptop.Views.Students  5	      C    =CA.GestionEtudiant.Deskptop.Views.Students.StudentListingView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Q
converters:clr-namespace:CA.GestionEtudiant.Deskptop.Views.Converters     5      T
components=clr-namespace:CA.GestionEtudiant.Deskptop.Components.Students     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mvms=clr-namespace:CA.GestionEtudiant.Deskptop.ViewModels.Students     5      Jlocal8clr-namespace:CA.GestionEtudiant.Deskptop.Views.Students     5	      ��5      �� *ActualWidth+  �� RelativeSource  ��  �� AncestorType
 Window � 	Resources 5      M   GCA.GestionEtudiant.Deskptop.Views.Converters.InverseVisibilityConverter   InverseVisibilityConverter��%   &	          5   
   60   5      .��5      � .+�5   
   �� .+�5      �  � RowDefinitions 5      �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $��* �6$   .+�5      �� $��Liste des Etudiants��6   
���   �$��23(�5      $��SemiBold"�5      $��10q�5       $��Center=�5!      $��Center=�5"      � 5$      $��1��6    � ColumnDefinitions 5%      �� 5&      $
��auto �6+   �� 5'      $��* �6+   .+�5+      ��  �� Orientation$ 
Horizontal=�6!   $��0��6:   $��Center=�6J   $��Center=�6g   $��0 0 0 0q�6�   .+�5,      �� $��Filter by : ��6$   $��13(�68   $��SemiBold"�6F   ���#121518$��Center=�5-   2   $��0,0,10,0q�6M   �� 5.      -   5         ��Name$ 	txtFilter��5.   "   $	��250��65   $��Center=�6A   $��0,0,0,0q�6\   5/      �� 52      -   5         ��Name$ btnOpenDialogue��52      $��1��67   $��Create Student��6G   $	��125��6`   $��0 1 10 1q�6l   $��Right=�6   6�   53      � 54      $��2��6   $��0 20 0 0q�6$   .+�55      �� ��6#   �� *ActualWidth+  �� 
 Window.��56      � ��57      �� 58   "    �� 
TargetType" �6(   .�59   &   �� 	 �� Property	 � y�
 �� Value$
 	Collapsed=�6C    �� Triggers 5:   &   �� 5;   *    �� Binding 66   �� *HasStudents+ �� Value True6V   .a�5<   .   �� 	 � y�$
 Visible=�6K   5=   +   5?   #   .+�5B      D   >CA.GestionEtudiant.Deskptop.Components.Students.StudentListing  5D      5E      5F      5G      5H      � 5K   
   -   5         �Name$ DialogOverlay��5K   '   ���	#80000000$y�	Collapsed=�5L      .+�5M      �� 
������� �� Padding$ 20q�6(   $	��300��65   $
��auto��6A   $��Center=�6O   $��Center=�6l   ._�5N      �� .+�5O      �� $��32(�5P      $��Create Student��5Q      � 5S      $��1��6   $��0 15 0 0q�6(    5T      �� 5U      $
��auto �6/    z� SharedSizeGroup$ Label��6<   �� 5V      $��* �6/   .+�5Y      �� $��0��6$   $��	FirstName��64   �� 5Z      $��1��5[      $��20 0 0 0q�5\      ��5]      �� *	FirstName+ �� UpdateSourceTrigger$ PropertyChanged=�5^      � 5`      $��2��6   $��0 15 0 0q�6(    5a      �� 5b      $
��auto �6/   $ Label��6<   �� 5c      $��* �6/   .+�5f      �� $��0��6$   $��LastName��64   �� 5g      $��1��5h      $��20 0 0 0q�5i      ��5j      �� *
LastName+$ PropertyChanged=�5k      � 5m      $��3��6   $��0 15 0 0q�6(    5n      �� 5o      $
��auto �6/   $ Label��6<   �� 5p      $��* �6/   .+�5s      �� $��0��6$   $��Cours��64   �� 5t      $��1��5u      $��42,0,0,0q�5v      ��5w      �� *Cours+$ PropertyChanged=�5x      � 5y      $��4��6   $��0 15 0 0q�6(    5z      �� 5{      $
��auto �6/   $ Label��6<   �� 5|      $��* �6/   .+�5      �� $��0��6$   $��
Entreprise��64   �� 5�      $��1��5�      $��20 0 0 0q�5�      ��5�      �� *
Entreprise+$ PropertyChanged=�5�      � 5�      $��5��6   $��0 15 0 0q�6(    5�      �� 5�      $
��auto �6/   $ Label��6<   �� 5�      $��* �6/   .+�5�      �� $��0��6$   $��	NbreHeure��64   �� 5�      $��1��5�      $��22,0,0,0q�5�      ��5�      �� *
NbreHeures+$ PropertyChanged=�5�      � 5�      $��6��6   $��0 15 0 0q�6(    5�      �� 5�      $
��auto �6/   $ Label��6<   �� 5�      $��* �6/   .+�5�      �� $��0��6$   $
��Prix��64   �� 5�      $��1��5�      $��55,0,0,0q�5�      ��5�      �� *Prix+$ PropertyChanged=� �� StringFormat$ {0:C}��5�      � 5�      $��7��6   $��0 15 0 0q�6(    5�      �� 5�      $
��auto �6/   $ Label��6<   �� 5�      $��* �6/   .+�5�      �� $��0��6$   $��
Enseignant��64   �� 5�      $��1��5�      $��20 0 0 0q�5�      ��5�      �� *
Enseignant+$ PropertyChanged=�5�      � 5�      $��8��6   $��0 15 0 0q�6(    5�      �� 5�      $
��auto �6/   $ Label��6<   �� 5�      $��* �6/   .+�5�      �� $��0��6$   $��
DebutCours��64   �� 5�      $��1��5�      $��20,0,0,0q�5�      ��5�      �� *
DebutCours+$ PropertyChanged=�5�      � 5�      $��9��6   $��0 15 0 0q�6(    5�      �� 5�      $
��auto �6/   $ Label��6<   �� 5�      $��* �6/   .+�5�      �� $��0��6$   $��FinCours��64   �� 5�      $��1��5�      $��37,0,0,0q�5�      ��5�      �� *
FinCours+$ PropertyChanged=�5�      � 5�      $��10��6   $��0 25 0 0q�6)    5�      �� 5�      $
��auto �6/   �� 5�      $
��auto �6/   .+�5�      �� -   5        $ CloseDialogButton��5�      $��0��5�      $��0 0 10 0q�5�      $��OK��5�      $
��Save��5�      ��5�      �� *CloseDialogCommand+5�   ,   �� 5�      $��1��5�      $��Cancel��5�      $��Cancel��5�      ��5�      �� *CloseDialogCommand+5�      5�      5�      5�      5�      5�     5�     