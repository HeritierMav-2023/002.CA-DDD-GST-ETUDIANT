   M S B A M L   `   `   `  ����V  RCA.GestionEtudiant.Deskptop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:CA.GestionEtudiant.Deskptop.Components&CA.GestionEtudiant.Deskptop.Components  5      3    -CA.GestionEtudiant.Deskptop.Components.Layout   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:CA.GestionEtudiant.Deskptop.Components     5      .��5	      �� $
��Auto=�6   $
��Auto=�68   .��5
   
   � ��6   �� *ActualWidth+  �� RelativeSource  ��  �� AncestorType
 Window � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $��* �6    .+�5      � $��0��5      
����d�
������� � DataContext 5      �� *NavigationBarViewModel+.+�5      � $��20 10q�6    � ColumnDefinitions 5      �� 5      $��* �6+   �� 5      $
��auto �6+   �� 5      $
��auto �6+   �� 5      $
��auto �6+   .+�5      �� $��0��5      $��Center=�5       $��28(�5!      $ �� Student Management System��5"      �� 5$      $��1��5%      $��10 0 0 0q�5&      $
��10 5q�5'      $
��Home��5)      ��5(      �� *NavigatePostHomeCommand+5)      �� 5+      $��2��5,      $��10 0 0 0q�5-      $
��10 5q�5.      $��Posts��50      ��5/      �� *NavigatePostListingCommand+50      �� 52      $��3��53      $��10 0 0 0q�54      $
��10 5q�55      $��Students��57      ��56      �� *NavigateStudentListingCommand+57      58      59      @   :CA.GestionEtudiant.Deskptop.Components.GlobalMessageBanner  5;      $��1��5<       5=      �� *GlobalMessageViewModel+��5>      �� *ActualWidth+  �� 
 Window�� 5@      $��2��5A      $��20q�5C      ��5B      �� *ActualWidth+  �� 
 Window��5D      �� *ContentViewModel+5E      5F      5G      