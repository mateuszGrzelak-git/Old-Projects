import time
import math
print("Wymawiałeś przez: ")
c = 0
d = 0
a = list(time.ctime())
a.remove(":")
a.remove(":")
a = a[11:17]

b = ['1','7','2','1','4','0']

e = int(b[0])*10 + int(b[1])
f = int(b[2])*10 + int(b[3])
g = int(b[4])*10 + int(b[5])
h = e*3600 + f*60 + g

i = int(a[0])*10 + int(a[1])
j = int(a[2])*10 + int(a[3])
k = int(a[4])*10 + int(a[5])
l = i*3600 + j*60 + k


r=l-h
if r/3600>=1:
    x = math.floor(r/3600)
    print(f"{x} Godziny")
    r = r - x*3600
    y = math.floor(r/60)
    print(f"{y} Minut")
    r = r - y*60
    z = math.floor(r/1)
    print(f"{z} Sekund")
elif r/60>=1:
    y = math.floor(r/60)
    print(f"{y} Minut")
    r = r - y*60
    z = (math.floor(r/1))
    print(f"{z} Sekund")
else:
    print(f"{r} Sekund")

 
