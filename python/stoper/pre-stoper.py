import time
from tkinter import *

tk = Tk()
poczatek = 0
koniec = 0
def start():
    global poczatek
    poczatek = list(time.ctime())
    poczatek.remove(":")
    poczatek.remove(":")
    poczatek = poczatek[11:17]
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
        Label(tk, text=f"{x} Godziny").pack()
        i = i - x*3600
        y = math.floor(i/60)
        Label(tk, text=f"{y} Minut").pack()
        i = i - y*60
        z = math.floor(i/1)
        Label(tk, text=f"{z} Sekund").pack()
    elif i/60>=1:
        y = math.floor(i/60)
        Label(tk, text=f"{y} Minut").pack()
        i = i - y*60
        z = (math.floor(i/1))
        Label(tk, text=f"{z} Sekund").pack()
    else:
        Label(tk, text=f"{i} Sekund").pack()

    #Label(tk, text=str(koniec-poczatek)).pack()


    
a = Button(tk,text="start", command=start)
b = Button(tk,text="stop", command=stop)
a.pack()
b.pack()
tk.mainloop()
