   M S B A M L   `   `   `  ����  	CAAgenda1    CAAgenda1.Sprint   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Sprint��5   	   $	��452��6   $	��897��6%   .��5      � ��5   
   �� 5       �� ImageSource$D >/CAAgenda1;component/Images/Android_Wallpaper_by_clondike7.png��6   .+�5	   
   �� -   5        $��tbSprint��5	   3   $��23��6   $��71,38,718,0q�6   $	��Top=�6C   �� 5
   
   -   5        $��label1��5
   [   $��SPRINT��6   $��28��6!   $
��Left=�6-   $��	90,12,0,0q�6H   $	��Top=�6i   �� 5   
   -   5        $��textBox1��5   M   $��23��6   $
��Left=�6   $��
302,38,0,0q�69   $	��Top=�6]   $��98��6u   �� 5   
   -   5        $��label2��5   ^   $��DURACION��6   $��28��6#   $
��Left=�6/   $��
315,12,0,0q�6J   $	��Top=�6l   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��datePicker1��5   5   $��25��6   $��
0,36,587,0q�6!   $	��Top=�6H   $��Right=�6`   $	��125��6|   �� 5   
   -   5        $��label3��5   \   $��INICIO��6   $��28��6!   $
��Left=�6-   $��
201,12,0,0q�6H   $	��Top=�6j   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	dataGrid1��5   j      AutoGenerateColumns .  $	��311��6/   $
��Left=�6<   $��	12,80,0,0q�6W   $	��Top=�6{   $	��851��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ BackLog��6&      
IsReadOnly . 67     5      $ Id��6&    . 62     5      $ Tarea��6&    .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 300 6G     5      $
 Tipo��6&    . $	 100 6F     5      $ Estado��6&    . $	 100 6H     5      $ Responsable��6&    . 6;     5      $ Esfuerzo��6&    . $	 300 6J   5      �� 5   
   -   5        $��label4��5   f   $��Horas Pendientes��6   $��28��6+   $
��Left=�67   $��
559,46,0,0q�6R   $	��Top=�6t   �� 5   
   -	   5        $��label5��5   g   $��Tareas Pendientes��6   $��28��6,   $
��Left=�68   $��
555,12,0,0q�6S   $	��Top=�6u   �� 5   
   -
   5        $��tbHoras��5   M   $��23��6   $
��Left=�6   $��
667,46,0,0q�69   $	��Top=�6\   $��30��6t   �� 5   
   -   5        $��tbTareas��5   M   $��23��6   $
��Left=�6   $��
667,14,0,0q�69   $	��Top=�6]   $��30��6u   5      5      