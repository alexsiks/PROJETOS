

import sqlite3
from sqlite3.dbapi2 import Error

def conectar():
    db=sqlite3.connect("bd.db")
    cur=db.cursor()
    cur.execute('''
        create table protocolo(
        id integer primary key,
        Descricao text )
        )''')

    if Error:
        print("Erro de conexão")

conectar()
