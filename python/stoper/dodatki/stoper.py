import time
from tkinter import *
import math

tk = Tk()
def start():
    global poczatek
    poczatek = list(time.ctime())
    poczatek.remove(":")
    poczatek.remove(":")
    poczatek = poczatek[11:17]
    Label(tk, text="Rozpoczęto odliczanie").pack()
def stop():
    koniec = list(time.ctime())
    koniec.remove(":")
    koniec.remove(":")
    koniec = koniec[11:17]
    
    a = int(poczatek[0])*10 + int(poczatek[1])
    b = int(poczatek[2])*10 + int(poczatek[3])
    c = int(poczatek[4])*10 + int(poczatek[5])
    d = a*3600 + b*60 + c

    e = int(koniec[0])*10 + int(koniec[1])
    f = int(koniec[2])*10 + int(koniec[3])
    g = int(koniec[4])*10 + int(koniec[5])
    h = e*3600 + f*60 + g
    
    i = h-d
    if i/3600>=1:
        x = math.floor(i/3600)
        i = i - x*3600
        y = math.floor(i/60)
        i = i - y*60
        z = math.floor(i/1)
        if x/10>=1 and y/10>=1 and z/10>=1:
            Label(tk, text=f"{x}:{y}:{z}").pack()
        elif x/10>=1 and y/10>=1 and z/10<1:
            Label(tk, text=f"{x}:{y}:0{z}").pack()
        elif x/10>=1 and y/10<1 and z/10>=1:
            Label(tk, text=f"{x}:0{y}:{z}").pack()
        elif x/10>=1 and y/10<1 and z/10<1:
            Label(tk, text=f"{x}:0{y}:0{z}").pack()
        elif x/10<1 and y/10>=1 and z/10>=1:
            Label(tk, text=f"0{x}:{y}:{z}").pack()
        elif x/10<1 and y/10>=1 and z/10<1:
            Label(tk, text=f"0{x}:{y}:0{z}").pack()
        elif x/10<1 and y/10<1 and z/10>=1:
            Label(tk, text=f"0{x}:0{y}:{z}").pack()
        else:
            Label(tk, text=f"0{x}:0{y}:0{z}").pack()
        
    elif i/60>=1:
        y = math.floor(i/60)
        i = i - y*60
        z = (math.floor(i/1))
        if y/10>=1 and z/10>=1:
            Label(tk, text=f"00:{y}:{z}").pack()
        elif y/10<1 and z/10>=1:
            Label(tk, text=f"00:0{y}:{i}").pack()
        elif y/10>=1 and z/10<1:
            Label(tk, text=f"00:{y}:0{i}").pack()
        else:
            Label(tk, text=f"00:0{y}:0{i}").pack()
    else:
        if i/10>=1:
            Label(tk, text=f"00:00:{i}").pack()
        else:
            Label(tk, text=f"00:00:0{i}").pack()


    
a = Button(tk,text="start", command=start)
b = Button(tk,text="stop", command=stop)
c = Text(tk)
d = Button(tk,text="enter")
a.pack()
b.pack()
c.pack()
tk.mainloop()