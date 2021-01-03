from conexão_sqlsever import visualizar
import eel
from eel import expose
import time
import pyodbc
import os

eel.init('API_WEB_ELL')

@eel.expose
def call_in_js(x):
    print(x)




'''

string_conexao=["DESKTOP-KEIJ2RI","BIGDATA_2020","teste","123"]
conn = pyodbc.connect("Driver={SQL Server Native Client 11.0};Server="+string_conexao[0]+";"
"Database="+string_conexao[1]+";"
"UID="+string_conexao[2]+";"
"PWD="+string_conexao[3]+";")

def visualizar():
    dados=[]
    os.system('cls')
    cursor = conn.cursor()
    cursor.execute("select * from USUARIO")
    for row in cursor:
        eel.call_in_python(str(row))        
          

visualizar()

'''








####################################################################################################################

eel.start('index.html',size = (500,500))