import tkinter as tk

window = tk.Tk()
#greeting = tk.Label(text="Hello World!")
"""label = tk.Label(
    text = "Hello Mr",
    fg="white", #foreground
    bg="black", #background
    width=10,
    height=10,
)"""
button = tk.Button(
    text="Click Me!",
    width=25,
    height=5,
    bg="blue",
    fg="yellow"
)
button.pack()
#label.pack()
#greeting.pack()
window.mainloop()

