import math
a = input()
b = len(a)/2
if b%1==0:
    c = math.ceil(b)
    d = math.floor(b)
    e = c+d/2
else:
    e = a[math.ceil(b)]
print(e)