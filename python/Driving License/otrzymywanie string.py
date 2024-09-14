my_name = "Eric"
others = ["Adam", "Caroline", "Eric", "Rebecca", "Frank"]
c = 0
for x in others:
    if x==my_name:
        break
    else:
        c+=1
print(c)
