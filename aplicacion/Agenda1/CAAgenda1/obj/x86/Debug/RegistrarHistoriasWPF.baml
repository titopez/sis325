   M S B A M L   `   `   `  ����  	CAAgenda1%    CAAgenda1.RegistrarHistoriasWPF   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $��wRegistroHist��5   >     � Title$  Registrar Historias��6	   $	��505��6%   $	��645��62   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��462* �6   �� 5      $
��161* �6   ��5
   
   �� 5       �� ImageSource$D >/CAAgenda1;component/Images/Android_Wallpaper_by_clondike7.png��6   .+�5   
   �� -   5        $��lDescripcion��5   a   $��Descripcion:��6   $��28��6'   $
��Left=�63   $��	77,37,0,0q�6N   $	��Top=�6u   �� 5   
   -   5        $��
lPrioridad��5   `   $��
Prioridad:��6   $��28��6%   $
��Left=�61   $��
90,131,0,0q�6L   $	��Top=�6r   �� 5   
   -   5        $��chbHabilitar��5   c   $��	Habilitar��6   $��16��6'   $
��Left=�63   $��382,131,0,0q�6N   $	��Top=�6w    d� 	IsChecked 6�   �� *SelectedItem.Habilitado+ �� ElementName$ dgHistorias��6�   �� 5   
   -   5        $��tbDescripcion��5   M   $��77��6   $��Right=�6   $��	0,39,66,0q�6:   $	��Top=�6b   $	��398��6z    �� AcceptsReturn . $��2��6�   ��6�   �� *SelectedItem.Descripcion+$ dgHistorias��6�   �� 5   
   -   5        $��
bRegistrar��5   j   $��Registrar Historia��6   $��42��6.   $
��Left=�6:   $��120,206,0,0q�6U   $	��Top=�6|   $	��113��6�   6�   �� 5   
   -   5        $��	bCancelar��5   _   $��Eliminar��6   $��42��6$   $
��Left=�60   $��
57,206,0,0q�6K   $	��Top=�6p   $��92��6�   $��1��6�   �� 5   
   -   5        $��cbPrioridad��5   O   $��23��6   $
��Left=�6   $��159,131,0,0q�6:   $	��Top=�6b   $��82��6z    �� Text 6�   �� *SelectedItem.Prioridad+$ dgHistorias��.@�5      �� $��1��6   �� 5      $��2��6   �� 5      $��3��6   �� 5      $��4��6   �� 5      $��5��6   5      &   System.Windows.Controls.DataGrid  5   
   -	   5        $��dgHistorias��5   D      AutoGenerateColumns .  $��12,254,12,0q�6/      
IsReadOnly . $	��174��6i   $	��Top=�6v   	 J� 	AllowDrop	 . $��2��6�   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6<      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+6H     5      $ Descripcion��6E    .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 300 6l    6%   �� *Descripcion+6l     5      $ 	Prioridad��6C    .  6%   �� *	Prioridad+6V     5      $ 
Habilitado��6D    .  6%   �� *
Habilitado+6X     5       $ Proyecto��6E    .  6%   �� *Proyecto_id+6W     5!      $ Estimacion Horas��6H    .  6%   �� *Cantidad_Horas+6b   5#      �� 5$   
   -
   5        $��	tbnombrep��5$   9   $��23��6   $
��Left=�6   $	��Top=�6J   $	��623��6b   {�.  $��2��6�   $��Consolas)�6�   $
��Bold"�6�   $��14(�6�   �� 5%   
   -   5        $��btGestionar��5%   N   $��42��6   $��Right=�6   $��0,206,110,0q�69   $	��Top=�6a   $	��131��6y   $��Guardar Modificacion��6�   $��2��6�   �� 5&   
   -   5        $��
btnGuardar��5&   _   $��Guardar��6   $��42��6#   $
��Left=�6/   $��235,270,0,0q�6J   $	��Top=�6q   $��92��6�   $��1��6�   �� 5'   
   -   5        $��label1��5'   i   $��Estimacion de Horas��6   $��28��6.   $
��Left=�6:   $��
33,165,0,0q�6U   $	��Top=�6w   �� 5(   
   -   5        $��tbHoras��5(   N   $��23��6   $
��Left=�6   $��159,167,0,0q�69   $	��Top=�6]   $	��101��6u   ��6�   �� *SelectedItem.Cantidad_Horas+$ dgHistorias��6�   �� 5)   
   -   5        $��tbIDH��5)   \   $��1��6   $��23��6"   $
��Left=�6.   $��	129,0,0,0q�6I   $	��Top=�6i   $��32��6�   {�.  ��6�   �� *SelectedItem.id+$ dgHistorias���� 5*   
   -   5        $��bCerrar��5*   ]   $��Cerrar��6   $��42��6"   $
��Left=�6.   $��
12,206,0,0q�6I   $	��Top=�6l   $	��102��6�   6�   �� 5+   
   -   5        $��bCrearSprint��5+   d   $��Crear Sprint��6   $��42��6(   $
��Left=�64   $��250,206,0,0q�6O   $	��Top=�6x   $	��116��6�   6�   �� 5,   
   -   5        $��bCrearTareas��5,   s   $��Crear Tareas��6   $��1��6(   $��23��68   $
��Left=�6D   $��
58,164,0,0q�6_   $	��Top=�6�   $��75��6�   {�.  6�   5-      5.      