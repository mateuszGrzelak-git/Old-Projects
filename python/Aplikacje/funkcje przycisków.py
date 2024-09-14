from tkinter import *

root = Tk()

def myClick():
    myLabel = Label(root, text="Clicked Button!")
    myLabel.pack()

myButton=Button(root, text="Click Me!", command=myClick)#bez nawiasów bo od razu się zrobi 
myButton.pack()

root.mainloop()

