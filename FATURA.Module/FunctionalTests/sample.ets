;#DropDB FATURAEasyTest

#Application FATURAWin
#Application FATURABlazor

*FillForm
 User Name = Admin
*Action Log In

#IfDef FATURAWin

*Action About...
 
*Action OK

#EndIf

#IfDef FATURABlazor
*Action Navigation(My Details)
#EndIf
