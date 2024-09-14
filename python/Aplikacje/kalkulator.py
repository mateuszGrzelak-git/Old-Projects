from tkinter import *

root = Tk()
a = 0
b = ""
c = 0
d = 0
rowne = ""
liczby = Label(root, text="")
def dziewiec():
    if b=="+" or b=="-" or b=="*" or b=="/":
        c=9
    else:
        a=9
        
def osiem():
    if b=="+" or b=="-" or b=="*" or b=="/":
        c=8
    else:
        a=8
        
def siedem():
    if b=="+" or b=="-" or b=="*" or b=="/":
        c=7
    else:
        a=7
def szesc():
     if b=="+" or b=="-" or b=="*" or b=="/":
        c=6
     else:
        a=6
def piec():
     if b=="+" or b=="-" or b=="*" or b=="/":
        c=5
     else:
        a=5
def cztery():
     if b=="+" or b=="-" or b=="*" or b=="/":
        c=4
     else:
        a=4
def trzy():
     if b=="+" or b=="-" or b=="*" or b=="/":
        c=3
     else:
        a=3
def dwa():
     if b=="+" or b=="-" or b=="*" or b=="/":
        c=2
     else:
        a=2
def jeden():
     if b=="+" or b=="-" or b=="*" or b=="/":
        c=1
     else:
        a=1
def plus():
    b="+"
def minus():
    b="-"
def rowne():
    kalkulator()
    liczby = Label(root, text=f"{d}")
def kalkulator():
    if b=="+":
        d=a+c
    elif b=="-":
        d=a-c
    elif b=="*":
        d=a*c
    elif b=="/":
        d=a/c
    
dziewiec = Button(root, text="9", command=dziewiec)
osiem = Button(root, text="8", command=osiem)
siedem = Button(root, text="7", command=siedem)
plus = Button(root, text="+", command=plus)

szesc = Button(root, text="6", command=szesc)
piec = Button(root, text="5", command=piec)
cztery = Button(root, text="4", command=cztery)
minus = Button(root, text="-", command=minus)

trzy = Button(root, text="3", command=trzy)
dwa = Button(root, text="2", command=dwa)
jeden = Button(root, text="1", command=jeden)
rowne = Button(root, text="=", command=rowne)

liczby.grid(row=0)
siedem.grid(row=1, column=0)
osiem.grid(row=1, column=1)
dziewiec.grid(row=1, column=2)
plus.grid(row=1, column=3)
cztery.grid(row=2, column=0)
piec.grid(row=2, column=1)
szesc.grid(row=2, column=2)
minus.grid(row=2, column=3)
jeden.grid(row=3, column=0)
dwa.grid(row=3, column=1)
trzy.grid(row=3, column=2)
rowne.grid(row=4)

root.mainloop()
