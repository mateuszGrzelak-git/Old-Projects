a = input()
a = [a.split(" ")]
c = 0
for x in a:
    b=len(a[x])
    if b>c:
        c = b
        d = a[x]
print(d)
