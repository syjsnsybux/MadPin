   M S B A M L   `   `   `  ���� C  ?Hostlink, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HostlinkHostlink      Hostlink.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Hostlink     -     � WindowStartupLocation$  CenterScreen=� � Title$ Hostlink��$	��550��$	��500�� � WindowState$ Normal=� � 	Resources    ButtonStyle1 �� 
TargetType �� Property �� Value �� 
TargetType ��Name	 �� CornerRadius
 J� SnapsToDevicePixels ��Name �� Triggers P� Property P� Value �� 
TargetName  RadioButtonStyle �� StrokeDashArray �� ContentStringFormat �� ContentStringFormat��%�  &	        &	 �    �� " ��.���  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��$	 10��#��z��#��z��#��z��
 . ._��� $ contentPresenter��|�.  #��z��#��z����. #
 z
 #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . P�  � �� . P�  � {� .  �� " 	�.���  �@�FocusVisualStyle �� .���  � �� �� .R��� $��2q�
 . #��� ��$��1��$	 1 2R���  � ��
 �������  � �� �	#FF707070��  � ��# � ����  � ��$ 1q���  � �� �� " 	�.R��� $��bd��
������ $	 10��._��� $ contentPresenter��#��z��#��z��# z |�.  #��z��#��z����. #
 z
 #��z�� P�  � �� . . ���  �@�FocusVisualStyle �� .���  � �� �� .R��� $��14,0,0,0q�
 . #��� ��$��1��$	 1 2R���  � ��$ 4,-1,0,0q�P�  �@J�IsMouseOver . P�  � {� .  P�  � �� . P�  �@d�	IsChecked$
 TrueY�. ��� $ bd�� � ��
 � ���P�  �@d�	IsChecked$ falseY�. ��� $ bd�� � ��
 �����P�  Z�  �@d�	IsChecked. ��� $ bd�� � ��
 �����.��� $	��519��$	��Top=�����  �� ImageSource$ 1.jpg�� �� Opacity$
 0.05Q� � RowDefinitions �� �� $
��auto ��� �� $	��100 ��� $��50 �.+��� ���	#FF90EAEE J� Opacity$	 0.8Q�._��� 
 . &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�   TextRenderingMode$ 	ClearType=�$��Center=�$��50(�$��Center=�$��抽检模式设定��$��Microsoft YaHei)���  �� Orientation$ 
Horizontal=�$��1��$��Center=�.+�	� -    	�Name$ enableRB��$ Display=�$��Center=�$��35(�$��
10,50,0,50q�#���  $��抽检启用��$��Times New Roman)� � Cursor$
 Hand�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 5Q�   Color$ 	#FF662CAC��	� -   $ unableRB��$ Display=�$��35(�$��Center=�#���  $��100,50,0,50q�$��	不启用��$��Times New Roman)�$
 Hand�� d� 	IsChecked Z�    $ 5Q�$ 	#FF662CAC��� $��2��$��0,0,0,33q�  J� RenderTransformOrigin$  
0.508,0.98&�! � ColumnDefinitions! �� $
��223* ��� $	��23* � �� $��2* ��� $��* �.+��� $��Center=�$ 
Horizontal=�$��2��$��0,2,0,29q�$��51��$��2��.+��� $��设定：连续��$��Times New Roman)�$��18(��� -   " ��Name$" cbpcsNum��$��5,0,0,27q�$��Times New Roman)�$��18(�$��40��
��������� $��片中，第��$��Times New Roman)�$��18(��� -   $" 
cbwhichNum��
�������$��5,0,0,27q�$��Times New Roman)�$��18(�$��40���� $��片开始ByPass��$��Times New Roman)�$��18(��� -   
�������$��Center=�$��2,0,0,21q�$��Times New Roman)�$��25(�$��设定保存��$��30��$	��120��$
 Hand��   $ 	#FF662CAC���� $��2q�
����  �$��3��$��Options�����	#FF90EAEE$	 0.8Q�.���� $��0,0,0.333,-12q�.+��� $��10,0,0,0q�$ 
Horizontal=�$��Center=�$y�Hidden=�.+��� $��选择串口���� -   $" cbSerial��$��5,0,0,0q��� $��20,0,0,0q�$��ReadTimeout(ms)���� -   # ��Name$# tbReadTimeout��$��5,0,0,0q�$��20��$	��500���� $��20,0,0,0q�$��WriteTimeout(ms)���� -	   $# tbWriteTimeout��$��5,0,0,0q�$	��500��$��20���� $��10,0,0,0q�$ 
Horizontal=�$
��Left=�$��Center=�.+�	� -
   $��打开端口��$
��Left=�#���  $	��Top=�$	��200��$��35��$��30(�$��Times New Roman)�$
 Hand��   $ 	#FF662CAC��	� -   $��10,0,0,0q�$��Right=�$
 TrueY�$��关闭端口��#���  $	��200��$��35��$	��Top=�$��30(�
�������$��Times New Roman)�$	 0.9Q�$
 Hand��   $ 	#FF662CAC���� $��10,0,0,0q�$��Center=�$ 
Horizontal=�$y�Hidden=�.+��� $��	波特率���� -   $" cbBoundRate��$��5,0,0,0q��� $��20,0,0,0q�$��	数据位���� -   $" 
cbDataBits��$��5,0,0,0q��� $��20,0,0,0q�$��	停止位���� -   $" cbStop��$��5,0,0,0q��� $��20,0,0,0q�$��	校验位���� -   $" cbParity��$��5,0,0,0q��� $��4��$��Center=�$ 
Horizontal=�.+��� $��端口号: ��$��Times New Roman)�$��16(��� ���� $ �� ElementName$$ cbSerial��% �� Path$% SelectedItem��� $��20,0,0,0q�$��波特率: ��$��Times New Roman)�$��16(��� ���� $$ cbBoundRate��$% SelectedItem��� $��20,0,0,0q�$��停止位: ��$��Times New Roman)�$��16(��� ���� $$ cbStop��$% SelectedItem��� $��20,0,0,0q�$��校验: ��$��Times New Roman)�$��16(��� ���� $$ cbParity��$% SelectedItem�