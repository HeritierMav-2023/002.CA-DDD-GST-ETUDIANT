   M S B A M L   `   `   `  ����V  RCA.GestionEtudiant.Deskptop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullq=clr-namespace:CA.GestionEtudiant.Deskptop.Components.Students/CA.GestionEtudiant.Deskptop.Components.Students  5      D    >CA.GestionEtudiant.Deskptop.Components.Students.StudentListing   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Olocal=clr-namespace:CA.GestionEtudiant.Deskptop.Components.Students     5      ��5   #   �� *ActualWidth+  �� RelativeSource  ��  �� AncestorType
 Window.��5	      &   System.Windows.Controls.DataGrid  $��1��6      AutoGenerateColumns$ False��6@   $��Stretch=�5
      $��Stretch=�6-      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5         AlternatingRowBackground
 �����   GridLinesVisibility$
 None=�6E   ��5	      �� *
Students+   Columns 5   
   0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6!   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *Id+  5      $ 	FirstName��6!   	   
IsReadOnly$
	 True��64   
   Width$
 * 6F    6P   ��  �� Path$ 	FirstName�  5      $ LastName��6!   $
	 True��63   $
 * 6E    6O   �� $ LastName�  5      $ Email��6!   $
	 True��60   $
 * 6B    6L   �� $ Email�  5      $ Cours��6!   $
	 True��60   $
 * 6B    6L   �� $ Cours�  5      $ 
Entreprise��6!   $
	 True��65   $
 * 6G    6Q   �� $ 
Entreprise�  5      $ 	NbreHeure��6!   $
	 True��64   $
 * 6F    6P   �� $ 
NbreHeures�  5      $
 Prix��6!   $
	 True��6/   $
 * 6A    6K   �� $
 Prix�  5      $ 
DebutCours��6!   $
	 True��65   $
 * 6G    6Q   �� $ 
DebutCours�  5      $ FinCours��6!   $
	 True��63   $
 * 6E    6O   �� $ FinCours�  5      $ 
Enseignant��6!   $
	 True��65   $
 * 6G    6Q   �� $ 
Enseignant�5      5      