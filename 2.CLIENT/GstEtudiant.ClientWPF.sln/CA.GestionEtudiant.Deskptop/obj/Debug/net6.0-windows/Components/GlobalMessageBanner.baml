   M S B A M L   `   `   `  ����V  RCA.GestionEtudiant.Deskptop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:CA.GestionEtudiant.Deskptop.Components&CA.GestionEtudiant.Deskptop.Components  5      @    :CA.GestionEtudiant.Deskptop.Components.GlobalMessageBanner   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:CA.GestionEtudiant.Deskptop.Components     5        � 	Resources  5	          BooleanToVisibilityConverter��%   &	        �� 5
   
   6'   5      .��5      � y�6   �� *
HasMessage+ �� 	Converter# [  ��5   
   �� 5       �� 
TargetType" �6    �� Triggers 5      �� 5       �� Binding 6"   �� *IsStatusMessage+ �� Value True6F   .a�5      ��  �� Property � �� �� Value
 � � �67   �� 5       � ��
 �����6A   5      �� 5       6"   �� *IsErrorMessage+ True6E   .a�5      ��  � ��
 �  ��67   �� 5       � ��
 �����6A   5      5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5"   
   �� $��1��5#   	   	 �� Padding$	 5q�5$   	   $��Center=�5%   	   ��5&   	   �� *	Message+�� 5(   
   $��2��5)   	   $��0 2 10 2q�5*   	   $	��5 2q�5+   	   $��Right=�5,   	   $��X��5.   	   ��5-   	   �� *ClearMessageCommand+5.   	   5/      50      