   M S B A M L   `   `   `  ����e  aArwinTolentino.CookingRecipePortal.Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:ArwinTolentino.CookingRecipePortal.Windows.Users0ArwinTolentino.CookingRecipePortal.Windows.Users  5   	   =    7ArwinTolentino.CookingRecipePortal.Windows.Users.UrList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Plocal>clr-namespace:ArwinTolentino.CookingRecipePortal.Windows.Users     5   	     � Title$  UrList��5   	   $	��450��6   $	��800��6%   .��5	      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgUsers��5      $
��Left=�6$   $	��278��6?   $��
26,131,0,0q�6L   $	��Top=�6`   $	��609��6x   $��2��6�      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   5   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *	FirstName+65     5      $ LastName��6%   $ * 5   4    6   �� *
LastName+64     5      $ Email Address��6%   $ * 5   8    6   �� *EmailAddress+68     5      $ Password��6%   $ * 5   4    6   �� *
Password+64   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� 	 ��Name$	 	btnUpdate��6%   -   5        .��5   P   Update6X   5      5        5       5      �� 5       .R�5!      �� $	 	btnDelete��6%   -   5        .��5!   P   Delete6X   5"      5$      5&      �� 5'   
   -   5        $	 btnNext��5'      $
��NEXT��6"   $
��Left=�61   $��684,109,0,0q�6L   $	��Top=�6a   $��74��6y   $��35��6�   �� 5(   
   -   5        $	 btnPrev��5(      $��PREV.��6"   $
��Left=�62   $��685,149,0,0q�6M   $	��Top=�6b   $��73��6z   $��35��6�   �� 5)   
   -   5        $	 btnFirst��5)      $��FIRST��6#   $
��Left=�63   $��684,189,0,0q�6N   $	��Top=�6c   $��74��6{   $��38��6�   �� 5*   
   -   5        $	 btnLast��5*      $
��LAST��6"   $
��Left=�61   $��684,232,0,0q�6L   $	��Top=�6a   $��74��6y   $��38��6�   �� 5+   
   -   5        
 ��Name$
 lblPageSize��5+      $��	PAGE SIZE��6%   $
��Left=�69   $��684,359,0,0q�6T   $	��Top=�6i   $��73��6�   $
��Bold"�6�   �� 5,   
   -	   5         ��Name$ txtPageSize��5,      $
��Left=�6'   $��35��6B   $��684,319,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $��1��6w   $	��Top=�6�   $��73��6�   6�   �� 5-   
   -
   5        $
 	lblSortby��5-      $��	SORT BY ;��6#   $
��Left=�67   $��
444,21,0,0q�6R   $	��Top=�6f   $	��155��6~   $��26��6�   $
��Bold"�6�   �� 5.   
   -   5        $ 
txtFilters��5.      $
��Left=�6&   $��37��6A   $��	27,55,0,0q�6M   $
 Wrap=�6`   $	��Top=�6t   $	��385��6�   6�   �� 5/   
   -   5        $
 
lblFilters��5/      $��	FILTERS :��6$   $
��Left=�68   $��	27,21,0,0q�6S   $	��Top=�6f   $
��Bold"�6~   $	��385��6�   �� 50   
   -   5        $
 lblSortOrder��50      $��SORT ORDER :��6&   $
��Left=�6=   $��
604,21,0,0q�6X   $	��Top=�6l    J� RenderTransformOrigin$ 0.342,-0.288&�6�   $	��155��6�   $��26��6�   $
��Bold"�6�   �� 51   
   -   5         ��Name$ 	cboSortBy��51      $
��Left=�6&   $��
444,56,0,0q�6A   $	��Top=�6U   $	��155��6m   $��37��6y   6�   �� 52   
   -   5        $ cboSortOrder��52      $
��Left=�6)   $��
604,55,0,0q�6D   $	��Top=�6X   $	��154��6p   $��38��6|   6�   �� 53   
   -   5        $	 	btnAddNew��53      $��ADD NEW��6$   $
��Left=�66   $��38��6Q   $��683,276,0,0q�6]   $	��Top=�6r   $��74��6�   6�   56      57      