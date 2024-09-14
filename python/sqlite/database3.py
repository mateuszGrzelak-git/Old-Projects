import sqlite3

#conn = sqlite3.connect(':memory:')

conn = sqlite3.connect('customer3.db')#pod customr.db

#create a cursor
c = conn.cursor()

many_customers = [('Wes','Brown','wes@brown.pl'),
                 ('Steph','Nowak','steph@nowak.pl')]

#create a table
c.executemany("INSERT INTO customers VALUES (?,?,?)", many_customers)
#może być DATABASE, execute dla pojedynczych


print("success")

#Commit our command
conn.commit()

#Close our connection
conn.close()
