from tkinter import *

root = Tk()

e=Entry(root, width=50, borderwidth=5)
e.pack()
e.insert(0, "Enter Something: ")

def myClick():
    myLabel = Label(root, text=e.get())
    myLabel.pack()

myButton=Button(root, text="Enter Something", command=myClick)#bez nawiasów bo od razu się zrobi 
myButton.pack()

root.mainloop()

