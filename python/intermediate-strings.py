my_string = """Hello
World!"""
print(my_string)

char = my_string[0]
#my_string[0] = 'h' to nie działa
print(char)
substring=my_string[1:5]
print(substring)
print()
print(my_string[::-1])
name = "Tom"
greeting = "Hello"
sentence = greeting + " " + name
print(sentence)
for i in greeting:
    print(i)
if 'ell' in greeting:
    print("Yes")
else:
    print("No")
a = '     Hello World     '
a = a.strip()
print(a)
b = "Hello World"
if b.startswith("H"):
    print("Ok")
if b.endswith("World"):
    print("Nice")
print(b.find("el"))
print(b.find("oo"))
print(b.count("l"))
print(b.replace("World", "Mark"))
