   M S B A M L   `   `   `  ????G  CbdInterfaces, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:bdInterfaces.PagesbdInterfaces.Pages  5          bdInterfaces.Pages.Crud   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      X TFontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfo=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      ,local clr-namespace:bdInterfaces.Pages  5        N? Title$
  Crud??5
      $	??425??6   $	??600??6!    	  Negro N? 
Background# [  5      .??5      ? .+?5   
   ? $??
0,10,50,10q?6    ? RowDefinitions 5      ?? 5      $	??150 ?6    ?? 5      $??* ?6    .+?5      ? $??0??6   .+?5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? .+?5      	? -   5         	?Name$ 
RbtAgregar??5   &     
BotSubMenu#??[ 5   &   
 ? Tag# [  5   &    d? 	IsChecked$
 TrueY?5   &   .??5      ?? $ 
Horizontal=?6)   .+?5    "   !  FontAwesome.Sharp.IconImage  ?  ?FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.2.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ 
PlusSquare=?6/    	 Verde   
Foreground# [ 5!   /   $??20??5"   /   $??10,0,0,0q?5#   /   ?? 5$   "   $??AGREGAR??6,   #??[ 5%   ,   $
??Bold"?5&   ,   $??10,0,0,0q?5'   ,   $??Bottom=?5(   ,   6I   5)      5*      	? 5,      -   5        $ RbtModificar??5,   &   #??[ 5-   &   # [  5.   &   .??50      ?? $ 
Horizontal=?6)   .+?51   "     $	 Pen=?6/   # [ 52   /   $??20??53   /   $??10,0,0,0q?54   /   ?? 55   "   $??	MODIFICAR??6,   $??10,0,0,0q?56   ,   #??[ 57   ,   $
??Bold"?58   ,   $??Bottom=?59   ,   6I   5:      5;      	? 5=      -   5        $ 	RbtBorrar??5=   &   #??[ 5>   &   # [  5?   &   .??5A      ?? $ 
Horizontal=?6)   .+?5B   "     $ TrashCan=?6/   # [ 5C   /   $??20??5D   /   $??10,0,0,0q?5E   /   ?? 5F   "   $??BORRAR??6,   $??10,0,0,0q?5G   ,   #??[ 5H   ,   $
??Bold"?5I   ,   $??Bottom=?5J   ,   6I   5K      5L      5N      ?? 5P      $??Center=?6!   .+?5R       ? -   5        	  ?Name$	 SubMenus??5R       $	??400??5S       $	??150??5T       
  ? Source$
 ../Pages/Agregar.xaml??5U         ? NavigationUIVisibility$ Hidden=?5V       6B   5W      5Y      5\      ?? 5^      $??1??6   .+?5`      ?? -   5         ??Name$
 list??5`      $	??500??5a      $	??175??5b      $??	50,40,0,0q?5c      
?????? 
???????$??
Montserrat)?5f      $??1q?5g      #??[ 5h      5k      5n      5p      5s      5t      