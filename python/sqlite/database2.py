import sqlite3

#conn = sqlite3.connect(':memory:')

conn = sqlite3.connect('customer2.db')#pod customr.db

#create a cursor
c = conn.cursor()

#create a table
c.execute("INSERT INTO customers VALUES ('Janusz', 'Nosacz', 'somsiad@.pl')")
#może być DATABASE


print("success")

#Commit our command
conn.commit()

#Close our connection
conn.close()
