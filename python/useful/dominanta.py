a=input()
c = 0
d = ""
e = 0
f = ""
for x in a:
    for i in a:
        if x==i:
            d = x
            c += 1 
        if e<c:
            print("H")
            e = c
            f = d
            c = 0
        else:
            c = 0
print(f)